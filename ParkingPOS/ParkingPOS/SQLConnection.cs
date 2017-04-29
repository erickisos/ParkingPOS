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
		const string creatorStringSql = "CREATE TABLE IF NOT EXISTS VENTAS(" +
			"FOLIO VARCHAR(8) PRIMARY KEY NOT NULL," +
			"HORA VARCHAR(4) NOT NULL," +
			"FECHA DATE NOT NULL," +
			"BOLETERA CHAR(1) NOT NULL," +
			"TIPO INTEGER NOT NULL," +
			"COSTO REAL NOT NULL" +
			");" +
			"CREATE TABLE IF NOT EXISTS COSTOS(" +
			"TIPO INTEGER PRIMARY KEY," +
			"COSTO REAL NOT NULL," +
			"TOLERANCIA INTEGER" +
			");" +
			"CREATE TABLE IF NOT EXISTS LOGIN(" +
			"VENDEDOR VARCHAR(8) PRIMARY KEY," +
			"PASSWORD VARCHAR(8) NOT NULL" +
			");" +
			"CREATE TABLE IF NOT EXISTS TICKETS(" +
			"FOLIO VARCHAR(8) PRIMARY KEY," +
			"HORA VARCHAR(4) NOT NULL," +
			"FECHA DATE NOT NULL" +
			");";

		public SQLConnection (string connectionString)
		{
			db = new SqliteConnection (connectionString);
			db.Open ();
			dbcmd = new SqliteCommand (db);
			dbcmd.CommandText = creatorStringSql;
			dbcmd.ExecuteNonQuery ();
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

		~SQLConnection()
		{
			dbcmd.Dispose ();
			db.Close ();
		}
	}
}