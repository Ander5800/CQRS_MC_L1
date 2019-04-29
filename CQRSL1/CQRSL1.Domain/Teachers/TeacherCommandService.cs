namespace CQRSL1.Domain
{
    public interface ITeacherCommandService : IStartsWithMessage<CreateTeacherCommand>
    { }



    public class TeacherCommandService : ITeacherCommandService
    {
        private readonly IDbContext _context;


        public TeacherCommandService(IDbContext context)
        {
            _context = context;
        }

        public void Start(CreateTeacherCommand command)
        {
            Teacher teacher = Teacher.CreateNew(
                command.Name,
                command.LastName,

                Address.CreateNew(
                    command.PostalAddress,
                    command.City,
                    command.State,
                    command.PostalCode
                    ),

                Department.createNew(command.DepartmentName)
            );

            _context.Add(teacher);

            _context.SaveChanges();

            //raise NewTeacherCreatedEvent
        }
    }
}
