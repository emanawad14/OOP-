


using Common;

#region Employee
Employee employee1 = new Employee(Guid.NewGuid(), "Eman", security.Guest, 14000, DateTime.Now, "Female");
Employee employee2 = new Employee(Guid.NewGuid(), "Ahmed", security.DBA, 16000, DateTime.Now, "Male");
Employee employee3 = new Employee(Guid.NewGuid(), "Aya", security.Developer, 25000, DateTime.Now, "Female");

Console.WriteLine(employee1);
Console.WriteLine(employee2);
Console.WriteLine(employee3);
#endregion



Console.WriteLine(" *********************Data ****************************");
Console.WriteLine(" *********************Data ****************************");
Console.WriteLine(" *********************Data ****************************");
Console.WriteLine(" *********************Data ****************************");
Console.WriteLine(" *********************Data ****************************");
Console.WriteLine(" *********************Data ****************************");


Hire_Data Data =new Hire_Data(2001 ,8 ,14);
Console.WriteLine(Data);




