IF OBJECT_ID(N'dbo.UserLogin', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.UserLogin (
        ID INT IDENTITY(1, 1) PRIMARY KEY,
        UserName NVARCHAR(100) NOT NULL UNIQUE,
        Pwd NVARCHAR(255) NOT NULL
    );
END;

IF OBJECT_ID(N'dbo.student', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.student (
        ID INT IDENTITY(1, 1) PRIMARY KEY,
        Num NVARCHAR(32) NOT NULL UNIQUE,
        Name NVARCHAR(100) NOT NULL,
        Sex NVARCHAR(16) NULL,
        Age INT NULL CHECK (Age > 0),
        Class NVARCHAR(100) NOT NULL,
        Speciality NVARCHAR(100) NOT NULL,
        Phone NVARCHAR(50) NULL
    );
END;
