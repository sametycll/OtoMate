using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoMate.Domain.Entities
{
    public class Category :BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Araba markası, model gibi alt kategoriler için
        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }

        public ICollection<Category> SubCategories { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
