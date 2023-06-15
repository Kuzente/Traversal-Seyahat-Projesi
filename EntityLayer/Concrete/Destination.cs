using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination:BaseEntity
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public string CoverImage { get; set; }
        public string Article1 { get; set; }
        public string Quote { get; set; }
        public string Article2Title { get; set; }
        public string Article2 { get; set; }
        public string SmallImage1 { get; set; }
        public string SmallImage2 { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
