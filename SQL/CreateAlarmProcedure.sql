CREATE PROCEDURE CreateAlarm
    @TagName VARCHAR(50),
    @ActivationTime DATETIME,
    @AlarmType VARCHAR(50),
    @Priority INT,
    @Description TEXT
AS
BEGIN
    SET NOCOUNT ON;

    -- Get the TagId based on the TagName
    DECLARE @TagId INT;
    SET @TagId = (SELECT TagId FROM TagConfig WHERE TagName = @TagName);

    IF @TagId IS NULL
    BEGIN
        -- Insert the new TagConfig record if the TagName doesn't exist
        INSERT INTO TagConfig (TagName, ItemId, Description)
        VALUES (@TagName, '', '');

        -- Get the newly inserted TagId
        SET @TagId = SCOPE_IDENTITY();
    END;

    -- Insert the new alarm into the Alarm table
    INSERT INTO Alarm (TagId, ActivationTime, Acknowledged, AlarmType, Priority, Description)
    VALUES (@TagId, @ActivationTime, 0, @AlarmType, @Priority, @Description);
END;
