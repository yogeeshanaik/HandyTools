/****** Object:  StoredProcedure [dbo].[usp_verify_schedule_identifiers]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_schedule_identifiers]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_verify_schedule_identifiers]
GO
/****** Object:  StoredProcedure [dbo].[usp_verify_schedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_schedule]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_verify_schedule]
GO
/****** Object:  StoredProcedure [dbo].[usp_verify_jobstep]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_jobstep]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_verify_jobstep]
GO
/****** Object:  StoredProcedure [dbo].[usp_verify_job_time]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_job_time]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_verify_job_time]
GO
/****** Object:  StoredProcedure [dbo].[usp_verify_job_identifiers]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_job_identifiers]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_verify_job_identifiers]
GO
/****** Object:  StoredProcedure [dbo].[usp_verify_job_date]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_job_date]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_verify_job_date]
GO
/****** Object:  StoredProcedure [dbo].[usp_verify_job]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_job]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_verify_job]
GO
/****** Object:  StoredProcedure [dbo].[usp_verify_category_identifiers]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_category_identifiers]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_verify_category_identifiers]
GO
/****** Object:  StoredProcedure [dbo].[usp_update_schedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_update_schedule]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_update_schedule]
GO
/****** Object:  StoredProcedure [dbo].[usp_update_jobstep]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_update_jobstep]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_update_jobstep]
GO
/****** Object:  StoredProcedure [dbo].[usp_update_job]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_update_job]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_update_job]
GO
/****** Object:  StoredProcedure [dbo].[usp_start_schedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_start_schedule]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_start_schedule]
GO
/****** Object:  StoredProcedure [dbo].[usp_start_jobsteps]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_start_jobsteps]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_start_jobsteps]
GO
/****** Object:  StoredProcedure [dbo].[usp_start_job]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_start_job]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_start_job]
GO
/****** Object:  StoredProcedure [dbo].[usp_set_jobstep_completion_state]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_set_jobstep_completion_state]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_set_jobstep_completion_state]
GO
/****** Object:  StoredProcedure [dbo].[usp_log_jobhistory]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_log_jobhistory]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_log_jobhistory]
GO
/****** Object:  StoredProcedure [dbo].[usp_help_jobstep]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_help_jobstep]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_help_jobstep]
GO
/****** Object:  StoredProcedure [dbo].[usp_help_jobschedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_help_jobschedule]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_help_jobschedule]
GO
/****** Object:  StoredProcedure [dbo].[usp_get_schedule_description]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_get_schedule_description]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_get_schedule_description]
GO
/****** Object:  StoredProcedure [dbo].[usp_get_jobschedules]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_get_jobschedules]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_get_jobschedules]
GO
/****** Object:  StoredProcedure [dbo].[usp_detach_schedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_detach_schedule]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_detach_schedule]
GO
/****** Object:  StoredProcedure [dbo].[usp_delete_schedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_delete_schedule]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_delete_schedule]
GO
/****** Object:  StoredProcedure [dbo].[usp_attach_schedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_attach_schedule]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_attach_schedule]
GO
/****** Object:  StoredProcedure [dbo].[usp_add_schedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_schedule]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_add_schedule]
GO
/****** Object:  StoredProcedure [dbo].[usp_add_jobstep_internal]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_jobstep_internal]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_add_jobstep_internal]
GO
/****** Object:  StoredProcedure [dbo].[usp_add_jobstep]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_jobstep]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_add_jobstep]
GO
/****** Object:  StoredProcedure [dbo].[usp_add_jobschedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_jobschedule]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_add_jobschedule]
GO
/****** Object:  StoredProcedure [dbo].[usp_add_job]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_job]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_add_job]
GO
/****** Object:  View [dbo].[Jobs_View]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Jobs_View]'))
DROP VIEW [dbo].[Jobs_View]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schedules]') AND type in (N'U'))
DROP TABLE [dbo].[Schedules]
GO
/****** Object:  Table [dbo].[JobSteps]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobSteps]') AND type in (N'U'))
DROP TABLE [dbo].[JobSteps]
GO
/****** Object:  Table [dbo].[JobSchedules]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobSchedules]') AND type in (N'U'))
DROP TABLE [dbo].[JobSchedules]
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Jobs]') AND type in (N'U'))
DROP TABLE [dbo].[Jobs]
GO
/****** Object:  Table [dbo].[JobHistory]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobHistory]') AND type in (N'U'))
DROP TABLE [dbo].[JobHistory]
GO
/****** Object:  Table [dbo].[JobCategories]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobCategories]') AND type in (N'U'))
DROP TABLE [dbo].[JobCategories]
GO
/****** Object:  UserDefinedFunction [dbo].[udfGetScheduleTimes]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udfGetScheduleTimes]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udfGetScheduleTimes]
GO
/****** Object:  UserDefinedFunction [dbo].[udfGetNextSchedule]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udfGetNextSchedule]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udfGetNextSchedule]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_TimeToInt]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_TimeToInt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_TimeToInt]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_Job_Datetime]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_Job_Datetime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_Job_Datetime]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_IntToTimeString]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_IntToTimeString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_IntToTimeString]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_DateToInt]    Script Date: 30-06-2020 16:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_DateToInt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_DateToInt]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_DateToInt]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_DateToInt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'/************************************************
-- FUNCTION fn_IntToTimeString
-- AUTHOR	Alan Jefferson
-- Date		5/11/2017
--
-- Purpose	convert integer representation of time found in sysschedules to a displayable form
*************************************************/
CREATE FUNCTION [dbo].[fn_DateToInt] (@date datetime)
returns varchar(20)
AS
BEGIN
declare @return varchar(20)
set @return = FORMAT(@date,''yyyyMMdd'')
return @return;
END' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_IntToTimeString]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_IntToTimeString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'/************************************************
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
set @return = ''''
if @time is NOT null and @time >= 0 and @time < 240000
select @return = REPLACE(convert(varchar(20), convert(TIME, left(right(''000000'' + convert(varchar(6),@time), 6),2) + '':'' 
				+ substring(right(''000000'' + convert(varchar(6),@time), 6), 3,2) + '':'' 
				+ right(''00'' + convert(varchar(6),@time), 2)),109),''.0000000'', '' '')
return @return;
END' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_Job_Datetime]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_Job_Datetime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- Alter Function fn_Job_Datetime


CREATE FUNCTION [dbo].[fn_Job_Datetime](@date int, @time int)
RETURNS DATETIME
AS
BEGIN
 RETURN
  (
    CONVERT(DATETIME,
          CONVERT(NVARCHAR(4),@date / 10000) + N''-'' + 
          CONVERT(NVARCHAR(2),(@date % 10000)/100)  + N''-'' +
          CONVERT(NVARCHAR(2),@date % 100) + N'' '' +        
          CONVERT(NVARCHAR(2),@time / 10000) + N'':'' +        
          CONVERT(NVARCHAR(2),(@time % 10000)/100) + N'':'' +        
          CONVERT(NVARCHAR(2),@time % 100),
    120)
  )
END
' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_TimeToInt]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_TimeToInt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'/************************************************
-- FUNCTION fn_IntToTimeString
-- AUTHOR	Alan Jefferson
-- Date		5/11/2017
--
-- Purpose	convert integer representation of time found in sysschedules to a displayable form
*************************************************/
CREATE FUNCTION [dbo].[fn_TimeToInt] (@time datetime)
returns varchar(20)
AS
BEGIN
declare @return varchar(20)
set @return = FORMAT(@time,''HHmmss'')
return @return;
END' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[udfGetNextSchedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udfGetNextSchedule]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N' -- SELECT * FROM [dbo].[udfGetNextSchedule] (2)
CREATE FUNCTION [dbo].[udfGetNextSchedule]
(
	@schedule_id int 
)
RETURNS 
--DECLARE @schedule_id int = 2
--DECLARE
@t TABLE (
		scheduleID INT NOT NULL,
		--serverName SYSNAME NOT NULL,
		--jobName SYSNAME NOT NULL,
		--jobDescription NVARCHAR(512) NOT NULL,
		scheduleName SYSNAME NOT NULL,
		--categoryName SYSNAME NOT NULL,
		infoDate DATETIME NOT NULL,
		startTime DATETIME NOT NULL,
		endTime DATETIME NOT NULL,
		--jobEnabled INT NOT NULL,
		scheduleEnabled INT NOT NULL)

--AS

BEGIN

DECLARE @startDate DATETIME = GETDATE()-1
DECLARE @endDate DATETIME = GETDATE() +365

-- Create a tally table. If you already have one of your own please use that instead.
DECLARE	@tallyNumbers TABLE
		(
			num SMALLINT PRIMARY KEY CLUSTERED
		)

DECLARE	@index SMALLINT

SET	@index = 1

WHILE @index <= 8640
	BEGIN
		INSERT	@tallyNumbers
			(
				num
			)
		VALUES	(
				@index
			)

		SET	@index = @index + 1
	END

-- Create a staging table for jobschedules
DECLARE	@jobSchedules TABLE
		(
			rowID INT IDENTITY(1, 1) PRIMARY KEY CLUSTERED,
			--serverName SYSNAME NOT NULL,
			--jobName SYSNAME NOT NULL,
			--jobDescription NVARCHAR(512) NOT NULL,
			scheduleName SYSNAME NOT NULL,
			scheduleID INT NOT NULL,
			--categoryName SYSNAME NOT NULL,
			freq_type INT NOT NULL,
			freq_interval INT NOT NULL,
			freq_subday_type INT NOT NULL,
			freq_subday_interval INT NOT NULL,
			freq_relative_interval INT NOT NULL,
			freq_recurrence_factor INT NOT NULL,
			startDate DATETIME NOT NULL,
			startTime DATETIME NOT NULL,
			endDate DATETIME NOT NULL,
			endTime DATETIME NOT NULL,
			--jobEnabled INT NOT NULL,
			scheduleEnabled INT NOT NULL
		)


-- Popoulate the staging table for JobSchedules with SQL Server 2005 and SQL Server 2008
INSERT		@JobSchedules
		(
			--serverName,
			--jobName,
			--jobDescription,
			scheduleName,
			scheduleID,
			--categoryName,
			freq_type,
			freq_interval,
			freq_subday_type,
			freq_subday_interval,
			freq_relative_interval,
			freq_recurrence_factor,
			startDate,
			startTime,
			endDate,
			endTime,
			--jobEnabled,
			scheduleEnabled
		)
