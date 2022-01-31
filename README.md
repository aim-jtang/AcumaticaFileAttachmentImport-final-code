# Acumatica File Attachment Import
##### Utility for Bulk Importing of Attachments to Acumatica

## Developer : Shiv
## Version : v1.0.2
## Added : Changed UI
## Added : Changed flow of uploading files.
## date  : 31.01.2022


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
