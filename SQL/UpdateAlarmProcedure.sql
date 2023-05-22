CREATE PROCEDURE UpdateAlarm
    @AlarmId INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Update the alarm to set it as acknowledged and set the AcknowledgeTime
    UPDATE Alarm
    SET Acknowledged = 1,
        AcknowledgeTime = GETDATE()
    WHERE AlarmId = @AlarmId;
END;
