
-- CREATE JOBS & SCHEDULES FOR TESTING
-------------------------------------------------------------------------------------
-- Programmatically managing SQL Agent jobs and schedules
-------------------------------------------------------------------------------------
/*
TRUNCATE TABLE [dbo].[jobs]
TRUNCATE TABLE [dbo].[jobsteps]
TRUNCATE TABLE [dbo].[schedules]
TRUNCATE TABLE [dbo].[jobschedules]
TRUNCATE TABLE [dbo].[jobhistory]
*/
-------------------------------------------------------------------------------------

SELECT * FROM [dbo].[JobCategories]
SELECT * FROM [dbo].[Jobs]
SELECT * FROM [dbo].[JobSteps]
SELECT * FROM [dbo].[Schedules]
SELECT * FROM [dbo].[JobSchedules]
SELECT * FROM [dbo].[JobHistory]
SELECT * FROM [dbo].[Jobs_View]

BEGIN
/****** Object:  Job [Email_ShortfallSummary_Report]    Script Date: 11-06-2020 09:34:31 ******/
BEGIN TRANSACTION
DECLARE @ReturnCode INT
SELECT @ReturnCode = 0
/*
/****** Object:  JobCategory [[Uncategorized (Local)]]    Script Date: 11-06-2020 09:34:31 ******/
IF NOT EXISTS (SELECT name FROM dbo.syscategories WHERE name=N'[Uncategorized (Local)]' AND category_class=1)
BEGIN
EXEC @ReturnCode = dbo.sp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'[Uncategorized (Local)]'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

END
*/

DECLARE @jobId BINARY(16)
EXEC @ReturnCode =  dbo.usp_add_job @job_name=N'Email_ShortfallSummary_Report', 
		@enabled=1, 
		@delete_level=0, 
		@description=N'Genrate shortfall summary report and email to the receipients', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'YOGEESHA\Yogi', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [Generate_SummaryReport_And_Email]    Script Date: 11-06-2020 09:34:31 ******/
EXEC @ReturnCode = dbo.usp_add_jobstep @job_id=@jobId, @step_name=N'Generate_SummaryReport_And_Email', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=3, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=1, 
		@retry_interval=1, 
		@subsystem=N'TSQL', 
		@command=N'SELECT GETDATE() AS [ReportDate], ''Summary'' AS [Report Type]', 
		@database_name=N'master'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [Generate_DetailedReport_And_Email]    Script Date: 11-06-2020 09:34:31 ******/
EXEC @ReturnCode = dbo.usp_add_jobstep @job_id=@jobId, @step_name=N'Generate_DetailedReport_And_Email', 
		@step_id=2, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=1, 
		@retry_interval=1, 
		@subsystem=N'TSQL', 
		@command=N'SELECT 1/0 AS [ReportDate], ''Detailed'' AS [Report Type]', 
		@database_name=N'master'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = dbo.usp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

--Occurs every week on Friday at 11:00:00. Schedule will be used starting on 11-06-2020.
EXEC @ReturnCode = dbo.usp_add_jobschedule @job_id=@jobId, @name=N'Every_Friday', 
		@enabled=1, 
		@freq_type=8, 
		@freq_interval=32, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=1, 
		@active_start_date=20200611, 
		@active_end_date=99991231, 
		@active_start_time=110000, 
		@active_end_time=235959, 
		@schedule_uid=N'631b3284-8cff-4234-a40e-00a2a098fac8'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

--Occurs every week on Friday at 11:00:00. Schedule will be used starting on 11-06-2020.
EXEC @ReturnCode = dbo.usp_add_jobschedule @job_id=@jobId, @name=N'Every_Friday', 
		@enabled=1, 
		@freq_type=4, 
		@freq_interval=0, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=1, 
		@active_start_date=20200611, 
		@active_end_date=99991231, 
		@active_start_time=110000, 
		@active_end_time=235959, 
		@schedule_uid=N'631b3284-8cff-4234-a40e-00a2a098fac8'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

--EXEC @ReturnCode = dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
--IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:
END
GO

-------------------------------------------------------------------------------------
-- Execute Job
-------------------------------------------------------------------------------------
BEGIN
DECLARE @RC int
DECLARE @job_name sysname
DECLARE @job_id uniqueidentifier
DECLARE @error_flag int
DECLARE @server_name sysname
DECLARE @step_name sysname
DECLARE @output_flag int

-- TODO: Set parameter values here.
SET @job_id = N'32F29714-5897-4652-A3E7-DD6AA2400444'

EXECUTE @RC = [dbo].[usp_start_job] 
   @job_name
  ,@job_id
  ,@error_flag
  ,@server_name
  ,@step_name
  ,@output_flag
 END
GO

EXECUTE [dbo].[usp_start_schedule]
  @schedule_id   =  2

SELECT * FROM [dbo].[JobCategories]
SELECT * FROM [dbo].[Jobs]
SELECT * FROM [dbo].[JobSteps]
SELECT * FROM [dbo].[Schedules]
SELECT * FROM [dbo].[JobSchedules]
SELECT * FROM [dbo].[JobHistory]
SELECT * FROM [dbo].[Jobs_View]

SELECT * FROM  [dbo].[udfGetNextSchedule] (3)
SELECT * FROM [dbo].[Schedules]
------------------------------------------------------------------------------------------------------------------
-- Multiple Schedules per Job example
------------------------------------------------------------------------------------------------------------------

BEGIN
/****** Object:  Job [Email_ShortfallSummary_Report]    Script Date: 20-06-2020 09:34:19 ******/
--EXEC dbo.usp_delete_job @job_id=N'a8dd3797-0664-4e5f-9a72-7d43a795158d', @delete_unused_schedule=1
--GO

