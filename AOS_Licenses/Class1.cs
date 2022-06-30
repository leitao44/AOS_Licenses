using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace AOS_Licenses
{
    public class Empresa
    {
            public Empresa(string json)
            {
                JObject jObject = JObject.Parse(json);
                JToken jEmpresa = jObject["empresa"];
                tag0 = (string)jEmpresa["Tag0"];
                tag1 = (string)jEmpresa["Tag1"];
                tag2 = (string)jEmpresa["Tag2"];
                tag3 = (string)jEmpresa["Tag3"];
                tag4 = (string)jEmpresa["Tag4"];
                tag5 = (string)jEmpresa["Tag5"];
                tag6 = (string)jEmpresa["Tag6"];
                tag7 = (string)jEmpresa["Tag7"];
                tag8 = (string)jEmpresa["Tag8"];
                tag9 = (string)jEmpresa["Tag9"];
                tag10 = (string)jEmpresa["Tag10"];
                tag11 = (string)jEmpresa["Tag11"];
                tag12 = (string)jEmpresa["Tag12"];
                tag13 = (string)jEmpresa["Tag13"];
                tag14 = (string)jEmpresa["Tag14"];
                tag15 = (string)jEmpresa["Tag15"];
                tag16 = (string)jEmpresa["Tag16"];
                tag17 = (string)jEmpresa["Tag17"];
                tag18 = (string)jEmpresa["Tag18"];
                tag19 = (string)jEmpresa["Tag19"];
                tag20 = (string)jEmpresa["Tag20"];
                tag21 = (string)jEmpresa["Tag21"];
                tag22 = (string)jEmpresa["Tag22"];
                tag23 = (string)jEmpresa["Tag23"];
                tag24 = (string)jEmpresa["Tag24"];
                tag25 = (string)jEmpresa["Tag25"];
                tag26 = (string)jEmpresa["Tag26"];
                tag27 = (string)jEmpresa["Tag27"];
                tag28 = (string)jEmpresa["Tag28"];
                tag29 = (string)jEmpresa["Tag29"];
                tag30 = (string)jEmpresa["Tag30"];
            }

            public int Id { get; set; }
            public string nomeEmpresa { get; set; }
            public string localizacao { get; set; }
            public string tag0 { get; set; }
            public string tag1 { get; set; }
            public string tag2 { get; set; }
            public string tag3 { get; set; }
            public string tag4 { get; set; }
            public string tag5 { get; set; }
            public string tag6 { get; set; }
            public string tag7 { get; set; }
            public string tag8 { get; set; }
            public string tag9 { get; set; }
            public string tag10 { get; set; }
            public string tag11 { get; set; }
            public string tag12 { get; set; }
            public string tag13 { get; set; }
            public string tag14 { get; set; }
            public string tag15 { get; set; }
            public string tag16 { get; set; }
            public string tag17 { get; set; }
            public string tag18 { get; set; }
            public string tag19 { get; set; }
            public string tag20 { get; set; }
            public string tag21 { get; set; }
            public string tag22 { get; set; }
            public string tag23 { get; set; }

            public string tag24 { get; set; }
            public string tag25 { get; set; }
            public string tag26 { get; set; }
            public string tag27 { get; set; }
            public string tag28 { get; set; }
            public string tag29 { get; set; }
            public string tag30 { get; set; }





        }
    }
