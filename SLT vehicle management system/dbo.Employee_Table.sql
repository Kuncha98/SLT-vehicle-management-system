CREATE TABLE [dbo].[Employee_Table] (
    [Employee First Name]      NVARCHAR (50)  NOT NULL,
    [Employee Last Name]       NVARCHAR (50)  NOT NULL,
    [ Emlpoyee Address]        NVARCHAR (MAX) NOT NULL,
	[Employee Date of Birth]   INT NOT NULL,
    [ Emlpoyee Gender]         NVARCHAR (50)  NOT NULL,
    [ Emlpoyee Contact Number] INT            NOT NULL,
    [Employee E-mail]          NVARCHAR (50)  NOT NULL,
    [Employee Password]        NVARCHAR (50)  NOT NULL, 
    CONSTRAINT [PK_Employee_Table] PRIMARY KEY ([Employee First Name])
);

