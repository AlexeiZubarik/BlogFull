using Blog.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Blog
{
    public class PostDao : IPostDAO
    {
        private const string body =
            "Validate XHTML & CSS. Mauris venenatis quam non nunc convallis tincidunt. Aliquam tempus neque nec nisl pellentesque nec dignissim lorem cursus. Integer cursus ultrices massa non vehicula. Etiam vitae lacus eu arcu rutrum fermentum. Nullam fringilla imperdiet magna, id sagittis nisl feugiat at. Donec eget lacus eros, et blandit odio. Maecenas et urna vitae sapien dictum dapibus. Aliquam id sem metus. Aenean sapien felis, congue porttitor elementum quis, pretium sit amet urna. Vestibulum eget ligula et ipsum laoreet aliquam sed ut risus. Nulla facilisi. Phasellus nibh justo, lobortis nec vehicula sit amet, cursus vitae ligula.";
        public ICollection<Post> Load(int skip, int take)
        {
            var result = new Collection<Post>();
            for(int i = 0; i < take; i++)
            {
                result.Add(new Post() { Body = body, DateCreated = DateTime.Now.AddDays(-1), Title = "Aliquam lorem ante dapibus in viverra" + i});
            }
            return result;
        }
    }
}