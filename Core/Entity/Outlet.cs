using Core.Entity.Base;

namespace Core.Entity
{
    public class Outlet : Base_Entity
    {
        public string Outlet_Name { set; get; }
        public string Outlet_Address { set; get; }
        public string Platform { set; get; }
        public Outlet() : base()
        {

        }
    }
}
