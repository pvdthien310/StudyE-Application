Create Table EV_Word
(
	ID int not null,
	Name nvarchar(50),
	Meaning nvarchar(3000)
)
alter table EV_Word 
add constraint PK_ID_EV primary key (ID)

Create Table VE_Word
(
	ID int not null,
	Name nvarchar(50),
	Meaning nvarchar(3000)
)
alter table VE_Word 
add constraint PK_ID_VV primary key (ID)

