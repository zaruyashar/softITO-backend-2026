USE School;

INSERT INTO ogrenci(Adsoyad, Yas, Bolum, Puan, BursTutar, DersKredisi, TcNo, Email)
VALUES('merve', 23, 'mühendis',90,5000,34,'123456789', 'merve@email.com');

SELECT * FROM ogrenci;

ALTER TABLE ogrenci ADD CONSTRAINT df_school_ogrenci 
DEFAULT 'istanbul' FOR Sehir;

INSERT INTO ogrenci(Adsoyad, Yas, Bolum, Puan, BursTutar, DersKredisi, TcNo, Email)
VALUES('nej', 23, 'mühendis',90,5000,34,'123456789', 'nej@email.com');

ALTER TABLE ogrenci ADD CONSTRAINT df_school_derskredisi 
DEFAULT 30 FOR DersKredisi;

INSERT INTO ogrenci(Adsoyad, Yas, Bolum, Puan, BursTutar, TcNo, Email)
VALUES('ahmet', 23, 'mühendis',90,5000,'123456789','ahmet@email.com');

ALTER TABLE ogrenci ADD CONSTRAINT UQ_ogrenci_TcNo UNIQUE(TcNo);

ALTER TABLE ogrenci ADD CONSTRAINT Ck_ogrenci_Puan 
CHECK (Puan >= 0 AND PUAN <= 100);

INSERT INTO ogrenci(Adsoyad, Yas, Bolum, Puan, BursTutar, TcNo, Email)
VALUES('deniz', 23, 'mühendis',90,5000,'123456786','deniz@email.com');


--==================================================================--

USE School;

CREATE TABLE [dbo].[Personel] (
[personelno] INT NOT NULL,
[adsoyad] VARCHAR(50) NULL,
[yas] INT NULL,
[mail] VARCHAR(50) NULL,
[departnanadi] VARCHAR(50) NULL,
[merkez] VARCHAR(50) NULL,
[maas] INT NULL,
[prim] INT NULL,
[puan] INT NULL,
[email] VARCHAR(50) NULL,
[vergino] VARCHAR(20) NULL,
[sgkno] VARCHAR(20) NULL,
PRIMARY KEY CLUSTERED ([personelno] ASC)
);

INSERT INTO Personel(personelno, adsoyad, yas, mail, departnanadi, merkez, maas, prim, puan, email, vergino, sgkno)
VALUES(1, 'Ahmet Yilmaz', 35, 'ahmet@sirket.com', 'IT', 'ankara', 60000, 5000, 85, 'ahmet.y@sirket.com', '1000000001', '2000000001');

INSERT INTO Personel(personelno, adsoyad, yas, mail, departnanadi, maas, puan, email, vergino, sgkno)
VALUES(2, 'Zeynep Kaya', 29, 'zeynep@sirket.com', 'IK', 55000, 95, 'zeynep.k@sirket.com', '1000000002', '2000000002');

INSERT INTO Personel(personelno, adsoyad, yas, mail, departnanadi, merkez, maas, prim, puan, email, vergino, sgkno)
VALUES(3, 'Caner Yildiz', 42, 'caner@sirket.com', 'Satis', 'izmir', 70000, 15000, 78, 'caner.y@sirket.com', '1000000003', '2000000003');

INSERT INTO Personel(personelno, adsoyad, yas, mail, departnanadi, maas, prim, puan, email, vergino, sgkno)
VALUES(4, 'Elif Demir', 25, 'elif@sirket.com', 'Pazarlama', 45000, 2000, 88, 'elif.d@sirket.com', '1000000004', '2000000004');

INSERT INTO Personel(personelno, adsoyad, yas, mail, departnanadi, merkez, maas, puan, email, vergino, sgkno)
VALUES(5, 'Burak Sahin', 31, 'burak@sirket.com', 'Muhasebe', 'bursa', 50000, 92, 'burak.s@sirket.com', '1000000005', '2000000005');

ALTER TABLE Personel ADD CONSTRAINT df_school_merkez 
DEFAULT 'istanbul' FOR merkez;

ALTER TABLE Personel ADD CONSTRAINT df_school_prim 
DEFAULT 0 FOR prim;

ALTER TABLE Personel ADD CONSTRAINT UQ_Personel_sgkno UNIQUE(sgkno);

ALTER TABLE Personel ADD CONSTRAINT UQ_Personel_vergino UNIQUE(vergino);

ALTER TABLE Personel ADD CONSTRAINT Ck_Personel_puan 
CHECK (puan >= 0 AND puan <= 100);

ALTER TABLE Personel ADD CONSTRAINT Ck_Personel_yas 
CHECK (yas >= 18);

