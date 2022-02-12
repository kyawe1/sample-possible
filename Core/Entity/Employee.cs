using Core.Entity.Base;

namespace Core.Entity
{
    public class Employee : Base_Entity
    {
        public string Employee_Name { set; get; }
        public string Employee_Address { set; get; }
        public string Employee_Phone { set; get; }
        public string Employee_NRC { set; get; }
        public Employee() : base()
        {

        }
    }
}
