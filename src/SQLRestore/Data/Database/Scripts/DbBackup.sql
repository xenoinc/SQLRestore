/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-12
 * File:    BackupDb.sql
 * Description: Backup database
 * Parameters:
 *  0 - Database name to restore to
 *  1 - BAK file path
 *  2 - Extra parameter(s). I.E. "WITH COPY ONLY"
 *
 * Change Log:
 *  2017-0412 * Initial creation
 */
 
-- Example:
--  BACKUP DATABASE [Sales]
--  TO DISK = 'E:\BAK\Sales_Copy.bak'
--  WITH COPY_ONLY;
--  NOFORMAT, NOINIT,  NAME = N'data-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10

BACKUP DATABASE [{0}]
TO DISK='{1}' {2};
