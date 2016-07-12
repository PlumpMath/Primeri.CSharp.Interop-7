using System;
using InteropExcel = Microsoft.Office.Interop.Excel;

namespace Excel
{
	public class IOWrite
	{

		private DataStruct _data;
		private InteropExcel.Application excel;

		public IOWrite( DataStruct data )
		{
			

			Console.WriteLine("excell=" + excel + getPath());

		}

		public bool exportTable()
		{
			try
			{
				//Междинни проверки
				excel = new InteropExcel.ApplicationClass();
				if (excel == null) return false;

				//Подготовка
				excel.Visible = false;

				InteropExcel.Workbook workbook = excel.Workbooks.Add();
				if (workbook == null) return false;

				InteropExcel.Worksheet sheet = (InteropExcel.Worksheet) workbook.Worksheets[1];
				sheet.Name = "Таблица 1";

				//Попълване на таблицата



				//Запаметяване и затваряне
				workbook.SaveCopyAs( getPath() );
				excel.DisplayAlerts = false;    //Изключване на съобщения от Excel
				workbook.Close();
				excel.Quit();
				return true;
			}catch{
			}
			return false;
		}

		public void addRow(DataRow _row)
		{
			try
			{


			}
			catch
			{
			}

		}


		public void runFile()
		{
			try
			{
				System.Diagnostics.Process.Start(getPath());
			}
			catch
			{
			}
		}


		private string getPath()
		{
			return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Table1.xlsx");
		}


	}
}

