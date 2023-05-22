-- Create the AlarmTrigger trigger function
CREATE OR ALTER TRIGGER AlarmTrigger
ON TagData
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Alarm (TagId, AlarmType, ActivationTime, Acknowledged, Description)
    SELECT i.TagId,
           CASE
               WHEN i.Value < 20 THEN 'Low temp'
               WHEN i.Value > 39 THEN 'High temp'
           END AS AlarmType,
           GETDATE() AS ActivationTime,
           0 AS Acknowledged,
           CASE
               WHEN i.Value < 20 THEN 'Tag value is lower than 20'
               WHEN i.Value > 39 THEN 'Tag value is higher than 39'
           END AS Description
    FROM inserted i
    WHERE i.Value < 20 OR i.Value > 39;
END;
