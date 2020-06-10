/****** Object:  StoredProcedure [dbo].[sp_verify_schedule_identifiers]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_verify_schedule_identifiers]
GO
/****** Object:  StoredProcedure [dbo].[sp_verify_schedule]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_verify_schedule]
GO
/****** Object:  StoredProcedure [dbo].[sp_verify_jobstep]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_verify_jobstep]
GO
/****** Object:  StoredProcedure [dbo].[sp_verify_jobproc_caller]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_verify_jobproc_caller]
GO
/****** Object:  StoredProcedure [dbo].[sp_verify_job_time]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_verify_job_time]
GO
/****** Object:  StoredProcedure [dbo].[sp_verify_job_identifiers]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_verify_job_identifiers]
GO
/****** Object:  StoredProcedure [dbo].[sp_verify_job_date]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_verify_job_date]
GO
/****** Object:  StoredProcedure [dbo].[sp_update_schedule]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_update_schedule]
GO
/****** Object:  StoredProcedure [dbo].[sp_update_replication_job_parameter]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_update_replication_job_parameter]
GO
/****** Object:  StoredProcedure [dbo].[sp_update_jobstep]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_update_jobstep]
GO
/****** Object:  StoredProcedure [dbo].[sp_sqlagent_notify]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_sqlagent_notify]
GO
/****** Object:  StoredProcedure [dbo].[sp_sqlagent_log_jobhistory]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_sqlagent_log_jobhistory]
GO
/****** Object:  StoredProcedure [dbo].[sp_post_msx_operation]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_post_msx_operation]
GO
/****** Object:  StoredProcedure [dbo].[sp_help_jobstep]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_help_jobstep]
GO
/****** Object:  StoredProcedure [dbo].[sp_help_jobschedule]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_help_jobschedule]
GO
/****** Object:  StoredProcedure [dbo].[sp_get_schedule_description]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_get_schedule_description]
GO
/****** Object:  StoredProcedure [dbo].[sp_downloaded_row_limiter]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_downloaded_row_limiter]
GO
/****** Object:  StoredProcedure [dbo].[sp_detach_schedule]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_detach_schedule]
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_schedule]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_delete_schedule]
GO
/****** Object:  StoredProcedure [dbo].[sp_attach_schedule]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_attach_schedule]
GO
/****** Object:  StoredProcedure [dbo].[sp_add_schedule]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_add_schedule]
GO
/****** Object:  StoredProcedure [dbo].[sp_add_jobstep_internal]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_add_jobstep_internal]
GO
/****** Object:  StoredProcedure [dbo].[sp_add_jobstep]    Script Date: 10-06-2020 17:39:26 ******/
DROP PROCEDURE [dbo].[sp_add_jobstep]
GO
ALTER TABLE [dbo].[sysoriginatingservers] DROP CONSTRAINT [CK_originating_server_id_MustBe_1]
GO
ALTER TABLE [dbo].[sysoriginatingservers] DROP CONSTRAINT [CK_master_server_MustBe_1]
GO
ALTER TABLE [dbo].[sysjobschedules] DROP CONSTRAINT [FK__sysjobsch__sched__2A4B4B5E]
GO
ALTER TABLE [dbo].[sysjobschedules] DROP CONSTRAINT [FK__sysjobsch__job_i__2D27B809]
GO
ALTER TABLE [dbo].[sysoriginatingservers] DROP CONSTRAINT [DF__sysorigin__maste__145C0A3F]
GO
ALTER TABLE [dbo].[sysoriginatingservers] DROP CONSTRAINT [DF__sysorigin__origi__1367E606]
GO
ALTER TABLE [dbo].[sysjobstepslogs] DROP CONSTRAINT [DF__sysjobste__date___4BAC3F29]
GO
ALTER TABLE [dbo].[sysjobstepslogs] DROP CONSTRAINT [DF__sysjobste__date___4AB81AF0]
GO
/****** Object:  Index [UQ__sysorigi__57F15AAC1CBD2DD6]    Script Date: 10-06-2020 17:39:26 ******/
ALTER TABLE [dbo].[sysoriginatingservers] DROP CONSTRAINT [UQ__sysorigi__57F15AAC1CBD2DD6]
GO
/****** Object:  View [dbo].[sysschedules_localserver_view]    Script Date: 10-06-2020 17:39:26 ******/
DROP VIEW [dbo].[sysschedules_localserver_view]
GO
/****** Object:  View [dbo].[sysjobs_view]    Script Date: 10-06-2020 17:39:26 ******/
DROP VIEW [dbo].[sysjobs_view]
GO
/****** Object:  View [dbo].[sysoriginatingservers_view]    Script Date: 10-06-2020 17:39:26 ******/
DROP VIEW [dbo].[sysoriginatingservers_view]
GO
/****** Object:  Table [dbo].[sysschedules]    Script Date: 10-06-2020 17:39:26 ******/
DROP TABLE [dbo].[sysschedules]
GO
/****** Object:  Table [dbo].[sysoriginatingservers]    Script Date: 10-06-2020 17:39:26 ******/
DROP TABLE [dbo].[sysoriginatingservers]
GO
/****** Object:  Table [dbo].[sysjobstepslogs]    Script Date: 10-06-2020 17:39:26 ******/
DROP TABLE [dbo].[sysjobstepslogs]
GO
/****** Object:  Table [dbo].[sysjobsteps]    Script Date: 10-06-2020 17:39:26 ******/
DROP TABLE [dbo].[sysjobsteps]
GO
/****** Object:  Table [dbo].[sysjobservers]    Script Date: 10-06-2020 17:39:26 ******/
DROP TABLE [dbo].[sysjobservers]
GO
/****** Object:  Table [dbo].[sysjobschedules]    Script Date: 10-06-2020 17:39:26 ******/
DROP TABLE [dbo].[sysjobschedules]
GO
/****** Object:  Table [dbo].[sysjobs]    Script Date: 10-06-2020 17:39:26 ******/
DROP TABLE [dbo].[sysjobs]
GO
/****** Object:  Table [dbo].[sysjobhistory]    Script Date: 10-06-2020 17:39:26 ******/
DROP TABLE [dbo].[sysjobhistory]
GO
/****** Object:  Table [dbo].[syscategories]    Script Date: 10-06-2020 17:39:26 ******/
DROP TABLE [dbo].[syscategories]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_IntToTimeString]    Script Date: 10-06-2020 17:39:26 ******/
DROP FUNCTION [dbo].[fn_IntToTimeString]
GO
/****** Object:  UserDefinedFunction [dbo].[agent_datetime]    Script Date: 10-06-2020 17:39:26 ******/
DROP FUNCTION [dbo].[agent_datetime]
GO
/****** Object:  Database [MyScheduler]    Script Date: 10-06-2020 17:39:26 ******/

CREATE FUNCTION [dbo].[agent_datetime](@date int, @time int)
RETURNS DATETIME
AS
BEGIN
 RETURN
  (
    CONVERT(DATETIME,
          CONVERT(NVARCHAR(4),@date / 10000) + N'-' + 
          CONVERT(NVARCHAR(2),(@date % 10000)/100)  + N'-' +
          CONVERT(NVARCHAR(2),@date % 100) + N' ' +        
          CONVERT(NVARCHAR(2),@time / 10000) + N':' +        
          CONVERT(NVARCHAR(2),(@time % 10000)/100) + N':' +        
          CONVERT(NVARCHAR(2),@time % 100),
    120)
  )
END

 
GO
/****** Object:  UserDefinedFunction [dbo].[fn_IntToTimeString]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/************************************************
-- FUNCTION fn_IntToTimeString
-- AUTHOR	Alan Jefferson
-- Date		5/11/2017
--
-- Purpose	convert integer representation of time found in sysschedules to a displayable form
*************************************************/
create function [dbo].[fn_IntToTimeString] (@time int)
returns varchar(20)
AS
BEGIN
declare @return varchar(20)
set @return = ''
if @time is NOT null and @time >= 0 and @time < 240000
select @return = REPLACE(convert(varchar(20), convert(TIME, left(right('000000' + convert(varchar(6),@time), 6),2) + ':' 
				+ substring(right('000000' + convert(varchar(6),@time), 6), 3,2) + ':' 
				+ right('00' + convert(varchar(6),@time), 2)),109),'.0000000', ' ')
return @return;
END
GO
/****** Object:  Table [dbo].[syscategories]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[syscategories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_class] [int] NOT NULL,
	[category_type] [tinyint] NOT NULL,
	[name] [sysname] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysjobhistory]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysjobhistory](
	[instance_id] [int] IDENTITY(1,1) NOT NULL,
	[job_id] [uniqueidentifier] NOT NULL,
	[step_id] [int] NOT NULL,
	[step_name] [sysname] NOT NULL,
	[sql_message_id] [int] NOT NULL,
	[sql_severity] [int] NOT NULL,
	[message] [nvarchar](4000) NULL,
	[run_status] [int] NOT NULL,
	[run_date] [int] NOT NULL,
	[run_time] [int] NOT NULL,
	[run_duration] [int] NOT NULL,
	[operator_id_emailed] [int] NOT NULL,
	[operator_id_netsent] [int] NOT NULL,
	[operator_id_paged] [int] NOT NULL,
	[retries_attempted] [int] NOT NULL,
	[server] [sysname] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysjobs]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sysjobs](
	[job_id] [uniqueidentifier] NOT NULL,
	[originating_server_id] [int] NOT NULL,
	[name] [sysname] NOT NULL,
	[enabled] [tinyint] NOT NULL,
	[description] [nvarchar](512) NULL,
	[start_step_id] [int] NOT NULL,
	[category_id] [int] NOT NULL,
	[owner_sid] [varbinary](85) NOT NULL,
	[notify_level_eventlog] [int] NOT NULL,
	[notify_level_email] [int] NOT NULL,
	[notify_level_netsend] [int] NOT NULL,
	[notify_level_page] [int] NOT NULL,
	[notify_email_operator_id] [int] NOT NULL,
	[notify_netsend_operator_id] [int] NOT NULL,
	[notify_page_operator_id] [int] NOT NULL,
	[delete_level] [int] NOT NULL,
	[date_created] [datetime] NOT NULL,
	[date_modified] [datetime] NOT NULL,
	[version_number] [int] NOT NULL,
 CONSTRAINT [PK_sysjobs] PRIMARY KEY CLUSTERED 
(
	[job_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sysjobschedules]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysjobschedules](
	[schedule_id] [int] NULL,
	[job_id] [uniqueidentifier] NULL,
	[next_run_date] [int] NOT NULL DEFAULT ((0)),
	[next_run_time] [int] NOT NULL DEFAULT ((0))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysjobservers]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysjobservers](
	[job_id] [uniqueidentifier] NOT NULL,
	[server_id] [int] NOT NULL,
	[last_run_outcome] [tinyint] NOT NULL,
	[last_outcome_message] [nvarchar](4000) NULL,
	[last_run_date] [int] NOT NULL,
	[last_run_time] [int] NOT NULL,
	[last_run_duration] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysjobsteps]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysjobsteps](
	[job_id] [uniqueidentifier] NOT NULL,
	[step_id] [int] NOT NULL,
	[step_name] [sysname] NOT NULL,
	[subsystem] [nvarchar](40) NOT NULL,
	[command] [nvarchar](max) NULL,
	[flags] [int] NOT NULL,
	[additional_parameters] [nvarchar](max) NULL,
	[cmdexec_success_code] [int] NOT NULL,
	[on_success_action] [tinyint] NOT NULL,
	[on_success_step_id] [int] NOT NULL,
	[on_fail_action] [tinyint] NOT NULL,
	[on_fail_step_id] [int] NOT NULL,
	[server] [sysname] NULL,
	[database_name] [sysname] NULL,
	[database_user_name] [sysname] NULL,
	[retry_attempts] [int] NOT NULL,
	[retry_interval] [int] NOT NULL,
	[os_run_priority] [int] NOT NULL,
	[output_file_name] [nvarchar](200) NULL,
	[last_run_outcome] [int] NOT NULL,
	[last_run_duration] [int] NOT NULL,
	[last_run_retries] [int] NOT NULL,
	[last_run_date] [int] NOT NULL,
	[last_run_time] [int] NOT NULL,
	[proxy_id] [int] NULL,
	[step_uid] [uniqueidentifier] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysjobstepslogs]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysjobstepslogs](
	[log_id] [int] IDENTITY(1,1) NOT NULL,
	[log] [nvarchar](max) NOT NULL,
	[date_created] [datetime] NOT NULL,
	[date_modified] [datetime] NOT NULL,
	[log_size] [bigint] NOT NULL,
	[step_uid] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[log_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysoriginatingservers]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysoriginatingservers](
	[originating_server_id] [int] NULL,
	[originating_server] [sysname] NOT NULL,
	[master_server] [bit] NULL,
UNIQUE CLUSTERED 
(
	[originating_server_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysschedules]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sysschedules](
	[schedule_id] [int] IDENTITY(1,1) NOT NULL,
	[schedule_uid] [uniqueidentifier] NOT NULL,
	[originating_server_id] [int] NOT NULL,
	[name] [sysname] NOT NULL,
	[owner_sid] [varbinary](85) NOT NULL,
	[enabled] [int] NOT NULL,
	[freq_type] [int] NOT NULL,
	[freq_interval] [int] NOT NULL,
	[freq_subday_type] [int] NOT NULL,
	[freq_subday_interval] [int] NOT NULL,
	[freq_relative_interval] [int] NOT NULL,
	[freq_recurrence_factor] [int] NOT NULL,
	[active_start_date] [int] NOT NULL,
	[active_end_date] [int] NOT NULL,
	[active_start_time] [int] NOT NULL,
	[active_end_time] [int] NOT NULL,
	[date_created] [datetime] NOT NULL DEFAULT (getdate()),
	[date_modified] [datetime] NOT NULL DEFAULT (getdate()),
	[version_number] [int] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[schedule_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[sysoriginatingservers_view]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sysoriginatingservers_view](originating_server_id, originating_server, master_server)
AS 
   SELECT
      0 AS originating_server_id, 
      UPPER(CONVERT(sysname, SERVERPROPERTY('ServerName'))) AS originating_server,
      0 AS master_server
   UNION
   SELECT 
      originating_server_id,
      originating_server,
      master_server
   FROM
      dbo.sysoriginatingservers

GO
/****** Object:  View [dbo].[sysjobs_view]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* filter out local jobs  

WHERE        (jobs.owner_sid = SUSER_SID()) OR
                         (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1) OR
                         (ISNULL(IS_MEMBER(N'SQLAgentReaderRole'), 0) = 1) OR
                         (ISNULL(IS_MEMBER(N'TargetServersRole'), 0) = 1) AND EXISTS
                             (SELECT        job_id, server_id, last_run_outcome, last_outcome_message, last_run_date, last_run_time, last_run_duration
                               FROM            dbo.sysjobservers AS js
                               WHERE        (server_id <> 0) AND (job_id = jobs.job_id))
*/
CREATE VIEW [dbo].[sysjobs_view]
AS
SELECT        jobs.job_id, svr.originating_server, jobs.name, jobs.enabled, jobs.description, jobs.start_step_id, jobs.category_id, jobs.owner_sid, jobs.notify_level_eventlog, jobs.notify_level_email, jobs.notify_level_netsend, 
                         jobs.notify_level_page, jobs.notify_email_operator_id, jobs.notify_netsend_operator_id, jobs.notify_page_operator_id, jobs.delete_level, jobs.date_created, jobs.date_modified, jobs.version_number, jobs.originating_server_id, 
                         svr.master_server
FROM            dbo.sysjobs AS jobs INNER JOIN
                         dbo.sysoriginatingservers_view AS svr ON jobs.originating_server_id = svr.originating_server_id

