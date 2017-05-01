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
			rdr = new SqliteDataReader ();
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

		public string getValues(string table, string column, string keyValue)
		{
			try{
				dbcmd.CommandText = String.Format("SELECT * FROM {0} WHERE {1} = {2}", table, column, keyValue);
				rdr = dbcmd.ExecuteReader();
				while(rdr.Read())
				{
					Console.WriteLine("Vale verga, regreso esto: {0}", rdr.GetFieldType(0));
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