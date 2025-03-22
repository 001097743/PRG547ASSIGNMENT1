using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547ASSIGNMENT1
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Address Address { get; set; }

        /// <summary>
        /// All Arg Person
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="email">Email</param>
        /// <param name="phoneNumber">Phone Number</param>
        /// <param name="address">Address Class</param>
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        /// <summary>
        /// Partial Arg Person
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="email">Email</param>
        /// <param name="phoneNumber">Phone Number</param>
        public Person(string name, string email, string phoneNumber) : this(name, email, phoneNumber, new Address()) {}

        public override string ToString()
        {
            return $"\n" +
                $"[Person]\n" +
                $"Name: {Name}\n" +
                $"Email: {Email}\n" +
                $"Phone Number: {PhoneNumber}\n" +
                $"{Address}\n" +
                $"";
        }
    }
}
