-- Create TagConfig table
CREATE TABLE TagConfig (
    TagId INT IDENTITY(1,1) PRIMARY KEY,
    TagName VARCHAR(50) NOT NULL,
    ItemId VARCHAR(50),
    Description TEXT
);

-- Create TagData table
CREATE TABLE TagData (
    TagDataId INT IDENTITY(1,1) PRIMARY KEY,
    TagId INT,
    TagTimeStamp datetime DEFAULT getdate(),
    Value FLOAT NOT NULL,
    Status VARCHAR(50),
    FOREIGN KEY (TagId) REFERENCES TagConfig(TagId)
);

-- Create Alarm table
CREATE TABLE Alarm (
    AlarmId INT IDENTITY(1,1) PRIMARY KEY,
    TagId INT,
    ActivationTime datetime DEFAULT getdate(),
    Acknowledged INT,
    AlarmType VARCHAR(50),
    AcknowledgeTime DATETIME,
    Priority INT,
    Description TEXT,
    FOREIGN KEY (TagId) REFERENCES TagConfig(TagId)
);
