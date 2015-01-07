using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Interfaces
{
    public interface IPostDAO
    {
        ICollection<Post> Load(int skip, int take);
    }
}
