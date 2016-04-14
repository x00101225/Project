using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace Project2.Models
{
    public class Vote
    {
        public int VoteId { get; set; }
        public int Value { get; set; }
        public string Sugesstion { get; set; }
        public string UserId { get; set; }
    }
}