using System.Data.Entity;
using Project2.Entities;

namespace Project2.Repository
{
    public class PostRepository: Repository<Post>
    {
        public PostRepository(): this(new BlogEntities()) { }
        public PostRepository(DbContext context) : base(context)
        {
        }

        public Post GetById(int id)
        {
            return First(e => e.Id == id);
        }
    }
}
//REF:
//www.danylkoweb.com/Blog/how-to-make-your-own-real-time-like-button-using-aspnet-mvc-jquery-and-signalr-QF
//github.com/jdanylko/LikeButtonDemo