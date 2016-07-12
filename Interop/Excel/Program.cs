using System;

namespace Excel
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			DataStruct data = new DataStruct();
			IOWrite write = new IOWrite( data );

			//Набиране на данни в основната таблица
			data.addRow("Диана","Ситева","58");
			data.addRow("Лилия", "Дацева", "33");

			//Проверка на таблицата
			data.printTable();

			write.exportTable();
			//write.runFile();

			
		}
	}
}
