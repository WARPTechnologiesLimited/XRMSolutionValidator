﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace WARP.XrmSolutionValidator.Core.XrmModels {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class LocalizedNames {
        
        private LocalizedNamesLocalizedName[] localizedNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocalizedName", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LocalizedNamesLocalizedName[] LocalizedName {
            get {
                return this.localizedNameField;
            }
            set {
                this.localizedNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LocalizedNamesLocalizedName {
        
        private string descriptionField;
        
        private string languagecodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string languagecode {
            get {
                return this.languagecodeField;
            }
            set {
                this.languagecodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ImportExportXml {
        
        private ImportExportXmlSolutionManifest[] solutionManifestField;
        
        private string versionField;
        
        private string solutionPackageVersionField;
        
        private string languagecodeField;
        
        private string generatedByField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SolutionManifest", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImportExportXmlSolutionManifest[] SolutionManifest {
            get {
                return this.solutionManifestField;
            }
            set {
                this.solutionManifestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SolutionPackageVersion {
            get {
                return this.solutionPackageVersionField;
            }
            set {
                this.solutionPackageVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string languagecode {
            get {
                return this.languagecodeField;
            }
            set {
                this.languagecodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string generatedBy {
            get {
                return this.generatedByField;
            }
            set {
                this.generatedByField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ImportExportXmlSolutionManifest {
        
        private string uniqueNameField;
        
        private string descriptionsField;
        
        private string versionField;
        
        private string managedField;

        private LocalizedNamesLocalizedName[] localizedNamesField;

        private ImportExportXmlSolutionManifestPublisher[] publisherField;

        private ImportExportXmlSolutionManifestRootComponentsRootComponent[] rootComponentsField;

        private ImportExportXmlSolutionManifestMissingDependenciesMissingDependency[] missingDependenciesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UniqueName {
            get {
                return this.uniqueNameField;
            }
            set {
                this.uniqueNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Descriptions {
            get {
                return this.descriptionsField;
            }
            set {
                this.descriptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Managed {
            get {
                return this.managedField;
            }
            set {
                this.managedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LocalizedName", typeof(LocalizedNamesLocalizedName), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public LocalizedNamesLocalizedName[] LocalizedNames
        {
            get
            {
                return this.localizedNamesField;
            }
            set
            {
                this.localizedNamesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Publisher", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImportExportXmlSolutionManifestPublisher[] Publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RootComponent", typeof(ImportExportXmlSolutionManifestRootComponentsRootComponent), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public ImportExportXmlSolutionManifestRootComponentsRootComponent[] RootComponents
        {
            get
            {
                return this.rootComponentsField;
            }
            set
            {
                this.rootComponentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("MissingDependency", typeof(ImportExportXmlSolutionManifestMissingDependenciesMissingDependency), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public ImportExportXmlSolutionManifestMissingDependenciesMissingDependency[] MissingDependencies
        {
            get
            {
                return this.missingDependenciesField;
            }
            set
            {
                this.missingDependenciesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ImportExportXmlSolutionManifestPublisher {
        
        private string uniqueNameField;
        
        private string descriptionsField;
        
        private string eMailAddressField;
        
        private string supportingWebsiteUrlField;
        
        private string customizationPrefixField;
        
        private string customizationOptionValuePrefixField;

        private LocalizedNamesLocalizedName[] localizedNamesField;

        private ImportExportXmlSolutionManifestPublisherAddressesAddress[] addressesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UniqueName {
            get {
                return this.uniqueNameField;
            }
            set {
                this.uniqueNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Descriptions {
            get {
                return this.descriptionsField;
            }
            set {
                this.descriptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMailAddress {
            get {
                return this.eMailAddressField;
            }
            set {
                this.eMailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupportingWebsiteUrl {
            get {
                return this.supportingWebsiteUrlField;
            }
            set {
                this.supportingWebsiteUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CustomizationPrefix {
            get {
                return this.customizationPrefixField;
            }
            set {
                this.customizationPrefixField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CustomizationOptionValuePrefix {
            get {
                return this.customizationOptionValuePrefixField;
            }
            set {
                this.customizationOptionValuePrefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LocalizedName", typeof(LocalizedNamesLocalizedName), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public LocalizedNamesLocalizedName[] LocalizedNames
        {
            get
            {
                return this.localizedNamesField;
            }
            set
            {
                this.localizedNamesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Address", typeof(ImportExportXmlSolutionManifestPublisherAddressesAddress), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public ImportExportXmlSolutionManifestPublisherAddressesAddress[] Addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ImportExportXmlSolutionManifestPublisherAddressesAddress {
        
        private string addressNumberField;
        
        private string addressTypeCodeField;
        
        private string cityField;
        
        private string countyField;
        
        private string countryField;
        
        private string faxField;
        
        private string freightTermsCodeField;
        
        private string importSequenceNumberField;
        
        private string latitudeField;
        
        private string line1Field;
        
        private string line2Field;
        
        private string line3Field;
        
        private string longitudeField;
        
        private string nameField;
        
        private string postalCodeField;
        
        private string postOfficeBoxField;
        
        private string primaryContactNameField;
        
        private string shippingMethodCodeField;
        
        private string stateOrProvinceField;
        
        private string telephone1Field;
        
        private string telephone2Field;
        
        private string telephone3Field;
        
        private string timeZoneRuleVersionNumberField;
        
        private string uPSZoneField;
        
        private string uTCOffsetField;
        
        private string uTCConversionTimeZoneCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AddressNumber {
            get {
                return this.addressNumberField;
            }
            set {
                this.addressNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AddressTypeCode {
            get {
                return this.addressTypeCodeField;
            }
            set {
                this.addressTypeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string County {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FreightTermsCode {
            get {
                return this.freightTermsCodeField;
            }
            set {
                this.freightTermsCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ImportSequenceNumber {
            get {
                return this.importSequenceNumberField;
            }
            set {
                this.importSequenceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line1 {
            get {
                return this.line1Field;
            }
            set {
                this.line1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line2 {
            get {
                return this.line2Field;
            }
            set {
                this.line2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line3 {
            get {
                return this.line3Field;
            }
            set {
                this.line3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostOfficeBox {
            get {
                return this.postOfficeBoxField;
            }
            set {
                this.postOfficeBoxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrimaryContactName {
            get {
                return this.primaryContactNameField;
            }
            set {
                this.primaryContactNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ShippingMethodCode {
            get {
                return this.shippingMethodCodeField;
            }
            set {
                this.shippingMethodCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StateOrProvince {
            get {
                return this.stateOrProvinceField;
            }
            set {
                this.stateOrProvinceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Telephone1 {
            get {
                return this.telephone1Field;
            }
            set {
                this.telephone1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Telephone2 {
            get {
                return this.telephone2Field;
            }
            set {
                this.telephone2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Telephone3 {
            get {
                return this.telephone3Field;
            }
            set {
                this.telephone3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TimeZoneRuleVersionNumber {
            get {
                return this.timeZoneRuleVersionNumberField;
            }
            set {
                this.timeZoneRuleVersionNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UPSZone {
            get {
                return this.uPSZoneField;
            }
            set {
                this.uPSZoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UTCOffset {
            get {
                return this.uTCOffsetField;
            }
            set {
                this.uTCOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UTCConversionTimeZoneCode {
            get {
                return this.uTCConversionTimeZoneCodeField;
            }
            set {
                this.uTCConversionTimeZoneCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ImportExportXmlSolutionManifestRootComponentsRootComponent {
        
        private string typeField;
        
        private string schemaNameField;
        
        private string behaviorField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemaName {
            get {
                return this.schemaNameField;
            }
            set {
                this.schemaNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string behavior {
            get {
                return this.behaviorField;
            }
            set {
                this.behaviorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ImportExportXmlSolutionManifestMissingDependenciesMissingDependency {
        
        private ImportExportXmlSolutionManifestMissingDependenciesMissingDependencyRequired[] requiredField;
        
        private ImportExportXmlSolutionManifestMissingDependenciesMissingDependencyDependent[] dependentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Required", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImportExportXmlSolutionManifestMissingDependenciesMissingDependencyRequired[] Required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dependent", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImportExportXmlSolutionManifestMissingDependenciesMissingDependencyDependent[] Dependent {
            get {
                return this.dependentField;
            }
            set {
                this.dependentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ImportExportXmlSolutionManifestMissingDependenciesMissingDependencyRequired {
        
        private string keyField;
        
        private string typeField;
        
        private string schemaNameField;
        
        private string displayNameField;
        
        private string solutionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemaName {
            get {
                return this.schemaNameField;
            }
            set {
                this.schemaNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string solution {
            get {
                return this.solutionField;
            }
            set {
                this.solutionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ImportExportXmlSolutionManifestMissingDependenciesMissingDependencyDependent {
        
        private string keyField;
        
        private string typeField;
        
        private string schemaNameField;
        
        private string displayNameField;
        
        private string parentDisplayNameField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemaName {
            get {
                return this.schemaNameField;
            }
            set {
                this.schemaNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentDisplayName {
            get {
                return this.parentDisplayNameField;
            }
            set {
                this.parentDisplayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class NewDataSet {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImportExportXml", typeof(ImportExportXml))]
        [System.Xml.Serialization.XmlElementAttribute("LocalizedNames", typeof(LocalizedNames))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}