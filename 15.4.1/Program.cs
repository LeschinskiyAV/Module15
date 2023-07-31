var departments = new List<Department>()
{
   new Department() {Id = 1, Name = "Программирование"},
   new Department() {Id = 2, Name = "Продажи"}
};
var employees = new List<Employee>()
{
   new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
   new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
   new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
   new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
};
var joined = departments.Join(employees,
    x => x.Id,
    y => y.DepartmentId,
    (x, y) => new { name = y.Name, dep = x.Name });
foreach (var employee in joined)
{
    Console.WriteLine($"Dep:{employee.dep}, empl:{employee.name}");
}
internal class Department
{
    internal int Id { get; set; }
    internal string Name { get; set; }
}
internal class Employee
{
    internal int Id { get; set; }
    internal string Name { get; set; }
    public int DepartmentId { get; set; }
}