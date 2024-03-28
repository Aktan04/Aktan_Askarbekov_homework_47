namespace Hw47;

public class Employee
{ 
    [MyPropertyInfo("Имя сотрудника")]
    public string Name { get; set; }

    [MyPropertyInfo( "Опыт работы")]
    public int Experience { get; set; }
}