using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    private string path = Application.dataPath + "/data.db";

    void Start()
    {

        DbAccess db = new DbAccess("data source=" + path);
        db.CreateTable("momo", new string[] { "name", "qq", "email", "blog" }, new string[] { "text", "text", "text", "text" });

        db.CloseSqlConnection();
    }

}


//创建数据库名称为xuanyusong.db
//DbAccess db = new DbAccess("data source=xuanyusong.db");

//创建数据库表，与字段
//db.CreateTable("momo", new string[] { "name", "qq", "email", "blog" }, new string[] { "text", "text", "text", "text" });
//请注意 插入字符串是 已经要加上'宣雨松' 不然会报错
//db.InsertInto("momo", new string[] { "'宣雨松'", "'289187120'", "'xuanyusong@gmail.com'", "'www.xuanyusong.com'" });
//关闭对象
//db.CloseSqlConnection();