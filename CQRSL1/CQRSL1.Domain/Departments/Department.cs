namespace CQRSL1.Domain
{
    public class Department : Aggregate
    {
        public string Name { get; protected set; }

        protected Department()
        {

        }

        public static Department createNew(string name)
        {
            return new Department
            {
                Name = name
            };
        }
    }
}
