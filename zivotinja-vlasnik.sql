alter table dbo.Zivotinje
add VlasnikId int not null constraint FK_Zivotinja_Vlasnik foreign key references dbo.Osobe(Id);