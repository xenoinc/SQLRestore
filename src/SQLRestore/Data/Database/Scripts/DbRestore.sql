/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-12
 * File:    RestoreDb.sql
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-412 * Initial creation
 */

RESTORE DATABASE [{DatabaseFullPath}] FROM DISK = N'{BackupPath}' WITH  FILE = 1,  NOUNLOAD,  STATS = 10;