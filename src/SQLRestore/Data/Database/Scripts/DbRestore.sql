/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * File:    RestoreDb.sql
 * Date:    2017-4-12
 * Description:
 *  Restore database from file
 * Parameters:
 *  0 - Database Full Path
 *  1 - Backup Path
 * Change Log:
 *  2017-0412 * Initial creation
 */

USE [master];

RESTORE DATABASE [{0}]
FROM DISK = N'{1}'
WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5;


--RESTORE DATABASE [MyDatabase]
--FROM DISK='C:\temp\MyDatabase_20100810.bak' 
--WITH REPLACE,
--MOVE 'MyDatabase' TO 'E:\SQLData_2008\MyDatabase.mdf',
--MOVE 'MyDatabase_log' TO 'E:\SQLData_2008\MyDatabase.ldf' 
