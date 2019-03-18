using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonSearch.Models
{
    public class PersonRecord
    {
        public Person Person { get; set; }
        public Address Address { get; set; }
        public Picture Picture { get; set; }
    }
}
