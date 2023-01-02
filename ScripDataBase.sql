CREATE DATABASE [20521587_TNGV]

USE [20521587_TNGV]
--DROP TABLE USERINFO
CREATE TABLE USERINFO(
	USERID			char(4),
	[NAME]			nvarchar(50),
	USERNAME		nvarchar(50),
	[PASSWORD]		nvarchar(50),
	DATECREATE		smalldatetime,
	PHONE			nvarchar(50),
	EMAIL			nvarchar(50),
	[ADDRESS]		nvarchar(400),
	[IMAGE]			image,
);
SET DATEFORMAT DMY;
INSERT INTO USERINFO VALUES('US01',N'Đoán Xem','user','user','28/11/2022','0923423526','doanxem@gmail.com','','');
INSERT INTO USERINFO VALUES('US02',N'Nguyễn Tuân','nguyetuan','123123','28/11/2022','0923423526','','','');
INSERT INTO USERINFO VALUES('US03',N'Thúy Kiều','thuykieu','123123','28/11/2022','0949285736','','','');
INSERT INTO USERINFO VALUES('US04',N'Thúy Vân','thuyvan','123123','28/11/2022','0937483929','','','');
INSERT INTO USERINFO VALUES('US05',N'Nguyễn Du','nguyendu','123123','28/11/2022','0860294052','','','');
INSERT INTO USERINFO VALUES('US06',N'Văn Lực','vanluc','123123','28/11/2022','0948294729','','','');

CREATE TABLE CLEANER(
	ID			char(4),
	[NAME]			nvarchar(50),
	[AGE]			int,
	[ADDRESS]		nvarchar(400),
	PHONE			nvarchar(50),
	EMAIL			nvarchar(50),
	[USERNAME]			nvarchar(50),
	[PASSWORD]		nvarchar(50),
	DATECREATE		smalldatetime,
	[IMAGE]			image,
	[LOVEANIMAL]	int,
	[VACXINED]	int,
	[WORKHOURLV]	int,
	[WORKDATE]	int,
	[ISPREMIUM]	int,

	[RATE]		int,
	CONSTRAINT VACXINED_ischk CHECK (VACXINED IN (1,0)),
	CONSTRAINT LOVEANIMAL_ischk CHECK (LOVEANIMAL IN (1,0)),

);