SELECT		--srv.srvname,
		--sj.name,
		--COALESCE(sj.description, ''''),
		ss.name,
		ss.schedule_id,
		--sc.name,
		ss.freq_type,
		ss.freq_interval,
		ss.freq_subday_type,
		ss.freq_subday_interval,
		ss.freq_relative_interval,
		ss.freq_recurrence_factor,
		COALESCE(STR(ss.active_start_date, 8), CONVERT(CHAR(8), GETDATE(), 112)),
		STUFF(STUFF(REPLACE(STR(ss.active_start_time, 6), '' '', ''0''), 3, 0, '':''), 6, 0, '':''),
		STR(ss.active_end_date, 8),
		STUFF(STUFF(REPLACE(STR(ss.active_end_time, 6), '' '', ''0''), 3, 0, '':''), 6, 0, '':''),
		--sj.enabled,
		ss.enabled
FROM		Schedules AS ss
--INNER JOIN	JobSchedules AS sjs ON sjs.schedule_id = ss.schedule_id
--INNER JOIN	Jobs AS sj ON sj.job_id = sjs.job_id
--INNER JOIN	sys.sysservers AS srv ON srv.srvid = sj.originating_server_id
--INNER JOIN	JobCategories AS sc ON sc.category_id = sj.category_id
WHERE		ss.freq_type IN (1, 4, 8, 16, 32)
AND			ss.schedule_id = @schedule_id
ORDER BY	--srv.srvname,
		--sj.name,
		ss.name

-- Deal with first, second, third, fourth and last occurence
DECLARE	@tempStart DATETIME,
	@tempEnd DATETIME

SELECT	@tempStart = DATEADD(MONTH, DATEDIFF(MONTH, ''19000101'', @startDate), ''19000101''),
	@TempEnd = DATEADD(MONTH, DATEDIFF(MONTH, ''18991231'', @endDate), ''18991231'')

DECLARE	@dayInformation TABLE
		(
			infoDate DATETIME PRIMARY KEY CLUSTERED,
			weekdayName VARCHAR(9) NOT NULL,
			statusCode INT NOT NULL,
			lastDay TINYINT DEFAULT 0
		)

WHILE @tempStart <= @tempEnd
	BEGIN
		INSERT	@dayInformation
			(
				infoDate,
				weekdayName,
				statusCode
			)
		SELECT	@tempStart,
			DATENAME(WEEKDAY, @tempStart),
			CASE
				WHEN DATEPART(DAY, @tempStart) BETWEEN 1 AND 7 THEN 1
				WHEN DATEPART(DAY, @tempStart) BETWEEN 8 AND 14 THEN 2
				WHEN DATEPART(DAY, @tempStart) BETWEEN 15 AND 21 THEN 4
				WHEN DATEPART(DAY, @tempStart) BETWEEN 22 AND 28 THEN 8
				ELSE 0
			END

		SET	@tempStart = DATEADD(DAY, 1, @tempStart)
	END

UPDATE		di
SET		di.statusCode = di.statusCode + 16
FROM		@dayInformation AS di
INNER JOIN	(
			SELECT		DATEDIFF(MONTH, ''19000101'', infoDate) AS theMonth,
					DATEPART(DAY, MAX(infoDate)) - 6 AS theDay
			FROM		@dayInformation
			GROUP BY	DATEDIFF(MONTH, ''19000101'', infoDate)
		) AS x ON x.theMonth = DATEDIFF(MONTH, ''19000101'', di.infoDate)
WHERE		DATEPART(DAY, di.infoDate) >= x.theDay

UPDATE		di
SET		di.lastDay = 16
FROM		@dayInformation AS di
INNER JOIN	(
			SELECT		DATEDIFF(MONTH, ''19000101'', infoDate) AS theMonth,
					MAX(infoDate) AS theDay
			FROM		@dayInformation
			GROUP BY	DATEDIFF(MONTH, ''19000101'', infoDate)
		) AS x ON x.theMonth = DATEDIFF(MONTH, ''19000101'', di.infoDate)
WHERE		di.infoDate = x.theDay

UPDATE	@dayInformation
SET	lastDay = DATEPART(DAY, infoDate)
WHERE	DATEPART(DAY, infoDate) BETWEEN 1 AND 4

-- Stage all individual schedule times
DECLARE	@scheduleTimes TABLE
		(
			rowID INT NOT NULL,
			infoDate DATETIME NOT NULL,
			startTime DATETIME NOT NULL,
			endTime DATETIME NOT NULL,
			waitSeconds INT DEFAULT 0
		)


-- Insert one time only schedules
INSERT	@scheduleTimes
	(
		rowID,
		infoDate,
		startTime,
		endTime
	)
SELECT	rowID,
	startDate,
	startTime,
	endTime
FROM	@jobSchedules
WHERE	freq_type = 1
	AND startDate >= @StartDate
	AND startDate <= @EndDate

-- Insert daily schedules
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		js.rowID,
		di.infoDate,
		js.startTime,
		js.endTime,
		CASE js.freq_subday_type
			WHEN 1 THEN 0
			WHEN 2 THEN js.freq_subday_interval
			WHEN 4 THEN 60 * js.freq_subday_interval
			WHEN 8 THEN 3600 * js.freq_subday_interval
		END
FROM		@jobSchedules AS js
INNER JOIN	@dayInformation AS di ON di.infoDate >= @startDate
			AND di.infoDate <= @endDate
WHERE		js.freq_type = 4
		AND DATEDIFF(DAY, js.startDate, di.infoDate) % js.freq_interval = 0

-- Insert weekly schedules
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		js.rowID,
		di.infoDate,
		js.startTime,
		js.endTime,
		CASE js.freq_subday_type
			WHEN 1 THEN 0
			WHEN 2 THEN js.freq_subday_interval
			WHEN 4 THEN 60 * js.freq_subday_interval
			WHEN 8 THEN 3600 * js.freq_subday_interval
		END
FROM		@jobSchedules AS js
INNER JOIN	@dayInformation AS di ON di.infoDate >= @startDate
			AND di.infoDate <= @endDate
WHERE		js.freq_type = 8
		AND 1 =	CASE
				WHEN js.freq_interval & 1 = 1 AND di.weekdayName = ''Sunday'' THEN 1
				WHEN js.freq_interval & 2 = 2 AND di.weekdayName = ''Monday'' THEN 1
				WHEN js.freq_interval & 4 = 4 AND di.weekdayName = ''Tuesday'' THEN 1
				WHEN js.freq_interval & 8 = 8 AND di.weekdayName = ''Wednesday'' THEN 1
				WHEN js.freq_interval & 16 = 16 AND di.weekdayName = ''Thursday'' THEN 1
				WHEN js.freq_interval & 32 = 32 AND di.weekdayName = ''Friday'' THEN 1
				WHEN js.freq_interval & 64 = 64 AND di.weekdayName = ''Saturday'' THEN 1
				ELSE 0
			END
		AND (DATEDIFF(DAY, js.startDate, di.infoDate) / 7) % js.freq_recurrence_factor = 0

-- Insert monthly schedules
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		js.rowID,
		di.infoDate,
		js.startTime,
		js.endTime,
		CASE js.freq_subday_type
			WHEN 1 THEN 0
			WHEN 2 THEN js.freq_subday_interval
			WHEN 4 THEN 60 * js.freq_subday_interval
			WHEN 8 THEN 3600 * js.freq_subday_interval
		END
FROM		@jobSchedules AS js
INNER JOIN	@dayInformation AS di ON di.infoDate >= @startDate
			AND di.infoDate <= @endDate
WHERE		js.freq_type = 16
		AND DATEPART(DAY, di.infoDate) = js.freq_interval
		AND DATEDIFF(MONTH, js.startDate, di.infoDate) % js.freq_recurrence_factor = 0

-- Insert monthly relative schedules
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		js.rowID,
		di.infoDate,
		js.startTime,
		js.endTime,
		CASE js.freq_subday_type
			WHEN 1 THEN 0
			WHEN 2 THEN js.freq_subday_interval
			WHEN 4 THEN 60 * js.freq_subday_interval
			WHEN 8 THEN 3600 * js.freq_subday_interval
		END
FROM		@jobSchedules AS js
INNER JOIN	@dayInformation AS di ON di.infoDate >= @startDate
			AND di.infoDate <= @endDate
WHERE		js.freq_type = 32
		AND 1 =	CASE
				WHEN js.freq_interval = 1 AND di.weekdayName = ''Sunday'' THEN 1
				WHEN js.freq_interval = 2 AND di.weekdayName = ''Monday'' THEN 1
				WHEN js.freq_interval = 3 AND di.weekdayName = ''Tuesday'' THEN 1
				WHEN js.freq_interval = 4 AND di.weekdayName = ''Wednesday'' THEN 1
				WHEN js.freq_interval = 5 AND di.weekdayName = ''Thursday'' THEN 1
				WHEN js.freq_interval = 6 AND di.weekdayName = ''Friday'' THEN 1
				WHEN js.freq_interval = 7 AND di.weekdayName = ''Saturday'' THEN 1
				WHEN js.freq_interval = 8 AND js.freq_relative_interval = di.lastDay THEN 1
				WHEN js.freq_interval = 9 AND di.weekdayName NOT IN (''Sunday'', ''Saturday'') THEN 1
				WHEN js.freq_interval = 10 AND di.weekdayName IN (''Sunday'', ''Saturday'') THEN 1
				ELSE 0
			END
		AND di.statusCode & js.freq_relative_interval = js.freq_relative_interval
		AND DATEDIFF(MONTH, js.startDate, di.infoDate) % js.freq_recurrence_factor = 0

--	select * from @scheduleTimes return;

-- Get the daily recurring schedule times
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		st.rowID,
		st.infoDate,
		DATEADD(SECOND, tn.num * st.waitSeconds, st.startTime),
		st.endTime,
		st.waitSeconds
FROM		@scheduleTimes AS st
CROSS JOIN	@tallyNumbers AS tn
WHERE		tn.num * st.waitSeconds <= DATEDIFF(SECOND, st.startTime, st.endTime)
		AND st.waitSeconds > 0

-- Present the result
INSERT @t (scheduleID,
		--serverName,
		--jobName,
		--jobDescription,
		scheduleName,
		--categoryName,
		infoDate,
		startTime,
		endTime,
		--jobEnabled,
		scheduleEnabled)
SELECT	TOP 1 js.scheduleID,
		--js.serverName,
		--js.jobName,
		--js.jobDescription,
		js.scheduleName,
		--js.categoryName,
		--st.infoDate,
		st.infoDate + st.startTime,
		st.startTime,
		st.endTime,
		--js.jobEnabled,
		js.scheduleEnabled
FROM		@scheduleTimes AS st
INNER JOIN	@jobSchedules AS js ON js.rowID = st.rowID
LEFT JOIN (
	SELECT [dbo].[JobSchedules].schedule_id,
	MAX([dbo].[fn_Job_Datetime](run_date,run_time)) [LastRunDate]
	FROM [dbo].[JobHistory] 
	INNER JOIN [dbo].[JobSchedules] ON  [dbo].[JobHistory].job_id = [dbo].[JobSchedules].job_id
	WHERE run_status = 1
	GROUP BY [dbo].[JobSchedules].schedule_id
)AS JH ON JS.scheduleID = JH.schedule_id
WHERE js.scheduleEnabled = 1
AND st.infoDate + st.startTime > GETDATE()
AND (JH.[LastRunDate] IS NULL OR st.infoDate + st.startTime > JH.[LastRunDate])
AND (js.freq_type != 4 OR st.startTime!=''00:00:00.000'')

ORDER BY st.rowID

--SELECT * FROM @t

RETURN

END' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[udfGetScheduleTimes]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udfGetScheduleTimes]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[udfGetScheduleTimes]
(
	@startDate DATETIME,
	@endDate DATETIME
)

RETURNS @t TABLE (
		scheduleID INT NOT NULL,
		serverName SYSNAME NOT NULL,
		jobName SYSNAME NOT NULL,
		jobDescription NVARCHAR(512) NOT NULL,
		scheduleName SYSNAME NOT NULL,
		categoryName SYSNAME NOT NULL,
		infoDate DATETIME NOT NULL,
		startTime DATETIME NOT NULL,
		endTime DATETIME NOT NULL,
		jobEnabled INT NOT NULL,
		scheduleEnabled INT NOT NULL)

AS

BEGIN

-- Create a tally table. If you already have one of your own please use that instead.
DECLARE	@tallyNumbers TABLE
		(
			num SMALLINT PRIMARY KEY CLUSTERED
		)

DECLARE	@index SMALLINT

SET	@index = 1

WHILE @index <= 8640
	BEGIN
		INSERT	@tallyNumbers
			(
				num
			)
		VALUES	(
				@index
			)

		SET	@index = @index + 1
	END

-- Create a staging table for jobschedules
DECLARE	@jobSchedules TABLE
		(
			rowID INT IDENTITY(1, 1) PRIMARY KEY CLUSTERED,
			serverName SYSNAME NOT NULL,
			jobName SYSNAME NOT NULL,
			jobDescription NVARCHAR(512) NOT NULL,
			scheduleName SYSNAME NOT NULL,
			scheduleID INT NOT NULL,
			categoryName SYSNAME NOT NULL,
			freq_type INT NOT NULL,
			freq_interval INT NOT NULL,
			freq_subday_type INT NOT NULL,
			freq_subday_interval INT NOT NULL,
			freq_relative_interval INT NOT NULL,
			freq_recurrence_factor INT NOT NULL,
			startDate DATETIME NOT NULL,
			startTime DATETIME NOT NULL,
			endDate DATETIME NOT NULL,
			endTime DATETIME NOT NULL,
			jobEnabled INT NOT NULL,
			scheduleEnabled INT NOT NULL
		)


-- Popoulate the staging table for JobSchedules with SQL Server 2005 and SQL Server 2008
INSERT		@JobSchedules
		(
			serverName,
			jobName,
			jobDescription,
			scheduleName,
			scheduleID,
			categoryName,
			freq_type,
			freq_interval,
			freq_subday_type,
			freq_subday_interval,
			freq_relative_interval,
			freq_recurrence_factor,
			startDate,
			startTime,
			endDate,
			endTime,
			jobEnabled,
			scheduleEnabled
		)
SELECT		srv.srvname,
		sj.name,
		COALESCE(sj.description, ''''),
		ss.name,
		ss.schedule_id,
		sc.name,
		ss.freq_type,
		ss.freq_interval,
		ss.freq_subday_type,
		ss.freq_subday_interval,
		ss.freq_relative_interval,
		ss.freq_recurrence_factor,
		COALESCE(STR(ss.active_start_date, 8), CONVERT(CHAR(8), GETDATE(), 112)),
		STUFF(STUFF(REPLACE(STR(ss.active_start_time, 6), '' '', ''0''), 3, 0, '':''), 6, 0, '':''),
		STR(ss.active_end_date, 8),
		STUFF(STUFF(REPLACE(STR(ss.active_end_time, 6), '' '', ''0''), 3, 0, '':''), 6, 0, '':''),
		sj.enabled,
		ss.enabled
FROM		msdb..sysschedules AS ss
INNER JOIN	msdb..sysjobschedules AS sjs ON sjs.schedule_id = ss.schedule_id
INNER JOIN	msdb..sysjobs AS sj ON sj.job_id = sjs.job_id
INNER JOIN	sys.sysservers AS srv ON srv.srvid = sj.originating_server_id
INNER JOIN	msdb..syscategories AS sc ON sc.category_id = sj.category_id
WHERE		ss.freq_type IN (1, 4, 8, 16, 32)
ORDER BY	srv.srvname,
		sj.name,
		ss.name

-- Deal with first, second, third, fourth and last occurence
DECLARE	@tempStart DATETIME,
	@tempEnd DATETIME

SELECT	@tempStart = DATEADD(MONTH, DATEDIFF(MONTH, ''19000101'', @startDate), ''19000101''),
	@TempEnd = DATEADD(MONTH, DATEDIFF(MONTH, ''18991231'', @endDate), ''18991231'')

DECLARE	@dayInformation TABLE
		(
			infoDate DATETIME PRIMARY KEY CLUSTERED,
			weekdayName VARCHAR(9) NOT NULL,
			statusCode INT NOT NULL,
			lastDay TINYINT DEFAULT 0
		)

WHILE @tempStart <= @tempEnd
	BEGIN
		INSERT	@dayInformation
			(
				infoDate,
				weekdayName,
				statusCode
			)
		SELECT	@tempStart,
			DATENAME(WEEKDAY, @tempStart),
			CASE
				WHEN DATEPART(DAY, @tempStart) BETWEEN 1 AND 7 THEN 1
				WHEN DATEPART(DAY, @tempStart) BETWEEN 8 AND 14 THEN 2
				WHEN DATEPART(DAY, @tempStart) BETWEEN 15 AND 21 THEN 4
				WHEN DATEPART(DAY, @tempStart) BETWEEN 22 AND 28 THEN 8
				ELSE 0
			END

		SET	@tempStart = DATEADD(DAY, 1, @tempStart)
	END

UPDATE		di
SET		di.statusCode = di.statusCode + 16
FROM		@dayInformation AS di
INNER JOIN	(
			SELECT		DATEDIFF(MONTH, ''19000101'', infoDate) AS theMonth,
					DATEPART(DAY, MAX(infoDate)) - 6 AS theDay
			FROM		@dayInformation
			GROUP BY	DATEDIFF(MONTH, ''19000101'', infoDate)
		) AS x ON x.theMonth = DATEDIFF(MONTH, ''19000101'', di.infoDate)
WHERE		DATEPART(DAY, di.infoDate) >= x.theDay

UPDATE		di
SET		di.lastDay = 16
FROM		@dayInformation AS di
INNER JOIN	(
			SELECT		DATEDIFF(MONTH, ''19000101'', infoDate) AS theMonth,
					MAX(infoDate) AS theDay
			FROM		@dayInformation
			GROUP BY	DATEDIFF(MONTH, ''19000101'', infoDate)
		) AS x ON x.theMonth = DATEDIFF(MONTH, ''19000101'', di.infoDate)
WHERE		di.infoDate = x.theDay

UPDATE	@dayInformation
SET	lastDay = DATEPART(DAY, infoDate)
WHERE	DATEPART(DAY, infoDate) BETWEEN 1 AND 4

-- Stage all individual schedule times
DECLARE	@scheduleTimes TABLE
		(
			rowID INT NOT NULL,
			infoDate DATETIME NOT NULL,
			startTime DATETIME NOT NULL,
			endTime DATETIME NOT NULL,
			waitSeconds INT DEFAULT 0
		)


-- Insert one time only schedules
INSERT	@scheduleTimes
	(
		rowID,
		infoDate,
		startTime,
		endTime
	)
SELECT	rowID,
	startDate,
	startTime,
	endTime
FROM	@jobSchedules
WHERE	freq_type = 1
	AND startDate >= @StartDate
	AND startDate <= @EndDate

-- Insert daily schedules
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		js.rowID,
		di.infoDate,
		js.startTime,
		js.endTime,
		CASE js.freq_subday_type
			WHEN 1 THEN 0
			WHEN 2 THEN js.freq_subday_interval
			WHEN 4 THEN 60 * js.freq_subday_interval
			WHEN 8 THEN 3600 * js.freq_subday_interval
		END
FROM		@jobSchedules AS js
INNER JOIN	@dayInformation AS di ON di.infoDate >= @startDate
			AND di.infoDate <= @endDate
WHERE		js.freq_type = 4
		AND DATEDIFF(DAY, js.startDate, di.infoDate) % js.freq_interval = 0

-- Insert weekly schedules
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		js.rowID,
		di.infoDate,
		js.startTime,
		js.endTime,
		CASE js.freq_subday_type
			WHEN 1 THEN 0
			WHEN 2 THEN js.freq_subday_interval
			WHEN 4 THEN 60 * js.freq_subday_interval
			WHEN 8 THEN 3600 * js.freq_subday_interval
		END
FROM		@jobSchedules AS js
INNER JOIN	@dayInformation AS di ON di.infoDate >= @startDate
			AND di.infoDate <= @endDate
WHERE		js.freq_type = 8
		AND 1 =	CASE
				WHEN js.freq_interval & 1 = 1 AND di.weekdayName = ''Sunday'' THEN 1
				WHEN js.freq_interval & 2 = 2 AND di.weekdayName = ''Monday'' THEN 1
				WHEN js.freq_interval & 4 = 4 AND di.weekdayName = ''Tuesday'' THEN 1
				WHEN js.freq_interval & 8 = 8 AND di.weekdayName = ''Wednesday'' THEN 1
				WHEN js.freq_interval & 16 = 16 AND di.weekdayName = ''Thursday'' THEN 1
				WHEN js.freq_interval & 32 = 32 AND di.weekdayName = ''Friday'' THEN 1
				WHEN js.freq_interval & 64 = 64 AND di.weekdayName = ''Saturday'' THEN 1
				ELSE 0
			END
		AND (DATEDIFF(DAY, js.startDate, di.infoDate) / 7) % js.freq_recurrence_factor = 0

-- Insert monthly schedules
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		js.rowID,
		di.infoDate,
		js.startTime,
		js.endTime,
		CASE js.freq_subday_type
			WHEN 1 THEN 0
			WHEN 2 THEN js.freq_subday_interval
			WHEN 4 THEN 60 * js.freq_subday_interval
			WHEN 8 THEN 3600 * js.freq_subday_interval
		END
FROM		@jobSchedules AS js
INNER JOIN	@dayInformation AS di ON di.infoDate >= @startDate
			AND di.infoDate <= @endDate
WHERE		js.freq_type = 16
		AND DATEPART(DAY, di.infoDate) = js.freq_interval
		AND DATEDIFF(MONTH, js.startDate, di.infoDate) % js.freq_recurrence_factor = 0

-- Insert monthly relative schedules
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		js.rowID,
		di.infoDate,
		js.startTime,
		js.endTime,
		CASE js.freq_subday_type
			WHEN 1 THEN 0
			WHEN 2 THEN js.freq_subday_interval
			WHEN 4 THEN 60 * js.freq_subday_interval
			WHEN 8 THEN 3600 * js.freq_subday_interval
		END
FROM		@jobSchedules AS js
INNER JOIN	@dayInformation AS di ON di.infoDate >= @startDate
			AND di.infoDate <= @endDate
WHERE		js.freq_type = 32
		AND 1 =	CASE
				WHEN js.freq_interval = 1 AND di.weekdayName = ''Sunday'' THEN 1
				WHEN js.freq_interval = 2 AND di.weekdayName = ''Monday'' THEN 1
				WHEN js.freq_interval = 3 AND di.weekdayName = ''Tuesday'' THEN 1
				WHEN js.freq_interval = 4 AND di.weekdayName = ''Wednesday'' THEN 1
				WHEN js.freq_interval = 5 AND di.weekdayName = ''Thursday'' THEN 1
				WHEN js.freq_interval = 6 AND di.weekdayName = ''Friday'' THEN 1
				WHEN js.freq_interval = 7 AND di.weekdayName = ''Saturday'' THEN 1
				WHEN js.freq_interval = 8 AND js.freq_relative_interval = di.lastDay THEN 1
				WHEN js.freq_interval = 9 AND di.weekdayName NOT IN (''Sunday'', ''Saturday'') THEN 1
				WHEN js.freq_interval = 10 AND di.weekdayName IN (''Sunday'', ''Saturday'') THEN 1
				ELSE 0
			END
		AND di.statusCode & js.freq_relative_interval = js.freq_relative_interval
		AND DATEDIFF(MONTH, js.startDate, di.infoDate) % js.freq_recurrence_factor = 0

-- Get the daily recurring schedule times
INSERT		@scheduleTimes
		(
			rowID,
			infoDate,
			startTime,
			endTime,
			waitSeconds
		)
SELECT		st.rowID,
		st.infoDate,
		DATEADD(SECOND, tn.num * st.waitSeconds, st.startTime),
		st.endTime,
		st.waitSeconds
FROM		@scheduleTimes AS st
CROSS JOIN	@tallyNumbers AS tn
WHERE		tn.num * st.waitSeconds <= DATEDIFF(SECOND, st.startTime, st.endTime)
		AND st.waitSeconds > 0

-- Present the result
INSERT @t (scheduleID,
		serverName,
		jobName,
		jobDescription,
		scheduleName,
		categoryName,
		infoDate,
		startTime,
		endTime,
		jobEnabled,
		scheduleEnabled)
SELECT		js.scheduleID,
		js.serverName,
		js.jobName,
		js.jobDescription,
		js.scheduleName,
		js.categoryName,
		st.infoDate,
		st.startTime,
		st.endTime,
		js.jobEnabled,
		js.scheduleEnabled
FROM		@scheduleTimes AS st
INNER JOIN	@jobSchedules AS js ON js.rowID = st.rowID
WHERE		js.jobEnabled = 1
		AND js.scheduleEnabled = 1

RETURN

END' 
END

GO
/****** Object:  Table [dbo].[JobCategories]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobCategories]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[JobCategories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_class] [int] NOT NULL,
	[category_type] [tinyint] NOT NULL,
	[name] [sysname] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[JobHistory]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobHistory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[JobHistory](
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
	[retries_attempted] [int] NOT NULL,
	[server] [sysname] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Jobs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Jobs](
	[job_id] [uniqueidentifier] NOT NULL,
	[name] [sysname] NOT NULL,
	[enabled] [tinyint] NOT NULL,
	[description] [nvarchar](512) NULL,
	[start_step_id] [int] NOT NULL,
	[category_id] [int] NOT NULL,
	[owner_sid] [varbinary](85) NOT NULL,
	[delete_level] [int] NOT NULL,
	[date_created] [datetime] NOT NULL,
	[date_modified] [datetime] NOT NULL,
	[version_number] [int] NOT NULL,
 CONSTRAINT [PK_sysjobs] PRIMARY KEY CLUSTERED 
(
	[job_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobSchedules]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobSchedules]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[JobSchedules](
	[schedule_id] [int] NULL,
	[job_id] [uniqueidentifier] NULL,
	[next_run_date] [int] NOT NULL DEFAULT ((0)),
	[next_run_time] [int] NOT NULL DEFAULT ((0))
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[JobSteps]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobSteps]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[JobSteps](
	[job_id] [uniqueidentifier] NOT NULL,
	[step_id] [int] NOT NULL,
	[step_name] [sysname] NOT NULL,
	[subsystem] [nvarchar](40) NOT NULL,
	[command] [nvarchar](max) NULL,
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
	[output_file_name] [nvarchar](200) NULL,
	[last_run_outcome] [int] NOT NULL,
	[last_run_duration] [int] NOT NULL,
	[last_run_retries] [int] NOT NULL,
	[last_run_date] [int] NOT NULL,
	[last_run_time] [int] NOT NULL,
	[step_uid] [uniqueidentifier] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schedules]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Schedules](
	[schedule_id] [int] IDENTITY(1,1) NOT NULL,
	[schedule_uid] [uniqueidentifier] NOT NULL,
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Jobs_View]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Jobs_View]'))
EXEC dbo.sp_executesql @statement = N'-- Alter View Jobs_View
-- Alter View sysjobs_view

/* filter out local jobs  

WHERE        (jobs.owner_sid = SUSER_SID()) OR
                         (ISNULL(IS_SRVROLEMEMBER(N''sysadmin''), 0) = 1) OR
                         (ISNULL(IS_MEMBER(N''SQLAgentReaderRole''), 0) = 1) OR
                         (ISNULL(IS_MEMBER(N''TargetServersRole''), 0) = 1) AND EXISTS
                             (SELECT        job_id, server_id, last_run_outcome, last_outcome_message, last_run_date, last_run_time, last_run_duration
                               FROM            dbo.sysjobservers AS js
                               WHERE        (server_id <> 0) AND (job_id = jobs.job_id))
*/
CREATE VIEW [dbo].[Jobs_View]
AS
SELECT        jobs.job_id, jobs.name, jobs.enabled, jobs.description, jobs.start_step_id, jobs.category_id, jobs.owner_sid,
                         jobs.delete_level, jobs.date_created, jobs.date_modified, jobs.version_number
FROM            dbo.Jobs AS jobs
' 
GO
SET IDENTITY_INSERT [dbo].[JobCategories] ON 

GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (0, 1, 1, N'[Uncategorized (Local)]')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (2, 1, 2, N'[Uncategorized (Multi-Server)]')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (98, 2, 3, N'[Uncategorized]')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (99, 3, 3, N'[Uncategorized]')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (8, 1, 1, N'Data Collector')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (7, 1, 1, N'Database Engine Tuning Advisor')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (3, 1, 1, N'Database Maintenance')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (5, 1, 1, N'Full-Text')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (1, 1, 1, N'Jobs from MSX')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (6, 1, 1, N'Log Shipping')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (18, 1, 1, N'REPL-Alert Response')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (16, 1, 1, N'REPL-Checkup')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (10, 1, 1, N'REPL-Distribution')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (11, 1, 1, N'REPL-Distribution Cleanup')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (12, 1, 1, N'REPL-History Cleanup')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (20, 2, 3, N'Replication')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (13, 1, 1, N'REPL-LogReader')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (14, 1, 1, N'REPL-Merge')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (19, 1, 1, N'REPL-QueueReader')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (15, 1, 1, N'REPL-Snapshot')
GO
INSERT [dbo].[JobCategories] ([category_id], [category_class], [category_type], [name]) VALUES (17, 1, 1, N'REPL-Subscription Cleanup')
GO
SET IDENTITY_INSERT [dbo].[JobCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[JobHistory] ON 

GO
INSERT [dbo].[JobHistory] ([instance_id], [job_id], [step_id], [step_name], [sql_message_id], [sql_severity], [message], [run_status], [run_date], [run_time], [run_duration], [retries_attempted], [server]) VALUES (1, N'301f33fd-a102-4f63-a4e9-7bc2be168b24', 1, N'Generate_SummaryReport_And_Email', 0, 0, N'Executed as user: YOGEESHA\Yogi. The step succeeded.', 1, 20200622, 172445, 0, 0, N'YOGEESHA')
GO
INSERT [dbo].[JobHistory] ([instance_id], [job_id], [step_id], [step_name], [sql_message_id], [sql_severity], [message], [run_status], [run_date], [run_time], [run_duration], [retries_attempted], [server]) VALUES (2, N'301f33fd-a102-4f63-a4e9-7bc2be168b24', 2, N'Generate_DetailedReport_And_Email', 0, 0, N'Executed as user: YOGEESHA\Yogi. The step succeeded.', 1, 20200622, 172445, 0, 0, N'YOGEESHA')
GO
INSERT [dbo].[JobHistory] ([instance_id], [job_id], [step_id], [step_name], [sql_message_id], [sql_severity], [message], [run_status], [run_date], [run_time], [run_duration], [retries_attempted], [server]) VALUES (1002, N'301f33fd-a102-4f63-a4e9-7bc2be168b24', 1, N'Generate_SummaryReport_And_Email', 0, 0, N'Executed as user: YOGEESHA\Yogi. The step succeeded.', 1, 20200625, 161018, 0, 0, N'YOGEESHA')
GO
SET IDENTITY_INSERT [dbo].[JobHistory] OFF
GO
INSERT [dbo].[Jobs] ([job_id], [name], [enabled], [description], [start_step_id], [category_id], [owner_sid], [delete_level], [date_created], [date_modified], [version_number]) VALUES (N'301f33fd-a102-4f63-a4e9-7bc2be168b24', N'Email_ShortfallSummary_Report', 1, N'Genrate shortfall summary report and email to the receipients', 1, 0, 0x0105000000000005150000006A427F5AEEEC7EF00F3C03ACE9030000, 0, CAST(N'2020-06-22 17:02:29.423' AS DateTime), CAST(N'2020-06-22 17:02:29.427' AS DateTime), 4)
GO
INSERT [dbo].[Jobs] ([job_id], [name], [enabled], [description], [start_step_id], [category_id], [owner_sid], [delete_level], [date_created], [date_modified], [version_number]) VALUES (N'594e06c4-936e-433e-8f9b-df6eee9c49e9', N'AuditReport', 1, N'No description available.', 1, 0, 0x0105000000000005150000006A427F5AEEEC7EF00F3C03ACE9030000, 0, CAST(N'2020-06-26 09:21:07.460' AS DateTime), CAST(N'2020-06-26 09:21:07.527' AS DateTime), 3)
GO
INSERT [dbo].[JobSchedules] ([schedule_id], [job_id], [next_run_date], [next_run_time]) VALUES (1, N'301f33fd-a102-4f63-a4e9-7bc2be168b24', 20200622, 233000)
GO
INSERT [dbo].[JobSchedules] ([schedule_id], [job_id], [next_run_date], [next_run_time]) VALUES (2, N'301f33fd-a102-4f63-a4e9-7bc2be168b24', 20200622, 180000)
GO
INSERT [dbo].[JobSchedules] ([schedule_id], [job_id], [next_run_date], [next_run_time]) VALUES (3, N'301f33fd-a102-4f63-a4e9-7bc2be168b24', 20200622, 110000)
GO
INSERT [dbo].[JobSchedules] ([schedule_id], [job_id], [next_run_date], [next_run_time]) VALUES (4, N'301f33fd-a102-4f63-a4e9-7bc2be168b24', 20200630, 90000)
GO
INSERT [dbo].[JobSchedules] ([schedule_id], [job_id], [next_run_date], [next_run_time]) VALUES (2, N'594e06c4-936e-433e-8f9b-df6eee9c49e9', 20200626, 100000)
GO
INSERT [dbo].[JobSteps] ([job_id], [step_id], [step_name], [subsystem], [command], [additional_parameters], [cmdexec_success_code], [on_success_action], [on_success_step_id], [on_fail_action], [on_fail_step_id], [server], [database_name], [database_user_name], [retry_attempts], [retry_interval], [output_file_name], [last_run_outcome], [last_run_duration], [last_run_retries], [last_run_date], [last_run_time], [step_uid]) VALUES (N'301f33fd-a102-4f63-a4e9-7bc2be168b24', 1, N'Generate_SummaryReport_And_Email', N'TSQL', N'SELECT GETDATE() AS [ReportDate], ''Summary'' AS [Report Type]', N'
{
  "Email": {
    "To": "naik.yogeesha@gmail.com;naik.yogeesha@outlook.com;",
	"Cc": "yogishdj@live.com",
	"Bcc": "yogishdj@gmail.com",
	"Subject": "Test Email",
	"Body": "Hi,
	This is to test report scheduler console app.

	Thanks,
	Report Scheduler"
  }
}', 0, 3, 0, 2, 0, NULL, N'master', NULL, 1, 1, NULL, 1, 0, 0, 20200625, 161018, N'0cb31584-fad6-4e81-ba00-2de222a3f703')
GO
INSERT [dbo].[JobSteps] ([job_id], [step_id], [step_name], [subsystem], [command], [additional_parameters], [cmdexec_success_code], [on_success_action], [on_success_step_id], [on_fail_action], [on_fail_step_id], [server], [database_name], [database_user_name], [retry_attempts], [retry_interval], [output_file_name], [last_run_outcome], [last_run_duration], [last_run_retries], [last_run_date], [last_run_time], [step_uid]) VALUES (N'301f33fd-a102-4f63-a4e9-7bc2be168b24', 2, N'Generate_DetailedReport_And_Email', N'TSQL', N'SELECT GETDATE() AS [ReportDate], ''Detailed'' AS [Report Type]', N'
{
  "Email": {
    "To": "naik.yogeesha@gmail.com;naik.yogeesha@outlook.com;",
	"Cc": "yogishdj@live.com",
	"Bcc": "yogishdj@gmail.com",
	"Subject": "Test Email",
	"Body": "Hi,
	This is to test report scheduler console app.

	Thanks,
	Report Scheduler"
  }
}', 0, 1, 0, 2, 0, NULL, N'master', NULL, 1, 1, NULL, 1, 0, 0, 20200622, 172445, N'529a114f-ed36-471a-99a9-38b91ef7a603')
GO
INSERT [dbo].[JobSteps] ([job_id], [step_id], [step_name], [subsystem], [command], [additional_parameters], [cmdexec_success_code], [on_success_action], [on_success_step_id], [on_fail_action], [on_fail_step_id], [server], [database_name], [database_user_name], [retry_attempts], [retry_interval], [output_file_name], [last_run_outcome], [last_run_duration], [last_run_retries], [last_run_date], [last_run_time], [step_uid]) VALUES (N'594e06c4-936e-433e-8f9b-df6eee9c49e9', 1, N'Current Day Audit', N'TSQL', N'SELECT GETDATE()', NULL, 0, 1, 0, 2, 0, NULL, N'master', NULL, 0, 0, NULL, 0, 0, 0, 0, 0, N'ce840dc2-6be2-41e1-b61a-3eb444d444eb')
GO
SET IDENTITY_INSERT [dbo].[Schedules] ON 

GO
INSERT [dbo].[Schedules] ([schedule_id], [schedule_uid], [name], [owner_sid], [enabled], [freq_type], [freq_interval], [freq_subday_type], [freq_subday_interval], [freq_relative_interval], [freq_recurrence_factor], [active_start_date], [active_end_date], [active_start_time], [active_end_time], [date_created], [date_modified], [version_number]) VALUES (1, N'b76d0fa3-b82a-4433-8ccd-47ae24c8e318', N'Daily Once', 0x0105000000000005150000006A427F5AEEEC7EF00F3C03ACE9030000, 1, 4, 1, 1, 0, 0, 0, 20200620, 99991231, 233000, 235959, CAST(N'2020-06-22 17:02:29.430' AS DateTime), CAST(N'2020-06-22 17:02:29.430' AS DateTime), 1)
GO
INSERT [dbo].[Schedules] ([schedule_id], [schedule_uid], [name], [owner_sid], [enabled], [freq_type], [freq_interval], [freq_subday_type], [freq_subday_interval], [freq_relative_interval], [freq_recurrence_factor], [active_start_date], [active_end_date], [active_start_time], [active_end_time], [date_created], [date_modified], [version_number]) VALUES (2, N'a3e178f4-6177-49eb-b72d-0fdac970bfa3', N'Every One Hour', 0x0105000000000005150000006A427F5AEEEC7EF00F3C03ACE9030000, 1, 4, 1, 8, 1, 0, 0, 20200620, 99991231, 0, 235959, CAST(N'2020-06-22 17:02:30.173' AS DateTime), CAST(N'2020-06-22 17:02:30.173' AS DateTime), 1)
GO
INSERT [dbo].[Schedules] ([schedule_id], [schedule_uid], [name], [owner_sid], [enabled], [freq_type], [freq_interval], [freq_subday_type], [freq_subday_interval], [freq_relative_interval], [freq_recurrence_factor], [active_start_date], [active_end_date], [active_start_time], [active_end_time], [date_created], [date_modified], [version_number]) VALUES (3, N'631b3284-8cff-4234-a40e-00a2a098fac8', N'Every_Friday', 0x0105000000000005150000006A427F5AEEEC7EF00F3C03ACE9030000, 1, 8, 32, 1, 0, 0, 1, 20200611, 99991231, 110000, 235959, CAST(N'2020-06-22 17:02:32.290' AS DateTime), CAST(N'2020-06-22 17:02:32.290' AS DateTime), 1)
GO
INSERT [dbo].[Schedules] ([schedule_id], [schedule_uid], [name], [owner_sid], [enabled], [freq_type], [freq_interval], [freq_subday_type], [freq_subday_interval], [freq_relative_interval], [freq_recurrence_factor], [active_start_date], [active_end_date], [active_start_time], [active_end_time], [date_created], [date_modified], [version_number]) VALUES (4, N'a8b7b3d8-ee01-4d19-a2d2-630908ce9923', N'Monthly_Dynamic', 0x0105000000000005150000006A427F5AEEEC7EF00F3C03ACE9030000, 1, 32, 8, 1, 0, 16, 1, 20200620, 99991231, 90000, 235959, CAST(N'2020-06-22 17:02:32.527' AS DateTime), CAST(N'2020-06-22 17:02:32.527' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Schedules] OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_add_job]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_job]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_add_job] AS' 
END
GO
-- Alter Procedure usp_add_job
-- Alter Procedure usp_add_job
-- Alter Procedure usp_add_job
-- Alter Procedure sp_add_job
ALTER PROCEDURE [dbo].[usp_add_job]
  @job_name                     sysname,
  @enabled                      TINYINT          = 1,        -- 0 = Disabled, 1 = Enabled
  @description                  NVARCHAR(512)    = NULL,
  @start_step_id                INT              = 1,
  @category_name                sysname          = NULL,
  @category_id                  INT              = NULL,     -- A language-independent way to specify which category to use
  @owner_login_name             sysname          = NULL,     -- The procedure assigns a default
  @delete_level                 INT              = 0,        -- 0 = Never, 1 = On Success, 2 = On Failure, 3 = Always
  @job_id                       UNIQUEIDENTIFIER = NULL OUTPUT
AS
BEGIN
  DECLARE @retval                     INT
  DECLARE @owner_sid                  VARBINARY(85)

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters (except @owner_login_name)
  SELECT @job_name                     = LTRIM(RTRIM(@job_name))
  SELECT @description                  = LTRIM(RTRIM(@description))
  SELECT @category_name                = LTRIM(RTRIM(@category_name))

  -- Turn [nullable] empty string parameters into NULLs
  IF (@description                  = N'') SELECT @description                  = NULL
  IF (@category_name                = N'') SELECT @category_name                = NULL

  --only members of sysadmins role can set the owner
  --IF (@owner_login_name IS NOT NULL AND ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 0) AND (@owner_login_name <> SUSER_SNAME())
  --BEGIN
  --  RAISERROR(14515, -1, -1)
  --  RETURN(1) -- Failure
  --END
    
  -- Default the owner (if not supplied or if a non-sa is [illegally] trying to create a job for another user)
  -- allow special account only when caller is sysadmin
  IF (@owner_login_name = N'$(SQLAgentAccount)')  AND 
     (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1)
  BEGIN
    SELECT @owner_sid = 0xFFFFFFFF   
  END
  ELSE 
  IF (@owner_login_name IS NULL) OR ((ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 0) AND (@owner_login_name <> SUSER_SNAME()))
  BEGIN
    SELECT @owner_sid = SUSER_SID()
  END
  ELSE
  BEGIN
    --force case insensitive comparation for NT users
    SELECT @owner_sid = SUSER_SID(@owner_login_name, 0) -- If @owner_login_name is invalid then SUSER_SID() will return NULL
  END

  -- Default the description (if not supplied)
  IF (@description IS NULL)
    SELECT @description = FORMATMESSAGE(14571)

  -- If a category ID is provided this overrides any supplied category name
  EXECUTE @retval = dbo.usp_verify_category_identifiers '@category_name',
                                                   '@category_id',
                                                    @category_name OUTPUT,
                                                    @category_id   OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Check parameters
  EXECUTE @retval = dbo.usp_verify_job NULL,  --  The job id is null since this is a new job
                                  @job_name,
                                  @enabled,
                                  @start_step_id,
                                  @category_name,
                                  @owner_sid                  OUTPUT,
                                  @delete_level,
                                  @category_id                OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure
    
  IF (@job_id IS NULL)
  BEGIN
    -- Assign the GUID
    SELECT @job_id = NEWID()
  END
  ELSE
  BEGIN
    -- A job ID has been provided, so check that the caller is SQLServerAgent (inserting an MSX job)
    IF (PROGRAM_NAME() NOT LIKE N'SQLAgent%')
    BEGIN
      RAISERROR(14274, -1, -1)
      RETURN(1) -- Failure
    END
  END

  INSERT INTO dbo.Jobs
         (job_id,
          name,
          enabled,
          description,
          start_step_id,
          category_id,
          owner_sid,
          delete_level,
          date_created,
          date_modified,
          version_number)
  VALUES  (@job_id,
          @job_name,
          @enabled,
          @description,
          @start_step_id,
          @category_id,
          @owner_sid,
          @delete_level,
          GETDATE(),
          GETDATE(),
          1) -- Version number 1
  SELECT @retval = @@error

  -- NOTE: We don't notify SQLServerAgent to update it's cache (we'll do this in sp_add_jobserver)

  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_add_jobschedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_jobschedule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_add_jobschedule] AS' 
END
GO
-- Create Procedure usp_add_jobschedule
-- Create Procedure usp_add_jobschedule
-- Create Procedure usp_add_jobschedule
-- Alter Procedure usp_add_jobschedule
ALTER PROCEDURE [dbo].[usp_add_jobschedule]                 
  @job_id                 UNIQUEIDENTIFIER = NULL,
  @job_name               sysname          = NULL,
  @name                   sysname,
  @enabled                TINYINT          = 1,
  @freq_type              INT              = 1,
  @freq_interval          INT              = 0,
  @freq_subday_type       INT              = 0,
  @freq_subday_interval   INT              = 0,
  @freq_relative_interval INT              = 0,
  @freq_recurrence_factor INT              = 0,
  @active_start_date      INT              = NULL,     -- sp_verify_schedule assigns a default
  @active_end_date        INT              = 99991231, -- December 31st 9999
  @active_start_time      INT              = 000000,   -- 12:00:00 am
  @active_end_time        INT              = 235959,    -- 11:59:59 pm
  @schedule_id            INT              = NULL  OUTPUT,
  @automatic_post         BIT              = 1,         -- If 1 will post notifications to all tsx servers to that run this job
  @schedule_uid           UNIQUEIDENTIFIER = NULL OUTPUT
AS
BEGIN
  DECLARE @retval           INT
  DECLARE @owner_login_name sysname

  SET NOCOUNT ON

  -- Check that we can uniquely identify the job
  EXECUTE @retval = dbo.usp_verify_job_identifiers '@job_name',
                                              '@job_id',
                                               @job_name OUTPUT,
                                               @job_id   OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure


  -- Add the schedule first
  EXECUTE @retval = dbo.usp_add_schedule @schedule_name          = @name,
                                             @enabled                = @enabled,
                                             @freq_type              = @freq_type,
                                             @freq_interval          = @freq_interval,
                                             @freq_subday_type       = @freq_subday_type,
                                             @freq_subday_interval   = @freq_subday_interval,
                                             @freq_relative_interval = @freq_relative_interval,
                                             @freq_recurrence_factor = @freq_recurrence_factor,
                                             @active_start_date      = @active_start_date,
                                             @active_end_date        = @active_end_date,
                                             @active_start_time      = @active_start_time,
                                             @active_end_time        = @active_end_time,
                                             @owner_login_name       = @owner_login_name,
                                             @schedule_uid           = @schedule_uid OUTPUT,
                                             @schedule_id            = @schedule_id  OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure
 
 
  EXECUTE @retval = dbo.usp_attach_schedule @job_id           = @job_id, 
                                                @job_name         = NULL,
                                                @schedule_id      = @schedule_id,
                                                @schedule_name    = NULL,
                                                @automatic_post   = @automatic_post
  IF (@retval <> 0)
    RETURN(1) -- Failure
    
    

  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_add_jobstep]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_jobstep]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_add_jobstep] AS' 
