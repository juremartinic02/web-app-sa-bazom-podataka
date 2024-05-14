create table dbo.OsobeZivotinje(
	OsobaId int not null 
		constraint FK_OsobeZivotinje_Osoba 
		foreign key references dbo.Osobe(Id),
	ZivotinjaId int not null 
		constraint FK_OsobeZivotinje_Zivotinja 
		foreign key references dbo.Zivotinje(Id)

	constraint PK_OsobeZivotinje primary key (OsobaId, ZivotinjaId)
);