GO
/****** Object:  View [dbo].[sysschedules_localserver_view]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[sysschedules_localserver_view]
AS
SELECT sched.schedule_id,
       sched.schedule_uid,
       sched.originating_server_id,
       sched.name,
       sched.owner_sid,
       sched.enabled,
       sched.freq_type,
       sched.freq_interval,
       sched.freq_subday_type,
       sched.freq_subday_interval,
       sched.freq_relative_interval,
       sched.freq_recurrence_factor,
       sched.active_start_date,
       sched.active_end_date,
       sched.active_start_time,
       sched.active_end_time,
       sched.date_created,
       sched.date_modified,
       sched.version_number,
       svr.originating_server,
       svr.master_server
FROM dbo.sysschedules as sched
    JOIN dbo.sysoriginatingservers_view as svr
    ON sched.originating_server_id = svr.originating_server_id
WHERE (svr.master_server = 0)
  AND ( (sched.owner_sid = SUSER_SID())
        OR (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1)
      OR (ISNULL(IS_MEMBER(N'SQLAgentReaderRole'), 0) = 1)
      )

GO
SET IDENTITY_INSERT [dbo].[syscategories] ON 

GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (0, 1, 1, N'[Uncategorized (Local)]')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (2, 1, 2, N'[Uncategorized (Multi-Server)]')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (98, 2, 3, N'[Uncategorized]')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (99, 3, 3, N'[Uncategorized]')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (8, 1, 1, N'Data Collector')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (7, 1, 1, N'Database Engine Tuning Advisor')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (3, 1, 1, N'Database Maintenance')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (5, 1, 1, N'Full-Text')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (1, 1, 1, N'Jobs from MSX')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (6, 1, 1, N'Log Shipping')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (18, 1, 1, N'REPL-Alert Response')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (16, 1, 1, N'REPL-Checkup')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (10, 1, 1, N'REPL-Distribution')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (11, 1, 1, N'REPL-Distribution Cleanup')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (12, 1, 1, N'REPL-History Cleanup')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (20, 2, 3, N'Replication')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (13, 1, 1, N'REPL-LogReader')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (14, 1, 1, N'REPL-Merge')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (19, 1, 1, N'REPL-QueueReader')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (15, 1, 1, N'REPL-Snapshot')
GO
INSERT [dbo].[syscategories] ([category_id], [category_class], [category_type], [name]) VALUES (17, 1, 1, N'REPL-Subscription Cleanup')
GO
SET IDENTITY_INSERT [dbo].[syscategories] OFF
GO
INSERT [dbo].[sysjobs] ([job_id], [originating_server_id], [name], [enabled], [description], [start_step_id], [category_id], [owner_sid], [notify_level_eventlog], [notify_level_email], [notify_level_netsend], [notify_level_page], [notify_email_operator_id], [notify_netsend_operator_id], [notify_page_operator_id], [delete_level], [date_created], [date_modified], [version_number]) VALUES (N'9201cd8d-98da-4b2e-a4c5-6bb817cf5cd2', 0, N'syspolicy_purge_history', 1, N'No description available.', 1, 0, 0x01, 0, 0, 0, 0, 0, 0, 0, 0, CAST(N'2016-10-16 11:27:25.037' AS DateTime), CAST(N'2020-06-08 10:44:40.290' AS DateTime), 8)
GO
INSERT [dbo].[sysjobschedules] ([schedule_id], [job_id], [next_run_date], [next_run_time]) VALUES (1, N'9201cd8d-98da-4b2e-a4c5-6bb817cf5cd2', 0, 0)
GO
SET IDENTITY_INSERT [dbo].[sysschedules] ON 

GO
INSERT [dbo].[sysschedules] ([schedule_id], [schedule_uid], [originating_server_id], [name], [owner_sid], [enabled], [freq_type], [freq_interval], [freq_subday_type], [freq_subday_interval], [freq_relative_interval], [freq_recurrence_factor], [active_start_date], [active_end_date], [active_start_time], [active_end_time], [date_created], [date_modified], [version_number]) VALUES (1, N'10165dc7-523a-464a-a737-a35c716019c3', 0, N'First Schedule', 0x01, 1, 8, 2, 1, 0, 0, 1, 20200607, 99991231, 20500, 235959, CAST(N'2020-06-07 19:30:51.097' AS DateTime), CAST(N'2020-06-08 16:11:52.043' AS DateTime), 5)
GO
SET IDENTITY_INSERT [dbo].[sysschedules] OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__sysorigi__57F15AAC1CBD2DD6]    Script Date: 10-06-2020 17:39:26 ******/
ALTER TABLE [dbo].[sysoriginatingservers] ADD UNIQUE NONCLUSTERED 
(
	[originating_server] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[sysjobstepslogs] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[sysjobstepslogs] ADD  DEFAULT (getdate()) FOR [date_modified]
GO
ALTER TABLE [dbo].[sysoriginatingservers] ADD  DEFAULT ((1)) FOR [originating_server_id]
GO
ALTER TABLE [dbo].[sysoriginatingservers] ADD  DEFAULT ((1)) FOR [master_server]
GO
ALTER TABLE [dbo].[sysjobschedules]  WITH CHECK ADD FOREIGN KEY([job_id])
REFERENCES [dbo].[sysjobs] ([job_id])
GO
ALTER TABLE [dbo].[sysjobschedules]  WITH CHECK ADD FOREIGN KEY([schedule_id])
REFERENCES [dbo].[sysschedules] ([schedule_id])
GO
ALTER TABLE [dbo].[sysoriginatingservers]  WITH CHECK ADD  CONSTRAINT [CK_master_server_MustBe_1] CHECK  (([master_server]=(1)))
GO
ALTER TABLE [dbo].[sysoriginatingservers] CHECK CONSTRAINT [CK_master_server_MustBe_1]
GO
ALTER TABLE [dbo].[sysoriginatingservers]  WITH CHECK ADD  CONSTRAINT [CK_originating_server_id_MustBe_1] CHECK  (([originating_server_id]=(1)))
GO
ALTER TABLE [dbo].[sysoriginatingservers] CHECK CONSTRAINT [CK_originating_server_id_MustBe_1]
GO
/****** Object:  StoredProcedure [dbo].[sp_add_jobstep]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_add_jobstep]
  @job_id                UNIQUEIDENTIFIER = NULL,   -- Must provide either this or job_name
  @job_name              sysname          = NULL,   -- Must provide either this or job_id
  @step_id               INT              = NULL,   -- The proc assigns a default
  @step_name             sysname,
  @subsystem             NVARCHAR(40)     = N'TSQL',
  @command               NVARCHAR(max)   = NULL,   
  @additional_parameters NVARCHAR(max)    = NULL,
  @cmdexec_success_code  INT              = 0,
  @on_success_action     TINYINT          = 1,      -- 1 = Quit With Success, 2 = Quit With Failure, 3 = Goto Next Step, 4 = Goto Step
  @on_success_step_id    INT              = 0,
  @on_fail_action        TINYINT          = 2,      -- 1 = Quit With Success, 2 = Quit With Failure, 3 = Goto Next Step, 4 = Goto Step
  @on_fail_step_id       INT              = 0,
  @server                sysname      = NULL,
  @database_name         sysname          = NULL,
  @database_user_name    sysname          = NULL,
  @retry_attempts        INT              = 0,      -- No retries
  @retry_interval        INT              = 0,      -- 0 minute interval
  @os_run_priority       INT              = 0,      -- -15 = Idle, -1 = Below Normal, 0 = Normal, 1 = Above Normal, 15 = Time Critical)
  @output_file_name      NVARCHAR(200)    = NULL,
  @flags                 INT              = 0,       -- 0 = Normal, 
                                                     -- 1 = Encrypted command (read only), 
                                                     -- 2 = Append output files (if any), 
                                                     -- 4 = Write TSQL step output to step history,                                            
                                                     -- 8 = Write log to table (overwrite existing history), 
                                                     -- 16 = Write log to table (append to existing history)
                                                     -- 32 = Write all output to job history
                                                     -- 64 = Create a Windows event to use as a signal for the Cmd jobstep to abort
  @proxy_id                 INT                = NULL,
  @proxy_name               sysname          = NULL,
  -- mutual exclusive; must specify only one of above 2 parameters to 
  -- identify the proxy. 
  @step_uid UNIQUEIDENTIFIER = NULL OUTPUT
AS
BEGIN
  DECLARE @retval      INT

  SET NOCOUNT ON
  -- Only sysadmin's or db_owner's of msdb can add replication job steps directly
  IF (UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) IN
                        (N'DISTRIBUTION',
                         N'SNAPSHOT',
                         N'LOGREADER',
                         N'MERGE',
                         N'QUEUEREADER'))
  BEGIN
    IF NOT ((ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1) OR
            (ISNULL(IS_MEMBER(N'db_owner'), 0) = 1) OR
            (UPPER(USER_NAME() collate SQL_Latin1_General_CP1_CS_AS) = N'DBO'))
    BEGIN
      RAISERROR(14260, -1, -1)
      RETURN(1) -- Failure
    END
  END

  --Only sysadmin can specify @database_user_name
  IF (@database_user_name IS NOT NULL) AND (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1)
  BEGIN
    RAISERROR(14583, -1, -1)
    RETURN(1) -- Failure    
  END

  -- Make sure Dts is translated into new subsystem's name SSIS
  IF UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) = N'DTS'
  BEGIN
    SET @subsystem = N'SSIS'
  END

  EXECUTE @retval = dbo.sp_add_jobstep_internal @job_id = @job_id,
                                                @job_name = @job_name,
                                                @step_id = @step_id,
                                                @step_name = @step_name,
                                                @subsystem = @subsystem,
                                                @command = @command,
                                                @additional_parameters = @additional_parameters,
                                                @cmdexec_success_code = @cmdexec_success_code,
                                                @on_success_action = @on_success_action,
                                                @on_success_step_id = @on_success_step_id,
                                                @on_fail_action = @on_fail_action,
                                                @on_fail_step_id = @on_fail_step_id,
                                                @server = @server,
                                                @database_name = @database_name,
                                                @database_user_name = @database_user_name,
                                                @retry_attempts = @retry_attempts,
                                                @retry_interval = @retry_interval,
                                                @os_run_priority = @os_run_priority,
                                                @output_file_name = @output_file_name,
                                                @flags = @flags,
                                                            @proxy_id = @proxy_id,
                                                @proxy_name = @proxy_name,
                                                            @step_uid = @step_uid OUTPUT


  RETURN(@retval)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_add_jobstep_internal]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_add_jobstep_internal]
  @job_id                UNIQUEIDENTIFIER = NULL,   -- Must provide either this or job_name
  @job_name              sysname          = NULL,   -- Must provide either this or job_id
  @step_id               INT              = NULL,   -- The proc assigns a default
  @step_name             sysname,
  @subsystem             NVARCHAR(40)     = N'TSQL',
  @command               NVARCHAR(max)    = NULL,
  @additional_parameters NVARCHAR(max)    = NULL,
  @cmdexec_success_code  INT              = 0,
  @on_success_action     TINYINT          = 1,      -- 1 = Quit With Success, 2 = Quit With Failure, 3 = Goto Next Step, 4 = Goto Step
  @on_success_step_id    INT              = 0,
  @on_fail_action        TINYINT          = 2,      -- 1 = Quit With Success, 2 = Quit With Failure, 3 = Goto Next Step, 4 = Goto Step
  @on_fail_step_id       INT              = 0,
  @server                sysname          = NULL,
  @database_name         sysname          = NULL,
  @database_user_name    sysname          = NULL,
  @retry_attempts        INT              = 0,      -- No retries
  @retry_interval        INT              = 0,      -- 0 minute interval
  @os_run_priority       INT              = 0,      -- -15 = Idle, -1 = Below Normal, 0 = Normal, 1 = Above Normal, 15 = Time Critical)
  @output_file_name      NVARCHAR(200)    = NULL,
  @flags                 INT              = 0,       --  0 = Normal, 
                                                     --  1 = Encrypted command (read only), 
                                                     --  2 = Append output files (if any), 
                                                     --  4 = Write TSQL step output to step history
                                                     --  8 = Write log to table (overwrite existing history)
                                                     -- 16 = Write log to table (append to existing history)
                                                     -- 32 = Write all output to job history
                                                     -- 64 = Create a Windows event to use as a signal for the Cmd jobstep to abort
  @proxy_id               int               = NULL,
  @proxy_name              sysname           = NULL,
  -- mutual exclusive; must specify only one of above 2 parameters to 
  -- identify the proxy. 
  @step_uid UNIQUEIDENTIFIER              = NULL OUTPUT
AS
BEGIN
  DECLARE @retval         INT
  DECLARE @max_step_id    INT
  DECLARE @job_owner_sid  VARBINARY(85)
  DECLARE @subsystem_id   INT
  DECLARE @auto_proxy_name sysname
  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @step_name          = LTRIM(RTRIM(@step_name))
  SELECT @subsystem          = LTRIM(RTRIM(@subsystem))
  SELECT @server             = LTRIM(RTRIM(@server))
  SELECT @database_name      = LTRIM(RTRIM(@database_name))
  SELECT @database_user_name = LTRIM(RTRIM(@database_user_name))
  SELECT @output_file_name   = LTRIM(RTRIM(@output_file_name))
  SELECT @proxy_name         = LTRIM(RTRIM(@proxy_name))

  -- Turn [nullable] empty string parameters into NULLs
  IF (@server             = N'') SELECT @server             = NULL
  IF (@database_name      = N'') SELECT @database_name      = NULL
  IF (@database_user_name = N'') SELECT @database_user_name = NULL
  IF (@output_file_name   = N'') SELECT @output_file_name   = NULL
  IF (@proxy_name         = N'') SELECT @proxy_name         = NULL

  -- Check authority (only SQLServerAgent can add a step to a non-local job)
  EXECUTE @retval = sp_verify_jobproc_caller @job_id = @job_id, @program_name = N'SQLAgent%'
  IF (@retval <> 0)
    RETURN(@retval)

  EXECUTE @retval = sp_verify_job_identifiers '@job_name',
                                              '@job_id',
                                               @job_name OUTPUT,
                                               @job_id   OUTPUT,
                                               @owner_sid = @job_owner_sid OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure

  IF ((ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1) AND
      (SUSER_SID() <> @job_owner_sid))
  BEGIN
     RAISERROR(14525, -1, -1)
     RETURN(1) -- Failure
  END
  
  /*
  -- check proxy identifiers only if a proxy has been provided
  IF (@proxy_id IS NOT NULL) or (@proxy_name IS NOT NULL)
  BEGIN
    EXECUTE @retval = sp_verify_proxy_identifiers '@proxy_name',
                                                  '@proxy_id',
                                                   @proxy_name OUTPUT,
                                                   @proxy_id   OUTPUT
    IF (@retval <> 0)
      RETURN(1) -- Failure
   END
   */
  -- Default step id (if not supplied)
  IF (@step_id IS NULL)
  BEGIN
    SELECT @step_id = ISNULL(MAX(step_id), 0) + 1
    FROM dbo.sysjobsteps
    WHERE (job_id = @job_id)
  END

  -- Check parameters
  EXECUTE @retval = sp_verify_jobstep @job_id,
                                      @step_id,
                                      @step_name,
                                      @subsystem,
                                      @command,
                                      @server,
                                      @on_success_action,
                                      @on_success_step_id,
                                      @on_fail_action,
                                      @on_fail_step_id,
                                      @os_run_priority,
                                      @database_name      OUTPUT,
                                      @database_user_name OUTPUT,
                                      @flags,
                                      @output_file_name,
                                               @proxy_id

  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Get current maximum step id
  SELECT @max_step_id = ISNULL(MAX(step_id), 0)
  FROM dbo.sysjobsteps
  WHERE (job_id = @job_id)

  DECLARE @TranCounter INT;
  SET @TranCounter = @@TRANCOUNT;
  IF @TranCounter = 0
  BEGIN
      -- start our own transaction if there is no outer transaction
      BEGIN TRANSACTION;
  END
  
  -- Modify database.
  BEGIN TRY
    -- Update the job's version/last-modified information
    UPDATE dbo.sysjobs
    SET version_number = version_number + 1,
        date_modified = GETDATE()
    WHERE (job_id = @job_id)

    -- Adjust step id's (unless the new step is being inserted at the 'end')
    -- NOTE: We MUST do this before inserting the step.
    IF (@step_id <= @max_step_id)
    BEGIN
      UPDATE dbo.sysjobsteps
      SET step_id = step_id + 1
      WHERE (step_id >= @step_id)
        AND (job_id = @job_id)

      -- Clean up OnSuccess/OnFail references
      UPDATE dbo.sysjobsteps
      SET on_success_step_id = on_success_step_id + 1
      WHERE (on_success_step_id >= @step_id)
        AND (job_id = @job_id)

      UPDATE dbo.sysjobsteps
      SET on_fail_step_id = on_fail_step_id + 1
      WHERE (on_fail_step_id >= @step_id)
        AND (job_id = @job_id)

      UPDATE dbo.sysjobsteps
      SET on_success_step_id = 0,
          on_success_action = 1  -- Quit With Success
      WHERE (on_success_step_id = @step_id)
        AND (job_id = @job_id)

      UPDATE dbo.sysjobsteps
      SET on_fail_step_id = 0,
          on_fail_action = 2     -- Quit With Failure
      WHERE (on_fail_step_id = @step_id)
        AND (job_id = @job_id)
    END

    SELECT @step_uid = NEWID()

    -- Insert the step
    INSERT INTO dbo.sysjobsteps
           (job_id,
            step_id,
            step_name,
            subsystem,
            command,
            flags,
            additional_parameters,
            cmdexec_success_code,
            on_success_action,
            on_success_step_id,
            on_fail_action,
            on_fail_step_id,
            server,
            database_name,
            database_user_name,
            retry_attempts,
            retry_interval,
            os_run_priority,
            output_file_name,
            last_run_outcome,
            last_run_duration,
            last_run_retries,
            last_run_date,
            last_run_time,
            proxy_id,
         step_uid)
    VALUES (@job_id,
            @step_id,
            @step_name,
            @subsystem,
            @command,
            @flags,
            @additional_parameters,
            @cmdexec_success_code,
            @on_success_action,
            @on_success_step_id,
            @on_fail_action,
            @on_fail_step_id,
            @server,
            @database_name,
            @database_user_name,
            @retry_attempts,
            @retry_interval,
            @os_run_priority,
            @output_file_name,
            0,
            0,
            0,
            0,
            0,
         @proxy_id,
         @step_uid)
         
  IF @TranCounter = 0
  BEGIN
      -- start our own transaction if there is no outer transaction
      COMMIT TRANSACTION;
  END

  END TRY
  BEGIN CATCH

      -- Prepare tp echo error information to the caller.
      DECLARE @ErrorMessage NVARCHAR(400)
      DECLARE @ErrorSeverity INT
      DECLARE @ErrorState INT

      SELECT @ErrorMessage = ERROR_MESSAGE()
      SELECT @ErrorSeverity = ERROR_SEVERITY()
      SELECT @ErrorState = ERROR_STATE()
      
      IF @TranCounter = 0
      BEGIN
          -- Transaction started in procedure.
          -- Roll back complete transaction.
          ROLLBACK TRANSACTION;
      END
      RAISERROR (@ErrorMessage, -- Message text.
                  @ErrorSeverity, -- Severity.
                  @ErrorState -- State.
                  )
      RETURN (1)                  
  END CATCH
  
  -- Make sure that SQLServerAgent refreshes the job if the 'Has Steps' property has changed
  IF ((SELECT COUNT(*)
       FROM dbo.sysjobsteps
       WHERE (job_id = @job_id)) = 1)
  BEGIN
    -- NOTE: We only notify SQLServerAgent if we know the job has been cached
    IF (EXISTS (SELECT *
                FROM dbo.sysjobservers
                WHERE (job_id = @job_id)
                  AND (server_id = 0)))
      EXECUTE dbo.sp_sqlagent_notify @op_type       = N'J',
                                            @job_id      = @job_id,
                                            @action_type = N'U'
  END

  /*
  -- For a multi-server job, push changes to the target servers
  IF (EXISTS (SELECT *
              FROM dbo.sysjobservers
              WHERE (job_id = @job_id)
                AND (server_id <> 0)))
  BEGIN
    EXECUTE dbo.sp_post_msx_operation 'INSERT', 'JOB', @job_id
  END
  */

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_add_schedule]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[sp_add_schedule]
(
  @schedule_name        sysname,
  @enabled              TINYINT         = 1,            -- Name does not have to be unique
  @freq_type            INT             = 0,
  @freq_interval        INT             = 0,
  @freq_subday_type        INT             = 0,
  @freq_subday_interval    INT             = 0,
  @freq_relative_interval  INT             = 0,
  @freq_recurrence_factor  INT             = 0,
  @active_start_date    INT             = NULL,         -- sp_verify_schedule assigns a default
  @active_end_date         INT             = 99991231,     -- December 31st 9999
  @active_start_time    INT             = 000000,       -- 12:00:00 am
  @active_end_time         INT             = 235959,       -- 11:59:59 pm
  @owner_login_name        sysname         = NULL,
  @schedule_uid             UNIQUEIDENTIFIER= NULL  OUTPUT, -- Used by a TSX machine when inserting a schedule
  @schedule_id              INT             = NULL  OUTPUT,
  @originating_server       sysname        = NULL
)   
AS
BEGIN
  DECLARE @retval           INT
  DECLARE @owner_sid        VARBINARY(85)
  DECLARE @orig_server_id   INT

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @schedule_name         = LTRIM(RTRIM(@schedule_name)),
         @owner_login_name      = LTRIM(RTRIM(@owner_login_name)),
         @originating_server    = UPPER(LTRIM(RTRIM(@originating_server))),
         @schedule_id           = 0
         
         
   -- If the owner isn't supplied make if the current user
  IF(@owner_login_name IS NULL OR @owner_login_name = '')
  BEGIN
    --Get the current users sid
    SELECT @owner_sid = SUSER_SID()
  END
  ELSE
  BEGIN
    -- Get the sid for @owner_login_name SID
    --force case insensitive comparation for NT users
    SELECT @owner_sid = dbo.SQLAGENT_SUSER_SID(@owner_login_name)
    -- Cannot proceed if @owner_login_name doesn't exist
    IF(@owner_sid IS NULL)
    BEGIN
      RAISERROR(14262, -1, -1, '@owner_login_name', @owner_login_name)
      RETURN(1) -- Failure
    END
  END

  -- Check schedule (frequency and owner) parameters
  EXECUTE @retval = sp_verify_schedule NULL,   -- schedule_id does not exist for the new schedule
                                       @name                    = @schedule_name,
                                       @enabled                 = @enabled,
                                       @freq_type               = @freq_type,
                                       @freq_interval           = @freq_interval            OUTPUT,
                                       @freq_subday_type        = @freq_subday_type         OUTPUT,
                                       @freq_subday_interval    = @freq_subday_interval     OUTPUT,
                                       @freq_relative_interval  = @freq_relative_interval   OUTPUT,
                                       @freq_recurrence_factor  = @freq_recurrence_factor   OUTPUT,
                                       @active_start_date       = @active_start_date        OUTPUT,
                                       @active_start_time       = @active_start_time        OUTPUT,
                                       @active_end_date         = @active_end_date          OUTPUT,
                                       @active_end_time         = @active_end_time          OUTPUT,
                                       @owner_sid               = @owner_sid
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- ignore @originating_server unless SQLAgent is calling
  if((@originating_server IS NULL) OR (@originating_server = N'') OR (PROGRAM_NAME() NOT LIKE N'SQLAgent%'))
  BEGIN
    --Get the local originating_server_id
    SELECT @orig_server_id = originating_server_id 
    FROM dbo.sysoriginatingservers_view 
    WHERE master_server = 0
  END
  ELSE
  BEGIN
    --Get the MSX originating_server_id. If @originating_server isn't the msx server error out
    SELECT @orig_server_id = originating_server_id 
    FROM dbo.sysoriginatingservers_view 
    WHERE (originating_server = @originating_server)

    IF (@orig_server_id IS NULL)
    BEGIN
      RAISERROR(14370, -1, -1)
      RETURN(1) -- Failure
    END
  END
  
  IF (@schedule_uid IS NULL)
  BEGIN
    -- Assign the GUID
    SELECT @schedule_uid = NEWID()
  END
  ELSE IF (@schedule_uid <> CONVERT(UNIQUEIDENTIFIER, 0x00))
  BEGIN
    --Try and find the schedule if a @schedule_uid is provided. 
    --A TSX server uses the @schedule_uid to identify a schedule downloaded from the MSX
   SELECT @schedule_id = schedule_id
    FROM dbo.sysschedules
    WHERE schedule_uid = @schedule_uid

   IF((@schedule_id IS NOT NULL) AND (@schedule_id <> 0))
   BEGIN
      --If found update the fields
      UPDATE dbo.sysschedules
        SET name              = ISNULL(@schedule_name, name),
            enabled              = ISNULL(@enabled, enabled),
         freq_type            = ISNULL(@freq_type, freq_type),
         freq_interval        = ISNULL(@freq_interval, freq_interval),
         freq_subday_type     = ISNULL(@freq_subday_type, freq_subday_type),
         freq_subday_interval = ISNULL(@freq_subday_interval, freq_subday_interval),
         freq_relative_interval  = ISNULL(@freq_relative_interval, freq_relative_interval),
         freq_recurrence_factor  = ISNULL(@freq_recurrence_factor, freq_recurrence_factor),
         active_start_date    = ISNULL(@active_start_date, active_start_date),
         active_end_date         = ISNULL(@active_end_date, active_end_date),
         active_start_time    = ISNULL(@active_start_time, active_start_time),
         active_end_time         = ISNULL(@active_end_time, active_end_time)
      WHERE schedule_uid = @schedule_uid

      RETURN(@@ERROR)
   END
  END
  
  --MSX not found so add a record to sysschedules
  INSERT INTO dbo.sysschedules
         (schedule_uid,
          originating_server_id,
          name,
          owner_sid,
          enabled,
          freq_type,
          freq_interval,
          freq_subday_type,
          freq_subday_interval,
          freq_relative_interval,
          freq_recurrence_factor,
          active_start_date,
          active_end_date,
          active_start_time,
          active_end_time)
  select @schedule_uid,
         @orig_server_id, 
         @schedule_name,
         @owner_sid,
         @enabled,
         @freq_type,
         @freq_interval,
         @freq_subday_type,
         @freq_subday_interval,
         @freq_relative_interval,
         @freq_recurrence_factor,
         @active_start_date,
         @active_end_date,
         @active_start_time,
         @active_end_time
          
  SELECT @retval = @@ERROR,
         @schedule_id = @@IDENTITY

  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_attach_schedule]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[sp_attach_schedule]
(
  @job_id               UNIQUEIDENTIFIER    = NULL,     -- Must provide either this or job_name
  @job_name             sysname             = NULL,     -- Must provide either this or job_id
  @schedule_id          INT                 = NULL,     -- Must provide either this or schedule_name
  @schedule_name        sysname             = NULL,     -- Must provide either this or schedule_id
  @automatic_post       BIT                 = 1         -- If 1 will post notifications to all tsx servers to that run this job
)   
AS
BEGIN
  DECLARE @retval           INT
  DECLARE @sched_owner_sid  VARBINARY(85)
  DECLARE @job_owner_sid    VARBINARY(85)

  
  SET NOCOUNT ON

  -- Check that we can uniquely identify the job
  EXECUTE @retval = dbo.sp_verify_job_identifiers '@job_name',
                                                       '@job_id',
                                                        @job_name                   OUTPUT,
                                                        @job_id                     OUTPUT,
                                                        @owner_sid = @job_owner_sid OUTPUT
    IF (@retval <> 0)
        RETURN(1) -- Failure

