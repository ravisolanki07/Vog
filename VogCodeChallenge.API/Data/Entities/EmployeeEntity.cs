namespace VogCodeChallenge.API.Data.Entities
{
    public class EmployeeEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string MailingAddress { get; set; }

        public DepartmentEntity Department { get; set; }
    }
}