/****** Object:  Job [Email_ShortfallSummary_Report]    Script Date: 20-06-2020 09:34:19 ******/
BEGIN TRANSACTION
DECLARE @ReturnCode INT
SELECT @ReturnCode = 0
/****** Object:  JobCategory [[Uncategorized (Local)]]    Script Date: 20-06-2020 09:34:19 ******/
--IF NOT EXISTS (SELECT name FROM dbo.JobCategories WHERE name=N'[Uncategorized (Local)]' AND category_class=1)
--BEGIN
--EXEC @ReturnCode = dbo.usp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'[Uncategorized (Local)]'
--IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
--END

DECLARE @jobId BINARY(16)
EXEC @ReturnCode =  dbo.usp_add_job @job_name=N'Email_ShortfallSummary_Report', 
		@enabled=1,  
		@delete_level=0, 
		@description=N'Genrate shortfall summary report and email to the receipients', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'YOGEESHA\Yogi', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [Generate_SummaryReport_And_Email]    Script Date: 20-06-2020 09:34:19 ******/
EXEC @ReturnCode = dbo.usp_add_jobstep @job_id=@jobId, @step_name=N'Generate_SummaryReport_And_Email', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=3, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=1, 
		@retry_interval=1, 
		@subsystem=N'TSQL', 
		@command=N'SELECT GETDATE() AS [ReportDate], ''Summary'' AS [Report Type]', 
		@database_name=N'master'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [Generate_DetailedReport_And_Email]    Script Date: 20-06-2020 09:34:19 ******/
EXEC @ReturnCode = dbo.usp_add_jobstep @job_id=@jobId, @step_name=N'Generate_DetailedReport_And_Email', 
		@step_id=2, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=1, 
		@retry_interval=1, 
		@subsystem=N'TSQL', 
		@command=N'SELECT GETDATE() AS [ReportDate], ''Detailed'' AS [Report Type]', 
		@database_name=N'master'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = dbo.usp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = dbo.usp_add_jobschedule @job_id=@jobId, @name=N'Daily Once', 
		@enabled=1, 
		@freq_type=4, 
		@freq_interval=1, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=0, 
		@active_start_date=20200620, 
		@active_end_date=99991231, 
		@active_start_time=233000, 
		@active_end_time=235959, 
		@schedule_uid=N'b76d0fa3-b82a-4433-8ccd-47ae24c8e318'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = dbo.usp_add_jobschedule @job_id=@jobId, @name=N'Every One Hour', 
		@enabled=1, 
		@freq_type=4, 
		@freq_interval=1, 
		@freq_subday_type=8, 
		@freq_subday_interval=1, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=0, 
		@active_start_date=20200620, 
		@active_end_date=99991231, 
		@active_start_time=0, 
		@active_end_time=235959, 
		@schedule_uid=N'a3e178f4-6177-49eb-b72d-0fdac970bfa3'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = dbo.usp_add_jobschedule @job_id=@jobId, @name=N'Every_Friday', 
		@enabled=1, 
		@freq_type=8, 
		@freq_interval=32, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=1, 
		@active_start_date=20200611, 
		@active_end_date=99991231, 
		@active_start_time=110000, 
		@active_end_time=235959, 
		@schedule_uid=N'631b3284-8cff-4234-a40e-00a2a098fac8'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = dbo.usp_add_jobschedule @job_id=@jobId, @name=N'Monthly_Dynamic', 
		@enabled=1, 
		@freq_type=32, 
		@freq_interval=8, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=16, 
		@freq_recurrence_factor=1, 
		@active_start_date=20200620, 
		@active_end_date=99991231, 
		@active_start_time=90000, 
		@active_end_time=235959, 
		@schedule_uid=N'a8b7b3d8-ee01-4d19-a2d2-630908ce9923'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
--EXEC @ReturnCode = dbo.usp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:
END
GO


------------------------------------------------------------------------------------------------------------------
-- Get schedule description
------------------------------------------------------------------------------------------------------------------
BEGIN
DECLARE @RC int
DECLARE @freq_type int
DECLARE @freq_interval int
DECLARE @freq_subday_type int
DECLARE @freq_subday_interval int
DECLARE @freq_relative_interval int
DECLARE @freq_recurrence_factor int
DECLARE @active_start_date int
DECLARE @active_end_date int
DECLARE @active_start_time int
DECLARE @active_end_time int
DECLARE @schedule_description nvarchar(255)

SELECT 
 @freq_type					= freq_type				
,@freq_interval				= freq_interval			
,@freq_subday_type			= freq_subday_type		
,@freq_subday_interval		= freq_subday_interval	
,@freq_relative_interval	= freq_relative_interval
,@freq_recurrence_factor	= freq_recurrence_factor
,@active_start_date			= active_start_date		
,@active_end_date			= active_end_date		
,@active_start_time			= active_start_time		
,@active_end_time			= active_end_time		
--,@schedule_description		= schedule_description	
FROM Schedules
WHERE schedule_id = 2

-- TODO: Set parameter values here.

EXECUTE @RC = [dbo].[usp_get_schedule_description] 
   @freq_type
  ,@freq_interval
  ,@freq_subday_type
  ,@freq_subday_interval
  ,@freq_relative_interval
  ,@freq_recurrence_factor
  ,@active_start_date
  ,@active_end_date
  ,@active_start_time
  ,@active_end_time
  ,@schedule_description OUTPUT

SELECT @schedule_description
END
GO
