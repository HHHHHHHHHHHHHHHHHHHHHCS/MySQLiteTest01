using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System;

public class Test : MonoBehaviour
{
    private static string _path;
    private static string path
    {
        get
        {
            if (string.IsNullOrEmpty(_path))
            {
                _path = Application.dataPath + "/data.db";
            }
            return _path;
        }
    }


    void Start()
    {

        DbAccess db = new DbAccess("data source=" + path);
        db.ExecuteNonQuery(SQLScripts.nowsite_createTable);
        db.ExecuteNonQuery(SQLScripts.score_createTable);
        string insertSQL = string.Format(SQLScripts.score_insert, Guid.NewGuid().ToString("N"), "2", "3", 4, 1, 0, "", "", "");
        db.ExecuteNonQuery(insertSQL);
        string updateSQL = string.Format(SQLScripts.score_update, "c8b497afdd8a477bbaf90d5fa7454e6d");
        db.ExecuteNonQuery(updateSQL);
        db.CloseSqlConnection();
    }

}
