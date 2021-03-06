﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastQuery.Data
{
    public class Keyword
    {

        public string[]
            BlockKeywords ={
            "INSERT", "UPDATE", "DELETE", 
            "CREATE", "DROP", "ALTER", "DELETE", "TRUNCATE", "ADD",
            "EXECUTE", "EXEC"
                              };

        public string[]
        DataChangeKeywords ={
            "INSERT", "UPDATE", "DELETE", 
            "CREATE", "DROP", "ALTER", "DELETE", "TRUNCATE", "ADD",
            "EXECUTE"
                              };

        public string[]
        SchemaChangeKeywords ={
            "UPDATE TABLE", "DELETE TABLE", 
            "CREATE TABLE", "DROP TABLE", "ALTER TABLE", "DELETE TABLE", "ADD TABLE"
                              };

        public string[]
            KeywordsBlue = {
            "ABSOLUTE", "ADA", "ADD", "ALL", "ALLOCATE", "ALTER", "AND", "ANY", "ARE", "AS", "ASC", 
            "ASSERTION", "AT", "AUTHORIZATION", "AVG", "BEGIN", "BETWEEN", "BIT", "BIT_LENGTH", "BY", "CASCADE", 
            "CASCADED", "CASE", "CAST", "CATALOG", "CHAR", "CHAR_LENGTH", "CHARACTER", "CHARACTER_LENGTH", "CHECK", 
            "CLOSE", "COALESCE", "COBOL", "COLLATE", "COLLATION", "COLUMN", "COMMIT", "CONNECT", "CONNECTION", 
            "CONSTRAINT", "CONSTRAINTS", "CONTINUE", "CONVERT", "CORRESPONDING", "COUNT", "CREATE", "CURRENT", 
            "CURRENT_DATE", "CURRENT-TIME", "CURRENT_TIMESTAMP", "CURSOR", "DATABASE", "DATE", "DAY", "DEALLOCATE", 
            "DEC", "DECIMAL", "DECLARE", "DEFERRABLE", "DEFERRED", "DELETE", "DESC", "DESCRIBE", "DESCRIPTOR", 
            "DIAGNOSTICS", "DICTIONARY", "DISCONNECT", "DISPLACEMENT", "DISTINCT", "DOMAIN", "DOUBLE", "DROP", 
            "ELSE", "END", "END-EXEC", "ESCAPE", "EXCEPT", "EXCEPTION", "EXEC", "EXECUTE", "EXISTS", 
            "EXTERNAL", "EXTRACT", "FALSE", "FETCH", "FIRST", "FLOAT", "FOR", "FOREIGN", "FORTRAN", "FOUND", 
            "FROM", "FULL", "GENERAL", "GET", "GLOBAL", "GO", "GOTO", "GRANT", "GROUP", "HAVING", "HOUR", 
            "IDENTITY", "IGNORE", "IMMEDIATE", "IN", "INCLUDE", "INDEX", "INDICATOR", "INITIALLY", "INNER", 
            "INPUT", "INSENSITIVE", "INSERT", "INTEGER", "INTERSECT", "INTERVAL", "INTO", "IS", "ISOLATION", 
            "JOIN", "KEY", "LANGUAGE", "LAST", "LEFT", "LEVEL", "LIKE", "LOCAL", "LOWER", "MATCH", "MAX", "MIN", 
            "MINUTE", "MODULE", "MONTH", "MUMPS", "NAMES", "NATIONAL", "NCHAR", "NEXT", "NONE", "NOT", "NULL", 
            "NULLIF", "NUMERIC", "OCTET_LENGTH", "OF", "OFF", "ON", "ONLY", "OPEN", "OIPTION", "OR", "ORDER", 
            "OUTER", "OUTPUT", "OVERLAPS", "PARTIAL", "PASCAL", "PLI", "POSITION", "PRECISION", "PREPARE", 
            "PRESERVE", "PRIMARY", "PRIOR", "PRIVILEGES", "PROCEDURE", "PUBLIC", "RESTRICT", "REVOKE", "RIGHT", 
            "ROLLBACK", "ROWS", "SCHEMA", "SCROLL", "SECOND", "SECTION", "SELECT", "SEQUENCE", "SET", "SIZE", 
            "SMALLINT", "SOME", "SQL", "SQLCA", "SQLCODE", "SQLERROR", "SQLSTATE", "SQLWARNING", "SUBSTRING", 
            "SUM", "SYSTEM", "TABLE", "TEMPORARY", "THEN", "TIME", "TIMESTAMP", "TIMEZONE_HOUR", "TIMEZONE_MINUTE", 
            "TO", "TRANSACTION", "TRANSLATE", "TRANSLATION", "TRUE", "UNION", "UNIQUE", "UNKNOWN", "UPDATE", "UPPER", 
            "USAGE", "USER", "USING", "VALUE", "VALUES", "VARCHAR", "VARYING", "VIEW", "WHEN", "WHENEVER", "WHERE", 
            "WITH", "WORK", "YEAR", "NOLOCK"
        
                           };
    }
}
