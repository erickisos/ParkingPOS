using System;
using System.Data;
using Mono.Data.Sqlite;

namespace ParkingPOS
{
	public class SQLConnection
	{
		// string connectionString = "URI=file:POS.db";
		SqliteConnection db = null;
		SqliteCommand dbcmd = null;
		SqliteDataReader rdr = null;

		public SQLConnection (string connectionString)
		{
			db = new SqliteConnection (connectionString);
			db.Open ();
			dbcmd = new SqliteCommand (db);
		}

		public bool executeQuery(string text)
		{
			try{
				dbcmd.CommandText = text;
				dbcmd.ExecuteNonQuery ();
				return true;
			}
			catch(SqliteException ex) 
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
			catch(SqliteException ex) {
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
			catch(SqliteException ex) {
				Console.WriteLine ("SQLError: {0}", ex.Message);
				return "";
			}
			catch(Exception exc) {
				Console.WriteLine ("Error: {0}", exc.Message);
				return "";
			}
		}

		public long getLastTicket()
		{
			long folio = 0;
			try{
				dbcmd.CommandText = String.Format("SELECT * FROM ");
				return folio;
			}
			catch(SqliteException ex) {
				return null;
			}
		}

		~SQLConnection()
		{
			dbcmd.Dispose ();
			db.Close ();
		}
	}
}