END
GO
-- Create Procedure usp_add_jobstep
-- Alter Procedure usp_add_jobstep
ALTER PROCEDURE [dbo].[usp_add_jobstep]
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
  @output_file_name      NVARCHAR(200)    = NULL, 
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

  EXECUTE @retval = dbo.usp_add_jobstep_internal @job_id = @job_id,
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
                                                @output_file_name = @output_file_name,
                                                            @step_uid = @step_uid OUTPUT


  RETURN(@retval)
END

GO
/****** Object:  StoredProcedure [dbo].[usp_add_jobstep_internal]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_jobstep_internal]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_add_jobstep_internal] AS' 
END
GO
-- Alter Procedure usp_add_jobstep_internal
-- Alter Procedure usp_add_jobstep_internal
-- Alter Procedure usp_add_jobstep_internal
-- Alter Procedure sp_add_jobstep_internal
-- Alter Procedure sp_add_jobstep_internal
ALTER PROCEDURE [dbo].[usp_add_jobstep_internal]
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
  @output_file_name      NVARCHAR(200)    = NULL,
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

  -- Turn [nullable] empty string parameters into NULLs
  IF (@server             = N'') SELECT @server             = NULL
  IF (@database_name      = N'') SELECT @database_name      = NULL
  IF (@database_user_name = N'') SELECT @database_user_name = NULL
  IF (@output_file_name   = N'') SELECT @output_file_name   = NULL

  EXECUTE @retval = dbo.usp_verify_job_identifiers '@job_name',
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
  

  -- Default step id (if not supplied)
  IF (@step_id IS NULL)
  BEGIN
    SELECT @step_id = ISNULL(MAX(step_id), 0) + 1
    FROM dbo.JobSteps
    WHERE (job_id = @job_id)
  END

  -- Check parameters
  EXECUTE @retval = dbo.usp_verify_jobstep @job_id,
                                      @step_id,
                                      @step_name,
                                      @subsystem,
                                      @command,
                                      @server,
                                      @on_success_action,
                                      @on_success_step_id,
                                      @on_fail_action,
                                      @on_fail_step_id,
                                      @database_name      OUTPUT,
                                      @database_user_name OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Get current maximum step id
  SELECT @max_step_id = ISNULL(MAX(step_id), 0)
  FROM dbo.JobSteps
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
    UPDATE dbo.Jobs
    SET version_number = version_number + 1,
        date_modified = GETDATE()
    WHERE (job_id = @job_id)

    -- Adjust step id's (unless the new step is being inserted at the 'end')
    -- NOTE: We MUST do this before inserting the step.
    IF (@step_id <= @max_step_id)
    BEGIN
      UPDATE dbo.JobSteps
      SET step_id = step_id + 1
      WHERE (step_id >= @step_id)
        AND (job_id = @job_id)

      -- Clean up OnSuccess/OnFail references
      UPDATE dbo.JobSteps
      SET on_success_step_id = on_success_step_id + 1
      WHERE (on_success_step_id >= @step_id)
        AND (job_id = @job_id)

      UPDATE dbo.JobSteps
      SET on_fail_step_id = on_fail_step_id + 1
      WHERE (on_fail_step_id >= @step_id)
        AND (job_id = @job_id)

      UPDATE dbo.JobSteps
      SET on_success_step_id = 0,
          on_success_action = 1  -- Quit With Success
      WHERE (on_success_step_id = @step_id)
        AND (job_id = @job_id)

      UPDATE dbo.JobSteps
      SET on_fail_step_id = 0,
          on_fail_action = 2     -- Quit With Failure
      WHERE (on_fail_step_id = @step_id)
        AND (job_id = @job_id)
    END

    SELECT @step_uid = NEWID()

    -- Insert the step
    INSERT INTO dbo.JobSteps
           (job_id,
            step_id,
            step_name,
            subsystem,
            command,
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
            output_file_name,
            last_run_outcome,
            last_run_duration,
            last_run_retries,
            last_run_date,
            last_run_time,
         step_uid)
    VALUES (@job_id,
            @step_id,
            @step_name,
            @subsystem,
            @command,
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
            @output_file_name,
            0,
            0,
            0,
            0,
            0,
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

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_add_schedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_add_schedule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_add_schedule] AS' 
END
GO
-- Alter Procedure usp_add_schedule
-- Alter Procedure usp_add_schedule
-- Alter Procedure sp_add_schedule

ALTER PROCEDURE [dbo].[usp_add_schedule]
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
  @schedule_id              INT             = NULL  OUTPUT
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
  EXECUTE @retval = dbo.usp_verify_schedule NULL,   -- schedule_id does not exist for the new schedule
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
    FROM dbo.Schedules
    WHERE schedule_uid = @schedule_uid

   IF((@schedule_id IS NOT NULL) AND (@schedule_id <> 0))
   BEGIN
      --If found update the fields
      UPDATE dbo.Schedules
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
  INSERT INTO dbo.Schedules
         (schedule_uid,
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
/****** Object:  StoredProcedure [dbo].[usp_attach_schedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_attach_schedule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_attach_schedule] AS' 
END
GO
-- Create Procedure usp_attach_schedule
-- Create Procedure usp_attach_schedule
-- Alter Procedure usp_attach_schedule
-- Create Procedure sp_attach_schedule

ALTER PROCEDURE [dbo].[usp_attach_schedule]
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
	DECLARE @next_run_date int
	DECLARE @next_run_time int
  
  SET NOCOUNT ON

  -- Check that we can uniquely identify the job
  EXECUTE @retval = dbo.usp_verify_job_identifiers '@job_name',
                                                       '@job_id',
                                                        @job_name                   OUTPUT,
                                                        @job_id                     OUTPUT,
                                                        @owner_sid = @job_owner_sid OUTPUT
    IF (@retval <> 0)
        RETURN(1) -- Failure
        
  -- Check that we can uniquely identify the schedule
  EXECUTE @retval = dbo.usp_verify_schedule_identifiers @name_of_name_parameter = '@schedule_name',
                                                            @name_of_id_parameter   = '@schedule_id',
                                                            @schedule_name          = @schedule_name    OUTPUT,
                                                            @schedule_id            = @schedule_id      OUTPUT,
                                                            @owner_sid              = @sched_owner_sid  OUTPUT
  IF (@retval <> 0)
      RETURN(1) -- Failure     

  -- If the record doesn't already exist create it
  IF( NOT EXISTS(SELECT *  
                 FROM dbo.JobSchedules
                 WHERE (schedule_id = @schedule_id)
                   AND (job_id = @job_id)) )
  BEGIN
	SELECT 
		@next_run_date = [dbo].[fn_DateToInt](infoDate),
		@next_run_time = [dbo].[fn_TimeToInt](infoDate)
		FROM [dbo].[udfGetNextSchedule] (@schedule_id)

	--DECLARE @message varchar(2000) = FORMATMESSAGE('Invalid time %i. Length should be 6 characters long.',@next_run_time)
	--SELECT @message
	--IF LEN(@next_run_time) < 6
	--	RAISERROR(@message,16,1)

    INSERT INTO dbo.JobSchedules (schedule_id, job_id, next_run_date, next_run_time)
    SELECT @schedule_id, @job_id, @next_run_date, @next_run_time

    SELECT @retval = @@ERROR

  END
  
  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_delete_schedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_delete_schedule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_delete_schedule] AS' 
END
GO
-- Create Procedure usp_delete_schedule
-- Alter Procedure usp_delete_schedule
-- Create Procedure sp_delete_schedule
-- Create Procedure sp_delete_schedule

ALTER PROCEDURE [dbo].[usp_delete_schedule]
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
  EXECUTE @retval = dbo.usp_verify_schedule_identifiers @name_of_name_parameter = '@schedule_name',
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
  FROM dbo.JobSchedules 
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
  FROM dbo.JobSchedules AS jsched 
   JOIN dbo.sysjobservers AS jsvr
      ON jsched.job_id = jsvr.job_id
  WHERE (jsched.schedule_id = @schedule_id)

  --OK to delete the job - schedule link
  DELETE dbo.JobSchedules 
  WHERE schedule_id = @schedule_id

  --OK to delete the schedule 
  DELETE dbo.Schedules 
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
/****** Object:  StoredProcedure [dbo].[usp_detach_schedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_detach_schedule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_detach_schedule] AS' 
END
GO
-- Create Procedure usp_detach_schedule
-- Create Procedure usp_detach_schedule
-- Alter Procedure usp_detach_schedule
-- Create Procedure sp_detach_schedule
-- Create Procedure sp_detach_schedule
-- Alter Procedure sp_detach_schedule

ALTER PROCEDURE [dbo].[usp_detach_schedule]
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
  EXECUTE @retval = dbo.usp_verify_job_identifiers '@job_name',
                                                       '@job_id',
                                                        @job_name OUTPUT,
                                                        @job_id   OUTPUT,
                                                        @owner_sid = @job_owner_sid OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure

        
  -- Check that we can uniquely identify the schedule
  EXECUTE @retval = dbo.usp_verify_schedule_identifiers @name_of_name_parameter = '@schedule_name',
                                                            @name_of_id_parameter   = '@schedule_id',
                                                            @schedule_name          = @schedule_name OUTPUT,
                                                            @schedule_id            = @schedule_id   OUTPUT,
                                                            @owner_sid              = @sched_owner_sid OUTPUT,
                                                            @job_id_filter          = @job_id
  IF (@retval <> 0)
      RETURN(1) -- Failure
 
  -- If the record doesn't exist raise an error
  IF( NOT EXISTS(SELECT *  
                 FROM dbo.JobSchedules
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

    DELETE FROM dbo.JobSchedules
    WHERE (job_id = @job_id)
      AND (schedule_id = @schedule_id)
    
    SELECT @retval = @@ERROR
    
    --delete the schedule if requested and it isn't referenced
    IF(@retval = 0 AND @delete_unused_schedule = 1)
    BEGIN
        IF(NOT EXISTS(SELECT * 
                      FROM dbo.JobSchedules
                      WHERE (schedule_id = @schedule_id)))
        BEGIN
            DELETE FROM dbo.Schedules
            WHERE (schedule_id = @schedule_id)
        END
    END

    -- Update the job's version/last-modified information
    UPDATE dbo.Jobs
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
/****** Object:  StoredProcedure [dbo].[usp_get_jobschedules]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_get_jobschedules]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_get_jobschedules] AS' 
END
GO

-- Get Available Schedules
ALTER PROCEDURE [dbo].[usp_get_jobschedules]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @JobSchedules TABLE(job_id UNIQUEIDENTIFIER, schedule_id INT, next_run_datetime DATETIME)

	;WITH CTE_Schedules
	AS (
		SELECT 
		 JS.schedule_id
		,JS.job_id		
		,next_run_datetime = [dbo].[fn_Job_Datetime](next_run_date,next_run_time) 
		FROM [dbo].[JobSchedules] AS JS
		LEFT JOIN (
			SELECT job_id,
			MAX([dbo].[fn_Job_Datetime](run_date,run_time)) [LastRunDate]
			FROM [dbo].[JobHistory] 
			WHERE run_status = 1
			GROUP BY job_id
		)AS JH ON JS.job_id = JH.job_id
		WHERE [dbo].[fn_Job_Datetime](next_run_date,next_run_time) <= GETDATE()
		AND (JH.[LastRunDate] IS NULL OR [dbo].[fn_Job_Datetime](next_run_date,next_run_time) > JH.[LastRunDate])
	)

	INSERT INTO @JobSchedules(job_id, schedule_id, next_run_datetime)
	SELECT 		 
		 S.job_id	
		,S.schedule_id	
		,S.next_run_datetime
	FROM CTE_Schedules S

	--SELECT * FROM @JobSchedules

	SELECT 
		 S.schedule_id
		,S.job_id	
		,JS.step_id	
		,JS.step_name
		,S.next_run_datetime
		,JS.additional_parameters
	FROM @JobSchedules S
	INNER JOIN [dbo].[JobSteps] JS ON S.job_id = JS.job_id
	ORDER BY S.next_run_datetime, S.job_id, JS.step_id	
END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_schedule_description]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_get_schedule_description]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_get_schedule_description] AS' 
END
GO
-- Alter Procedure usp_get_schedule_description
ALTER PROCEDURE [dbo].[usp_get_schedule_description]
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

  /*
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
  */

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
/****** Object:  StoredProcedure [dbo].[usp_help_jobschedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_help_jobschedule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_help_jobschedule] AS' 
END
GO
-- Create Procedure usp_help_jobschedule
-- Alter Procedure usp_help_jobschedule
-- Alter Procedure usp_help_jobschedule
-- Alter Procedure sp_help_jobschedule
-- Create Procedure sp_help_jobschedule
-- Create Procedure sp_help_jobschedule

ALTER PROCEDURE [dbo].[usp_help_jobschedule]
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
    FROM dbo.JobSchedules
    WHERE (schedule_id = @schedule_id) 
    
    if(@job_count > 1)
    BEGIN
      SELECT @schedule_id_as_char = CONVERT(VARCHAR, @schedule_id)
      RAISERROR(14369, -1, -1, @schedule_id_as_char)
      RETURN(1) -- Failure
    END
  
    SELECT @job_id = job_id
    FROM dbo.JobSchedules
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
    EXECUTE @retval = dbo.usp_verify_job_identifiers '@job_name',
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
    EXECUTE @retval = dbo.usp_verify_schedule_identifiers @name_of_name_parameter = '@schedule_name',
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
                    FROM dbo.JobSchedules AS js
                      JOIN dbo.Schedules AS s
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
  FROM dbo.JobSchedules AS js
    JOIN dbo.Schedules AS s
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

        EXECUTE dbo.usp_get_schedule_description
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
  SELECT *, (SELECT COUNT(*) FROM dbo.JobSchedules WHERE JobSchedules.schedule_id = #temp_jobschedule.schedule_id) as 'job_count'
  FROM #temp_jobschedule
  ORDER BY schedule_id

  RETURN(@@error) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_help_jobstep]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_help_jobstep]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_help_jobstep] AS' 
END
GO
-- Alter Procedure usp_help_jobstep
-- Alter Procedure usp_help_jobstep
-- Alter Procedure sp_help_jobstep
ALTER PROCEDURE [dbo].[usp_help_jobstep]
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

  EXECUTE @retval = dbo.usp_verify_job_identifiers '@job_name',
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
    FROM dbo.JobSteps
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
    FROM dbo.JobSteps
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
           output_file_name,
           last_run_outcome,
           last_run_duration,
           last_run_retries,
           last_run_date,
           last_run_time
    FROM dbo.JobSteps
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
           output_file_name,
           last_run_outcome,
           last_run_duration,
           last_run_retries,
           last_run_date,
           last_run_time
    FROM dbo.JobSteps
    WHERE (job_id = @job_id)
      AND ((@step_id IS NULL) OR (step_id = @step_id))
    ORDER BY job_id, step_id
  END

  RETURN(@@error) -- 0 means success

END

GO
/****** Object:  StoredProcedure [dbo].[usp_log_jobhistory]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_log_jobhistory]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_log_jobhistory] AS' 
END
GO
-- Alter Procedure usp_log_jobhistory
-- Alter Procedure usp_log_jobhistory
-- Alter Procedure usp_log_jobhistory
-- Alter Procedure usp_sqlagent_log_jobhistory
-- Create Procedure sp_sqlagent_log_jobhistory
-- Alter Procedure sp_sqlagent_log_jobhistory
-- Alter Procedure sp_sqlagent_log_jobhistory
ALTER PROCEDURE [dbo].[usp_log_jobhistory]
  @job_id               UNIQUEIDENTIFIER,
  @step_id              INT,
  @sql_message_id       INT = 0,
  @sql_severity         INT = 0,
  @message              NVARCHAR(4000) = NULL,
  @run_status           INT, -- SQLAGENT_EXEC_X code
  @run_date             INT,
  @run_time             INT,
  @run_duration         INT,
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

  -- NOTE: We raise all errors as informational (sev 0) to prevent SQLServerAgent from caching
  --       the operation (if it fails) since if the operation will never run successfully we
  --       don't want it to stay around in the operation cache.
  SELECT @error_severity = 0

  -- Check job_id
  IF (NOT EXISTS (SELECT *
                  FROM dbo.Jobs_View
                  WHERE (job_id = @job_id)))
  BEGIN
    DECLARE @job_id_as_char      VARCHAR(36)
    SELECT @job_id_as_char = CONVERT(VARCHAR(36), @job_id)
    RAISERROR(14262, @error_severity, -1, 'Job', @job_id_as_char)
    RETURN(1) -- Failure
  END

  -- Check step id
  IF (@step_id <> 0) -- 0 means 'for the whole job'
  BEGIN
    SELECT @step_name = step_name
    FROM dbo.JobSteps
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

  -- Check run_status
  IF (@run_status NOT IN (0, 1, 2, 3, 4, 5)) -- SQLAGENT_EXEC_X code
  BEGIN
    RAISERROR(14266, @error_severity, -1, '@run_status', '0, 1, 2, 3, 4, 5')
    RETURN(1) -- Failure
  END

  -- Check run_date
  EXECUTE @retval = dbo.usp_verify_job_date @run_date, '@run_date', 10
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Check run_time
  EXECUTE @retval = dbo.usp_verify_job_time @run_time, '@run_time', 10
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Insert the history row
  INSERT INTO dbo.JobHistory
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
/****** Object:  StoredProcedure [dbo].[usp_set_jobstep_completion_state]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_set_jobstep_completion_state]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_set_jobstep_completion_state] AS' 
END
GO
-- Create Procedure usp_set_jobstep_completion_state
-- Alter Procedure usp_set_jobstep_completion_state
-- Alter Procedure sp_sqlagent_set_jobstep_completion_state
ALTER PROCEDURE [dbo].[usp_set_jobstep_completion_state]
    @job_id                UNIQUEIDENTIFIER,
    @step_id               INT,
    @last_run_outcome      INT,
    @last_run_duration     INT,
    @last_run_retries      INT,
    @last_run_date         INT,
    @last_run_time         INT,
    @session_id            INT 
AS
BEGIN
    -- Update job step completion state in sysjobsteps as well as sysjobactivity
    UPDATE [dbo].[JobSteps]
    SET last_run_outcome      = @last_run_outcome,
        last_run_duration     = @last_run_duration,
        last_run_retries      = @last_run_retries,
        last_run_date         = @last_run_date, 
        last_run_time         = @last_run_time 
    WHERE job_id   = @job_id
    AND   step_id  = @step_id

    DECLARE @last_executed_step_date DATETIME 
    SET @last_executed_step_date = [dbo].[fn_Job_Datetime](@last_run_date, @last_run_time)

    --UPDATE [dbo].[sysjobactivity]
    --SET last_executed_step_date = @last_executed_step_date,
    --    last_executed_step_id   = @step_id
    --WHERE job_id     = @job_id 
    --AND   session_id = @session_id
END

GO
/****** Object:  StoredProcedure [dbo].[usp_start_job]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_start_job]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_start_job] AS' 
END
GO
-- Alter Procedure usp_start_job
-- Create Procedure usp_start_job
-- Alter Procedure usp_start_job
-- Alter Procedure sp_start_job
ALTER PROCEDURE [dbo].[usp_start_job]
  @job_name    sysname          = NULL,
  @job_id      UNIQUEIDENTIFIER = NULL,
  @error_flag  INT              = 1,    -- Set to 0 to suppress the error from sp_sqlagent_notify if SQLServerAgent is not running
  @server_name sysname          = NULL, -- The specific target server to start the [multi-server] job on
  @step_name   sysname          = NULL, -- The name of the job step to start execution with [for use with a local job only]
  @output_flag INT              = 1     -- Set to 0 to suppress the success message
AS
BEGIN
  DECLARE @job_id_as_char VARCHAR(36)
  DECLARE @retval         INT
  DECLARE @step_id        INT
  DECLARE @job_owner_sid  VARBINARY(85)

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @job_name    = LTRIM(RTRIM(@job_name))
  SELECT @server_name = UPPER(LTRIM(RTRIM(@server_name)))
  SELECT @step_name   = LTRIM(RTRIM(@step_name))

  -- Turn [nullable] empty string parameters into NULLs
  IF (@job_name = N'')    SELECT @job_name = NULL
  IF (@server_name = N'') SELECT @server_name = NULL
  IF (@step_name = N'')   SELECT @step_name = NULL

  EXECUTE @retval = dbo.usp_verify_job_identifiers '@job_name',
                                              '@job_id',
                                               @job_name OUTPUT,
                                               @job_id   OUTPUT,
                                               @owner_sid = @job_owner_sid OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Check permissions beyond what's checked by the sysjobs_view
  -- SQLAgentReader role can see all jobs but
  -- cannot start/stop jobs they do not own
  IF (@job_owner_sid <> SUSER_SID()                      -- does not own the job
     AND (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 0)     -- is not sysadmin
     AND (ISNULL(IS_MEMBER(N'SQLAgentOperatorRole'), 0) = 0))  -- is not SQLAgentOperatorRole
  BEGIN
   RAISERROR(14393, -1, -1);  
   RETURN(1) -- Failure
  END

    -- Check the step name (if supplied)
    IF (@step_name IS NOT NULL)
    BEGIN
      SELECT @step_id = step_id
      FROM dbo.JobSteps
      WHERE (step_name = @step_name)
        AND (job_id = @job_id)

      IF (@step_id IS NULL)
      BEGIN
        RAISERROR(14262, -1, -1, '@step_name', @step_name)
        RETURN(1) -- Failure
      END
    END

    EXECUTE @retval = dbo.[usp_start_jobsteps] 
                                                  @job_id      = @job_id,
                                                  @schedule_id = NULL -- This is the start step

    IF ((@retval = 0) AND (@output_flag = 1))
      RAISERROR(14243, 0, 1, @job_name)

  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_start_jobsteps]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_start_jobsteps]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_start_jobsteps] AS' 
END
GO
-- Alter Procedure usp_start_jobsteps
-- Create Procedure sp_start_jobsteps
-- Create Procedure sp_start_jobsteps
-- Create Procedure sp_start_jobsteps
-- Create Procedure sp_start_jobsteps
ALTER PROCEDURE [dbo].[usp_start_jobsteps]
  @job_id      UNIQUEIDENTIFIER = NULL, 
  @schedule_id INT              = NULL, 
  @step_id INT					= NULL
AS
BEGIN

  DECLARE @retval         INT
  DECLARE @nt_user_name   NVARCHAR(100)
   
  SET NOCOUNT ON

  SELECT @retval = 0 -- Success

  SELECT @nt_user_name = ISNULL(NT_CLIENT(), ISNULL(SUSER_SNAME(), FORMATMESSAGE(14205)))

  -- Start: Custom Code

		DECLARE @sql_message_id int
		DECLARE @sql_severity int
		DECLARE @message nvarchar(4000)
		DECLARE @run_status int
		DECLARE @run_date int
		DECLARE @run_time int
		DECLARE @run_duration int
		DECLARE @operator_id_emailed int
		DECLARE @operator_id_netsent int
		DECLARE @operator_id_paged int
		DECLARE @retries_attempted int
		DECLARE @server sysname
		DECLARE @session_id int
		DECLARE @next_run_date int
		DECLARE @next_run_time int
		DECLARE @StartTime DATETIME

		-- Variables for Loop
		DECLARE @Min INT
		DECLARE @Max INT

		DECLARE	@JobSteps TABLE(
			--[job_id] [uniqueidentifier] NOT NULL,
			[step_id] [int] NOT NULL,
			[step_name] [sysname] NOT NULL,
			[subsystem] [nvarchar](40) NOT NULL,
			[command] [nvarchar](max) NULL,
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
			[output_file_name] [nvarchar](200) NULL,
			[last_run_outcome] [int] NOT NULL,
			[last_run_duration] [int] NOT NULL,
			[last_run_retries] [int] NOT NULL,
			[last_run_date] [int] NOT NULL,
			[last_run_time] [int] NOT NULL,
			[step_uid] [uniqueidentifier] NULL
		)

	INSERT @JobSteps(
		 step_id
		,step_name
		,subsystem
		,command
		,cmdexec_success_code
		,on_success_action
		,on_success_step_id
		,on_fail_action
		,on_fail_step_id
		,server
		,database_name
		,database_user_name
		,retry_attempts
		,retry_interval
		,output_file_name
		,last_run_outcome
		,last_run_duration
		,last_run_retries
		,last_run_date
		,last_run_time
	)  
	EXECUTE @retval = [dbo].[usp_help_jobstep] 
	  @job_id    = @job_id, -- Must provide either this or job_name
	  @job_name  = NULL, -- Must provide either this or job_id
	  @step_id   = @step_id,
	  @step_name = NULL,
	  @suffix    = 0     -- A flag to control how the result set is formatted

	-- Find the last step
	declare @last_step_id        int
	select max([last_step_id]) from (
		select max(on_success_step_id) as [last_step_id] from JobSteps where job_id = @job_id union
		select max(on_fail_step_id	 ) as [last_step_id] from JobSteps where job_id = @job_id union
		select max(step_id			 ) as [last_step_id] from JobSteps where job_id = @job_id
	) as t

	SELECT @Min=MIN(step_id), @Max= MAX(step_id) FROM @JobSteps

	WHILE(@Min<=@Max)
	BEGIN
		SET @StartTime = GETDATE()
		
		DECLARE @Command VARCHAR(MAX)

		DECLARE @on_success_action tinyint
		DECLARE @on_success_step_id int
		DECLARE @on_fail_action tinyint
		DECLARE @on_fail_step_id int

		DECLARE @last_run_outcome int
		
		SELECT	@Command = command,
				@on_success_action	= on_success_action,
				@on_success_step_id = on_success_step_id,
				@on_fail_action		= on_fail_action,
				@on_fail_step_id	= on_fail_step_id
		FROM @JobSteps WHERE step_id =	@Min

		BEGIN TRY 
			EXECUTE(@Command)
			SET @last_run_outcome = 1
		END TRY  
		BEGIN CATCH  
			SELECT @retval = @@ERROR, @sql_severity = ERROR_SEVERITY(), @message = FORMATMESSAGE('Msg %i, Level %i, State %i, Line %i, %s. %s', ERROR_NUMBER(), ERROR_SEVERITY(), ERROR_STATE(), ERROR_LINE(), ERROR_PROCEDURE(), ERROR_MESSAGE())
			SET @sql_message_id = @retval 	 
			SET @last_run_outcome = 0			 
		END CATCH; 

	--[dbo].[sp_sqlagent_set_jobstep_completion_state]

		IF @retval = 0
		BEGIN
			SET @message = 'Executed as user: '+@nt_user_name+'. The step succeeded.'
			SET @sql_message_id		= 0	
			SET @sql_severity		= 0	
		END

		-- TODO: Set parameter values here.
		SET @step_id	= @Min
		SET @run_status = 1 
		SET @run_date	= [dbo].[fn_DateToInt](@StartTime)	
		SET @run_time	= [dbo].[fn_TimeToInt](@StartTime)
		SET @run_duration = DATEDIFF(MINUTE, @StartTime, GETDATE())		
		SET @retries_attempted		= 0
		SET @run_status = 1
		SET @server = @@SERVERNAME		

		EXECUTE [dbo].[usp_set_jobstep_completion_state]
			@job_id					= @job_id
			,@step_id               = @step_id
			,@last_run_outcome      = @last_run_outcome
			,@last_run_duration     = @run_duration
			,@last_run_retries      = @retries_attempted
			,@last_run_date         = @run_date
			,@last_run_time         = @run_time
			,@session_id            = @@SPID

		EXECUTE @retval = [dbo].[usp_log_jobhistory] 
			@job_id					= @job_id
			,@step_id				= @step_id				
			,@sql_message_id		= @sql_message_id		
			,@sql_severity			= @sql_severity			
			,@message				= @message				
			,@run_status			= @run_status			
			,@run_date				= @run_date				
			,@run_time				= @run_time				
			,@run_duration			= @run_duration					
			,@retries_attempted		= @retries_attempted		
			,@server				= @server				
			,@session_id			= @session_id

		-- if last step of the job, then update next run date and time
		IF @last_step_id = @step_id
		BEGIN 
			SELECT 
				@next_run_date = FORMAT(infoDate,'yyyyMMdd'),
				@next_run_time = FORMAT(infoDate,'HHmmss')
			 FROM [dbo].[udfGetNextSchedule] (@schedule_id)

			UPDATE dbo.JobSchedules 
			SET next_run_date = @next_run_date, 
				next_run_time = @next_run_time 
			WHERE (job_id = @job_id 
			and schedule_id = @schedule_id)
		END

		/*
		1 = Quit the job reporting success.
		2 = Quit the job reporting failure.
		3 = Go to the next step.
		4 = Go to step.
		*/		
		IF @sql_message_id = 0
		BEGIN
			IF @on_success_action = 1
				RETURN(0);	-- 0 means success
			ELSE IF @on_success_action = 2 
			BEGIN
				RETURN(1); -- Failure
			END		
			ELSE IF @on_success_action = 3
				SELECT @Min = MIN(step_id) FROM @JobSteps WHERE step_id >	@Min
			ELSE IF @on_success_action = 4
				SET @Min = 	@on_success_step_id	
		END ELSE
		BEGIN
			IF @on_fail_action = 1
				RETURN(0);	-- 0 means success
			ELSE IF @on_fail_action = 2 
			BEGIN
				RETURN(1); -- Failure
			END		
			ELSE IF @on_fail_action = 3
				SELECT @Min = MIN(step_id) FROM @JobSteps WHERE step_id >	@Min
			ELSE IF @on_fail_action = 4
				SET @Min = 	@on_fail_step_id	
		END
	END

  RETURN(@retval)
