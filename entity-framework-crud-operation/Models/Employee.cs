namespace entity_framework_crud_operation.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string DeptName { get; set; }

        public bool IsActive { get; set; }  

        public ICollection<Employee> Employees { get; set; }
    }

    public class Employee
    {
    }

}
