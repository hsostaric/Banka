﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace BankaHS.BLL.OstaleKlase
{
    public class Tecaj
    {
        [JsonProperty(PropertyName = "Broj tečajnice")]
        public int BrojTecajnice { get; set; }
        [JsonProperty(PropertyName = "Datum primjene")]
        public string DatumPrimjene { get; set; }
        [JsonProperty(PropertyName = "Država")]
        public string Drzava { get; set; }
        [JsonProperty(PropertyName = "Šifra valute")]
        public string SifraValute { get; set; }
        [JsonProperty(PropertyName = "Valuta")]
        public string Valuta { get; set; }
        [JsonProperty(PropertyName = "Jedinica")]
        public int Jedinica { get; set; }
        [JsonProperty(PropertyName = "Kupovni za devize")]
        public string KupovniZaDevize { get; set; }
        [JsonProperty(PropertyName = "Srednji za devize")]
        public string SrednjiZaDevize { get; set; }
        [JsonProperty(PropertyName = "Prodajni za devize")]
        public string ProdajniZaDevize { get; set; }
        public Tecaj()
        {

        }

        public static List<Tecaj> DohvatiRESTPodatke(string uri)
        {

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.Method = "GET";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            string podaci = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            return JsonConvert.DeserializeObject<List<Tecaj>>(podaci);
        }

    }
}