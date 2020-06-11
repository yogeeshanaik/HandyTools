
-- CREATE JOBS & SCHEDULES FOR TESTING
-------------------------------------------------------------------------------------
-- Programmatically managing SQL Agent jobs and schedules
-------------------------------------------------------------------------------------
/*
TRUNCATE TABLE [dbo].[sysjobs]
TRUNCATE TABLE [dbo].[sysjobsteps]
TRUNCATE TABLE [dbo].[sysschedules]
TRUNCATE TABLE [dbo].[sysjobschedules]
TRUNCATE TABLE [dbo].[sysjobservers]
TRUNCATE TABLE [dbo].[sysoriginatingservers]
TRUNCATE TABLE [dbo].[sysjobhistory]
TRUNCATE TABLE [dbo].[sysjobstepslogs]
*/
-------------------------------------------------------------------------------------

SELECT * FROM [dbo].[syscategories]
SELECT * FROM [dbo].[sysjobs]
SELECT * FROM [dbo].[sysjobsteps]
SELECT * FROM [dbo].[sysschedules]
SELECT * FROM [dbo].[sysjobschedules]

SELECT * FROM [dbo].[sysjobservers]
SELECT * FROM [dbo].[sysoriginatingservers]

SELECT * FROM [dbo].[sysjobhistory]
SELECT * FROM [dbo].[sysjobstepslogs]

SELECT * FROM [dbo].[sysjobs_view]

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
EXEC @ReturnCode =  dbo.sp_add_job @job_name=N'Email_ShortfallSummary_Report', 
		@enabled=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=0, 
		@notify_level_netsend=0, 
		@notify_level_page=0, 
		@delete_level=0, 
		@description=N'Genrate shortfall summary report and email to the receipients', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'YOGEESHA\Yogi', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [Generate_SummaryReport_And_Email]    Script Date: 11-06-2020 09:34:31 ******/
EXEC @ReturnCode = dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'Generate_SummaryReport_And_Email', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=3, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=1, 
		@retry_interval=1, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'SELECT GETADTE() AS [ReportDate], ''Summary'' AS [Report Type]', 
		@database_name=N'master', 
		@flags=0
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [Generate_DetailedReport_And_Email]    Script Date: 11-06-2020 09:34:31 ******/
EXEC @ReturnCode = dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'Generate_DetailedReport_And_Email', 
		@step_id=2, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=1, 
		@retry_interval=1, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'SELECT GETADTE() AS [ReportDate], ''Detailed'' AS [Report Type]', 
		@database_name=N'master', 
		@flags=0
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = dbo.sp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

--Occurs every week on Friday at 11:00:00. Schedule will be used starting on 11-06-2020.
EXEC @ReturnCode = dbo.sp_add_jobschedule @job_id=@jobId, @name=N'Every_Friday', 
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
EXEC @ReturnCode = dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:

GO


-------------------------------------------------------------------------------------
-- Execute Job
-------------------------------------------------------------------------------------
DECLARE @RC int
DECLARE @job_name sysname
DECLARE @job_id uniqueidentifier
DECLARE @error_flag int
DECLARE @server_name sysname
DECLARE @step_name sysname
DECLARE @output_flag int

-- TODO: Set parameter values here.
SET @job_id = N'356A817F-19A8-47D4-B0C9-42A995405ADE'

EXECUTE @RC = [dbo].[sp_start_job] 
   @job_name
  ,@job_id
  ,@error_flag
  ,@server_name
  ,@step_name
  ,@output_flag
GO

SELECT * FROM [dbo].[sysjobhistory]