END

GO
/****** Object:  StoredProcedure [dbo].[usp_start_schedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_start_schedule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_start_schedule] AS' 
END
GO

ALTER PROCEDURE [dbo].[usp_start_schedule]
  @schedule_id    int 
AS
BEGIN
	DECLARE @retval		INT
	DECLARE @job_id		uniqueidentifier
	DECLARE @job_name	sysname
	DECLARE @next_run_date int
	DECLARE @next_run_time int
	-- Variables for Loop
	DECLARE @Min		INT
	DECLARE @Max		INT

	SET NOCOUNT ON

	DECLARE @JobSchedules TABLE(Id INT IDENTITY(1,1), job_id uniqueidentifier, job_name	sysname)

	INSERT INTO @JobSchedules (job_id, job_name)
	SELECT S.job_id, J.name 
	FROM JobSchedules S
	INNER JOIN Jobs J ON S.job_id = S.job_id 
	WHERE S.schedule_id = @schedule_id

	SELECT @Min=MIN(Id), @Max= MAX(Id)	
	FROM @JobSchedules

	WHILE(@Min<=@Max)
	BEGIN
		SELECT @job_id  = job_id,  @job_name = job_name FROM @JobSchedules WHERE Id  = @Min

		EXECUTE @retval = dbo.[usp_start_job] @job_id  = @job_id

		IF (@retval = 0) 
		  RAISERROR(14243, 0, 1, @job_name)


		SELECT 
			@next_run_date = FORMAT(infoDate,'yyyyMMdd'),
			@next_run_time = FORMAT(infoDate,'HHmmss')
		 FROM [dbo].[udfGetNextSchedule] (@schedule_id)

		UPDATE dbo.JobSchedules 
		SET next_run_date = @next_run_date, 
			next_run_time = @next_run_time 
		WHERE (job_id = @job_id 
		and schedule_id = @schedule_id)
		
		SELECT @Min = MIN(Id) FROM @JobSchedules WHERE Id >	@Min
	END

  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_update_job]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_update_job]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_update_job] AS' 
END
GO
-- Alter Procedure usp_update_job
-- Alter Procedure usp_update_job
-- Alter Procedure usp_update_job
-- Create Procedure sp_update_job
-- Alter Procedure sp_update_job
-- Create Procedure sp_update_job
-- Alter Procedure sp_update_job
ALTER PROCEDURE [dbo].[usp_update_job]
  @job_id                       UNIQUEIDENTIFIER = NULL, -- Must provide this or current_name
  @job_name                     sysname          = NULL, -- Must provide this or job_id
  @new_name                     sysname          = NULL,
  @enabled                      TINYINT          = NULL,
  @description                  NVARCHAR(512)    = NULL,
  @start_step_id                INT              = NULL,
  @category_name                sysname          = NULL,
  @owner_login_name             sysname          = NULL,
  @delete_level                 INT              = NULL,
  @automatic_post               BIT              = 1     -- Flag for SEM use only
AS
BEGIN
  DECLARE @retval                        INT
  DECLARE @category_id                   INT
  DECLARE @owner_sid                     VARBINARY(85)
  DECLARE @alert_id                      INT
  DECLARE @cached_attribute_modified     INT
  DECLARE @is_sysadmin                   INT
  DECLARE @current_owner                 sysname
  DECLARE @enable_only_used              INT

  DECLARE @x_new_name                    sysname
  DECLARE @x_enabled                     TINYINT
  DECLARE @x_description                 NVARCHAR(512)
  DECLARE @x_start_step_id               INT
  DECLARE @x_category_name               sysname
  DECLARE @x_category_id                 INT
  DECLARE @x_owner_sid                   VARBINARY(85)
  DECLARE @x_delete_level                INT

  -- Remove any leading/trailing spaces from parameters (except @owner_login_name)
  SELECT @job_name                     = LTRIM(RTRIM(@job_name))
  SELECT @new_name                     = LTRIM(RTRIM(@new_name))
  SELECT @description                  = LTRIM(RTRIM(@description))
  SELECT @category_name                = LTRIM(RTRIM(@category_name))

  SET NOCOUNT ON

  EXECUTE @retval = dbo.usp_verify_job_identifiers '@job_name',
                                              '@job_id',
                                               @job_name OUTPUT,
                                               @job_id   OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure

  -- Are we modifying an attribute which SQLServerAgent caches?
  IF ((@new_name                     IS NOT NULL) OR
      (@enabled                      IS NOT NULL) OR
      (@start_step_id                IS NOT NULL) OR
      (@owner_login_name             IS NOT NULL) OR
      (@delete_level                 IS NOT NULL))
    SELECT @cached_attribute_modified = 1
  ELSE
    SELECT @cached_attribute_modified = 0
    
  -- Is @enable the only parameter used beside jobname and jobid?
  IF ((@enabled                   IS NOT NULL) AND
     (@new_name                IS NULL) AND
     (@description                  IS NULL) AND
     (@start_step_id                IS NULL) AND
     (@category_name                IS NULL) AND
     (@owner_login_name             IS NULL) AND
     (@delete_level                 IS NULL))
    SELECT @enable_only_used = 1
  ELSE
    SELECT @enable_only_used = 0

  -- Set the x_ (existing) variables
  SELECT @x_new_name                    = sjv.name,
         @x_enabled                     = sjv.enabled,
         @x_description                 = sjv.description,
         @x_start_step_id               = sjv.start_step_id,
         @x_category_name               = sc.name,                  -- From syscategories
         @x_category_id                 = sc.category_id,           -- From syscategories
         @x_owner_sid                   = sjv.owner_sid,
         --@x_notify_email_operator_name  = so1.name,                   -- From sysoperators
         --@x_notify_netsnd_operator_name = so2.name,                   -- From sysoperators
         --@x_notify_page_operator_name   = so3.name,                   -- From sysoperators
         @x_delete_level                = sjv.delete_level
  FROM dbo.Jobs_View                 sjv
       ,dbo.JobCategories                sc
  WHERE (sjv.job_id = @job_id)
    AND (sjv.category_id = sc.category_id)

  -- Check permissions beyond what's checked by the sysjobs_view
  -- SQLAgentReader and SQLAgentOperator roles that can see all jobs
  -- cannot modify jobs they do not own
  IF ( (@x_owner_sid <> SUSER_SID())                  -- does not own the job
      AND (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1)   -- is not sysadmin
      AND (@enable_only_used <> 1 OR ISNULL(IS_MEMBER(N'SQLAgentOperatorRole'), 0) <> 1))
  BEGIN
   RAISERROR(14525, -1, -1);
   RETURN(1) -- Failure
  END

  -- Check job category, only sysadmin can modify mutli-server jobs        
  IF (EXISTS (SELECT * FROM dbo.JobCategories WHERE (category_class = 1) -- Job
                                                     AND (category_type = 2) -- Multi-Server
                                                     AND (category_id = @x_category_id)
                                                     AND (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1))) -- is not sysadmin
  BEGIN
     RAISERROR(14396, -1, -1);
     RETURN(1) -- Failure
  END          
            
  IF (@new_name = N'') SELECT @new_name = NULL

  -- Fill out the values for all non-supplied parameters from the existing values
  IF (@new_name                     IS NULL) SELECT @new_name                     = @x_new_name
  IF (@enabled                      IS NULL) SELECT @enabled                      = @x_enabled
  IF (@description                  IS NULL) SELECT @description                  = @x_description
  IF (@start_step_id                IS NULL) SELECT @start_step_id                = @x_start_step_id
  IF (@category_name                IS NULL) SELECT @category_name                = @x_category_name
  IF (@owner_sid                    IS NULL) SELECT @owner_sid                    = @x_owner_sid
  IF (@delete_level                 IS NULL) SELECT @delete_level                 = @x_delete_level

  -- If the SA is attempting to assign ownership of the job to someone else, then convert
  -- the login name to an ID
  IF (@owner_login_name = N'$(SQLAgentAccount)')  AND 
     (ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1)
  BEGIN
    SELECT @owner_sid = 0xFFFFFFFF   
  END
  ELSE IF ((ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 1) AND (@owner_login_name IS NOT NULL))
  BEGIN
    --force case insensitive comparation for NT users
    SELECT @owner_sid = SUSER_SID(@owner_login_name, 0) -- If @owner_login_name is invalid then SUSER_SID() will return NULL
  END

  -- Only the SA can re-assign jobs
  IF ((ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) <> 1) AND (@owner_login_name IS NOT NULL))
    RAISERROR(14242, -1, -1)


  -- Turn [nullable] empty string parameters into NULLs
  IF (@description                  = N'') SELECT @description                  = NULL
  IF (@category_name                = N'') SELECT @category_name                = NULL

  -- Check new values
  EXECUTE @retval = dbo.usp_verify_job @job_id,
                                  @new_name,
                                  @enabled,
                                  @start_step_id,
                                  @category_name,
                                  @owner_sid                  OUTPUT,
                                  @delete_level,
                                  @category_id                OUTPUT  
  IF (@retval <> 0)
    RETURN(1) -- Failure

  BEGIN TRANSACTION

  -- If the job is being re-assigned, modify sysjobsteps.database_user_name as necessary
  IF (@owner_login_name IS NOT NULL)
  BEGIN
    IF (EXISTS (SELECT *
                FROM dbo.JobSteps
                WHERE (job_id = @job_id)
                  AND (subsystem = N'TSQL')))
    BEGIN
      IF (EXISTS (SELECT *
                  FROM master.dbo.syslogins
                  WHERE (sid = @owner_sid)
                    AND (sysadmin <> 1)))
      BEGIN
        -- The job is being re-assigned to an non-SA
        UPDATE dbo.JobSteps
        SET database_user_name = NULL
        WHERE (job_id = @job_id)
          AND (subsystem = N'TSQL')
      END
    END
  END


  UPDATE dbo.Jobs
  SET name                       = @new_name,
      enabled                    = @enabled,
      description                = @description,
      start_step_id              = @start_step_id,
      category_id                = @category_id,              -- Returned from sp_verify_job
      owner_sid                  = @owner_sid,
      delete_level               = @delete_level,
      version_number             = version_number + 1,  -- Update the job's version
      date_modified              = GETDATE()            -- Update the job's last-modified information
  WHERE (job_id = @job_id)
  SELECT @retval = @@error

  COMMIT TRANSACTION

  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_update_jobstep]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_update_jobstep]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_update_jobstep] AS' 
END
GO
-- Alter Procedure usp_update_jobstep
-- Alter Procedure usp_update_jobstep
-- Alter Procedure usp_update_jobstep
-- Alter Procedure sp_update_jobstep
-- Alter Procedure sp_update_jobstep
ALTER PROCEDURE [dbo].[usp_update_jobstep]
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
  @retry_interval         INT              = NULL
AS
BEGIN
  DECLARE @retval                 INT
  DECLARE @step_id_as_char        VARCHAR(10)
  DECLARE @new_step_name          sysname
  DECLARE @x_step_name            sysname
  DECLARE @x_subsystem            NVARCHAR(40)
  DECLARE @x_command              NVARCHAR(max)
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
  DECLARE @x_last_run_outcome     TINYINT      -- Not updatable (but may be in future)
  DECLARE @x_last_run_duration    INT          -- Not updatable (but may be in future)
  DECLARE @x_last_run_retries     INT          -- Not updatable (but may be in future)
  DECLARE @x_last_run_date        INT          -- Not updatable (but may be in future)
  DECLARE @x_last_run_time        INT          -- Not updatable (but may be in future)

  DECLARE @subsystem_id           INT
  DECLARE @job_owner_sid        VARBINARY(85)
  
  SET NOCOUNT ON


  -- Remove any leading/trailing spaces from parameters
  SELECT @step_name          = LTRIM(RTRIM(@step_name))
  SELECT @subsystem          = LTRIM(RTRIM(@subsystem))
  SELECT @command            = LTRIM(RTRIM(@command))
  SELECT @server             = LTRIM(RTRIM(@server))
  SELECT @database_name      = LTRIM(RTRIM(@database_name))
  SELECT @database_user_name = LTRIM(RTRIM(@database_user_name))

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

  EXECUTE @retval = dbo.usp_verify_job_identifiers '@job_name',
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
                  FROM dbo.JobSteps
                  WHERE (job_id = @job_id)
                    AND (step_id = @step_id)))
  BEGIN
    SELECT @step_id_as_char = CONVERT(VARCHAR(10), @step_id)
    RAISERROR(14262, -1, -1, '@step_id', @step_id_as_char)
    RETURN(1) -- Failure
  END

  -- Set the x_ (existing) variables
  SELECT @x_step_name            = step_name,
         @x_subsystem            = subsystem,
         @x_command              = command,
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
         @x_last_run_outcome     = last_run_outcome,
         @x_last_run_duration    = last_run_duration,
         @x_last_run_retries     = last_run_retries,
         @x_last_run_date        = last_run_date,
         @x_last_run_time        = last_run_time
  FROM dbo.JobSteps
  WHERE (job_id = @job_id)
    AND (step_id = @step_id)

  IF ((@step_name IS NOT NULL) AND (@step_name <> @x_step_name))
    SELECT @new_step_name = @step_name

  -- Fill out the values for all non-supplied parameters from the existing values
  IF (@step_name            IS NULL) SELECT @step_name            = @x_step_name
  IF (@subsystem            IS NULL) SELECT @subsystem            = @x_subsystem
  IF (@command              IS NULL) SELECT @command              = @x_command
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

  -- Turn [nullable] empty string parameters into NULLs
  IF (@command            = N'') SELECT @command            = NULL
  IF (@server             = N'') SELECT @server             = NULL
  IF (@database_name      = N'') SELECT @database_name      = NULL
  IF (@database_user_name = N'') SELECT @database_user_name = NULL


  -- Check new values
  EXECUTE @retval = dbo.usp_verify_jobstep @job_id,
                                      @step_id,
                                      @new_step_name,
                                      @subsystem,
                                      @command,
                                      @server,
                                      @on_success_action,
                                      @on_success_step_id,
                                      @on_fail_action,
                                      @on_fail_step_id,
                                      @database_name      OUTPUT,
                                      @database_user_name OUTPUT
  IF (@retval <> 0)
    RETURN(1) -- Failure

  BEGIN TRANSACTION

    -- Update the job's version/last-modified information
    UPDATE dbo.Jobs
    SET version_number = version_number + 1,
        date_modified = GETDATE()
    WHERE (job_id = @job_id)

    -- Update the step
    UPDATE dbo.JobSteps
    SET step_name             = @step_name,
        subsystem             = @subsystem,
        command               = @command,
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
        last_run_outcome      = @x_last_run_outcome,
        last_run_duration     = @x_last_run_duration,
        last_run_retries      = @x_last_run_retries,
        last_run_date         = @x_last_run_date,
        last_run_time         = @x_last_run_time
    WHERE (job_id = @job_id)
      AND (step_id = @step_id)


  COMMIT TRANSACTION

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_update_schedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_update_schedule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_update_schedule] AS' 
END
GO
-- Create Procedure usp_update_schedule
-- Alter Procedure usp_update_schedule
-- Alter Procedure usp_update_schedule
-- Create Procedure sp_update_schedule

ALTER PROCEDURE [dbo].[usp_update_schedule]
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
  EXECUTE @retval = dbo.usp_verify_schedule_identifiers @name_of_name_parameter = '@name',
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
  FROM dbo.Schedules
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
  EXECUTE @retval = dbo.usp_verify_schedule @schedule_id             = @schedule_id,
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
  UPDATE dbo.Schedules
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

  RETURN(@retval) -- 0 means success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_verify_category_identifiers]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_category_identifiers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_verify_category_identifiers] AS' 
END
GO
-- Alter Procedure usp_verify_category_identifiers
-- Alter Procedure sp_verify_category_identifiers

ALTER PROCEDURE [dbo].[usp_verify_category_identifiers]
   @name_of_name_parameter [varchar](60),
   @name_of_id_parameter [varchar](60),
   @category_name [sysname] OUTPUT,
   @category_id [INT] OUTPUT
AS
BEGIN
  DECLARE @retval         INT
  DECLARE @category_id_as_char NVARCHAR(36)

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @name_of_name_parameter = LTRIM(RTRIM(@name_of_name_parameter))
  SELECT @name_of_id_parameter   = LTRIM(RTRIM(@name_of_id_parameter))
  SELECT @category_name          = LTRIM(RTRIM(@category_name))

  IF (@category_name = N'') SELECT @category_name = NULL

  IF ((@category_name IS NOT NULL) AND (@category_id IS NOT NULL))
  BEGIN
    RAISERROR(14524, -1, -1, @name_of_id_parameter, @name_of_name_parameter)
    RETURN(1) -- Failure
  END

  -- Check category id
  IF (@category_id IS NOT NULL)
  BEGIN
    SELECT @category_name = name
    FROM dbo.JobCategories
    WHERE (category_id = @category_id)
    IF (@category_name IS NULL)
    BEGIN
     SELECT @category_id_as_char = CONVERT(nvarchar(36), @category_id)
      RAISERROR(14262, -1, -1, '@category_id', @category_id_as_char)
      RETURN(1) -- Failure
    END
  END
  ELSE
  -- Check category name
  IF (@category_name IS NOT NULL)
  BEGIN
    -- The name is not ambiguous, so get the corresponding category_id (if the job exists)
    SELECT @category_id = category_id
    FROM dbo.JobCategories
    WHERE (name = @category_name)
    IF (@category_id IS NULL)
    BEGIN
      RAISERROR(14262, -1, -1, '@category_name', @category_name)
      RETURN(1) -- Failure
    END
  END

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_verify_job]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_job]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_verify_job] AS' 
END
GO
-- Alter Procedure usp_verify_job
-- Alter Procedure sp_verify_job
-- Alter Procedure sp_verify_job

ALTER PROCEDURE [dbo].[usp_verify_job]
  @job_id                       UNIQUEIDENTIFIER,
  @name                         sysname,
  @enabled                      TINYINT,
  @start_step_id                INT,
  @category_name                sysname,
  @owner_sid                    VARBINARY(85) OUTPUT, -- Output since we may modify it
  @delete_level                 INT,
  @category_id                  INT           OUTPUT -- The ID corresponding to the name
AS
BEGIN
  DECLARE @job_type           INT
  DECLARE @retval             INT
  DECLARE @current_date       INT
  DECLARE @res_valid_range    NVARCHAR(200)

  SET NOCOUNT ON

  -- Remove any leading/trailing spaces from parameters
  SELECT @name                       = LTRIM(RTRIM(@name))
  SELECT @category_name              = LTRIM(RTRIM(@category_name))

  -- Check enabled state
  IF (@enabled <> 0) AND (@enabled <> 1)
  BEGIN
    RAISERROR(14266, -1, -1, '@enabled', '0, 1')
    RETURN(1) -- Failure
  END

  -- Check start step
  IF (@job_id IS NULL)
  BEGIN
    -- New job
    -- NOTE: For [new] MSX jobs we allow the start step to be other than 1 since
    --       the start step was validated when the job was created at the MSX
    IF (@start_step_id <> 1)
    BEGIN
      RAISERROR(14266, -1, -1, '@start_step_id', '1')
      RETURN(1) -- Failure
    END
  END
  ELSE
  BEGIN
    -- Existing job
    DECLARE @max_step_id INT
    DECLARE @valid_range VARCHAR(50)

    -- Get current maximum step id
    SELECT @max_step_id = ISNULL(MAX(step_id), 0)
    FROM dbo.JobSteps
    WHERE (job_id = @job_id)

    IF (@start_step_id < 1) OR (@start_step_id > @max_step_id + 1)
    BEGIN
      SELECT @valid_range = '1..' + CONVERT(VARCHAR, @max_step_id + 1)
      RAISERROR(14266, -1, -1, '@start_step_id', @valid_range)
      RETURN(1) -- Failure
    END
  END

  -- Check category
  SELECT @job_type = NULL

    SELECT @job_type = 1 -- LOCAL


  -- A local job cannot be added to a multi-server job_category
  IF (@job_type = 1) AND (EXISTS (SELECT *
                                  FROM dbo.JobCategories
                                  WHERE (category_class = 1) -- Job
                                    AND (category_type = 2) -- Multi-Server
                                    AND (name = @category_name)))
  BEGIN
    RAISERROR(14285, -1, -1)
    RETURN(1) -- Failure
  END

  -- A multi-server job cannot be added to a local job_category
  IF (@job_type = 2) AND (EXISTS (SELECT *
                                  FROM dbo.JobCategories
                                  WHERE (category_class = 1) -- Job
                                    AND (category_type = 1) -- Local
                                    AND (name = @category_name)))
  BEGIN
    RAISERROR(14286, -1, -1)
    RETURN(1) -- Failure
  END

  -- Get the category_id, handling any special-cases as appropriate
  SELECT @category_id = NULL
  IF (@category_name = N'[DEFAULT]') -- User wants to revert to the default job category
  BEGIN
    SELECT @category_id = CASE ISNULL(@job_type, 1)
                            WHEN 1 THEN 0 -- [Uncategorized (Local)]
                            WHEN 2 THEN 2 -- [Uncategorized (Multi-Server)]
                          END
  END
  ELSE
  IF (@category_name IS NULL) -- The sp_add_job default
  BEGIN
    SELECT @category_id = 0
  END
  ELSE
  BEGIN
    SELECT @category_id = category_id
    FROM dbo.JobCategories
    WHERE (category_class = 1) -- Job
      AND (name = @category_name)
  END

  IF (@category_id IS NULL)
  BEGIN
    RAISERROR(14234, -1, -1, '@category_name', 'sp_help_category')
    RETURN(1) -- Failure
  END

  -- Only SQLServerAgent may add jobs to the 'Jobs From MSX' category
  IF (@category_id = 1) AND
     (PROGRAM_NAME() NOT LIKE N'SQLAgent%')
  BEGIN
    RAISERROR(14267, -1, -1, @category_name)
    RETURN(1) -- Failure
  END

  -- Check owner
  -- Default the owner to be the calling user if:
  -- caller is not a sysadmin
  -- caller is not SQLAgentOperator and job_id is NULL, meaning new job 
  IF (((ISNULL(IS_SRVROLEMEMBER(N'sysadmin'), 0) = 0) AND
      ((ISNULL(IS_MEMBER('SQLAgentOperatorRole'), 0) = 0) AND @job_id IS NULL)) AND
      (@owner_sid <> SUSER_SID()))
  BEGIN
    SELECT @owner_sid = SUSER_SID()
  END
  
  -- Now just check that the login id is valid (ie. it exists and isn't an NT group)
  IF ((@owner_sid <> 0x010100000000000512000000) AND -- NT AUTHORITY\SYSTEM sid
     (@owner_sid <> 0x010100000000000514000000)) OR  -- NT AUTHORITY\NETWORK SERVICE sid
     (@owner_sid IS NULL)
  BEGIN
     IF (@owner_sid IS NULL OR (EXISTS (SELECT sid
                                      FROM sys.syslogins
                                      WHERE sid = @owner_sid
                                        AND isntgroup <> 0)))
     BEGIN
       -- NOTE: In the following message we quote @owner_login_name instead of @owner_sid
       --       since this is the parameter the user passed to the calling SP (ie. either
       --       sp_add_job or sp_update_job)
       SELECT @res_valid_range = FORMATMESSAGE(14203)
       RAISERROR(14234, -1, -1, '@owner_login_name', @res_valid_range)
       RETURN(1) -- Failure
     END
  END

  IF (@delete_level & 0x3 <> @delete_level)
  BEGIN
    RAISERROR(14266, -1, -1, '@delete_level', '0, 1, 2, 3')
    RETURN(1) -- Failure
  END

  RETURN(0) -- Success
END

GO
/****** Object:  StoredProcedure [dbo].[usp_verify_job_date]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_job_date]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_verify_job_date] AS' 
END
GO
-- Alter Procedure usp_verify_job_date
ALTER PROCEDURE [dbo].[usp_verify_job_date]
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
/****** Object:  StoredProcedure [dbo].[usp_verify_job_identifiers]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_job_identifiers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_verify_job_identifiers] AS' 
END
GO
-- Alter Procedure usp_verify_job_identifiers
-- Create Procedure sp_verify_job_identifiers
ALTER PROCEDURE [dbo].[usp_verify_job_identifiers]
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
    FROM dbo.Jobs_View
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
         FROM dbo.Jobs_View
         WHERE (name = @job_name)) > 1)
    BEGIN
      RAISERROR(14293, -1, -1, @job_name, @name_of_id_parameter, @name_of_name_parameter)
      RETURN(1) -- Failure
    END

    -- The name is not ambiguous, so get the corresponding job_id (if the job exists)
    SELECT @job_id = job_id,
           @owner_sid = owner_sid
    FROM dbo.Jobs_View
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
/****** Object:  StoredProcedure [dbo].[usp_verify_job_time]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_job_time]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_verify_job_time] AS' 
END
GO
-- Alter Procedure usp_verify_job_time

ALTER PROCEDURE [dbo].[usp_verify_job_time]
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
/****** Object:  StoredProcedure [dbo].[usp_verify_jobstep]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_jobstep]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_verify_jobstep] AS' 
END
GO
-- Alter Procedure usp_verify_jobstep
-- Alter Procedure sp_verify_jobstep
ALTER PROCEDURE [dbo].[usp_verify_jobstep]
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
  @database_name      sysname OUTPUT,
  @database_user_name sysname OUTPUT
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

  -- Get current maximum step id
  SELECT @max_step_id = ISNULL(MAX(step_id), 0)
  FROM dbo.JobSteps
  WHERE (job_id = @job_id)

  -- Check step id
  IF (@step_id < 1) OR (@step_id > @max_step_id + 1)
  BEGIN
    SELECT @valid_values = '1..' + CONVERT(VARCHAR, @max_step_id + 1)
    RAISERROR(14266, -1, -1, '@step_id', @valid_values)
    RETURN(1) -- Failure
  END

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
              FROM dbo.JobSteps
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
/****** Object:  StoredProcedure [dbo].[usp_verify_schedule]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_schedule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_verify_schedule] AS' 
END
GO
-- Alter Procedure usp_verify_schedule
-- Alter Procedure sp_verify_schedule
-- Alter Procedure sp_verify_schedule
ALTER PROCEDURE [dbo].[usp_verify_schedule]
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

  EXECUTE @return_code = dbo.usp_verify_job_date @active_end_date, '@active_end_date'
  IF (@return_code <> 0)
    RETURN(1) -- Failure

  EXECUTE @return_code = dbo.usp_verify_job_date @active_start_date, '@active_start_date'
  IF (@return_code <> 0)
    RETURN(1) -- Failure

  IF (@active_end_date < @active_start_date)
  BEGIN
    RAISERROR(14288, -1, -1, '@active_end_date', '@active_start_date')
    RETURN(1) -- Failure
  END

  EXECUTE @return_code = dbo.usp_verify_job_time @active_end_time, '@active_end_time'
  IF (@return_code <> 0)
    RETURN(1) -- Failure

  EXECUTE @return_code = dbo.usp_verify_job_time @active_start_time, '@active_start_time'
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
/****** Object:  StoredProcedure [dbo].[usp_verify_schedule_identifiers]    Script Date: 30-06-2020 16:31:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_verify_schedule_identifiers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_verify_schedule_identifiers] AS' 
END
GO
-- Alter Procedure usp_verify_schedule_identifiers
-- Alter Procedure sp_verify_schedule_identifiers
-- Alter Procedure sp_verify_schedule_identifiers
ALTER PROCEDURE [dbo].[usp_verify_schedule_identifiers]
  @name_of_name_parameter   VARCHAR(60),             -- Eg. '@schedule_name'
  @name_of_id_parameter     VARCHAR(60),             -- Eg. '@schedule_id'
  @schedule_name            sysname             OUTPUT, 
  @schedule_id              INT                 OUTPUT,
  @owner_sid                VARBINARY(85)       OUTPUT,
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
        -- Look at all schedules
        SELECT @schedule_name   = name,
           @owner_sid           = owner_sid
        FROM dbo.Schedules
        WHERE (schedule_id = @schedule_id)


    IF (@schedule_name IS NULL)
    BEGIN

        SELECT @schedule_id_as_char = CONVERT(VARCHAR(36), @schedule_id)
        RAISERROR(14262, -1, -1, '@schedule_id', @schedule_id_as_char)
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
               @owner_sid      = MIN(owner_sid)
        FROM dbo.Schedules as s
          JOIN dbo.JobSchedules as js 
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
            @owner_sid       = MIN(owner_sid)
        FROM dbo.Schedules
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
                FROM dbo.Schedules as sched
                  JOIN dbo.JobSchedules as js 
                    ON sched.schedule_id = js.schedule_id
                WHERE (name = @schedule_name) AND
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