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
    public partial class EntityRelationships {
        
        private EntityRelationshipsEntityRelationship[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityRelationship", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EntityRelationshipsEntityRelationship[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EntityRelationshipsEntityRelationship {
        
        private string entityRelationshipTypeField;
        
        private string isCustomizableField;
        
        private string introducedVersionField;
        
        private string isHierarchicalField;
        
        private string referencingEntityNameField;
        
        private string referencedEntityNameField;
        
        private string cascadeAssignField;
        
        private string cascadeDeleteField;
        
        private string cascadeReparentField;
        
        private string cascadeShareField;
        
        private string cascadeUnshareField;
        
        private string cascadeRollupViewField;
        
        private string isValidForAdvancedFindField;
        
        private string referencingAttributeNameField;
        
        private EntityRelationshipsEntityRelationshipRelationshipDescriptionDescriptionsDescription[][] relationshipDescriptionField;
        
        private EntityRelationshipsEntityRelationshipEntityRelationshipRolesEntityRelationshipRole[] entityRelationshipRolesField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EntityRelationshipType {
            get {
                return this.entityRelationshipTypeField;
            }
            set {
                this.entityRelationshipTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IsCustomizable {
            get {
                return this.isCustomizableField;
            }
            set {
                this.isCustomizableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IntroducedVersion {
            get {
                return this.introducedVersionField;
            }
            set {
                this.introducedVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IsHierarchical {
            get {
                return this.isHierarchicalField;
            }
            set {
                this.isHierarchicalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReferencingEntityName {
            get {
                return this.referencingEntityNameField;
            }
            set {
                this.referencingEntityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReferencedEntityName {
            get {
                return this.referencedEntityNameField;
            }
            set {
                this.referencedEntityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CascadeAssign {
            get {
                return this.cascadeAssignField;
            }
            set {
                this.cascadeAssignField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CascadeDelete {
            get {
                return this.cascadeDeleteField;
            }
            set {
                this.cascadeDeleteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CascadeReparent {
            get {
                return this.cascadeReparentField;
            }
            set {
                this.cascadeReparentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CascadeShare {
            get {
                return this.cascadeShareField;
            }
            set {
                this.cascadeShareField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CascadeUnshare {
            get {
                return this.cascadeUnshareField;
            }
            set {
                this.cascadeUnshareField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CascadeRollupView {
            get {
                return this.cascadeRollupViewField;
            }
            set {
                this.cascadeRollupViewField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IsValidForAdvancedFind {
            get {
                return this.isValidForAdvancedFindField;
            }
            set {
                this.isValidForAdvancedFindField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReferencingAttributeName {
            get {
                return this.referencingAttributeNameField;
            }
            set {
                this.referencingAttributeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Descriptions", typeof(EntityRelationshipsEntityRelationshipRelationshipDescriptionDescriptionsDescription[]), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Description", typeof(EntityRelationshipsEntityRelationshipRelationshipDescriptionDescriptionsDescription), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false, NestingLevel=1)]
        public EntityRelationshipsEntityRelationshipRelationshipDescriptionDescriptionsDescription[][] RelationshipDescription {
            get {
                return this.relationshipDescriptionField;
            }
            set {
                this.relationshipDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("EntityRelationshipRole", typeof(EntityRelationshipsEntityRelationshipEntityRelationshipRolesEntityRelationshipRole), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public EntityRelationshipsEntityRelationshipEntityRelationshipRolesEntityRelationshipRole[] EntityRelationshipRoles {
            get {
                return this.entityRelationshipRolesField;
            }
            set {
                this.entityRelationshipRolesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EntityRelationshipsEntityRelationshipRelationshipDescriptionDescriptionsDescription {
        
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
    public partial class EntityRelationshipsEntityRelationshipEntityRelationshipRolesEntityRelationshipRole {
        
        private string navPaneDisplayOptionField;
        
        private string navPaneAreaField;
        
        private string navPaneOrderField;
        
        private string navigationPropertyNameField;
        
        private string relationshipRoleTypeField;
        
        private EntityRelationshipsEntityRelationshipEntityRelationshipRolesEntityRelationshipRoleCustomLabelsCustomLabel[] customLabelsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NavPaneDisplayOption {
            get {
                return this.navPaneDisplayOptionField;
            }
            set {
                this.navPaneDisplayOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NavPaneArea {
            get {
                return this.navPaneAreaField;
            }
            set {
                this.navPaneAreaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NavPaneOrder {
            get {
                return this.navPaneOrderField;
            }
            set {
                this.navPaneOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NavigationPropertyName {
            get {
                return this.navigationPropertyNameField;
            }
            set {
                this.navigationPropertyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RelationshipRoleType {
            get {
                return this.relationshipRoleTypeField;
            }
            set {
                this.relationshipRoleTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomLabel", typeof(EntityRelationshipsEntityRelationshipEntityRelationshipRolesEntityRelationshipRoleCustomLabelsCustomLabel), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public EntityRelationshipsEntityRelationshipEntityRelationshipRolesEntityRelationshipRoleCustomLabelsCustomLabel[] CustomLabels {
            get {
                return this.customLabelsField;
            }
            set {
                this.customLabelsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EntityRelationshipsEntityRelationshipEntityRelationshipRolesEntityRelationshipRoleCustomLabelsCustomLabel {
        
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
}