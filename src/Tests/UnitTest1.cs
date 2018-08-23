using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CsvHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{




    public class naam {
        public string voornaam {get;set;}
        public bool geslacht {get;set;}

        public string achternaam {get;set;}
    }

    public class Adres {
        public string straatnaam {get;set;}
        public int huisnummer {get;set;}
        public string huisletter {get;set;}

        public string toevoeging {get;set;}

        public string woonplaats {get;set;}

        public string postcode {get;set;}

    }

    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void can_select_a_random_record_from_city()
        {
            var csv = new CsvReader(new StreamReader("../../../inspireadressen.csv"));
            var result = csv.GetRecords<Adres>();

            var r = (from p in result where p.woonplaats=="Haarlem" orderby Guid.NewGuid() select p).FirstOrDefault();
        }

        [TestMethod]
        public void can_select_a_random_record_from_first_names()
        {
            var csv = new CsvReader(new StreamReader("../../../voornamen.csv"));
            csv.Configuration.HeaderValidated=null;
            csv.Configuration.MissingFieldFound=null;
            var result = csv.GetRecords<naam>();
            var r = (from p in result select p).Skip(new Random().Next(9754)).FirstOrDefault();
            var l = r.voornaam.Split(' ');
            r.voornaam=l[0];
            r.geslacht=l[1]=="(V)";
        }

        [TestMethod]
        public void can_select_a_random_record_from_last_names()
        {
            var csv = new CsvReader(new StreamReader("../../../achternamen.csv"));
            csv.Configuration.HeaderValidated=null;
            csv.Configuration.MissingFieldFound=null;
            var result = csv.GetRecords<naam>();
            var r = (from p in result select p).Skip(new Random().Next(100)).FirstOrDefault();
        }
    }
}