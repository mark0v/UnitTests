using DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    class DBTest
    {
        [Test]
        public void TestDBConnectivity()
        {
            getAddressFromDB();
        }

        [Test]
        public void TestDBConnectivity2()
        {
            getAddressFromDB();
        }
        public List <String> getAddressFromDB()
        {
            using (AdventureWorksLT2012 db = new AdventureWorksLT2012())
            {
                var Addresses = db.Addresses.Select(x => x).ToList();
                List<String> adr = new List<string>();
                foreach (var address in Addresses)
                {
                    adr.Add(address.AddressLine1);
                    Console.WriteLine("Address :  " + address.AddressLine1);
                }                
                return adr;
            }
            
        }


    }
}
