using Core.Entity.Base;

namespace Core.Entity
{
    public class Payment : Base_Entity
    {
        public string Payment_Name { set; get; }
        public string Payment_Description { set; get; }
        public bool Payment_Status { set; get; }

        public Payment():base()
        {

        }
    }
}
