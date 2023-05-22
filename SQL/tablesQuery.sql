-- Create TagConfig table
CREATE TABLE TagConfig (
    TagId INT PRIMARY KEY,
    TagName VARCHAR(50) NOT NULL,
    ItemId VARCHAR(50) NOT NULL,
    Description TEXT
);

-- Create TagData table
CREATE TABLE TagData (
    TagId INT,
    TagTimeStamp datetime,
    Value FLOAT NOT NULL,
    Status VARCHAR(50) NOT NULL,
    FOREIGN KEY (TagId) REFERENCES TagConfig(TagId)
);

-- Create Alarm table
CREATE TABLE Alarm (
    AlarmId INT PRIMARY KEY,
    TagId INT,
    ActivationTime datetime,
    Acknowledged int,
    AlarmType VARCHAR(50) NOT NULL,
    Priority INT NOT NULL,
    Description TEXT,
    FOREIGN KEY (TagId) REFERENCES TagConfig(TagId)
);
