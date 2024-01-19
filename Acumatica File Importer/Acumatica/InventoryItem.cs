using System;
using System.Collections.Generic;

namespace Acumatica_File_Importer.Acumatica
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ABCCode
    {
    }

    public class AutoIncrementalValue
    {
    }

    public class AverageCost
    {
        public double value { get; set; }
    }

    public class BaseUOM
    {
        public string value { get; set; }
    }

    public class COGSAccount
    {
        public string value { get; set; }
    }

    public class COGSSubaccount
    {
        public string value { get; set; }
    }

    public class Content
    {
        public string value { get; set; }
    }

    public class CurrentStdCost
    {
        public double value { get; set; }
    }

    public class DefaultIssueLocationID
    {
        public string value { get; set; }
    }

    public class DefaultPrice
    {
        public double value { get; set; }
    }

    public class DefaultReceiptLocationID
    {
        public string value { get; set; }
    }

    public class DefaultWarehouseID
    {
        public string value { get; set; }
    }

    public class DeferralAccount
    {
    }

    public class DeferralSubaccount
    {
    }

    public class Description
    {
        public string value { get; set; }
    }

    public class DimensionVolume
    {
        public double value { get; set; }
    }

    public class DimensionWeight
    {
        public double value { get; set; }
    }

    public class DiscountAccount
    {
    }

    public class DiscountSubaccount
    {
    }

    public class ImageUrl
    {
        public string value { get; set; }
    }

    public class InventoryAccount
    {
        public string value { get; set; }
    }

    public class InventoryID
    {
        public string value { get; set; }
    }

    public class InventorySubaccount
    {
        public string value { get; set; }
    }

    public class IsAKit
    {
        public bool value { get; set; }
    }

    public class ItemClass
    {
        public string value { get; set; }
    }

    public class ItemStatus
    {
        public string value { get; set; }
    }

    public class ItemType
    {
        public string value { get; set; }
    }

    public class LandedCostVarianceAccount
    {
        public string value { get; set; }
    }

    public class LandedCostVarianceSubaccount
    {
        public string value { get; set; }
    }

    public class LastCost
    {
        public double value { get; set; }
    }

    public class LastModified
    {
        public DateTime value { get; set; }
    }

    public class LastStdCost
    {
        public double value { get; set; }
    }

    public class LotSerialClass
    {
        public string value { get; set; }
    }

    public class Markup
    {
        public double value { get; set; }
    }

    public class MaxCost
    {
        public double value { get; set; }
    }

    public class MinCost
    {
        public double value { get; set; }
    }

    public class MinMarkup
    {
        public double value { get; set; }
    }

    public class MSRP
    {
        public double value { get; set; }
    }

    public class PackagingOption
    {
        public string value { get; set; }
    }

    public class PackSeparately
    {
        public bool value { get; set; }
    }

    public class PendingStdCost
    {
        public double value { get; set; }
    }

    public class POAccrualAccount
    {
        public string value { get; set; }
    }

    public class POAccrualSubaccount
    {
        public string value { get; set; }
    }

    public class PostingClass
    {
        public string value { get; set; }
    }

    public class PriceClass
    {
    }

    public class PriceManager
    {
    }

    public class PriceWorkgroup
    {
    }

    public class ProductManager
    {
    }

    public class ProductWorkgroup
    {
    }

    public class PurchasePriceVarianceAccount
    {
        public string value { get; set; }
    }

    public class PurchasePriceVarianceSubaccount
    {
        public string value { get; set; }
    }

    public class PurchaseUOM
    {
        public string value { get; set; }
    }

    public class ReasonCodeSubaccount
    {
        public string value { get; set; }
    }

    public class SalesAccount
    {
        public string value { get; set; }
    }

    public class SalesSubaccount
    {
        public string value { get; set; }
    }

    public class SalesUOM
    {
        public string value { get; set; }
    }

    public class StandardCostRevaluationAccount
    {
        public string value { get; set; }
    }

    public class StandardCostRevaluationSubaccount
    {
        public string value { get; set; }
    }

    public class StandardCostVarianceAccount
    {
        public string value { get; set; }
    }

    public class StandardCostVarianceSubaccount
    {
        public string value { get; set; }
    }

    public class SubjectToCommission
    {
        public bool value { get; set; }
    }

    public class TaxCategory
    {
        public string value { get; set; }
    }

    public class ValuationMethod
    {
        public string value { get; set; }
    }

    public class VolumeUOM
    {
        public string value { get; set; }
    }

    public class WeightUOM
    {
        public string value { get; set; }
    }

    public class Custom
    {
    }

    public class File
    {
        public string id { get; set; }
        public string filename { get; set; }
        public string href { get; set; }
    }

    public class InventoryItem
    {
        public string id { get; set; }
        public int rowNumber { get; set; }
        public string note { get; set; }
        public ABCCode ABCCode { get; set; }
        public AutoIncrementalValue AutoIncrementalValue { get; set; }
        public AverageCost AverageCost { get; set; }
        public BaseUOM BaseUOM { get; set; }
        public COGSAccount COGSAccount { get; set; }
        public COGSSubaccount COGSSubaccount { get; set; }
        public Content Content { get; set; }
        public CurrentStdCost CurrentStdCost { get; set; }
        public DefaultIssueLocationID DefaultIssueLocationID { get; set; }
        public DefaultPrice DefaultPrice { get; set; }
        public DefaultReceiptLocationID DefaultReceiptLocationID { get; set; }
        public DefaultWarehouseID DefaultWarehouseID { get; set; }
        public DeferralAccount DeferralAccount { get; set; }
        public DeferralSubaccount DeferralSubaccount { get; set; }
        public Description Description { get; set; }
        public DimensionVolume DimensionVolume { get; set; }
        public DimensionWeight DimensionWeight { get; set; }
        public DiscountAccount DiscountAccount { get; set; }
        public DiscountSubaccount DiscountSubaccount { get; set; }
        public ImageUrl ImageUrl { get; set; }
        public InventoryAccount InventoryAccount { get; set; }
        public InventoryID InventoryID { get; set; }
        public InventorySubaccount InventorySubaccount { get; set; }
        public IsAKit IsAKit { get; set; }
        public ItemClass ItemClass { get; set; }
        public ItemStatus ItemStatus { get; set; }
        public ItemType ItemType { get; set; }
        public LandedCostVarianceAccount LandedCostVarianceAccount { get; set; }
        public LandedCostVarianceSubaccount LandedCostVarianceSubaccount { get; set; }
        public LastCost LastCost { get; set; }
        public LastModified LastModified { get; set; }
        public LastStdCost LastStdCost { get; set; }
        public LotSerialClass LotSerialClass { get; set; }
        public Markup Markup { get; set; }
        public MaxCost MaxCost { get; set; }
        public MinCost MinCost { get; set; }
        public MinMarkup MinMarkup { get; set; }
        public MSRP MSRP { get; set; }
        public PackagingOption PackagingOption { get; set; }
        public PackSeparately PackSeparately { get; set; }
        public PendingStdCost PendingStdCost { get; set; }
        public POAccrualAccount POAccrualAccount { get; set; }
        public POAccrualSubaccount POAccrualSubaccount { get; set; }
        public PostingClass PostingClass { get; set; }
        public PriceClass PriceClass { get; set; }
        public PriceManager PriceManager { get; set; }
        public PriceWorkgroup PriceWorkgroup { get; set; }
        public ProductManager ProductManager { get; set; }
        public ProductWorkgroup ProductWorkgroup { get; set; }
        public PurchasePriceVarianceAccount PurchasePriceVarianceAccount { get; set; }
        public PurchasePriceVarianceSubaccount PurchasePriceVarianceSubaccount { get; set; }
        public PurchaseUOM PurchaseUOM { get; set; }
        public ReasonCodeSubaccount ReasonCodeSubaccount { get; set; }
        public SalesAccount SalesAccount { get; set; }
        public SalesSubaccount SalesSubaccount { get; set; }
        public SalesUOM SalesUOM { get; set; }
        public StandardCostRevaluationAccount StandardCostRevaluationAccount { get; set; }
        public StandardCostRevaluationSubaccount StandardCostRevaluationSubaccount { get; set; }
        public StandardCostVarianceAccount StandardCostVarianceAccount { get; set; }
        public StandardCostVarianceSubaccount StandardCostVarianceSubaccount { get; set; }
        public SubjectToCommission SubjectToCommission { get; set; }
        public TaxCategory TaxCategory { get; set; }
        public ValuationMethod ValuationMethod { get; set; }
        public VolumeUOM VolumeUOM { get; set; }
        public WeightUOM WeightUOM { get; set; }
        public Custom custom { get; set; }
        public List<File> files { get; set; }
    }


}
