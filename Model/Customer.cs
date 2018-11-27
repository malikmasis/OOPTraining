namespace Model
{
    public class Customer: ICustomer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        private decimal discount;
        public virtual decimal Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }
    }
}
