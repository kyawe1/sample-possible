using Core.Entity.Base;

namespace Core.Entity
{
    public class OrderDetail : Base_Entity
    {
        public string Order_ID { set; get; }
        public string Product_ID { set; get; }
        public int Quentity { set; get; }

        public OrderDetail() : base()
        {

        }
    }
}
