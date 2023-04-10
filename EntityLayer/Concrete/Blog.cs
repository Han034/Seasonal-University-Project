using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } //Bloğa Category Türü atadık
        public int WriterId { get; set; }
        public Writer writer { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
