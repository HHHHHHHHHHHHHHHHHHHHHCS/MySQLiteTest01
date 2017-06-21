using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQLScripts
{
    private const string nowSiteID = "ld00001";

    public const string score_createTable = @"
CREATE TABLE  if not exists  score (
    guid     VARCHAR (32) PRIMARY KEY,
    clientid VARCHAR (10),
    cardno   VARCHAR (10),
    mission  INT,
    iswin    BOOL,
    ispost   BOOL,
    remark1  VARCHAR (20),
    remark2  VARCHAR (20),
    remark3  VARCHAR (20) 
);";

    public const string score_insert = @"INSERT INTO score(guid, clientid, cardno, mission, iswin, ispost, remark1, remark2, remark3) 
VALUES('{0}','{1}','{2}',{3},{4},{5},'{6}','{7}','{8}')";

    public const string score_select = @"SELECT * FROM score
where ispost=0";

    public const string score_update = @"update score 
set ispost = 1
where guid = '{0}';";

    public const string buildSite_createTable = @"CREATE TABLE if not exists buildingsite (
    siteid   VARCHAR (10) PRIMARY KEY,
    sitename VARCHAR (20) 
);";

    public const string nowsite_createTable = @"CREATE TABLE  if not exists  nowsite (
    nowsite VARCHAR (10) PRIMARY KEY DEFAULT " + nowSiteID +
");";
}
