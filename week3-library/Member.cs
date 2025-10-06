using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_library
{
    internal class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;
    
        // Public properties
        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; } // Private setter makes it read-only
        }
        public string Name
        {
            get { return name; }  // get method
            set { name = value; } // set method
        }
        public string Address
        {
            get { return address; }  // get method
            set { address = value; } // set method
        }
        public int Phone
        {
            get { return phone; }  // get method
            set { phone = value; } // set method
        }

        // Constructor for new member
        public Member(int memberId, string name, string address, int phone)
        {
            this.MemberId = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone number: {Phone}");
            Console.WriteLine();
        }
    } 
}
