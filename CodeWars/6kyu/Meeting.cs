using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace CodeWars._6kyu
{
	public class JohnMeeting
	{
		internal void Solve()
        {
            var s = "Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn";
			string result = Meeting(s);

			Console.WriteLine(result);
		}
		public static string Meeting(string s)
		{
			s = s.ToUpper();
			var names = s.Split(";");
			List<(string lastname, string firstname)> parsedNames = new List<(string lastname, string firtname)>();
            foreach (var n in names)
            {
				var x = n.Split(":");
				parsedNames.Add((x[1], x[0]));
            }

			var sortednames = parsedNames.OrderBy(x => x.lastname).ThenBy(x => x.firstname);
		

			var result = "";
            foreach (var item in sortednames)
            {
				result += $"({item.lastname}, {item.firstname})";
            }
			return result;	
            
		}

       
    }
}
