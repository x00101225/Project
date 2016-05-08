using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.Entities;
using Project2.Repository;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Project2.Hubs
{
    [HubName("postHub")]
    public class PostHub : Hub
    {
        public Task Like(string postId)
        {
            var likePost = SaveLike(postId);
            return Clients.All.updateLikeCount(likePost);
        }
        private LikePost SaveLike(string id)
        {
            var postId = int.Parse(id);
            var baseContext = Context.Request.GetHttpContext();
            var postRepository = new PostRepository();
            var item = postRepository.GetById(postId);
            var liked = new PostLike
            {
                IPAddress = baseContext.Request.UserHostAddress,
                PostId = item.Id,
                UserAgent = baseContext.Request.UserAgent,
                UserLike = true
            };
            var dupe = item.PostLikes.FirstOrDefault(e => e.IPAddress == liked.IPAddress);
            if (dupe == null)
            {
                item.PostLikes.Add(liked);
            }
            else
            {
                dupe.UserLike = !dupe.UserLike;
            }
            postRepository.SaveChanges();
            var post = postRepository.GetById(postId);

            return new LikePost
            {
                LikeCount = post.PostLikes.Count(e => e.UserLike)
            };
        }

    }
}

//REF:
//www.danylkoweb.com/Blog/how-to-make-your-own-real-time-like-button-using-aspnet-mvc-jquery-and-signalr-QF
//github.com/jdanylko/LikeButtonDemo