DROP PROCEDURE PROC_Kojin_SelectCustomer
GO
CREATE PROCEDURE PROC_Kojin_SelectCustomer
AS BEGIN
	Select Cust_id,Name1,Name2,Name3,Gender,Address1,Address2,Address3,City,State,Country,Pincode,UserType,Status,Convert(Varchar(20),[DateTime],106) As 'Date'
	,LTRIM(RIGHT(CONVERT(VARCHAR(20),[DateTime],100),7)) AS [Time] from Kojin_Cust_Master
END


DROP PROCEDURE PROC_Kojin_SelectKitchen
GO
CREATE PROCEDURE PROC_Kojin_SelectKitchen
AS BEGIN
	Select Cust_id,Kit_id,Kit_Loc1,Kit_Loc2,Kit_Type,CAST(App_Small_V AS DECIMAL(10,0)) AS App_Small_V,CAST(Act_Small_V AS DECIMAL(10,0)) AS Act_Small_V,
	CAST(App_Meduim_V AS DECIMAL(10,2)) AS App_Meduim_V,CAST(Act_Meduim_V AS DECIMAL(10,2))AS Act_Meduim_V,CAST(App_Larger_V AS DECIMAL(10,2)) AS App_Larger_V,
	CAST(Act_Larger_V AS DECIMAL(10,2)) AS Act_Larger_V,CAST(App_Extra_LV AS DECIMAL(10,2)) AS App_Extra_LV,CAST(Act_Extra_LV AS DECIMAL(10,2)) AS Act_Extra_LV,Kit_Status,
	Convert(Varchar(20),[Kit_DateTime],106) As [Kit_Date],LTRIM(RIGHT(CONVERT(VARCHAR(20),[Kit_DateTime],100),7)) AS [Kit_Time] from  Kojin_Kitchen_Master
END



CREATE PROCEDURE PROC_Kojin_SelectItemCategory
AS BEGIN
	Select Kojin_Kitchen_Master.Kit_id,Kojin_Kitchen_Master.Cust_id,Item_Cat_id,Item_Cat_Name,Item_Cat_Desc1,Item_Cat_Desc2,Item_Cat_Desc3,Item_Cat_Status,
Convert(Varchar(20),[Item_Cat_DateTime],106) As [Item_Cat_Date],LTRIM(RIGHT(CONVERT(VARCHAR(20),[Item_Cat_DateTime],100),7)) AS [Item_Cat_Time],
	Kit_Loc1,Kit_Loc2,Kit_Type,CAST(App_Small_V AS DECIMAL(10,0)) AS App_Small_V,CAST(Act_Small_V AS DECIMAL(10,0)) AS Act_Small_V,
	CAST(App_Meduim_V AS DECIMAL(10,2)) AS App_Meduim_V,CAST(Act_Meduim_V AS DECIMAL(10,2))AS Act_Meduim_V,CAST(App_Larger_V AS DECIMAL(10,2)) AS App_Larger_V,
	CAST(Act_Larger_V AS DECIMAL(10,2)) AS Act_Larger_V,CAST(App_Extra_LV AS DECIMAL(10,2)) AS App_Extra_LV,CAST(Act_Extra_LV AS DECIMAL(10,2)) AS Act_Extra_LV 
	FROM Kojin_Item_Category LEFT OUTER JOIN Kojin_Kitchen_Master ON Kojin_Item_Category.Kit_id = Kojin_Kitchen_Master.Kit_id
END


CREATE PROCEDURE PROC_Kojin_SelectItemMaster
AS
	Select Kojin_Kitchen_Master.Cust_id,Kojin_Kitchen_Master.Kit_id,Kojin_Item_Master.Item_Cat_id,Kojin_Item_Master.Item_id,Item_Name,Item_Desc1,Item_Desc2,
	Item_UnitMeasure,Item_Status, Convert(Varchar(20),[Item_DateTime],106) As [Item_Date],LTRIM(RIGHT(CONVERT(VARCHAR(20),[Item_DateTime],100),7)) AS [Item_Time] 
	from Kojin_Item_Master left outer join Kojin_Item_Category on Kojin_Item_Master.item_cat_id = Kojin_Item_Category.item_cat_id 
	left outer join Kojin_Kitchen_Master on Kojin_Item_Category.Kit_id = Kojin_Kitchen_Master.Kit_id 


	
CREATE PROCEDURE PROC_Kojin_SelectItemUnitMaster
AS
	SELECT Unit_Code,Unit_Name,Unit_Status, Convert(Varchar(20),[Unit_DateTime],106) As [Unit_Date],LTRIM(RIGHT(CONVERT(VARCHAR(20),
	[Unit_DateTime],100),7)) AS [Unit_Time]  FROM Kojin_Item_Unit_Master

	
	