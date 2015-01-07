using Blog.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Blog.Interfaces
{
    public class PostPresentationService : IPostPresentationService
    {
        private readonly IPostDAO postDao;
        private readonly ICommentDao commentDao;
        private readonly ILogger logger;

        public PostPresentationService(IPostDAO postDao, ICommentDao commentDao, ILogger logger)
        {
            this.postDao = postDao;
            this.commentDao = commentDao;
            this.logger = logger;
        }
        public ICollection<PostItemViewModel> GetItems(int count)
        {
            var model = new Collection<PostItemViewModel>();
            var posts = postDao.Load(0, count);
            if(posts == null)
            {
                logger.Error("PostDao returned null");
                return model;
            }
            foreach (var post in posts) 
            {
                var commentsCount = post.Comments == null ? 0 : post.Comments.Count();
                model.Add(new PostItemViewModel(post.Title, ExtractShortSummary(post), post.DateCreated, commentsCount));
            }
            return model;
        }

        private string ExtractShortSummary(Post post)
        {
            if(string.IsNullOrWhiteSpace(post.Body))
            {
                return string.Empty;
            }

            if(post.Body.Length <= 50)
            {
                return post.Body;
            }

            return post.Body.Substring(0, 50);
        }
    }
}