

CREATE  TABLE Kojin_operational_country (
  id INT identity NOT NULL  ,
  Country_Code CHAR(2) DEFAULT NULL,
  PRIMARY KEY (id)    
)
go


create table Kojin_Country (
  cou_code nvarchar(2) not null default '',
  name varchar(80) not null default '',
  cou_name varchar(80) not null default '',
  iso3 varchar(3) default null,
  numcode int default null,
  primary key (cou_code)
)
go


create table Kojin_province (
  id bigint not null default '0',
  province_name varchar(40) not null default '',
  province_code char(2) not null default '',
  cou_code char(2) not null default 'us',
  primary key  (id)
)
go

CREATE TABLE [dbo].[ErrorInfo](
	[Sno] [int] IDENTITY(1,1) NOT NULL,
	[ExceptionMsg] [varchar](100) NULL,
	[ExceptionType] [varchar](100) NULL,
	[ExceptionSource] [nvarchar](max) NULL,
	[ExceptionURL] [varchar](100) NULL,
	[Logdate] [datetime] NULL,
	[IPAdd] [varchar](100) NULL
PRIMARY KEY CLUSTERED 
(
	[Sno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF


Create Procedure ExceptionLoggingToDataBase    
(  
	@ExceptionMsg varchar(100)=null,  
	@ExceptionType varchar(100)=null,  
	@ExceptionSource nvarchar(max)=null,  
	@ExceptionURL varchar(100)=null,
	@IPAdd varchar(100)    
)    
as    
begin   
	Insert into ErrorInfo  
	(    
	ExceptionMsg ,    
	ExceptionType,     
	ExceptionSource,    
	ExceptionURL,    
	Logdate,
	IPAdd    
	)    
	select    
	@ExceptionMsg,    
	@ExceptionType,    
	@ExceptionSource,    
	@ExceptionURL,    
	getdate(),
	@IPAdd    
End 





DROP PROCEDURE PROC_Kojin_InsertUpdateCustomer
GO
CREATE PROCEDURE PROC_Kojin_InsertUpdateCustomer
(
	@Cust_id	varchar(50) = null,
	@Name1	varchar(50) = null,
	@Name2	varchar(50) = null,
	@Name3	varchar(50) = null,
	@Gender	varchar(10) = null,
	@Address1	varchar(100) = null,
	@Address2	varchar(100) = null,
	@Address3	varchar(100) = null,
	@City	varchar(100) = null,
	@State	varchar(100) = null,
	@Country	varchar(100) = null,
	@Pincode	varchar(20) = null,
	@UserType	varchar(50) = null
)
AS BEGIN
	IF EXISTS(SELECT * FROM Kojin_Cust_Master Where Cust_id = @Cust_id And Status = 1)
	BEGIN
		UPDATE Kojin_Cust_Master SET 
		Name1=@Name1,
		Name2=@Name2,
		Name3=@Name3,
		Gender=@Gender,
		Address1=@Address1,
		Address2=@Address2,
		Address3=@Address3,
		City=@City,
		State=@State,
		Country=@Country,
		Pincode=@Pincode,
		UserType=@UserType,
		DateTime=GetDate() Where Cust_id = @Cust_id
	END
	ELSE BEGIN
		 DECLARE @PREFIX VARCHAR(10);
		 SET @PREFIX= 'KCNDLS';	
		 DECLARE @id	varchar(50);
		 SELECT @id  = (@PREFIX + replicate(0, 7- len(CONVERT(VARCHAR,N.OID + 1))) + CONVERT(VARCHAR,N.OID + 1)) FROM (SELECT CASE WHEN MAX(T.TID) IS null then 0 else     
		 MAX(T.TID) end as OID FROM (SELECT SUBSTRING(Cust_id, 1, 6) as PRE_FIX,SUBSTRING (Cust_id, 7, LEN(Cust_id)) as TID FROM Kojin_Cust_Master WHERE  
		 Cust_id LIKE  @PREFIX+'%') AS T WHERE T.PRE_FIX = @PREFIX ) AS N
		 INSERT INTO Kojin_Cust_Master(Cust_id,Name1,Name2,Name3,Gender,Address1,Address2,Address3,City,State,Country,Pincode,UserType,DateTime)
         SELECT	@id,@Name1,@Name2,@Name3,@Gender,@Address1,@Address2,@Address3,@City,@State,@Country,@Pincode,@UserType,GetDate()
	END
 END



CREATE TABLE Kojin_Kitchen_Master
 (
	Cust_id varchar(50) NOT NULL,
	Kit_id  varchar(50) NOT NULL,
	Kit_Loc1 varchar(100) DEFAULT NULL,
	Kit_Loc2 varchar(100) DEFAULT NULL,
	Kit_Type varchar(50) DEFAULT NULL,
	App_Small_V DECIMAL(10,4),
	Act_Small_V DECIMAL(10,4),
	App_Meduim_V DECIMAL(10,4),
	Act_Meduim_V DECIMAL(10,4),
	App_Larger_V DECIMAL(10,4),
	Act_Larger_V DECIMAL(10,4),
	App_Extra_LV DECIMAL(10,4),
	Act_Extra_LV DECIMAL(10,4),
	Kit_Status INT DEFAULT 1,
	Kit_DateTime DateTime  NULL,
	primary key (Kit_id)
 )

 
 

DROP PROCEDURE PROC_Kojin_InsertUpdateKitchen
GO
CREATE PROCEDURE PROC_Kojin_InsertUpdateKitchen
(
	@Cust_id varchar(50),
	@Kit_id  varchar(50) = NULL,
	@Kit_Loc1 varchar(100) = NULL,
	@Kit_Loc2 varchar(100) = NULL,
	@Kit_Type varchar(50) = NULL,
	@App_Small_V DECIMAL(10,4),
	@Act_Small_V DECIMAL(10,4),
	@App_Meduim_V DECIMAL(10,4),
	@Act_Meduim_V DECIMAL(10,4),
	@App_Larger_V DECIMAL(10,4),
	@Act_Larger_V DECIMAL(10,4),
	@App_Extra_LV DECIMAL(10,4),
	@Act_Extra_LV DECIMAL(10,4)
	
)
AS BEGIN
	IF EXISTS(Select * From Kojin_Kitchen_Master Where Kit_id = @Kit_id)
	BEGIN
		UPDATE Kojin_Kitchen_Master SET 
		Cust_id = @Cust_id,
		Kit_Loc1= @Kit_Loc1,
		Kit_Loc2 = @Kit_Loc2,
		Kit_Type = @Kit_Type,
		App_Small_V = @App_Small_V,
		Act_Small_V = @Act_Small_V,
		App_Meduim_V = @App_Meduim_V,
		Act_Meduim_V = @Act_Meduim_V,
		App_Larger_V = @App_Larger_V,
		Act_Larger_V = @Act_Larger_V,
		App_Extra_LV = @App_Extra_LV,
		Act_Extra_LV = @Act_Extra_LV,
		Kit_DateTime = GETDATE() WHERE Kit_id = @Kit_id
	END
	ELSE BEGIN
		 DECLARE @PREFIX VARCHAR(10);
		 SET @PREFIX= 'KKNDLS';	
		 DECLARE @id	varchar(50);
		 SELECT @id  = (@PREFIX + replicate(0, 7- len(CONVERT(VARCHAR,N.OID + 1))) + CONVERT(VARCHAR,N.OID + 1)) FROM (SELECT CASE WHEN MAX(T.TID) IS null then 0 else     
		 MAX(T.TID) end as OID FROM (SELECT SUBSTRING(Kit_id, 1, 6) as PRE_FIX,SUBSTRING (Kit_id, 7, LEN(Kit_id)) as TID FROM Kojin_Kitchen_Master WHERE  
		 Kit_id LIKE  @PREFIX+'%') AS T WHERE T.PRE_FIX = @PREFIX ) AS N
		INSERT INTO Kojin_Kitchen_Master (Cust_id,Kit_id,Kit_Loc1,Kit_Loc2,Kit_Type,App_Small_V,Act_Small_V,App_Meduim_V,Act_Meduim_V,App_Larger_V,Act_Larger_V,App_Extra_LV,Act_Extra_LV,Kit_DateTime)
		SELECT @Cust_id,@id,@Kit_Loc1,@Kit_Loc2,@Kit_Type,@App_Small_V,@Act_Small_V,@App_Meduim_V,@Act_Meduim_V,@App_Larger_V,@Act_Larger_V,@App_Extra_LV,@Act_Extra_LV,GETDATE()
	END
END



 
 CREATE TABLE Kojin_Item_Category
 (
	Kit_id  varchar(50) NOT NULL,
	Item_Cat_id varchar(50) NOT NULL,
	Item_Cat_Name varchar(100) NOT NULL,
	Item_Cat_Desc1 varchar(100) DEFAULT NULL,
	Item_Cat_Desc2 varchar(100) DEFAULT NULL,
	Item_Cat_Desc3 varchar(100) DEFAULT NULL,
	Item_Cat_Status INT DEFAULT 1,
	Item_Cat_DateTime DateTime ,
	PRIMARY KEY(Item_Cat_id)
 )
 
 
 
CREATE PROCEDURE PROC_Kojin_InsertUpdateItemCategory
(
	@Kit_id  varchar(50),
	@Item_Cat_id varchar(50) = NULL,
	@Item_Cat_Name varchar(100) = NULL,
	@Item_Cat_Desc1 varchar(100) = NULL,
	@Item_Cat_Desc2 varchar(100) = NULL,
	@Item_Cat_Desc3 varchar(100) = NULL
)
AS BEGIN
	IF EXISTS(SELECT * FROM Kojin_Item_Category WHERE Item_Cat_id = @Item_Cat_id)
	BEGIN
		UPDATE Kojin_Item_Category SET
		Kit_id = @Kit_id,Item_Cat_Name = @Item_Cat_Name,Item_Cat_Desc1 = @Item_Cat_Desc1,Item_Cat_Desc2 = @Item_Cat_Desc2 ,
		Item_Cat_Desc3 = @Item_Cat_Desc3 WHERE Item_Cat_id = @Item_Cat_id
	END
	ELSE BEGIN
		DECLARE @PREFIX VARCHAR(10);
		 SET @PREFIX= 'KICN';	
		 DECLARE @id	varchar(50);
		 SELECT @id  = (@PREFIX + replicate(0, 7- len(CONVERT(VARCHAR,N.OID + 1))) + CONVERT(VARCHAR,N.OID + 1)) FROM (SELECT CASE WHEN MAX(T.TID) IS null then 0 else     
		 MAX(T.TID) end as OID FROM (SELECT SUBSTRING(Item_Cat_id, 1, 4) as PRE_FIX,SUBSTRING (Item_Cat_id, 7, LEN(Item_Cat_id)) as TID FROM Kojin_Item_Category WHERE  
		 Item_Cat_id LIKE  @PREFIX+'%') AS T WHERE T.PRE_FIX = @PREFIX ) AS N
		INSERT INTO Kojin_Item_Category(Kit_id,Item_Cat_id,Item_Cat_Name,Item_Cat_Desc1,Item_Cat_Desc2,Item_Cat_Desc3,Item_Cat_DateTime)
		SELECT @Kit_id,@id,@Item_Cat_Name,@Item_Cat_Desc1,@Item_Cat_Desc2,@Item_Cat_Desc3,GETDATE()
	END
END



 CREATE TABLE Kojin_Item_Master
 (
	Item_Cat_id varchar(50) NOT NULL,
	Item_id varchar(50) NOT NULL,
	Item_Name varchar(100) NOT NULL,
	Item_Desc1 varchar(100) DEFAULT NULL,
	Item_Desc2 varchar(100) DEFAULT NULL,
	Item_UnitMeasure varchar(50) DEFAULT NULL,
	Item_Status INT DEFAULT 1,
	Item_DateTime DateTime ,
	PRIMARY KEY(Item_id)
 )
 
 

CREATE PROCEDURE PROC_Kojin_InsertUpdateItemCode  
(  
	 @Item_Cat_id varchar(50) ,  
	 @Item_id varchar(50) ,  
	 @Item_Name varchar(100) = NULL,  
	 @Item_Desc1 varchar(100) = NULL,  
	 @Item_Desc2 varchar(100) = NULL,  
	 @Item_UnitMeasure varchar(50) = NULL  
)  
AS BEGIN  
 IF EXISTS(SELECT * FROM Kojin_Item_Master WHERE Item_id = @Item_id)  
 BEGIN   
	  UPDATE Kojin_Item_Master SET   
	  Item_Cat_id = @Item_Cat_id,Item_Name = @Item_Name,Item_Desc1 = @Item_Desc1,Item_Desc2 = @Item_Desc2,  
	  Item_UnitMeasure = @Item_UnitMeasure,Item_DateTime=GETDATE() WHERE Item_id = @Item_id  
 END  
 ELSE BEGIN  
	   DECLARE @PREFIX VARCHAR(10);
	   SET @PREFIX= 'KIN';   
	   DECLARE @id varchar(50);  
	   SELECT @id  = (@PREFIX + replicate(0, 7- len(CONVERT(VARCHAR,N.OID + 1))) + CONVERT(VARCHAR,N.OID + 1)) FROM (SELECT CASE WHEN MAX(T.TID) IS null then 0 else       
	   MAX(T.TID) end as OID FROM (SELECT SUBSTRING(Item_id, 1, 3) as PRE_FIX,SUBSTRING (Item_id, 7, LEN(Item_id)) as TID FROM Kojin_Item_Master WHERE    
	   Item_id LIKE  @PREFIX+'%') AS T WHERE T.PRE_FIX = @PREFIX ) AS N   
	  
	  INSERT INTO Kojin_Item_Master(Item_Cat_id,Item_id,Item_Name,Item_Desc1,Item_Desc2,Item_UnitMeasure,Item_DateTime)  
	  SELECT @Item_Cat_id,@id,@Item_Name,@Item_Desc1,@Item_Desc2,@Item_UnitMeasure,GETDATE()  
 END  
END



CREATE TABLE Kojin_Item_Unit_Master
(
	Unit_Code varchar(50) NOT NULL,
	Unit_Name varchar(100),
	Unit_Status int Default 1,
	Unit_DateTime DateTime
	PRIMARY KEY(Unit_Code)
)




CREATE PROCEDURE PROC_Kojin_InsertUpdateItemUnitMaster
(
	@Unit_Code varchar(50),
	@Unit_Name varchar(100)	
)
AS 
	IF EXISTS(Select * from Kojin_Item_Unit_Master WHERE Unit_Code = @Unit_Code)
		UPDATE Kojin_Item_Unit_Master SET Unit_Name = @Unit_Name,Unit_DateTime = GETDATE() WHERE Unit_Code = @Unit_Code
	ELSE
		INSERT INTO Kojin_Item_Unit_Master(Unit_Code,Unit_Name,Unit_DateTime)
		SELECT @Unit_Code,@Unit_Name,GETDATE()


		
		
CREATE TABLE Kojin_Kitchen_Tray_Master
(
	Kit_id varchar(50) NOT NULL,
	Tray_Id varchar(100) NOT NULL,
	No_Of_Cell int,
	D_Cell_1 varchar(100),
	D_Cell_2 varchar(100),
	D_Cell_3 varchar(100),
	D_Cell_4 varchar(100),
	D_Cell_5 varchar(100),
	D_Temp_1 varchar(100),
	D_Status INT DEFAULT 1,
	D_DateTime DateTime,
	PRIMARY KEY(Tray_Id)
)

CREATE PROCEDURE PROC_Kojin_InsertUpdateKitchenTrayMaster
(
	@Kit_id varchar(50),
	@Tray_Id varchar(100),
	@No_Of_Cell int,
	@D_Cell_1 varchar(100),
	@D_Cell_2 varchar(100),
	@D_Cell_3 varchar(100),
	@D_Cell_4 varchar(100),
	@D_Cell_5 varchar(100),
	@D_Temp_1 varchar(100)
)
AS 
	IF EXISTS(SELECT * FROM Kojin_Kitchen_Tray_Master WHERE Tray_Id = @Tray_Id)
		UPDATE Kojin_Kitchen_Tray_Master SET Kit_id = @Kit_id,No_Of_Cell = @No_Of_Cell,
		D_Cell_1 = @D_Cell_1,D_Cell_2 = @D_Cell_2,D_Cell_3 = @D_Cell_3,D_Cell_4 = @D_Cell_4,D_Cell_5 = @D_Cell_5,D_Temp_1 = @D_Temp_1,
		D_DateTime = GETDATE() WHERE Tray_Id = @Tray_Id
	ELSE
		INSERT INTO Kojin_Kitchen_Tray_Master(Kit_id,Tray_Id,No_Of_Cell,D_Cell_1,D_Cell_2,D_Cell_3,D_Cell_4,D_Cell_5,D_Temp_1,D_DateTime)
		SELECT @Kit_id,@Tray_Id,@No_Of_Cell,@D_Cell_1,@D_Cell_2,@D_Cell_3,@D_Cell_4,@D_Cell_5,@D_Temp_1,GETDATE()	

		
CREATE TABLE kojin_Vendor_Details
(
	Ven_Code varchar(50) not null,
	Ven_Name varchar(100) not null,
	Ven_Address1 varchar(100),
	Ven_Address2 varchar(100),
	Ven_Address3 varchar(100), 
	Ven_City varchar(100),
	Ven_State varchar(100),
	Ven_Country varchar(100),
	Ven_Pincode varchar(20),
	Ven_Phone varchar(30),
	Ven_Email varchar(50),
	Ven_Status INT Default 1,
	Ven_DateTime DateTime,
	PRIMARY KEY(Ven_Code)
)


		

CREATE TABLE Kojin_Kitchen_Item_Master
(
	Sno INT IDENTITY(1,1) NOT NULL,
	Cust_Id varchar(50),
	Kit_Id varchar(50),
	Tray_Id varchar(50),
	Cell_Id varchar(50),
	Item_Cate varchar(100),
	Item_Code varchar(100),
	Item_Details varchar(100),
	Unit_Of_Measure varchar(50),
	Min_Qty Decimal(10,4),
	Max_Qty Decimal(10,4),
	Re_Order_Qty Decimal(10,4),
	DSMB_Vendor	varchar(100),
	Max_V_SMB_Vendor varchar(100),
	D_Big_Ret varchar(100),
	Min_V_Big_Ret Varchar(100),
	CI_Status Int Default 1,
	CI_DateTime DateTime,
	PRIMARY KEY(Sno)
)




CREATE TABLE Kojin_Item_Replanishment
(
	Cust_Id varchar(50),
	Kit_Id varchar(50),	
	Rep_Window varchar(50),
	Reorder_value varchar(5),
	Item_Rep_Status INT DEFAULT 1,
	Item_Rep_DateTime DateTime,
	Item_Rep_Sno INT IDENTITY NOT NULL,
	PRIMARY KEY(Item_Rep_Sno)
)