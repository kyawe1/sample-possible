using Core.Entity.Base;

namespace Core.Entity
{
    public class InventoryControl : Base_Entity
    {
        public string Outlet_ID { set; get; }
        public string Product_ID { set; get; }
        public int Quentity { set; get; }

        public InventoryControl() : base()
        {

        }
    }
}
