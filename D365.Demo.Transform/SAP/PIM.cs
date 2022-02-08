﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Koden er generert av et verktøy.
//     Kjøretidsversjon:4.0.30319.42000
//
//     Endringer i denne filen kan føre til feil virkemåte, og vil gå tapt hvis
//     koden genereres på nytt.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace D365.Demo.Transform.SAP {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private string pimIDField;
        
        private uint sapSKUField;
        
        private string materialTypeField;
        
        private string industrySectorField;
        
        private string baseUoMField;
        
        private byte crmOnlyField;
        
        private bool crmOnlyFieldSpecified;
        
        private byte divisionField;
        
        private byte materialGrpField;
        
        private string externalMatGrpField;
        
        private string generalItemCatGrpField;
        
        private string manufacturerField;
        
        private string manuPartNumField;
        
        private string batchManField;
        
        private byte totalShelfLifeField;
        
        private byte minRemShelfLifeField;
        
        private byte cartonQuantityField;
        
        private byte transGrpField;
        
        private object expirationDateField;
        
        private byte storagePercantageField;
        
        private byte kolliField;
        
        private object internalCommentField;
        
        private ItemPlantData[] plantDataField;
        
        private ItemSalesData[] salesDataField;
        
        private ItemCountryInformation[] countryInformationField;
        
        private ItemTexts[] textsField;
        
        private ItemUnitsOfMeasure unitsOfMeasureField;
        
        /// <remarks/>
        public string PimID {
            get {
                return this.pimIDField;
            }
            set {
                this.pimIDField = value;
            }
        }
        
        /// <remarks/>
        public uint sapSKU {
            get {
                return this.sapSKUField;
            }
            set {
                this.sapSKUField = value;
            }
        }
        
        /// <remarks/>
        public string materialType {
            get {
                return this.materialTypeField;
            }
            set {
                this.materialTypeField = value;
            }
        }
        
        /// <remarks/>
        public string industrySector {
            get {
                return this.industrySectorField;
            }
            set {
                this.industrySectorField = value;
            }
        }
        
        /// <remarks/>
        public string baseUoM {
            get {
                return this.baseUoMField;
            }
            set {
                this.baseUoMField = value;
            }
        }
        
        /// <remarks/>
        public byte crmOnly {
            get {
                return this.crmOnlyField;
            }
            set {
                this.crmOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool crmOnlySpecified {
            get {
                return this.crmOnlyFieldSpecified;
            }
            set {
                this.crmOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public byte division {
            get {
                return this.divisionField;
            }
            set {
                this.divisionField = value;
            }
        }
        
        /// <remarks/>
        public byte materialGrp {
            get {
                return this.materialGrpField;
            }
            set {
                this.materialGrpField = value;
            }
        }
        
        /// <remarks/>
        public string externalMatGrp {
            get {
                return this.externalMatGrpField;
            }
            set {
                this.externalMatGrpField = value;
            }
        }
        
        /// <remarks/>
        public string generalItemCatGrp {
            get {
                return this.generalItemCatGrpField;
            }
            set {
                this.generalItemCatGrpField = value;
            }
        }
        
        /// <remarks/>
        public string manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }
        
        /// <remarks/>
        public string manuPartNum {
            get {
                return this.manuPartNumField;
            }
            set {
                this.manuPartNumField = value;
            }
        }
        
        /// <remarks/>
        public string batchMan {
            get {
                return this.batchManField;
            }
            set {
                this.batchManField = value;
            }
        }
        
        /// <remarks/>
        public byte totalShelfLife {
            get {
                return this.totalShelfLifeField;
            }
            set {
                this.totalShelfLifeField = value;
            }
        }
        
        /// <remarks/>
        public byte minRemShelfLife {
            get {
                return this.minRemShelfLifeField;
            }
            set {
                this.minRemShelfLifeField = value;
            }
        }
        
        /// <remarks/>
        public byte cartonQuantity {
            get {
                return this.cartonQuantityField;
            }
            set {
                this.cartonQuantityField = value;
            }
        }
        
        /// <remarks/>
        public byte transGrp {
            get {
                return this.transGrpField;
            }
            set {
                this.transGrpField = value;
            }
        }
        
        /// <remarks/>
        public object expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }
        
        /// <remarks/>
        public byte storagePercantage {
            get {
                return this.storagePercantageField;
            }
            set {
                this.storagePercantageField = value;
            }
        }
        
        /// <remarks/>
        public byte kolli {
            get {
                return this.kolliField;
            }
            set {
                this.kolliField = value;
            }
        }
        
        /// <remarks/>
        public object internalComment {
            get {
                return this.internalCommentField;
            }
            set {
                this.internalCommentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlantData")]
        public ItemPlantData[] PlantData {
            get {
                return this.plantDataField;
            }
            set {
                this.plantDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesData")]
        public ItemSalesData[] SalesData {
            get {
                return this.salesDataField;
            }
            set {
                this.salesDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CountryInformation")]
        public ItemCountryInformation[] CountryInformation {
            get {
                return this.countryInformationField;
            }
            set {
                this.countryInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Texts")]
        public ItemTexts[] Texts {
            get {
                return this.textsField;
            }
            set {
                this.textsField = value;
            }
        }
        
        /// <remarks/>
        public ItemUnitsOfMeasure UnitsOfMeasure {
            get {
                return this.unitsOfMeasureField;
            }
            set {
                this.unitsOfMeasureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ItemPlantData {
        
        private ushort plantField;
        
        private byte checkGrpAvailCheckField;
        
        private decimal commodityCodeField;
        
        private string countryOfOriginField;
        
        private ushort defStorLocForEPField;
        
        private bool defStorLocForEPFieldSpecified;
        
        private byte forecastModelField;
        
        private byte grProcessingTimeField;
        
        private byte histPeriodsField;
        
        private byte impExpMaterialGrpField;
        
        private string initializationField;
        
        private byte initializationPeriodField;
        
        private byte loadingGrpField;
        
        private string logHandlingGrpField;
        
        private string lotSizeField;
        
        private byte mrpControllerField;
        
        private string mrpTypeField;
        
        private byte minSafetyStockField;
        
        private object modelSelField;
        
        private decimal movingPriceField;
        
        private byte numOfForecastPeriodsField;
        
        private object optimLevelField;
        
        private object ppcPlanningCalField;
        
        private string periodIndField;
        
        private byte planDelTimeInDaysField;
        
        private byte plantSpecMatStatusField;
        
        private bool plantSpecMatStatusFieldSpecified;
        
        private string postToInspStockField;
        
        private string procurementTypeField;
        
        private byte purchGrpField;
        
        private byte reorderPointField;
        
        private byte roundingValueField;
        
        private byte safetyStockField;
        
        private byte schedMarginKeyForFloatsField;
        
        private string serNumProfileField;
        
        private byte serviceLevelField;
        
        private byte standPriceField;
        
        private byte trackLimitField;
        
        /// <remarks/>
        public ushort plant {
            get {
                return this.plantField;
            }
            set {
                this.plantField = value;
            }
        }
        
        /// <remarks/>
        public byte checkGrpAvailCheck {
            get {
                return this.checkGrpAvailCheckField;
            }
            set {
                this.checkGrpAvailCheckField = value;
            }
        }
        
        /// <remarks/>
        public decimal commodityCode {
            get {
                return this.commodityCodeField;
            }
            set {
                this.commodityCodeField = value;
            }
        }
        
        /// <remarks/>
        public string countryOfOrigin {
            get {
                return this.countryOfOriginField;
            }
            set {
                this.countryOfOriginField = value;
            }
        }
        
        /// <remarks/>
        public ushort defStorLocForEP {
            get {
                return this.defStorLocForEPField;
            }
            set {
                this.defStorLocForEPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defStorLocForEPSpecified {
            get {
                return this.defStorLocForEPFieldSpecified;
            }
            set {
                this.defStorLocForEPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public byte forecastModel {
            get {
                return this.forecastModelField;
            }
            set {
                this.forecastModelField = value;
            }
        }
        
        /// <remarks/>
        public byte grProcessingTime {
            get {
                return this.grProcessingTimeField;
            }
            set {
                this.grProcessingTimeField = value;
            }
        }
        
        /// <remarks/>
        public byte histPeriods {
            get {
                return this.histPeriodsField;
            }
            set {
                this.histPeriodsField = value;
            }
        }
        
        /// <remarks/>
        public byte impExpMaterialGrp {
            get {
                return this.impExpMaterialGrpField;
            }
            set {
                this.impExpMaterialGrpField = value;
            }
        }
        
        /// <remarks/>
        public string initialization {
            get {
                return this.initializationField;
            }
            set {
                this.initializationField = value;
            }
        }
        
        /// <remarks/>
        public byte initializationPeriod {
            get {
                return this.initializationPeriodField;
            }
            set {
                this.initializationPeriodField = value;
            }
        }
        
        /// <remarks/>
        public byte loadingGrp {
            get {
                return this.loadingGrpField;
            }
            set {
                this.loadingGrpField = value;
            }
        }
        
        /// <remarks/>
        public string logHandlingGrp {
            get {
                return this.logHandlingGrpField;
            }
            set {
                this.logHandlingGrpField = value;
            }
        }
        
        /// <remarks/>
        public string lotSize {
            get {
                return this.lotSizeField;
            }
            set {
                this.lotSizeField = value;
            }
        }
        
        /// <remarks/>
        public byte mrpController {
            get {
                return this.mrpControllerField;
            }
            set {
                this.mrpControllerField = value;
            }
        }
        
        /// <remarks/>
        public string mrpType {
            get {
                return this.mrpTypeField;
            }
            set {
                this.mrpTypeField = value;
            }
        }
        
        /// <remarks/>
        public byte minSafetyStock {
            get {
                return this.minSafetyStockField;
            }
            set {
                this.minSafetyStockField = value;
            }
        }
        
        /// <remarks/>
        public object modelSel {
            get {
                return this.modelSelField;
            }
            set {
                this.modelSelField = value;
            }
        }
        
        /// <remarks/>
        public decimal movingPrice {
            get {
                return this.movingPriceField;
            }
            set {
                this.movingPriceField = value;
            }
        }
        
        /// <remarks/>
        public byte numOfForecastPeriods {
            get {
                return this.numOfForecastPeriodsField;
            }
            set {
                this.numOfForecastPeriodsField = value;
            }
        }
        
        /// <remarks/>
        public object optimLevel {
            get {
                return this.optimLevelField;
            }
            set {
                this.optimLevelField = value;
            }
        }
        
        /// <remarks/>
        public object ppcPlanningCal {
            get {
                return this.ppcPlanningCalField;
            }
            set {
                this.ppcPlanningCalField = value;
            }
        }
        
        /// <remarks/>
        public string periodInd {
            get {
                return this.periodIndField;
            }
            set {
                this.periodIndField = value;
            }
        }
        
        /// <remarks/>
        public byte planDelTimeInDays {
            get {
                return this.planDelTimeInDaysField;
            }
            set {
                this.planDelTimeInDaysField = value;
            }
        }
        
        /// <remarks/>
        public byte plantSpecMatStatus {
            get {
                return this.plantSpecMatStatusField;
            }
            set {
                this.plantSpecMatStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plantSpecMatStatusSpecified {
            get {
                return this.plantSpecMatStatusFieldSpecified;
            }
            set {
                this.plantSpecMatStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string postToInspStock {
            get {
                return this.postToInspStockField;
            }
            set {
                this.postToInspStockField = value;
            }
        }
        
        /// <remarks/>
        public string procurementType {
            get {
                return this.procurementTypeField;
            }
            set {
                this.procurementTypeField = value;
            }
        }
        
        /// <remarks/>
        public byte purchGrp {
            get {
                return this.purchGrpField;
            }
            set {
                this.purchGrpField = value;
            }
        }
        
        /// <remarks/>
        public byte reorderPoint {
            get {
                return this.reorderPointField;
            }
            set {
                this.reorderPointField = value;
            }
        }
        
        /// <remarks/>
        public byte roundingValue {
            get {
                return this.roundingValueField;
            }
            set {
                this.roundingValueField = value;
            }
        }
        
        /// <remarks/>
        public byte safetyStock {
            get {
                return this.safetyStockField;
            }
            set {
                this.safetyStockField = value;
            }
        }
        
        /// <remarks/>
        public byte schedMarginKeyForFloats {
            get {
                return this.schedMarginKeyForFloatsField;
            }
            set {
                this.schedMarginKeyForFloatsField = value;
            }
        }
        
        /// <remarks/>
        public string serNumProfile {
            get {
                return this.serNumProfileField;
            }
            set {
                this.serNumProfileField = value;
            }
        }
        
        /// <remarks/>
        public byte serviceLevel {
            get {
                return this.serviceLevelField;
            }
            set {
                this.serviceLevelField = value;
            }
        }
        
        /// <remarks/>
        public byte standPrice {
            get {
                return this.standPriceField;
            }
            set {
                this.standPriceField = value;
            }
        }
        
        /// <remarks/>
        public byte trackLimit {
            get {
                return this.trackLimitField;
            }
            set {
                this.trackLimitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ItemSalesData {
        
        private ushort salesOrgField;
        
        private byte dcField;
        
        private byte accountAssignGrpField;
        
        private string itemCatGrpMatField;
        
        private byte warrantyField;
        
        private byte webStatusField;
        
        private bool webStatusFieldSpecified;
        
        private ushort deliveringPlantField;
        
        /// <remarks/>
        public ushort salesOrg {
            get {
                return this.salesOrgField;
            }
            set {
                this.salesOrgField = value;
            }
        }
        
        /// <remarks/>
        public byte dc {
            get {
                return this.dcField;
            }
            set {
                this.dcField = value;
            }
        }
        
        /// <remarks/>
        public byte accountAssignGrp {
            get {
                return this.accountAssignGrpField;
            }
            set {
                this.accountAssignGrpField = value;
            }
        }
        
        /// <remarks/>
        public string itemCatGrpMat {
            get {
                return this.itemCatGrpMatField;
            }
            set {
                this.itemCatGrpMatField = value;
            }
        }
        
        /// <remarks/>
        public byte warranty {
            get {
                return this.warrantyField;
            }
            set {
                this.warrantyField = value;
            }
        }
        
        /// <remarks/>
        public byte webStatus {
            get {
                return this.webStatusField;
            }
            set {
                this.webStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool webStatusSpecified {
            get {
                return this.webStatusFieldSpecified;
            }
            set {
                this.webStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ushort deliveringPlant {
            get {
                return this.deliveringPlantField;
            }
            set {
                this.deliveringPlantField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ItemCountryInformation {
        
        private string countryField;
        
        private byte mvaField;
        
        /// <remarks/>
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public byte mva {
            get {
                return this.mvaField;
            }
            set {
                this.mvaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ItemTexts {
        
        private string languageField;
        
        private string materialDescriptionField;
        
        private string webText1Field;
        
        private string webText2Field;
        
        /// <remarks/>
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        public string materialDescription {
            get {
                return this.materialDescriptionField;
            }
            set {
                this.materialDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string webText1 {
            get {
                return this.webText1Field;
            }
            set {
                this.webText1Field = value;
            }
        }
        
        /// <remarks/>
        public string webText2 {
            get {
                return this.webText2Field;
            }
            set {
                this.webText2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ItemUnitsOfMeasure {
        
        private byte denominatorForConvField;
        
        private string altUOMField;
        
        private byte numeratorConvToBUField;
        
        private string baseUoMField;
        
        private ulong eanField;
        
        private decimal lengthField;
        
        private decimal widthField;
        
        private decimal heightField;
        
        private decimal grossWeightField;
        
        private decimal netWeightField;
        
        private string weightUnitField;
        
        private string lowerLevelUoMField;
        
        /// <remarks/>
        public byte denominatorForConv {
            get {
                return this.denominatorForConvField;
            }
            set {
                this.denominatorForConvField = value;
            }
        }
        
        /// <remarks/>
        public string altUOM {
            get {
                return this.altUOMField;
            }
            set {
                this.altUOMField = value;
            }
        }
        
        /// <remarks/>
        public byte numeratorConvToBU {
            get {
                return this.numeratorConvToBUField;
            }
            set {
                this.numeratorConvToBUField = value;
            }
        }
        
        /// <remarks/>
        public string baseUoM {
            get {
                return this.baseUoMField;
            }
            set {
                this.baseUoMField = value;
            }
        }
        
        /// <remarks/>
        public ulong ean {
            get {
                return this.eanField;
            }
            set {
                this.eanField = value;
            }
        }
        
        /// <remarks/>
        public decimal length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        public decimal width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        public decimal height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <remarks/>
        public decimal grossWeight {
            get {
                return this.grossWeightField;
            }
            set {
                this.grossWeightField = value;
            }
        }
        
        /// <remarks/>
        public decimal netWeight {
            get {
                return this.netWeightField;
            }
            set {
                this.netWeightField = value;
            }
        }
        
        /// <remarks/>
        public string weightUnit {
            get {
                return this.weightUnitField;
            }
            set {
                this.weightUnitField = value;
            }
        }
        
        /// <remarks/>
        public string lowerLevelUoM {
            get {
                return this.lowerLevelUoMField;
            }
            set {
                this.lowerLevelUoMField = value;
            }
        }
    }
}