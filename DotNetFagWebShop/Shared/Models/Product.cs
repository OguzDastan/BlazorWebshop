using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFagWebShop.Shared.Models
{
    public class Product : BaseModel
    {
        // all props
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime Created { get; set; }
        public double Price { get; set; }

        // FK key for category
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


        // empty constructor
        public Product()
        {

        }
    }
}
