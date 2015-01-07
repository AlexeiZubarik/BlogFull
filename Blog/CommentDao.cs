using Blog.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Blog
{
    public class CommentDao : ICommentDao
    {
        public ICollection<Comment> LoadByPostTitle(string postTitle)
        {
            var result = new Collection<Comment>();
            var commentsCount = new Random().Next(0, 100);
            for(int i = 0; i < commentsCount; i++)
            {
                result.Add(new Comment());
            }
            return result;
        }        
    }
}
