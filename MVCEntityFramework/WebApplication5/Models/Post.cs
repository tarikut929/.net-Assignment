using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string PostDate { get; set; }

        public int InfoId { get; set; }
        public virtual Info Info { get; set; }



    }
}
