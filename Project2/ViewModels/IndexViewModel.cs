using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.Entities;

namespace Project2.ViewModels
{
    public class IndexViewModel
    {
        public Post Post { get; set; }
        public int PostLikes { get; set; }
    }
}
//REF:
//www.danylkoweb.com/Blog/how-to-make-your-own-real-time-like-button-using-aspnet-mvc-jquery-and-signalr-QF
//github.com/jdanylko/LikeButtonDemo