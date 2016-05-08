using System.Collections.Generic;
using System.Data.Entity;
using Project2.Entities;
using Project2.Repository;

namespace LikeButtonDemo.Repository
{
    public class PostLikeRepository : Repository<PostLike>
    {
        public PostLikeRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<PostLike> GetByPostId(int id)
        {
            return Find(e => e.PostId == id);
        }

        public bool Exists(int postId, string ipAddress)
        {
            var result = First(e => e.PostId == postId && e.IPAddress == ipAddress);
            return result != null;
        }

        public int CountByPostId(int id)
        {
            return Count(e => e.PostId == id);
        }
    }
}
//REF:
//www.danylkoweb.com/Blog/how-to-make-your-own-real-time-like-button-using-aspnet-mvc-jquery-and-signalr-QF
//github.com/jdanylko/LikeButtonDemo