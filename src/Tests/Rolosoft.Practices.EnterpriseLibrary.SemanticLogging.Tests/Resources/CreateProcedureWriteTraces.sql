CREATE PROCEDURE [dbo].[WriteTraces]
(
  @InsertTraces TracesType READONLY
)
AS
BEGIN
  INSERT INTO [Traces] (
		[InstanceName],
		[ProviderId],
		[ProviderName],
		[EventId],
		[EventKeywords],
		[Level],
		[Opcode],
		[Task],
		[Timestamp],
		[Version],
		[FormattedMessage],
		[Payload],
		[ActivityId],
		[RelatedActivityId],
		[ProcessId],
		[ThreadId]
	)
  SELECT * FROM @InsertTraces;
END