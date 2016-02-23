using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project2.Models;

namespace Project2.Models
{
    public class Create
    {
        public IEnumerable<Contact> Contact { get; set; }
        public RegisterViewModel Register { get; set; }
    }
}