INSERT INTO Personel(personelno,adsoyad, yas, mail, departnanadi, merkez, maas, puan, email, vergino, sgkno)
VALUES(6, 'Ali Ata', 31, 'ali@sirket.com', 'Yazılım', 'istanbul', 50001, 91, 'ali.a@sirket.com', '1000000123', '2000000123');

--==================================================================--

CREATE FUNCTION CalculatePrice(@Price DECIMAL(18,2), @Percentage DECIMAL(5,2))
RETURNS DECIMAL(18,2)
AS BEGIN
DECLARE @CalculatedResult DECIMAL(18,2)
SET @CalculatedResult = @Price + (@Price * @Percentage / 100)
RETURN @CalculatedResult
END

SELECT dbo.CalculatePrice(1500.00, 20.00) AS 'Calculated Price'
---------------------
create function Durum(@yas int)
returns varchar(50)
as begin
declare @sonuc varchar(50)
set @sonuc=case when @yas<25 then 'genç'
when @yas>=25 and @yas<40 then 'orta yaş'
else 'yaşlı'
end
return @sonuc
end

select dbo.Durum(37)
-------------------------------------------------
ALTER FUNCTION YasHesapla(@dt DATETIME)
RETURNS INT
AS BEGIN
DECLARE @Yas INT
SET @Yas=DATEDIFF(DAY,@dt,GETDATE())
RETURN @Yas
END

SELECT * FROM dbo.YasHesapla('1995/10/01') AS yas -- error on this line
-----------------------------
CREATE FUNCTION dtstudent(@OgrenciNo int) -- error here as well
RETURNS TABLE
AS BEGIN
RETURN SELECT * FROM ogrenci WHERE OgrenciNo = @OgrenciNo

SELECT * FROM dbo.dtstudent

-----------------------------

CREATE VIEW PersonelOgrenciMerkez
AS
SELECT p.adsoyad AS PersonelAdi, p.departnanadi, p.merkez, o.Adsoyad AS OgrenciAdi, o.Bolum
FROM Personel p
INNER JOIN ogrenci o ON p.merkez = o.Sehir
WHERE p.yas >= 30;

SELECT * FROM PersonelOgrenciMerkez;

---------------------TRY-CATCH-----------------------------
BEGIN TRY
SELECT a = 1/0
SELECT b = 5
SELECT c = 3
END TRY 
BEGIN CATCH
PRINT 'Error message'
END CATCH
-----------------------------------
BEGIN TRY
SELECT sonuc=5/0
END TRY
BEGIN CATCH
SELECT [Hatasatırı]=ERROR_LINE(),
[Hatasayısı]=ERROR_NUMBER(),
[Hataonemi]=ERROR_SEVERITY(),
[Hatadurumu]=ERROR_STATE()

SELECT [hatamesajı]=ERROR_MESSAGE()
END CATCH
-------------------------------
BEGIN TRY
EXEC ornekproc
END TRY
BEGIN CATCH
SELECT [Hatasatırı]=ERROR_LINE(),
procedureadi=ERROR_PROCEDURE()
SELECT [hatamesajı]=ERROR_MESSAGE()
END CATCH
--------------------------------------
--TRANSACTION--
--------------------------------------
CREATE TABLE banka(
hesapno INT NOT NULL PRIMARY KEY,
adsoyad VARCHAR(50),
SubeNo INT,
Bakiye INT
);
--------------------------
INSERT INTO banka (hesapno, adsoyad, SubeNo, Bakiye)
VALUES (1001, 'Ahmet Yilmaz', 1, 5000);

INSERT INTO banka (hesapno, adsoyad, SubeNo, Bakiye)
VALUES (1002, 'Ayse Fatma', 2, 12000);

INSERT INTO banka (hesapno, adsoyad, SubeNo, Bakiye)
VALUES (1003, 'Mehmet Can', 1, 3500);

INSERT INTO banka (hesapno, adsoyad, SubeNo, Bakiye)
VALUES (1004, 'Elif Kaya', 3, 25000);

INSERT INTO banka (hesapno, adsoyad, SubeNo, Bakiye)
VALUES (1005, 'Hasan Demir', 2, 800);
--------------------------------
CREATE PROC HavaleYap
@ALICINO INT,
@GONDERENNO INT,
@TUTAR INT
AS
BEGIN TRY
BEGIN TRAN --transaction baslatılıyor
UPDATE banka SET Bakiye-=@TUTAR WHERE hesapno=@GONDERENNO
DECLARE @A INT=8/0
UPDATE banka SET Bakiye+=@TUTAR WHERE hesapno=@ALICINO
COMMIT TRAN
END TRY
BEGIN CATCH
ROLLBACK TRAN
PRINT 'An error occurred'
END CATCH
--------------------------------------
EXEC HavaleYap 2,1,50000

SELECT * FROM banka
--------------------------------------