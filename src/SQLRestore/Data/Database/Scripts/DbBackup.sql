/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-12
 * File:    BackupDb.sql
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-412 * Initial creation
 */

BACKUP DATABASE [{DatabaseName}]
TO DISK='{0}' {1};

--BACKUP DATABASE [{DatabaseName}]
--TO DISK='{FileName}'
--{UseCopyOnly};

-- BACKUP DATABASE Sales
-- TO DISK = 'E:\BAK\Sales_Copy.bak'
-- WITH COPY_ONLY;
