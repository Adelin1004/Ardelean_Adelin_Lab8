using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ardelean_Adelin_Lab8.Modes
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
