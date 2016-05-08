using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Entities
{
    [DataContract]
    public class LikePost
    {
        [DataMember]
        public int LikeCount { get; set; }
    }
}

//REF:
//www.danylkoweb.com/Blog/how-to-make-your-own-real-time-like-button-using-aspnet-mvc-jquery-and-signalr-QF
//github.com/jdanylko/LikeButtonDemo