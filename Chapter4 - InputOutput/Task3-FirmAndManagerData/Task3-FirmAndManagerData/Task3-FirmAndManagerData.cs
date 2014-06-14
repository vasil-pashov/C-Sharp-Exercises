using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_FirmAndManagerData
{
	class Task3_FirmAndManagerData
	{
		static void Main(string[] args)
		{
			//Task firm has name, address, thelephone number, fax, e-mail and a manager. The manager has name, surname and telephone. Write program that takes the data and prints it out;
			string firmName, firmAddress, firmEmail, managerName, managerSurname;
			int firmTelephone, firmFax, managerTelephone;
			Console.WriteLine("Input firm name");
			firmName = Console.ReadLine();
			Console.WriteLine("Input firm address");
			firmAddress= Console.ReadLine();
			Console.WriteLine("Input firm telephone number");
			firmTelephone = int.Parse(Console.ReadLine());
			Console.WriteLine("Input firm fax number");
			firmFax = int.Parse(Console.ReadLine());
			Console.WriteLine("Input firm e-mail");
			firmEmail = Console.ReadLine();
			Console.WriteLine("Input firm manager name");
			managerName = Console.ReadLine();
			Console.WriteLine("Input manager surname");
			managerSurname = Console.ReadLine();
			Console.WriteLine("Input the manager telephone number");
			managerTelephone = int.Parse(Console.ReadLine());
			Console.WriteLine("The firm name is {0}, it is situated at {1}.", firmName, firmAddress);
			Console.WriteLine("Contacts: Telephone number: {0}, fax: {1}, Email: {2}", firmTelephone, firmFax, firmEmail);
			Console.WriteLine("Manager info\n Name {0} {1}\n Telephone number: {2}", managerName, managerSurname, managerTelephone);
		}
	}
}
