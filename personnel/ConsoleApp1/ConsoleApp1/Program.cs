using System;
using System.Collections.Generic;
public class Employee
{
    // protected permet l'accès depuis une classe dérivée
    protected string name;

    public Employee(string name)
    {
        Console.WriteLine("Employee constructor");
        this.name = name;
    }

    public void Show()
    {
        Console.WriteLine("Employee Name : " + name);
    }
}

public class Manager : Employee
{
    private string _department;
    // :base(...) permet de transmettre le paramètre requis
    // par le constructeur de la classe de base
    public Manager(string name, string department) : base(name)
    {
        Console.WriteLine("Manager constructor");
        _department = department;
    }

    // le mot clef "new" permet de créer une méthode propre à la classe Manager
    public new void Show()
    {
        Console.WriteLine("Manager Name : " + name);
        Console.WriteLine("Department : " + _department);
    }
}

namespace ConsAppInheritance
{
    class Program
    {

        Employee toto = new Employee("Toto");
        Console.WriteLine(toto);
    }
}
