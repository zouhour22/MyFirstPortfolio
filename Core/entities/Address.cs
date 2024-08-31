using System;
using System.Collections.Generic;
using System.Text;

namespace Core.entities
{
    public class Address : EntityBase
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
    }
}
