// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.5.0.14890
//    <NameSpace>Modulo.Collect.OVAL.SystemCharacteristics</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings>Modulo.Collect.OVAL.Common.XmlSignatures;Modulo.Collect.OVAL.Common</CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Modulo.Collect.OVAL.SystemCharacteristics {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using Modulo.Collect.OVAL.Common.XmlSignatures;
    using Modulo.Collect.OVAL.Common;
    
    
    /// <summary>
    /// The system_characteristics element is the root of an OVAL System Characteristics Document, and must occur exactly once. Its purpose is to bind together the four major sections of a system characteristics file - generator, system_info, collected_objects, and system_data - which are the children of the oval_system_characteristics element.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=false)]
    public partial class oval_system_characteristics {
        
        private GeneratorType generatorField;
        
        private SystemInfoType system_infoField;
        
        private ObjectType[] collected_objectsField;
        
        private ItemType[] system_dataField;
        
        private SignatureType signatureField;
        
        /// <summary>
        /// The generator section must be present and provides information about when the system characteristics file was compiled and under what version.
        /// </summary>
        public GeneratorType generator {
            get {
                return this.generatorField;
            }
            set {
                this.generatorField = value;
            }
        }
        
        /// <summary>
        /// The required system_info element is used to record information about the system being described.
        /// </summary>
        public SystemInfoType system_info {
            get {
                return this.system_infoField;
            }
            set {
                this.system_infoField = value;
            }
        }
        
        /// <summary>
        /// The optional collected_objects section is used to associated the ids of the OVAL Objects collected with the system characteristics items that have been defined. The collected_objects section provides a listing of all the objects used to generate this system characteristics file.
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("object", IsNullable=false)]
        public ObjectType[] collected_objects {
            get {
                return this.collected_objectsField;
            }
            set {
                this.collected_objectsField = value;
            }
        }
        
        /// <summary>
        /// The optional system_data section defines the specific characteristics that have been collected from the system.
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemType[] system_data {
            get {
                return this.system_dataField;
            }
            set {
                this.system_dataField = value;
            }
        }
        
        /// <summary>
        /// The optional Signature element allows an XML Signature as defined by the W3C to be attached to the document. This allows authentication and data integrity to be provided to the user. Enveloped signatures are supported. More information about the official W3C Recommendation regarding XML digital signatures can be found at http://www.w3.org/TR/xmldsig-core/.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute("item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=false)]
    public partial class ItemType {
        
        private MessageType[] messageField;
        
        private string idField;
        
        private StatusEnumeration statusField;
        
        public ItemType() {
            this.statusField = StatusEnumeration.exists;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public MessageType[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(StatusEnumeration.exists)]
        public StatusEnumeration status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=false)]
    public enum StatusEnumeration {
        
        /// <remarks/>
        error,
        
        /// <remarks/>
        exists,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("does not exist")]
        doesnotexist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("not collected")]
        notcollected,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class ReferenceType {
        
        private string item_refField;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string item_ref {
            get {
                return this.item_refField;
            }
            set {
                this.item_refField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class VariableValueType {
        
        private string variable_idField;
        
        private string valueField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variable_id {
            get {
                return this.variable_idField;
            }
            set {
                this.variable_idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class ObjectType {
        
        private MessageType[] messageField;
        
        private VariableValueType[] variable_valueField;
        
        private ReferenceType[] referenceField;
        
        private string idField;
        
        private string versionField;
        
        private string variable_instanceField;
        
        private string commentField;
        
        private FlagEnumeration flagField;
        
        public ObjectType() {
            this.variable_instanceField = "1";
        }
        
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public MessageType[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("variable_value")]
        public VariableValueType[] variable_value {
            get {
                return this.variable_valueField;
            }
            set {
                this.variable_valueField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reference")]
        public ReferenceType[] reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string variable_instance {
            get {
                return this.variable_instanceField;
            }
            set {
                this.variable_instanceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FlagEnumeration flag {
            get {
                return this.flagField;
            }
            set {
                this.flagField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=false)]
    public enum FlagEnumeration {
        
        /// <remarks/>
        error,
        
        /// <remarks/>
        complete,
        
        /// <remarks/>
        incomplete,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("does not exist")]
        doesnotexist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("not collected")]
        notcollected,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("not applicable")]
        notapplicable,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class InterfaceType {
        
        private string interface_nameField;
        
        private string ip_addressField;
        
        private string mac_addressField;
        
        public string interface_name {
            get {
                return this.interface_nameField;
            }
            set {
                this.interface_nameField = value;
            }
        }
        
        public string ip_address {
            get {
                return this.ip_addressField;
            }
            set {
                this.ip_addressField = value;
            }
        }
        
        public string mac_address {
            get {
                return this.mac_addressField;
            }
            set {
                this.mac_addressField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class SystemInfoType {
        
        private string os_nameField;
        
        private string os_versionField;
        
        private string architectureField;
        
        private string primary_host_nameField;
        
        private InterfaceType[] interfacesField;
        
        private System.Xml.XmlElement[] anyField;
        
        public string os_name {
            get {
                return this.os_nameField;
            }
            set {
                this.os_nameField = value;
            }
        }
        
        public string os_version {
            get {
                return this.os_versionField;
            }
            set {
                this.os_versionField = value;
            }
        }
        
        public string architecture {
            get {
                return this.architectureField;
            }
            set {
                this.architectureField = value;
            }
        }
        
        public string primary_host_name {
            get {
                return this.primary_host_nameField;
            }
            set {
                this.primary_host_nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("interface", IsNullable=false)]
        public InterfaceType[] interfaces {
            get {
                return this.interfacesField;
            }
            set {
                this.interfacesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class InterfacesType {
        
        private InterfaceType[] interfaceField;
        
        [System.Xml.Serialization.XmlElementAttribute("interface")]
        public InterfaceType[] @interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class CollectedObjectsType {
        
        private ObjectType[] objectField;
        
        [System.Xml.Serialization.XmlElementAttribute("object")]
        public ObjectType[] @object {
            get {
                return this.objectField;
            }
            set {
                this.objectField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class SystemDataType {
        
        private ItemType[] itemField;
        
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public ItemType[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemEVRStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemIOSVersionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemFilesetRevisionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemVersionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemIntType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemFloatType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemBoolType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemBinaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemAnySimpleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemIPAddressStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemIPAddressType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public abstract partial class EntityItemSimpleBaseType {
        
        private string datatypeField;
        
        private bool maskField;
        
        private StatusEnumeration statusField;
        
        private string valueField;
        
        public EntityItemSimpleBaseType() {
            this.datatypeField = "string";
            this.maskField = false;
            this.statusField = StatusEnumeration.exists;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("string")]
        public string datatype {
            get {
                return this.datatypeField;
            }
            set {
                this.datatypeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool mask {
            get {
                return this.maskField;
            }
            set {
                this.maskField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(StatusEnumeration.exists)]
        public StatusEnumeration status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemEVRStringType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemIOSVersionType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemFilesetRevisionType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemVersionType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemStringType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemIntType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemFloatType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemBoolType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemBinaryType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemAnySimpleType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemIPAddressStringType : EntityItemSimpleBaseType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemIPAddressType : EntityItemSimpleBaseType {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityItemRecordType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public abstract partial class EntityItemComplexBaseType {
        
        private string datatypeField;
        
        private bool maskField;
        
        private StatusEnumeration statusField;
        
        public EntityItemComplexBaseType() {
            this.datatypeField = "string";
            this.maskField = false;
            this.statusField = StatusEnumeration.exists;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("string")]
        public string datatype {
            get {
                return this.datatypeField;
            }
            set {
                this.datatypeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool mask {
            get {
                return this.maskField;
            }
            set {
                this.maskField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(StatusEnumeration.exists)]
        public StatusEnumeration status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemRecordType : EntityItemComplexBaseType {
        
        private EntityItemFieldType[] fieldField;
        
        [System.Xml.Serialization.XmlElementAttribute("field")]
        public EntityItemFieldType[] field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=true)]
    public partial class EntityItemFieldType {
        
        private string nameField;
        
        private string datatypeField;
        
        private bool maskField;
        
        private StatusEnumeration statusField;
        
        private string valueField;
        
        public EntityItemFieldType() {
            this.datatypeField = "string";
            this.maskField = false;
            this.statusField = StatusEnumeration.exists;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("string")]
        public string datatype {
            get {
                return this.datatypeField;
            }
            set {
                this.datatypeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool mask {
            get {
                return this.maskField;
            }
            set {
                this.maskField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(StatusEnumeration.exists)]
        public StatusEnumeration status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
