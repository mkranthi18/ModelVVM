using System;
using SQLite;
using SQLite.Net;
using SQLite.Net.Attributes;

namespace ModelVVM.Model
{
    public class Employee
    {
        public Employee()
        {
        }

            [PrimaryKey, AutoIncrement]
            public long EmpId
            { get; set; }
            [NotNull]
            public string FirstName
            { get; set; }
            public string LastName
            { get; set; }
            public string Email
            { get; set; }
        public string Vendor
        { get; set; }
        public string Client
        { get; set; }
        public string Location
        { get; set; }
            public string DOB
            { get; set; }

    }
}
