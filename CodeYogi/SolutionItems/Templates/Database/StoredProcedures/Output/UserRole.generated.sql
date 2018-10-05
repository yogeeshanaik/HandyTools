




/******************************************************************************************
** Auth: Yogeesha Naik
** Date: 
** Desc: Other than crud operations on UserRole 
*******************************************************************************************
** Change History
*******************************************************************************************
**  PR  Date        Author          Description 
**  --  --------    -------         ------------------------------------
**  
*******************************************************************************************
** Test Data
EXECUTE Admin_ManageUserRole 
*******************************************************************************************/

-- Create temp table



GO
BEGIN TRAN;

    MERGE UserRole AS T
    USING Source AS S
    ON (T.EmployeeID = S.EmployeeID) 
    WHEN NOT MATCHED BY TARGET AND S.EmployeeName LIKE 'S%' 
        
    THEN INSERT(
                UserRoleId,
				UserId,
				RoleId 
            ) VALUES(
                S.[UserRoleId],
				S.[UserId],
				S.[RoleId]
            )
  
    WHEN MATCHED 
    THEN UPDATE SET T.[UserRoleId] = S.[UserRoleId],
				T.[UserId] = S.[UserId],
				T.[RoleId] = S.[RoleId]
    WHEN NOT MATCHED BY SOURCE AND T.EmployeeName LIKE 'S%'
        THEN DELETE 
    OUTPUT $action, inserted.*, deleted.*;
    
ROLLBACK TRAN;
GO 