﻿****************************************
			Version Info:
****************************************

Version		-	V1.0.0
Date		-	Oct 2021
Created by	-	Shiv Lohar
Info		-	Base Version(Acumatica File Import)
----------------------------------------------------------------------------------------------------------------------

Version		-	V1.0.1
Date		-	17 Dec 2021
Created by	-	Shiv Lohar
Info		-	Base Version(Acumatica File Import)
Changes     -   Added CreditMemo type invoice upload & Image upload to Stock-Item
----------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------

Version		-	V1.0.2
Date		-	31 Jan 2022
Created by	-	Shiv Lohar
Info		-	Base Version(Acumatica File Import)
Changes     -   flow of uploading files & UI.
----------------------------------------------------------------------------------------------------------------------


# Acumatica File Attachment Import
##### Utility for Bulk Importing of Attachments to Acumatica


This utility takes a file from folder path with a combination of Record Type, Key values of that record, file path of the soon to be attachment, and uploads the file to the specified record.

## Configuration
## Add configuration to configuration tab.
## click configure to connect Acumatica instance.  


## To upload image to specific stock-item, need to put InventoryCD in 'BULK IMPORT' tab then select folder containing files to be uploaded.
Folder name does not matter here.

## To Upload image from 'Image Import' tab. name all images with associated InventoryCD (eg. InventoryCD.png). keep all images in the folder.
## select folder then click upload button.    

## Folder name formate should be below for PDF upload from 'PDF Import'.

folder name|
-------- 
SalesOrder |
PurchaseOrder |
ARInvoice |
APInvoice |
ARPayment |
APPayment |
CreditMemo | 

## Supported Records for 'PDF Import'. 

Doc Type |
-------- |
SalesOrder |
PurchaseOrder |
ARInvoice |
APInvoice |
ARPayment |
APPayment |
CreditMemo |
