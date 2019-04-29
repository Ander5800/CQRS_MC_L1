namespace CQRSL1.Domain
{
    public class CreateTeacherCommand : IMessage
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public string PostalAddress { get; protected set; }
        public string City { get; protected set; }
        public string State { get; protected set; }
        public string PostalCode { get; protected set; }
        public string DepartmentName { get; protected set; }
    }
}
