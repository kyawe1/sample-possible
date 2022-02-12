using Core.Entity.Base;

namespace Core.Entity
{
    public class Order : Base_Entity
    {
        public string Order_ID { set; get; }
        public string Employee_ID { set; get; }
        public string Consumer_ID { set; get; }
        public string Payment_ID { set; get; }

        public Order() : base()
        {

        }
    }
}
