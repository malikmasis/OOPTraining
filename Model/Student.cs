namespace Model
{
    public class Student : Customer, IEntity
    {
        public override decimal Price
        {
            get { return (decimal)0.9; }
        }
    }
}
