CREATE TABLE Rooms (
    RoomID int NOT NULL PRIMARY KEY identity,
    RoomNumber int NOT NULL unique,
	Availability bit NOT NULL,
	FloorNumber int NOT NULL,
	RoomType nvarchar(MAX) NOT NULL
);
go

CREATE TABLE Users (
    UserID int NOT NULL PRIMARY KEY identity,
    UserSSN int NOT NULL UNIQUE ,
	UserName nvarchar(MAX) NOT NULL,
	UserGender char NOT NULL,
	UserPhoneNumber nvarchar(MAX) NOT NULL,
	UserMailAddress nvarchar(450) NOT NULL UNIQUE,
	UserPassword nvarchar(MAX) NOT NULL,
	RoleID int NOT NULL
);

go
CREATE TABLE Roles (
    RoleID int NOT NULL PRIMARY KEY identity,
	RoleName nvarchar(450) NOT NULL unique
);
go
CREATE TABLE Reservation (
    ReservationID int NOT NULL PRIMARY KEY identity,
	UserID int NOT NULL,
	RoomID int NOT NULL,
	ReservationTime date NOT NULL,
	StartDate date NOT NULL ,
	EndDate date NOT NULL,
	CheckoutTime date,
	CreateReservationBy int NOT NULL
	
	);

ALTER TABLE Reservation  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Reservation_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO

ALTER TABLE Reservation  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Reservation_RoomID] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Rooms] ([RoomID])
GO
ALTER TABLE Reservation  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Reservation_CreateReservationBy] FOREIGN KEY([CreateReservationBy])
REFERENCES [dbo].[Users] ([UserID])
GO

ALTER TABLE Users  WITH CHECK ADD  CONSTRAINT [FK_Users_Users_RoleID] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO


11	123	ali	m	0158528	Ali@gmail.com	0125	2
14	1234	ahmed	f	015588	ahmed@gmail.com	012585	2
17	1235	ali	m	0158528	Ali@gmail.com	0125	2
18	12356	ali	m	0158528	Ali@gmail.com	0125	2
19	6585	ahmed	f	015588	ahmed@gmail.com	012585	2
20	85258	ahmed	f	015588	ahmed@gmail.com	012585	2
21	55885	ahmed	f	015588	ahmed@gmail.com	012585	2
NULL	NULL	NULL	NULL	NULL	NULL	NULL	NULL

