namespace Model
{
    public class Officer : Customer, IEntity
    {
        public override decimal Price
        {
            get { return (decimal)0.8; }
        }
    }
}
