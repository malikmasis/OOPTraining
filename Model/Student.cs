namespace Model
{
    public class Student : Customer, IEntity
    {
        public override decimal Price
        {
            get { return 3; }
        }
    }
}
