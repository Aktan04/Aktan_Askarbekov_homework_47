﻿using Hw47;

Employee employee = new Employee { Name = "Ivanov Ivan", Experience = 5 };
MySerializer<Employee> employeeSerializer = new MySerializer<Employee>(employee);
string serializedEmployeeT = employeeSerializer.SerializeObject(employee);
Console.WriteLine(serializedEmployeeT);
string serializedEmployee = employeeSerializer.Serialize();
Console.WriteLine(serializedEmployee);
   


