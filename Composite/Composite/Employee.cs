using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	class Employee
	{
		private string name;
		private string department;
		private int salary;
		private List<Employee> subordinates;

		public Employee(string name, string department, int salary)
		{
			this.name = name;
			this.department = department;
			this.salary = salary;
			subordinates = new List<Employee>();
		}

		public void addSubordinate(Employee employee)
		{
			subordinates.Add(employee);
		}

		public void removeSubordinate(Employee employee)
		{
			subordinates.Remove(employee);
		}

		public List<Employee> getSubordinates()
		{
			return subordinates;
		}

		public override string ToString()
		{
			return department+ ":: " + name+ ", salary: " + salary;
		}
	}
}