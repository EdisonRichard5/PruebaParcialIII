 using Mono.Data.Sqlite;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBConnector : MonoBehaviour
{
    private SqliteConnection _conexion;
    private SqliteCommand _command;
    private SqliteDataReader _reader;

    private string _query;
    public void OpenDB(string _dbName)
    {
        _conexion = new SqliteConnection(_dbName);
        _conexion.Open();
    }

    public void SelectData()
    {
        _query = "SELECT * FROM Person";
        _command.CommandText = _query;
        _reader = _command.ExecuteReader();
        if (_reader != null)
        {
            while (_reader.Read())
            {
                print(_reader.GetValue(1).ToString() + "-" + _reader.GetValue(2).ToString());
            }
        }
    }


    
    public void InsertData(string _puntos, string _x, string _y, string _z)
{

    _query = "INSERT INTO Person VALUES(2,'" + _puntos + "','" + _x + "','" + _y + "','" + _z + "')";
    _command = _conexion.CreateCommand();
    _command.CommandText = _query;
    _command.ExecuteReader();
       
}

public void UpdateData(string _name)
{
    _query = " UPDATE Person SET Name = '" + _name + "' WHERE id =1";
    _command = _conexion.CreateCommand();
    _command.CommandText = _query;
    _command.ExecuteReader();
}

public void CloseDB()
{
    _reader.Close();
    _reader = null;
    _command = null;
    _conexion.Close();
    _conexion = null;
}

}