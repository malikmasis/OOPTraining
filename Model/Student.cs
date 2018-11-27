namespace Model
{
    public class Student : Customer, IEntity
    {
        public override decimal Discount
        {
            get { return (decimal)0.9; }
        }
    }
}