/*
  -- Check authority (only SQLServerAgent can add a schedule to a non-local job)
  EXECUTE @retval = sp_verify_jobproc_caller @job_id = @job_id, @program_name = N'SQLAgent%'
  IF (@retval <> 0)
    RETURN(@retval)
	*/
        
  -- Check that we can uniquely identify the schedule
  EXECUTE @retval = dbo.sp_verify_schedule_identifiers @name_of_name_parameter = '@schedule_name',
                                                            @name_of_id_parameter   = '@schedule_id',
                                                            @schedule_name          = @schedule_name    OUTPUT,
                                                            @schedule_id            = @schedule_id      OUTPUT,
                                                            @owner_sid              = @sched_owner_sid  OUTPUT,
                                                            @orig_server_id         = NULL
  IF (@retval <> 0)
      RETURN(1) -- Failure     
 /*
  --Schedules can only be attached to a job if the caller owns the job
  --or the caller is a sysadmin
  IF ((@job_owner_sid <> SUSER_SID()) AND
      (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1))
  BEGIN
     RAISERROR(14377, -1, -1)
     RETURN(1) -- Failure
  END
  */

  -- If the record doesn't already exist create it
  IF( NOT EXISTS(SELECT *  
                 FROM dbo.sysjobschedules
                 WHERE (schedule_id = @schedule_id)
                   AND (job_id = @job_id)) )
  BEGIN
    INSERT INTO dbo.sysjobschedules (schedule_id, job_id)
    SELECT @schedule_id, @job_id
    
    SELECT @retval = @@ERROR
	/*
    -- Notify SQLServerAgent of the change, but only if we know the job has been cached
    IF (EXISTS (SELECT *
                FROM dbo.sysjobservers
                WHERE (job_id = @job_id)
                    AND (server_id = 0)))
    BEGIN
        EXECUTE dbo.sp_sqlagent_notify @op_type     = N'S',
                                            @job_id      = @job_id,
                                            @schedule_id = @schedule_id,
                                            @action_type = N'I'
    END
    
    -- For a multi-server job, remind the user that they need to call sp_post_msx_operation
    IF (EXISTS (SELECT *
                FROM dbo.sysjobservers
                WHERE (job_id = @job_id)
                    AND (server_id <> 0)))
      -- sp_post_msx_operation will do nothing if the schedule isn't assigned to any tsx machines 
      IF (@automatic_post = 1)
        EXECUTE sp_post_msx_operation @operation = 'INSERT', @object_type = 'JOB', @job_id = @job_id
      ELSE
        RAISERROR(14547, 0, 1, N'INSERT', N'sp_post_msx_operation')

    -- update this job's subplan to point to this schedule
    UPDATE dbo.sysmaintplan_subplans
      SET schedule_id = @schedule_id
    WHERE (job_id = @job_id)
      AND (schedule_id IS NULL)
	  */
  END
  
  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_delete_schedule]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[sp_delete_schedule]
(
  @schedule_id          INT                 = NULL,     -- Must provide either this or schedule_name
  @schedule_name        sysname             = NULL,     -- Must provide either this or schedule_id
  @force_delete         bit                 = 0,
  @automatic_post       BIT                 = 1         -- If 1 will post notifications to all tsx servers to that run this schedule
)   
AS
BEGIN
  DECLARE @retval           INT
  DECLARE @owner_sid        VARBINARY(85)
  DECLARE @job_count        INT
  DECLARE @targ_server_id   INT

  SET NOCOUNT ON
  --Get the owners sid       
  SELECT @job_count = 0

  -- Check that we can uniquely identify the schedule. This only returns a schedule that is visible to this user
  EXECUTE @retval = dbo.sp_verify_schedule_identifiers @name_of_name_parameter = '@schedule_name',
                                                            @name_of_id_parameter   = '@schedule_id',
                                                            @schedule_name          = @schedule_name    OUTPUT,
                                                            @schedule_id            = @schedule_id      OUTPUT,
                                                            @owner_sid              = @owner_sid        OUTPUT,
                                                            @orig_server_id         = NULL
  IF (@retval <> 0)
    RETURN(1) -- Failure 

  -- Non-sysadmins can only update jobs schedules they own. 
  -- Members of SQLAgentReaderRole and SQLAgentOperatorRole can view job schedules, 
  -- but they should not be able to delete them
  IF ((@owner_sid <> SUSER_SID()) AND
     (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'),0) <> 1))
  BEGIN
   RAISERROR(14394, -1, -1)
   RETURN(1) -- Failure
  END
    
  --check if there are jobs using this schedule
  SELECT @job_count = count(*)
  FROM sysjobschedules 
  WHERE (schedule_id = @schedule_id)   
  
  -- If we aren't force deleting the schedule make sure no jobs are using it
  IF ((@force_delete = 0) AND (@job_count > 0))
  BEGIN 
    RAISERROR(14372, -1, -1)
    RETURN (1) -- Failure 
  END

  -- Get the one of the terget server_id's. 
  -- Getting MIN(jsvr.server_id) works here because we are only interested in this ID
  -- to determine if the schedule ID is for local jobs or MSX jobs. 
  -- Note, an MSX job can't be run on the local server
  SELECT @targ_server_id = MIN(jsvr.server_id)
  FROM dbo.sysjobschedules AS jsched 
   JOIN dbo.sysjobservers AS jsvr
      ON jsched.job_id = jsvr.job_id
  WHERE (jsched.schedule_id = @schedule_id)

  --OK to delete the job - schedule link
  DELETE sysjobschedules 
  WHERE schedule_id = @schedule_id

  --OK to delete the schedule 
  DELETE sysschedules 
  WHERE schedule_id = @schedule_id

  /*
  -- @targ_server_id would be null if no jobs use this schedule
  IF (@targ_server_id IS NOT NULL)
  BEGIN
   -- Notify SQLServerAgent of the change but only if it the schedule was used by a local job
   IF (@targ_server_id = 0)
   BEGIN 
      -- Only send a notification if the schedule is force deleted. If it isn't force deleted
      -- a notification would have already been sent while detaching the schedule (sp_detach_schedule)
      IF (@force_delete = 1)
      BEGIN
        EXECUTE dbo.sp_sqlagent_notify @op_type     = N'S',
                                   @schedule_id = @schedule_id,
                                   @action_type = N'D'
      END                   
   END
   ELSE
   BEGIN
    -- Instruct the tsx servers to pick up the altered schedule
    IF (@automatic_post = 1)
    BEGIN
      DECLARE @schedule_uid UNIQUEIDENTIFIER
      SELECT @schedule_uid = schedule_uid 
      FROM sysschedules 
      WHERE schedule_id = @schedule_id

      IF(NOT @schedule_uid IS NULL)
      BEGIN
        -- sp_post_msx_operation will do nothing if the schedule isn't assigned to any tsx machines 
        EXECUTE sp_post_msx_operation @operation = 'INSERT', @object_type = 'SCHEDULE', @schedule_uid = @schedule_uid
      END
    END
    ELSE
      RAISERROR(14547, 0, 1, N'INSERT', N'sp_post_msx_operation')
   END
  END
  */
  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_detach_schedule]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[sp_detach_schedule]
(
  @job_id               UNIQUEIDENTIFIER    = NULL,     -- Must provide either this or job_name
  @job_name             sysname             = NULL,     -- Must provide either this or job_id
  @schedule_id          INT                 = NULL,     -- Must provide either this or schedule_name
  @schedule_name        sysname             = NULL,     -- Must provide either this or schedule_id
  @delete_unused_schedule BIT               = 0,        -- Can optionally delete schedule if it isn't referenced.
                                                        -- The default is to keep schedules 
  @automatic_post       BIT                 = 1         -- If 1 will post notifications to all tsx servers to that run this job
)   
AS
BEGIN
  DECLARE @retval   INT
  DECLARE @sched_owner_sid VARBINARY(85)
  DECLARE @job_owner_sid    VARBINARY(85)
  
  SET NOCOUNT ON

  -- Check that we can uniquely identify the job
  EXECUTE @retval = dbo.sp_verify_job_identifiers '@job_name',
                                                       '@job_id',
                                                        @job_name OUTPUT,
                                                        @job_id   OUTPUT,
                                                        @owner_sid = @job_owner_sid OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Check authority (only SQLServerAgent can add a schedule to a non-local job)
  EXECUTE @retval = sp_verify_jobproc_caller @job_id = @job_id, @program_name = N'SQLAgent%'
  IF (@retval <> 0)
    RETURN(@retval)
        
  -- Check that we can uniquely identify the schedule
  EXECUTE @retval = dbo.sp_verify_schedule_identifiers @name_of_name_parameter = '@schedule_name',
                                                            @name_of_id_parameter   = '@schedule_id',
                                                            @schedule_name          = @schedule_name OUTPUT,
                                                            @schedule_id            = @schedule_id   OUTPUT,
                                                            @owner_sid              = @sched_owner_sid OUTPUT,
                                                            @orig_server_id         = NULL,
                                                            @job_id_filter          = @job_id
  IF (@retval <> 0)
      RETURN(1) -- Failure
 
  -- If the record doesn't exist raise an error
  IF( NOT EXISTS(SELECT *  
                 FROM dbo.sysjobschedules
                 WHERE (schedule_id = @schedule_id)
                   AND (job_id = @job_id)) )
  BEGIN
    RAISERROR(14374, 0, 1, @schedule_name, @job_name)    
    RETURN(1) -- Failure   
  END
  ELSE
  BEGIN
  
   -- Permissions check:
   --  If sysadmin continue (sysadmin can detach schedules they don't own)
   --  Otherwise if the caller owns the job, we can detach it
   --  Except If @delete_unused_schedule = 1 then the caller has to own both the job and the schedule
   IF (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1)
   BEGIN
    IF (@job_owner_sid = SUSER_SID())
    BEGIN
      IF ((@delete_unused_schedule = 1) AND (@sched_owner_sid <> SUSER_SID()))
      BEGIN
        -- Cannot delete the schedule
        RAISERROR(14394, -1, -1)
        RETURN(1) -- Failure
      END
    END
    ELSE -- the caller is not sysadmin and it does not own the job -> throw
    BEGIN
      RAISERROR(14391, -1, -1)
      RETURN(1) -- Failure
    END
   END

    DELETE FROM dbo.sysjobschedules
    WHERE (job_id = @job_id)
      AND (schedule_id = @schedule_id)
    
    SELECT @retval = @@ERROR
    
    --delete the schedule if requested and it isn't referenced
    IF(@retval = 0 AND @delete_unused_schedule = 1)
    BEGIN
        IF(NOT EXISTS(SELECT * 
                      FROM dbo.sysjobschedules
                      WHERE (schedule_id = @schedule_id)))
        BEGIN
            DELETE FROM dbo.sysschedules
            WHERE (schedule_id = @schedule_id)
        END
    END

    -- Update the job's version/last-modified information
    UPDATE dbo.sysjobs
    SET version_number = version_number + 1,
        date_modified = GETDATE()
    WHERE (job_id = @job_id)

	/*
    -- Notify SQLServerAgent of the change, but only if we know the job has been cached
    IF (EXISTS (SELECT *
                FROM dbo.sysjobservers
                WHERE (job_id = @job_id)
                    AND (server_id = 0)))
    BEGIN
        EXECUTE dbo.sp_sqlagent_notify @op_type     = N'S',
                                            @job_id      = @job_id,
                                            @schedule_id = @schedule_id,
                                            @action_type = N'D'
    END


    -- For a multi-server job, remind the user that they need to call sp_post_msx_operation
    IF (EXISTS (SELECT *
                FROM dbo.sysjobservers
                WHERE (job_id = @job_id)
                    AND (server_id <> 0)))
      -- sp_post_msx_operation will do nothing if the schedule isn't assigned to any tsx machines 
      IF (@automatic_post = 1)
        EXECUTE sp_post_msx_operation @operation = 'INSERT', @object_type = 'JOB', @job_id = @job_id
      ELSE
        RAISERROR(14547, 0, 1, N'INSERT', N'sp_post_msx_operation')
    
    -- set this job's subplan to the first schedule in sysjobschedules or NULL if there is none 
    UPDATE dbo.sysmaintplan_subplans
    SET schedule_id = (    SELECT TOP(1) schedule_id
                        FROM dbo.sysjobschedules
                        WHERE (job_id = @job_id) )
    WHERE (job_id = @job_id)
      AND (schedule_id = @schedule_id)
	  */
  END
  
  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_downloaded_row_limiter]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_downloaded_row_limiter]
  @server_name sysname -- Target server name
