using System;
using Xamarin.Forms;
using SQLite.Net;
using ModelVVM;
using System.IO;

[assembly: Dependency(typeof(ModelVVM.Droid.SqliteService))]
namespace ModelVVM.Droid
{
    
    public class SqliteService: Model.ISQLite
    {
        public SqliteService()
        {
        }
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "SQLiteEx.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            Console.WriteLine(path);
            if (!File.Exists(path))
                File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            // Return the database connection 
            return conn;
        }
    }
}
