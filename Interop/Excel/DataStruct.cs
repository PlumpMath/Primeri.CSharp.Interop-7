using System;
using System.Collections.Generic;

namespace Excel
{
	public class DataStruct
	{
		public List<DataRow> table = new List<DataRow>();

		public DataStruct()
		{
		}

		public void addRow(string _fname, string _lname, string _age)
		{
			table.Add( new DataRow(_fname,_lname,_age) );
		}

		public void printTable()
		{
			try
			{

				foreach ( DataRow row in table )
				{
					Console.WriteLine( row.firstName +" "+ row.lastName +", "+ row.age );
				}

			}
			catch
			{
			}

		}

	}

	public class DataRow
	{
		private string _firstName = "";
		private string _lastName = "";
		private string _age = "";

		public DataRow(string __firstNme, string __lastNme, string __age)
		{
			_firstName = __firstNme;
			_lastName = __lastNme;
			_age = __age;
		}

		public string firstName
		{
			set { _firstName = value; }
			get { return _firstName;}
		}

		public string lastName
		{
			set { _lastName = value; }
			get { return _lastName; }
		}

		public string age
		{
			set { _age = value; }
			get { return _age; }
		}
	}


}