AS
BEGIN
  -- This trigger controls how many downloaded (status = 1) sysdownloadlist rows exist
  -- for any given server.  It does NOT control the absolute number of rows in the table.

  DECLARE @current_rows_per_server INT
  DECLARE @max_rows_per_server     INT -- This value comes from the resgistry (DownloadedMaxRows)
  DECLARE @rows_to_delete          INT
  DECLARE @quoted_server_name      NVARCHAR(514) -- enough room to accomodate the quoted name
  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @server_name = LTRIM(RTRIM(@server_name))

  -- Check the server name (if it's bad we fail silently)
  IF (@server_name IS NULL) OR
     (NOT EXISTS (SELECT *
                  FROM dbo.sysdownloadlist
                  WHERE (target_server = @server_name)))
    RETURN(1) -- Failure

  SELECT @max_rows_per_server = 0

  -- Get the max-rows-per-server from the registry
  EXECUTE master.dbo.xp_instance_regread N'HKEY_LOCAL_MACHINE',
                                         N'SOFTWARE\Microsoft\MSSQLServer\SQLServerAgent',
                                         N'DownloadedMaxRows',
                                         @max_rows_per_server OUTPUT,
                                         N'no_output'

  -- Check if we are limiting sysdownloadlist rows
  IF (ISNULL(@max_rows_per_server, -1) = -1)
    RETURN

  -- Check that max_rows_per_server is >= 0
  IF (@max_rows_per_server < -1)
  BEGIN
    -- It isn't, so default to 100 rows
    SELECT @max_rows_per_server = 100
    EXECUTE master.dbo.xp_instance_regwrite N'HKEY_LOCAL_MACHINE',
                                            N'SOFTWARE\Microsoft\MSSQLServer\SQLServerAgent',
                                            N'DownloadedMaxRows',
                                            N'REG_DWORD',
                                            @max_rows_per_server
  END

  -- Get the number of downloaded rows in sysdownloadlist for the target server in question
  -- NOTE: Determining this [quickly] requires a [non-clustered] index on target_server
  SELECT @current_rows_per_server = COUNT(*)
  FROM dbo.sysdownloadlist
  WHERE (target_server = @server_name)
    AND (status = 1)

  -- Delete the oldest downloaded row(s) for the target server in question if the new row has
  -- pushed us over the per-server row limit
  SELECT @rows_to_delete = @current_rows_per_server - @max_rows_per_server
  IF (@rows_to_delete > 0)
  BEGIN
    WITH RowsToDelete AS (
      SELECT TOP (@rows_to_delete) *
      FROM dbo.sysdownloadlist
      WHERE (target_server = @server_name)
        AND (status = 1)
      ORDER BY instance_id
    )
    DELETE FROM RowsToDelete;
  END
END

GO
/****** Object:  StoredProcedure [dbo].[sp_get_schedule_description]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_get_schedule_description]
  @freq_type              INT          = NULL,
  @freq_interval          INT          = NULL,
  @freq_subday_type       INT          = NULL,
  @freq_subday_interval   INT          = NULL,
  @freq_relative_interval INT          = NULL,
  @freq_recurrence_factor INT          = NULL,
  @active_start_date      INT          = NULL,
  @active_end_date        INT          = NULL,
  @active_start_time      INT          = NULL,
  @active_end_time        INT          = NULL,
  @schedule_description   NVARCHAR(255) OUTPUT
AS
BEGIN
  DECLARE @loop              INT
  DECLARE @idle_cpu_percent  INT
  DECLARE @idle_cpu_duration INT

  SET NOCOUNT ON

  IF (@freq_type = 0x1) -- OneTime
  BEGIN
    SELECT @schedule_description = N'Once on ' + CONVERT(NVARCHAR, @active_start_date) + N' at ' + CONVERT(NVARCHAR, @active_start_time)
    RETURN
  END

  IF (@freq_type = 0x4) -- Daily
  BEGIN
    SELECT @schedule_description = N'Every day '
  END

  IF (@freq_type = 0x8) -- Weekly
  BEGIN
    SELECT @schedule_description = N'Every ' + CONVERT(NVARCHAR, @freq_recurrence_factor) + N' week(s) on '
    SELECT @loop = 1
    WHILE (@loop <= 7)
    BEGIN
      IF (@freq_interval & POWER(2, @loop - 1) = POWER(2, @loop - 1))
        SELECT @schedule_description = @schedule_description + DATENAME(dw, N'1996120' + CONVERT(NVARCHAR, @loop)) + N', '
      SELECT @loop = @loop + 1
    END
    IF (RIGHT(@schedule_description, 2) = N', ')
      SELECT @schedule_description = SUBSTRING(@schedule_description, 1, (DATALENGTH(@schedule_description) / 2) - 2) + N' '
  END

  IF (@freq_type = 0x10) -- Monthly
  BEGIN
    SELECT @schedule_description = N'Every ' + CONVERT(NVARCHAR, @freq_recurrence_factor) + N' months(s) on day ' + CONVERT(NVARCHAR, @freq_interval) + N' of that month '
  END

  IF (@freq_type = 0x20) -- Monthly Relative
  BEGIN
    SELECT @schedule_description = N'Every ' + CONVERT(NVARCHAR, @freq_recurrence_factor) + N' months(s) on the '
    SELECT @schedule_description = @schedule_description +
      CASE @freq_relative_interval
        WHEN 0x01 THEN N'first '
        WHEN 0x02 THEN N'second '
        WHEN 0x04 THEN N'third '
        WHEN 0x08 THEN N'fourth '
        WHEN 0x10 THEN N'last '
      END +
      CASE
        WHEN (@freq_interval > 00)
         AND (@freq_interval < 08) THEN DATENAME(dw, N'1996120' + CONVERT(NVARCHAR, @freq_interval))
        WHEN (@freq_interval = 08) THEN N'day'
        WHEN (@freq_interval = 09) THEN N'week day'
        WHEN (@freq_interval = 10) THEN N'weekend day'
      END + N' of that month '
  END

  IF (@freq_type = 0x40) -- AutoStart
  BEGIN
    SELECT @schedule_description = FORMATMESSAGE(14579)
    RETURN
  END

  IF (@freq_type = 0x80) -- OnIdle
  BEGIN
    EXECUTE master.dbo.xp_instance_regread N'HKEY_LOCAL_MACHINE',
                                           N'SOFTWARE\Microsoft\MSSQLServer\SQLServerAgent',
                                           N'IdleCPUPercent',
                                           @idle_cpu_percent OUTPUT,
                                           N'no_output'
    EXECUTE master.dbo.xp_instance_regread N'HKEY_LOCAL_MACHINE',
                                           N'SOFTWARE\Microsoft\MSSQLServer\SQLServerAgent',
                                           N'IdleCPUDuration',
                                           @idle_cpu_duration OUTPUT,
                                           N'no_output'
    SELECT @schedule_description = FORMATMESSAGE(14578, ISNULL(@idle_cpu_percent, 10), ISNULL(@idle_cpu_duration, 600))
    RETURN
  END

  -- Subday stuff
  SELECT @schedule_description = @schedule_description +
    CASE @freq_subday_type
      WHEN 0x1 THEN N'at ' + CONVERT(NVARCHAR, @active_start_time)
      WHEN 0x2 THEN N'every ' + CONVERT(NVARCHAR, @freq_subday_interval) + N' second(s)'
      WHEN 0x4 THEN N'every ' + CONVERT(NVARCHAR, @freq_subday_interval) + N' minute(s)'
      WHEN 0x8 THEN N'every ' + CONVERT(NVARCHAR, @freq_subday_interval) + N' hour(s)'
    END
  IF (@freq_subday_type IN (0x2, 0x4, 0x8))
    SELECT @schedule_description = @schedule_description + N' between ' +
           CONVERT(NVARCHAR, @active_start_time) + N' and ' + CONVERT(NVARCHAR, @active_end_time)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_help_jobschedule]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[sp_help_jobschedule]
  @job_id              UNIQUEIDENTIFIER = NULL,
  @job_name            sysname          = NULL,
  @schedule_name       sysname          = NULL,
  @schedule_id         INT              = NULL,
  @include_description BIT              = 0 -- 1 if a schedule description is required (NOTE: It's expensive to generate the description)
AS
BEGIN
  DECLARE @retval                 INT
  DECLARE @schedule_description   NVARCHAR(255)
  DECLARE @name                   sysname
  DECLARE @freq_type              INT
  DECLARE @freq_interval          INT
  DECLARE @freq_subday_type       INT
  DECLARE @freq_subday_interval   INT
  DECLARE @freq_relative_interval INT
  DECLARE @freq_recurrence_factor INT
  DECLARE @active_start_date      INT
  DECLARE @active_end_date        INT
  DECLARE @active_start_time      INT
  DECLARE @active_end_time        INT
  DECLARE @schedule_id_as_char    VARCHAR(10)
  DECLARE @job_count               INT

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @schedule_name = LTRIM(RTRIM(@schedule_name))
  SELECT @job_count = 0

  -- Turn [nullable] empty string parameters into NULLs
  IF (@schedule_name = N'') SELECT @schedule_name = NULL

  -- The user must provide either:
  -- 1) job_id (or job_name) and (optionally) a schedule name
  -- or...
  -- 2) just schedule_id
  IF (@schedule_id IS NULL) AND
     (@job_id      IS NULL) AND
     (@job_name    IS NULL)
  BEGIN
    RAISERROR(14273, -1, -1)
    RETURN(1) -- Failure
  END

  IF (@schedule_id IS NOT NULL) AND ((@job_id        IS NOT NULL) OR
                                     (@job_name      IS NOT NULL) OR
                                     (@schedule_name IS NOT NULL))
  BEGIN
    RAISERROR(14273, -1, -1)
    RETURN(1) -- Failure
  END

  -- Check that the schedule (by ID) exists and it is only used by one job. 
  -- Allowing this for backward compatibility with versions prior to V9
  IF (@schedule_id IS NOT NULL) AND 
     (@job_id      IS NULL) AND
     (@job_name    IS NULL)
  BEGIN
  
    SELECT @job_count = COUNT(*)
    FROM dbo.sysjobschedules
    WHERE (schedule_id = @schedule_id) 
    
    if(@job_count > 1)
    BEGIN
      SELECT @schedule_id_as_char = CONVERT(VARCHAR, @schedule_id)
      RAISERROR(14369, -1, -1, @schedule_id_as_char)
      RETURN(1) -- Failure
    END
  
    SELECT @job_id = job_id
    FROM dbo.sysjobschedules
    WHERE (schedule_id = @schedule_id)
    IF (@job_id IS NULL)
    BEGIN
      SELECT @schedule_id_as_char = CONVERT(VARCHAR, @schedule_id)
      RAISERROR(14262, -1, -1, '@schedule_id', @schedule_id_as_char)
      RETURN(1) -- Failure
    END
  END

  -- Check that we can uniquely identify the job
  IF (@job_id IS NOT NULL) OR (@job_name IS NOT NULL)
  BEGIN
    EXECUTE @retval = sp_verify_job_identifiers '@job_name',
                                                '@job_id',
                                                 @job_name OUTPUT,
                                                 @job_id   OUTPUT,
                                                'NO_TEST'
    IF (@retval <> 0)
      RETURN(1) -- Failure
  END

  IF (@schedule_id IS NOT NULL OR @schedule_name IS NOT NULL)
  BEGIN
    -- Check that we can uniquely identify the schedule
    EXECUTE @retval = dbo.sp_verify_schedule_identifiers @name_of_name_parameter = '@schedule_name',
                                                              @name_of_id_parameter   = '@schedule_id',
                                                              @schedule_name          = @schedule_name OUTPUT,
                                                              @schedule_id            = @schedule_id   OUTPUT,
                                                              @owner_sid              = NULL,
                                                              @orig_server_id         = NULL,
                                                              @job_id_filter          = @job_id
    IF (@retval <> 0)
      RETURN(1) -- Failure
  
  END

  -- Check that the schedule (by name) exists
  IF (@schedule_name IS NOT NULL)
  BEGIN
    IF (NOT EXISTS (SELECT *
                    FROM dbo.sysjobschedules AS js
                      JOIN dbo.sysschedules AS s
                        ON js.schedule_id = s.schedule_id
                    WHERE (js.job_id = @job_id)
                      AND (s.name = @schedule_name)))
    BEGIN
      RAISERROR(14262, -1, -1, '@schedule_name', @schedule_name)
      RETURN(1) -- Failure
    END
  END

  -- Get the schedule(s) into a temporary table
  SELECT s.schedule_id,
        'schedule_name' = name,
         enabled,
         freq_type,
         freq_interval,
         freq_subday_type,
         freq_subday_interval,
         freq_relative_interval,
         freq_recurrence_factor,
         active_start_date,
         active_end_date,
         active_start_time,
         active_end_time,
         date_created,
        'schedule_description' = FORMATMESSAGE(14549),
         js.next_run_date,
         js.next_run_time,
         s.schedule_uid
  INTO #temp_jobschedule
  FROM dbo.sysjobschedules AS js
    JOIN dbo.sysschedules AS s
      ON js.schedule_id = s.schedule_id
  WHERE ((@job_id IS NULL) OR (js.job_id = @job_id))
    AND ((@schedule_name IS NULL) OR (s.name = @schedule_name))
    AND ((@schedule_id IS NULL) OR (s.schedule_id = @schedule_id))

  IF (@include_description = 1)
  BEGIN
    -- For each schedule, generate the textual schedule description and update the temporary
    -- table with it
    IF (EXISTS (SELECT *
                FROM #temp_jobschedule))
    BEGIN
      WHILE (EXISTS (SELECT *
                     FROM #temp_jobschedule
                     WHERE schedule_description = FORMATMESSAGE(14549)))
      BEGIN
        SET ROWCOUNT 1
        SELECT @name                   = schedule_name,
               @freq_type              = freq_type,
               @freq_interval          = freq_interval,
               @freq_subday_type       = freq_subday_type,
               @freq_subday_interval   = freq_subday_interval,
               @freq_relative_interval = freq_relative_interval,
               @freq_recurrence_factor = freq_recurrence_factor,
               @active_start_date      = active_start_date,
               @active_end_date        = active_end_date,
               @active_start_time      = active_start_time,
               @active_end_time        = active_end_time
        FROM #temp_jobschedule
        WHERE (schedule_description = FORMATMESSAGE(14549))
        SET ROWCOUNT 0

        EXECUTE sp_get_schedule_description
          @freq_type,
          @freq_interval,
          @freq_subday_type,
          @freq_subday_interval,
          @freq_relative_interval,
          @freq_recurrence_factor,
          @active_start_date,
          @active_end_date,
          @active_start_time,
          @active_end_time,
          @schedule_description OUTPUT

        UPDATE #temp_jobschedule
        SET schedule_description = ISNULL(LTRIM(RTRIM(@schedule_description)), FORMATMESSAGE(14205))
        WHERE (schedule_name = @name)
      END -- While
    END
  END

  -- Return the result set, adding job count to it
  SELECT *, (SELECT COUNT(*) FROM sysjobschedules WHERE sysjobschedules.schedule_id = #temp_jobschedule.schedule_id) as 'job_count'
  FROM #temp_jobschedule
  ORDER BY schedule_id

  RETURN(@@error) -- 0 means success
END


GO
/****** Object:  StoredProcedure [dbo].[sp_help_jobstep]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_help_jobstep]
  @job_id    UNIQUEIDENTIFIER = NULL, -- Must provide either this or job_name
  @job_name  sysname          = NULL, -- Must provide either this or job_id
  @step_id   INT              = NULL,
  @step_name sysname          = NULL,
  @suffix    BIT              = 0     -- A flag to control how the result set is formatted
AS
BEGIN
  DECLARE @retval      INT
  DECLARE @max_step_id INT
  DECLARE @valid_range VARCHAR(50)

  SET NOCOUNT ON

  EXECUTE @retval = sp_verify_job_identifiers '@job_name',
                                              '@job_id',
                                               @job_name OUTPUT,
                                               @job_id   OUTPUT,
                                              'NO_TEST'
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- The suffix flag must be either 0 (ie. no suffix) or 1 (ie. add suffix). 0 is the default.
  IF (@suffix <> 0)
    SELECT @suffix = 1

  -- Check step id (if supplied)
  IF (@step_id IS NOT NULL)
  BEGIN
    -- Get current maximum step id
    SELECT @max_step_id = ISNULL(MAX(step_id), 0)
    FROM dbo.sysjobsteps
    WHERE job_id = @job_id
   IF @max_step_id = 0
   BEGIN
      RAISERROR(14528, -1, -1, @job_name)
      RETURN(1) -- Failure 
   END
    ELSE IF (@step_id < 1) OR (@step_id > @max_step_id)
    BEGIN
      SELECT @valid_range = '1..' + CONVERT(VARCHAR, @max_step_id)
      RAISERROR(14266, -1, -1, '@step_id', @valid_range)
      RETURN(1) -- Failure
    END
  END

  -- Check step name (if supplied)
  -- NOTE: A supplied step id overrides a supplied step name
  IF ((@step_id IS NULL) AND (@step_name IS NOT NULL))
  BEGIN
    SELECT @step_id = step_id
    FROM dbo.sysjobsteps
    WHERE (step_name = @step_name)
      AND (job_id = @job_id)

    IF (@step_id IS NULL)
    BEGIN
      RAISERROR(14262, -1, -1, '@step_name', @step_name)
      RETURN(1) -- Failure
    END
  END

  -- Return the job steps for this job (or just return the specific step)
  IF (@suffix = 0)
  BEGIN
    SELECT step_id,
           step_name,
           subsystem,
           command,
           flags,
           cmdexec_success_code,
           on_success_action,
           on_success_step_id,
           on_fail_action,
           on_fail_step_id,
           server,
           database_name,
           database_user_name,
           retry_attempts,
           retry_interval,
           os_run_priority,
           output_file_name,
           last_run_outcome,
           last_run_duration,
           last_run_retries,
           last_run_date,
           last_run_time,
         proxy_id
    FROM dbo.sysjobsteps
    WHERE (job_id = @job_id)
      AND ((@step_id IS NULL) OR (step_id = @step_id))
    ORDER BY job_id, step_id
  END
  ELSE
  BEGIN
    SELECT step_id,
           step_name,
           subsystem,
           command,
          'flags' = CONVERT(NVARCHAR, flags) + N' (' +
                    ISNULL(CASE WHEN (flags = 0)     THEN FORMATMESSAGE(14561) END, '') +
                    ISNULL(CASE WHEN (flags & 1) = 1 THEN FORMATMESSAGE(14558) + ISNULL(CASE WHEN (flags > 1) THEN N', ' END, '') END, '') +
                    ISNULL(CASE WHEN (flags & 2) = 2 THEN FORMATMESSAGE(14559) + ISNULL(CASE WHEN (flags > 3) THEN N', ' END, '') END, '') +
                    ISNULL(CASE WHEN (flags & 4) = 4 THEN FORMATMESSAGE(14560) END, '') + N')',
           cmdexec_success_code,
          'on_success_action' = CASE on_success_action
                                  WHEN 1 THEN CONVERT(NVARCHAR, on_success_action) + N' ' + FORMATMESSAGE(14562)
                                  WHEN 2 THEN CONVERT(NVARCHAR, on_success_action) + N' ' + FORMATMESSAGE(14563)
                                  WHEN 3 THEN CONVERT(NVARCHAR, on_success_action) + N' ' + FORMATMESSAGE(14564)
                                  WHEN 4 THEN CONVERT(NVARCHAR, on_success_action) + N' ' + FORMATMESSAGE(14565)
                                  ELSE        CONVERT(NVARCHAR, on_success_action) + N' ' + FORMATMESSAGE(14205)
                                END,
           on_success_step_id,
          'on_fail_action' = CASE on_fail_action
                               WHEN 1 THEN CONVERT(NVARCHAR, on_fail_action) + N' ' + FORMATMESSAGE(14562)
                               WHEN 2 THEN CONVERT(NVARCHAR, on_fail_action) + N' ' + FORMATMESSAGE(14563)
                               WHEN 3 THEN CONVERT(NVARCHAR, on_fail_action) + N' ' + FORMATMESSAGE(14564)
                               WHEN 4 THEN CONVERT(NVARCHAR, on_fail_action) + N' ' + FORMATMESSAGE(14565)
                               ELSE        CONVERT(NVARCHAR, on_fail_action) + N' ' + FORMATMESSAGE(14205)
                             END,
           on_fail_step_id,
           server,
           database_name,
           database_user_name,
           retry_attempts,
           retry_interval,
          'os_run_priority' = CASE os_run_priority
                                WHEN -15 THEN CONVERT(NVARCHAR, os_run_priority) + N' ' + FORMATMESSAGE(14566)
                                WHEN -1  THEN CONVERT(NVARCHAR, os_run_priority) + N' ' + FORMATMESSAGE(14567)
                                WHEN  0  THEN CONVERT(NVARCHAR, os_run_priority) + N' ' + FORMATMESSAGE(14561)
                                WHEN  1  THEN CONVERT(NVARCHAR, os_run_priority) + N' ' + FORMATMESSAGE(14568)
                                WHEN  15 THEN CONVERT(NVARCHAR, os_run_priority) + N' ' + FORMATMESSAGE(14569)
                                ELSE          CONVERT(NVARCHAR, os_run_priority) + N' ' + FORMATMESSAGE(14205)
                              END,
           output_file_name,
           last_run_outcome,
           last_run_duration,
           last_run_retries,
           last_run_date,
           last_run_time,
         proxy_id
    FROM dbo.sysjobsteps
    WHERE (job_id = @job_id)
      AND ((@step_id IS NULL) OR (step_id = @step_id))
    ORDER BY job_id, step_id
  END

  RETURN(@@error) -- 0 means success

END

GO
/****** Object:  StoredProcedure [dbo].[sp_post_msx_operation]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_post_msx_operation]
  @operation              VARCHAR(64),
  @object_type            VARCHAR(64)       = 'JOB',-- Can be JOB, SERVER or SCHEDULE
  @job_id                 UNIQUEIDENTIFIER  = NULL, -- NOTE: 0x00 means 'ALL' jobs
  @specific_target_server sysname           = NULL,
  @value                  INT               = NULL, -- For polling interval value
  @schedule_uid           UNIQUEIDENTIFIER  = NULL  -- schedule_uid if the @object_type = 'SCHEDULE'
AS
BEGIN
  DECLARE @operation_code            INT
  DECLARE @specific_target_server_id INT
  DECLARE @instructions_posted       INT
  DECLARE @job_id_as_char            VARCHAR(36)
  DECLARE @schedule_uid_as_char      VARCHAR(36)
  DECLARE @msx_time_zone_adjustment  INT
  DECLARE @local_machine_name        sysname
  DECLARE @retval                    INT

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @operation              = LTRIM(RTRIM(@operation))
  SELECT @object_type            = LTRIM(RTRIM(@object_type))
  SELECT @specific_target_server = LTRIM(RTRIM(@specific_target_server))

  -- Turn [nullable] empty string parameters into NULLs
  IF (@specific_target_server = N'') SELECT @specific_target_server = NULL

  -- Only a sysadmin can do this, but fail silently for a non-sysadmin
  IF (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1) 
    RETURN(0) -- Success (or more accurately a no-op)

  -- Check operation
  SELECT @operation = UPPER(@operation collate SQL_Latin1_General_CP1_CS_AS)
  SELECT @operation_code = CASE @operation
                             WHEN 'INSERT'    THEN 1
                             WHEN 'UPDATE'    THEN 2
                             WHEN 'DELETE'    THEN 3
                             WHEN 'START'     THEN 4
                             WHEN 'STOP'      THEN 5
                             WHEN 'RE-ENLIST' THEN 6
                             WHEN 'DEFECT'    THEN 7
                             WHEN 'SYNC-TIME' THEN 8
                             WHEN 'SET-POLL'  THEN 9
                             ELSE 0
                           END
  IF (@operation_code = 0)
  BEGIN
    RAISERROR(14266, -1, -1, '@operation_code', 'INSERT, UPDATE, DELETE, START, STOP, RE-ENLIST, DEFECT, SYNC-TIME, SET-POLL')
    RETURN(1) -- Failure
  END

  -- Check object type (in 9.0 only 'JOB', 'SERVER' or 'SCHEDULE'are valid)
  IF ((@object_type <> 'JOB') AND (@object_type <> 'SERVER') AND (@object_type <> 'SCHEDULE'))
  BEGIN
    RAISERROR(14266, -1, -1, '@object_type', 'JOB, SERVER, SCHEDULE')
    RETURN(1) -- Failure
  END

  -- Check that for a object type of JOB a job_id has been supplied
  IF ((@object_type = 'JOB') AND (@job_id IS NULL))
  BEGIN
    RAISERROR(14233, -1, -1)
    RETURN(1) -- Failure
  END
  
    -- Check that for a object type of JOB a job_id has been supplied
  IF ((@object_type = 'SCHEDULE') AND (@schedule_uid IS NULL))
  BEGIN
    RAISERROR(14365, -1, -1)
    RETURN(1) -- Failure
  END

  -- Check polling interval value
  IF (@operation_code = 9) AND ((ISNULL(@value, 0) < 10) OR (ISNULL(@value, 0) > 28800))
  BEGIN
    RAISERROR(14266, -1, -1, '@value', '10..28800')
    RETURN(1) -- Failure
  END

  -- Check specific target server
  IF (@specific_target_server IS NOT NULL)
  BEGIN
    SELECT @specific_target_server = UPPER(@specific_target_server)

    -- Check if the local server is being targeted
    IF (@specific_target_server = UPPER(CONVERT(sysname, SERVERPROPERTY('ServerName'))))
    BEGIN
      RETURN(0)
    END
    ELSE
    BEGIN
      SELECT @specific_target_server_id = server_id
      FROM dbo.systargetservers
      WHERE (UPPER(server_name) = @specific_target_server)
      IF (@specific_target_server_id IS NULL)
      BEGIN
        RAISERROR(14262, -1, -1, '@specific_target_server', @specific_target_server)
        RETURN(1) -- Failure
      END
    END
  END

  -- Check that this server is an MSX server
  IF ((SELECT COUNT(*)
       FROM dbo.systargetservers) = 0)
  BEGIN
    RETURN(0)
  END

  -- Get local machine name
  EXECUTE @retval = master.dbo.xp_getnetname @local_machine_name OUTPUT
  IF (@retval <> 0) OR (@local_machine_name IS NULL)
  BEGIN
    RAISERROR(14225, -1, -1)
    RETURN(1)
  END

  -- Job-specific processing...
  IF (@object_type = 'JOB')
  BEGIN
    -- Validate the job (if supplied)
    IF (@job_id <> CONVERT(UNIQUEIDENTIFIER, 0x00))
    BEGIN
      SELECT @job_id_as_char = CONVERT(VARCHAR(36), @job_id)

      -- Check if the job exists
      IF (NOT EXISTS (SELECT *
                      FROM dbo.sysjobs_view
                      WHERE (job_id = @job_id)))
      BEGIN
        RAISERROR(14262, -1, -1, '@job_id', @job_id_as_char)
        RETURN(1) -- Failure
      END

      -- If this is a local job then there's nothing for us to do
      IF (EXISTS (SELECT *
                  FROM dbo.sysjobservers
                  WHERE (job_id = @job_id)
                    AND (server_id = 0))) -- 0 means local server
      OR (NOT EXISTS (SELECT *
                      FROM dbo.sysjobservers
                      WHERE (job_id = @job_id)))
      BEGIN
        RETURN(0)
      END
    END

    -- Generate the sysdownloadlist row(s)...
    IF (@operation_code = 1) OR  -- Insert
       (@operation_code = 2) OR  -- Update
       (@operation_code = 3) OR  -- Delete
       (@operation_code = 4) OR  -- Start
       (@operation_code = 5)     -- Stop
    BEGIN
      IF (@job_id = CONVERT(UNIQUEIDENTIFIER, 0x00)) -- IE. 'ALL'
      BEGIN
        -- All jobs

        -- Handle DELETE as a special case (rather than posting 1 instruction per job we just
        -- post a single instruction that means 'delete all jobs from the MSX')
        IF (@operation_code = 3)
        BEGIN
          INSERT INTO dbo.sysdownloadlist
                (source_server,
                 operation_code,
                 object_type,
                 object_id,
                 target_server)
          SELECT @local_machine_name,
                 @operation_code,
                 1,                -- 1 means 'JOB'
                 CONVERT(UNIQUEIDENTIFIER, 0x00),
                 sts.server_name
          FROM systargetservers sts
          WHERE ((@specific_target_server_id IS NULL) OR (sts.server_id = @specific_target_server_id))
            AND ((SELECT COUNT(*)
                  FROM dbo.sysjobservers
                  WHERE (server_id = sts.server_id)) > 0)
          SELECT @instructions_posted = @@rowcount
        END
        ELSE
        BEGIN
          INSERT INTO dbo.sysdownloadlist
                (source_server,
                 operation_code,
                 object_type,
                 object_id,
                 target_server)
          SELECT @local_machine_name,
                 @operation_code,
                 1,                -- 1 means 'JOB'
                 sjv.job_id,
                 sts.server_name
          FROM sysjobs_view     sjv,
               sysjobservers    sjs,
               systargetservers sts
          WHERE (sjv.job_id = sjs.job_id)
            AND (sjs.server_id = sts.server_id)
            AND (sjs.server_id <> 0) -- We want to exclude local jobs
            AND ((@specific_target_server_id IS NULL) OR (sjs.server_id = @specific_target_server_id))
          SELECT @instructions_posted = @@rowcount
        END
      END
      ELSE
      BEGIN
        -- Specific job (ie. @job_id is not 0x00)
        INSERT INTO dbo.sysdownloadlist
              (source_server,
               operation_code,
               object_type,
               object_id,
               target_server,
               deleted_object_name)
        SELECT @local_machine_name,
               @operation_code,
               1,                -- 1 means 'JOB'
               sjv.job_id,
               sts.server_name,
               CASE @operation_code WHEN 3 -- Delete
                                      THEN sjv.name
                                      ELSE NULL
                                    END
        FROM sysjobs_view     sjv,
             sysjobservers    sjs,
             systargetservers sts
        WHERE (sjv.job_id = @job_id)
          AND (sjv.job_id = sjs.job_id)
          AND (sjs.server_id = sts.server_id)
          AND (sjs.server_id <> 0) -- We want to exclude local jobs
          AND ((@specific_target_server_id IS NULL) OR (sjs.server_id = @specific_target_server_id))
        SELECT @instructions_posted = @@rowcount
      END
    END
    ELSE
    BEGIN
      RAISERROR(14266, -1, -1, '@operation_code', 'INSERT, UPDATE, DELETE, START, STOP')
      RETURN(1) -- Failure
    END
  END
  
  
  -- SCHEDULE specific processing for INSERT, UPDATE or DELETE schedule operations
  -- All msx jobs that use the specified @schedule_uid will be notified with an Insert operation. 
  -- This will cause agent to reload all schedules for each job. 
  -- This is compatible with the legacy shiloh servers that don't know about reusable schedules
  IF (@object_type = 'SCHEDULE')
  BEGIN
    -- Validate the schedule
    -- Check if the schedule exists
    IF (NOT EXISTS (SELECT *
                    FROM dbo.sysschedules_localserver_view
                    WHERE (schedule_uid = @schedule_uid)))
    BEGIN
      SELECT @schedule_uid_as_char = CONVERT(VARCHAR(36), @schedule_uid)
      
      RAISERROR(14262, -1, -1, '@schedule_uid', @schedule_uid_as_char)
      RETURN(1) -- Failure
    END

    -- If this schedule is only used locally (no target servers) then there's nothing to do
    IF (NOT EXISTS (SELECT *
                    FROM dbo.sysschedules    s,
                        dbo.sysjobschedules  js,
                        dbo.sysjobs_view     sjv,
                        dbo.sysjobservers    sjs,
                        dbo.systargetservers sts
                    WHERE (s.schedule_uid = @schedule_uid)
                    AND (s.schedule_id = js.schedule_id)
                    AND (sjv.job_id = js.job_id)
                    AND (sjv.job_id = sjs.job_id)
                    AND (sjs.server_id = sts.server_id)
                    AND (sjs.server_id <> 0)))                        
    BEGIN
      RETURN(0)
    END

    -- Generate the sysdownloadlist row(s)...
    IF (@operation_code = 1) OR  -- Insert
       (@operation_code = 2) OR  -- Update
       (@operation_code = 3)     -- Delete
    BEGIN
      -- Insert specific schedule into sysdownloadlist 
      -- We need to create a sysdownloadlist JOB INSERT record for each job that runs the schedule
     INSERT INTO dbo.sysdownloadlist
         (source_server,
          operation_code,
          object_type,
          object_id,
          target_server)
     SELECT @local_machine_name,
          1,             -- 1 means 'Insert'
          1,             -- 1 means 'JOB'
          sjv.job_id,
          sts.server_name
     FROM dbo.sysschedules     s,
           dbo.sysjobschedules  js,
           dbo.sysjobs_view     sjv,
         dbo.sysjobservers    sjs,
         systargetservers          sts
     WHERE (s.schedule_id = js.schedule_id)
        AND (js.job_id = sjv.job_id)
        AND (sjv.job_id = sjs.job_id)
      AND (sjs.server_id = sts.server_id)
        AND (s.schedule_uid = @schedule_uid)
      AND (sjs.server_id <> 0)            -- We want to exclude local jobs
      AND ((@specific_target_server_id IS NULL) OR (sjs.server_id = @specific_target_server_id))

      SELECT @instructions_posted = @@rowcount


    END
    ELSE
    BEGIN
      RAISERROR(14266, -1, -1, '@operation_code', 'UPDATE, DELETE')
      RETURN(1) -- Failure
    END
  END
  

  -- Server-specific processing...
  IF (@object_type = 'SERVER')
  BEGIN
    -- Generate the sysdownloadlist row(s)...
    IF (@operation_code = 6) OR  -- ReEnlist
       (@operation_code = 7) OR  -- Defect
       (@operation_code = 8) OR  -- Synchronize time (with MSX)
       (@operation_code = 9)     -- Set MSX polling interval (in seconds)
    BEGIN
      IF (@operation_code = 8)
      BEGIN
        EXECUTE master.dbo.xp_regread N'HKEY_LOCAL_MACHINE',
                                      N'SYSTEM\CurrentControlSet\Control\TimeZoneInformation',
                                      N'Bias',
                                      @msx_time_zone_adjustment OUTPUT,
                                      N'no_output'
        SELECT @msx_time_zone_adjustment = -ISNULL(@msx_time_zone_adjustment, 0)
      END

      INSERT INTO dbo.sysdownloadlist
            (source_server,
             operation_code,
             object_type,
             object_id,
             target_server)
      SELECT @local_machine_name,
             @operation_code,
             2,                  -- 2 means 'SERVER'
             CASE @operation_code
               WHEN 8 THEN CONVERT(UNIQUEIDENTIFIER, CONVERT(BINARY(16), -(@msx_time_zone_adjustment - sts.time_zone_adjustment)))
               WHEN 9 THEN CONVERT(UNIQUEIDENTIFIER, CONVERT(BINARY(16), @value))
               ELSE CONVERT(UNIQUEIDENTIFIER, 0x00)
             END,
             sts.server_name
      FROM systargetservers sts
      WHERE ((@specific_target_server_id IS NULL) OR (sts.server_id = @specific_target_server_id))
      SELECT @instructions_posted = @@rowcount
    END
    ELSE
    BEGIN
      RAISERROR(14266, -1, -1, '@operation_code', 'RE-ENLIST, DEFECT, SYNC-TIME, SET-POLL')
      RETURN(1) -- Failure
    END
  END


  -- Report number of rows inserted
  IF (@object_type = 'JOB') AND
     (@job_id = CONVERT(UNIQUEIDENTIFIER, 0x00)) AND
     (@instructions_posted = 0) AND
     (@specific_target_server_id IS NOT NULL)
    RAISERROR(14231, 0, 1, '@specific_target_server', @specific_target_server)
  ELSE
    RAISERROR(14230, 0, 1, @instructions_posted, @operation)

  -- Delete any [downloaded] instructions that are over the registry-defined limit
  IF (@specific_target_server IS NOT NULL)
    EXECUTE dbo.sp_downloaded_row_limiter @specific_target_server

  RETURN(0) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sqlagent_log_jobhistory]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_sqlagent_log_jobhistory]
  @job_id               UNIQUEIDENTIFIER,
  @step_id              INT,
  @sql_message_id       INT = 0,
  @sql_severity         INT = 0,
  @message              NVARCHAR(4000) = NULL,
  @run_status           INT, -- SQLAGENT_EXEC_X code
  @run_date             INT,
  @run_time             INT,
  @run_duration         INT,
  @operator_id_emailed  INT = 0,
  @operator_id_netsent  INT = 0,
  @operator_id_paged    INT = 0,
  @retries_attempted    INT,
  @server               sysname = NULL,
  @session_id           INT = 0
AS
BEGIN
  DECLARE @retval              INT
  DECLARE @operator_id_as_char VARCHAR(10)
  DECLARE @step_name           sysname
  DECLARE @error_severity      INT

  SET NOCOUNT ON

  IF (@server IS NULL) OR (UPPER(@server collate SQL_Latin1_General_CP1_CS_AS) = '(LOCAL)')
    SELECT @server = UPPER(CONVERT(sysname, SERVERPROPERTY('ServerName')))

  -- Check authority (only SQLServerAgent can add a history entry for a job)
  EXECUTE @retval = sp_verify_jobproc_caller @job_id = @job_id, @program_name = N'SQLAgent%'
  IF (@retval <> 0)
    RETURN(@retval)

  -- NOTE: We raise all errors as informational (sev 0) to prevent SQLServerAgent from caching
  --       the operation (if it fails) since if the operation will never run successfully we
  --       don't want it to stay around in the operation cache.
  SELECT @error_severity = 0

  -- Check job_id
  IF (NOT EXISTS (SELECT *
                  FROM dbo.sysjobs_view
                  WHERE (job_id = @job_id)))
  BEGIN
    DECLARE @job_id_as_char      VARCHAR(36)
    SELECT @job_id_as_char = CONVERT(VARCHAR(36), @job_id)
    RAISERROR(14262, @error_severity, -1, 'Job', @job_id_as_char)
    RETURN(1) -- Failure
  END
/*
  -- Check step id
  IF (@step_id <> 0) -- 0 means 'for the whole job'
  BEGIN
    SELECT @step_name = step_name
    FROM dbo.sysjobsteps
    WHERE (job_id = @job_id)
      AND (step_id = @step_id)
    IF (@step_name IS NULL)
    BEGIN
      DECLARE @step_id_as_char     VARCHAR(10)
      SELECT @step_id_as_char = CONVERT(VARCHAR, @step_id)
      RAISERROR(14262, @error_severity, -1, '@step_id', @step_id_as_char)
      RETURN(1) -- Failure
    END
  END
  ELSE
    SELECT @step_name = FORMATMESSAGE(14570)
*/
  -- Check run_status
  IF (@run_status NOT IN (0, 1, 2, 3, 4, 5)) -- SQLAGENT_EXEC_X code
  BEGIN
    RAISERROR(14266, @error_severity, -1, '@run_status', '0, 1, 2, 3, 4, 5')
    RETURN(1) -- Failure
  END

  -- Check run_date
  EXECUTE @retval = sp_verify_job_date @run_date, '@run_date', 10
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Check run_time
  EXECUTE @retval = sp_verify_job_time @run_time, '@run_time', 10
  IF (@retval <> 0)
    RETURN(1) -- Failure
/*
  -- Check operator_id_emailed
  IF (@operator_id_emailed <> 0)
  BEGIN
    IF (NOT EXISTS (SELECT *
                    FROM dbo.sysoperators
                    WHERE (id = @operator_id_emailed)))
    BEGIN
      SELECT @operator_id_as_char = CONVERT(VARCHAR, @operator_id_emailed)
      RAISERROR(14262, @error_severity, -1, '@operator_id_emailed', @operator_id_as_char)
      RETURN(1) -- Failure
    END
  END

  -- Check operator_id_netsent
  IF (@operator_id_netsent <> 0)
  BEGIN
    IF (NOT EXISTS (SELECT *
                    FROM dbo.sysoperators
                    WHERE (id = @operator_id_netsent)))
    BEGIN
      SELECT @operator_id_as_char = CONVERT(VARCHAR, @operator_id_netsent)
      RAISERROR(14262, @error_severity, -1, '@operator_id_netsent', @operator_id_as_char)
      RETURN(1) -- Failure
    END
  END

  -- Check operator_id_paged
  IF (@operator_id_paged <> 0)
  BEGIN
    IF (NOT EXISTS (SELECT *
                    FROM dbo.sysoperators
                    WHERE (id = @operator_id_paged)))
    BEGIN
      SELECT @operator_id_as_char = CONVERT(VARCHAR, @operator_id_paged)
      RAISERROR(14262, @error_severity, -1, '@operator_id_paged', @operator_id_as_char)
      RETURN(1) -- Failure
    END
  END
*/
  -- Insert the history row
  INSERT INTO dbo.sysjobhistory
         (job_id,
          step_id,
          step_name,
          sql_message_id,
          sql_severity,
          message,
          run_status,
          run_date,
          run_time,
          run_duration,
          operator_id_emailed,
          operator_id_netsent,
          operator_id_paged,
          retries_attempted,
          server)
  VALUES (@job_id,
          @step_id,
          @step_name,
          @sql_message_id,
          @sql_severity,
          @message,
          @run_status,
          @run_date,
          @run_time,
          @run_duration,
          @operator_id_emailed,
          @operator_id_netsent,
          @operator_id_paged,
          @retries_attempted,
          @server)
/*
  -- Update sysjobactivity table 
  IF (@step_id = 0) --only update for job, not for each step
  BEGIN
    UPDATE dbo.sysjobactivity
    SET stop_execution_date = DATEADD(ms, -DATEPART(ms, GetDate()),  GetDate()),
        job_history_id = SCOPE_IDENTITY()
    WHERE
        session_id = @session_id AND job_id = @job_id
  END

  -- Special handling of replication jobs 
  DECLARE @job_name sysname
  DECLARE @category_id int
  SELECT  @job_name = name, @category_id = category_id from dbo.sysjobs 
   WHERE job_id = @job_id 
 
  -- If replicatio agents (snapshot, logreader, distribution, merge, and queuereader
  -- and the step has been canceled and if we are at the distributor.
  IF @category_id in (10,13,14,15,19) and @run_status = 3 and 
   object_id('MSdistributiondbs') is not null
  BEGIN
    -- Get the database
    DECLARE @database sysname
    SELECT @database = database_name from sysjobsteps where job_id = @job_id and 
   lower(subsystem) in (N'distribution', N'logreader','snapshot',N'merge',
      N'queuereader')
    -- If the database is a distribution database
    IF EXISTS (select * from MSdistributiondbs where name = @database)
    BEGIN
   DECLARE @proc nvarchar(500)
   SELECT @proc = quotename(@database) + N'.dbo.sp_MSlog_agent_cancel'
   EXEC @proc @job_id = @job_id, @category_id = @category_id, 
      @message = @message
    END  
  END

  -- Delete any history rows that are over the registry-defined limits
  IF (@step_id = 0) --only check once per job execution.
  BEGIN
    EXECUTE dbo.sp_jobhistory_row_limiter @job_id
  END
  */
  RETURN(@@error) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sqlagent_notify]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_sqlagent_notify]
  @op_type     NCHAR(1),                -- One of: J (Job action [refresh or start/stop]),
                                        --         S (Schedule action [refresh only])
                                        --         A (Alert action [refresh only]),
                                        --         G (Re-cache all registry settings),
                                        --         D (Dump job [or job schedule] cache to errorlog)
                                        --         P (Force an immediate poll of the MSX)
                                        --         L (Cycle log file)
                                        --         T (Test WMI parameters (namespace and query))
                                        --         M (DatabaseMail action [ refresh profile  associated with sql agent)
  @job_id      UNIQUEIDENTIFIER = NULL, -- JobID (for OpTypes 'J', 'S' and 'D')
  @schedule_id INT              = NULL, -- ScheduleID (for OpType 'S')
  @alert_id    INT              = NULL, -- AlertID (for OpType 'A')
  @action_type NCHAR(1)         = NULL, -- For 'J' one of: R (Run - no service check),
                                        --                 S (Start - with service check),
                                        --                 I (Insert),
                                        --                 U (Update),
                                        --                 D (Delete),
                                        --                 C (Stop [Cancel])
                                        -- For 'S' or 'A' one of: I (Insert),
                                        --                        U (Update),
                                        --                        D (Delete)
  @error_flag  INT              = 1,    -- Set to 0 to suppress the error from xp_sqlagent_notify if SQLServer agent is not running
  @wmi_namespace nvarchar(128) = NULL,
  @wmi_query     nvarchar(512) = NULL
AS
BEGIN



  DECLARE @retval         INT
  DECLARE @id_as_char     VARCHAR(10)
  DECLARE @job_id_as_char VARCHAR(36)
  DECLARE @nt_user_name   NVARCHAR(100)
   
  

  SET NOCOUNT ON

  SELECT @retval = 0 -- Success

  -- Make sure that we're dealing only with uppercase characters
  SELECT @op_type     = UPPER(@op_type collate SQL_Latin1_General_CP1_CS_AS)
  SELECT @action_type = UPPER(@action_type collate SQL_Latin1_General_CP1_CS_AS)

  -- Verify operation code
  IF (CHARINDEX(@op_type, N'JSAGDPLTM') = 0)
  BEGIN
    RAISERROR(14266, -1, -1, '@op_type', 'J, S, A, G, D, P, L, T, M')
    RETURN(1) -- Failure
  END

  -- Check the job id for those who use it
  IF (CHARINDEX(@op_type, N'JSD') <> 0)
  BEGIN
    IF (NOT ((@op_type = N'D' OR @op_type = N'S') AND (@job_id IS NULL))) -- For 'D' and 'S' job_id is optional
    BEGIN
      IF ((@job_id IS NULL) OR
          ((@action_type <> N'D') AND NOT EXISTS (SELECT *
                                                  FROM dbo.sysjobs_view
                                                  WHERE (job_id = @job_id))))
      BEGIN
        SELECT @job_id_as_char = CONVERT(VARCHAR(36), @job_id)
        RAISERROR(14262, -1, -1, '@job_id', @job_id_as_char)
        RETURN(1) -- Failure
      END
    END
  END

  -- Verify 'job' action parameters
  IF (@op_type = N'J')
  BEGIN
    SELECT @alert_id = 0
    IF (@schedule_id IS NULL) SELECT @schedule_id = 0

    -- The schedule_id (if specified) is the start step
    IF ((CHARINDEX(@action_type, N'RS') <> 0) AND (@schedule_id <> 0))
    BEGIN
      IF (NOT EXISTS (SELECT *
                      FROM dbo.sysjobsteps
                      WHERE (job_id = @job_id)
                        AND (step_id = @schedule_id)))
      BEGIN
        SELECT @id_as_char = ISNULL(CONVERT(VARCHAR, @schedule_id), '(null)')
        RAISERROR(14262, -1, -1, '@schedule_id', @id_as_char)
        RETURN(1) -- Failure
      END
    END
    ELSE
      SELECT @schedule_id = 0

    IF (CHARINDEX(@action_type, N'RSIUDC') = 0)
    BEGIN
      RAISERROR(14266, -1, -1, '@action_type', 'R, S, I, U, D, C')
      RETURN(1) -- Failure
    END
  END

  -- Verify 'schedule' action parameters
  IF (@op_type = N'S')
  BEGIN
    SELECT @alert_id = 0

    IF (CHARINDEX(@action_type, N'IUD') = 0)
    BEGIN
      RAISERROR(14266, -1, -1, '@action_type', 'I, U, D')
      RETURN(1) -- Failure
    END

    IF ((@schedule_id IS NULL) OR
        ((@action_type <> N'D') AND NOT EXISTS (SELECT *
                                                FROM dbo.sysschedules
                                                WHERE (schedule_id = @schedule_id))))
    BEGIN
      SELECT @id_as_char = ISNULL(CONVERT(VARCHAR, @schedule_id), '(null)')
      RAISERROR(14262, -1, -1, '@schedule_id', @id_as_char)
      RETURN(1) -- Failure
    END
  END

  -- Verify 'alert' action parameters
  IF (@op_type = N'A')
  BEGIN
    SELECT @job_id = 0x00
    SELECT @schedule_id = 0

    IF (CHARINDEX(@action_type, N'IUD') = 0)
    BEGIN
      RAISERROR(14266, -1, -1, '@action_type', 'I, U, D')
      RETURN(1) -- Failure
    END

    IF ((@alert_id IS NULL) OR
        ((@action_type <> N'D') AND NOT EXISTS (SELECT *
                                                FROM dbo.sysalerts
                                                WHERE (id = @alert_id))))
    BEGIN
      SELECT @id_as_char = ISNULL(CONVERT(VARCHAR, @alert_id), '(null)')
      RAISERROR(14262, -1, -1, '@alert_id', @id_as_char)
      RETURN(1) -- Failure
    END
  END

  -- Verify 'registry', 'job dump' and 'force MSX poll' , 'cycle log', dbmail profile refresh action parameters
  IF (CHARINDEX(@op_type, N'GDPLM') <> 0)
  BEGIN
    IF (@op_type <> N'D')
      SELECT @job_id = 0x00
    SELECT @alert_id = 0
    SELECT @schedule_id = 0
    SELECT @action_type = NULL
  END

  -- Parameters are valid, so now check execution permissions...

  -- For anything except a job (or schedule) action the caller must be SysAdmin, DBO, or DB_Owner
  IF (@op_type NOT IN (N'J', N'S'))
  BEGIN
    IF NOT ((ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1) OR
            (ISNULL(IS_MEMBER(N'db_owner'), 0) = 1) OR
            (UPPER(USER_NAME() collate SQL_Latin1_General_CP1_CS_AS) = N'DBO'))
    BEGIN
      RAISERROR(14260, -1, -1)
      RETURN(1) -- Failure
    END
  END

  -- For a Job Action the caller must be SysAdmin, DBO, DB_Owner, or the job owner
  IF (@op_type = N'J')
  BEGIN
    IF NOT ((ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1) OR
            (ISNULL(IS_MEMBER(N'db_owner'), 0) = 1) OR
            (UPPER(USER_NAME() collate SQL_Latin1_General_CP1_CS_AS) = N'DBO') OR
            (EXISTS (SELECT *
                     FROM dbo.sysjobs_view
                     WHERE (job_id = @job_id))))
    BEGIN
      RAISERROR(14252, -1, -1)
      RETURN(1) -- Failure
    END
  END

  --verify WMI parameters
  IF (@op_type = N'T')
  BEGIN
   SELECT @wmi_namespace = LTRIM(RTRIM(@wmi_namespace))
   SELECT @wmi_query = LTRIM(RTRIM(@wmi_query))  
    IF (@wmi_namespace IS NULL) or (@wmi_query IS NULL)
   BEGIN
          RAISERROR(14508, 16, 1)
          RETURN(1) -- Failure      
   END
  END

  -- Ok, let's do it...
  SELECT @nt_user_name = ISNULL(NT_CLIENT(), ISNULL(SUSER_SNAME(), FORMATMESSAGE(14205)))
  EXECUTE @retval = master.dbo.xp_sqlagent_notify @op_type, @job_id, @schedule_id, @alert_id, @action_type, @nt_user_name, @error_flag, @@trancount, @wmi_namespace, @wmi_query

  RETURN(@retval)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_update_jobstep]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_update_jobstep]
  @job_id                 UNIQUEIDENTIFIER = NULL, -- Must provide either this or job_name
  @job_name               sysname          = NULL, -- Not updatable (provided for identification purposes only)
  @step_id                INT,                     -- Not updatable (provided for identification purposes only)
  @step_name              sysname          = NULL,
  @subsystem              NVARCHAR(40)     = NULL,
  @command                NVARCHAR(max)    = NULL,
  @additional_parameters  NVARCHAR(max)    = NULL,
  @cmdexec_success_code   INT              = NULL,
  @on_success_action      TINYINT          = NULL,
  @on_success_step_id     INT              = NULL,
  @on_fail_action         TINYINT          = NULL,
  @on_fail_step_id        INT              = NULL,
  @server                 sysname          = NULL,
  @database_name          sysname          = NULL,
  @database_user_name     sysname          = NULL,
  @retry_attempts         INT              = NULL,
  @retry_interval         INT              = NULL,
  @os_run_priority        INT              = NULL,
  @output_file_name       NVARCHAR(200)    = NULL,
  @flags                  INT              = NULL,
  @proxy_id            int          = NULL,
  @proxy_name          sysname         = NULL
  -- mutual exclusive; must specify only one of above 2 parameters to 
  -- identify the proxy. 
