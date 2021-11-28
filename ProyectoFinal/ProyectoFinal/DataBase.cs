using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProyectoFinal
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();



    }
}
