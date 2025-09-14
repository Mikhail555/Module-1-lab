using System;
using System.Collections.Generic;

// Сотрудник
abstract class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Position { get; set; }

    // Подсчет зп 
    public abstract double CalculateSalary();

    public override string ToString() => $"ID: {Id}, {Name}, {Position}";
}

// Рабочий
class Worker : Employee
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }
    public override double CalculateSalary() => HourlyRate * HoursWorked;
}

// Менеджер
class Manager : Employee
{
    public double FixedSalary { get; set; }
    public double Bonus { get; set; }
    public override double CalculateSalary() => FixedSalary + Bonus;
}

class Program
{
    static void Main()
    {
        // Список сотрудников
        var employees = new List<Employee>
        {
            new Worker { Id = 1, Name = "Михаил", Position = "Рабочий", HourlyRate = 500, HoursWorked = 160 },
            new Manager { Id = 2, Name = "Сергей", Position = "Менеджер", FixedSalary = 50000, Bonus = 15000 }
        };

        // Вывод зп
        foreach (var emp in employees)
            Console.WriteLine($"{emp} | Зарплата: {emp.CalculateSalary()}");
    }
}


// Вывод

// Наследование → Worker, Manager ← Employee.
// Полиморфизм → метод CalculateSalary() разный у рабочего и менеджера.
