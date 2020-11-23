using System;
using System.IO;

namespace PizzaApp.Config
{
    internal class DatabaseConfiguration
    {
        internal static string ConnectionString = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\PizzaApp\Database\PizzaAppDB.mdf;Integrated Security=True",
                                                    Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
    }
}