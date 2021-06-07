using System;
using System.Globalization;

public class Employee {
	public int Id {get; private set;}
	public string name;
    public double Salary {get; private set;}

    public Employee(int id, string name, double salary) {
		Id = id;
		this.name = name;
		Salary = salary;
	}

	public void IncreaceSalary(double perc) {
		Salary += Salary * perc;
	}

	public string Name { 
		get { return name; }
		set {
			if (name != null && name.Length > 1) {
				name = value;
			}
		}
	}

    public override string ToString() {
		return Id + ", " + name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture) ;
    }
}
