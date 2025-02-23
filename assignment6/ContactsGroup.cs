using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
	public class ContactsGroup : List<Contacts>
	{
		public string GroupName { get; set; }
		public ContactsGroup(string groupName, List<Contacts> contact) : base(contact)
		{
			GroupName = groupName;
		}
	}
}