AS
BEGIN
  DECLARE @retval                 INT
  DECLARE @os_run_priority_code   INT
  DECLARE @step_id_as_char        VARCHAR(10)
  DECLARE @new_step_name          sysname
  DECLARE @x_step_name            sysname
  DECLARE @x_subsystem            NVARCHAR(40)
  DECLARE @x_command              NVARCHAR(max)
  DECLARE @x_flags                INT
  DECLARE @x_cmdexec_success_code INT
  DECLARE @x_on_success_action    TINYINT
  DECLARE @x_on_success_step_id   INT
  DECLARE @x_on_fail_action       TINYINT
  DECLARE @x_on_fail_step_id      INT
  DECLARE @x_server               sysname
  DECLARE @x_database_name        sysname
  DECLARE @x_database_user_name   sysname
  DECLARE @x_retry_attempts       INT
  DECLARE @x_retry_interval       INT
  DECLARE @x_os_run_priority      INT
  DECLARE @x_output_file_name     NVARCHAR(200)
  DECLARE @x_proxy_id             INT         
  DECLARE @x_last_run_outcome     TINYINT      -- Not updatable (but may be in future)
  DECLARE @x_last_run_duration    INT          -- Not updatable (but may be in future)
  DECLARE @x_last_run_retries     INT          -- Not updatable (but may be in future)
  DECLARE @x_last_run_date        INT          -- Not updatable (but may be in future)
  DECLARE @x_last_run_time        INT          -- Not updatable (but may be in future)

  DECLARE @new_proxy_id           INT
  DECLARE @subsystem_id           INT
  DECLARE @auto_proxy_name        sysname
  DECLARE @job_owner_sid        VARBINARY(85)
  
  SET NOCOUNT ON

  SELECT @new_proxy_id = NULL

  -- Remove any leading/trailing spaces from parameters
  SELECT @step_name          = LTRIM(RTRIM(@step_name))
  SELECT @subsystem          = LTRIM(RTRIM(@subsystem))
  SELECT @command            = LTRIM(RTRIM(@command))
  SELECT @server             = LTRIM(RTRIM(@server))
  SELECT @database_name      = LTRIM(RTRIM(@database_name))
  SELECT @database_user_name = LTRIM(RTRIM(@database_user_name))
  SELECT @output_file_name   = LTRIM(RTRIM(@output_file_name))
  SELECT @proxy_name         = LTRIM(RTRIM(@proxy_name))

  -- Make sure Dts is translated into new subsystem's name SSIS
  IF (@subsystem IS NOT NULL AND UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) = N'DTS')
  BEGIN
    SET @subsystem = N'SSIS'
  END

  -- Only sysadmin's or db_owner's of msdb can directly change
  -- an existing job step to use one of the replication
  -- subsystems
  IF (UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) IN
                        (N'DISTRIBUTION',
                         N'SNAPSHOT',
                         N'LOGREADER',
                         N'MERGE',
                         N'QUEUEREADER'))
  BEGIN
    IF NOT ((ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1) OR
            (ISNULL(IS_MEMBER(N'db_owner'), 0) = 1) OR
            (UPPER(USER_NAME() collate SQL_Latin1_General_CP1_CS_AS) = N'DBO'))
    BEGIN
      RAISERROR(14260, -1, -1)
      RETURN(1) -- Failure
    END
  END

  EXECUTE @retval = sp_verify_job_identifiers '@job_name',
                                              '@job_id',
                                               @job_name OUTPUT,
                                               @job_id   OUTPUT,
                                               @owner_sid = @job_owner_sid OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Check permissions beyond what's checked by the sysjobs_view
  -- SQLAgentReader and SQLAgentOperator roles that can see all jobs
  -- cannot modify jobs they do not own
  IF (@job_owner_sid <> SUSER_SID()                   -- does not own the job
     AND (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1))   -- is not sysadmin
  BEGIN
   RAISERROR(14525, -1, -1);
   RETURN(1) -- Failure
  END

  -- Check that the step exists
  IF (NOT EXISTS (SELECT *
                  FROM dbo.sysjobsteps
                  WHERE (job_id = @job_id)
                    AND (step_id = @step_id)))
  BEGIN
    SELECT @step_id_as_char = CONVERT(VARCHAR(10), @step_id)
    RAISERROR(14262, -1, -1, '@step_id', @step_id_as_char)
    RETURN(1) -- Failure
  END
