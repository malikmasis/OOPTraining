namespace Model
{
    public class Officer : Customer, IEntity
    {
        public override decimal Discount
        {
            get { return (decimal)0.8; }
        }
    }
}
