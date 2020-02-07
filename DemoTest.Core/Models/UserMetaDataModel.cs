using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DemoTest.Core.Models
{
    public class UserMetaDataModel
    {
        public UserMetaDataModel() {}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime  Dob{ get; set; }

        public string StreetAddressLine1 { get; set; }

        public string StreetAddressLine2 { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public BigInteger Income { get; set; }

        public string Occupation { get; set; }

        public int Score { get; set; }
    }
}