/*
  -- check proxy identifiers only if a proxy has been provided
  -- @proxy_name = N'' is a special case to allow change of an existing proxy with NULL
  IF (@proxy_id IS NOT NULL) OR (@proxy_name IS NOT NULL AND @proxy_name <> N'') 
  BEGIN
    EXECUTE @retval = sp_verify_proxy_identifiers '@proxy_name',
                                                  '@proxy_id',
                                                   @proxy_name OUTPUT,
                                                   @proxy_id   OUTPUT
    IF (@retval <> 0)
      RETURN(1) -- Failure

     SELECT @new_proxy_id  = @proxy_id

  END
  */
  -- Check authority (only SQLServerAgent can modify a step of a non-local job)
  EXECUTE @retval = sp_verify_jobproc_caller @job_id = @job_id, @program_name = N'SQLAgent%'
  IF (@retval <> 0)
    RETURN(@retval)

  -- Set the x_ (existing) variables
  SELECT @x_step_name            = step_name,
         @x_subsystem            = subsystem,
         @x_command              = command,
         @x_flags                = flags,
         @x_cmdexec_success_code = cmdexec_success_code,
         @x_on_success_action    = on_success_action,
         @x_on_success_step_id   = on_success_step_id,
         @x_on_fail_action       = on_fail_action,
         @x_on_fail_step_id      = on_fail_step_id,
         @x_server               = server,
         @x_database_name        = database_name,
         @x_database_user_name   = database_user_name,
         @x_retry_attempts       = retry_attempts,
         @x_retry_interval       = retry_interval,
         @x_os_run_priority      = os_run_priority,
         @x_output_file_name     = output_file_name,
         @x_proxy_id             = proxy_id,
         @x_last_run_outcome     = last_run_outcome,
         @x_last_run_duration    = last_run_duration,
         @x_last_run_retries     = last_run_retries,
         @x_last_run_date        = last_run_date,
         @x_last_run_time        = last_run_time
  FROM dbo.sysjobsteps
  WHERE (job_id = @job_id)
    AND (step_id = @step_id)

  IF ((@step_name IS NOT NULL) AND (@step_name <> @x_step_name))
    SELECT @new_step_name = @step_name

  -- Fill out the values for all non-supplied parameters from the existing values
  IF (@step_name            IS NULL) SELECT @step_name            = @x_step_name
  IF (@subsystem            IS NULL) SELECT @subsystem            = @x_subsystem
  IF (@command              IS NULL) SELECT @command              = @x_command
  IF (@flags                IS NULL) SELECT @flags                = @x_flags
  IF (@cmdexec_success_code IS NULL) SELECT @cmdexec_success_code = @x_cmdexec_success_code
  IF (@on_success_action    IS NULL) SELECT @on_success_action    = @x_on_success_action
  IF (@on_success_step_id   IS NULL) SELECT @on_success_step_id   = @x_on_success_step_id
  IF (@on_fail_action       IS NULL) SELECT @on_fail_action       = @x_on_fail_action
  IF (@on_fail_step_id      IS NULL) SELECT @on_fail_step_id      = @x_on_fail_step_id
  IF (@server               IS NULL) SELECT @server               = @x_server
  IF (@database_name        IS NULL) SELECT @database_name        = @x_database_name
  IF (@database_user_name   IS NULL) SELECT @database_user_name   = @x_database_user_name
  IF (@retry_attempts       IS NULL) SELECT @retry_attempts       = @x_retry_attempts
  IF (@retry_interval       IS NULL) SELECT @retry_interval       = @x_retry_interval
  IF (@os_run_priority      IS NULL) SELECT @os_run_priority      = @x_os_run_priority
  IF (@output_file_name     IS NULL) SELECT @output_file_name     = @x_output_file_name
  IF (@proxy_id             IS NULL) SELECT @new_proxy_id         = @x_proxy_id

  --if an empty proxy_name is supplied the proxy is removed
  IF @proxy_name = N'' SELECT @new_proxy_id = NULL
  -- Turn [nullable] empty string parameters into NULLs
  IF (@command            = N'') SELECT @command            = NULL
  IF (@server             = N'') SELECT @server             = NULL
  IF (@database_name      = N'') SELECT @database_name      = NULL
  IF (@database_user_name = N'') SELECT @database_user_name = NULL
  IF (@output_file_name   = N'') SELECT @output_file_name   = NULL


  -- Check new values
  EXECUTE @retval = sp_verify_jobstep @job_id,
                                      @step_id,
                                      @new_step_name,
                                      @subsystem,
                                      @command,
                                      @server,
                                      @on_success_action,
                                      @on_success_step_id,
                                      @on_fail_action,
                                      @on_fail_step_id,
                                      @os_run_priority,
                                      @database_name      OUTPUT,
                                      @database_user_name OUTPUT,
                                      @flags,
                                      @output_file_name,
                                               @new_proxy_id
  IF (@retval <> 0)
    RETURN(1) -- Failure

  BEGIN TRANSACTION

    -- Update the job's version/last-modified information
    UPDATE dbo.sysjobs
    SET version_number = version_number + 1,
        date_modified = GETDATE()
    WHERE (job_id = @job_id)

    -- Update the step
    UPDATE dbo.sysjobsteps
    SET step_name             = @step_name,
        subsystem             = @subsystem,
        command               = @command,
        flags                 = @flags,
        additional_parameters = @additional_parameters,
        cmdexec_success_code  = @cmdexec_success_code,
        on_success_action     = @on_success_action,
        on_success_step_id    = @on_success_step_id,
        on_fail_action        = @on_fail_action,
        on_fail_step_id       = @on_fail_step_id,
        server                = @server,
        database_name         = @database_name,
        database_user_name    = @database_user_name,
        retry_attempts        = @retry_attempts,
        retry_interval        = @retry_interval,
        os_run_priority       = @os_run_priority,
        output_file_name      = @output_file_name,
        last_run_outcome      = @x_last_run_outcome,
        last_run_duration     = @x_last_run_duration,
        last_run_retries      = @x_last_run_retries,
        last_run_date         = @x_last_run_date,
        last_run_time         = @x_last_run_time,
          proxy_id                 = @new_proxy_id
    WHERE (job_id = @job_id)
      AND (step_id = @step_id)


  COMMIT TRANSACTION

  -- For a multi-server job, push changes to the target servers
  IF (EXISTS (SELECT *
              FROM dbo.sysjobservers
              WHERE (job_id = @job_id)
                AND (server_id <> 0)))
  BEGIN
    EXECUTE dbo.sp_post_msx_operation 'INSERT', 'JOB', @job_id
  END

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_update_replication_job_parameter]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_update_replication_job_parameter]
  @job_id        UNIQUEIDENTIFIER,
  @old_freq_type INT,
  @new_freq_type INT
AS
BEGIN
  DECLARE @category_id INT
  DECLARE @pattern     NVARCHAR(50)
  DECLARE @patternidx  INT
  DECLARE @cmdline     NVARCHAR(3200)
  DECLARE @step_id     INT

  SET NOCOUNT ON
  SELECT @pattern = N'%[-/][Cc][Oo][Nn][Tt][Ii][Nn][Uu][Oo][Uu][Ss]%'

  -- Make sure that we are dealing with relevant replication jobs
  SELECT @category_id = category_id
  FROM dbo.sysjobs
  WHERE (@job_id = job_id)

  -- @category_id = 10 (REPL-Distribution), 13 (REPL-LogReader), 14 (REPL-Merge),
  --  19 (REPL-QueueReader)
  IF @category_id IN (10, 13, 14, 19)
  BEGIN
    -- Adding the -Continuous parameter (non auto-start to auto-start)
    IF ((@old_freq_type <> 0x40) AND (@new_freq_type = 0x40))
    BEGIN
      -- Use a cursor to handle multiple replication agent job steps
      DECLARE step_cursor CURSOR LOCAL FOR
      SELECT command, step_id
      FROM dbo.sysjobsteps
      WHERE (@job_id = job_id)
        AND (UPPER(subsystem collate SQL_Latin1_General_CP1_CS_AS) IN (N'MERGE', N'LOGREADER', N'DISTRIBUTION', N'QUEUEREADER'))
      OPEN step_cursor
      FETCH step_cursor INTO @cmdline, @step_id

      WHILE (@@FETCH_STATUS <> -1)
      BEGIN
        SELECT @patternidx = PATINDEX(@pattern, @cmdline)
        -- Make sure that the -Continuous parameter has not been specified already
        IF (@patternidx = 0)
        BEGIN
          SELECT @cmdline = @cmdline + N' -Continuous'
          UPDATE dbo.sysjobsteps
          SET command = @cmdline
          WHERE (@job_id = job_id)
            AND (@step_id = step_id)
        END -- IF (@patternidx = 0)
        FETCH NEXT FROM step_cursor into @cmdline, @step_id
      END -- WHILE (@@FETCH_STATUS <> -1)
      CLOSE step_cursor
      DEALLOCATE step_cursor
    END -- IF ((@old_freq_type...
    -- Removing the -Continuous parameter (auto-start to non auto-start)
    ELSE
    IF ((@old_freq_type = 0x40) AND (@new_freq_type <> 0x40))
    BEGIN
      DECLARE step_cursor CURSOR LOCAL FOR
      SELECT command, step_id
      FROM dbo.sysjobsteps
      WHERE (@job_id = job_id)
        AND (UPPER(subsystem collate SQL_Latin1_General_CP1_CS_AS) IN (N'MERGE', N'LOGREADER', N'DISTRIBUTION', N'QUEUEREADER'))
      OPEN step_cursor
      FETCH step_cursor INTO @cmdline, @step_id

      WHILE (@@FETCH_STATUS <> -1)
      BEGIN
        SELECT @patternidx = PATINDEX(@pattern, @cmdline)
        IF (@patternidx <> 0)
        BEGIN
          -- Handle multiple instances of -Continuous in the commandline
          WHILE (@patternidx <> 0)
          BEGIN
            SELECT @cmdline = STUFF(@cmdline, @patternidx, 11, N'')
            IF (@patternidx > 1)
            BEGIN
              -- Remove the preceding space if -Continuous does not start at the beginning of the commandline
              SELECT @cmdline = stuff(@cmdline, @patternidx - 1, 1, N'')
            END
            SELECT @patternidx = PATINDEX(@pattern, @cmdline)
          END -- WHILE (@patternidx <> 0)
          UPDATE dbo.sysjobsteps
          SET command = @cmdline
          WHERE (@job_id = job_id)
            AND (@step_id = step_id)
        END -- IF (@patternidx <> -1)
        FETCH NEXT FROM step_cursor INTO @cmdline, @step_id
      END -- WHILE (@@FETCH_STATUS <> -1)
      CLOSE step_cursor
      DEALLOCATE step_cursor
    END -- ELSE IF ((@old_freq_type = 0x40)...
  END -- IF @category_id IN (10, 13, 14)

  RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[sp_update_schedule]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[sp_update_schedule]
(
  @schedule_id              INT             = NULL,     -- Must provide either this or schedule_name
  @name                     sysname         = NULL,     -- Must provide either this or schedule_id
  @new_name                 sysname         = NULL,
  @enabled                  TINYINT         = NULL,
  @freq_type                INT             = NULL,
  @freq_interval            INT             = NULL,
  @freq_subday_type         INT             = NULL,
  @freq_subday_interval     INT             = NULL,
  @freq_relative_interval   INT             = NULL,
  @freq_recurrence_factor   INT             = NULL,
  @active_start_date        INT             = NULL, 
  @active_end_date          INT             = NULL,
  @active_start_time        INT             = NULL,
  @active_end_time          INT             = NULL,
  @owner_login_name         sysname         = NULL,
  @automatic_post           BIT             = 1         -- If 1 will post notifications to all tsx servers to 
                                                        -- update all jobs that use this schedule
)
AS
BEGIN
  DECLARE @retval                   INT
  DECLARE @owner_sid                VARBINARY(85)
  DECLARE @cur_owner_sid            VARBINARY(85)
  DECLARE @x_name                   sysname
  DECLARE @enable_only_used         INT

  DECLARE @x_enabled                TINYINT
  DECLARE @x_freq_type              INT
  DECLARE @x_freq_interval          INT
  DECLARE @x_freq_subday_type       INT
  DECLARE @x_freq_subday_interval   INT
  DECLARE @x_freq_relative_interval INT
  DECLARE @x_freq_recurrence_factor INT
  DECLARE @x_active_start_date      INT
  DECLARE @x_active_end_date        INT
  DECLARE @x_active_start_time      INT
  DECLARE @x_active_end_time        INT
  DECLARE @schedule_uid             UNIQUEIDENTIFIER

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @name              = LTRIM(RTRIM(@name))
  SELECT @new_name          = LTRIM(RTRIM(@new_name))
  SELECT @owner_login_name  = LTRIM(RTRIM(@owner_login_name))
  -- Turn [nullable] empty string parameters into NULLs
  IF (@new_name = N'') SELECT @new_name = NULL

   -- If the owner is supplied get the sid and check it
  IF(@owner_login_name IS NOT NULL AND @owner_login_name <> '')
  BEGIN
      -- Get the sid for @owner_login_name SID 
      --force case insensitive comparation for NT users
      SELECT @owner_sid = dbo.SQLAGENT_SUSER_SID(@owner_login_name)
    -- Cannot proceed if @owner_login_name doesn't exist
    IF(@owner_sid IS NULL)
    BEGIN
      RAISERROR(14262, -1, -1, '@owner_login_name', @owner_login_name)
      RETURN(1) -- Failure
    END
  END

  -- Check that we can uniquely identify the schedule. This only returns a schedule that is visible to this user
  EXECUTE @retval = dbo.sp_verify_schedule_identifiers @name_of_name_parameter = '@name',
                                                            @name_of_id_parameter   = '@schedule_id',
                                                            @schedule_name          = @name             OUTPUT,
                                                            @schedule_id            = @schedule_id      OUTPUT,
                                                            @owner_sid              = @cur_owner_sid    OUTPUT,
                                                            @orig_server_id         = NULL
  IF (@retval <> 0)
      RETURN(1) -- Failure   

  -- Is @enable the only parameter used beside jobname and jobid?
  IF ((@enabled                   IS NOT NULL) AND
       (@new_name                 IS NULL) AND
      (@freq_type                 IS NULL) AND
      (@freq_interval             IS NULL) AND
      (@freq_subday_type          IS NULL) AND
      (@freq_subday_interval      IS NULL) AND
      (@freq_relative_interval    IS NULL) AND
      (@freq_recurrence_factor    IS NULL) AND
      (@active_start_date         IS NULL) AND
      (@active_end_date           IS NULL) AND
      (@active_start_time         IS NULL) AND
      (@active_end_time           IS NULL) AND
      (@owner_login_name          IS NULL))
    SELECT @enable_only_used = 1
  ELSE
    SELECT @enable_only_used = 0
      
  -- Non-sysadmins can only update jobs schedules they own. 
  -- Members of SQLAgentReaderRole and SQLAgentOperatorRole can view job schedules, 
  -- but they should not be able to delete them
  IF ((@cur_owner_sid <> SUSER_SID())
       AND (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'),0) <> 1)
      AND (@enable_only_used <> 1 OR ISNULL(IS_MEMBER(N'SQLAgentOperatorRole'), 0) <> 1))
  BEGIN
   RAISERROR(14394, -1, -1)
   RETURN(1) -- Failure
  END
  
  -- If the param @owner_login_name is null or doesn't get resolved by SUSER_SID() set it to the current owner of the schedule
  if(@owner_sid IS NULL)
      SELECT @owner_sid = @cur_owner_sid
       
   -- Set the x_ (existing) variables
  SELECT @x_name                   = name,
         @x_enabled                = enabled,
         @x_freq_type              = freq_type,
         @x_freq_interval          = freq_interval,
         @x_freq_subday_type       = freq_subday_type,
         @x_freq_subday_interval   = freq_subday_interval,
         @x_freq_relative_interval = freq_relative_interval,
         @x_freq_recurrence_factor = freq_recurrence_factor,
         @x_active_start_date      = active_start_date,
         @x_active_end_date        = active_end_date,
         @x_active_start_time      = active_start_time,
         @x_active_end_time        = active_end_time
  FROM dbo.sysschedules
  WHERE (schedule_id = @schedule_id )     
  
  
    -- Fill out the values for all non-supplied parameters from the existing values
  IF (@new_name               IS NULL) SELECT @new_name               = @x_name
  IF (@enabled                IS NULL) SELECT @enabled                = @x_enabled
  IF (@freq_type              IS NULL) SELECT @freq_type              = @x_freq_type
  IF (@freq_interval          IS NULL) SELECT @freq_interval          = @x_freq_interval
  IF (@freq_subday_type       IS NULL) SELECT @freq_subday_type       = @x_freq_subday_type
  IF (@freq_subday_interval   IS NULL) SELECT @freq_subday_interval   = @x_freq_subday_interval
  IF (@freq_relative_interval IS NULL) SELECT @freq_relative_interval = @x_freq_relative_interval
  IF (@freq_recurrence_factor IS NULL) SELECT @freq_recurrence_factor = @x_freq_recurrence_factor
  IF (@active_start_date      IS NULL) SELECT @active_start_date      = @x_active_start_date
  IF (@active_end_date        IS NULL) SELECT @active_end_date        = @x_active_end_date
  IF (@active_start_time      IS NULL) SELECT @active_start_time      = @x_active_start_time
  IF (@active_end_time        IS NULL) SELECT @active_end_time        = @x_active_end_time
      
  -- Check schedule (frequency and owner) parameters
  EXECUTE @retval = sp_verify_schedule @schedule_id             = @schedule_id,
                                       @name                    = @new_name,
                                       @enabled                 = @enabled,
                                       @freq_type               = @freq_type,
                                       @freq_interval           = @freq_interval            OUTPUT,
                                       @freq_subday_type        = @freq_subday_type         OUTPUT,
                                       @freq_subday_interval    = @freq_subday_interval     OUTPUT,
                                       @freq_relative_interval  = @freq_relative_interval   OUTPUT,
                                       @freq_recurrence_factor  = @freq_recurrence_factor   OUTPUT,
                                       @active_start_date       = @active_start_date        OUTPUT,
                                       @active_start_time       = @active_start_time        OUTPUT,
                                       @active_end_date         = @active_end_date          OUTPUT,
                                       @active_end_time         = @active_end_time          OUTPUT,
                                       @owner_sid               = @owner_sid
  IF (@retval <> 0)
    RETURN(1) -- Failure  

  -- Update the sysschedules table
  UPDATE dbo.sysschedules
  SET name                   = @new_name,
      owner_sid              = @owner_sid,
      enabled                = @enabled,
      freq_type              = @freq_type,
      freq_interval          = @freq_interval,
      freq_subday_type       = @freq_subday_type,
      freq_subday_interval   = @freq_subday_interval,
      freq_relative_interval = @freq_relative_interval,
      freq_recurrence_factor = @freq_recurrence_factor,
      active_start_date      = @active_start_date,
      active_end_date        = @active_end_date,
      active_start_time      = @active_start_time,
      active_end_time        = @active_end_time,
      date_modified          = GETDATE(),
      version_number         = version_number + 1
  WHERE (schedule_id = @schedule_id)

  SELECT @retval = @@error

 -- update any job that has repl steps
  DECLARE @job_id UNIQUEIDENTIFIER
  DECLARE jobsschedule_cursor CURSOR LOCAL FOR
  SELECT job_id
  FROM dbo.sysjobschedules
  WHERE (schedule_id = @schedule_id)
  
  IF @x_freq_type <> @freq_type
  BEGIN
    OPEN jobsschedule_cursor
    FETCH NEXT FROM jobsschedule_cursor INTO @job_id

    WHILE (@@FETCH_STATUS = 0)
    BEGIN 
      EXEC  sp_update_replication_job_parameter @job_id = @job_id,
                                                @old_freq_type = @x_freq_type,
                                                @new_freq_type = @freq_type
      FETCH NEXT FROM jobsschedule_cursor INTO @job_id
    END
    CLOSE jobsschedule_cursor
  END
  DEALLOCATE jobsschedule_cursor

/*  
  -- Notify SQLServerAgent of the change if this is attached to a local job
  IF (EXISTS (SELECT *
                FROM dbo.sysjobschedules AS jsched 
              JOIN dbo.sysjobservers AS jsvr
                    ON jsched.job_id = jsvr.job_id
                WHERE (jsched.schedule_id = @schedule_id)
                  AND (jsvr.server_id = 0)) )
  BEGIN 
      EXECUTE dbo.sp_sqlagent_notify @op_type     = N'S',
                                          @schedule_id = @schedule_id,
                                          @action_type = N'U'              
  END
*/

/*
  -- Instruct the tsx servers to pick up the altered schedule
  IF (@automatic_post = 1)
  BEGIN
      SELECT @schedule_uid = schedule_uid 
      FROM sysschedules 
      WHERE schedule_id = @schedule_id

      IF(NOT @schedule_uid IS NULL)
      BEGIN
          -- sp_post_msx_operation will do nothing if the schedule isn't assigned to any tsx machines 
          EXECUTE @retval = sp_post_msx_operation @operation = 'INSERT', @object_type = 'SCHEDULE', @schedule_uid = @schedule_uid
      END
  END  
  */
  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_verify_job_date]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_verify_job_date]
  @date           INT,
  @date_name      VARCHAR(60) = 'date',
  @error_severity INT         = -1
AS
BEGIN
  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @date_name = LTRIM(RTRIM(@date_name))

  IF ((ISDATE(CONVERT(VARCHAR, @date)) = 0) OR (@date < 19900101) OR (@date > 99991231))
  BEGIN
    RAISERROR(14266, @error_severity, -1, @date_name, '19900101..99991231')
    RETURN(1) -- Failure
  END

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_verify_job_identifiers]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_verify_job_identifiers]
  @name_of_name_parameter  VARCHAR(60),             -- Eg. '@job_name'
  @name_of_id_parameter    VARCHAR(60),             -- Eg. '@job_id'
  @job_name                sysname          OUTPUT, -- Eg. 'My Job'
  @job_id                  UNIQUEIDENTIFIER OUTPUT,
  @sqlagent_starting_test  VARCHAR(7) = 'TEST',      -- By default we DO want to test if SQLServerAgent is running (caller should specify 'NO_TEST' if not desired)
  @owner_sid                VARBINARY(85) = NULL OUTPUT  
