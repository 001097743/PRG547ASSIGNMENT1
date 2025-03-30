using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547ASSIGNMENT1
{
    class Address
    {
        const string DEF_STREET_NUM = "Not provided";
        const string DEF_STREET_NAME = "Not provided";
        const string DEF_SUBURB = "Not provided";
        const string DEF_POSTCODE = "Not provided";
        const string DEF_STATE = "Not provided";
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        public Address(string streetNum, string streetName, string suburb, string postCode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postCode;
            State = state;
        }

        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE) { }

        public override string ToString()
        {
            return $"\n" +
                $"[Address]\n" +
                $"Street Num: {StreetNum}\n" +
                $"Street Name: {StreetName}\n" +
                $"Suburb: {Suburb}\n" +
                $"Postcode: {Postcode}\n" +
                $"State: {State}\n" +
                $"";
        }
    }
}
