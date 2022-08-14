// *** SETUP *** //

CREATE DATABASE dbHrmsProj;

CREATE TABLE dbHrmsProj.dbo.tblEmployees (
    ID BIGINT NOT NULL PRIMARY KEY IDENTITY(10001,1),
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
    MiddleName VARCHAR(255),
    PositionID BIGINT,
    Gender VARCHAR(18),
    BDate DATE,
    HomeAddress VARCHAR(255),
    TelNo VARCHAR(255),
    MobileNo VARCHAR(255),
    EmailAddress VARCHAR(255)
)

CREATE TABLE dbHrmsProj.dbo.tblPosition (
    PositionID BIGINT NOT NULL PRIMARY KEY IDENTITY(10001,1),
    PositionName VARCHAR(255)
)

INSERT INTO dbHrmsProj.dbo.tblPosition (PositionName) 
VALUES ('CEO'), ('CTO'), ('Admin'), ('Engineers'), ('Marketing Executive')

INSERT INTO dbHrmsProj.dbo.tblEmployees (
    FirstName,
    LastName,
    MiddleName,
    PositionID,
    Gender,
    BDate,
    HomeAddress,
    TelNo,
    MobileNo,
    EmailAddress
) VALUES 
    ('Alvin', 'Chiew', NULL, 10001, 'Male', '1992-02-22', 'Kuala Lumpur, Malaysia', '+6031324523', '+60181523523', 'alvin@email.com'),
    ('Melvin', 'Cheong', 'Great', 10002, 'Male', '1982-04-30', 'Kedah, Malaysia', NULL, NULL, 'melvin@email.com');

CREATE TABLE dbHrmsProj.dbo.tblUsers (
    ID BIGINT NOT NULL PRIMARY KEY IDENTITY(10001,1),
    UserID BIGINT NOT NULL,
    UserName VARCHAR(255) NOT NULL,
    UserPassword VARCHAR(255),
    DateUpdate DATETIME DEFAULT GETDATE() NOT NULL
);

INSERT INTO dbHrmsProj.dbo.tblUsers (UserID, UserName, UserPassword)
VALUES (10001, 'alv', 'alvpass'), (10002, 'mlv', 'mlvpass');
    
// *** TEST *** //

SELECT e.*, p.PositionName 
FROM dbHrmsProj.dbo.tblEmployees AS e
INNER JOIN dbHrmsProj.dbo.tblPosition AS p
ON e.PositionID = p.PositionID
ORDER BY ID;

SELECT * FROM dbHrmsProj.dbo.tblPosition;
SELECT * FROM dbHrmsProj.dbo.tblUsers;

