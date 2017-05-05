using System;
using System.Data;
using System.Data.SQLite;

namespace ParkingPOS
{
	public class SQLConnection
	{
		// string connectionString = "URI=file:POS.db";
		SQLiteConnection db = null;
		SQLiteCommand dbcmd = null;
		SQLiteDataReader rdr = null;

		public SQLConnection (string connectionString)
		{
			db = new SQLiteConnection(connectionString);
			db.Open ();
			dbcmd = new SQLiteCommand(db);
		}

		public bool executeQuery(string text)
		{
			try{
				dbcmd.CommandText = text;
				dbcmd.ExecuteNonQuery ();
				return true;
			}
			catch(SQLiteException ex) 
			{
				Console.WriteLine ("Error: {0}", ex.ErrorCode);
				return false;
			}
		}

		public void getValues(string table, string column, string keyValue)
		{
			try{
				dbcmd.CommandText = String.Format("SELECT * FROM {0} WHERE {1} = {2}", table, column, keyValue);
				rdr = dbcmd.ExecuteReader();
				while(rdr.Read())
				{
					Console.WriteLine("Vale verga, regreso esto: {0}", rdr.GetFieldType(0));
				}
			}
			catch(SQLiteException ex) {
				Console.WriteLine ("Error: {0}", ex.ErrorCode);
			}
		}

		public string getPassword(string user)
		{
			try{
				dbcmd.CommandText = String.Format("SELECT password FROM login WHERE VENDEDOR = \"{0}\"", user);
				rdr = dbcmd.ExecuteReader();
				string passwd = "";
				int i = 0;
				while(rdr.Read())
				{	
					Console.WriteLine("Reading... {0}", i);
					passwd = String.Format("{0}", rdr["password"]);
					i++;
				}
				rdr = null;
				return passwd;
			}
			catch(SQLiteException ex) {
				Console.WriteLine ("SQLError: {0}", ex.Message);
				return "";
			}
			catch(Exception exc) {
				Console.WriteLine ("Error: {0}", exc.Message);
				return "";
			}
		}

		public string getLastTicket()
		{
			string folio = "";
			try{
				dbcmd.CommandText = String.Format("SELECT * FROM ");
				return folio;
			}
			catch(SQLiteException ex) {
				Console.WriteLine("{0}", ex.Message);
				return null;
			}
		}

		public void writeTicket(string folio, int tipo, float costo)
		{
			string caseta;
			string fecha;
			string hora;
			string current_number;
			if (folio.Length == 18)
			{
				caseta = folio.Substring(0, 1);
				current_number = folio.Substring(1, 8);
				hora = folio.Substring(9, 2) + ":" + folio.Substring(11, 2);
				fecha = folio.Substring(13, 2) + "/" + folio.Substring(15, 2) + "/" + folio.Substring(17, 2);
				try
				{
					string query = String.Format("INSERT INTO ventas VALUES({0}, {1}, {2}, {3}, {4}, {5});", folio, hora, fecha, caseta, tipo, costo);
					executeQuery(query);
				}
				catch (SQLiteException ex)
				{
					ErrorDialog errord = new ErrorDialog(ex.Message);
					Console.WriteLine("Error: {0}", ex.Message);
				}
			}
		}

		~SQLConnection()
		{
			dbcmd.Dispose ();
			db.Close ();
		}
	}
}