AS
BEGIN
  DECLARE @retval         INT
  DECLARE @job_id_as_char VARCHAR(36)

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @name_of_name_parameter = LTRIM(RTRIM(@name_of_name_parameter))
  SELECT @name_of_id_parameter   = LTRIM(RTRIM(@name_of_id_parameter))
  SELECT @job_name               = LTRIM(RTRIM(@job_name))

  IF (@job_name = N'') SELECT @job_name = NULL

  IF ((@job_name IS NULL)     AND (@job_id IS NULL)) OR
     ((@job_name IS NOT NULL) AND (@job_id IS NOT NULL))
  BEGIN
    RAISERROR(14294, -1, -1, @name_of_id_parameter, @name_of_name_parameter)
    RETURN(1) -- Failure
  END

  -- Check job id
  IF (@job_id IS NOT NULL)
  BEGIN
    SELECT @job_name = name,
           @owner_sid = owner_sid
    FROM dbo.sysjobs_view
    WHERE (job_id = @job_id)
    
    -- the view would take care of all the permissions issues.
    IF (@job_name IS NULL) 
    BEGIN
      SELECT @job_id_as_char = CONVERT(VARCHAR(36), @job_id)
      RAISERROR(14262, -1, -1, '@job_id', @job_id_as_char)
      RETURN(1) -- Failure
    END
  END
  ELSE
  -- Check job name
  IF (@job_name IS NOT NULL)
  BEGIN
    -- Check if the job name is ambiguous
    IF ((SELECT COUNT(*)
         FROM dbo.sysjobs_view
         WHERE (name = @job_name)) > 1)
    BEGIN
      RAISERROR(14293, -1, -1, @job_name, @name_of_id_parameter, @name_of_name_parameter)
      RETURN(1) -- Failure
    END

    -- The name is not ambiguous, so get the corresponding job_id (if the job exists)
    SELECT @job_id = job_id,
           @owner_sid = owner_sid
    FROM dbo.sysjobs_view
    WHERE (name = @job_name)
    
    -- the view would take care of all the permissions issues.
    IF (@job_id IS NULL) 
    BEGIN
      RAISERROR(14262, -1, -1, '@job_name', @job_name)
      RETURN(1) -- Failure
    END
  END

  /*
  IF (@sqlagent_starting_test = 'TEST')
  BEGIN
    -- Finally, check if SQLServerAgent is in the process of starting and if so prevent the
    -- calling SP from running
    EXECUTE @retval = dbo.sp_is_sqlagent_starting
    IF (@retval <> 0)
      RETURN(1) -- Failure
  END
  */

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_verify_job_time]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[sp_verify_job_time]
  @time           INT,
  @time_name      VARCHAR(60) = 'time',
  @error_severity INT = -1
AS
BEGIN
  DECLARE @hour      INT
  DECLARE @minute    INT
  DECLARE @second    INT
  DECLARE @part_name NVARCHAR(50)

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @time_name = LTRIM(RTRIM(@time_name))

  IF ((@time < 0) OR (@time > 235959))
  BEGIN
    RAISERROR(14266, @error_severity, -1, @time_name, '000000..235959')
    RETURN(1) -- Failure
  END

  SELECT @hour   = (@time / 10000)
  SELECT @minute = (@time % 10000) / 100
  SELECT @second = (@time % 100)

  -- Check hour range
  IF (@hour > 23)
  BEGIN
    SELECT @part_name = FORMATMESSAGE(14218)
    RAISERROR(14287, @error_severity, -1, @time_name, @part_name)
    RETURN(1) -- Failure
  END

  -- Check minute range
  IF (@minute > 59)
  BEGIN
    SELECT @part_name = FORMATMESSAGE(14219)
    RAISERROR(14287, @error_severity, -1, @time_name, @part_name)
    RETURN(1) -- Failure
  END

  -- Check second range
  IF (@second > 59)
  BEGIN
    SELECT @part_name = FORMATMESSAGE(14220)
    RAISERROR(14287, @error_severity, -1, @time_name, @part_name)
    RETURN(1) -- Failure
  END

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_verify_jobproc_caller]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_verify_jobproc_caller]
  @job_id       UNIQUEIDENTIFIER,
  @program_name sysname
AS
BEGIN
  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @program_name = LTRIM(RTRIM(@program_name))

  IF (EXISTS (SELECT    *
              FROM      dbo.sysjobs_view
              WHERE     (job_id = @job_id)
              AND       (master_server = 1) )) -- master_server = 1 filters on MSX jobs in this TSX server
              AND       (PROGRAM_NAME() NOT LIKE @program_name)
  BEGIN
    RAISERROR(14274, -1, -1)
    RETURN(1) -- Failure
  END

  RETURN(0)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_verify_jobstep]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_verify_jobstep]
  @job_id             UNIQUEIDENTIFIER,
  @step_id            INT,
  @step_name          sysname,
  @subsystem          NVARCHAR(40),
  @command            NVARCHAR(max),
  @server             sysname,
  @on_success_action  TINYINT,
  @on_success_step_id INT,
  @on_fail_action     TINYINT,
  @on_fail_step_id    INT,
  @os_run_priority    INT,
  @database_name      sysname OUTPUT,
  @database_user_name sysname OUTPUT,
  @flags              INT,
  @output_file_name   NVARCHAR(200),
  @proxy_id         INT 
AS
BEGIN
  DECLARE @max_step_id             INT
  DECLARE @retval                  INT
  DECLARE @valid_values            VARCHAR(50)
  DECLARE @database_name_temp      NVARCHAR(258)
  DECLARE @database_user_name_temp NVARCHAR(256)
  DECLARE @temp_command            NVARCHAR(max)
  DECLARE @iPos                    INT
  DECLARE @create_count            INT
  DECLARE @destroy_count           INT
  DECLARE @is_olap_subsystem       BIT
  DECLARE @owner_sid               VARBINARY(85)
  DECLARE @owner_name              sysname
  -- Remove any leading/trailing spaces from parameters
  SELECT @subsystem        = LTRIM(RTRIM(@subsystem))
  SELECT @server           = LTRIM(RTRIM(@server))
  SELECT @output_file_name = LTRIM(RTRIM(@output_file_name))

  -- Get current maximum step id
  SELECT @max_step_id = ISNULL(MAX(step_id), 0)
  FROM dbo.sysjobsteps
  WHERE (job_id = @job_id)

  -- Check step id
  IF (@step_id < 1) OR (@step_id > @max_step_id + 1)
  BEGIN
    SELECT @valid_values = '1..' + CONVERT(VARCHAR, @max_step_id + 1)
    RAISERROR(14266, -1, -1, '@step_id', @valid_values)
    RETURN(1) -- Failure
  END
/*
  -- Check subsystem
  EXECUTE @retval = sp_verify_subsystem @subsystem
  IF (@retval <> 0)
    RETURN(1) -- Failure
  
  --check if proxy is allowed for this subsystem for current user
  IF (@proxy_id IS NOT NULL)
  BEGIN
    --get the job owner
    SELECT @owner_sid = owner_sid FROM sysjobs
    WHERE  job_id = @job_id
    IF @owner_sid = 0xFFFFFFFF
    BEGIN
      --ask to verify for the special account
      EXECUTE @retval = sp_verify_proxy_permissions 
        @subsystem_name = @subsystem, 
        @proxy_id = @proxy_id, 
        @name = NULL, 
        @raise_error = 1, 
        @allow_disable_proxy = 1, 
        @verify_special_account = 1
      IF (@retval <> 0)
        RETURN(1) -- Failure
    END
    ELSE
    BEGIN
      SELECT @owner_name = SUSER_SNAME(@owner_sid)
      EXECUTE @retval = sp_verify_proxy_permissions 
      @subsystem_name = @subsystem, 
      @proxy_id = @proxy_id, 
      @name = @owner_name, 
      @raise_error = 1, 
      @allow_disable_proxy = 1
      IF (@retval <> 0)
        RETURN(1) -- Failure
    END
  END
  */
  --Only sysadmin can specify @output_file_name 
  IF (@output_file_name IS NOT NULL) AND  (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1)
  BEGIN
    RAISERROR(14582, -1, -1)
    RETURN(1) -- Failure    
  END

  --Determmine if this is a olap subsystem jobstep
  IF ( UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) in (N'ANALYSISQUERY', N'ANALYSISCOMMAND') )
    SELECT @is_olap_subsystem = 1
  ELSE
    SELECT @is_olap_subsystem = 0

  -- Check command length
  -- not necessary now, command can be any length
