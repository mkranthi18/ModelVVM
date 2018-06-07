using System;
using SQLite.Net;

namespace ModelVVM.Services
{
    public interface Isqlite
    {
		SQLiteConnection GetConnection();
    }
}
