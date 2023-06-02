﻿using System.Data;

namespace Arrays_and_Lists_Exercise_01.DBConnections;

internal class PostgreSQLConnection : IDbConnection
{
    public string ConnectionString { get; set; }

    public int ConnectionTimeout => 10;

    public string Database => "PostgreSQL";

    public ConnectionState State => ConnectionState.Open;

    public IDbTransaction BeginTransaction()
    {
        throw new NotImplementedException();
    }

    public IDbTransaction BeginTransaction(IsolationLevel il)
    {
        throw new NotImplementedException();
    }

    public void ChangeDatabase(string databaseName)
    {
        throw new NotImplementedException();
    }

    public void Close()
    {
        throw new NotImplementedException();
    }

    public IDbCommand CreateCommand()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void Open()
    {
        throw new NotImplementedException();
    }
}
