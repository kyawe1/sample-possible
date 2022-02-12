using Core.Entity.Base;

namespace Core.Entity
{
    public class Product : Base_Entity
    {
        public string Product_Name { set; get; }
        public string Product_Description { set; get; }
        public float Product_Price { set; get; }
        public Product() : base()
        {

        }
    }
}
