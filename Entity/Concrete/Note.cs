using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Note:BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public int LikedCount { get; set; }
        public bool IsDraft { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
