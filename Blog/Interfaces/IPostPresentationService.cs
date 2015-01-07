using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Interfaces
{
    public interface IPostPresentationService
    {
        ICollection<PostItemViewModel> GetItems(int count); 
    }
}
