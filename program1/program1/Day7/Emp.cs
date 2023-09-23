using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day7
{
    internal class Emp
    {
        public int Eno = 0;
        private readonly Address address;
        public Emp()
        {
            address = new Address(this);
        }
        public Address GetAddress()
        {
            return address;
        }

        public class Address
        {
            public string Address1;
            public string Address2;
            private readonly Emp e1;

            internal Address(Emp outerEmp)
            {
                if (outerEmp == null)
                {
                    throw new NullReferenceException("Outer Emp is NULL!!");
                    e1 = outerEmp;
                }

            }
            public override string ToString()
            {
                return Address1 + "," + Address2 + "of" + e1.Eno;
            }
        }
    }
}