/*
  IF ((DATALENGTH(@command) / 2) > 3200)
  BEGIN
    RAISERROR(14250, 16, 1, '@command', 3200)
    RETURN(1) -- Failure
  END
*/
  -- For a VBScript command, check that object creations are paired with object destructions
  IF ((UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) = N'ACTIVESCRIPTING') AND (@database_name = N'VBScript'))
  BEGIN
    SET @temp_command = @command

    SELECT @create_count = 0
    SELECT @iPos = PATINDEX('%[Cc]reate[Oo]bject[ (]%', @temp_command)
    WHILE(@iPos > 0)
    BEGIN
      SELECT @temp_command = SUBSTRING(@temp_command, @iPos + 1, DATALENGTH(@temp_command) / 2)
      SELECT @iPos = PATINDEX('%[Cc]reate[Oo]bject[ (]%', @temp_command)
      SELECT @create_count = @create_count + 1
    END

    -- restore @temp_command for next loop
    SET @temp_command = @command
    
    SELECT @destroy_count = 0
    SELECT @iPos = PATINDEX('%[Ss]et %=%[Nn]othing%', @temp_command)
    WHILE(@iPos > 0)
    BEGIN
      SELECT @temp_command = SUBSTRING(@temp_command, @iPos + 1, DATALENGTH(@temp_command) / 2)
      SELECT @iPos = PATINDEX('%[Ss]et %=%[Nn]othing%', @temp_command)
      SELECT @destroy_count = @destroy_count + 1
    END

    IF(@create_count > @destroy_count)
    BEGIN
      RAISERROR(14277, -1, -1)
      RETURN(1) -- Failure
    END
  END

  -- Check step name
  IF (EXISTS (SELECT *
              FROM dbo.sysjobsteps
              WHERE (job_id = @job_id)
                AND (step_name = @step_name)))
  BEGIN
    RAISERROR(14261, -1, -1, '@step_name', @step_name)
    RETURN(1) -- Failure
  END

  -- Check on-success action/step
  IF (@on_success_action <> 1) AND -- Quit Qith Success
     (@on_success_action <> 2) AND -- Quit Qith Failure
     (@on_success_action <> 3) AND -- Goto Next Step
     (@on_success_action <> 4)     -- Goto Step
  BEGIN
    RAISERROR(14266, -1, -1, '@on_success_action', '1, 2, 3, 4')
    RETURN(1) -- Failure
  END
  IF (@on_success_action = 4) AND
     ((@on_success_step_id < 1) OR (@on_success_step_id = @step_id))
  BEGIN
    -- NOTE: We allow forward references to non-existant steps to prevent the user from
    --       having to make a second update pass to fix up the flow
    RAISERROR(14235, -1, -1, '@on_success_step', @step_id)
    RETURN(1) -- Failure
  END

  -- Check on-fail action/step
  IF (@on_fail_action <> 1) AND -- Quit With Success
     (@on_fail_action <> 2) AND -- Quit With Failure
     (@on_fail_action <> 3) AND -- Goto Next Step
     (@on_fail_action <> 4)     -- Goto Step
  BEGIN
    RAISERROR(14266, -1, -1, '@on_failure_action', '1, 2, 3, 4')
    RETURN(1) -- Failure
  END
  IF (@on_fail_action = 4) AND
     ((@on_fail_step_id < 1) OR (@on_fail_step_id = @step_id))
  BEGIN
    -- NOTE: We allow forward references to non-existant steps to prevent the user from
    --       having to make a second update pass to fix up the flow
    RAISERROR(14235, -1, -1, '@on_failure_step', @step_id)
    RETURN(1) -- Failure
  END

  -- Warn the user about forward references
  IF ((@on_success_action = 4) AND (@on_success_step_id > @max_step_id))
    RAISERROR(14236, 0, 1, '@on_success_step_id')
  IF ((@on_fail_action = 4) AND (@on_fail_step_id > @max_step_id))
    RAISERROR(14236, 0, 1, '@on_fail_step_id')

  --Special case the olap subsystem. It can have any server name. 
  --Default it to the local server if @server is null 
  IF(@is_olap_subsystem = 1)
  BEGIN
    IF(@server IS NULL)
    BEGIN
    --TODO: needs error better message ? >> 'Specify the OLAP server name in the %s parameter'
      --Must specify the olap server name
      RAISERROR(14262, -1, -1, '@server', @server)
      RETURN(1) -- Failure    
    END
  END
  ELSE
  BEGIN
    -- Check server (this is the replication server, NOT the job-target server)
    IF (@server IS NOT NULL) AND (NOT EXISTS (SELECT *
                                              FROM master.dbo.sysservers
                                              WHERE (UPPER(srvname) = UPPER(@server))))
    BEGIN
      RAISERROR(14234, -1, -1, '@server', 'sp_helpserver')
      RETURN(1) -- Failure
    END
  END

  -- Check run priority: must be a valid value to pass to SetThreadPriority:
  -- [-15 = IDLE, -1 = BELOW_NORMAL, 0 = NORMAL, 1 = ABOVE_NORMAL, 15 = TIME_CRITICAL]
  IF (@os_run_priority NOT IN (-15, -1, 0, 1, 15))
  BEGIN
    RAISERROR(14266, -1, -1, '@os_run_priority', '-15, -1, 0, 1, 15')
    RETURN(1) -- Failure
  END

  -- Check flags
  IF ((@flags < 0) OR (@flags > 114))
  BEGIN
    RAISERROR(14266, -1, -1, '@flags', '0..114')
    RETURN(1) -- Failure
  END

  -- @flags=4 is valid only for TSQL subsystem
  IF (((@flags & 4) <> 0) AND (UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) NOT IN ('TSQL')))
  BEGIN
    RAISERROR(14545, -1, -1, '@flags', @subsystem)
    RETURN(1) -- Failure
  END

  -- values 8 and 16 for @flags cannot be combined
  IF (((@flags & 8) <> 0) AND ((@flags & 16) <> 0))
  BEGIN
    RAISERROR(14545, -1, -1, '@flags', @subsystem)
    RETURN(1) -- Failure
  END

  IF (((@flags & 64) <> 0) AND (UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) NOT IN ('CMDEXEC')))
  BEGIN
    RAISERROR(14545, -1, -1, '@flags', @subsystem)
    RETURN(1) -- Failure
  END

  -- Check output file
  IF (@output_file_name IS NOT NULL) AND (UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) NOT IN ('TSQL', 'CMDEXEC', 'ANALYSISQUERY', 'ANALYSISCOMMAND', 'SSIS', 'POWERSHELL'))
  BEGIN
    RAISERROR(14545, -1, -1, '@output_file_name', @subsystem)
    RETURN(1) -- Failure
  END

  -- Check writing to table flags
  -- Note: explicit check for null is required here
  IF (@flags IS NOT NULL) AND (((@flags & 8) <> 0) OR ((@flags & 16) <> 0)) AND (UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) NOT IN ('TSQL', 'CMDEXEC', 'ANALYSISQUERY', 'ANALYSISCOMMAND', 'SSIS', 'POWERSHELL'))
  BEGIN
    RAISERROR(14545, -1, -1, '@flags', @subsystem)
    RETURN(1) -- Failure
  END

  -- For CmdExec steps database-name and database-user-name should both be null
  IF (UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) = N'CMDEXEC')
    SELECT @database_name = NULL,
           @database_user_name = NULL

  -- For non-TSQL steps, database-user-name should be null
  IF (UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) <> 'TSQL')
    SELECT @database_user_name = NULL

  -- For a TSQL step, get (and check) the username of the caller in the target database.
  IF (UPPER(@subsystem collate SQL_Latin1_General_CP1_CS_AS) = 'TSQL')
  BEGIN
    SET NOCOUNT ON

    -- But first check if remote server name has been supplied
    IF (@server IS NOT NULL)
      SELECT @server = NULL

    -- Default database to 'master' if not supplied
    IF (LTRIM(RTRIM(@database_name)) IS NULL)
      SELECT @database_name = N'master'

    -- Check the database (although this is no guarantee that @database_user_name can access it)
    IF (DB_ID(@database_name) IS NULL)
    BEGIN
      RAISERROR(14262, -1, -1, '@database_name', @database_name)
      RETURN(1) -- Failure
    END

    SELECT @database_user_name = LTRIM(RTRIM(@database_user_name))

    -- Only if a SysAdmin is creating the job can the database user name be non-NULL [since only
    -- SysAdmin's can call SETUSER].
    -- NOTE: In this case we don't try to validate the user name (it's too costly to do so)
    --       so if it's bad we'll get a runtime error when the job executes.
    IF (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1)
    BEGIN
      -- If this is a multi-server job then @database_user_name must be null
      IF (@database_user_name IS NOT NULL)
      BEGIN
        IF (EXISTS (SELECT *
                    FROM dbo.sysjobs       sj,
                         dbo.sysjobservers sjs
                    WHERE (sj.job_id = sjs.job_id)
                      AND (sj.job_id = @job_id)
                      AND (sjs.server_id <> 0)))
        BEGIN
          RAISERROR(14542, -1, -1, N'database_user_name')
          RETURN(1) -- Failure
        END
      END

      -- For a SQL-user, check if it exists
      IF (@database_user_name NOT LIKE N'%\%')
      BEGIN
        SELECT @database_user_name_temp = replace(@database_user_name, N'''', N'''''')
        SELECT @database_name_temp = QUOTENAME(@database_name)

        EXECUTE(N'DECLARE @ret INT
                  SELECT @ret = COUNT(*)
                  FROM ' + @database_name_temp + N'.dbo.sysusers
                  WHERE (name = N''' + @database_user_name_temp + N''')
                  HAVING (COUNT(*) > 0)')
        IF (@@ROWCOUNT = 0)
        BEGIN
          RAISERROR(14262, -1, -1, '@database_user_name', @database_user_name)
          RETURN(1) -- Failure
        END
      END
    END
    ELSE
      SELECT @database_user_name = NULL

  END  -- End of TSQL property verification

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[sp_verify_schedule]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_verify_schedule]
  @schedule_id            INT,
  @name                   sysname,
  @enabled                TINYINT,
  @freq_type              INT,          
  @freq_interval          INT OUTPUT,   -- Output because we may set it to 0 if Frequency Type is one-time or auto-start
  @freq_subday_type       INT OUTPUT,   -- As above
  @freq_subday_interval   INT OUTPUT,   -- As above
  @freq_relative_interval INT OUTPUT,   -- As above
  @freq_recurrence_factor INT OUTPUT,   -- As above
  @active_start_date      INT OUTPUT,
  @active_start_time      INT OUTPUT,
  @active_end_date        INT OUTPUT,
  @active_end_time        INT OUTPUT,
  @owner_sid              VARBINARY(85) --Must be a valid sid. Will fail if this is NULL
AS
BEGIN
  DECLARE @return_code             INT
  DECLARE @res_valid_range         NVARCHAR(100)
  DECLARE @reason                  NVARCHAR(200)
  DECLARE @isAdmin                 INT
  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @name = LTRIM(RTRIM(@name))

  -- Make sure that NULL input/output parameters - if NULL - are initialized to 0
  SELECT @freq_interval          = ISNULL(@freq_interval, 0)
  SELECT @freq_subday_type       = ISNULL(@freq_subday_type, 0)
  SELECT @freq_subday_interval   = ISNULL(@freq_subday_interval, 0)
  SELECT @freq_relative_interval = ISNULL(@freq_relative_interval, 0)
  SELECT @freq_recurrence_factor = ISNULL(@freq_recurrence_factor, 0)
  SELECT @active_start_date      = ISNULL(@active_start_date, 0)
  SELECT @active_start_time      = ISNULL(@active_start_time, 0)
  SELECT @active_end_date        = ISNULL(@active_end_date, 0)
  SELECT @active_end_time        = ISNULL(@active_end_time, 0)


  -- Check owner 
  IF(ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1)
    SELECT @isAdmin = 1
  ELSE
    SELECT @isAdmin = 0


  -- If a non-sa is [illegally] trying to create a schedule for another user then raise an error
  IF ((@isAdmin <> 1) AND 
      (ISNULL(IS_MEMBER('SQLAgentOperatorRole'),0) <> 1 AND @schedule_id IS NULL) AND
      (@owner_sid <> SUSER_SID()))
  BEGIN
     RAISERROR(14366, -1, -1)
     RETURN(1) -- Failure
  END


  -- Now just check that the login id is valid (ie. it exists and isn't an NT group)
  IF (@owner_sid <> 0x010100000000000512000000) AND -- NT AUTHORITY\SYSTEM sid
     (@owner_sid <> 0x010100000000000514000000)     -- NT AUTHORITY\NETWORK SERVICE sid
  BEGIN
     IF (@owner_sid IS NULL) OR (EXISTS (SELECT *
                                      FROM master.dbo.syslogins
                                      WHERE (sid = @owner_sid)
                                      AND (isntgroup <> 0)))
     BEGIN
       -- NOTE: In the following message we quote @owner_login_name instead of @owner_sid
       --       since this is the parameter the user passed to the calling SP (ie. either
       --       sp_add_schedule, sp_add_job and sp_update_job)
       SELECT @res_valid_range = FORMATMESSAGE(14203)
       RAISERROR(14234, -1, -1, '@owner_login_name', @res_valid_range)
       RETURN(1) -- Failure
     END
  END
  
  -- Verify name (we disallow schedules called 'ALL' since this has special meaning in sp_delete_jobschedules)
  IF (UPPER(@name collate SQL_Latin1_General_CP1_CS_AS) = N'ALL')
  BEGIN
    RAISERROR(14200, -1, -1, '@name')
    RETURN(1) -- Failure
  END

  -- Verify enabled state
  IF (@enabled <> 0) AND (@enabled <> 1)
  BEGIN
    RAISERROR(14266, -1, -1, '@enabled', '0, 1')
    RETURN(1) -- Failure
  END

  -- Verify frequency type
  IF (@freq_type = 0x2) -- OnDemand is no longer supported
  BEGIN
    RAISERROR(14295, -1, -1)
    RETURN(1) -- Failure
  END
  IF (@freq_type NOT IN (0x1, 0x4, 0x8, 0x10, 0x20, 0x40, 0x80))
  BEGIN
    RAISERROR(14266, -1, -1, '@freq_type', '1, 4, 8, 16, 32, 64, 128')
    RETURN(1) -- Failure
  END

  -- Verify frequency sub-day type
  IF (@freq_subday_type <> 0) AND (@freq_subday_type NOT IN (0x1, 0x2, 0x4, 0x8))
  BEGIN
    RAISERROR(14266, -1, -1, '@freq_subday_type', '0x1, 0x2, 0x4, 0x8')
    RETURN(1) -- Failure
  END

  -- Default active start/end date/times (if not supplied, or supplied as NULLs or 0)
  IF (@active_start_date = 0)
    SELECT @active_start_date = DATEPART(yy, GETDATE()) * 10000 +
                                DATEPART(mm, GETDATE()) * 100 +
                                DATEPART(dd, GETDATE()) -- This is an ISO format: "yyyymmdd"
  IF (@active_end_date = 0)
    SELECT @active_end_date = 99991231  -- December 31st 9999
  IF (@active_start_time = 0)
    SELECT @active_start_time = 000000  -- 12:00:00 am
  IF (@active_end_time = 0)
    SELECT @active_end_time = 235959    -- 11:59:59 pm

  -- Verify active start/end dates
  IF (@active_end_date = 0)
    SELECT @active_end_date = 99991231

  EXECUTE @return_code = sp_verify_job_date @active_end_date, '@active_end_date'
  IF (@return_code <> 0)
    RETURN(1) -- Failure

  EXECUTE @return_code = sp_verify_job_date @active_start_date, '@active_start_date'
  IF (@return_code <> 0)
    RETURN(1) -- Failure

  IF (@active_end_date < @active_start_date)
  BEGIN
    RAISERROR(14288, -1, -1, '@active_end_date', '@active_start_date')
    RETURN(1) -- Failure
  END

  EXECUTE @return_code = sp_verify_job_time @active_end_time, '@active_end_time'
  IF (@return_code <> 0)
    RETURN(1) -- Failure

  EXECUTE @return_code = sp_verify_job_time @active_start_time, '@active_start_time'
  IF (@return_code <> 0)
    RETURN(1) -- Failure

  -- NOTE: It's valid for active_end_time to be less than active_start_time since in this
  --       case we assume that the user wants the active time zone to span midnight.
  --       But it's not valid for active_start_date and active_end_date to be the same for recurring sec/hour/minute schedules

  IF (@active_start_time = @active_end_time and (@freq_subday_type in (0x2, 0x4, 0x8)))
  BEGIN
    SELECT @res_valid_range = FORMATMESSAGE(14202)
    RAISERROR(14266, -1, -1, '@active_end_time', @res_valid_range)
    RETURN(1) -- Failure
  END

  -- NOTE: The rest of this procedure is a SQL implementation of VerifySchedule in job.c

  IF ((@freq_type = 0x1) OR  -- FREQTYPE_ONETIME
      (@freq_type = 0x40) OR -- FREQTYPE_AUTOSTART
      (@freq_type = 0x80))   -- FREQTYPE_ONIDLE
  BEGIN
    -- Set standard defaults for non-required parameters
    SELECT @freq_interval          = 0
    SELECT @freq_subday_type       = 0
    SELECT @freq_subday_interval   = 0
    SELECT @freq_relative_interval = 0
    SELECT @freq_recurrence_factor = 0

    -- Check that a one-time schedule isn't already in the past
    -- Bug 442883: let the creation of the one-time schedule succeed but leave a disabled schedule
    /*
    IF (@freq_type = 0x1) -- FREQTYPE_ONETIME
    BEGIN
      DECLARE @current_date INT
      DECLARE @current_time INT

      -- This is an ISO format: "yyyymmdd"
      SELECT @current_date = CONVERT(INT, CONVERT(VARCHAR, GETDATE(), 112))
      SELECT @current_time = (DATEPART(hh, GETDATE()) * 10000) + (DATEPART(mi, GETDATE()) * 100) + DATEPART(ss, GETDATE())
      IF (@active_start_date < @current_date) OR ((@active_start_date = @current_date) AND (@active_start_time <= @current_time))
      BEGIN
        SELECT @res_valid_range = '> ' + CONVERT(VARCHAR, @current_date) + ' / ' + CONVERT(VARCHAR, @current_time)
        SELECT @reason = '@active_start_date = ' + CONVERT(VARCHAR, @active_start_date) + ' / @active_start_time = ' + CONVERT(VARCHAR, @active_start_time)
        RAISERROR(14266, -1, -1, @reason, @res_valid_range)
        RETURN(1) -- Failure
      END
    END
    */

    GOTO ExitProc
  END

  -- Safety net: If the sub-day-type is 0 (and we know that the schedule is not a one-time or
  --             auto-start) then set it to 1 (FREQSUBTYPE_ONCE).  If the user wanted something
  --             other than ONCE then they should have explicitly set @freq_subday_type.
  IF (@freq_subday_type = 0)
    SELECT @freq_subday_type = 0x1 -- FREQSUBTYPE_ONCE

  IF ((@freq_subday_type <> 0x1) AND  -- FREQSUBTYPE_ONCE   (see qsched.h)
      (@freq_subday_type <> 0x2) AND  -- FREQSUBTYPE_SECOND (see qsched.h)
      (@freq_subday_type <> 0x4) AND  -- FREQSUBTYPE_MINUTE (see qsched.h)
      (@freq_subday_type <> 0x8))     -- FREQSUBTYPE_HOUR   (see qsched.h)
  BEGIN
    SELECT @reason = FORMATMESSAGE(14266, '@freq_subday_type', '0x1, 0x2, 0x4, 0x8')
    RAISERROR(14278, -1, -1, @reason)
    RETURN(1) -- Failure
  END

  IF ((@freq_subday_type <> 0x1) AND (@freq_subday_interval < 1)) -- FREQSUBTYPE_ONCE and less than 1 interval
     OR
     ((@freq_subday_type = 0x2) AND (@freq_subday_interval < 10)) -- FREQSUBTYPE_SECOND and less than 10 seconds (see MIN_SCHEDULE_GRANULARITY in SqlAgent source code)
  BEGIN
    SELECT @reason = FORMATMESSAGE(14200, '@freq_subday_interval')
    RAISERROR(14278, -1, -1, @reason)
    RETURN(1) -- Failure
  END

  IF (@freq_type = 0x4)      -- FREQTYPE_DAILY
  BEGIN
    SELECT @freq_recurrence_factor = 0
    IF (@freq_interval < 1)
    BEGIN
      SELECT @reason = FORMATMESSAGE(14572)
      RAISERROR(14278, -1, -1, @reason)
      RETURN(1) -- Failure
    END
  END

  IF (@freq_type = 0x8)      -- FREQTYPE_WEEKLY
  BEGIN
    IF (@freq_interval < 1)   OR
       (@freq_interval > 127) -- (2^7)-1 [freq_interval is a bitmap (Sun=1..Sat=64)]
    BEGIN
      SELECT @reason = FORMATMESSAGE(14573)
      RAISERROR(14278, -1, -1, @reason)
      RETURN(1) -- Failure
    END

  END

  IF (@freq_type = 0x10)    -- FREQTYPE_MONTHLY
  BEGIN
    IF (@freq_interval < 1)  OR
       (@freq_interval > 31)
    BEGIN
      SELECT @reason = FORMATMESSAGE(14574)
      RAISERROR(14278, -1, -1, @reason)
      RETURN(1) -- Failure
    END

  END

  IF (@freq_type = 0x20)     -- FREQTYPE_MONTHLYRELATIVE
  BEGIN
    IF (@freq_relative_interval <> 0x01) AND  -- RELINT_1ST
       (@freq_relative_interval <> 0x02) AND  -- RELINT_2ND
       (@freq_relative_interval <> 0x04) AND  -- RELINT_3RD
       (@freq_relative_interval <> 0x08) AND  -- RELINT_4TH
       (@freq_relative_interval <> 0x10)      -- RELINT_LAST
    BEGIN
      SELECT @reason = FORMATMESSAGE(14575)
      RAISERROR(14278, -1, -1, @reason)
      RETURN(1) -- Failure
    END
  END

  IF (@freq_type = 0x20)     -- FREQTYPE_MONTHLYRELATIVE
  BEGIN
    IF (@freq_interval <> 01) AND -- RELATIVE_SUN
       (@freq_interval <> 02) AND -- RELATIVE_MON
       (@freq_interval <> 03) AND -- RELATIVE_TUE
       (@freq_interval <> 04) AND -- RELATIVE_WED
       (@freq_interval <> 05) AND -- RELATIVE_THU
       (@freq_interval <> 06) AND -- RELATIVE_FRI
       (@freq_interval <> 07) AND -- RELATIVE_SAT
       (@freq_interval <> 08) AND -- RELATIVE_DAY
       (@freq_interval <> 09) AND -- RELATIVE_WEEKDAY
       (@freq_interval <> 10)     -- RELATIVE_WEEKENDDAY
    BEGIN
      SELECT @reason = FORMATMESSAGE(14576)
      RAISERROR(14278, -1, -1, @reason)
      RETURN(1) -- Failure
    END
  END

  IF ((@freq_type = 0x08)  OR   -- FREQTYPE_WEEKLY
      (@freq_type = 0x10)  OR   -- FREQTYPE_MONTHLY
      (@freq_type = 0x20)) AND  -- FREQTYPE_MONTHLYRELATIVE
      (@freq_recurrence_factor < 1)
  BEGIN
    SELECT @reason = FORMATMESSAGE(14577)
    RAISERROR(14278, -1, -1, @reason)
    RETURN(1) -- Failure
  END

ExitProc:
  -- If we made it this far the schedule is good
  RETURN(0) -- Success

END

GO
/****** Object:  StoredProcedure [dbo].[sp_verify_schedule_identifiers]    Script Date: 10-06-2020 17:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_verify_schedule_identifiers]
  @name_of_name_parameter   VARCHAR(60),             -- Eg. '@schedule_name'
  @name_of_id_parameter     VARCHAR(60),             -- Eg. '@schedule_id'
  @schedule_name            sysname             OUTPUT, 
  @schedule_id              INT                 OUTPUT,
  @owner_sid                VARBINARY(85)       OUTPUT,
  @orig_server_id           INT                 OUTPUT,
  @job_id_filter            UNIQUEIDENTIFIER    = NULL
AS
BEGIN
  DECLARE @retval         INT
  DECLARE @schedule_id_as_char VARCHAR(36)
  DECLARE @sch_name_count INT

  SET NOCOUNT ON
  
  -- Remove any leading/trailing spaces from parameters
  SELECT @name_of_name_parameter = LTRIM(RTRIM(@name_of_name_parameter))
  SELECT @name_of_id_parameter   = LTRIM(RTRIM(@name_of_id_parameter))
  SELECT @schedule_name          = LTRIM(RTRIM(@schedule_name))
  SELECT @sch_name_count         = 0
  

  IF (@schedule_name = N'') SELECT @schedule_name = NULL

  IF ((@schedule_name IS NULL)     AND (@schedule_id IS NULL)) OR
     ((@schedule_name IS NOT NULL) AND (@schedule_id IS NOT NULL))
  BEGIN
    RAISERROR(14373, -1, -1, @name_of_id_parameter, @name_of_name_parameter)
    RETURN(1) -- Failure
  END

  -- Check schedule id
  IF (@schedule_id IS NOT NULL)
  BEGIN
    -- if Agent is calling look in all schedules not just the local server schedules
    if(PROGRAM_NAME() LIKE N'SQLAgent%')
    BEGIN
        -- Look at all schedules
        SELECT @schedule_name   = name,
           @owner_sid           = owner_sid,
           @orig_server_id      = originating_server_id
        FROM dbo.sysschedules
        WHERE (schedule_id = @schedule_id)
    END
    ELSE
    BEGIN
        --Look at local schedules only
        SELECT @schedule_name   = name,
           @owner_sid           = owner_sid,
           @orig_server_id      = originating_server_id
        FROM dbo.sysschedules_localserver_view
        WHERE (schedule_id = @schedule_id)
    END

    IF (@schedule_name IS NULL)
    BEGIN
     --If the schedule is from an MSX and a sysadmin is calling report a specific 'MSX' message
      IF(PROGRAM_NAME() NOT LIKE N'SQLAgent%' AND
         ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1 AND
         EXISTS(SELECT * 
                FROM dbo.sysschedules as sched
                  JOIN dbo.sysoriginatingservers_view as svr
                    ON sched.originating_server_id = svr.originating_server_id
                WHERE (schedule_id = @schedule_id) AND 
                      (svr.master_server = 1)))
     BEGIN
       RAISERROR(14274, -1, -1)
     END
      ELSE  
      BEGIN
        SELECT @schedule_id_as_char = CONVERT(VARCHAR(36), @schedule_id)
        RAISERROR(14262, -1, -1, '@schedule_id', @schedule_id_as_char)
      END

      RETURN(1) -- Failure
    END
  END
  ELSE
  -- Check job name
  IF (@schedule_name IS NOT NULL)
  BEGIN
    -- if a job_id is supplied use it as a filter. This helps with V8 legacy support
    IF(@job_id_filter IS NOT NULL)
    BEGIN
        -- Check if the job name is ambiguous and also get the schedule_id optimistically.
        -- If the name is not ambiguous this gets the corresponding schedule_id (if the schedule exists)
        SELECT @sch_name_count = COUNT(*),
               @schedule_id    = MIN(s.schedule_id),
               @owner_sid      = MIN(owner_sid),
               @orig_server_id = MIN(originating_server_id)
        FROM dbo.sysschedules_localserver_view as s
          JOIN dbo.sysjobschedules as js 
            ON s.schedule_id = js.schedule_id
        WHERE (name = @schedule_name) AND
              (js.job_id = @job_id_filter)
    END
    ELSE
    BEGIN
      -- Check if the job name is ambiguous from the count(*) result
        -- If the name is not ambiguous it is safe use the fields returned by the MIN() function
        SELECT @sch_name_count = COUNT(*),
         @schedule_id     = MIN(schedule_id),
            @owner_sid       = MIN(owner_sid),
            @orig_server_id  = MIN(originating_server_id)
        FROM dbo.sysschedules_localserver_view
        WHERE (name = @schedule_name)
    END

    IF(@sch_name_count > 1)
    BEGIN
        -- ambiguous, user needs to use a schedule_id instead of a schedule_name
        RAISERROR(14371, -1, -1, @schedule_name, @name_of_id_parameter, @name_of_name_parameter)
        RETURN(1) -- Failure
    END

    --schedule_id isn't visible to this user or doesn't exist
    IF (@schedule_id IS NULL)
    BEGIN
      --If the schedule is from an MSX and a sysadmin is calling report a specific 'MSX' message
      IF(PROGRAM_NAME() NOT LIKE N'SQLAgent%' AND
         ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1 AND
         EXISTS(SELECT * 
                FROM dbo.sysschedules as sched
                  JOIN dbo.sysoriginatingservers_view as svr
                    ON sched.originating_server_id = svr.originating_server_id
                  JOIN dbo.sysjobschedules as js 
                    ON sched.schedule_id = js.schedule_id
                WHERE (svr.master_server = 1) AND
                      (name = @schedule_name) AND
                      ((@job_id_filter IS NULL) OR (js.job_id = @job_id_filter))))
     BEGIN
       RAISERROR(14274, -1, -1)
     END
      ELSE
      BEGIN
        --If not a MSX schedule raise local error
        RAISERROR(14262, -1, -1, '@schedule_name', @schedule_name)
      END

      RETURN(1) -- Failure
    END
  END

  RETURN(0) -- Success
END
GO