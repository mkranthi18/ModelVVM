using System;
using SQLite.Net;

namespace ModelVVM.Model
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
