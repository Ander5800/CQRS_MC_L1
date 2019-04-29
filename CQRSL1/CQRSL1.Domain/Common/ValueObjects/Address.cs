namespace CQRSL1.Domain
{
    public class Address
    {
        public string PostalAddress { get; protected set; }
        public string City { get; protected set; }
        public string State { get; protected set; }
        public string PostalCode { get; protected set; }

        protected Address()
        {

        }

        public static Address CreateNew(string address, string city, string state, string postalCode)
        {
            return new Address()
            {
                PostalAddress = address ?? "",
                City = city ?? "",
                PostalCode = postalCode ?? "",
                State = state ?? "",
            };
        }
    }
}
