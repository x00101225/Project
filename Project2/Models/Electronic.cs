using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Text;

namespace Project2.Models
{
    public class Electronic
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string SubGenre { get; set; }

        public string Comment { get; set; }

        public string Link { get; set; }

    }
}