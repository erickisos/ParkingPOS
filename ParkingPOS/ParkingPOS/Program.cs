using System;
using Gtk;
using Mono.Data.Sqlite;

namespace ParkingPOS
{
	class MainClass
	{
		public SQLConnection conn = null;
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
		
		public static void Main (string[] args)
		{
			SQLConnection conn = new SQLConnection ("URI=file:POS.db");
			conn.executeQuery (creatorStringSql);
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
