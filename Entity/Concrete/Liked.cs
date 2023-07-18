using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Liked:BaseEntity
    {
        public int NoteId { get; set; }
        public virtual Note Note { get; set; }

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
