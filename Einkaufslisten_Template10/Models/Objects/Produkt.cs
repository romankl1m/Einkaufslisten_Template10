﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Einkaufslisten_Template10.Models.Objects
{
    public class Produkt:BaseObject
    {   
        private int _anzahl;
        private string _mengenBezeichnung;                      
        public Produkt(int id_item, string name) : base(id_item, name)
        {
        }
        public Produkt(int id_item, string name, int anzahl, string mengenBezeichnung) : this(id_item, name)
        {
            _anzahl = anzahl;
            _mengenBezeichnung = mengenBezeichnung;
        }
        [JsonProperty(PropertyName = "anzahl")]
        public int anzahl
        {
            get => _anzahl; 
            set => _anzahl = value; 
        }
        [JsonProperty(PropertyName = "mengenbezeichnung")]
        public string mengenbezeichnung
        {
            get => _mengenBezeichnung; 
            set => _mengenBezeichnung = value;
        }
        public override string ToString()
        {
            return base.ToString() + " Anzahl = " + _anzahl + " Mengenbezeichnung = " + _mengenBezeichnung;
        }
    }
}