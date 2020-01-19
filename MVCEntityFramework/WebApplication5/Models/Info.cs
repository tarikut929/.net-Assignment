using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Info
    {
        public int InforId { get; set; }
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; }


    }
}
