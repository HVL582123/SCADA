-- Create the view
CREATE VIEW AlarmView AS
SELECT A.AlarmId, TC.TagName, A.AlarmType, A.ActivationTime, A.AcknowledgeTime
FROM Alarm A
JOIN TagConfig TC ON A.TagId = TC.TagId;
