using Core.Entity.Base;
namespace Core.Entity
{
    public class Enterprise : Base_Entity
    {
        public string Entriprise_Name { set; get; }
        public string Tax_id { set; get; }
        public string PIC { set; get; }
        public string registered_address { set; get; }
        public string business_address { set; get; }
        public string registered_phonenumber { set; get; }
        public string business_phonenumber { set; get; }

        public Enterprise() : base()
        {

        }
    }
}
