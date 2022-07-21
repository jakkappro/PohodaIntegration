#pragma warning disable
namespace PrehomeXMLFeedIntegration.Pohoda
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Runtime.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/data.xsd")]
    [XmlRootAttribute("dataPack", Namespace="http://www.stormware.cz/schema/version_2/data.xsd", IsNullable=false)]
    public partial class dataPackType
    {
        #region Private fields
        private transformationType _transformation;
        private List<dataPackItemType> _dataPackItem;
        private dataPackVersionType _version;
        private string _id;
        private string _ico;
        private string _key;
        private periodType1 _period;
        private string _application;
        private string _programVersion;
        private string _note;
        private static XmlSerializer _serializerXml;
        #endregion
        
        public dataPackType()
        {
            _dataPackItem = new List<dataPackItemType>();
            _transformation = new transformationType();
        }
        
        public transformationType transformation
        {
            get
            {
                return _transformation;
            }
            set
            {
                _transformation = value;
            }
        }
        
        [XmlElement("dataPackItem")]
        public List<dataPackItemType> dataPackItem
        {
            get
            {
                return _dataPackItem;
            }
            set
            {
                _dataPackItem = value;
            }
        }
        
        [XmlAttribute]
        public dataPackVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlAttribute]
        public string ico
        {
            get
            {
                return _ico;
            }
            set
            {
                _ico = value;
            }
        }
        
        [XmlAttribute]
        public string key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }
        
        [XmlAttribute]
        public periodType1 period
        {
            get
            {
                return _period;
            }
            set
            {
                _period = value;
            }
        }
        
        [XmlAttribute]
        public string application
        {
            get
            {
                return _application;
            }
            set
            {
                _application = value;
            }
        }
        
        [XmlAttribute]
        public string programVersion
        {
            get
            {
                return _programVersion;
            }
            set
            {
                _programVersion = value;
            }
        }
        
        [XmlAttribute]
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        private static XmlSerializer SerializerXml
        {
            get
            {
                if ((_serializerXml == null))
                {
                    _serializerXml = new XmlSerializerFactory().CreateSerializer(typeof(dataPackType));
                }
                return _serializerXml;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serialize dataPackType object
        /// </summary>
        /// <returns>XML value</returns>
        public virtual string Serialize()
        {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try
            {
                memoryStream = new MemoryStream();
                System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
                System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
                SerializerXml.Serialize(xmlWriter, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes dataPackType object
        /// </summary>
        /// <param name="input">string to deserialize</param>
        /// <param name="obj">Output dataPackType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out dataPackType obj, out Exception exception)
        {
            exception = null;
            obj = default(dataPackType);
            try
            {
                obj = Deserialize(input);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string input, out dataPackType obj)
        {
            Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public static dataPackType Deserialize(string input)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(input);
                return ((dataPackType)(SerializerXml.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static dataPackType Deserialize(Stream s)
        {
            return ((dataPackType)(SerializerXml.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current dataPackType object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName)
        {
            StreamWriter streamWriter = null;
            try
            {
                string dataString = Serialize();
                FileInfo outputFile = new FileInfo(fileName);
                streamWriter = outputFile.CreateText();
                streamWriter.WriteLine(dataString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an dataPackType object
        /// </summary>
        /// <param name="fileName">File to load and deserialize</param>
        /// <param name="obj">Output dataPackType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out dataPackType obj, out Exception exception)
        {
            exception = null;
            obj = default(dataPackType);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out dataPackType obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static dataPackType LoadFromFile(string fileName)
        {
            FileStream file = null;
            StreamReader sr = null;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(file);
                string dataString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(dataString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/data.xsd")]
    public partial class transformationType
    {
        #region Private fields
        private string _input;
        private string _output;
        #endregion
        
        public string input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
            }
        }
        
        public string output
        {
            get
            {
                return _output;
            }
            set
            {
                _output = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestServiceType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestServiceType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterDocsType
    {
        #region Private fields
        private string _id;
        private System.DateTime _dateFrom;
        private System.DateTime _dateTill;
        private List<numberType1> _selectedNumbers;
        private List<string> _selectedCompanys;
        private List<string> _selectedIco;
        private System.DateTime _lastChanges;
        #endregion
        
        public filterDocsType()
        {
            _selectedIco = new List<string>();
            _selectedCompanys = new List<string>();
            _selectedNumbers = new List<numberType1>();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateFrom
        {
            get
            {
                return _dateFrom;
            }
            set
            {
                _dateFrom = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTill
        {
            get
            {
                return _dateTill;
            }
            set
            {
                _dateTill = value;
            }
        }
        
        [XmlArrayItemAttribute("number", IsNullable=false)]
        public List<numberType1> selectedNumbers
        {
            get
            {
                return _selectedNumbers;
            }
            set
            {
                _selectedNumbers = value;
            }
        }
        
        [XmlArrayItemAttribute("company", IsNullable=false)]
        public List<string> selectedCompanys
        {
            get
            {
                return _selectedCompanys;
            }
            set
            {
                _selectedCompanys = value;
            }
        }
        
        [XmlArrayItemAttribute("ico", IsNullable=false)]
        public List<string> selectedIco
        {
            get
            {
                return _selectedIco;
            }
            set
            {
                _selectedIco = value;
            }
        }
        
        public System.DateTime lastChanges
        {
            get
            {
                return _lastChanges;
            }
            set
            {
                _lastChanges = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="numberType", Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class numberType1
    {
        #region Private fields
        private string _id;
        private string _ids;
        private numberTypeNumberRequested _numberRequested;
        #endregion
        
        public numberType1()
        {
            _numberRequested = new numberTypeNumberRequested();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public numberTypeNumberRequested numberRequested
        {
            get
            {
                return _numberRequested;
            }
            set
            {
                _numberRequested = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class numberTypeNumberRequested
    {
        #region Private fields
        private boolean _checkDuplicity;
        private string _value;
        #endregion
        
        public numberTypeNumberRequested()
        {
            _checkDuplicity = boolean.@true;
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@true)]
        public boolean checkDuplicity
        {
            get
            {
                return _checkDuplicity;
            }
            set
            {
                _checkDuplicity = value;
            }
        }
        
        [XmlTextAttribute]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum boolean
    {
        @true,
        @false,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listServiceRequestType
    {
        #region Private fields
        private List<requestServiceType> _requestService;
        private listServiceVerType _version;
        private serviceVersionType _serviceVersion;
        #endregion
        
        public listServiceRequestType()
        {
            _requestService = new List<requestServiceType>();
        }
        
        [XmlElement("requestService")]
        public List<requestServiceType> requestService
        {
            get
            {
                return _requestService;
            }
            set
            {
                _requestService = value;
            }
        }
        
        [XmlAttribute]
        public listServiceVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public serviceVersionType serviceVersion
        {
            get
            {
                return _serviceVersion;
            }
            set
            {
                _serviceVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listServiceVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/service.xsd")]
    public enum serviceVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterIndividualPriceType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private string _company;
        private string _name;
        private string _city;
        private string _street;
        private string _zip;
        private string _ico;
        private string _dic;
        private numberADType _number;
        private System.DateTime _lastChanges;
        private System.DateTime _lastChangesIndividualPrice;
        #endregion
        
        public filterIndividualPriceType()
        {
            _number = new numberADType();
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        
        public string street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        
        public string zip
        {
            get
            {
                return _zip;
            }
            set
            {
                _zip = value;
            }
        }
        
        public string ico
        {
            get
            {
                return _ico;
            }
            set
            {
                _ico = value;
            }
        }
        
        public string dic
        {
            get
            {
                return _dic;
            }
            set
            {
                _dic = value;
            }
        }
        
        public numberADType number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public System.DateTime lastChanges
        {
            get
            {
                return _lastChanges;
            }
            set
            {
                _lastChanges = value;
            }
        }
        
        public System.DateTime lastChangesIndividualPrice
        {
            get
            {
                return _lastChangesIndividualPrice;
            }
            set
            {
                _lastChangesIndividualPrice = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class extIdType
    {
        #region Private fields
        private string _ids;
        private string _exSystemName;
        private string _exSystemText;
        #endregion
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public string exSystemName
        {
            get
            {
                return _exSystemName;
            }
            set
            {
                _exSystemName = value;
            }
        }
        
        public string exSystemText
        {
            get
            {
                return _exSystemText;
            }
            set
            {
                _exSystemText = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class numberADType
    {
        #region Private fields
        private string _id;
        private string _ids;
        private numberADTypeNumberRequested _numberRequested;
        #endregion
        
        public numberADType()
        {
            _numberRequested = new numberADTypeNumberRequested();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public numberADTypeNumberRequested numberRequested
        {
            get
            {
                return _numberRequested;
            }
            set
            {
                _numberRequested = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class numberADTypeNumberRequested
    {
        #region Private fields
        private boolean _checkDuplicity;
        private string _value;
        #endregion
        
        public numberADTypeNumberRequested()
        {
            _checkDuplicity = boolean.@true;
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@true)]
        public boolean checkDuplicity
        {
            get
            {
                return _checkDuplicity;
            }
            set
            {
                _checkDuplicity = value;
            }
        }
        
        [XmlTextAttribute]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestIndividualPriceType
    {
        #region Private fields
        private filterIndividualPriceType _filter;
        private string _userFilterName;
        #endregion
        
        public requestIndividualPriceType()
        {
            _filter = new filterIndividualPriceType();
        }
        
        public filterIndividualPriceType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listIndividualPriceRequestType
    {
        #region Private fields
        private List<requestIndividualPriceType> _requestIndividualPrice;
        private listIndividualPriceRequestVerType _version;
        private idpVersionType _individualPriceVersion;
        private string _extSystem;
        #endregion
        
        public listIndividualPriceRequestType()
        {
            _requestIndividualPrice = new List<requestIndividualPriceType>();
        }
        
        [XmlElement("requestIndividualPrice")]
        public List<requestIndividualPriceType> requestIndividualPrice
        {
            get
            {
                return _requestIndividualPrice;
            }
            set
            {
                _requestIndividualPrice = value;
            }
        }
        
        [XmlAttribute]
        public listIndividualPriceRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public idpVersionType individualPriceVersion
        {
            get
            {
                return _individualPriceVersion;
            }
            set
            {
                _individualPriceVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listIndividualPriceRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/individualPrice.xsd")]
    public enum idpVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestRecyclingContribType
    {
        #region Private fields
        private filterIDType _filter;
        private string _userFilterName;
        #endregion
        
        public requestRecyclingContribType()
        {
            _filter = new filterIDType();
        }
        
        public filterIDType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterIDType
    {
        #region Private fields
        private string _id;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listRecyclingContribRequestType
    {
        #region Private fields
        private List<requestRecyclingContribType> _requestRecyclingContrib;
        private listRecyclingContribVerType _version;
        private recVersionType _recyclingContribVersion;
        #endregion
        
        public listRecyclingContribRequestType()
        {
            _requestRecyclingContrib = new List<requestRecyclingContribType>();
        }
        
        [XmlElement("requestRecyclingContrib")]
        public List<requestRecyclingContribType> requestRecyclingContrib
        {
            get
            {
                return _requestRecyclingContrib;
            }
            set
            {
                _requestRecyclingContrib = value;
            }
        }
        
        [XmlAttribute]
        public listRecyclingContribVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public recVersionType recyclingContribVersion
        {
            get
            {
                return _recyclingContribVersion;
            }
            set
            {
                _recyclingContribVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listRecyclingContribVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/recyclingContrib.xsd")]
    public enum recVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class stockItemMovementType
    {
        #region Private fields
        private refTypeStorage _storage;
        private stockItemMovementTypeStockItem _stockItem;
        #endregion
        
        public stockItemMovementType()
        {
            _stockItem = new stockItemMovementTypeStockItem();
            _storage = new refTypeStorage();
        }
        
        public refTypeStorage storage
        {
            get
            {
                return _storage;
            }
            set
            {
                _storage = value;
            }
        }
        
        public stockItemMovementTypeStockItem stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class refTypeStorage
    {
        #region Private fields
        private string _id;
        private string _ids;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class stockItemMovementTypeStockItem
    {
        #region Private fields
        private string _id;
        private string _eAN;
        private string _ids;
        private string _name;
        private string _nameComplement;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string EAN
        {
            get
            {
                return _eAN;
            }
            set
            {
                _eAN = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string nameComplement
        {
            get
            {
                return _nameComplement;
            }
            set
            {
                _nameComplement = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterMovementType
    {
        #region Private fields
        private string _id;
        private stockItemMovementType _stockItem;
        private System.DateTime _dateFrom;
        private System.DateTime _dateTill;
        private agendaMovementType _agenda;
        #endregion
        
        public filterMovementType()
        {
            _stockItem = new stockItemMovementType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public stockItemMovementType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateFrom
        {
            get
            {
                return _dateFrom;
            }
            set
            {
                _dateFrom = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTill
        {
            get
            {
                return _dateTill;
            }
            set
            {
                _dateTill = value;
            }
        }
        
        public agendaMovementType agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum agendaMovementType
    {
        issuedInvoice,
        receivedInvoice,
        receiptVoucher,
        issueSlip,
        transfer,
        production,
        saleVoucher,
        voucher,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestMovementType
    {
        #region Private fields
        private filterMovementType _filter;
        private string _userFilterName;
        #endregion
        
        public requestMovementType()
        {
            _filter = new filterMovementType();
        }
        
        public filterMovementType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listMovementRequestType
    {
        #region Private fields
        private List<requestMovementType> _requestMovement;
        private listMovementVerType _version;
        private movementVersionType _movementVersion;
        #endregion
        
        public listMovementRequestType()
        {
            _requestMovement = new List<requestMovementType>();
        }
        
        [XmlElement("requestMovement")]
        public List<requestMovementType> requestMovement
        {
            get
            {
                return _requestMovement;
            }
            set
            {
                _requestMovement = value;
            }
        }
        
        [XmlAttribute]
        public listMovementVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public movementVersionType movementVersion
        {
            get
            {
                return _movementVersion;
            }
            set
            {
                _movementVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listMovementVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/movement.xsd")]
    public enum movementVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class stockItemRegNumberType
    {
        #region Private fields
        private refTypeStorage _storage;
        private stockItemRegNumberTypeStockItem _stockItem;
        #endregion
        
        public stockItemRegNumberType()
        {
            _stockItem = new stockItemRegNumberTypeStockItem();
            _storage = new refTypeStorage();
        }
        
        public refTypeStorage storage
        {
            get
            {
                return _storage;
            }
            set
            {
                _storage = value;
            }
        }
        
        public stockItemRegNumberTypeStockItem stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class stockItemRegNumberTypeStockItem
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private string _ids;
        private string _name;
        #endregion
        
        public stockItemRegNumberTypeStockItem()
        {
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterRegNumberType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private string _regNumber;
        private stockItemRegNumberType _stockItem;
        private System.DateTime _lastChanges;
        #endregion
        
        public filterRegNumberType()
        {
            _stockItem = new stockItemRegNumberType();
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string regNumber
        {
            get
            {
                return _regNumber;
            }
            set
            {
                _regNumber = value;
            }
        }
        
        public stockItemRegNumberType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public System.DateTime lastChanges
        {
            get
            {
                return _lastChanges;
            }
            set
            {
                _lastChanges = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestRegistrationNumberType
    {
        #region Private fields
        private filterRegNumberType _filter;
        private string _userFilterName;
        #endregion
        
        public requestRegistrationNumberType()
        {
            _filter = new filterRegNumberType();
        }
        
        public filterRegNumberType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listRegistrationNumberRequestType
    {
        #region Private fields
        private List<requestRegistrationNumberType> _requestRegistrationNumber;
        private listRegistrationNumberVerType _version;
        private registrationNumberVersionType _registrationNumberVersion;
        #endregion
        
        public listRegistrationNumberRequestType()
        {
            _requestRegistrationNumber = new List<requestRegistrationNumberType>();
        }
        
        [XmlElement("requestRegistrationNumber")]
        public List<requestRegistrationNumberType> requestRegistrationNumber
        {
            get
            {
                return _requestRegistrationNumber;
            }
            set
            {
                _requestRegistrationNumber = value;
            }
        }
        
        [XmlAttribute]
        public listRegistrationNumberVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public registrationNumberVersionType registrationNumberVersion
        {
            get
            {
                return _registrationNumberVersion;
            }
            set
            {
                _registrationNumberVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listRegistrationNumberVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/registrationNumber.xsd")]
    public enum registrationNumberVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class requestrequestGlobalSettingsType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listGlobalSettingsRequestType
    {
        #region Private fields
        private List<requestrequestGlobalSettingsType> _requestGlobalSettings;
        private listGlobalSettingsVerType _version;
        private archiveVersionType _globalSettingsVersion;
        #endregion
        
        public listGlobalSettingsRequestType()
        {
            _requestGlobalSettings = new List<requestrequestGlobalSettingsType>();
        }
        
        [XmlElement("requestGlobalSettings")]
        public List<requestrequestGlobalSettingsType> requestGlobalSettings
        {
            get
            {
                return _requestGlobalSettings;
            }
            set
            {
                _requestGlobalSettings = value;
            }
        }
        
        [XmlAttribute]
        public listGlobalSettingsVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public archiveVersionType globalSettingsVersion
        {
            get
            {
                return _globalSettingsVersion;
            }
            set
            {
                _globalSettingsVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listGlobalSettingsVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/archive.xsd")]
    public enum archiveVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestProdejkaType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestProdejkaType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/accountingSalesVouchers.xsd")]
    public partial class accountingSalesVouchersType
    {
        #region Private fields
        private requestProdejkaType _recordFilter;
        private refType _centre;
        private accountingSalesVouchersVerType _version;
        #endregion
        
        public accountingSalesVouchersType()
        {
            _centre = new refType();
            _recordFilter = new requestProdejkaType();
        }
        
        public requestProdejkaType recordFilter
        {
            get
            {
                return _recordFilter;
            }
            set
            {
                _recordFilter = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        [XmlAttribute]
        public accountingSalesVouchersVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class refType
    {
        #region Private fields
        private string _id;
        private string _ids;
        private refTypeValueType _valueType;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public refTypeValueType valueType
        {
            get
            {
                return _valueType;
            }
            set
            {
                _valueType = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum refTypeValueType
    {
        nullValue,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/accountingSalesVouchers.xsd")]
    public enum accountingSalesVouchersVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/sendEET.xsd")]
    public partial class recordSendEETType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        private sendEETAgendaType _agenda;
        #endregion
        
        public recordSendEETType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
        
        [XmlAttribute]
        public sendEETAgendaType agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/sendEET.xsd")]
    public enum sendEETAgendaType
    {
        ostatni_pohledavky,
        pokladna_prijem,
        prodejky,
        vydane_faktury,
        vydane_zalohove_faktury,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/sendEET.xsd")]
    public partial class sendEETType
    {
        #region Private fields
        private recordSendEETType _record;
        private sendEETVerType _version;
        #endregion
        
        public sendEETType()
        {
            _record = new recordSendEETType();
        }
        
        public recordSendEETType record
        {
            get
            {
                return _record;
            }
            set
            {
                _record = value;
            }
        }
        
        [XmlAttribute]
        public sendEETVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/sendEET.xsd")]
    public enum sendEETVerType
    {
        [XmlEnumAttribute("1.0")]
        Item10,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
    public partial class attachmentType
    {
        #region Private fields
        private boolean _preview;
        private string _fileName;
        #endregion
        
        public boolean preview
        {
            get
            {
                return _preview;
            }
            set
            {
                _preview = value;
            }
        }
        
        public string fileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
    public partial class secureHashAlgorithmType
    {
        #region Private fields
        private hashAlgorithmType _item;
        #endregion
        
        [XmlElement("hashAlgorithm")]
        public hashAlgorithmType Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
    public enum hashAlgorithmType
    {
        [XmlEnumAttribute("SHA-1")]
        SHA1,
        [XmlEnumAttribute("SHA-256")]
        SHA256,
        [XmlEnumAttribute("SHA-384")]
        SHA384,
        [XmlEnumAttribute("SHA-512")]
        SHA512,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
    public partial class signatureCertificateType
    {
        #region Private fields
        private string _item;
        #endregion
        
        [XmlElement("serialNumber")]
        public string Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
    public partial class isdocSettingsType
    {
        #region Private fields
        private string _fileName;
        private versionIsdocDocumentType _versionIsdocDocument;
        private signatureCertificateType _signatureCertificate;
        private secureHashAlgorithmType _secureHashAlgorithm;
        private System.Nullable<identificationOfStockitemType> _identificationOfStockitem;
        private List<attachmentType> _attachments;
        #endregion
        
        public isdocSettingsType()
        {
            _attachments = new List<attachmentType>();
            _secureHashAlgorithm = new secureHashAlgorithmType();
            _signatureCertificate = new signatureCertificateType();
        }
        
        public string fileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }
        
        public versionIsdocDocumentType versionIsdocDocument
        {
            get
            {
                return _versionIsdocDocument;
            }
            set
            {
                _versionIsdocDocument = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public signatureCertificateType signatureCertificate
        {
            get
            {
                return _signatureCertificate;
            }
            set
            {
                _signatureCertificate = value;
            }
        }
        
        public secureHashAlgorithmType secureHashAlgorithm
        {
            get
            {
                return _secureHashAlgorithm;
            }
            set
            {
                _secureHashAlgorithm = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public System.Nullable<identificationOfStockitemType> identificationOfStockitem
        {
            get
            {
                return _identificationOfStockitem;
            }
            set
            {
                _identificationOfStockitem = value;
            }
        }
        
        [XmlArrayItemAttribute("attachment", IsNullable=false)]
        public List<attachmentType> attachments
        {
            get
            {
                return _attachments;
            }
            set
            {
                _attachments = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
    public enum versionIsdocDocumentType
    {
        [XmlEnumAttribute("5.2")]
        Item52,
        [XmlEnumAttribute("5.2.1")]
        Item521,
        [XmlEnumAttribute("5.2.2")]
        Item522,
        [XmlEnumAttribute("5.2.3")]
        Item523,
        [XmlEnumAttribute("5.3")]
        Item53,
        [XmlEnumAttribute("5.3.1")]
        Item531,
        [XmlEnumAttribute("6.0.1")]
        Item601,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
    public enum identificationOfStockitemType
    {
        Code,
        Item,
        Job,
        Note,
        [XmlEnumAttribute("Short title")]
        Shorttitle,
        Manufacturer,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class recordIsdocType
    {
        #region Private fields
        private filterIDType _filter;
        private string _userFilterName;
        private isdocAgendaType _agenda;
        #endregion
        
        public recordIsdocType()
        {
            _filter = new filterIDType();
        }
        
        public filterIDType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
        
        [XmlAttribute]
        public isdocAgendaType agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public enum isdocAgendaType
    {
        interni_doklady,
        vydane_faktury,
        vydane_zalohove_faktury,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="isdocType", Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
    public partial class isdocType1
    {
        #region Private fields
        private recordIsdocType _record;
        private List<isdocSettingsType> _isdocSettings;
        private isdocVerType _version;
        #endregion
        
        public isdocType1()
        {
            _isdocSettings = new List<isdocSettingsType>();
            _record = new recordIsdocType();
        }
        
        public recordIsdocType record
        {
            get
            {
                return _record;
            }
            set
            {
                _record = value;
            }
        }
        
        [XmlElement("isdocSettings")]
        public List<isdocSettingsType> isdocSettings
        {
            get
            {
                return _isdocSettings;
            }
            set
            {
                _isdocSettings = value;
            }
        }
        
        [XmlAttribute]
        public isdocVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
    public enum isdocVerType
    {
        [XmlEnumAttribute("1.0")]
        Item10,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class recordPrintType
    {
        #region Private fields
        private filterIDType _filter;
        private string _userFilterName;
        private printAgendaType _agenda;
        #endregion
        
        public recordPrintType()
        {
            _filter = new filterIDType();
        }
        
        public filterIDType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
        
        [XmlAttribute]
        public printAgendaType agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public enum printAgendaType
    {
        adresar,
        interni_doklady,
        ostatni_pohledavky,
        ostatni_zavazky,
        pokladna,
        prevod,
        prijate_faktury,
        prijate_nabidky,
        prijate_objednavky,
        prijate_poptavky,
        prijate_zalohove_faktury,
        prijemky,
        prodejky,
        vydane_faktury,
        vydane_nabidky,
        vydane_objednavky,
        vydane_poptavky,
        vydane_zalohove_faktury,
        vydejky,
        vyroba,
        zakazky,
        zasoby,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class printType
    {
        #region Private fields
        private recordPrintType _record;
        private List<printerSettingsType> _printerSettings;
        private printVerType _version;
        #endregion
        
        public printType()
        {
            _printerSettings = new List<printerSettingsType>();
            _record = new recordPrintType();
        }
        
        public recordPrintType record
        {
            get
            {
                return _record;
            }
            set
            {
                _record = value;
            }
        }
        
        [XmlElement("printerSettings")]
        public List<printerSettingsType> printerSettings
        {
            get
            {
                return _printerSettings;
            }
            set
            {
                _printerSettings = value;
            }
        }
        
        [XmlAttribute]
        public printVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class printerSettingsType
    {
        #region Private fields
        private reportType _report;
        private string _printer;
        private PDFType _pdf;
        private parametersType1 _parameters;
        #endregion
        
        public printerSettingsType()
        {
            _parameters = new parametersType1();
            _pdf = new PDFType();
            _report = new reportType();
        }
        
        public reportType report
        {
            get
            {
                return _report;
            }
            set
            {
                _report = value;
            }
        }
        
        public string printer
        {
            get
            {
                return _printer;
            }
            set
            {
                _printer = value;
            }
        }
        
        public PDFType pdf
        {
            get
            {
                return _pdf;
            }
            set
            {
                _pdf = value;
            }
        }
        
        public parametersType1 parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class reportType
    {
        #region Private fields
        private string _id;
        private string _name;
        private string _detail;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string detail
        {
            get
            {
                return _detail;
            }
            set
            {
                _detail = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class PDFType
    {
        #region Private fields
        private string _fileName;
        private isdocType _isdoc;
        #endregion
        
        public PDFType()
        {
            _isdoc = new isdocType();
        }
        
        public string fileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }
        
        public isdocType isdoc
        {
            get
            {
                return _isdoc;
            }
            set
            {
                _isdoc = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class isdocType
    {
        #region Private fields
        private boolean _includeToPdf;
        private isdocTypeGraphicNote _graphicNote;
        #endregion
        
        public boolean includeToPdf
        {
            get
            {
                return _includeToPdf;
            }
            set
            {
                _includeToPdf = value;
            }
        }
        
        public isdocTypeGraphicNote graphicNote
        {
            get
            {
                return _graphicNote;
            }
            set
            {
                _graphicNote = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public enum isdocTypeGraphicNote
    {
        topRight,
        topLeft,
        bottomRight,
        bottomLeft,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="parametersType", Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class parametersType1
    {
        #region Private fields
        private decimal _copy;
        private System.DateTime _datePrint;
        private checkboxType _checkbox1;
        private checkboxType _checkbox2;
        private checkboxType _checkbox3;
        private checkboxType _checkbox4;
        private checkboxType _checkbox5;
        private checkboxType _checkbox6;
        private radioButtonType _radioButton1;
        private numberType _spin1;
        private numberType _currency1;
        private numberType _month1;
        private numberType _month2;
        private numberType _year1;
        private dateType _date1;
        private dateType _date2;
        private dateType _date3;
        private dateType _date4;
        private textType _text1;
        private textType _text2;
        private textType _text3;
        private comboboxType _combobox1;
        private comboboxType _combobox2;
        private comboboxType _combobox3;
        private comboboxType _comboboxEx1;
        private comboboxType _comboboxEx2;
        #endregion
        
        public parametersType1()
        {
            _comboboxEx2 = new comboboxType();
            _comboboxEx1 = new comboboxType();
            _combobox3 = new comboboxType();
            _combobox2 = new comboboxType();
            _combobox1 = new comboboxType();
            _text3 = new textType();
            _text2 = new textType();
            _text1 = new textType();
            _date4 = new dateType();
            _date3 = new dateType();
            _date2 = new dateType();
            _date1 = new dateType();
            _year1 = new numberType();
            _month2 = new numberType();
            _month1 = new numberType();
            _currency1 = new numberType();
            _spin1 = new numberType();
            _radioButton1 = new radioButtonType();
            _checkbox6 = new checkboxType();
            _checkbox5 = new checkboxType();
            _checkbox4 = new checkboxType();
            _checkbox3 = new checkboxType();
            _checkbox2 = new checkboxType();
            _checkbox1 = new checkboxType();
            _copy = ((decimal)(1m));
        }
        
        [DefaultValue(typeof(decimal), "1")]
        public decimal copy
        {
            get
            {
                return _copy;
            }
            set
            {
                _copy = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime datePrint
        {
            get
            {
                return _datePrint;
            }
            set
            {
                _datePrint = value;
            }
        }
        
        public checkboxType checkbox1
        {
            get
            {
                return _checkbox1;
            }
            set
            {
                _checkbox1 = value;
            }
        }
        
        public checkboxType checkbox2
        {
            get
            {
                return _checkbox2;
            }
            set
            {
                _checkbox2 = value;
            }
        }
        
        public checkboxType checkbox3
        {
            get
            {
                return _checkbox3;
            }
            set
            {
                _checkbox3 = value;
            }
        }
        
        public checkboxType checkbox4
        {
            get
            {
                return _checkbox4;
            }
            set
            {
                _checkbox4 = value;
            }
        }
        
        public checkboxType checkbox5
        {
            get
            {
                return _checkbox5;
            }
            set
            {
                _checkbox5 = value;
            }
        }
        
        public checkboxType checkbox6
        {
            get
            {
                return _checkbox6;
            }
            set
            {
                _checkbox6 = value;
            }
        }
        
        public radioButtonType radioButton1
        {
            get
            {
                return _radioButton1;
            }
            set
            {
                _radioButton1 = value;
            }
        }
        
        public numberType spin1
        {
            get
            {
                return _spin1;
            }
            set
            {
                _spin1 = value;
            }
        }
        
        public numberType currency1
        {
            get
            {
                return _currency1;
            }
            set
            {
                _currency1 = value;
            }
        }
        
        public numberType month1
        {
            get
            {
                return _month1;
            }
            set
            {
                _month1 = value;
            }
        }
        
        public numberType month2
        {
            get
            {
                return _month2;
            }
            set
            {
                _month2 = value;
            }
        }
        
        public numberType year1
        {
            get
            {
                return _year1;
            }
            set
            {
                _year1 = value;
            }
        }
        
        public dateType date1
        {
            get
            {
                return _date1;
            }
            set
            {
                _date1 = value;
            }
        }
        
        public dateType date2
        {
            get
            {
                return _date2;
            }
            set
            {
                _date2 = value;
            }
        }
        
        public dateType date3
        {
            get
            {
                return _date3;
            }
            set
            {
                _date3 = value;
            }
        }
        
        public dateType date4
        {
            get
            {
                return _date4;
            }
            set
            {
                _date4 = value;
            }
        }
        
        public textType text1
        {
            get
            {
                return _text1;
            }
            set
            {
                _text1 = value;
            }
        }
        
        public textType text2
        {
            get
            {
                return _text2;
            }
            set
            {
                _text2 = value;
            }
        }
        
        public textType text3
        {
            get
            {
                return _text3;
            }
            set
            {
                _text3 = value;
            }
        }
        
        public comboboxType combobox1
        {
            get
            {
                return _combobox1;
            }
            set
            {
                _combobox1 = value;
            }
        }
        
        public comboboxType combobox2
        {
            get
            {
                return _combobox2;
            }
            set
            {
                _combobox2 = value;
            }
        }
        
        public comboboxType combobox3
        {
            get
            {
                return _combobox3;
            }
            set
            {
                _combobox3 = value;
            }
        }
        
        public comboboxType comboboxEx1
        {
            get
            {
                return _comboboxEx1;
            }
            set
            {
                _comboboxEx1 = value;
            }
        }
        
        public comboboxType comboboxEx2
        {
            get
            {
                return _comboboxEx2;
            }
            set
            {
                _comboboxEx2 = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class checkboxType
    {
        #region Private fields
        private boolean _value;
        private string _name;
        #endregion
        
        public boolean value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class radioButtonType
    {
        #region Private fields
        private string _value;
        private string _name;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class numberType
    {
        #region Private fields
        private string _value;
        private string _name;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class dateType
    {
        #region Private fields
        private System.DateTime _value;
        private string _name;
        #endregion
        
        [XmlElement(DataType="date")]
        public System.DateTime value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class textType
    {
        #region Private fields
        private string _value;
        private string _name;
        #endregion
        
        public string value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public partial class comboboxType
    {
        #region Private fields
        private string _value;
        private string _name;
        #endregion
        
        public string value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
    public enum printVerType
    {
        [XmlEnumAttribute("1.0")]
        Item10,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/mKasa.xsd")]
    public partial class importRequestType
    {
        #region Private fields
        private int _mKasaPackNum;
        private string _name;
        private string _deviceGuid;
        private boolean _overwriteDeviceGuid;
        #endregion
        
        public int mKasaPackNum
        {
            get
            {
                return _mKasaPackNum;
            }
            set
            {
                _mKasaPackNum = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string deviceGuid
        {
            get
            {
                return _deviceGuid;
            }
            set
            {
                _deviceGuid = value;
            }
        }
        
        public boolean overwriteDeviceGuid
        {
            get
            {
                return _overwriteDeviceGuid;
            }
            set
            {
                _overwriteDeviceGuid = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/mKasa.xsd")]
    public partial class exportRequestType
    {
        #region Private fields
        private string _name;
        private string _deviceGuid;
        private boolean _overwriteDeviceGuid;
        private agendaType2 _agenda;
        private int _myLastId;
        private boolean _diffExport;
        #endregion
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string deviceGuid
        {
            get
            {
                return _deviceGuid;
            }
            set
            {
                _deviceGuid = value;
            }
        }
        
        public boolean overwriteDeviceGuid
        {
            get
            {
                return _overwriteDeviceGuid;
            }
            set
            {
                _overwriteDeviceGuid = value;
            }
        }
        
        public agendaType2 agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
        
        public int myLastId
        {
            get
            {
                return _myLastId;
            }
            set
            {
                _myLastId = value;
            }
        }
        
        public boolean DiffExport
        {
            get
            {
                return _diffExport;
            }
            set
            {
                _diffExport = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(TypeName="agendaType", Namespace="http://www.stormware.cz/schema/version_2/mKasa.xsd")]
    public enum agendaType2
    {
        Kasa,
        AD,
        FormUh,
        CIN,
        CRady,
        SkCeny,
        SkSt,
        SkKat,
        SKz,
        SKzVC,
        PHzauc,
        Ucet,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/mKasa.xsd")]
    public partial class mKasaRequestType
    {
        #region Private fields
        private object _item;
        private mKasaVersionType _version;
        #endregion
        
        [XmlElement("export", typeof(exportRequestType))]
        [XmlElement("import", typeof(importRequestType))]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlAttribute]
        public mKasaVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/mKasa.xsd")]
    public enum mKasaVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class requestClassificationVATType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listClassificationVATRequestType
    {
        #region Private fields
        private List<requestClassificationVATType> _requestClassificationVAT;
        private listClassificationVATVerType _version;
        private classificationVATVersionType _classificationVATVersion;
        #endregion
        
        public listClassificationVATRequestType()
        {
            _requestClassificationVAT = new List<requestClassificationVATType>();
        }
        
        [XmlElement("requestClassificationVAT")]
        public List<requestClassificationVATType> requestClassificationVAT
        {
            get
            {
                return _requestClassificationVAT;
            }
            set
            {
                _requestClassificationVAT = value;
            }
        }
        
        [XmlAttribute]
        public listClassificationVATVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public classificationVATVersionType classificationVATVersion
        {
            get
            {
                return _classificationVATVersion;
            }
            set
            {
                _classificationVATVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listClassificationVATVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/classificationVAT.xsd")]
    public enum classificationVATVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_activity.xsd")]
    public partial class requestActivityType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_activity.xsd")]
    public partial class listRequestActivityType
    {
        #region Private fields
        private List<requestActivityType> _requestActivity;
        private listRequestActivityVerType _version;
        private activityVersionType _activityVersion;
        #endregion
        
        public listRequestActivityType()
        {
            _requestActivity = new List<requestActivityType>();
        }
        
        [XmlElement("requestActivity")]
        public List<requestActivityType> requestActivity
        {
            get
            {
                return _requestActivity;
            }
            set
            {
                _requestActivity = value;
            }
        }
        
        [XmlAttribute]
        public listRequestActivityVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public activityVersionType activityVersion
        {
            get
            {
                return _activityVersion;
            }
            set
            {
                _activityVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_activity.xsd")]
    public enum listRequestActivityVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/activity.xsd")]
    public enum activityVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_centre.xsd")]
    public partial class requestCentreType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_centre.xsd")]
    public partial class listRequestCentreType
    {
        #region Private fields
        private List<requestCentreType> _requestCentre;
        private listRequestCentreVerType _version;
        private centreVersionType _centreVersion;
        #endregion
        
        public listRequestCentreType()
        {
            _requestCentre = new List<requestCentreType>();
        }
        
        [XmlElement("requestCentre")]
        public List<requestCentreType> requestCentre
        {
            get
            {
                return _requestCentre;
            }
            set
            {
                _requestCentre = value;
            }
        }
        
        [XmlAttribute]
        public listRequestCentreVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public centreVersionType centreVersion
        {
            get
            {
                return _centreVersion;
            }
            set
            {
                _centreVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_centre.xsd")]
    public enum listRequestCentreVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/centre.xsd")]
    public enum centreVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class requestEstablishmentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listEstablishmentRequestType
    {
        #region Private fields
        private List<requestEstablishmentType> _requestEstablishment;
        private listEstablishmentVerType _version;
        private establishmentVersionType _establishmentVersion;
        #endregion
        
        public listEstablishmentRequestType()
        {
            _requestEstablishment = new List<requestEstablishmentType>();
        }
        
        [XmlElement("requestEstablishment")]
        public List<requestEstablishmentType> requestEstablishment
        {
            get
            {
                return _requestEstablishment;
            }
            set
            {
                _requestEstablishment = value;
            }
        }
        
        [XmlAttribute]
        public listEstablishmentVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public establishmentVersionType establishmentVersion
        {
            get
            {
                return _establishmentVersion;
            }
            set
            {
                _establishmentVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listEstablishmentVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/establishment.xsd")]
    public enum establishmentVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class requestGDPRType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listGDPRRequestType
    {
        #region Private fields
        private List<requestGDPRType> _requestGDPR;
        private listGDPRVerType _version;
        private GDPRVersionType _gDPRVersion;
        #endregion
        
        public listGDPRRequestType()
        {
            _requestGDPR = new List<requestGDPRType>();
        }
        
        [XmlElement("requestGDPR")]
        public List<requestGDPRType> requestGDPR
        {
            get
            {
                return _requestGDPR;
            }
            set
            {
                _requestGDPR = value;
            }
        }
        
        [XmlAttribute]
        public listGDPRVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public GDPRVersionType GDPRVersion
        {
            get
            {
                return _gDPRVersion;
            }
            set
            {
                _gDPRVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listGDPRVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/GDPR.xsd")]
    public enum GDPRVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterNumeciralSeriesType
    {
        #region Private fields
        private string _id;
        private periodType1 _period;
        private CRadyAgendaType _agenda;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public periodType1 period
        {
            get
            {
                return _period;
            }
            set
            {
                _period = value;
            }
        }
        
        public CRadyAgendaType agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(TypeName="periodType", Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum periodType1
    {
        current,
        following,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public enum CRadyAgendaType
    {
        adresar,
        casove_rozliseni,
        dlouhodoby_majetek,
        drobny_majetek,
        interni_doklady,
        inventurni_seznamy,
        leasingovy_majetek,
        opravne_polozky,
        ostatni_pohledavky,
        ostatni_zavazky,
        personalistika,
        pokladna,
        prevod,
        prijate_faktury,
        prijate_nabidky,
        prijate_objednavky,
        prijate_poptavky,
        prijate_zalohove_faktury,
        prijemky,
        prodejky,
        reklamace,
        servis,
        smlouvy,
        tuzemske_cestovni_prikazy,
        vydane_faktury,
        vydane_nabidky,
        vydane_objednavky,
        vydane_poptavky,
        vydane_zalohove_faktury,
        vydejky,
        vyroba,
        zakazky,
        zahranicni_cestovni_prikazy,
        zasilky,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestNumericalSeriesType
    {
        #region Private fields
        private filterNumeciralSeriesType _filter;
        private string _userFilterName;
        #endregion
        
        public requestNumericalSeriesType()
        {
            _filter = new filterNumeciralSeriesType();
        }
        
        public filterNumeciralSeriesType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listNumericalSeriesRequestType
    {
        #region Private fields
        private List<requestNumericalSeriesType> _requestNumericalSeries;
        private listNumericalSeriesVerType _version;
        private nmsVersionType _numericalSeriesVersion;
        #endregion
        
        public listNumericalSeriesRequestType()
        {
            _requestNumericalSeries = new List<requestNumericalSeriesType>();
        }
        
        [XmlElement("requestNumericalSeries")]
        public List<requestNumericalSeriesType> requestNumericalSeries
        {
            get
            {
                return _requestNumericalSeries;
            }
            set
            {
                _requestNumericalSeries = value;
            }
        }
        
        [XmlAttribute]
        public listNumericalSeriesVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public nmsVersionType numericalSeriesVersion
        {
            get
            {
                return _numericalSeriesVersion;
            }
            set
            {
                _numericalSeriesVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listNumericalSeriesVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/numericalSeries.xsd")]
    public enum nmsVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestPaymentType
    {
        #region Private fields
        private filterIDType _filter;
        private string _userFilterName;
        #endregion
        
        public requestPaymentType()
        {
            _filter = new filterIDType();
        }
        
        public filterIDType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listPaymentRequestType
    {
        #region Private fields
        private List<requestPaymentType> _requestPayment;
        private listPaymentRequestVerType _version;
        private payVersionType _paymentVersion;
        #endregion
        
        public listPaymentRequestType()
        {
            _requestPayment = new List<requestPaymentType>();
        }
        
        [XmlElement("requestPayment")]
        public List<requestPaymentType> requestPayment
        {
            get
            {
                return _requestPayment;
            }
            set
            {
                _requestPayment = value;
            }
        }
        
        [XmlAttribute]
        public listPaymentRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public payVersionType paymentVersion
        {
            get
            {
                return _paymentVersion;
            }
            set
            {
                _paymentVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listPaymentRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/payment.xsd")]
    public enum payVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestActionPriceType
    {
        #region Private fields
        private filterIDType _filter;
        private string _userFilterName;
        #endregion
        
        public requestActionPriceType()
        {
            _filter = new filterIDType();
        }
        
        public filterIDType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listActionPriceRequestType
    {
        #region Private fields
        private List<requestActionPriceType> _requestActionPrice;
        private listActionPriceRequestVerType _version;
        private acpVersionType _actionPricesVersion;
        #endregion
        
        public listActionPriceRequestType()
        {
            _requestActionPrice = new List<requestActionPriceType>();
        }
        
        [XmlElement("requestActionPrice")]
        public List<requestActionPriceType> requestActionPrice
        {
            get
            {
                return _requestActionPrice;
            }
            set
            {
                _requestActionPrice = value;
            }
        }
        
        [XmlAttribute]
        public listActionPriceRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public acpVersionType actionPricesVersion
        {
            get
            {
                return _actionPricesVersion;
            }
            set
            {
                _actionPricesVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listActionPriceRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/actionPrice.xsd")]
    public enum acpVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
        [XmlEnumAttribute("2.1")]
        Item21,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listGroupStocksRequestType
    {
        #region Private fields
        private requestGroupStocksType _requestGroupStocks;
        private listGroupStocksRequestVerType _version;
        private grsVersionType _groupStocksVersion;
        #endregion
        
        public listGroupStocksRequestType()
        {
            _requestGroupStocks = new requestGroupStocksType();
        }
        
        public requestGroupStocksType requestGroupStocks
        {
            get
            {
                return _requestGroupStocks;
            }
            set
            {
                _requestGroupStocks = value;
            }
        }
        
        [XmlAttribute]
        public listGroupStocksRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public grsVersionType groupStocksVersion
        {
            get
            {
                return _groupStocksVersion;
            }
            set
            {
                _groupStocksVersion = value;
            }
        }
    }
    
    [XmlInclude(typeof(requestGroupStocksActionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestGroupStocksType
    {
        #region Private fields
        private filterGroupStockType _filter;
        private string _userFilterName;
        #endregion
        
        public requestGroupStocksType()
        {
            _filter = new filterGroupStockType();
        }
        
        public filterGroupStockType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterGroupStockType
    {
        #region Private fields
        private string _id;
        private string _code;
        private string _name;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestGroupStocksActionType : requestGroupStocksType
    {
        #region Private fields
        private boolean _update;
        private boolean _add;
        #endregion
        
        public requestGroupStocksActionType()
        {
            _update = boolean.@false;
            _add = boolean.@false;
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@false)]
        public boolean update
        {
            get
            {
                return _update;
            }
            set
            {
                _update = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@false)]
        public boolean add
        {
            get
            {
                return _add;
            }
            set
            {
                _add = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listGroupStocksRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/groupStocks.xsd")]
    public enum grsVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestStoreType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestStoreType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listStoreRequestType
    {
        #region Private fields
        private requestStoreType _requestStore;
        private listStoreRequestVerType _version;
        private stoVersionType _storeVersion;
        #endregion
        
        public listStoreRequestType()
        {
            _requestStore = new requestStoreType();
        }
        
        public requestStoreType requestStore
        {
            get
            {
                return _requestStore;
            }
            set
            {
                _requestStore = value;
            }
        }
        
        [XmlAttribute]
        public listStoreRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public stoVersionType storeVersion
        {
            get
            {
                return _storeVersion;
            }
            set
            {
                _storeVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listStoreRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/store.xsd")]
    public enum stoVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class requestIntParamType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listIntParamRequestType
    {
        #region Private fields
        private requestIntParamType _requestIntParam;
        private listIntParamRequestVerType _version;
        #endregion
        
        public listIntParamRequestType()
        {
            _requestIntParam = new requestIntParamType();
        }
        
        public requestIntParamType requestIntParam
        {
            get
            {
                return _requestIntParam;
            }
            set
            {
                _requestIntParam = value;
            }
        }
        
        [XmlAttribute]
        public listIntParamRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listIntParamRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class requestCategoryType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listCategoryRequestType
    {
        #region Private fields
        private requestCategoryType _requestCategory;
        private listCategoryRequestVerType _version;
        private ctgVersionType _categoryVersion;
        #endregion
        
        public listCategoryRequestType()
        {
            _requestCategory = new requestCategoryType();
        }
        
        public requestCategoryType requestCategory
        {
            get
            {
                return _requestCategory;
            }
            set
            {
                _requestCategory = value;
            }
        }
        
        [XmlAttribute]
        public listCategoryRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public ctgVersionType categoryVersion
        {
            get
            {
                return _categoryVersion;
            }
            set
            {
                _categoryVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listCategoryRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/category.xsd")]
    public enum ctgVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
        [XmlEnumAttribute("2.1")]
        Item21,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class requestUserCodeType
    {
        #region Private fields
        private string _code;
        #endregion
        
        [XmlAttribute]
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listUserCodeRequestType
    {
        #region Private fields
        private List<requestUserCodeType> _requestUserCode;
        private string _version;
        private string _listVersion;
        #endregion
        
        public listUserCodeRequestType()
        {
            _requestUserCode = new List<requestUserCodeType>();
        }
        
        [XmlElement("requestUserCode")]
        public List<requestUserCodeType> requestUserCode
        {
            get
            {
                return _requestUserCode;
            }
            set
            {
                _requestUserCode = value;
            }
        }
        
        [XmlAttribute]
        public string version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public string listVersion
        {
            get
            {
                return _listVersion;
            }
            set
            {
                _listVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestContractType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestContractType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_contract.xsd")]
    public partial class listRequestContractType
    {
        #region Private fields
        private List<requestContractType> _requestContract;
        private listRequestContractVerType _version;
        private conVersionType _contractVersion;
        #endregion
        
        public listRequestContractType()
        {
            _requestContract = new List<requestContractType>();
        }
        
        [XmlElement("requestContract")]
        public List<requestContractType> requestContract
        {
            get
            {
                return _requestContract;
            }
            set
            {
                _requestContract = value;
            }
        }
        
        [XmlAttribute]
        public listRequestContractVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public conVersionType contractVersion
        {
            get
            {
                return _contractVersion;
            }
            set
            {
                _contractVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_contract.xsd")]
    public enum listRequestContractVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/contract.xsd")]
    public enum conVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestBankAccountType
    {
        #region Private fields
        private filterIDType _filter;
        private string _userFilterName;
        #endregion
        
        public requestBankAccountType()
        {
            _filter = new filterIDType();
        }
        
        public filterIDType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listBankAccountRequestType
    {
        #region Private fields
        private List<requestBankAccountType> _requestBankAccount;
        private listBankAccountRequestVerType _version;
        private bkaVersionType _bankAccountVersion;
        private string _extSystem;
        #endregion
        
        public listBankAccountRequestType()
        {
            _requestBankAccount = new List<requestBankAccountType>();
        }
        
        [XmlElement("requestBankAccount")]
        public List<requestBankAccountType> requestBankAccount
        {
            get
            {
                return _requestBankAccount;
            }
            set
            {
                _requestBankAccount = value;
            }
        }
        
        [XmlAttribute]
        public listBankAccountRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public bkaVersionType bankAccountVersion
        {
            get
            {
                return _bankAccountVersion;
            }
            set
            {
                _bankAccountVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listBankAccountRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bankAccount.xsd")]
    public enum bkaVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestCashRegisterType
    {
        #region Private fields
        private filterIDType _filter;
        private string _userFilterName;
        #endregion
        
        public requestCashRegisterType()
        {
            _filter = new filterIDType();
        }
        
        public filterIDType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listCashRegisterRequestType
    {
        #region Private fields
        private List<requestCashRegisterType> _requestCashRegister;
        private listCashRegisterRequestVerType _version;
        private cshVersionType _cashRegisterVersion;
        private string _extSystem;
        #endregion
        
        public listCashRegisterRequestType()
        {
            _requestCashRegister = new List<requestCashRegisterType>();
        }
        
        [XmlElement("requestCashRegister")]
        public List<requestCashRegisterType> requestCashRegister
        {
            get
            {
                return _requestCashRegister;
            }
            set
            {
                _requestCashRegister = value;
            }
        }
        
        [XmlAttribute]
        public listCashRegisterRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public cshVersionType cashRegisterVersion
        {
            get
            {
                return _cashRegisterVersion;
            }
            set
            {
                _cashRegisterVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listCashRegisterRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/cashRegister.xsd")]
    public enum cshVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [XmlInclude(typeof(listRequestStoresType))]
    [XmlInclude(typeof(listRequestAgendasType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listRequestType
    {
        #region Private fields
        private string _version;
        #endregion
        
        [XmlAttribute]
        public string version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listRequestStoresType : listRequestType
    {
        #region Private fields
        private List<refType> _stores;
        #endregion
        
        public listRequestStoresType()
        {
            _stores = new List<refType>();
        }
        
        [XmlArrayItemAttribute("store", IsNullable=false)]
        public List<refType> stores
        {
            get
            {
                return _stores;
            }
            set
            {
                _stores = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listRequestAgendasType : listRequestType
    {
        #region Private fields
        private List<agendaType1> _agendas;
        #endregion
        
        public listRequestAgendasType()
        {
            _agendas = new List<agendaType1>();
        }
        
        [XmlArrayItemAttribute("agenda", IsNullable=false)]
        public List<agendaType1> agendas
        {
            get
            {
                return _agendas;
            }
            set
            {
                _agendas = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(TypeName="agendaType", Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum agendaType1
    {
        cashReceived,
        cashPaid,
        internalDocument,
        issuedInvoice,
        issuedAdvanceInvoice,
        claim,
        receivedInvoice,
        receivedAdvanceInvoice,
        commitment,
        bankReceived,
        bankIssued,
        fixedAssets,
        leasingAssets,
        exchangeRateDifferences,
        accrualsAndDeferrals,
        correctiveItems,
    }
    
    [XmlInclude(typeof(itemNumericSeriesType))]
    [XmlInclude(typeof(itemAccountingTypeSingleEntry))]
    [XmlInclude(typeof(itemCashType))]
    [XmlInclude(typeof(itemUserCodeType))]
    [XmlInclude(typeof(itemNameType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class itemType
    {
        #region Private fields
        private string _id;
        private string _code;
        #endregion
        
        [XmlAttribute(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlAttribute]
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class itemNumericSeriesType : itemType
    {
        #region Private fields
        private string _name;
        private string _agenda;
        private string _year;
        #endregion
        
        [XmlAttribute]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [XmlAttribute]
        public string agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
        
        [XmlAttribute(DataType="gYear")]
        public string year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class itemAccountingTypeSingleEntry : itemType
    {
        #region Private fields
        private string _accounting;
        private string _agenda;
        private string _accountingType;
        #endregion
        
        [XmlAttribute]
        public string accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        [XmlAttribute]
        public string agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
        
        [XmlAttribute]
        public string accountingType
        {
            get
            {
                return _accountingType;
            }
            set
            {
                _accountingType = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class itemCashType : itemType
    {
        #region Private fields
        private string _codeCurrency;
        private string _name;
        #endregion
        
        [XmlAttribute]
        public string codeCurrency
        {
            get
            {
                return _codeCurrency;
            }
            set
            {
                _codeCurrency = value;
            }
        }
        
        [XmlAttribute]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class itemUserCodeType : itemType
    {
        #region Private fields
        private string _name;
        private string _constant;
        #endregion
        
        [XmlAttribute]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string constant
        {
            get
            {
                return _constant;
            }
            set
            {
                _constant = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class itemNameType : itemType
    {
        #region Private fields
        private string _name;
        #endregion
        
        [XmlAttribute]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listUserCodeType
    {
        #region Private fields
        private List<itemUserCodeType> _itemUserCode;
        private string _version;
        private System.DateTime _dateTimeStamp;
        private System.DateTime _dateValidFrom;
        private stavType2 _state;
        private string _id;
        private string _code;
        private string _name;
        private boolean _constants;
        #endregion
        
        public listUserCodeType()
        {
            _itemUserCode = new List<itemUserCodeType>();
            _constants = boolean.@false;
        }
        
        [XmlElement("itemUserCode")]
        public List<itemUserCodeType> itemUserCode
        {
            get
            {
                return _itemUserCode;
            }
            set
            {
                _itemUserCode = value;
            }
        }
        
        [XmlAttribute]
        public string version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public System.DateTime dateTimeStamp
        {
            get
            {
                return _dateTimeStamp;
            }
            set
            {
                _dateTimeStamp = value;
            }
        }
        
        [XmlAttribute(DataType="date")]
        public System.DateTime dateValidFrom
        {
            get
            {
                return _dateValidFrom;
            }
            set
            {
                _dateValidFrom = value;
            }
        }
        
        [XmlAttribute]
        public stavType2 state
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlAttribute]
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        [XmlAttribute]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@false)]
        public boolean constants
        {
            get
            {
                return _constants;
            }
            set
            {
                _constants = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum stavType2
    {
        ok,
        error,
    }
    
    [XmlInclude(typeof(itemAccountingTypeDoubleEntry))]
    [XmlInclude(typeof(createAccountingResponseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class createAccountingType
    {
        #region Private fields
        private string _code;
        private string _accounting;
        private agendaType1 _agenda;
        private string _debit;
        private string _credit;
        #endregion
        
        [XmlAttribute]
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        [XmlAttribute]
        public string accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        [XmlAttribute]
        public agendaType1 agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
        
        [XmlAttribute]
        public string debit
        {
            get
            {
                return _debit;
            }
            set
            {
                _debit = value;
            }
        }
        
        [XmlAttribute]
        public string credit
        {
            get
            {
                return _credit;
            }
            set
            {
                _credit = value;
            }
        }
    }
    
    [XmlInclude(typeof(createAccountingResponseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class itemAccountingTypeDoubleEntry : createAccountingType
    {
        #region Private fields
        private string _id;
        #endregion
        
        [XmlAttribute(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class createAccountingResponseType : itemAccountingTypeDoubleEntry
    {
        #region Private fields
        private stavType2 _state;
        private string _note;
        #endregion
        
        [XmlAttribute]
        public stavType2 state
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        
        [XmlAttribute]
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class createAccountingDoubleEntryType
    {
        #region Private fields
        private List<createAccountingType> _createAccounting;
        private createAccountingVerType _version;
        #endregion
        
        public createAccountingDoubleEntryType()
        {
            _createAccounting = new List<createAccountingType>();
        }
        
        [XmlElement("createAccounting")]
        public List<createAccountingType> createAccounting
        {
            get
            {
                return _createAccounting;
            }
            set
            {
                _createAccounting = value;
            }
        }
        
        [XmlAttribute]
        public createAccountingVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum createAccountingVerType
    {
        [XmlEnumAttribute("1.0")]
        Item10,
        [XmlEnumAttribute("1.1")]
        Item11,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestBankType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestBankType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listBankRequestType
    {
        #region Private fields
        private requestBankType _requestBank;
        private listBankRequestVerType _version;
        private bnkVersionType _bankVersion;
        #endregion
        
        public listBankRequestType()
        {
            _requestBank = new requestBankType();
        }
        
        public requestBankType requestBank
        {
            get
            {
                return _requestBank;
            }
            set
            {
                _requestBank = value;
            }
        }
        
        [XmlAttribute]
        public listBankRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public bnkVersionType bankVersion
        {
            get
            {
                return _bankVersion;
            }
            set
            {
                _bankVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listBankRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public enum bnkVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestProductRequirementType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestProductRequirementType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listProductRequirementRequestType
    {
        #region Private fields
        private List<requestProductRequirementType> _requestProductRequirement;
        private listProductRequirementVerType _version;
        private productRequirementVersionType _productRequirementVersion;
        #endregion
        
        public listProductRequirementRequestType()
        {
            _requestProductRequirement = new List<requestProductRequirementType>();
        }
        
        [XmlElement("requestProductRequirement")]
        public List<requestProductRequirementType> requestProductRequirement
        {
            get
            {
                return _requestProductRequirement;
            }
            set
            {
                _requestProductRequirement = value;
            }
        }
        
        [XmlAttribute]
        public listProductRequirementVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public productRequirementVersionType productRequirementVersion
        {
            get
            {
                return _productRequirementVersion;
            }
            set
            {
                _productRequirementVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listProductRequirementVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/productRequirement.xsd")]
    public enum productRequirementVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class requestBalanceType
    {
        #region Private fields
        private System.DateTime _dateTo;
        private double _adjustTo;
        private boolean _groupByDoc;
        private boolean _removeBalancedRec;
        private listBalancePairingType _pairing;
        private string _userFilterName;
        #endregion
        
        public requestBalanceType()
        {
            _adjustTo = 0.01D;
            _groupByDoc = boolean.@true;
            _removeBalancedRec = boolean.@true;
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTo
        {
            get
            {
                return _dateTo;
            }
            set
            {
                _dateTo = value;
            }
        }
        
        [DefaultValue(0.01D)]
        public double adjustTo
        {
            get
            {
                return _adjustTo;
            }
            set
            {
                _adjustTo = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean groupByDoc
        {
            get
            {
                return _groupByDoc;
            }
            set
            {
                _groupByDoc = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean removeBalancedRec
        {
            get
            {
                return _removeBalancedRec;
            }
            set
            {
                _removeBalancedRec = value;
            }
        }
        
        public listBalancePairingType pairing
        {
            get
            {
                return _pairing;
            }
            set
            {
                _pairing = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listBalancePairingType
    {
        PairingSymbol,
        PairingSymbolIC,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listBalanceRequestType
    {
        #region Private fields
        private requestBalanceType _requestBalance;
        private listBalanceRequestVerType _version;
        private balVersionType _balanceVersion;
        private string _extSystem;
        #endregion
        
        public listBalanceRequestType()
        {
            _requestBalance = new requestBalanceType();
        }
        
        public requestBalanceType requestBalance
        {
            get
            {
                return _requestBalance;
            }
            set
            {
                _requestBalance = value;
            }
        }
        
        [XmlAttribute]
        public listBalanceRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public balVersionType balanceVersion
        {
            get
            {
                return _balanceVersion;
            }
            set
            {
                _balanceVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listBalanceRequestVerType
    {
        [XmlEnumAttribute("1.0")]
        Item10,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/balance.xsd")]
    public enum balVersionType
    {
        [XmlEnumAttribute("1.0")]
        Item10,
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestPrijemkaType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestPrijemkaType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listPrijemkaRequestType
    {
        #region Private fields
        private List<requestPrijemkaType> _requestPrijemka;
        private listPrijemkaRequestVerType _version;
        private priVersionType _prijemkaVersion;
        private string _extSystem;
        #endregion
        
        public listPrijemkaRequestType()
        {
            _requestPrijemka = new List<requestPrijemkaType>();
        }
        
        [XmlElement("requestPrijemka")]
        public List<requestPrijemkaType> requestPrijemka
        {
            get
            {
                return _requestPrijemka;
            }
            set
            {
                _requestPrijemka = value;
            }
        }
        
        [XmlAttribute]
        public listPrijemkaRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public priVersionType prijemkaVersion
        {
            get
            {
                return _prijemkaVersion;
            }
            set
            {
                _prijemkaVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listPrijemkaRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prijemka.xsd")]
    public enum priVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestVydejkaType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestVydejkaType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listVydejkaRequestType
    {
        #region Private fields
        private List<requestVydejkaType> _requestVydejka;
        private listVydejkaRequestVerType _version;
        private vydVersionType _vydejkaVersion;
        private string _extSystem;
        #endregion
        
        public listVydejkaRequestType()
        {
            _requestVydejka = new List<requestVydejkaType>();
        }
        
        [XmlElement("requestVydejka")]
        public List<requestVydejkaType> requestVydejka
        {
            get
            {
                return _requestVydejka;
            }
            set
            {
                _requestVydejka = value;
            }
        }
        
        [XmlAttribute]
        public listVydejkaRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public vydVersionType vydejkaVersion
        {
            get
            {
                return _vydejkaVersion;
            }
            set
            {
                _vydejkaVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listVydejkaRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vydejka.xsd")]
    public enum vydVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class requestParameterType
    {
        #region Private fields
        private parameterAgendaType _idsAgenda;
        private string _idsUserAgenda;
        #endregion
        
        [XmlAttribute]
        public parameterAgendaType idsAgenda
        {
            get
            {
                return _idsAgenda;
            }
            set
            {
                _idsAgenda = value;
            }
        }
        
        [XmlAttribute]
        public string idsUserAgenda
        {
            get
            {
                return _idsUserAgenda;
            }
            set
            {
                _idsUserAgenda = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum parameterAgendaType
    {
        adresar,
        udalosti,
        pokladna,
        banka,
        interni,
        nabidky,
        poptavky,
        objednavky,
        faktury,
        zasoby,
        prijemky,
        vydejky,
        vyroba,
        prevod,
        agenda,
        personalistika,
        pracovniPomery,
        drobnyMajetek,
        majetek,
        leasingovyMajetek,
        smlouvy,
        vozidla,
        ridici,
        jizdy,
        seznam,
        osnova,
        reklamace,
        servis,
        strediska,
        cinnosti,
        zakazky,
        prodejky,
        ciselneRady,
        evidencniCisla,
        penezniDenik,
        ucetniDenik,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listParameterRequestType
    {
        #region Private fields
        private List<requestParameterType> _requestParameter;
        private listParameterRequestVerType _version;
        private prmVersionType _parameterVersion;
        #endregion
        
        public listParameterRequestType()
        {
            _requestParameter = new List<requestParameterType>();
        }
        
        [XmlElement("requestParameter")]
        public List<requestParameterType> requestParameter
        {
            get
            {
                return _requestParameter;
            }
            set
            {
                _requestParameter = value;
            }
        }
        
        [XmlAttribute]
        public listParameterRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public prmVersionType parameterVersion
        {
            get
            {
                return _parameterVersion;
            }
            set
            {
                _parameterVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listParameterRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/parameter.xsd")]
    public enum prmVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
        [XmlEnumAttribute("2.1")]
        Item21,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_stock.xsd")]
    public partial class restrictionDataType
    {
        #region Private fields
        private boolean _relatedFiles;
        private boolean _relatedLinks;
        private boolean _pictures;
        private boolean _categories;
        private boolean _relatedStocks;
        private boolean _alternativeStocks;
        private boolean _intParameters;
        private boolean _stockItem;
        private boolean _stockAttach;
        private boolean _stockSerialNumber;
        private boolean _stockPriceItem;
        private boolean _stockParameters;
        #endregion
        
        public restrictionDataType()
        {
            _relatedFiles = boolean.@true;
            _relatedLinks = boolean.@true;
            _pictures = boolean.@true;
            _categories = boolean.@true;
            _relatedStocks = boolean.@true;
            _alternativeStocks = boolean.@true;
            _intParameters = boolean.@true;
            _stockItem = boolean.@true;
            _stockAttach = boolean.@true;
            _stockSerialNumber = boolean.@true;
            _stockPriceItem = boolean.@true;
            _stockParameters = boolean.@true;
        }
        
        [DefaultValue(boolean.@true)]
        public boolean relatedFiles
        {
            get
            {
                return _relatedFiles;
            }
            set
            {
                _relatedFiles = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean relatedLinks
        {
            get
            {
                return _relatedLinks;
            }
            set
            {
                _relatedLinks = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean pictures
        {
            get
            {
                return _pictures;
            }
            set
            {
                _pictures = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean categories
        {
            get
            {
                return _categories;
            }
            set
            {
                _categories = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean relatedStocks
        {
            get
            {
                return _relatedStocks;
            }
            set
            {
                _relatedStocks = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean alternativeStocks
        {
            get
            {
                return _alternativeStocks;
            }
            set
            {
                _alternativeStocks = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean intParameters
        {
            get
            {
                return _intParameters;
            }
            set
            {
                _intParameters = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean stockAttach
        {
            get
            {
                return _stockAttach;
            }
            set
            {
                _stockAttach = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean stockSerialNumber
        {
            get
            {
                return _stockSerialNumber;
            }
            set
            {
                _stockSerialNumber = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean stockPriceItem
        {
            get
            {
                return _stockPriceItem;
            }
            set
            {
                _stockPriceItem = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean stockParameters
        {
            get
            {
                return _stockParameters;
            }
            set
            {
                _stockParameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_stock.xsd")]
    public partial class listRequestStockType
    {
        #region Private fields
        private List<requestStockType> _requestStock;
        private List<restrictionDataType> _restrictionData;
        private listRequestStockVerType _version;
        private stkVersionType _stockVersion;
        #endregion
        
        public listRequestStockType()
        {
            _restrictionData = new List<restrictionDataType>();
            _requestStock = new List<requestStockType>();
        }
        
        [XmlElement("requestStock")]
        public List<requestStockType> requestStock
        {
            get
            {
                return _requestStock;
            }
            set
            {
                _requestStock = value;
            }
        }
        
        [XmlElement("restrictionData")]
        public List<restrictionDataType> restrictionData
        {
            get
            {
                return _restrictionData;
            }
            set
            {
                _restrictionData = value;
            }
        }
        
        [XmlAttribute]
        public listRequestStockVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public stkVersionType stockVersion
        {
            get
            {
                return _stockVersion;
            }
            set
            {
                _stockVersion = value;
            }
        }
    }
    
    [XmlInclude(typeof(requestStockActionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestStockType
    {
        #region Private fields
        private filterStocksType _filter;
        private string _userFilterName;
        #endregion
        
        public requestStockType()
        {
            _filter = new filterStocksType();
        }
        
        public filterStocksType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterStocksType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private string _code;
        private string _eAN;
        private string _pLU;
        private string _name;
        private refTypeStorage _storage;
        private refType _store;
        private boolean _internet;
        private System.DateTime _lastChanges;
        #endregion
        
        public filterStocksType()
        {
            _store = new refType();
            _storage = new refTypeStorage();
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public string EAN
        {
            get
            {
                return _eAN;
            }
            set
            {
                _eAN = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string PLU
        {
            get
            {
                return _pLU;
            }
            set
            {
                _pLU = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public refTypeStorage storage
        {
            get
            {
                return _storage;
            }
            set
            {
                _storage = value;
            }
        }
        
        public refType store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }
        }
        
        public boolean internet
        {
            get
            {
                return _internet;
            }
            set
            {
                _internet = value;
            }
        }
        
        public System.DateTime lastChanges
        {
            get
            {
                return _lastChanges;
            }
            set
            {
                _lastChanges = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestStockActionType : requestStockType
    {
        #region Private fields
        private boolean _update;
        private boolean _add;
        #endregion
        
        public requestStockActionType()
        {
            _update = boolean.@false;
            _add = boolean.@false;
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@false)]
        public boolean update
        {
            get
            {
                return _update;
            }
            set
            {
                _update = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@false)]
        public boolean add
        {
            get
            {
                return _add;
            }
            set
            {
                _add = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_stock.xsd")]
    public enum listRequestStockVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public enum stkVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestOrderType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestOrderType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listOrderRequestType
    {
        #region Private fields
        private List<requestOrderType> _requestOrder;
        private List<restrictionDocParamType> _restrictionData;
        private listOrderRequestVerType _version;
        private orderTypeType _orderType;
        private ordVersionType _orderVersion;
        private string _extSystem;
        #endregion
        
        public listOrderRequestType()
        {
            _restrictionData = new List<restrictionDocParamType>();
            _requestOrder = new List<requestOrderType>();
        }
        
        [XmlElement("requestOrder")]
        public List<requestOrderType> requestOrder
        {
            get
            {
                return _requestOrder;
            }
            set
            {
                _requestOrder = value;
            }
        }
        
        [XmlElement("restrictionData")]
        public List<restrictionDocParamType> restrictionData
        {
            get
            {
                return _restrictionData;
            }
            set
            {
                _restrictionData = value;
            }
        }
        
        [XmlAttribute]
        public listOrderRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public orderTypeType orderType
        {
            get
            {
                return _orderType;
            }
            set
            {
                _orderType = value;
            }
        }
        
        [XmlAttribute]
        public ordVersionType orderVersion
        {
            get
            {
                return _orderVersion;
            }
            set
            {
                _orderVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class restrictionDocParamType
    {
        #region Private fields
        private boolean _documents;
        private boolean _parameters;
        #endregion
        
        public restrictionDocParamType()
        {
            _documents = boolean.@true;
            _parameters = boolean.@true;
        }
        
        [DefaultValue(boolean.@true)]
        public boolean documents
        {
            get
            {
                return _documents;
            }
            set
            {
                _documents = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listOrderRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/order.xsd")]
    public enum orderTypeType
    {
        issuedOrder,
        receivedOrder,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/order.xsd")]
    public enum ordVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestOfferType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestOfferType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listOfferRequestType
    {
        #region Private fields
        private List<requestOfferType> _requestOffer;
        private listOfferRequestVerType _version;
        private offerTypeType _offerType;
        private ofrVersionType _offerVersion;
        private string _extSystem;
        #endregion
        
        public listOfferRequestType()
        {
            _requestOffer = new List<requestOfferType>();
        }
        
        [XmlElement("requestOffer")]
        public List<requestOfferType> requestOffer
        {
            get
            {
                return _requestOffer;
            }
            set
            {
                _requestOffer = value;
            }
        }
        
        [XmlAttribute]
        public listOfferRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public offerTypeType offerType
        {
            get
            {
                return _offerType;
            }
            set
            {
                _offerType = value;
            }
        }
        
        [XmlAttribute]
        public ofrVersionType offerVersion
        {
            get
            {
                return _offerVersion;
            }
            set
            {
                _offerVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listOfferRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/offer.xsd")]
    public enum offerTypeType
    {
        issuedOffer,
        receivedOffer,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/offer.xsd")]
    public enum ofrVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestEnquiryType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestEnquiryType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listEnquiryRequestType
    {
        #region Private fields
        private List<requestEnquiryType> _requestEnquiry;
        private listEnquiryRequestVerType _version;
        private enquiryTypeType _enquiryType;
        private enqVersionType _enquiryVersion;
        private string _extSystem;
        #endregion
        
        public listEnquiryRequestType()
        {
            _requestEnquiry = new List<requestEnquiryType>();
        }
        
        [XmlElement("requestEnquiry")]
        public List<requestEnquiryType> requestEnquiry
        {
            get
            {
                return _requestEnquiry;
            }
            set
            {
                _requestEnquiry = value;
            }
        }
        
        [XmlAttribute]
        public listEnquiryRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public enquiryTypeType enquiryType
        {
            get
            {
                return _enquiryType;
            }
            set
            {
                _enquiryType = value;
            }
        }
        
        [XmlAttribute]
        public enqVersionType enquiryVersion
        {
            get
            {
                return _enquiryVersion;
            }
            set
            {
                _enquiryVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listEnquiryRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/enquiry.xsd")]
    public enum enquiryTypeType
    {
        issuedEnquiry,
        receivedEnquiry,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/enquiry.xsd")]
    public enum enqVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestInvoiceType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestInvoiceType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listInvoiceRequestType
    {
        #region Private fields
        private List<requestInvoiceType> _requestInvoice;
        private List<restrictionDocParamType> _restrictionData;
        private listInvoiceRequestVerType _version;
        private invoiceTypeType _invoiceType;
        private invVersionType _invoiceVersion;
        private string _extSystem;
        #endregion
        
        public listInvoiceRequestType()
        {
            _restrictionData = new List<restrictionDocParamType>();
            _requestInvoice = new List<requestInvoiceType>();
        }
        
        [XmlElement("requestInvoice")]
        public List<requestInvoiceType> requestInvoice
        {
            get
            {
                return _requestInvoice;
            }
            set
            {
                _requestInvoice = value;
            }
        }
        
        [XmlElement("restrictionData")]
        public List<restrictionDocParamType> restrictionData
        {
            get
            {
                return _restrictionData;
            }
            set
            {
                _restrictionData = value;
            }
        }
        
        [XmlAttribute]
        public listInvoiceRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public invoiceTypeType invoiceType
        {
            get
            {
                return _invoiceType;
            }
            set
            {
                _invoiceType = value;
            }
        }
        
        [XmlAttribute]
        public invVersionType invoiceVersion
        {
            get
            {
                return _invoiceVersion;
            }
            set
            {
                _invoiceVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listInvoiceRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public enum invoiceTypeType
    {
        issuedInvoice,
        issuedCreditNotice,
        issuedDebitNote,
        issuedAdvanceInvoice,
        receivable,
        issuedProformaInvoice,
        penalty,
        issuedCorrectiveTax,
        receivedInvoice,
        receivedCreditNotice,
        receivedDebitNote,
        receivedAdvanceInvoice,
        commitment,
        receivedProformaInvoice,
        receivedCorrectiveTax,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public enum invVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_addBook.xsd")]
    public partial class listAddressBookRequestType
    {
        #region Private fields
        private List<requestAddressBookType> _requestAddressBook;
        private listAddressBookRequestVerType _version;
        private adbVersionType _addressBookVersion;
        private string _extSystem;
        #endregion
        
        public listAddressBookRequestType()
        {
            _requestAddressBook = new List<requestAddressBookType>();
        }
        
        [XmlElement("requestAddressBook")]
        public List<requestAddressBookType> requestAddressBook
        {
            get
            {
                return _requestAddressBook;
            }
            set
            {
                _requestAddressBook = value;
            }
        }
        
        [XmlAttribute]
        public listAddressBookRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public adbVersionType addressBookVersion
        {
            get
            {
                return _addressBookVersion;
            }
            set
            {
                _addressBookVersion = value;
            }
        }
        
        [XmlAttribute]
        public string extSystem
        {
            get
            {
                return _extSystem;
            }
            set
            {
                _extSystem = value;
            }
        }
    }
    
    [XmlInclude(typeof(requestAddressBookActionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestAddressBookType
    {
        #region Private fields
        private filterAdbsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestAddressBookType()
        {
            _filter = new filterAdbsType();
        }
        
        public filterAdbsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterAdbsType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private string _company;
        private string _name;
        private string _city;
        private string _street;
        private string _zip;
        private string _ico;
        private string _dic;
        private numberADType _number;
        private System.DateTime _lastChanges;
        #endregion
        
        public filterAdbsType()
        {
            _number = new numberADType();
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        
        public string street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        
        public string zip
        {
            get
            {
                return _zip;
            }
            set
            {
                _zip = value;
            }
        }
        
        public string ico
        {
            get
            {
                return _ico;
            }
            set
            {
                _ico = value;
            }
        }
        
        public string dic
        {
            get
            {
                return _dic;
            }
            set
            {
                _dic = value;
            }
        }
        
        public numberADType number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public System.DateTime lastChanges
        {
            get
            {
                return _lastChanges;
            }
            set
            {
                _lastChanges = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestAddressBookActionType : requestAddressBookType
    {
        #region Private fields
        private boolean _update;
        private boolean _add;
        #endregion
        
        public requestAddressBookActionType()
        {
            _update = boolean.@false;
            _add = boolean.@false;
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@false)]
        public boolean update
        {
            get
            {
                return _update;
            }
            set
            {
                _update = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@false)]
        public boolean add
        {
            get
            {
                return _add;
            }
            set
            {
                _add = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list_addBook.xsd")]
    public enum listAddressBookRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/addressbook.xsd")]
    public enum adbVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestAccountancyType
    {
        #region Private fields
        private filterDocsType _filter;
        private string _userFilterName;
        #endregion
        
        public requestAccountancyType()
        {
            _filter = new filterDocsType();
        }
        
        public filterDocsType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        
        public string userFilterName
        {
            get
            {
                return _userFilterName;
            }
            set
            {
                _userFilterName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public partial class listAccountancyRequestType
    {
        #region Private fields
        private requestAccountancyType _requestAccountancy;
        private listAccountancyRequestVerType _version;
        private actVersionType _accountancyVersion;
        #endregion
        
        public listAccountancyRequestType()
        {
            _requestAccountancy = new requestAccountancyType();
        }
        
        public requestAccountancyType requestAccountancy
        {
            get
            {
                return _requestAccountancy;
            }
            set
            {
                _requestAccountancy = value;
            }
        }
        
        [XmlAttribute]
        public listAccountancyRequestVerType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public actVersionType accountancyVersion
        {
            get
            {
                return _accountancyVersion;
            }
            set
            {
                _accountancyVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
    public enum listAccountancyRequestVerType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/accountancy.xsd")]
    public enum actVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bankAccount.xsd")]
    public partial class currencyBankAccountType
    {
        #region Private fields
        private refType _currency;
        private rateType _rate;
        #endregion
        
        public currencyBankAccountType()
        {
            _currency = new refType();
        }
        
        public refType currency
        {
            get
            {
                return _currency;
            }
            set
            {
                _currency = value;
            }
        }
        
        public rateType rate
        {
            get
            {
                return _rate;
            }
            set
            {
                _rate = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bankAccount.xsd")]
    public enum rateType
    {
        daily,
        @fixed,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bankAccount.xsd")]
    public partial class bankAccountHeaderType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private string _ids;
        private string _numberAccount;
        private string _codeBank;
        private string _nameBank;
        private string _symSpec;
        private string _iBAN;
        private string _sWIFT;
        private refType _analyticAccount;
        private currencyBankAccountType _currencyBankAccount;
        private System.DateTime _cancelled;
        private string _homebanking;
        private string _payTerminal;
        private string _note;
        #endregion
        
        public bankAccountHeaderType()
        {
            _currencyBankAccount = new currencyBankAccountType();
            _analyticAccount = new refType();
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public string numberAccount
        {
            get
            {
                return _numberAccount;
            }
            set
            {
                _numberAccount = value;
            }
        }
        
        public string codeBank
        {
            get
            {
                return _codeBank;
            }
            set
            {
                _codeBank = value;
            }
        }
        
        public string nameBank
        {
            get
            {
                return _nameBank;
            }
            set
            {
                _nameBank = value;
            }
        }
        
        public string symSpec
        {
            get
            {
                return _symSpec;
            }
            set
            {
                _symSpec = value;
            }
        }
        
        public string IBAN
        {
            get
            {
                return _iBAN;
            }
            set
            {
                _iBAN = value;
            }
        }
        
        public string SWIFT
        {
            get
            {
                return _sWIFT;
            }
            set
            {
                _sWIFT = value;
            }
        }
        
        public refType analyticAccount
        {
            get
            {
                return _analyticAccount;
            }
            set
            {
                _analyticAccount = value;
            }
        }
        
        public currencyBankAccountType currencyBankAccount
        {
            get
            {
                return _currencyBankAccount;
            }
            set
            {
                _currencyBankAccount = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime cancelled
        {
            get
            {
                return _cancelled;
            }
            set
            {
                _cancelled = value;
            }
        }
        
        public string homebanking
        {
            get
            {
                return _homebanking;
            }
            set
            {
                _homebanking = value;
            }
        }
        
        public string payTerminal
        {
            get
            {
                return _payTerminal;
            }
            set
            {
                _payTerminal = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
    }
    
    [XmlInclude(typeof(requestExtIdActionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestExtIdType
    {
        #region Private fields
        private filterExtIdType _filter;
        #endregion
        
        public requestExtIdType()
        {
            _filter = new filterExtIdType();
        }
        
        public filterExtIdType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterExtIdType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        #endregion
        
        public filterExtIdType()
        {
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestExtIdActionType : requestExtIdType
    {
        #region Private fields
        private boolean _update;
        private boolean _add;
        #endregion
        
        public requestExtIdActionType()
        {
            _update = boolean.@false;
            _add = boolean.@false;
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@false)]
        public boolean update
        {
            get
            {
                return _update;
            }
            set
            {
                _update = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@false)]
        public boolean add
        {
            get
            {
                return _add;
            }
            set
            {
                _add = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="actionTypeType", Namespace="http://www.stormware.cz/schema/version_2/bankAccount.xsd")]
    public partial class actionTypeType4
    {
        #region Private fields
        private requestExtIdActionType _item;
        #endregion
        
        public actionTypeType4()
        {
            _item = new requestExtIdActionType();
        }
        
        [XmlElement("add")]
        public requestExtIdActionType Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bankAccount.xsd")]
    public partial class bankAccountType
    {
        #region Private fields
        private actionTypeType4 _actionType;
        private bankAccountHeaderType _bankAccountHeader;
        private bkaVersionType _version;
        #endregion
        
        public bankAccountType()
        {
            _bankAccountHeader = new bankAccountHeaderType();
            _actionType = new actionTypeType4();
        }
        
        public actionTypeType4 actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        public bankAccountHeaderType bankAccountHeader
        {
            get
            {
                return _bankAccountHeader;
            }
            set
            {
                _bankAccountHeader = value;
            }
        }
        
        [XmlAttribute]
        public bkaVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public partial class bankSummaryType
    {
        #region Private fields
        private typeRoundingDocument1 _roundingDocument;
        private typeRoundingVAT _roundingVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        private typeCurrencyForeign _foreignCurrency;
        #endregion
        
        public bankSummaryType()
        {
            _foreignCurrency = new typeCurrencyForeign();
            _homeCurrency = new typeCurrencyHome();
        }
        
        public typeRoundingDocument1 roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public typeRoundingVAT roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeign foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(TypeName="typeRoundingDocument", Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public enum typeRoundingDocument1
    {
        none,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public enum typeRoundingVAT
    {
        none,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum typeCalculateVATInclusivePriceType
    {
        VATNewMethod,
        VATOriginalMethod,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class typeCurrencyHome
    {
        #region Private fields
        private double _priceNone;
        private double _priceLow;
        private double _priceLowVAT;
        private double _priceLowSum;
        private double _priceHigh;
        private double _priceHighVAT;
        private double _priceHighSum;
        private double _price3;
        private double _price3VAT;
        private double _price3Sum;
        private typeRound _round;
        #endregion
        
        public typeCurrencyHome()
        {
            _round = new typeRound();
        }
        
        public double priceNone
        {
            get
            {
                return _priceNone;
            }
            set
            {
                _priceNone = value;
            }
        }
        
        public double priceLow
        {
            get
            {
                return _priceLow;
            }
            set
            {
                _priceLow = value;
            }
        }
        
        public double priceLowVAT
        {
            get
            {
                return _priceLowVAT;
            }
            set
            {
                _priceLowVAT = value;
            }
        }
        
        public double priceLowSum
        {
            get
            {
                return _priceLowSum;
            }
            set
            {
                _priceLowSum = value;
            }
        }
        
        public double priceHigh
        {
            get
            {
                return _priceHigh;
            }
            set
            {
                _priceHigh = value;
            }
        }
        
        public double priceHighVAT
        {
            get
            {
                return _priceHighVAT;
            }
            set
            {
                _priceHighVAT = value;
            }
        }
        
        public double priceHighSum
        {
            get
            {
                return _priceHighSum;
            }
            set
            {
                _priceHighSum = value;
            }
        }
        
        public double price3
        {
            get
            {
                return _price3;
            }
            set
            {
                _price3 = value;
            }
        }
        
        public double price3VAT
        {
            get
            {
                return _price3VAT;
            }
            set
            {
                _price3VAT = value;
            }
        }
        
        public double price3Sum
        {
            get
            {
                return _price3Sum;
            }
            set
            {
                _price3Sum = value;
            }
        }
        
        public typeRound round
        {
            get
            {
                return _round;
            }
            set
            {
                _round = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class typeRound
    {
        #region Private fields
        private double[] _items;
        private ItemsChoiceType[] _itemsElementName;
        #endregion
        
        [XmlElement("priceRound")]
        [XmlElement("priceRoundSum")]
        [XmlElement("priceRoundSumVAT")]
        [XmlElement("rateVATround")]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public double[] Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return _itemsElementName;
            }
            set
            {
                _itemsElementName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        priceRound,
        priceRoundSum,
        priceRoundSumVAT,
        rateVATround,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class typeCurrencyForeign
    {
        #region Private fields
        private refType _currency;
        private float _rate;
        private string _amount;
        private double _priceSum;
        private typeRound _round;
        #endregion
        
        public typeCurrencyForeign()
        {
            _round = new typeRound();
            _currency = new refType();
        }
        
        public refType currency
        {
            get
            {
                return _currency;
            }
            set
            {
                _currency = value;
            }
        }
        
        public float rate
        {
            get
            {
                return _rate;
            }
            set
            {
                _rate = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        
        public double priceSum
        {
            get
            {
                return _priceSum;
            }
            set
            {
                _priceSum = value;
            }
        }
        
        public typeRound round
        {
            get
            {
                return _round;
            }
            set
            {
                _round = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="typeCurrencyForeignItem", Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public partial class typeCurrencyForeignItem1
    {
        #region Private fields
        private double _unitPrice;
        #endregion
        
        public double unitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="typeCurrencyHomeItem", Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public partial class typeCurrencyHomeItem1
    {
        #region Private fields
        private double _unitPrice;
        #endregion
        
        public double unitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public partial class bankItemType
    {
        #region Private fields
        private string _text;
        private float _quantity;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem1 _homeCurrency;
        private typeCurrencyForeignItem1 _foreignCurrency;
        private typeCurrencyHomeItem _homeCurrencyJU;
        private typeCurrencyForeignItem _foreignCurrencyJU;
        private MOSStype _typeServiceMOSS;
        private string _note;
        private string _symPar;
        private refType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private bool _pDP;
        private string _codePDP;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private List<parameterDocType> _parameters;
        #endregion
        
        public bankItemType()
        {
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new refType();
            _typeServiceMOSS = new MOSStype();
            _foreignCurrencyJU = new typeCurrencyForeignItem();
            _homeCurrencyJU = new typeCurrencyHomeItem();
            _foreignCurrency = new typeCurrencyForeignItem1();
            _homeCurrency = new typeCurrencyHomeItem1();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem1 homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem1 foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrencyJU
        {
            get
            {
                return _homeCurrencyJU;
            }
            set
            {
                _homeCurrencyJU = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrencyJU
        {
            get
            {
                return _foreignCurrencyJU;
            }
            set
            {
                _foreignCurrencyJU = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public refType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public bool PDP
        {
            get
            {
                return _pDP;
            }
            set
            {
                _pDP = value;
            }
        }
        
        public string CodePDP
        {
            get
            {
                return _codePDP;
            }
            set
            {
                _codePDP = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum vatRateType
    {
        none,
        high,
        low,
        third,
        historyHigh,
        historyLow,
        historyThird,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class typeCurrencyHomeItem
    {
        #region Private fields
        private double _unitPrice;
        private double _price;
        private double _priceVAT;
        private double _priceSum;
        #endregion
        
        public double unitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }
        
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        
        public double priceVAT
        {
            get
            {
                return _priceVAT;
            }
            set
            {
                _priceVAT = value;
            }
        }
        
        public double priceSum
        {
            get
            {
                return _priceSum;
            }
            set
            {
                _priceSum = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class typeCurrencyForeignItem
    {
        #region Private fields
        private double _unitPrice;
        private double _price;
        private double _priceVAT;
        private double _priceSum;
        #endregion
        
        public double unitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }
        
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        
        public double priceVAT
        {
            get
            {
                return _priceVAT;
            }
            set
            {
                _priceVAT = value;
            }
        }
        
        public double priceSum
        {
            get
            {
                return _priceSum;
            }
            set
            {
                _priceSum = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class MOSStype
    {
        #region Private fields
        private string _ids;
        #endregion
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class classificationVATType
    {
        #region Private fields
        private string _id;
        private string _ids;
        private classificationVATTypeClassificationVATType _classificationVATType1;
        #endregion
        
        public classificationVATType()
        {
            _classificationVATType1 = classificationVATTypeClassificationVATType.inland;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        [XmlElement("classificationVATType")]
        [DefaultValue(classificationVATTypeClassificationVATType.inland)]
        public classificationVATTypeClassificationVATType classificationVATType1
        {
            get
            {
                return _classificationVATType1;
            }
            set
            {
                _classificationVATType1 = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum classificationVATTypeClassificationVATType
    {
        inland,
        nonSubsume,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class parameterDocType
    {
        #region Private fields
        private string _name;
        private object _item;
        private ItemChoiceType2 _itemElementName;
        private refType _list;
        #endregion
        
        public parameterDocType()
        {
            _list = new refType();
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [XmlElement("booleanValue", typeof(boolean))]
        [XmlElement("currencyValue", typeof(double))]
        [XmlElement("datetimeValue", typeof(System.DateTime), DataType="date")]
        [XmlElement("integerValue", typeof(string), DataType="integer")]
        [XmlElement("listValueRef", typeof(refType))]
        [XmlElement("memoValue", typeof(string))]
        [XmlElement("numberValue", typeof(float))]
        [XmlElement("textValue", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlIgnore]
        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return _itemElementName;
            }
            set
            {
                _itemElementName = value;
            }
        }
        
        public refType list
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        booleanValue,
        currencyValue,
        datetimeValue,
        integerValue,
        listValueRef,
        memoValue,
        numberValue,
        textValue,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public partial class statementNumberType
    {
        #region Private fields
        private string _statementNumber;
        private string _numberMovement;
        #endregion
        
        public string statementNumber
        {
            get
            {
                return _statementNumber;
            }
            set
            {
                _statementNumber = value;
            }
        }
        
        public string numberMovement
        {
            get
            {
                return _numberMovement;
            }
            set
            {
                _numberMovement = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public partial class bankHeaderType
    {
        #region Private fields
        private string _id;
        private bankTypeType _bankType;
        private refType _account;
        private string _number;
        private statementNumberType _statementNumber;
        private string _symVar;
        private string _dateStatement;
        private System.DateTime _datePayment;
        private accountingType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private string _text;
        private address _partnerIdentity;
        private myAddress _myIdentity;
        private bankHeaderTypePaymentAccount _paymentAccount;
        private string _symConst;
        private string _symSpec;
        private string _symPar;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private MOSStype _mOSS;
        private List<string> _evidentiaryResourcesMOSS;
        private string _accountingPeriodMOSS;
        private string _note;
        private string _intNote;
        private boolean _histRate;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        #endregion
        
        public bankHeaderType()
        {
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _evidentiaryResourcesMOSS = new List<string>();
            _mOSS = new MOSStype();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _paymentAccount = new bankHeaderTypePaymentAccount();
            _myIdentity = new myAddress();
            _partnerIdentity = new address();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new accountingType();
            _statementNumber = new statementNumberType();
            _account = new refType();
            _histRate = boolean.@false;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public bankTypeType bankType
        {
            get
            {
                return _bankType;
            }
            set
            {
                _bankType = value;
            }
        }
        
        public refType account
        {
            get
            {
                return _account;
            }
            set
            {
                _account = value;
            }
        }
        
        public string number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public statementNumberType statementNumber
        {
            get
            {
                return _statementNumber;
            }
            set
            {
                _statementNumber = value;
            }
        }
        
        public string symVar
        {
            get
            {
                return _symVar;
            }
            set
            {
                _symVar = value;
            }
        }
        
        public string dateStatement
        {
            get
            {
                return _dateStatement;
            }
            set
            {
                _dateStatement = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime datePayment
        {
            get
            {
                return _datePayment;
            }
            set
            {
                _datePayment = value;
            }
        }
        
        public accountingType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public myAddress myIdentity
        {
            get
            {
                return _myIdentity;
            }
            set
            {
                _myIdentity = value;
            }
        }
        
        public bankHeaderTypePaymentAccount paymentAccount
        {
            get
            {
                return _paymentAccount;
            }
            set
            {
                _paymentAccount = value;
            }
        }
        
        public string symConst
        {
            get
            {
                return _symConst;
            }
            set
            {
                _symConst = value;
            }
        }
        
        public string symSpec
        {
            get
            {
                return _symSpec;
            }
            set
            {
                _symSpec = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public MOSStype MOSS
        {
            get
            {
                return _mOSS;
            }
            set
            {
                _mOSS = value;
            }
        }
        
        [XmlArrayItemAttribute("ids", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<string> evidentiaryResourcesMOSS
        {
            get
            {
                return _evidentiaryResourcesMOSS;
            }
            set
            {
                _evidentiaryResourcesMOSS = value;
            }
        }
        
        public string accountingPeriodMOSS
        {
            get
            {
                return _accountingPeriodMOSS;
            }
            set
            {
                _accountingPeriodMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public enum bankTypeType
    {
        receipt,
        expense,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class accountingType
    {
        #region Private fields
        private string _id;
        private string _ids;
        private accountingTypeAccountingType _accountingType1;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        [XmlElement("accountingType")]
        public accountingTypeAccountingType accountingType1
        {
            get
            {
                return _accountingType1;
            }
            set
            {
                _accountingType1 = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum accountingTypeAccountingType
    {
        withoutAccounting,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class address
    {
        #region Private fields
        private string _id;
        private List<extIdType> _extId;
        private addressType _address1;
        private List<shipToAddressType> _shipToAddress;
        #endregion
        
        public address()
        {
            _shipToAddress = new List<shipToAddressType>();
            _address1 = new addressType();
            _extId = new List<extIdType>();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement("extId")]
        public List<extIdType> extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        [XmlElement("address")]
        public addressType address1
        {
            get
            {
                return _address1;
            }
            set
            {
                _address1 = value;
            }
        }
        
        [XmlElement("shipToAddress")]
        public List<shipToAddressType> shipToAddress
        {
            get
            {
                return _shipToAddress;
            }
            set
            {
                _shipToAddress = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class addressType
    {
        #region Private fields
        private string _company;
        private string _division;
        private string _name;
        private string _city;
        private string _street;
        private string _zip;
        private string _ico;
        private string _dic;
        private VATPayerTypeType _vATPayerType;
        private string _icDph;
        private refType _country;
        private string _phone;
        private string _mobilPhone;
        private string _fax;
        private string _email;
        private bool _linkToAddress;
        #endregion
        
        public addressType()
        {
            _country = new refType();
            _linkToAddress = false;
        }
        
        public string company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        
        public string division
        {
            get
            {
                return _division;
            }
            set
            {
                _division = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        
        public string street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        
        public string zip
        {
            get
            {
                return _zip;
            }
            set
            {
                _zip = value;
            }
        }
        
        public string ico
        {
            get
            {
                return _ico;
            }
            set
            {
                _ico = value;
            }
        }
        
        public string dic
        {
            get
            {
                return _dic;
            }
            set
            {
                _dic = value;
            }
        }
        
        public VATPayerTypeType VATPayerType
        {
            get
            {
                return _vATPayerType;
            }
            set
            {
                _vATPayerType = value;
            }
        }
        
        public string icDph
        {
            get
            {
                return _icDph;
            }
            set
            {
                _icDph = value;
            }
        }
        
        public refType country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        
        public string mobilPhone
        {
            get
            {
                return _mobilPhone;
            }
            set
            {
                _mobilPhone = value;
            }
        }
        
        public string fax
        {
            get
            {
                return _fax;
            }
            set
            {
                _fax = value;
            }
        }
        
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(false)]
        public bool linkToAddress
        {
            get
            {
                return _linkToAddress;
            }
            set
            {
                _linkToAddress = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum VATPayerTypeType
    {
        payer,
        [XmlEnumAttribute("non-payer")]
        nonpayer,
        [XmlEnumAttribute("")]
        Item,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class shipToAddressType
    {
        #region Private fields
        private actionTypeItem _actionType;
        private string _id;
        private string _extId;
        private string _company;
        private string _division;
        private string _name;
        private string _city;
        private string _street;
        private string _zip;
        private refType _country;
        private string _phone;
        private string _email;
        private boolean _defaultShipAddress;
        #endregion
        
        public shipToAddressType()
        {
            _country = new refType();
            _actionType = new actionTypeItem();
            _defaultShipAddress = boolean.@false;
        }
        
        public actionTypeItem actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        
        public string division
        {
            get
            {
                return _division;
            }
            set
            {
                _division = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        
        public string street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        
        public string zip
        {
            get
            {
                return _zip;
            }
            set
            {
                _zip = value;
            }
        }
        
        public refType country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean defaultShipAddress
        {
            get
            {
                return _defaultShipAddress;
            }
            set
            {
                _defaultShipAddress = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class actionTypeItem
    {
        #region Private fields
        private object _item;
        private ItemChoiceType1 _itemElementName;
        #endregion
        
        [XmlElement("add", typeof(string))]
        [XmlElement("delete", typeof(requestItemType))]
        [XmlElement("update", typeof(requestItemType))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlIgnore]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return _itemElementName;
            }
            set
            {
                _itemElementName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class requestItemType
    {
        #region Private fields
        private filterExtIdType _filter;
        #endregion
        
        public requestItemType()
        {
            _filter = new filterExtIdType();
        }
        
        public filterExtIdType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        add,
        delete,
        update,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class myAddress
    {
        #region Private fields
        private addressInternetType _address;
        private establishmentType _establishment;
        #endregion
        
        public myAddress()
        {
            _establishment = new establishmentType();
            _address = new addressInternetType();
        }
        
        public addressInternetType address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        
        public establishmentType establishment
        {
            get
            {
                return _establishment;
            }
            set
            {
                _establishment = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class addressInternetType
    {
        #region Private fields
        private string _company;
        private string _title;
        private string _surname;
        private string _name;
        private string _city;
        private string _street;
        private string _number;
        private string _zip;
        private string _ico;
        private string _dic;
        private string _icDph;
        private string _phone;
        private string _mobilPhone;
        private string _fax;
        private string _email;
        private string _www;
        #endregion
        
        public string company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        
        public string title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        
        public string surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        
        public string street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        
        public string number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public string zip
        {
            get
            {
                return _zip;
            }
            set
            {
                _zip = value;
            }
        }
        
        public string ico
        {
            get
            {
                return _ico;
            }
            set
            {
                _ico = value;
            }
        }
        
        public string dic
        {
            get
            {
                return _dic;
            }
            set
            {
                _dic = value;
            }
        }
        
        public string icDph
        {
            get
            {
                return _icDph;
            }
            set
            {
                _icDph = value;
            }
        }
        
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        
        public string mobilPhone
        {
            get
            {
                return _mobilPhone;
            }
            set
            {
                _mobilPhone = value;
            }
        }
        
        public string fax
        {
            get
            {
                return _fax;
            }
            set
            {
                _fax = value;
            }
        }
        
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        
        public string www
        {
            get
            {
                return _www;
            }
            set
            {
                _www = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class establishmentType
    {
        #region Private fields
        private string _company;
        private string _city;
        private string _street;
        private string _zip;
        #endregion
        
        public string company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        
        public string street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        
        public string zip
        {
            get
            {
                return _zip;
            }
            set
            {
                _zip = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public partial class bankHeaderTypePaymentAccount
    {
        #region Private fields
        private string _accountNo;
        private string _bankCode;
        #endregion
        
        public string accountNo
        {
            get
            {
                return _accountNo;
            }
            set
            {
                _accountNo = value;
            }
        }
        
        public string bankCode
        {
            get
            {
                return _bankCode;
            }
            set
            {
                _bankCode = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class labelType
    {
        #region Private fields
        private string _id;
        private string _ids;
        private attributeActionType _actionType;
        #endregion
        
        public labelType()
        {
            _actionType = attributeActionType.add;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(attributeActionType.add)]
        public attributeActionType actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum attributeActionType
    {
        add,
        delete,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
    public partial class bankType
    {
        #region Private fields
        private bankHeaderType _bankHeader;
        private List<bankItemType> _bankDetail;
        private bankSummaryType _bankSummary;
        private bnkVersionType _version;
        #endregion
        
        public bankType()
        {
            _bankSummary = new bankSummaryType();
            _bankDetail = new List<bankItemType>();
            _bankHeader = new bankHeaderType();
        }
        
        public bankHeaderType bankHeader
        {
            get
            {
                return _bankHeader;
            }
            set
            {
                _bankHeader = value;
            }
        }
        
        [XmlArrayItemAttribute("bankItem", IsNullable=false)]
        public List<bankItemType> bankDetail
        {
            get
            {
                return _bankDetail;
            }
            set
            {
                _bankDetail = value;
            }
        }
        
        public bankSummaryType bankSummary
        {
            get
            {
                return _bankSummary;
            }
            set
            {
                _bankSummary = value;
            }
        }
        
        [XmlAttribute]
        public bnkVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/productRequirement.xsd")]
    public partial class productRequirementItemType
    {
        #region Private fields
        private float _quantity;
        private float _produced;
        private stockItemType _stockItem;
        private System.DateTime _expirationDate;
        private string _note;
        #endregion
        
        public productRequirementItemType()
        {
            _stockItem = new stockItemType();
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public float produced
        {
            get
            {
                return _produced;
            }
            set
            {
                _produced = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime expirationDate
        {
            get
            {
                return _expirationDate;
            }
            set
            {
                _expirationDate = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class stockItemType
    {
        #region Private fields
        private refType _store;
        private stockRefType _stockItem;
        private string _serialNumber;
        private extIdType _serialNumberExtId;
        #endregion
        
        public stockItemType()
        {
            _serialNumberExtId = new extIdType();
            _stockItem = new stockRefType();
            _store = new refType();
        }
        
        public refType store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }
        }
        
        public stockRefType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public string serialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                _serialNumber = value;
            }
        }
        
        public extIdType serialNumberExtId
        {
            get
            {
                return _serialNumberExtId;
            }
            set
            {
                _serialNumberExtId = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class stockRefType
    {
        #region Private fields
        private string _id;
        private string _ids;
        private extIdType _extId;
        private string _eAN;
        private string _pLU;
        private bool _insertAttachStock;
        private bool _applyUserSettingsFilterOnTheStore;
        #endregion
        
        public stockRefType()
        {
            _extId = new extIdType();
            _insertAttachStock = true;
            _applyUserSettingsFilterOnTheStore = true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string EAN
        {
            get
            {
                return _eAN;
            }
            set
            {
                _eAN = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string PLU
        {
            get
            {
                return _pLU;
            }
            set
            {
                _pLU = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(true)]
        public bool insertAttachStock
        {
            get
            {
                return _insertAttachStock;
            }
            set
            {
                _insertAttachStock = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(true)]
        public bool applyUserSettingsFilterOnTheStore
        {
            get
            {
                return _applyUserSettingsFilterOnTheStore;
            }
            set
            {
                _applyUserSettingsFilterOnTheStore = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/productRequirement.xsd")]
    public partial class productRequirementHeaderType
    {
        #region Private fields
        private string _id;
        private numberType1 _number;
        private System.DateTime _date;
        private System.DateTime _dateTill;
        private string _text;
        private address _partnerIdentity;
        private refType _centreSource;
        private refType _centreDestination;
        private refType _activity;
        private refType _contract;
        private boolean _isExecuted;
        private boolean _isProduced;
        private boolean _isReserved;
        private string _note;
        private string _intNote;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        #endregion
        
        public productRequirementHeaderType()
        {
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _contract = new refType();
            _activity = new refType();
            _centreDestination = new refType();
            _centreSource = new refType();
            _partnerIdentity = new address();
            _number = new numberType1();
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTill
        {
            get
            {
                return _dateTill;
            }
            set
            {
                _dateTill = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public refType centreSource
        {
            get
            {
                return _centreSource;
            }
            set
            {
                _centreSource = value;
            }
        }
        
        public refType centreDestination
        {
            get
            {
                return _centreDestination;
            }
            set
            {
                _centreDestination = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public boolean isExecuted
        {
            get
            {
                return _isExecuted;
            }
            set
            {
                _isExecuted = value;
            }
        }
        
        public boolean isProduced
        {
            get
            {
                return _isProduced;
            }
            set
            {
                _isProduced = value;
            }
        }
        
        public boolean isReserved
        {
            get
            {
                return _isReserved;
            }
            set
            {
                _isReserved = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/productRequirement.xsd")]
    public partial class productRequirementType
    {
        #region Private fields
        private productRequirementHeaderType _productRequirementHeader;
        private List<productRequirementItemType> _productRequirementDetail;
        private List<printerSettingsType> _print;
        private productRequirementVersionType _version;
        #endregion
        
        public productRequirementType()
        {
            _print = new List<printerSettingsType>();
            _productRequirementDetail = new List<productRequirementItemType>();
            _productRequirementHeader = new productRequirementHeaderType();
        }
        
        public productRequirementHeaderType productRequirementHeader
        {
            get
            {
                return _productRequirementHeader;
            }
            set
            {
                _productRequirementHeader = value;
            }
        }
        
        [XmlArrayItemAttribute("productRequirementItem", IsNullable=false)]
        public List<productRequirementItemType> productRequirementDetail
        {
            get
            {
                return _productRequirementDetail;
            }
            set
            {
                _productRequirementDetail = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public productRequirementVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/GDPR.xsd")]
    public partial class GDPRHeaderType
    {
        #region Private fields
        private string _id;
        private GDPRTypeType _gDPRType;
        private string _name;
        private string _description;
        private string _valueOfValidity;
        private typeOfValidityType _typeOfValidity;
        private string _note;
        private boolean _markRecord;
        #endregion
        
        public GDPRHeaderType()
        {
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public GDPRTypeType GDPRType
        {
            get
            {
                return _gDPRType;
            }
            set
            {
                _gDPRType = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string valueOfValidity
        {
            get
            {
                return _valueOfValidity;
            }
            set
            {
                _valueOfValidity = value;
            }
        }
        
        public typeOfValidityType typeOfValidity
        {
            get
            {
                return _typeOfValidity;
            }
            set
            {
                _typeOfValidity = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/GDPR.xsd")]
    public enum GDPRTypeType
    {
        agreement,
        meetingContract,
        legalObligations,
        importantInterests,
        publicInterest,
        rightInterest,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/GDPR.xsd")]
    public enum typeOfValidityType
    {
        unlimited,
        day,
        week,
        month,
        year,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/GDPR.xsd")]
    public partial class GDPRType
    {
        #region Private fields
        private GDPRHeaderType _gDPRHeader;
        private GDPRVersionType _version;
        #endregion
        
        public GDPRType()
        {
            _gDPRHeader = new GDPRHeaderType();
        }
        
        public GDPRHeaderType GDPRHeader
        {
            get
            {
                return _gDPRHeader;
            }
            set
            {
                _gDPRHeader = value;
            }
        }
        
        [XmlAttribute]
        public GDPRVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/numericalSeries.xsd")]
    public partial class periodAccountUnitType
    {
        #region Private fields
        private System.DateTime _dateFrom;
        private System.DateTime _dateTill;
        #endregion
        
        [XmlElement(DataType="date")]
        public System.DateTime dateFrom
        {
            get
            {
                return _dateFrom;
            }
            set
            {
                _dateFrom = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTill
        {
            get
            {
                return _dateTill;
            }
            set
            {
                _dateTill = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/numericalSeries.xsd")]
    public partial class numericalSeriesHeaderType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private string _prefix;
        private string _number;
        private string _topNumber;
        private string _name;
        private CRadyAgendaType _agenda;
        private typeOfDocumentType _typeOfDocument;
        private refType _cashAccount;
        private refType _cashbox;
        private periodType _period;
        private periodAccountUnitType _periodAccountUnit;
        private refType _unitPZD;
        private string _year;
        private string _note;
        private boolean _markRecord;
        private List<parameterDocType> _parameters;
        #endregion
        
        public numericalSeriesHeaderType()
        {
            _parameters = new List<parameterDocType>();
            _unitPZD = new refType();
            _periodAccountUnit = new periodAccountUnitType();
            _cashbox = new refType();
            _cashAccount = new refType();
            _extId = new extIdType();
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string prefix
        {
            get
            {
                return _prefix;
            }
            set
            {
                _prefix = value;
            }
        }
        
        public string number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public string topNumber
        {
            get
            {
                return _topNumber;
            }
            set
            {
                _topNumber = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public CRadyAgendaType agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
        
        public typeOfDocumentType typeOfDocument
        {
            get
            {
                return _typeOfDocument;
            }
            set
            {
                _typeOfDocument = value;
            }
        }
        
        public refType cashAccount
        {
            get
            {
                return _cashAccount;
            }
            set
            {
                _cashAccount = value;
            }
        }
        
        public refType cashbox
        {
            get
            {
                return _cashbox;
            }
            set
            {
                _cashbox = value;
            }
        }
        
        public periodType period
        {
            get
            {
                return _period;
            }
            set
            {
                _period = value;
            }
        }
        
        public periodAccountUnitType periodAccountUnit
        {
            get
            {
                return _periodAccountUnit;
            }
            set
            {
                _periodAccountUnit = value;
            }
        }
        
        public refType unitPZD
        {
            get
            {
                return _unitPZD;
            }
            set
            {
                _unitPZD = value;
            }
        }
        
        [XmlElement(DataType="gYear")]
        public string year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/numericalSeries.xsd")]
    public enum typeOfDocumentType
    {
        vydane_faktury_faktura,
        vydane_faktury_opravny_danovy_doklad,
        vydane_faktury_dobropis,
        vydane_faktury_vrubopis,
        prijate_faktury_faktura,
        prijate_faktury_opravny_danovy_doklad,
        prijate_faktury_dobropis,
        prijate_faktury_vrubopis,
        pohledavky_pohledavka,
        pohledavky_penale,
        pokladna_prijem,
        pokladna_vydej,
        prodejky_vklad,
        prodejky_vyber,
        prodejky_prodejka,
        reklamace_zakaznicka,
        reklamace_skladova,
        reklamace_nakupni,
        reklamace_reklamacni_list,
        servis_pozarucni,
        servis_zarucni,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/numericalSeries.xsd")]
    public enum periodType
    {
        permanent,
        yearlong,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/numericalSeries.xsd")]
    public partial class numericalSeriesType
    {
        #region Private fields
        private numericalSeriesHeaderType _numericalSeriesHeader;
        private nmsVersionType _version;
        #endregion
        
        public numericalSeriesType()
        {
            _numericalSeriesHeader = new numericalSeriesHeaderType();
        }
        
        public numericalSeriesHeaderType numericalSeriesHeader
        {
            get
            {
                return _numericalSeriesHeader;
            }
            set
            {
                _numericalSeriesHeader = value;
            }
        }
        
        [XmlAttribute]
        public nmsVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/inventoryLists.xsd")]
    public partial class inventoryListsItemType
    {
        #region Private fields
        private stockItemType _stockItem;
        private string _code;
        private string _name;
        private string _text;
        private float _quantity;
        private string _unit;
        private boolean _isDelivered;
        #endregion
        
        public inventoryListsItemType()
        {
            _stockItem = new stockItemType();
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        public boolean isDelivered
        {
            get
            {
                return _isDelivered;
            }
            set
            {
                _isDelivered = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/inventoryLists.xsd")]
    public partial class inventoryListsHeaderType
    {
        #region Private fields
        private string _id;
        private numberType1 _number;
        private System.DateTime _date;
        private string _text;
        private refType _store;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private string _note;
        private boolean _markRecord;
        #endregion
        
        public inventoryListsHeaderType()
        {
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _store = new refType();
            _number = new numberType1();
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public refType store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/inventoryLists.xsd")]
    public partial class inventoryListsType
    {
        #region Private fields
        private inventoryListsHeaderType _inventoryListsHeader;
        private List<inventoryListsItemType> _inventoryListsDetail;
        private iltVersionType _version;
        #endregion
        
        public inventoryListsType()
        {
            _inventoryListsDetail = new List<inventoryListsItemType>();
            _inventoryListsHeader = new inventoryListsHeaderType();
        }
        
        public inventoryListsHeaderType inventoryListsHeader
        {
            get
            {
                return _inventoryListsHeader;
            }
            set
            {
                _inventoryListsHeader = value;
            }
        }
        
        [XmlArrayItemAttribute("inventoryListsItem", IsNullable=false)]
        public List<inventoryListsItemType> inventoryListsDetail
        {
            get
            {
                return _inventoryListsDetail;
            }
            set
            {
                _inventoryListsDetail = value;
            }
        }
        
        [XmlAttribute]
        public iltVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/inventoryLists.xsd")]
    public enum iltVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intParam.xsd")]
    public partial class parameterListItemType
    {
        #region Private fields
        private string _id;
        private string _name;
        private string _description;
        private string _sequence;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string sequence
        {
            get
            {
                return _sequence;
            }
            set
            {
                _sequence = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intParam.xsd")]
    public partial class parameterSettingsType
    {
        #region Private fields
        private string _unit;
        private string _length;
        private List<parameterListItemType> _parameterList;
        private refType _currency;
        #endregion
        
        public parameterSettingsType()
        {
            _currency = new refType();
            _parameterList = new List<parameterListItemType>();
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        
        [XmlArrayItemAttribute("parameterListItem", IsNullable=false)]
        public List<parameterListItemType> parameterList
        {
            get
            {
                return _parameterList;
            }
            set
            {
                _parameterList = value;
            }
        }
        
        public refType currency
        {
            get
            {
                return _currency;
            }
            set
            {
                _currency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intParam.xsd")]
    public partial class intParamType
    {
        #region Private fields
        private string _id;
        private string _name;
        private string _description;
        private internetParameterType _parameterType;
        private parameterSettingsType _parameterSettings;
        private boolean _markRecord;
        private string _note;
        #endregion
        
        public intParamType()
        {
            _parameterSettings = new parameterSettingsType();
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        public internetParameterType parameterType
        {
            get
            {
                return _parameterType;
            }
            set
            {
                _parameterType = value;
            }
        }
        
        public parameterSettingsType parameterSettings
        {
            get
            {
                return _parameterSettings;
            }
            set
            {
                _parameterSettings = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum internetParameterType
    {
        textValue,
        currencyValue,
        booleanValue,
        numberValue,
        integerValue,
        datetimeValue,
        unit,
        listValue,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intParam.xsd")]
    public partial class intParamDetailType
    {
        #region Private fields
        private List<intParamType> _intParam;
        private ipmVersionType _version;
        #endregion
        
        public intParamDetailType()
        {
            _intParam = new List<intParamType>();
        }
        
        [XmlElement("intParam")]
        public List<intParamType> intParam
        {
            get
            {
                return _intParam;
            }
            set
            {
                _intParam = value;
            }
        }
        
        [XmlAttribute]
        public ipmVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intParam.xsd")]
    public enum ipmVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/parameter.xsd")]
    public partial class userCodePartType
    {
        #region Private fields
        private string _part0;
        private string _part1;
        private string _part2;
        private string _part3;
        private string _part4;
        #endregion
        
        public string part0
        {
            get
            {
                return _part0;
            }
            set
            {
                _part0 = value;
            }
        }
        
        public string part1
        {
            get
            {
                return _part1;
            }
            set
            {
                _part1 = value;
            }
        }
        
        public string part2
        {
            get
            {
                return _part2;
            }
            set
            {
                _part2 = value;
            }
        }
        
        public string part3
        {
            get
            {
                return _part3;
            }
            set
            {
                _part3 = value;
            }
        }
        
        public string part4
        {
            get
            {
                return _part4;
            }
            set
            {
                _part4 = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class rectangle
    {
        #region Private fields
        private string _left;
        private string _top;
        private string _right;
        private string _bottom;
        #endregion
        
        [XmlAttribute(DataType="integer")]
        public string left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string top
        {
            get
            {
                return _top;
            }
            set
            {
                _top = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string bottom
        {
            get
            {
                return _bottom;
            }
            set
            {
                _bottom = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/parameter.xsd")]
    public partial class ctrlDefType
    {
        #region Private fields
        private string _name;
        private string _label;
        private rectangle _rect;
        private ctrlType _type;
        private string _style;
        #endregion
        
        public ctrlDefType()
        {
            _rect = new rectangle();
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string label
        {
            get
            {
                return _label;
            }
            set
            {
                _label = value;
            }
        }
        
        public rectangle rect
        {
            get
            {
                return _rect;
            }
            set
            {
                _rect = value;
            }
        }
        
        public ctrlType type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum ctrlType
    {
        text,
        push,
        link,
        group,
        rect,
        image,
        edit,
        check,
        pick,
        list,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/parameter.xsd")]
    public partial class formItemListType
    {
        #region Private fields
        private List<ctrlDefType> _ctrlDef;
        private parameterAgendaFormType _formAgenda;
        #endregion
        
        public formItemListType()
        {
            _ctrlDef = new List<ctrlDefType>();
        }
        
        [XmlElement("ctrlDef")]
        public List<ctrlDefType> ctrlDef
        {
            get
            {
                return _ctrlDef;
            }
            set
            {
                _ctrlDef = value;
            }
        }
        
        [XmlAttribute]
        public parameterAgendaFormType formAgenda
        {
            get
            {
                return _formAgenda;
            }
            set
            {
                _formAgenda = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum parameterAgendaFormType
    {
        issuedInvoice,
        receivedInvoice,
        receivable,
        commitment,
        issuedAdvanceInvoice,
        receivedAdvanceInvoice,
        issuedOffer,
        receivedOffer,
        issuedEnquiry,
        receivedEnquiry,
        receivedOrder,
        issuedOrder,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/parameter.xsd")]
    public partial class parameterDefType
    {
        #region Private fields
        private string _id;
        private string _label;
        private string _name;
        private parameterDataType _type;
        private string _length;
        private string _definition;
        private refType _list;
        private boolean _write;
        private string _row;
        private boolean _use0;
        private boolean _use1;
        private boolean _use2;
        private boolean _use3;
        private boolean _use4;
        private boolean _use5;
        #endregion
        
        public parameterDefType()
        {
            _list = new refType();
            _write = boolean.@true;
            _row = "1";
            _use0 = boolean.@false;
            _use1 = boolean.@false;
            _use2 = boolean.@false;
            _use3 = boolean.@false;
            _use4 = boolean.@false;
            _use5 = boolean.@false;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string label
        {
            get
            {
                return _label;
            }
            set
            {
                _label = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public parameterDataType type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        
        public string definition
        {
            get
            {
                return _definition;
            }
            set
            {
                _definition = value;
            }
        }
        
        public refType list
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean write
        {
            get
            {
                return _write;
            }
            set
            {
                _write = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        [DefaultValue("1")]
        public string row
        {
            get
            {
                return _row;
            }
            set
            {
                _row = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean use0
        {
            get
            {
                return _use0;
            }
            set
            {
                _use0 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean use1
        {
            get
            {
                return _use1;
            }
            set
            {
                _use1 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean use2
        {
            get
            {
                return _use2;
            }
            set
            {
                _use2 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean use3
        {
            get
            {
                return _use3;
            }
            set
            {
                _use3 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean use4
        {
            get
            {
                return _use4;
            }
            set
            {
                _use4 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean use5
        {
            get
            {
                return _use5;
            }
            set
            {
                _use5 = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum parameterDataType
    {
        text,
        currency,
        boolean,
        number,
        integer,
        datetime,
        list,
        memo,
        computed,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/parameter.xsd")]
    public partial class userAgendaDefType
    {
        #region Private fields
        private string _idsUserAgenda;
        private string _name;
        private string _tabMain;
        private string _tabItem;
        private numberType1 _number;
        private boolean _items;
        private boolean _templates;
        private boolean _documents;
        private boolean _list;
        private string _listIDS;
        private string _listSText;
        #endregion
        
        public userAgendaDefType()
        {
            _number = new numberType1();
            _list = boolean.@false;
        }
        
        public string idsUserAgenda
        {
            get
            {
                return _idsUserAgenda;
            }
            set
            {
                _idsUserAgenda = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string tabMain
        {
            get
            {
                return _tabMain;
            }
            set
            {
                _tabMain = value;
            }
        }
        
        public string tabItem
        {
            get
            {
                return _tabItem;
            }
            set
            {
                _tabItem = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public boolean items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        
        public boolean templates
        {
            get
            {
                return _templates;
            }
            set
            {
                _templates = value;
            }
        }
        
        public boolean documents
        {
            get
            {
                return _documents;
            }
            set
            {
                _documents = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean list
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
            }
        }
        
        public string listIDS
        {
            get
            {
                return _listIDS;
            }
            set
            {
                _listIDS = value;
            }
        }
        
        public string listSText
        {
            get
            {
                return _listSText;
            }
            set
            {
                _listSText = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/parameter.xsd")]
    public partial class parameterType
    {
        #region Private fields
        private userAgendaDefType _userAgendaDef;
        private List<parameterDefType> _formParameter;
        private List<parameterDefType> _itemParameter;
        private List<formItemListType> _userForm;
        private object _item;
        private prmVersionType _version;
        private parameterAgendaType _idsAgenda;
        private string _idsUserAgenda;
        private string _id;
        #endregion
        
        public parameterType()
        {
            _userForm = new List<formItemListType>();
            _itemParameter = new List<parameterDefType>();
            _formParameter = new List<parameterDefType>();
            _userAgendaDef = new userAgendaDefType();
        }
        
        public userAgendaDefType userAgendaDef
        {
            get
            {
                return _userAgendaDef;
            }
            set
            {
                _userAgendaDef = value;
            }
        }
        
        [XmlArrayItemAttribute("parameterDef", IsNullable=false)]
        public List<parameterDefType> formParameter
        {
            get
            {
                return _formParameter;
            }
            set
            {
                _formParameter = value;
            }
        }
        
        [XmlArrayItemAttribute("parameterDef", IsNullable=false)]
        public List<parameterDefType> itemParameter
        {
            get
            {
                return _itemParameter;
            }
            set
            {
                _itemParameter = value;
            }
        }
        
        [XmlElement("userForm")]
        public List<formItemListType> userForm
        {
            get
            {
                return _userForm;
            }
            set
            {
                _userForm = value;
            }
        }
        
        [XmlElement("userCode", typeof(string))]
        [XmlElement("userCodePart", typeof(userCodePartType))]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlAttribute]
        public prmVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public parameterAgendaType idsAgenda
        {
            get
            {
                return _idsAgenda;
            }
            set
            {
                _idsAgenda = value;
            }
        }
        
        [XmlAttribute]
        public string idsUserAgenda
        {
            get
            {
                return _idsUserAgenda;
            }
            set
            {
                _idsUserAgenda = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/category.xsd")]
    public partial class internetParamsType
    {
        #region Private fields
        private List<object> _items;
        #endregion
        
        public internetParamsType()
        {
            _items = new List<object>();
        }
        
        [XmlElement("idInternetParams", typeof(string))]
        [XmlElement("intParameter", typeof(refTypeLong))]
        public List<object> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class refTypeLong
    {
        #region Private fields
        private string _id;
        private string _ids;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/category.xsd")]
    public partial class categoryType
    {
        #region Private fields
        private string _parentId;
        private string _id;
        private string _name;
        private string _description;
        private string _sequence;
        private boolean _displayed;
        private string _picture;
        private string _note;
        private boolean _markRecord;
        private List<categoryType> _subCategories;
        private internetParamsType _internetParams;
        #endregion
        
        public categoryType()
        {
            _internetParams = new internetParamsType();
            _subCategories = new List<categoryType>();
            _sequence = "0";
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string parentId
        {
            get
            {
                return _parentId;
            }
            set
            {
                _parentId = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        [DefaultValue("0")]
        public string sequence
        {
            get
            {
                return _sequence;
            }
            set
            {
                _sequence = value;
            }
        }
        
        public boolean displayed
        {
            get
            {
                return _displayed;
            }
            set
            {
                _displayed = value;
            }
        }
        
        public string picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("category", IsNullable=false)]
        public List<categoryType> subCategories
        {
            get
            {
                return _subCategories;
            }
            set
            {
                _subCategories = value;
            }
        }
        
        public internetParamsType internetParams
        {
            get
            {
                return _internetParams;
            }
            set
            {
                _internetParams = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/category.xsd")]
    public partial class categoryDetailType
    {
        #region Private fields
        private List<categoryType> _category;
        private ctgVersionType _version;
        #endregion
        
        public categoryDetailType()
        {
            _category = new List<categoryType>();
        }
        
        [XmlElement("category")]
        public List<categoryType> category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        
        [XmlAttribute]
        public ctgVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/storage.xsd")]
    public partial class subStoragesType
    {
        #region Private fields
        private itemStorageType _itemStorage;
        #endregion
        
        public subStoragesType()
        {
            _itemStorage = new itemStorageType();
        }
        
        public itemStorageType itemStorage
        {
            get
            {
                return _itemStorage;
            }
            set
            {
                _itemStorage = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/storage.xsd")]
    public partial class itemStorageType
    {
        #region Private fields
        private subStoragesType _subStorages;
        private string _id;
        private string _code;
        private string _idStore;
        private string _name;
        private string _note;
        private boolean _offerTo;
        #endregion
        
        public itemStorageType()
        {
            _subStorages = new subStoragesType();
        }
        
        public subStoragesType subStorages
        {
            get
            {
                return _subStorages;
            }
            set
            {
                _subStorages = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlAttribute]
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string idStore
        {
            get
            {
                return _idStore;
            }
            set
            {
                _idStore = value;
            }
        }
        
        [XmlAttribute]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [XmlAttribute]
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [XmlAttribute]
        public boolean offerTo
        {
            get
            {
                return _offerTo;
            }
            set
            {
                _offerTo = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/storage.xsd")]
    public partial class storageType
    {
        #region Private fields
        private List<itemStorageType> _itemStorage;
        private strVersionType _version;
        #endregion
        
        public storageType()
        {
            _itemStorage = new List<itemStorageType>();
        }
        
        [XmlElement("itemStorage")]
        public List<itemStorageType> itemStorage
        {
            get
            {
                return _itemStorage;
            }
            set
            {
                _itemStorage = value;
            }
        }
        
        [XmlAttribute]
        public strVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/storage.xsd")]
    public enum strVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class actionTypeItemAddDelete
    {
        #region Private fields
        private object _item;
        #endregion
        
        [XmlElement("add", typeof(string))]
        [XmlElement("delete", typeof(requestItemType))]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/groupStocks.xsd")]
    public partial class variantsItemType
    {
        #region Private fields
        private actionTypeItemAddDelete _actionType;
        private stockItemType _stockItem;
        private string _order;
        private string _name;
        private float _quantity;
        #endregion
        
        public variantsItemType()
        {
            _stockItem = new stockItemType();
            _actionType = new actionTypeItemAddDelete();
        }
        
        public actionTypeItemAddDelete actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string order
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/groupStocks.xsd")]
    public partial class groupStocksHeaderType
    {
        #region Private fields
        private string _id;
        private string _code;
        private string _name;
        private string _description;
        private boolean _internet;
        private string _picture;
        private string _note;
        private boolean _markRecord;
        #endregion
        
        public groupStocksHeaderType()
        {
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        public boolean internet
        {
            get
            {
                return _internet;
            }
            set
            {
                _internet = value;
            }
        }
        
        public string picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="actionTypeType", Namespace="http://www.stormware.cz/schema/version_2/groupStocks.xsd")]
    public partial class actionTypeType3
    {
        #region Private fields
        private requestGroupStocksType _item;
        private ItemChoiceType5 _itemElementName;
        #endregion
        
        [XmlElement("add", typeof(requestGroupStocksActionType))]
        [XmlElement("delete", typeof(requestGroupStocksType))]
        [XmlElement("update", typeof(requestGroupStocksActionType))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public requestGroupStocksType Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlIgnore]
        public ItemChoiceType5 ItemElementName
        {
            get
            {
                return _itemElementName;
            }
            set
            {
                _itemElementName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/groupStocks.xsd", IncludeInSchema=false)]
    public enum ItemChoiceType5
    {
        add,
        delete,
        update,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/groupStocks.xsd")]
    public partial class groupStocksType
    {
        #region Private fields
        private actionTypeType3 _actionType;
        private groupStocksHeaderType _groupStocksHeader;
        private List<variantsItemType> _groupStocksDetail;
        private grsVersionType _version;
        #endregion
        
        public groupStocksType()
        {
            _groupStocksDetail = new List<variantsItemType>();
            _groupStocksHeader = new groupStocksHeaderType();
            _actionType = new actionTypeType3();
        }
        
        public actionTypeType3 actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        public groupStocksHeaderType groupStocksHeader
        {
            get
            {
                return _groupStocksHeader;
            }
            set
            {
                _groupStocksHeader = value;
            }
        }
        
        [XmlArrayItemAttribute("variant", IsNullable=false)]
        public List<variantsItemType> groupStocksDetail
        {
            get
            {
                return _groupStocksDetail;
            }
            set
            {
                _groupStocksDetail = value;
            }
        }
        
        [XmlAttribute]
        public grsVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/store.xsd")]
    public partial class accStockAType
    {
        #region Private fields
        private string _material;
        private string _goods;
        private string _workInProgress;
        private string _semiproducts;
        private string _products;
        private string _animals;
        private string _materialOfOwnProduction;
        #endregion
        
        public string material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;
            }
        }
        
        public string goods
        {
            get
            {
                return _goods;
            }
            set
            {
                _goods = value;
            }
        }
        
        public string workInProgress
        {
            get
            {
                return _workInProgress;
            }
            set
            {
                _workInProgress = value;
            }
        }
        
        public string semiproducts
        {
            get
            {
                return _semiproducts;
            }
            set
            {
                _semiproducts = value;
            }
        }
        
        public string products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
            }
        }
        
        public string animals
        {
            get
            {
                return _animals;
            }
            set
            {
                _animals = value;
            }
        }
        
        public string materialOfOwnProduction
        {
            get
            {
                return _materialOfOwnProduction;
            }
            set
            {
                _materialOfOwnProduction = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/store.xsd")]
    public partial class PLUtype
    {
        #region Private fields
        private bool _usePLU;
        private string _lowerLimit;
        private string _upperLimit;
        #endregion
        
        public PLUtype()
        {
            _usePLU = false;
        }
        
        [DefaultValue(false)]
        public bool usePLU
        {
            get
            {
                return _usePLU;
            }
            set
            {
                _usePLU = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string lowerLimit
        {
            get
            {
                return _lowerLimit;
            }
            set
            {
                _lowerLimit = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string upperLimit
        {
            get
            {
                return _upperLimit;
            }
            set
            {
                _upperLimit = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/store.xsd")]
    public partial class storeType
    {
        #region Private fields
        private string _id;
        private string _name;
        private string _text;
        private boolean _allowNegInvBalance;
        private refType _storekeeper;
        private PLUtype _pLU;
        private string _note;
        private boolean _markRecord;
        private bool _sourceStore;
        private bool _destinationStore;
        private bool _createInventoryCard;
        private refType _unitPZD;
        private accStockAType _accStockA;
        private stoVersionType _version;
        #endregion
        
        public storeType()
        {
            _accStockA = new accStockAType();
            _unitPZD = new refType();
            _pLU = new PLUtype();
            _storekeeper = new refType();
            _markRecord = boolean.@true;
            _sourceStore = false;
            _destinationStore = false;
            _createInventoryCard = false;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public boolean allowNegInvBalance
        {
            get
            {
                return _allowNegInvBalance;
            }
            set
            {
                _allowNegInvBalance = value;
            }
        }
        
        public refType storekeeper
        {
            get
            {
                return _storekeeper;
            }
            set
            {
                _storekeeper = value;
            }
        }
        
        public PLUtype PLU
        {
            get
            {
                return _pLU;
            }
            set
            {
                _pLU = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [DefaultValue(false)]
        public bool sourceStore
        {
            get
            {
                return _sourceStore;
            }
            set
            {
                _sourceStore = value;
            }
        }
        
        [DefaultValue(false)]
        public bool destinationStore
        {
            get
            {
                return _destinationStore;
            }
            set
            {
                _destinationStore = value;
            }
        }
        
        [DefaultValue(false)]
        public bool createInventoryCard
        {
            get
            {
                return _createInventoryCard;
            }
            set
            {
                _createInventoryCard = value;
            }
        }
        
        public refType unitPZD
        {
            get
            {
                return _unitPZD;
            }
            set
            {
                _unitPZD = value;
            }
        }
        
        public accStockAType accStockA
        {
            get
            {
                return _accStockA;
            }
            set
            {
                _accStockA = value;
            }
        }
        
        [XmlAttribute]
        public stoVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class numberTypeContract
    {
        #region Private fields
        private string _id;
        private string _ids;
        private numberTypeContractNumberRequested _numberRequested;
        #endregion
        
        public numberTypeContract()
        {
            _numberRequested = new numberTypeContractNumberRequested();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public numberTypeContractNumberRequested numberRequested
        {
            get
            {
                return _numberRequested;
            }
            set
            {
                _numberRequested = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class numberTypeContractNumberRequested
    {
        #region Private fields
        private boolean _checkDuplicity;
        private string _value;
        #endregion
        
        public numberTypeContractNumberRequested()
        {
            _checkDuplicity = boolean.@true;
        }
        
        [XmlAttribute]
        [DefaultValue(boolean.@true)]
        public boolean checkDuplicity
        {
            get
            {
                return _checkDuplicity;
            }
            set
            {
                _checkDuplicity = value;
            }
        }
        
        [XmlTextAttribute]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/contract.xsd")]
    public partial class contractDescType
    {
        #region Private fields
        private string _id;
        private numberTypeContract _number;
        private System.DateTime _datePlanStart;
        private System.DateTime _datePlanDelivery;
        private System.DateTime _dateStart;
        private System.DateTime _dateDelivery;
        private System.DateTime _dateWarranty;
        private string _text;
        private address _partnerIdentity;
        private refTypeLong _responsiblePerson;
        private contractStateType _contractState;
        private refTypeLong _status;
        private string _ost1;
        private string _ost2;
        private string _note;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        #endregion
        
        public contractDescType()
        {
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _status = new refTypeLong();
            _responsiblePerson = new refTypeLong();
            _partnerIdentity = new address();
            _number = new numberTypeContract();
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public numberTypeContract number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime datePlanStart
        {
            get
            {
                return _datePlanStart;
            }
            set
            {
                _datePlanStart = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime datePlanDelivery
        {
            get
            {
                return _datePlanDelivery;
            }
            set
            {
                _datePlanDelivery = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateStart
        {
            get
            {
                return _dateStart;
            }
            set
            {
                _dateStart = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateDelivery
        {
            get
            {
                return _dateDelivery;
            }
            set
            {
                _dateDelivery = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateWarranty
        {
            get
            {
                return _dateWarranty;
            }
            set
            {
                _dateWarranty = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public refTypeLong responsiblePerson
        {
            get
            {
                return _responsiblePerson;
            }
            set
            {
                _responsiblePerson = value;
            }
        }
        
        public contractStateType contractState
        {
            get
            {
                return _contractState;
            }
            set
            {
                _contractState = value;
            }
        }
        
        public refTypeLong status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        
        public string ost1
        {
            get
            {
                return _ost1;
            }
            set
            {
                _ost1 = value;
            }
        }
        
        public string ost2
        {
            get
            {
                return _ost2;
            }
            set
            {
                _ost2 = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/contract.xsd")]
    public enum contractStateType
    {
        planned,
        opened,
        delivered,
        closed,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/contract.xsd")]
    public partial class contractType
    {
        #region Private fields
        private contractDescType _contractDesc;
        private List<printerSettingsType> _print;
        private conVersionType _version;
        #endregion
        
        public contractType()
        {
            _print = new List<printerSettingsType>();
            _contractDesc = new contractDescType();
        }
        
        public contractDescType contractDesc
        {
            get
            {
                return _contractDesc;
            }
            set
            {
                _contractDesc = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public conVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vyroba.xsd")]
    public partial class productionListItemType
    {
        #region Private fields
        private stockItemType _stockItem;
        private float _quantity;
        private string _unit;
        private string _expirationDate;
        #endregion
        
        public productionListItemType()
        {
            _stockItem = new stockItemType();
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        public string expirationDate
        {
            get
            {
                return _expirationDate;
            }
            set
            {
                _expirationDate = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vyroba.xsd")]
    public partial class vyrobaItemType
    {
        #region Private fields
        private float _quantity;
        private stockItemType _stockItem;
        private System.DateTime _expirationDate;
        private string _note;
        private List<productionListItemType> _productionList;
        #endregion
        
        public vyrobaItemType()
        {
            _productionList = new List<productionListItemType>();
            _stockItem = new stockItemType();
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime expirationDate
        {
            get
            {
                return _expirationDate;
            }
            set
            {
                _expirationDate = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [XmlArrayItemAttribute("productionListItem", IsNullable=false)]
        public List<productionListItemType> productionList
        {
            get
            {
                return _productionList;
            }
            set
            {
                _productionList = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vyroba.xsd")]
    public partial class vyrobaHeaderType
    {
        #region Private fields
        private string _id;
        private numberType1 _number;
        private System.DateTime _date;
        private System.DateTime _time;
        private string _dateOfReceipt;
        private System.DateTime _timeOfReceipt;
        private string _symPar;
        private string _acc;
        private string _text;
        private address _partnerIdentity;
        private refType _centreSource;
        private refType _centreDestination;
        private refType _activity;
        private refType _contract;
        private string _note;
        private string _intNote;
        private boolean _markRecord;
        private List<labelType> _labels;
        private typeValidate _validate;
        private List<parameterDocType> _parameters;
        #endregion
        
        public vyrobaHeaderType()
        {
            _parameters = new List<parameterDocType>();
            _validate = new typeValidate();
            _labels = new List<labelType>();
            _contract = new refType();
            _activity = new refType();
            _centreDestination = new refType();
            _centreSource = new refType();
            _partnerIdentity = new address();
            _number = new numberType1();
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="time")]
        public System.DateTime time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }
        
        public string dateOfReceipt
        {
            get
            {
                return _dateOfReceipt;
            }
            set
            {
                _dateOfReceipt = value;
            }
        }
        
        [XmlElement(DataType="time")]
        public System.DateTime timeOfReceipt
        {
            get
            {
                return _timeOfReceipt;
            }
            set
            {
                _timeOfReceipt = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public string acc
        {
            get
            {
                return _acc;
            }
            set
            {
                _acc = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public refType centreSource
        {
            get
            {
                return _centreSource;
            }
            set
            {
                _centreSource = value;
            }
        }
        
        public refType centreDestination
        {
            get
            {
                return _centreDestination;
            }
            set
            {
                _centreDestination = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        public typeValidate validate
        {
            get
            {
                return _validate;
            }
            set
            {
                _validate = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class typeValidate
    {
        #region Private fields
        private boolean _inStock;
        #endregion
        
        public typeValidate()
        {
            _inStock = boolean.@false;
        }
        
        [DefaultValue(boolean.@false)]
        public boolean inStock
        {
            get
            {
                return _inStock;
            }
            set
            {
                _inStock = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vyroba.xsd")]
    public partial class vyrobaType
    {
        #region Private fields
        private vyrobaHeaderType _vyrobaHeader;
        private List<vyrobaItemType> _vyrobaDetail;
        private List<printerSettingsType> _print;
        private vyrVersionType _version;
        #endregion
        
        public vyrobaType()
        {
            _print = new List<printerSettingsType>();
            _vyrobaDetail = new List<vyrobaItemType>();
            _vyrobaHeader = new vyrobaHeaderType();
        }
        
        public vyrobaHeaderType vyrobaHeader
        {
            get
            {
                return _vyrobaHeader;
            }
            set
            {
                _vyrobaHeader = value;
            }
        }
        
        [XmlArrayItemAttribute("vyrobaItem", IsNullable=false)]
        public List<vyrobaItemType> vyrobaDetail
        {
            get
            {
                return _vyrobaDetail;
            }
            set
            {
                _vyrobaDetail = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public vyrVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vyroba.xsd")]
    public enum vyrVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vydejka.xsd")]
    public partial class vydejkaSummaryType
    {
        #region Private fields
        private typeRoundingDocument _roundingDocument;
        private string _roundingVAT;
        private bool _calculateVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        private typeCurrencyForeign _foreignCurrency;
        #endregion
        
        public vydejkaSummaryType()
        {
            _foreignCurrency = new typeCurrencyForeign();
            _homeCurrency = new typeCurrencyHome();
            _calculateVAT = false;
        }
        
        public typeRoundingDocument roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public string roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        [DefaultValue(false)]
        public bool calculateVAT
        {
            get
            {
                return _calculateVAT;
            }
            set
            {
                _calculateVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeign foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum typeRoundingDocument
    {
        none,
        math2one,
        math2half,
        math2tenth,
        math5cent,
        up2one,
        up2half,
        up2tenth,
        down2one,
        down2half,
        down2tenth,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vydejka.xsd")]
    public partial class vydejkaItemType
    {
        #region Private fields
        private linkItemType _link;
        private linkedDocumentType _linkedDocument;
        private string _id;
        private string _extId;
        private string _text;
        private float _quantity;
        private float _transferred;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private typeCurrencyForeignItem _foreignCurrency;
        private MOSStype _typeServiceMOSS;
        private string _note;
        private string _code;
        private string _guarantee;
        private guaranteeTypeType _guaranteeType;
        private stockItemType _stockItem;
        private linkToStockType _linkToStock;
        private string _acc;
        private bool _pDP;
        private string _codePDP;
        private recyclingContribType _recyclingContrib;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private System.DateTime _expirationDate;
        private List<parameterDocType> _parameters;
        #endregion
        
        public vydejkaItemType()
        {
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _recyclingContrib = new recyclingContribType();
            _linkToStock = new linkToStockType();
            _stockItem = new stockItemType();
            _typeServiceMOSS = new MOSStype();
            _foreignCurrency = new typeCurrencyForeignItem();
            _homeCurrency = new typeCurrencyHomeItem();
            _linkedDocument = new linkedDocumentType();
            _link = new linkItemType();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        public linkItemType link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
            }
        }
        
        public linkedDocumentType linkedDocument
        {
            get
            {
                return _linkedDocument;
            }
            set
            {
                _linkedDocument = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public float transferred
        {
            get
            {
                return _transferred;
            }
            set
            {
                _transferred = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string guarantee
        {
            get
            {
                return _guarantee;
            }
            set
            {
                _guarantee = value;
            }
        }
        
        public guaranteeTypeType guaranteeType
        {
            get
            {
                return _guaranteeType;
            }
            set
            {
                _guaranteeType = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public linkToStockType linkToStock
        {
            get
            {
                return _linkToStock;
            }
            set
            {
                _linkToStock = value;
            }
        }
        
        public string acc
        {
            get
            {
                return _acc;
            }
            set
            {
                _acc = value;
            }
        }
        
        public bool PDP
        {
            get
            {
                return _pDP;
            }
            set
            {
                _pDP = value;
            }
        }
        
        public string CodePDP
        {
            get
            {
                return _codePDP;
            }
            set
            {
                _codePDP = value;
            }
        }
        
        public recyclingContribType recyclingContrib
        {
            get
            {
                return _recyclingContrib;
            }
            set
            {
                _recyclingContrib = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime expirationDate
        {
            get
            {
                return _expirationDate;
            }
            set
            {
                _expirationDate = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class linkItemType
    {
        #region Private fields
        private agendaType _sourceAgenda;
        private string _sourceItemId;
        private extIdType _sourceItemExtId;
        private settingsSourceDocumentOrderItemType _settingsSourceDocumentOrderItem;
        private settingsSourceDocumentItemType _settingsSourceDocumentItem;
        #endregion
        
        public linkItemType()
        {
            _settingsSourceDocumentItem = new settingsSourceDocumentItemType();
            _settingsSourceDocumentOrderItem = new settingsSourceDocumentOrderItemType();
            _sourceItemExtId = new extIdType();
        }
        
        public agendaType sourceAgenda
        {
            get
            {
                return _sourceAgenda;
            }
            set
            {
                _sourceAgenda = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string sourceItemId
        {
            get
            {
                return _sourceItemId;
            }
            set
            {
                _sourceItemId = value;
            }
        }
        
        public extIdType sourceItemExtId
        {
            get
            {
                return _sourceItemExtId;
            }
            set
            {
                _sourceItemExtId = value;
            }
        }
        
        public settingsSourceDocumentOrderItemType settingsSourceDocumentOrderItem
        {
            get
            {
                return _settingsSourceDocumentOrderItem;
            }
            set
            {
                _settingsSourceDocumentOrderItem = value;
            }
        }
        
        public settingsSourceDocumentItemType settingsSourceDocumentItem
        {
            get
            {
                return _settingsSourceDocumentItem;
            }
            set
            {
                _settingsSourceDocumentItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum agendaType
    {
        issuedInvoice,
        issuedAdvanceInvoice,
        receivable,
        receivedInvoice,
        receivedAdvanceInvoice,
        commitment,
        internalDocuments,
        issuedOrder,
        receivedOrder,
        issuedOffer,
        receivedOffer,
        issuedEnquiry,
        receivedEnquiry,
        receiptVoucher,
        issueSlip,
        transfer,
        production,
        productRequirements,
        claims,
        claimsOld,
        service,
        fixedAssets,
        lowValueAssets,
        salesVouchers,
        cashbox,
        paymentOrders,
        accrualsAndDeferrals,
        correctiveItems,
        shipments,
        electronicRecordsOfSales,
        registerOfCure,
        domesticTravelOrder,
        foreignTravelOrders,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class settingsSourceDocumentOrderItemType
    {
        #region Private fields
        private object _item;
        #endregion
        
        [XmlElement("linkOrderItemToInvoice", typeof(linkOrderItemToInvoiceType))]
        [XmlElement("linkOrderItemToIssueSlip", typeof(linkOrderItemToIssueSlipType))]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum linkOrderItemToInvoiceType
    {
        [XmlEnumAttribute("4")]
        Item4,
        [XmlEnumAttribute("2")]
        Item2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum linkOrderItemToIssueSlipType
    {
        [XmlEnumAttribute("4")]
        Item4,
        [XmlEnumAttribute("2")]
        Item2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class settingsSourceDocumentItemType
    {
        #region Private fields
        private object _item;
        #endregion
        
        [XmlElement("linkIssueOfferItemToReceivedOrder", typeof(linkIssueOfferItemToReceivedOrderType))]
        [XmlElement("linkIssueSlipItemToInvoice", typeof(linkIssueSlipItemToInvoiceType))]
        [XmlElement("linkIssueSlipItemToSaleVoucher", typeof(linkIssueSlipItemToSaleVoucherType))]
        [XmlElement("linkReceivedOrderItemToSaleVoucher", typeof(linkReceivedOrderItemToSaleVoucherType))]
        [XmlElement("linkReceivedOrderItemToTransfer", typeof(linkReceivedOrderItemToTransferType))]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum linkIssueOfferItemToReceivedOrderType
    {
        [XmlEnumAttribute("4")]
        Item4,
        [XmlEnumAttribute("2")]
        Item2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum linkIssueSlipItemToInvoiceType
    {
        [XmlEnumAttribute("4")]
        Item4,
        [XmlEnumAttribute("2")]
        Item2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum linkIssueSlipItemToSaleVoucherType
    {
        [XmlEnumAttribute("4")]
        Item4,
        [XmlEnumAttribute("2")]
        Item2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum linkReceivedOrderItemToSaleVoucherType
    {
        [XmlEnumAttribute("4")]
        Item4,
        [XmlEnumAttribute("2")]
        Item2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum linkReceivedOrderItemToTransferType
    {
        [XmlEnumAttribute("4")]
        Item4,
        [XmlEnumAttribute("2")]
        Item2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class linkedDocumentType
    {
        #region Private fields
        private agendaType _sourceAgenda;
        private sourceDocumentType _sourceDocument;
        private sourceDocumentItemType _sourceDocumentItem;
        #endregion
        
        public linkedDocumentType()
        {
            _sourceDocumentItem = new sourceDocumentItemType();
            _sourceDocument = new sourceDocumentType();
        }
        
        public agendaType sourceAgenda
        {
            get
            {
                return _sourceAgenda;
            }
            set
            {
                _sourceAgenda = value;
            }
        }
        
        public sourceDocumentType sourceDocument
        {
            get
            {
                return _sourceDocument;
            }
            set
            {
                _sourceDocument = value;
            }
        }
        
        public sourceDocumentItemType sourceDocumentItem
        {
            get
            {
                return _sourceDocumentItem;
            }
            set
            {
                _sourceDocumentItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class sourceDocumentType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private string _number;
        #endregion
        
        public sourceDocumentType()
        {
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class sourceDocumentItemType
    {
        #region Private fields
        private string _sourceItemId;
        private extIdType _sourceItemExtId;
        #endregion
        
        public sourceDocumentItemType()
        {
            _sourceItemExtId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string sourceItemId
        {
            get
            {
                return _sourceItemId;
            }
            set
            {
                _sourceItemId = value;
            }
        }
        
        public extIdType sourceItemExtId
        {
            get
            {
                return _sourceItemExtId;
            }
            set
            {
                _sourceItemExtId = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum guaranteeTypeType
    {
        none,
        hour,
        day,
        month,
        year,
        life,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class linkToStockType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        #endregion
        
        public linkToStockType()
        {
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class recyclingContribType
    {
        #region Private fields
        private refType _recyclingContribType1;
        private string _recyclingContribText;
        private double _recyclingContribAmount;
        private string _recyclingContribUnit;
        private System.Nullable<float> _coefficientOfRecyclingContrib;
        #endregion
        
        public recyclingContribType()
        {
            _recyclingContribType1 = new refType();
        }
        
        [XmlElement("recyclingContribType")]
        public refType recyclingContribType1
        {
            get
            {
                return _recyclingContribType1;
            }
            set
            {
                _recyclingContribType1 = value;
            }
        }
        
        public string recyclingContribText
        {
            get
            {
                return _recyclingContribText;
            }
            set
            {
                _recyclingContribText = value;
            }
        }
        
        public double recyclingContribAmount
        {
            get
            {
                return _recyclingContribAmount;
            }
            set
            {
                _recyclingContribAmount = value;
            }
        }
        
        public string recyclingContribUnit
        {
            get
            {
                return _recyclingContribUnit;
            }
            set
            {
                _recyclingContribUnit = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public System.Nullable<float> coefficientOfRecyclingContrib
        {
            get
            {
                return _coefficientOfRecyclingContrib;
            }
            set
            {
                _coefficientOfRecyclingContrib = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vydejka.xsd")]
    public partial class vydejkaDetailType
    {
        #region Private fields
        private List<vydejkaItemType> _vydejkaItem;
        private roundingItemType _roundingItem;
        #endregion
        
        public vydejkaDetailType()
        {
            _roundingItem = new roundingItemType();
            _vydejkaItem = new List<vydejkaItemType>();
        }
        
        [XmlElement("vydejkaItem")]
        public List<vydejkaItemType> vydejkaItem
        {
            get
            {
                return _vydejkaItem;
            }
            set
            {
                _vydejkaItem = value;
            }
        }
        
        public roundingItemType roundingItem
        {
            get
            {
                return _roundingItem;
            }
            set
            {
                _roundingItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class roundingItemType
    {
        #region Private fields
        private string _id;
        private string _text;
        private float _quantity;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private typeCurrencyHomeItemRounding _homeCurrency;
        #endregion
        
        public roundingItemType()
        {
            _homeCurrency = new typeCurrencyHomeItemRounding();
            _quantity = ((float)(1F));
            _payVAT = boolean.@false;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        public typeCurrencyHomeItemRounding homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class typeCurrencyHomeItemRounding
    {
        #region Private fields
        private double _unitPrice;
        private double _price;
        private double _priceVAT;
        #endregion
        
        public double unitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }
        
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        
        public double priceVAT
        {
            get
            {
                return _priceVAT;
            }
            set
            {
                _priceVAT = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vydejka.xsd")]
    public partial class vydejkaHeaderType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private stornoType _storno;
        private numberType1 _number;
        private System.DateTime _date;
        private string _numberOrder;
        private string _dateOrder;
        private string _text;
        private address _partnerIdentity;
        private string _acc;
        private string _symPar;
        private refType _priceLevel;
        private paymentType _paymentType;
        private refType _kasa;
        private boolean _isExecuted;
        private boolean _isDelivered;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private carrierType _carrier;
        private refTypeRegVATinEU _regVATinEU;
        private MOSStype _mOSS;
        private List<string> _evidentiaryResourcesMOSS;
        private string _accountingPeriodMOSS;
        private string _note;
        private string _intNote;
        private boolean _histRate;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        private typeValidate _validate;
        #endregion
        
        public vydejkaHeaderType()
        {
            _validate = new typeValidate();
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _evidentiaryResourcesMOSS = new List<string>();
            _mOSS = new MOSStype();
            _regVATinEU = new refTypeRegVATinEU();
            _carrier = new carrierType();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _kasa = new refType();
            _paymentType = new paymentType();
            _priceLevel = new refType();
            _partnerIdentity = new address();
            _number = new numberType1();
            _extId = new extIdType();
            _histRate = boolean.@false;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public stornoType storno
        {
            get
            {
                return _storno;
            }
            set
            {
                _storno = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        public string numberOrder
        {
            get
            {
                return _numberOrder;
            }
            set
            {
                _numberOrder = value;
            }
        }
        
        public string dateOrder
        {
            get
            {
                return _dateOrder;
            }
            set
            {
                _dateOrder = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public string acc
        {
            get
            {
                return _acc;
            }
            set
            {
                _acc = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public refType priceLevel
        {
            get
            {
                return _priceLevel;
            }
            set
            {
                _priceLevel = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public paymentType paymentType
        {
            get
            {
                return _paymentType;
            }
            set
            {
                _paymentType = value;
            }
        }
        
        public refType kasa
        {
            get
            {
                return _kasa;
            }
            set
            {
                _kasa = value;
            }
        }
        
        public boolean isExecuted
        {
            get
            {
                return _isExecuted;
            }
            set
            {
                _isExecuted = value;
            }
        }
        
        public boolean isDelivered
        {
            get
            {
                return _isDelivered;
            }
            set
            {
                _isDelivered = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public carrierType carrier
        {
            get
            {
                return _carrier;
            }
            set
            {
                _carrier = value;
            }
        }
        
        public refTypeRegVATinEU regVATinEU
        {
            get
            {
                return _regVATinEU;
            }
            set
            {
                _regVATinEU = value;
            }
        }
        
        public MOSStype MOSS
        {
            get
            {
                return _mOSS;
            }
            set
            {
                _mOSS = value;
            }
        }
        
        [XmlArrayItemAttribute("ids", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<string> evidentiaryResourcesMOSS
        {
            get
            {
                return _evidentiaryResourcesMOSS;
            }
            set
            {
                _evidentiaryResourcesMOSS = value;
            }
        }
        
        public string accountingPeriodMOSS
        {
            get
            {
                return _accountingPeriodMOSS;
            }
            set
            {
                _accountingPeriodMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        
        public typeValidate validate
        {
            get
            {
                return _validate;
            }
            set
            {
                _validate = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum stornoType
    {
        cancelledDocument,
        cancelDocument,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class paymentType
    {
        #region Private fields
        private string _id;
        private string _ids;
        private paymentTypePaymentType _paymentType1;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        [XmlElement("paymentType")]
        public paymentTypePaymentType paymentType1
        {
            get
            {
                return _paymentType1;
            }
            set
            {
                _paymentType1 = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum paymentTypePaymentType
    {
        draft,
        cash,
        postal,
        delivery,
        creditcard,
        advance,
        encashment,
        cheque,
        compensation,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class carrierType
    {
        #region Private fields
        private string _id;
        private string _ids;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class refTypeRegVATinEU
    {
        #region Private fields
        private string _id;
        private string _ids;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/vydejka.xsd")]
    public partial class vydejkaType
    {
        #region Private fields
        private object[] _links;
        private vydejkaHeaderType _vydejkaHeader;
        private vydejkaDetailType _vydejkaDetail;
        private vydejkaSummaryType _vydejkaSummary;
        private object[] _linkedDocuments;
        private List<printerSettingsType> _print;
        private vydVersionType _version;
        #endregion
        
        public vydejkaType()
        {
            _print = new List<printerSettingsType>();
            _vydejkaSummary = new vydejkaSummaryType();
            _vydejkaDetail = new vydejkaDetailType();
            _vydejkaHeader = new vydejkaHeaderType();
        }
        
        [XmlArrayItemAttribute("link", typeof(linkElemetType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        [XmlArrayItemAttribute("manualLink", typeof(manualLinkElementType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public object[] links
        {
            get
            {
                return _links;
            }
            set
            {
                _links = value;
            }
        }
        
        public vydejkaHeaderType vydejkaHeader
        {
            get
            {
                return _vydejkaHeader;
            }
            set
            {
                _vydejkaHeader = value;
            }
        }
        
        public vydejkaDetailType vydejkaDetail
        {
            get
            {
                return _vydejkaDetail;
            }
            set
            {
                _vydejkaDetail = value;
            }
        }
        
        public vydejkaSummaryType vydejkaSummary
        {
            get
            {
                return _vydejkaSummary;
            }
            set
            {
                _vydejkaSummary = value;
            }
        }
        
        [XmlArrayItemAttribute("link", typeof(linkElemetType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        [XmlArrayItemAttribute("manualLink", typeof(manualLinkElementType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public object[] linkedDocuments
        {
            get
            {
                return _linkedDocuments;
            }
            set
            {
                _linkedDocuments = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public vydVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class linkElemetType
    {
        #region Private fields
        private agendaType _sourceAgenda;
        private sourceDocumentType _sourceDocument;
        private settingsSourceDocumentType _settingsSourceDocument;
        #endregion
        
        public linkElemetType()
        {
            _settingsSourceDocument = new settingsSourceDocumentType();
            _sourceDocument = new sourceDocumentType();
        }
        
        public agendaType sourceAgenda
        {
            get
            {
                return _sourceAgenda;
            }
            set
            {
                _sourceAgenda = value;
            }
        }
        
        public sourceDocumentType sourceDocument
        {
            get
            {
                return _sourceDocument;
            }
            set
            {
                _sourceDocument = value;
            }
        }
        
        public settingsSourceDocumentType settingsSourceDocument
        {
            get
            {
                return _settingsSourceDocument;
            }
            set
            {
                _settingsSourceDocument = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class settingsSourceDocumentType
    {
        #region Private fields
        private linkOrderToAdvanceInvoiceType _item;
        #endregion
        
        public settingsSourceDocumentType()
        {
            _item = linkOrderToAdvanceInvoiceType.Item3;
        }
        
        [XmlElement("linkOrderToAdvanceInvoice")]
        public linkOrderToAdvanceInvoiceType Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum linkOrderToAdvanceInvoiceType
    {
        [XmlEnumAttribute("1")]
        Item1,
        [XmlEnumAttribute("2")]
        Item2,
        [XmlEnumAttribute("3")]
        Item3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class manualLinkElementType
    {
        #region Private fields
        private agendaType _sourceAgenda;
        private sourceDocumentType _sourceDocument;
        #endregion
        
        public manualLinkElementType()
        {
            _sourceDocument = new sourceDocumentType();
        }
        
        public agendaType sourceAgenda
        {
            get
            {
                return _sourceAgenda;
            }
            set
            {
                _sourceAgenda = value;
            }
        }
        
        public sourceDocumentType sourceDocument
        {
            get
            {
                return _sourceDocument;
            }
            set
            {
                _sourceDocument = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public partial class voucherSummaryType
    {
        #region Private fields
        private typeRoundingDocument _roundingDocument;
        private string _roundingVAT;
        private bool _calculateVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        private typeCurrencyForeign _foreignCurrency;
        #endregion
        
        public voucherSummaryType()
        {
            _foreignCurrency = new typeCurrencyForeign();
            _homeCurrency = new typeCurrencyHome();
            _calculateVAT = false;
        }
        
        public typeRoundingDocument roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public string roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        [DefaultValue(false)]
        public bool calculateVAT
        {
            get
            {
                return _calculateVAT;
            }
            set
            {
                _calculateVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeign foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public partial class liquidationItemType
    {
        #region Private fields
        private string _text;
        private float _quantity;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private typeCurrencyHomeItem2 _homeCurrency;
        private string _note;
        private string _symPar;
        private refType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        #endregion
        
        public liquidationItemType()
        {
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new refType();
            _homeCurrency = new typeCurrencyHomeItem2();
            _quantity = ((float)(1F));
            _payVAT = boolean.@false;
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public typeCurrencyHomeItem2 homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public refType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class typeCurrencyHomeItem2
    {
        #region Private fields
        private double _unitPrice;
        private double _price;
        private double _priceVAT;
        private double _priceSum;
        #endregion
        
        public double unitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }
        
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        
        public double priceVAT
        {
            get
            {
                return _priceVAT;
            }
            set
            {
                _priceVAT = value;
            }
        }
        
        public double priceSum
        {
            get
            {
                return _priceSum;
            }
            set
            {
                _priceSum = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public partial class settingsLiquidationType
    {
        #region Private fields
        private liquidatedDocumentAgendaType _sourceAgenda;
        private sourceDocumentType _sourceDocument;
        private double _liquidationPrice;
        #endregion
        
        public settingsLiquidationType()
        {
            _sourceDocument = new sourceDocumentType();
        }
        
        public liquidatedDocumentAgendaType sourceAgenda
        {
            get
            {
                return _sourceAgenda;
            }
            set
            {
                _sourceAgenda = value;
            }
        }
        
        public sourceDocumentType sourceDocument
        {
            get
            {
                return _sourceDocument;
            }
            set
            {
                _sourceDocument = value;
            }
        }
        
        public double liquidationPrice
        {
            get
            {
                return _liquidationPrice;
            }
            set
            {
                _liquidationPrice = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum liquidatedDocumentAgendaType
    {
        issuedInvoice,
        receivedInvoice,
        receivable,
        commitment,
        issuedAdvanceInvoice,
        receivedAdvanceInvoice,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public partial class voucherliquidationItemType
    {
        #region Private fields
        private settingsLiquidationType _settingsLiquidation;
        private List<liquidationItemType> _liquidationItem;
        #endregion
        
        public voucherliquidationItemType()
        {
            _liquidationItem = new List<liquidationItemType>();
            _settingsLiquidation = new settingsLiquidationType();
        }
        
        public settingsLiquidationType settingsLiquidation
        {
            get
            {
                return _settingsLiquidation;
            }
            set
            {
                _settingsLiquidation = value;
            }
        }
        
        [XmlElement("liquidationItem")]
        public List<liquidationItemType> liquidationItem
        {
            get
            {
                return _liquidationItem;
            }
            set
            {
                _liquidationItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public partial class voucherItemType
    {
        #region Private fields
        private string _text;
        private float _quantity;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private typeCurrencyForeignItem _foreignCurrency;
        private MOSStype _typeServiceMOSS;
        private string _note;
        private string _code;
        private string _symPar;
        private stockItemType _stockItem;
        private refType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private bool _pDP;
        private string _codePDP;
        private recyclingContribType _recyclingContrib;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private EETItemType _eETItem;
        private List<parameterDocType> _parameters;
        #endregion
        
        public voucherItemType()
        {
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _recyclingContrib = new recyclingContribType();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new refType();
            _stockItem = new stockItemType();
            _typeServiceMOSS = new MOSStype();
            _foreignCurrency = new typeCurrencyForeignItem();
            _homeCurrency = new typeCurrencyHomeItem();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public refType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public bool PDP
        {
            get
            {
                return _pDP;
            }
            set
            {
                _pDP = value;
            }
        }
        
        public string CodePDP
        {
            get
            {
                return _codePDP;
            }
            set
            {
                _codePDP = value;
            }
        }
        
        public recyclingContribType recyclingContrib
        {
            get
            {
                return _recyclingContrib;
            }
            set
            {
                _recyclingContrib = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public EETItemType EETItem
        {
            get
            {
                return _eETItem;
            }
            set
            {
                _eETItem = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum EETItemType
    {
        BezTypu,
        CestovniSluzba,
        Osvobozene,
        Poukaz,
        PouziteZakladni,
        PouziteSnizena1,
        PouziteSnizena2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public partial class voucherDetailType
    {
        #region Private fields
        private List<voucherItemType> _voucherItem;
        private List<voucherliquidationItemType> _voucherLiquidationItem;
        private roundingItemType _roundingItem;
        private List<string> _text;
        #endregion
        
        public voucherDetailType()
        {
            _text = new List<string>();
            _roundingItem = new roundingItemType();
            _voucherLiquidationItem = new List<voucherliquidationItemType>();
            _voucherItem = new List<voucherItemType>();
        }
        
        [XmlElement("voucherItem")]
        public List<voucherItemType> voucherItem
        {
            get
            {
                return _voucherItem;
            }
            set
            {
                _voucherItem = value;
            }
        }
        
        [XmlElement("voucherLiquidationItem")]
        public List<voucherliquidationItemType> voucherLiquidationItem
        {
            get
            {
                return _voucherLiquidationItem;
            }
            set
            {
                _voucherLiquidationItem = value;
            }
        }
        
        public roundingItemType roundingItem
        {
            get
            {
                return _roundingItem;
            }
            set
            {
                _roundingItem = value;
            }
        }
        
        [XmlTextAttribute]
        public List<string> Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public partial class voucherHeaderType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private voucherTypeType _voucherType;
        private stornoType _storno;
        private refType _cashAccount;
        private numberType1 _number;
        private string _originalDocument;
        private System.DateTime _date;
        private System.DateTime _datePayment;
        private System.DateTime _dateTax;
        private string _dateKHDPH;
        private accountingType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private string _text;
        private address _partnerIdentity;
        private myAddress _myIdentity;
        private string _symPar;
        private refType _priceLevel;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private refTypeRegVATinEU _regVATinEU;
        private MOSStype _mOSS;
        private List<string> _evidentiaryResourcesMOSS;
        private string _accountingPeriodMOSS;
        private string _note;
        private string _intNote;
        private boolean _histRate;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        private typeValidate _validate;
        #endregion
        
        public voucherHeaderType()
        {
            _validate = new typeValidate();
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _evidentiaryResourcesMOSS = new List<string>();
            _mOSS = new MOSStype();
            _regVATinEU = new refTypeRegVATinEU();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _priceLevel = new refType();
            _myIdentity = new myAddress();
            _partnerIdentity = new address();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new accountingType();
            _number = new numberType1();
            _cashAccount = new refType();
            _extId = new extIdType();
            _histRate = boolean.@false;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public voucherTypeType voucherType
        {
            get
            {
                return _voucherType;
            }
            set
            {
                _voucherType = value;
            }
        }
        
        public stornoType storno
        {
            get
            {
                return _storno;
            }
            set
            {
                _storno = value;
            }
        }
        
        public refType cashAccount
        {
            get
            {
                return _cashAccount;
            }
            set
            {
                _cashAccount = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public string originalDocument
        {
            get
            {
                return _originalDocument;
            }
            set
            {
                _originalDocument = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime datePayment
        {
            get
            {
                return _datePayment;
            }
            set
            {
                _datePayment = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTax
        {
            get
            {
                return _dateTax;
            }
            set
            {
                _dateTax = value;
            }
        }
        
        public string dateKHDPH
        {
            get
            {
                return _dateKHDPH;
            }
            set
            {
                _dateKHDPH = value;
            }
        }
        
        public accountingType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public myAddress myIdentity
        {
            get
            {
                return _myIdentity;
            }
            set
            {
                _myIdentity = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public refType priceLevel
        {
            get
            {
                return _priceLevel;
            }
            set
            {
                _priceLevel = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public refTypeRegVATinEU regVATinEU
        {
            get
            {
                return _regVATinEU;
            }
            set
            {
                _regVATinEU = value;
            }
        }
        
        public MOSStype MOSS
        {
            get
            {
                return _mOSS;
            }
            set
            {
                _mOSS = value;
            }
        }
        
        [XmlArrayItemAttribute("ids", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<string> evidentiaryResourcesMOSS
        {
            get
            {
                return _evidentiaryResourcesMOSS;
            }
            set
            {
                _evidentiaryResourcesMOSS = value;
            }
        }
        
        public string accountingPeriodMOSS
        {
            get
            {
                return _accountingPeriodMOSS;
            }
            set
            {
                _accountingPeriodMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        
        public typeValidate validate
        {
            get
            {
                return _validate;
            }
            set
            {
                _validate = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public enum voucherTypeType
    {
        receipt,
        expense,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public partial class voucherType
    {
        #region Private fields
        private cancelDocumentType _cancelDocument;
        private voucherHeaderType _voucherHeader;
        private voucherDetailType _voucherDetail;
        private voucherSummaryType _voucherSummary;
        private EETType _eET;
        private List<printerSettingsType> _print;
        private vchVersionType _version;
        #endregion
        
        public voucherType()
        {
            _print = new List<printerSettingsType>();
            _eET = new EETType();
            _voucherSummary = new voucherSummaryType();
            _voucherDetail = new voucherDetailType();
            _voucherHeader = new voucherHeaderType();
            _cancelDocument = new cancelDocumentType();
        }
        
        public cancelDocumentType cancelDocument
        {
            get
            {
                return _cancelDocument;
            }
            set
            {
                _cancelDocument = value;
            }
        }
        
        public voucherHeaderType voucherHeader
        {
            get
            {
                return _voucherHeader;
            }
            set
            {
                _voucherHeader = value;
            }
        }
        
        public voucherDetailType voucherDetail
        {
            get
            {
                return _voucherDetail;
            }
            set
            {
                _voucherDetail = value;
            }
        }
        
        public voucherSummaryType voucherSummary
        {
            get
            {
                return _voucherSummary;
            }
            set
            {
                _voucherSummary = value;
            }
        }
        
        public EETType EET
        {
            get
            {
                return _eET;
            }
            set
            {
                _eET = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public vchVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class cancelDocumentType
    {
        #region Private fields
        private sourceDocumentType _sourceDocument;
        #endregion
        
        public cancelDocumentType()
        {
            _sourceDocument = new sourceDocumentType();
        }
        
        public sourceDocumentType sourceDocument
        {
            get
            {
                return _sourceDocument;
            }
            set
            {
                _sourceDocument = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class EETType
    {
        #region Private fields
        private stateEETType _stateEET;
        private List<detailEETType> _detailEET;
        private refType _profile;
        #endregion
        
        public EETType()
        {
            _profile = new refType();
            _detailEET = new List<detailEETType>();
        }
        
        public stateEETType stateEET
        {
            get
            {
                return _stateEET;
            }
            set
            {
                _stateEET = value;
            }
        }
        
        [XmlElement("detailEET")]
        public List<detailEETType> detailEET
        {
            get
            {
                return _detailEET;
            }
            set
            {
                _detailEET = value;
            }
        }
        
        public refType profile
        {
            get
            {
                return _profile;
            }
            set
            {
                _profile = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum stateEETType
    {
        notEnter,
        notSend,
        forSending,
        externally,
        simplify,
        sent,
        invalidData,
        commError,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class detailEETType
    {
        #region Private fields
        private string _numberOfDocument;
        private System.DateTime _dateOfSale;
        private double _price;
        private byte[] _pKP;
        private string _bKP;
        private string _fIK;
        private string _establishment;
        private string _cashDevice;
        private EETmodeType _mode;
        private System.DateTime _dateOfSend;
        private System.DateTime _dateOfAcceptance;
        private boolean _testMode;
        private string _vATIdOfPayer;
        private string _vATIdOfAuthPayer;
        private double _priceExempt;
        private double _priceBasic;
        private double _vATBasic;
        private double _priceReduced;
        private double _vATReduced;
        private double _priceSecondReduced;
        private double _vATSecondReduced;
        private double _travelService;
        private double _usedGoodsBasic;
        private double _usedGoodsFirstReduced;
        private double _usedGoodsSecondReduced;
        private double _forApply;
        private double _apply;
        private bool _firstSending;
        private string _uUID;
        private string _protocolVersion;
        #endregion
        
        public detailEETType()
        {
            _testMode = boolean.@false;
            _firstSending = true;
        }
        
        public string numberOfDocument
        {
            get
            {
                return _numberOfDocument;
            }
            set
            {
                _numberOfDocument = value;
            }
        }
        
        public System.DateTime dateOfSale
        {
            get
            {
                return _dateOfSale;
            }
            set
            {
                _dateOfSale = value;
            }
        }
        
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        
        [XmlElement(DataType="base64Binary")]
        public byte[] PKP
        {
            get
            {
                return _pKP;
            }
            set
            {
                _pKP = value;
            }
        }
        
        public string BKP
        {
            get
            {
                return _bKP;
            }
            set
            {
                _bKP = value;
            }
        }
        
        public string FIK
        {
            get
            {
                return _fIK;
            }
            set
            {
                _fIK = value;
            }
        }
        
        public string establishment
        {
            get
            {
                return _establishment;
            }
            set
            {
                _establishment = value;
            }
        }
        
        public string cashDevice
        {
            get
            {
                return _cashDevice;
            }
            set
            {
                _cashDevice = value;
            }
        }
        
        public EETmodeType mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
            }
        }
        
        public System.DateTime dateOfSend
        {
            get
            {
                return _dateOfSend;
            }
            set
            {
                _dateOfSend = value;
            }
        }
        
        public System.DateTime dateOfAcceptance
        {
            get
            {
                return _dateOfAcceptance;
            }
            set
            {
                _dateOfAcceptance = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean testMode
        {
            get
            {
                return _testMode;
            }
            set
            {
                _testMode = value;
            }
        }
        
        public string VATIdOfPayer
        {
            get
            {
                return _vATIdOfPayer;
            }
            set
            {
                _vATIdOfPayer = value;
            }
        }
        
        public string VATIdOfAuthPayer
        {
            get
            {
                return _vATIdOfAuthPayer;
            }
            set
            {
                _vATIdOfAuthPayer = value;
            }
        }
        
        public double priceExempt
        {
            get
            {
                return _priceExempt;
            }
            set
            {
                _priceExempt = value;
            }
        }
        
        public double priceBasic
        {
            get
            {
                return _priceBasic;
            }
            set
            {
                _priceBasic = value;
            }
        }
        
        public double VATBasic
        {
            get
            {
                return _vATBasic;
            }
            set
            {
                _vATBasic = value;
            }
        }
        
        public double priceReduced
        {
            get
            {
                return _priceReduced;
            }
            set
            {
                _priceReduced = value;
            }
        }
        
        public double VATReduced
        {
            get
            {
                return _vATReduced;
            }
            set
            {
                _vATReduced = value;
            }
        }
        
        public double priceSecondReduced
        {
            get
            {
                return _priceSecondReduced;
            }
            set
            {
                _priceSecondReduced = value;
            }
        }
        
        public double VATSecondReduced
        {
            get
            {
                return _vATSecondReduced;
            }
            set
            {
                _vATSecondReduced = value;
            }
        }
        
        public double travelService
        {
            get
            {
                return _travelService;
            }
            set
            {
                _travelService = value;
            }
        }
        
        public double usedGoodsBasic
        {
            get
            {
                return _usedGoodsBasic;
            }
            set
            {
                _usedGoodsBasic = value;
            }
        }
        
        public double usedGoodsFirstReduced
        {
            get
            {
                return _usedGoodsFirstReduced;
            }
            set
            {
                _usedGoodsFirstReduced = value;
            }
        }
        
        public double usedGoodsSecondReduced
        {
            get
            {
                return _usedGoodsSecondReduced;
            }
            set
            {
                _usedGoodsSecondReduced = value;
            }
        }
        
        public double forApply
        {
            get
            {
                return _forApply;
            }
            set
            {
                _forApply = value;
            }
        }
        
        public double apply
        {
            get
            {
                return _apply;
            }
            set
            {
                _apply = value;
            }
        }
        
        [DefaultValue(true)]
        public bool firstSending
        {
            get
            {
                return _firstSending;
            }
            set
            {
                _firstSending = value;
            }
        }
        
        public string UUID
        {
            get
            {
                return _uUID;
            }
            set
            {
                _uUID = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string protocolVersion
        {
            get
            {
                return _protocolVersion;
            }
            set
            {
                _protocolVersion = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum EETmodeType
    {
        current,
        simplified,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
    public enum vchVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class serialNumberItemType
    {
        #region Private fields
        private string _id;
        private string _serialNumber;
        private float _count;
        private System.DateTime _expiration;
        private string _note;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string serialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                _serialNumber = value;
            }
        }
        
        public float count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime expiration
        {
            get
            {
                return _expiration;
            }
            set
            {
                _expiration = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class attachItemType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private refTypeStorage _storage;
        private string _code;
        private string _name;
        private float _count;
        private float _quantity;
        private string _unit;
        private string _stockOrder;
        private boolean _warehouse;
        private boolean _notExpedite;
        private boolean _edit;
        private List<stockPriceType> _stockPriceItem;
        #endregion
        
        public attachItemType()
        {
            _stockPriceItem = new List<stockPriceType>();
            _storage = new refTypeStorage();
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public refTypeStorage storage
        {
            get
            {
                return _storage;
            }
            set
            {
                _storage = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public float count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string stockOrder
        {
            get
            {
                return _stockOrder;
            }
            set
            {
                _stockOrder = value;
            }
        }
        
        public boolean warehouse
        {
            get
            {
                return _warehouse;
            }
            set
            {
                _warehouse = value;
            }
        }
        
        public boolean notExpedite
        {
            get
            {
                return _notExpedite;
            }
            set
            {
                _notExpedite = value;
            }
        }
        
        public boolean edit
        {
            get
            {
                return _edit;
            }
            set
            {
                _edit = value;
            }
        }
        
        [XmlArrayItemAttribute("stockPrice", IsNullable=false)]
        public List<stockPriceType> stockPriceItem
        {
            get
            {
                return _stockPriceItem;
            }
            set
            {
                _stockPriceItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class stockPriceType
    {
        #region Private fields
        private string _id;
        private string _ids;
        private double _price;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="stockItemType", Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class stockItemType1
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private refTypeStorage _storage;
        private string _code;
        private string _name;
        private float _count;
        private float _quantity;
        private string _unit;
        private string _stockOrder;
        private List<stockPriceType> _stockPriceItem;
        #endregion
        
        public stockItemType1()
        {
            _stockPriceItem = new List<stockPriceType>();
            _storage = new refTypeStorage();
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public refTypeStorage storage
        {
            get
            {
                return _storage;
            }
            set
            {
                _storage = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public float count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string stockOrder
        {
            get
            {
                return _stockOrder;
            }
            set
            {
                _stockOrder = value;
            }
        }
        
        [XmlArrayItemAttribute("stockPrice", IsNullable=false)]
        public List<stockPriceType> stockPriceItem
        {
            get
            {
                return _stockPriceItem;
            }
            set
            {
                _stockPriceItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class intParameterValueType
    {
        #region Private fields
        private string _parameterValueID;
        private string _parameterValue;
        private string _parameterOrder;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string parameterValueID
        {
            get
            {
                return _parameterValueID;
            }
            set
            {
                _parameterValueID = value;
            }
        }
        
        public string parameterValue
        {
            get
            {
                return _parameterValue;
            }
            set
            {
                _parameterValue = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string parameterOrder
        {
            get
            {
                return _parameterOrder;
            }
            set
            {
                _parameterOrder = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class intParameterType
    {
        #region Private fields
        private actionTypeItem _actionType;
        private string _intParameterID;
        private string _intParameterName;
        private string _intParameterOrder;
        private internetParameterType _intParameterType1;
        private List<intParameterValueType> _intParameterValues;
        #endregion
        
        public intParameterType()
        {
            _intParameterValues = new List<intParameterValueType>();
            _actionType = new actionTypeItem();
        }
        
        public actionTypeItem actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string intParameterID
        {
            get
            {
                return _intParameterID;
            }
            set
            {
                _intParameterID = value;
            }
        }
        
        public string intParameterName
        {
            get
            {
                return _intParameterName;
            }
            set
            {
                _intParameterName = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string intParameterOrder
        {
            get
            {
                return _intParameterOrder;
            }
            set
            {
                _intParameterOrder = value;
            }
        }
        
        [XmlElement("intParameterType")]
        public internetParameterType intParameterType1
        {
            get
            {
                return _intParameterType1;
            }
            set
            {
                _intParameterType1 = value;
            }
        }
        
        [XmlArrayItemAttribute("intParameterValue", IsNullable=false)]
        public List<intParameterValueType> intParameterValues
        {
            get
            {
                return _intParameterValues;
            }
            set
            {
                _intParameterValues = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class actionTypeStockItem
    {
        #region Private fields
        private object _item;
        private ItemChoiceType4 _itemElementName;
        #endregion
        
        [XmlElement("add", typeof(string))]
        [XmlElement("delete", typeof(requestStockType))]
        [XmlElement("update", typeof(requestStockType))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlIgnore]
        public ItemChoiceType4 ItemElementName
        {
            get
            {
                return _itemElementName;
            }
            set
            {
                _itemElementName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IncludeInSchema=false)]
    public enum ItemChoiceType4
    {
        add,
        delete,
        update,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class orderStockItemType
    {
        #region Private fields
        private actionTypeStockItem _actionType;
        private string _stockOrder;
        private stockRefType _stockItem;
        #endregion
        
        public orderStockItemType()
        {
            _stockItem = new stockRefType();
            _actionType = new actionTypeStockItem();
        }
        
        public actionTypeStockItem actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string stockOrder
        {
            get
            {
                return _stockOrder;
            }
            set
            {
                _stockOrder = value;
            }
        }
        
        public stockRefType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class relatedLinkType
    {
        #region Private fields
        private string _addressURL;
        private string _description;
        private string _order;
        #endregion
        
        public string addressURL
        {
            get
            {
                return _addressURL;
            }
            set
            {
                _addressURL = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string order
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class relatedFileType
    {
        #region Private fields
        private string _filepath;
        private string _description;
        private string _order;
        #endregion
        
        public string filepath
        {
            get
            {
                return _filepath;
            }
            set
            {
                _filepath = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string order
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class pictureType
    {
        #region Private fields
        private actionTypeItem _actionType;
        private string _id;
        private string _filepath;
        private string _description;
        private string _order;
        private bool _default;
        #endregion
        
        public pictureType()
        {
            _actionType = new actionTypeItem();
        }
        
        public actionTypeItem actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string filepath
        {
            get
            {
                return _filepath;
            }
            set
            {
                _filepath = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string order
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
            }
        }
        
        [XmlAttribute]
        public bool @default
        {
            get
            {
                return _default;
            }
            set
            {
                _default = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class instrastatType
    {
        #region Private fields
        private string _goodsCode;
        private string _description;
        private string _statistic;
        private string _unit;
        private float _coefficient;
        private string _country;
        #endregion
        
        public string goodsCode
        {
            get
            {
                return _goodsCode;
            }
            set
            {
                _goodsCode = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        public string statistic
        {
            get
            {
                return _statistic;
            }
            set
            {
                _statistic = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        public string country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="recyclingContribType", Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class recyclingContribType1
    {
        #region Private fields
        private refType _recyclingContribType;
        private System.Nullable<float> _coefficientOfRecyclingContrib;
        #endregion
        
        public recyclingContribType1()
        {
            _recyclingContribType = new refType();
        }
        
        public refType recyclingContribType
        {
            get
            {
                return _recyclingContribType;
            }
            set
            {
                _recyclingContribType = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public System.Nullable<float> coefficientOfRecyclingContrib
        {
            get
            {
                return _coefficientOfRecyclingContrib;
            }
            set
            {
                _coefficientOfRecyclingContrib = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="eKasaItemType", Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class eKasaItemType1
    {
        #region Private fields
        private eKasaRefundType _refundType;
        #endregion
        
        public eKasaRefundType refundType
        {
            get
            {
                return _refundType;
            }
            set
            {
                _refundType = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum eKasaRefundType
    {
        none,
        @return,
        exchange,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class companyType
    {
        #region Private fields
        private string _id;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class stockHeaderType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private stockTypeType _stockType;
        private string _code;
        private string _eAN;
        private string _pLU;
        private boolean _isSales;
        private boolean _isSerialNumber;
        private boolean _isInternet;
        private boolean _isBatch;
        private vatRateType _purchasingRateVAT;
        private vatRateType _sellingRateVAT;
        private string _name;
        private string _nameComplement;
        private string _unit;
        private string _unit2;
        private string _unit3;
        private float _coefficient2;
        private float _coefficient3;
        private refTypeStorage _storage;
        private refType _typePrice;
        private double _weightedPurchasePrice;
        private stockHeaderTypePurchasingPrice _purchasingPrice;
        private stockHeaderTypeSellingPrice _sellingPrice;
        private fixationType _fixation;
        private float _limitMin;
        private float _limitMax;
        private float _mass;
        private float _volume;
        private float _count;
        private float _countReceivedOrders;
        private float _reservation;
        private companyType _supplier;
        private string _orderName;
        private float _orderQuantity;
        private float _countIssuedOrders;
        private float _reclamation;
        private float _service;
        private string _shortName;
        private refType _typeRP;
        private guaranteeTypeType _guaranteeType;
        private string _guarantee;
        private string _producer;
        private string _unitOfMeasure;
        private System.Nullable<float> _coefficientOfMeasure;
        private EETItemType _eETItem;
        private string _dicPP;
        private eKasaItemType1 _eKasaItem;
        private string _yield;
        private string _cost;
        private classificationVATType _classificationVATReceipt;
        private refType _classificationKVDPHReceipt;
        private classificationVATType _classificationVATIssue;
        private refType _classificationKVDPHIssue;
        private classOfStockType _classOfStock;
        private string _acc;
        private MOSStype _typeServiceMOSS;
        private boolean _controlLimitTaxLiability;
        private boolean _pDP;
        private classificationVATType _pDPclassificationVATIssue;
        private refType _pDPclassificationKVDPHIssue;
        private string _codePDP;
        private recyclingContribType1 _recyclingContrib;
        private instrastatType _intrastat;
        private boolean _news;
        private boolean _clearanceSale;
        private boolean _sale;
        private boolean _recommended;
        private boolean _discount;
        private boolean _prepare;
        private string _availability;
        private string _handlingInformation;
        private string _foreignName1;
        private string _foreignNameComplement1;
        private string _foreignName2;
        private string _foreignNameComplement2;
        private string _description;
        private string _description2;
        private List<pictureType> _pictures;
        private List<string> _categories;
        private List<relatedFileType> _relatedFiles;
        private List<relatedLinkType> _relatedLinks;
        private List<orderStockItemType> _relatedStocks;
        private List<orderStockItemType> _alternativeStocks;
        private List<intParameterType> _intParameters;
        private string _note;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        #endregion
        
        public stockHeaderType()
        {
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _intParameters = new List<intParameterType>();
            _alternativeStocks = new List<orderStockItemType>();
            _relatedStocks = new List<orderStockItemType>();
            _relatedLinks = new List<relatedLinkType>();
            _relatedFiles = new List<relatedFileType>();
            _categories = new List<string>();
            _pictures = new List<pictureType>();
            _intrastat = new instrastatType();
            _recyclingContrib = new recyclingContribType1();
            _pDPclassificationKVDPHIssue = new refType();
            _pDPclassificationVATIssue = new classificationVATType();
            _typeServiceMOSS = new MOSStype();
            _classificationKVDPHIssue = new refType();
            _classificationVATIssue = new classificationVATType();
            _classificationKVDPHReceipt = new refType();
            _classificationVATReceipt = new classificationVATType();
            _eKasaItem = new eKasaItemType1();
            _typeRP = new refType();
            _supplier = new companyType();
            _sellingPrice = new stockHeaderTypeSellingPrice();
            _purchasingPrice = new stockHeaderTypePurchasingPrice();
            _typePrice = new refType();
            _storage = new refTypeStorage();
            _extId = new extIdType();
            _pLU = "0";
            _purchasingRateVAT = vatRateType.none;
            _sellingRateVAT = vatRateType.none;
            _coefficient2 = ((float)(1F));
            _coefficient3 = ((float)(1F));
            _limitMin = ((float)(0F));
            _limitMax = ((float)(0F));
            _mass = ((float)(0F));
            _volume = ((float)(0F));
            _controlLimitTaxLiability = boolean.@false;
            _pDP = boolean.@false;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public stockTypeType stockType
        {
            get
            {
                return _stockType;
            }
            set
            {
                _stockType = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public string EAN
        {
            get
            {
                return _eAN;
            }
            set
            {
                _eAN = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        [DefaultValue("0")]
        public string PLU
        {
            get
            {
                return _pLU;
            }
            set
            {
                _pLU = value;
            }
        }
        
        public boolean isSales
        {
            get
            {
                return _isSales;
            }
            set
            {
                _isSales = value;
            }
        }
        
        public boolean isSerialNumber
        {
            get
            {
                return _isSerialNumber;
            }
            set
            {
                _isSerialNumber = value;
            }
        }
        
        public boolean isInternet
        {
            get
            {
                return _isInternet;
            }
            set
            {
                _isInternet = value;
            }
        }
        
        public boolean isBatch
        {
            get
            {
                return _isBatch;
            }
            set
            {
                _isBatch = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType purchasingRateVAT
        {
            get
            {
                return _purchasingRateVAT;
            }
            set
            {
                _purchasingRateVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType sellingRateVAT
        {
            get
            {
                return _sellingRateVAT;
            }
            set
            {
                _sellingRateVAT = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string nameComplement
        {
            get
            {
                return _nameComplement;
            }
            set
            {
                _nameComplement = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        public string unit2
        {
            get
            {
                return _unit2;
            }
            set
            {
                _unit2 = value;
            }
        }
        
        public string unit3
        {
            get
            {
                return _unit3;
            }
            set
            {
                _unit3 = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient2
        {
            get
            {
                return _coefficient2;
            }
            set
            {
                _coefficient2 = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient3
        {
            get
            {
                return _coefficient3;
            }
            set
            {
                _coefficient3 = value;
            }
        }
        
        public refTypeStorage storage
        {
            get
            {
                return _storage;
            }
            set
            {
                _storage = value;
            }
        }
        
        public refType typePrice
        {
            get
            {
                return _typePrice;
            }
            set
            {
                _typePrice = value;
            }
        }
        
        public double weightedPurchasePrice
        {
            get
            {
                return _weightedPurchasePrice;
            }
            set
            {
                _weightedPurchasePrice = value;
            }
        }
        
        public stockHeaderTypePurchasingPrice purchasingPrice
        {
            get
            {
                return _purchasingPrice;
            }
            set
            {
                _purchasingPrice = value;
            }
        }
        
        public stockHeaderTypeSellingPrice sellingPrice
        {
            get
            {
                return _sellingPrice;
            }
            set
            {
                _sellingPrice = value;
            }
        }
        
        public fixationType fixation
        {
            get
            {
                return _fixation;
            }
            set
            {
                _fixation = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float limitMin
        {
            get
            {
                return _limitMin;
            }
            set
            {
                _limitMin = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float limitMax
        {
            get
            {
                return _limitMax;
            }
            set
            {
                _limitMax = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float mass
        {
            get
            {
                return _mass;
            }
            set
            {
                _mass = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
            }
        }
        
        public float count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        
        public float countReceivedOrders
        {
            get
            {
                return _countReceivedOrders;
            }
            set
            {
                _countReceivedOrders = value;
            }
        }
        
        public float reservation
        {
            get
            {
                return _reservation;
            }
            set
            {
                _reservation = value;
            }
        }
        
        public companyType supplier
        {
            get
            {
                return _supplier;
            }
            set
            {
                _supplier = value;
            }
        }
        
        public string orderName
        {
            get
            {
                return _orderName;
            }
            set
            {
                _orderName = value;
            }
        }
        
        public float orderQuantity
        {
            get
            {
                return _orderQuantity;
            }
            set
            {
                _orderQuantity = value;
            }
        }
        
        public float countIssuedOrders
        {
            get
            {
                return _countIssuedOrders;
            }
            set
            {
                _countIssuedOrders = value;
            }
        }
        
        public float reclamation
        {
            get
            {
                return _reclamation;
            }
            set
            {
                _reclamation = value;
            }
        }
        
        public float service
        {
            get
            {
                return _service;
            }
            set
            {
                _service = value;
            }
        }
        
        public string shortName
        {
            get
            {
                return _shortName;
            }
            set
            {
                _shortName = value;
            }
        }
        
        public refType typeRP
        {
            get
            {
                return _typeRP;
            }
            set
            {
                _typeRP = value;
            }
        }
        
        public guaranteeTypeType guaranteeType
        {
            get
            {
                return _guaranteeType;
            }
            set
            {
                _guaranteeType = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string guarantee
        {
            get
            {
                return _guarantee;
            }
            set
            {
                _guarantee = value;
            }
        }
        
        public string producer
        {
            get
            {
                return _producer;
            }
            set
            {
                _producer = value;
            }
        }
        
        public string unitOfMeasure
        {
            get
            {
                return _unitOfMeasure;
            }
            set
            {
                _unitOfMeasure = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public System.Nullable<float> coefficientOfMeasure
        {
            get
            {
                return _coefficientOfMeasure;
            }
            set
            {
                _coefficientOfMeasure = value;
            }
        }
        
        public EETItemType EETItem
        {
            get
            {
                return _eETItem;
            }
            set
            {
                _eETItem = value;
            }
        }
        
        public string dicPP
        {
            get
            {
                return _dicPP;
            }
            set
            {
                _dicPP = value;
            }
        }
        
        public eKasaItemType1 eKasaItem
        {
            get
            {
                return _eKasaItem;
            }
            set
            {
                _eKasaItem = value;
            }
        }
        
        public string yield
        {
            get
            {
                return _yield;
            }
            set
            {
                _yield = value;
            }
        }
        
        public string cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }
        
        public classificationVATType classificationVATReceipt
        {
            get
            {
                return _classificationVATReceipt;
            }
            set
            {
                _classificationVATReceipt = value;
            }
        }
        
        public refType classificationKVDPHReceipt
        {
            get
            {
                return _classificationKVDPHReceipt;
            }
            set
            {
                _classificationKVDPHReceipt = value;
            }
        }
        
        public classificationVATType classificationVATIssue
        {
            get
            {
                return _classificationVATIssue;
            }
            set
            {
                _classificationVATIssue = value;
            }
        }
        
        public refType classificationKVDPHIssue
        {
            get
            {
                return _classificationKVDPHIssue;
            }
            set
            {
                _classificationKVDPHIssue = value;
            }
        }
        
        public classOfStockType classOfStock
        {
            get
            {
                return _classOfStock;
            }
            set
            {
                _classOfStock = value;
            }
        }
        
        public string acc
        {
            get
            {
                return _acc;
            }
            set
            {
                _acc = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean controlLimitTaxLiability
        {
            get
            {
                return _controlLimitTaxLiability;
            }
            set
            {
                _controlLimitTaxLiability = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean PDP
        {
            get
            {
                return _pDP;
            }
            set
            {
                _pDP = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public classificationVATType PDPclassificationVATIssue
        {
            get
            {
                return _pDPclassificationVATIssue;
            }
            set
            {
                _pDPclassificationVATIssue = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public refType PDPclassificationKVDPHIssue
        {
            get
            {
                return _pDPclassificationKVDPHIssue;
            }
            set
            {
                _pDPclassificationKVDPHIssue = value;
            }
        }
        
        public string CodePDP
        {
            get
            {
                return _codePDP;
            }
            set
            {
                _codePDP = value;
            }
        }
        
        public recyclingContribType1 recyclingContrib
        {
            get
            {
                return _recyclingContrib;
            }
            set
            {
                _recyclingContrib = value;
            }
        }
        
        public instrastatType intrastat
        {
            get
            {
                return _intrastat;
            }
            set
            {
                _intrastat = value;
            }
        }
        
        public boolean news
        {
            get
            {
                return _news;
            }
            set
            {
                _news = value;
            }
        }
        
        public boolean clearanceSale
        {
            get
            {
                return _clearanceSale;
            }
            set
            {
                _clearanceSale = value;
            }
        }
        
        public boolean sale
        {
            get
            {
                return _sale;
            }
            set
            {
                _sale = value;
            }
        }
        
        public boolean recommended
        {
            get
            {
                return _recommended;
            }
            set
            {
                _recommended = value;
            }
        }
        
        public boolean discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }
        
        public boolean prepare
        {
            get
            {
                return _prepare;
            }
            set
            {
                _prepare = value;
            }
        }
        
        public string availability
        {
            get
            {
                return _availability;
            }
            set
            {
                _availability = value;
            }
        }
        
        public string handlingInformation
        {
            get
            {
                return _handlingInformation;
            }
            set
            {
                _handlingInformation = value;
            }
        }
        
        public string foreignName1
        {
            get
            {
                return _foreignName1;
            }
            set
            {
                _foreignName1 = value;
            }
        }
        
        public string foreignNameComplement1
        {
            get
            {
                return _foreignNameComplement1;
            }
            set
            {
                _foreignNameComplement1 = value;
            }
        }
        
        public string foreignName2
        {
            get
            {
                return _foreignName2;
            }
            set
            {
                _foreignName2 = value;
            }
        }
        
        public string foreignNameComplement2
        {
            get
            {
                return _foreignNameComplement2;
            }
            set
            {
                _foreignNameComplement2 = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        public string description2
        {
            get
            {
                return _description2;
            }
            set
            {
                _description2 = value;
            }
        }
        
        [XmlArrayItemAttribute("picture", IsNullable=false)]
        public List<pictureType> pictures
        {
            get
            {
                return _pictures;
            }
            set
            {
                _pictures = value;
            }
        }
        
        [XmlArrayItemAttribute("idCategory", DataType="integer", IsNullable=false)]
        public List<string> categories
        {
            get
            {
                return _categories;
            }
            set
            {
                _categories = value;
            }
        }
        
        [XmlArrayItemAttribute("relatedFile", IsNullable=false)]
        public List<relatedFileType> relatedFiles
        {
            get
            {
                return _relatedFiles;
            }
            set
            {
                _relatedFiles = value;
            }
        }
        
        [XmlArrayItemAttribute("relatedLink", IsNullable=false)]
        public List<relatedLinkType> relatedLinks
        {
            get
            {
                return _relatedLinks;
            }
            set
            {
                _relatedLinks = value;
            }
        }
        
        [XmlArrayItemAttribute("idStocks", IsNullable=false)]
        public List<orderStockItemType> relatedStocks
        {
            get
            {
                return _relatedStocks;
            }
            set
            {
                _relatedStocks = value;
            }
        }
        
        [XmlArrayItemAttribute("idStocks", IsNullable=false)]
        public List<orderStockItemType> alternativeStocks
        {
            get
            {
                return _alternativeStocks;
            }
            set
            {
                _alternativeStocks = value;
            }
        }
        
        [XmlArrayItemAttribute("intParameter", IsNullable=false)]
        public List<intParameterType> intParameters
        {
            get
            {
                return _intParameters;
            }
            set
            {
                _intParameters = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public enum stockTypeType
    {
        card,
        text,
        service,
        package,
        set,
        product,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class stockHeaderTypePurchasingPrice
    {
        #region Private fields
        private bool _payVAT;
        private double _value;
        #endregion
        
        public stockHeaderTypePurchasingPrice()
        {
            _payVAT = false;
        }
        
        [XmlAttribute]
        [DefaultValue(false)]
        public bool payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [XmlTextAttribute]
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class stockHeaderTypeSellingPrice
    {
        #region Private fields
        private bool _payVAT;
        private double _value;
        #endregion
        
        public stockHeaderTypeSellingPrice()
        {
            _payVAT = false;
        }
        
        [XmlAttribute]
        [DefaultValue(false)]
        public bool payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [XmlTextAttribute]
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public enum fixationType
    {
        none,
        sellingPrice,
        margin,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public enum classOfStockType
    {
        material,
        goods,
        workInProgress,
        semiproducts,
        products,
        animals,
        materialOfOwnProduction,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="actionTypeType", Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class actionTypeType2
    {
        #region Private fields
        private requestStockType _item;
        private ItemChoiceType3 _itemElementName;
        #endregion
        
        [XmlElement("add", typeof(requestStockActionType))]
        [XmlElement("delete", typeof(requestStockType))]
        [XmlElement("update", typeof(requestStockActionType))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public requestStockType Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlIgnore]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return _itemElementName;
            }
            set
            {
                _itemElementName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        add,
        delete,
        update,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
    public partial class stockType
    {
        #region Private fields
        private actionTypeType2 _actionType;
        private stockHeaderType _stockHeader;
        private List<stockItemType1> _stockDetail;
        private List<attachItemType> _stockAttach;
        private List<serialNumberItemType> _stockSerialNumber;
        private List<stockPriceType> _stockPriceItem;
        private List<printerSettingsType> _print;
        private stkVersionType _version;
        #endregion
        
        public stockType()
        {
            _print = new List<printerSettingsType>();
            _stockPriceItem = new List<stockPriceType>();
            _stockSerialNumber = new List<serialNumberItemType>();
            _stockAttach = new List<attachItemType>();
            _stockDetail = new List<stockItemType1>();
            _stockHeader = new stockHeaderType();
            _actionType = new actionTypeType2();
        }
        
        public actionTypeType2 actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        public stockHeaderType stockHeader
        {
            get
            {
                return _stockHeader;
            }
            set
            {
                _stockHeader = value;
            }
        }
        
        [XmlArrayItemAttribute("stockItem", IsNullable=false)]
        public List<stockItemType1> stockDetail
        {
            get
            {
                return _stockDetail;
            }
            set
            {
                _stockDetail = value;
            }
        }
        
        [XmlArrayItemAttribute("attachItem", IsNullable=false)]
        public List<attachItemType> stockAttach
        {
            get
            {
                return _stockAttach;
            }
            set
            {
                _stockAttach = value;
            }
        }
        
        [XmlArrayItemAttribute("serialNumberItem", IsNullable=false)]
        public List<serialNumberItemType> stockSerialNumber
        {
            get
            {
                return _stockSerialNumber;
            }
            set
            {
                _stockSerialNumber = value;
            }
        }
        
        [XmlArrayItemAttribute("stockPrice", IsNullable=false)]
        public List<stockPriceType> stockPriceItem
        {
            get
            {
                return _stockPriceItem;
            }
            set
            {
                _stockPriceItem = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public stkVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prevodka.xsd")]
    public partial class prevodkaItemType
    {
        #region Private fields
        private linkItemType _link;
        private float _quantity;
        private stockItemType _stockItem;
        private string _note;
        private List<parameterDocType> _parameters;
        #endregion
        
        public prevodkaItemType()
        {
            _parameters = new List<parameterDocType>();
            _stockItem = new stockItemType();
            _link = new linkItemType();
        }
        
        public linkItemType link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prevodka.xsd")]
    public partial class prevodkaHeaderType
    {
        #region Private fields
        private string _id;
        private numberType1 _number;
        private System.DateTime _date;
        private System.DateTime _time;
        private string _dateOfReceipt;
        private string _timeOfReceipt;
        private string _symPar;
        private refType _store;
        private string _text;
        private address _partnerIdentity;
        private refType _centreSource;
        private refType _centreDestination;
        private refType _activity;
        private refType _contract;
        private string _note;
        private string _intNote;
        private boolean _markRecord;
        private List<parameterDocType> _parameters;
        private typeValidate _validate;
        #endregion
        
        public prevodkaHeaderType()
        {
            _validate = new typeValidate();
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centreDestination = new refType();
            _centreSource = new refType();
            _partnerIdentity = new address();
            _store = new refType();
            _number = new numberType1();
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="time")]
        public System.DateTime time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }
        
        public string dateOfReceipt
        {
            get
            {
                return _dateOfReceipt;
            }
            set
            {
                _dateOfReceipt = value;
            }
        }
        
        public string timeOfReceipt
        {
            get
            {
                return _timeOfReceipt;
            }
            set
            {
                _timeOfReceipt = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public refType store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public refType centreSource
        {
            get
            {
                return _centreSource;
            }
            set
            {
                _centreSource = value;
            }
        }
        
        public refType centreDestination
        {
            get
            {
                return _centreDestination;
            }
            set
            {
                _centreDestination = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        
        public typeValidate validate
        {
            get
            {
                return _validate;
            }
            set
            {
                _validate = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prevodka.xsd")]
    public partial class prevodkaType
    {
        #region Private fields
        private object[] _links;
        private prevodkaHeaderType _prevodkaHeader;
        private List<prevodkaItemType> _prevodkaDetail;
        private List<printerSettingsType> _print;
        private preVersionType _version;
        #endregion
        
        public prevodkaType()
        {
            _print = new List<printerSettingsType>();
            _prevodkaDetail = new List<prevodkaItemType>();
            _prevodkaHeader = new prevodkaHeaderType();
        }
        
        [XmlArrayItemAttribute("link", typeof(linkElemetType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        [XmlArrayItemAttribute("manualLink", typeof(manualLinkElementType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public object[] links
        {
            get
            {
                return _links;
            }
            set
            {
                _links = value;
            }
        }
        
        public prevodkaHeaderType prevodkaHeader
        {
            get
            {
                return _prevodkaHeader;
            }
            set
            {
                _prevodkaHeader = value;
            }
        }
        
        [XmlArrayItemAttribute("prevodkaItem", IsNullable=false)]
        public List<prevodkaItemType> prevodkaDetail
        {
            get
            {
                return _prevodkaDetail;
            }
            set
            {
                _prevodkaDetail = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public preVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prevodka.xsd")]
    public enum preVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prijemka.xsd")]
    public partial class prijemkaSummaryType
    {
        #region Private fields
        private typeRoundingDocument _roundingDocument;
        private string _roundingVAT;
        private bool _calculateVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        private typeCurrencyForeign _foreignCurrency;
        #endregion
        
        public prijemkaSummaryType()
        {
            _foreignCurrency = new typeCurrencyForeign();
            _homeCurrency = new typeCurrencyHome();
            _calculateVAT = false;
        }
        
        public typeRoundingDocument roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public string roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        [DefaultValue(false)]
        public bool calculateVAT
        {
            get
            {
                return _calculateVAT;
            }
            set
            {
                _calculateVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeign foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prijemka.xsd")]
    public partial class prijemkaAccessoryChargesItemType
    {
        #region Private fields
        private string _id;
        private float _quantity;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private typeCurrencyForeignItem _foreignCurrency;
        private string _note;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private List<parameterDocType> _parameters;
        #endregion
        
        public prijemkaAccessoryChargesItemType()
        {
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _foreignCurrency = new typeCurrencyForeignItem();
            _homeCurrency = new typeCurrencyHomeItem();
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prijemka.xsd")]
    public partial class prijemkaItemType
    {
        #region Private fields
        private string _id;
        private string _text;
        private float _quantity;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private typeCurrencyForeignItem _foreignCurrency;
        private string _note;
        private string _code;
        private stockItemType _stockItem;
        private linkToStockType _linkToStock;
        private string _acc;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private System.DateTime _expirationDate;
        private List<parameterDocType> _parameters;
        #endregion
        
        public prijemkaItemType()
        {
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _linkToStock = new linkToStockType();
            _stockItem = new stockItemType();
            _foreignCurrency = new typeCurrencyForeignItem();
            _homeCurrency = new typeCurrencyHomeItem();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public linkToStockType linkToStock
        {
            get
            {
                return _linkToStock;
            }
            set
            {
                _linkToStock = value;
            }
        }
        
        public string acc
        {
            get
            {
                return _acc;
            }
            set
            {
                _acc = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime expirationDate
        {
            get
            {
                return _expirationDate;
            }
            set
            {
                _expirationDate = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prijemka.xsd")]
    public partial class prijemkaDetailType
    {
        #region Private fields
        private List<object> _items;
        private List<string> _text;
        #endregion
        
        public prijemkaDetailType()
        {
            _text = new List<string>();
            _items = new List<object>();
        }
        
        [XmlElement("prijemkaAccessoryChargesItem", typeof(prijemkaAccessoryChargesItemType))]
        [XmlElement("prijemkaItem", typeof(prijemkaItemType))]
        [XmlElement("roundingItem", typeof(roundingItemType))]
        public List<object> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        
        [XmlTextAttribute]
        public List<string> Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prijemka.xsd")]
    public partial class prijemkaHeaderType
    {
        #region Private fields
        private string _id;
        private stornoType _storno;
        private numberType1 _number;
        private System.DateTime _date;
        private string _text;
        private address _partnerIdentity;
        private string _acc;
        private string _symPar;
        private boolean _isExecuted;
        private boolean _isDelivered;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private refTypeRegVATinEU _regVATinEU;
        private string _note;
        private string _intNote;
        private boolean _histRate;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        private typeValidate _validate;
        #endregion
        
        public prijemkaHeaderType()
        {
            _validate = new typeValidate();
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _regVATinEU = new refTypeRegVATinEU();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _partnerIdentity = new address();
            _number = new numberType1();
            _histRate = boolean.@false;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public stornoType storno
        {
            get
            {
                return _storno;
            }
            set
            {
                _storno = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public string acc
        {
            get
            {
                return _acc;
            }
            set
            {
                _acc = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public boolean isExecuted
        {
            get
            {
                return _isExecuted;
            }
            set
            {
                _isExecuted = value;
            }
        }
        
        public boolean isDelivered
        {
            get
            {
                return _isDelivered;
            }
            set
            {
                _isDelivered = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public refTypeRegVATinEU regVATinEU
        {
            get
            {
                return _regVATinEU;
            }
            set
            {
                _regVATinEU = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        
        public typeValidate validate
        {
            get
            {
                return _validate;
            }
            set
            {
                _validate = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prijemka.xsd")]
    public partial class prijemkaType
    {
        #region Private fields
        private prijemkaHeaderType _prijemkaHeader;
        private prijemkaDetailType _prijemkaDetail;
        private prijemkaSummaryType _prijemkaSummary;
        private List<printerSettingsType> _print;
        private priVersionType _version;
        #endregion
        
        public prijemkaType()
        {
            _print = new List<printerSettingsType>();
            _prijemkaSummary = new prijemkaSummaryType();
            _prijemkaDetail = new prijemkaDetailType();
            _prijemkaHeader = new prijemkaHeaderType();
        }
        
        public prijemkaHeaderType prijemkaHeader
        {
            get
            {
                return _prijemkaHeader;
            }
            set
            {
                _prijemkaHeader = value;
            }
        }
        
        public prijemkaDetailType prijemkaDetail
        {
            get
            {
                return _prijemkaDetail;
            }
            set
            {
                _prijemkaDetail = value;
            }
        }
        
        public prijemkaSummaryType prijemkaSummary
        {
            get
            {
                return _prijemkaSummary;
            }
            set
            {
                _prijemkaSummary = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public priVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public partial class eKasaType
    {
        #region Private fields
        private string _eKasaID;
        private string _eKasaOKP;
        private string _eKasaParNumber;
        private System.DateTime _eKasaDateOfPar;
        private boolean _printFM;
        #endregion
        
        public eKasaType()
        {
            _printFM = boolean.@false;
        }
        
        public string eKasaID
        {
            get
            {
                return _eKasaID;
            }
            set
            {
                _eKasaID = value;
            }
        }
        
        public string eKasaOKP
        {
            get
            {
                return _eKasaOKP;
            }
            set
            {
                _eKasaOKP = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string eKasaParNumber
        {
            get
            {
                return _eKasaParNumber;
            }
            set
            {
                _eKasaParNumber = value;
            }
        }
        
        public System.DateTime eKasaDateOfPar
        {
            get
            {
                return _eKasaDateOfPar;
            }
            set
            {
                _eKasaDateOfPar = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean printFM
        {
            get
            {
                return _printFM;
            }
            set
            {
                _printFM = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public partial class prodejkaSummaryType
    {
        #region Private fields
        private typeRoundingDocument _roundingDocument;
        private string _roundingVAT;
        private bool _calculateVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        #endregion
        
        public prodejkaSummaryType()
        {
            _homeCurrency = new typeCurrencyHome();
            _calculateVAT = false;
        }
        
        public typeRoundingDocument roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public string roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        [DefaultValue(false)]
        public bool calculateVAT
        {
            get
            {
                return _calculateVAT;
            }
            set
            {
                _calculateVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public partial class paymentAdvancedType
    {
        #region Private fields
        private object[] _items;
        private ItemsChoiceType1[] _itemsElementName;
        #endregion
        
        [XmlElement("account", typeof(accountType))]
        [XmlElement("amount", typeof(string), DataType="integer")]
        [XmlElement("paymentTerminal", typeof(boolean))]
        [XmlElement("rate", typeof(float))]
        [XmlElement("symVar", typeof(string))]
        [XmlElement("valueFoodVoucher", typeof(double))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return _itemsElementName;
            }
            set
            {
                _itemsElementName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class accountType
    {
        #region Private fields
        private string _id;
        private string _ids;
        private string _accountNo;
        private string _bankCode;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        
        public string accountNo
        {
            get
            {
                return _accountNo;
            }
            set
            {
                _accountNo = value;
            }
        }
        
        public string bankCode
        {
            get
            {
                return _bankCode;
            }
            set
            {
                _bankCode = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd", IncludeInSchema=false)]
    public enum ItemsChoiceType1
    {
        account,
        amount,
        paymentTerminal,
        rate,
        symVar,
        valueFoodVoucher,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public partial class paymentItemType
    {
        #region Private fields
        private paymentType _paymentType;
        private string _text;
        private double _received;
        private double _receivedHomeCurrency;
        private paymentAdvancedType _paymentAdvanced;
        private double _returned;
        private string _note;
        #endregion
        
        public paymentItemType()
        {
            _paymentAdvanced = new paymentAdvancedType();
            _paymentType = new paymentType();
        }
        
        public paymentType paymentType
        {
            get
            {
                return _paymentType;
            }
            set
            {
                _paymentType = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public double received
        {
            get
            {
                return _received;
            }
            set
            {
                _received = value;
            }
        }
        
        public double receivedHomeCurrency
        {
            get
            {
                return _receivedHomeCurrency;
            }
            set
            {
                _receivedHomeCurrency = value;
            }
        }
        
        public paymentAdvancedType paymentAdvanced
        {
            get
            {
                return _paymentAdvanced;
            }
            set
            {
                _paymentAdvanced = value;
            }
        }
        
        public double returned
        {
            get
            {
                return _returned;
            }
            set
            {
                _returned = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public partial class eKasaItemType
    {
        #region Private fields
        private string _refId;
        private eKasaRefundType _refundType;
        #endregion
        
        public string refId
        {
            get
            {
                return _refId;
            }
            set
            {
                _refId = value;
            }
        }
        
        public eKasaRefundType refundType
        {
            get
            {
                return _refundType;
            }
            set
            {
                _refundType = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public partial class prodejkaItemType
    {
        #region Private fields
        private linkItemType _link;
        private linkedDocumentType _linkedDocument;
        private sourceDocumentItemType _refundItem;
        private string _id;
        private string _text;
        private float _quantity;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private recyclingContribType _recyclingContrib;
        private string _note;
        private string _code;
        private string _guarantee;
        private guaranteeTypeType _guaranteeType;
        private stockItemType _stockItem;
        private refType _accounting;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private System.DateTime _expirationDate;
        private EETItemType _eETItem;
        private eKasaItemType _eKasaItem;
        private List<parameterDocType> _parameters;
        #endregion
        
        public prodejkaItemType()
        {
            _parameters = new List<parameterDocType>();
            _eKasaItem = new eKasaItemType();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _accounting = new refType();
            _stockItem = new stockItemType();
            _recyclingContrib = new recyclingContribType();
            _homeCurrency = new typeCurrencyHomeItem();
            _refundItem = new sourceDocumentItemType();
            _linkedDocument = new linkedDocumentType();
            _link = new linkItemType();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        public linkItemType link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
            }
        }
        
        public linkedDocumentType linkedDocument
        {
            get
            {
                return _linkedDocument;
            }
            set
            {
                _linkedDocument = value;
            }
        }
        
        public sourceDocumentItemType refundItem
        {
            get
            {
                return _refundItem;
            }
            set
            {
                _refundItem = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public recyclingContribType recyclingContrib
        {
            get
            {
                return _recyclingContrib;
            }
            set
            {
                _recyclingContrib = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string guarantee
        {
            get
            {
                return _guarantee;
            }
            set
            {
                _guarantee = value;
            }
        }
        
        public guaranteeTypeType guaranteeType
        {
            get
            {
                return _guaranteeType;
            }
            set
            {
                _guaranteeType = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public refType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime expirationDate
        {
            get
            {
                return _expirationDate;
            }
            set
            {
                _expirationDate = value;
            }
        }
        
        public EETItemType EETItem
        {
            get
            {
                return _eETItem;
            }
            set
            {
                _eETItem = value;
            }
        }
        
        public eKasaItemType eKasaItem
        {
            get
            {
                return _eKasaItem;
            }
            set
            {
                _eKasaItem = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public partial class prodejkaDetailType
    {
        #region Private fields
        private List<prodejkaItemType> _prodejkaItem;
        private roundingItemType _roundingItem;
        #endregion
        
        public prodejkaDetailType()
        {
            _roundingItem = new roundingItemType();
            _prodejkaItem = new List<prodejkaItemType>();
        }
        
        [XmlElement("prodejkaItem")]
        public List<prodejkaItemType> prodejkaItem
        {
            get
            {
                return _prodejkaItem;
            }
            set
            {
                _prodejkaItem = value;
            }
        }
        
        public roundingItemType roundingItem
        {
            get
            {
                return _roundingItem;
            }
            set
            {
                _roundingItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public partial class prodejkaHeaderType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private prodejkaTypeType _prodejkaType;
        private stornoType _storno;
        private numberType1 _number;
        private System.DateTime _date;
        private accountingType _accounting;
        private string _text;
        private address _partnerIdentity;
        private paymentType _paymentType;
        private refType _priceLevel;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private refType _kasa;
        private string _note;
        private string _intNote;
        private boolean _histRate;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        private typeValidate _validate;
        #endregion
        
        public prodejkaHeaderType()
        {
            _validate = new typeValidate();
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _kasa = new refType();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _priceLevel = new refType();
            _paymentType = new paymentType();
            _partnerIdentity = new address();
            _accounting = new accountingType();
            _number = new numberType1();
            _extId = new extIdType();
            _histRate = boolean.@false;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public prodejkaTypeType prodejkaType
        {
            get
            {
                return _prodejkaType;
            }
            set
            {
                _prodejkaType = value;
            }
        }
        
        public stornoType storno
        {
            get
            {
                return _storno;
            }
            set
            {
                _storno = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        public accountingType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public paymentType paymentType
        {
            get
            {
                return _paymentType;
            }
            set
            {
                _paymentType = value;
            }
        }
        
        public refType priceLevel
        {
            get
            {
                return _priceLevel;
            }
            set
            {
                _priceLevel = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public refType kasa
        {
            get
            {
                return _kasa;
            }
            set
            {
                _kasa = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        
        public typeValidate validate
        {
            get
            {
                return _validate;
            }
            set
            {
                _validate = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public enum prodejkaTypeType
    {
        saleVoucher,
        deposit,
        withdrawal,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public partial class prodejkaType
    {
        #region Private fields
        private cancelDocumentType _cancelDocument;
        private object[] _links;
        private prodejkaHeaderType _prodejkaHeader;
        private prodejkaDetailType _prodejkaDetail;
        private List<paymentItemType> _prodejkaPayments;
        private prodejkaSummaryType _prodejkaSummary;
        private object[] _linkedDocuments;
        private EETType _eET;
        private eKasaType _eKasa;
        private List<printerSettingsType> _print;
        private proVersionType _version;
        #endregion
        
        public prodejkaType()
        {
            _print = new List<printerSettingsType>();
            _eKasa = new eKasaType();
            _eET = new EETType();
            _prodejkaSummary = new prodejkaSummaryType();
            _prodejkaPayments = new List<paymentItemType>();
            _prodejkaDetail = new prodejkaDetailType();
            _prodejkaHeader = new prodejkaHeaderType();
            _cancelDocument = new cancelDocumentType();
        }
        
        public cancelDocumentType cancelDocument
        {
            get
            {
                return _cancelDocument;
            }
            set
            {
                _cancelDocument = value;
            }
        }
        
        [XmlArrayItemAttribute("link", typeof(linkElemetType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        [XmlArrayItemAttribute("manualLink", typeof(manualLinkElementType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public object[] links
        {
            get
            {
                return _links;
            }
            set
            {
                _links = value;
            }
        }
        
        public prodejkaHeaderType prodejkaHeader
        {
            get
            {
                return _prodejkaHeader;
            }
            set
            {
                _prodejkaHeader = value;
            }
        }
        
        public prodejkaDetailType prodejkaDetail
        {
            get
            {
                return _prodejkaDetail;
            }
            set
            {
                _prodejkaDetail = value;
            }
        }
        
        [XmlArrayItemAttribute("paymentItem", IsNullable=false)]
        public List<paymentItemType> prodejkaPayments
        {
            get
            {
                return _prodejkaPayments;
            }
            set
            {
                _prodejkaPayments = value;
            }
        }
        
        public prodejkaSummaryType prodejkaSummary
        {
            get
            {
                return _prodejkaSummary;
            }
            set
            {
                _prodejkaSummary = value;
            }
        }
        
        [XmlArrayItemAttribute("link", typeof(linkElemetType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        [XmlArrayItemAttribute("manualLink", typeof(manualLinkElementType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public object[] linkedDocuments
        {
            get
            {
                return _linkedDocuments;
            }
            set
            {
                _linkedDocuments = value;
            }
        }
        
        public EETType EET
        {
            get
            {
                return _eET;
            }
            set
            {
                _eET = value;
            }
        }
        
        public eKasaType eKasa
        {
            get
            {
                return _eKasa;
            }
            set
            {
                _eKasa = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public proVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
    public enum proVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/order.xsd")]
    public partial class orderSummaryType
    {
        #region Private fields
        private typeRoundingDocument _roundingDocument;
        private string _roundingVAT;
        private bool _calculateVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        private typeCurrencyForeign _foreignCurrency;
        #endregion
        
        public orderSummaryType()
        {
            _foreignCurrency = new typeCurrencyForeign();
            _homeCurrency = new typeCurrencyHome();
            _calculateVAT = false;
        }
        
        public typeRoundingDocument roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public string roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        [DefaultValue(false)]
        public bool calculateVAT
        {
            get
            {
                return _calculateVAT;
            }
            set
            {
                _calculateVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeign foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/order.xsd")]
    public partial class orderItemType
    {
        #region Private fields
        private linkItemType _link;
        private linkedDocumentType _linkedDocument;
        private string _id;
        private string _extId;
        private string _text;
        private float _quantity;
        private float _delivered;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private typeCurrencyForeignItem _foreignCurrency;
        private MOSStype _typeServiceMOSS;
        private string _note;
        private string _code;
        private stockItemType _stockItem;
        private linkToStockType _linkToStock;
        private bool _pDP;
        private string _codePDP;
        private recyclingContribType _recyclingContrib;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private EETItemType _eETItem;
        private List<parameterDocType> _parameters;
        #endregion
        
        public orderItemType()
        {
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _recyclingContrib = new recyclingContribType();
            _linkToStock = new linkToStockType();
            _stockItem = new stockItemType();
            _typeServiceMOSS = new MOSStype();
            _foreignCurrency = new typeCurrencyForeignItem();
            _homeCurrency = new typeCurrencyHomeItem();
            _linkedDocument = new linkedDocumentType();
            _link = new linkItemType();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        public linkItemType link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
            }
        }
        
        public linkedDocumentType linkedDocument
        {
            get
            {
                return _linkedDocument;
            }
            set
            {
                _linkedDocument = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public float delivered
        {
            get
            {
                return _delivered;
            }
            set
            {
                _delivered = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public linkToStockType linkToStock
        {
            get
            {
                return _linkToStock;
            }
            set
            {
                _linkToStock = value;
            }
        }
        
        public bool PDP
        {
            get
            {
                return _pDP;
            }
            set
            {
                _pDP = value;
            }
        }
        
        public string CodePDP
        {
            get
            {
                return _codePDP;
            }
            set
            {
                _codePDP = value;
            }
        }
        
        public recyclingContribType recyclingContrib
        {
            get
            {
                return _recyclingContrib;
            }
            set
            {
                _recyclingContrib = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public EETItemType EETItem
        {
            get
            {
                return _eETItem;
            }
            set
            {
                _eETItem = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/order.xsd")]
    public partial class orderDetailType
    {
        #region Private fields
        private List<orderItemType> _orderItem;
        private roundingItemType _roundingItem;
        #endregion
        
        public orderDetailType()
        {
            _roundingItem = new roundingItemType();
            _orderItem = new List<orderItemType>();
        }
        
        [XmlElement("orderItem")]
        public List<orderItemType> orderItem
        {
            get
            {
                return _orderItem;
            }
            set
            {
                _orderItem = value;
            }
        }
        
        public roundingItemType roundingItem
        {
            get
            {
                return _roundingItem;
            }
            set
            {
                _roundingItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/order.xsd")]
    public partial class orderHeaderType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private orderTypeType _orderType;
        private stornoOrderType _storno;
        private numberType1 _number;
        private string _numberOrder;
        private System.DateTime _date;
        private System.DateTime _dateDelivery;
        private System.DateTime _dateFrom;
        private System.DateTime _dateTo;
        private string _text;
        private address _partnerIdentity;
        private myAddress _myIdentity;
        private paymentType _paymentType;
        private refType _priceLevel;
        private boolean _isExecuted;
        private boolean _isDelivered;
        private boolean _isReserved;
        private refType _iShop;
        private string _iShopName;
        private System.DateTime _dateCancellation;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private refTypeRegVATinEU _regVATinEU;
        private MOSStype _mOSS;
        private List<string> _evidentiaryResourcesMOSS;
        private string _accountingPeriodMOSS;
        private boolean _permamentDocument;
        private boolean _permanentDocument;
        private string _note;
        private carrierType _carrier;
        private string _intNote;
        private boolean _histRate;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        #endregion
        
        public orderHeaderType()
        {
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _carrier = new carrierType();
            _evidentiaryResourcesMOSS = new List<string>();
            _mOSS = new MOSStype();
            _regVATinEU = new refTypeRegVATinEU();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _iShop = new refType();
            _priceLevel = new refType();
            _paymentType = new paymentType();
            _myIdentity = new myAddress();
            _partnerIdentity = new address();
            _number = new numberType1();
            _extId = new extIdType();
            _isExecuted = boolean.@false;
            _isReserved = boolean.@false;
            _permamentDocument = boolean.@false;
            _permanentDocument = boolean.@false;
            _histRate = boolean.@false;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public orderTypeType orderType
        {
            get
            {
                return _orderType;
            }
            set
            {
                _orderType = value;
            }
        }
        
        public stornoOrderType storno
        {
            get
            {
                return _storno;
            }
            set
            {
                _storno = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public string numberOrder
        {
            get
            {
                return _numberOrder;
            }
            set
            {
                _numberOrder = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateDelivery
        {
            get
            {
                return _dateDelivery;
            }
            set
            {
                _dateDelivery = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateFrom
        {
            get
            {
                return _dateFrom;
            }
            set
            {
                _dateFrom = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTo
        {
            get
            {
                return _dateTo;
            }
            set
            {
                _dateTo = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public myAddress myIdentity
        {
            get
            {
                return _myIdentity;
            }
            set
            {
                _myIdentity = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public paymentType paymentType
        {
            get
            {
                return _paymentType;
            }
            set
            {
                _paymentType = value;
            }
        }
        
        public refType priceLevel
        {
            get
            {
                return _priceLevel;
            }
            set
            {
                _priceLevel = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean isExecuted
        {
            get
            {
                return _isExecuted;
            }
            set
            {
                _isExecuted = value;
            }
        }
        
        public boolean isDelivered
        {
            get
            {
                return _isDelivered;
            }
            set
            {
                _isDelivered = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean isReserved
        {
            get
            {
                return _isReserved;
            }
            set
            {
                _isReserved = value;
            }
        }
        
        public refType iShop
        {
            get
            {
                return _iShop;
            }
            set
            {
                _iShop = value;
            }
        }
        
        public string iShopName
        {
            get
            {
                return _iShopName;
            }
            set
            {
                _iShopName = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateCancellation
        {
            get
            {
                return _dateCancellation;
            }
            set
            {
                _dateCancellation = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public refTypeRegVATinEU regVATinEU
        {
            get
            {
                return _regVATinEU;
            }
            set
            {
                _regVATinEU = value;
            }
        }
        
        public MOSStype MOSS
        {
            get
            {
                return _mOSS;
            }
            set
            {
                _mOSS = value;
            }
        }
        
        [XmlArrayItemAttribute("ids", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<string> evidentiaryResourcesMOSS
        {
            get
            {
                return _evidentiaryResourcesMOSS;
            }
            set
            {
                _evidentiaryResourcesMOSS = value;
            }
        }
        
        public string accountingPeriodMOSS
        {
            get
            {
                return _accountingPeriodMOSS;
            }
            set
            {
                _accountingPeriodMOSS = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean permamentDocument
        {
            get
            {
                return _permamentDocument;
            }
            set
            {
                _permamentDocument = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean permanentDocument
        {
            get
            {
                return _permanentDocument;
            }
            set
            {
                _permanentDocument = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public carrierType carrier
        {
            get
            {
                return _carrier;
            }
            set
            {
                _carrier = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum stornoOrderType
    {
        cancelledDocument,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class filterDocsDeleteType
    {
        #region Private fields
        private string _id;
        private string _number;
        private printAgendaType _agenda;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlAttribute]
        public printAgendaType agenda
        {
            get
            {
                return _agenda;
            }
            set
            {
                _agenda = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/filter.xsd")]
    public partial class deleteOrderType
    {
        #region Private fields
        private filterDocsDeleteType _filter;
        #endregion
        
        public deleteOrderType()
        {
            _filter = new filterDocsDeleteType();
        }
        
        public filterDocsDeleteType filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="actionTypeType", Namespace="http://www.stormware.cz/schema/version_2/order.xsd")]
    public partial class actionTypeType1
    {
        #region Private fields
        private object _item;
        #endregion
        
        [XmlElement("add", typeof(string))]
        [XmlElement("delete", typeof(deleteOrderType))]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/order.xsd")]
    public partial class orderType
    {
        #region Private fields
        private object[] _links;
        private actionTypeType1 _actionType;
        private orderHeaderType _orderHeader;
        private orderDetailType _orderDetail;
        private orderSummaryType _orderSummary;
        private object[] _linkedDocuments;
        private List<printerSettingsType> _print;
        private ordVersionType _version;
        #endregion
        
        public orderType()
        {
            _print = new List<printerSettingsType>();
            _orderSummary = new orderSummaryType();
            _orderDetail = new orderDetailType();
            _orderHeader = new orderHeaderType();
            _actionType = new actionTypeType1();
        }
        
        [XmlArrayItemAttribute("link", typeof(linkElemetType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        [XmlArrayItemAttribute("manualLink", typeof(manualLinkElementType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public object[] links
        {
            get
            {
                return _links;
            }
            set
            {
                _links = value;
            }
        }
        
        public actionTypeType1 actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        public orderHeaderType orderHeader
        {
            get
            {
                return _orderHeader;
            }
            set
            {
                _orderHeader = value;
            }
        }
        
        public orderDetailType orderDetail
        {
            get
            {
                return _orderDetail;
            }
            set
            {
                _orderDetail = value;
            }
        }
        
        public orderSummaryType orderSummary
        {
            get
            {
                return _orderSummary;
            }
            set
            {
                _orderSummary = value;
            }
        }
        
        [XmlArrayItemAttribute("link", typeof(linkElemetType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        [XmlArrayItemAttribute("manualLink", typeof(manualLinkElementType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public object[] linkedDocuments
        {
            get
            {
                return _linkedDocuments;
            }
            set
            {
                _linkedDocuments = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public ordVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/offer.xsd")]
    public partial class offerSummaryType
    {
        #region Private fields
        private typeRoundingDocument _roundingDocument;
        private string _roundingVAT;
        private bool _calculateVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        private typeCurrencyForeign _foreignCurrency;
        #endregion
        
        public offerSummaryType()
        {
            _foreignCurrency = new typeCurrencyForeign();
            _homeCurrency = new typeCurrencyHome();
            _calculateVAT = false;
        }
        
        public typeRoundingDocument roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public string roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        [DefaultValue(false)]
        public bool calculateVAT
        {
            get
            {
                return _calculateVAT;
            }
            set
            {
                _calculateVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeign foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/offer.xsd")]
    public partial class offerItemType
    {
        #region Private fields
        private string _id;
        private string _extId;
        private string _text;
        private float _quantity;
        private float _transferred;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private typeCurrencyForeignItem _foreignCurrency;
        private MOSStype _typeServiceMOSS;
        private bool _pDP;
        private string _codePDP;
        private recyclingContribType _recyclingContrib;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private string _note;
        private string _code;
        private stockItemType _stockItem;
        private EETItemType _eETItem;
        private List<parameterDocType> _parameters;
        #endregion
        
        public offerItemType()
        {
            _parameters = new List<parameterDocType>();
            _stockItem = new stockItemType();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _recyclingContrib = new recyclingContribType();
            _typeServiceMOSS = new MOSStype();
            _foreignCurrency = new typeCurrencyForeignItem();
            _homeCurrency = new typeCurrencyHomeItem();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public float transferred
        {
            get
            {
                return _transferred;
            }
            set
            {
                _transferred = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        public bool PDP
        {
            get
            {
                return _pDP;
            }
            set
            {
                _pDP = value;
            }
        }
        
        public string CodePDP
        {
            get
            {
                return _codePDP;
            }
            set
            {
                _codePDP = value;
            }
        }
        
        public recyclingContribType recyclingContrib
        {
            get
            {
                return _recyclingContrib;
            }
            set
            {
                _recyclingContrib = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public EETItemType EETItem
        {
            get
            {
                return _eETItem;
            }
            set
            {
                _eETItem = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/offer.xsd")]
    public partial class offerDetailType
    {
        #region Private fields
        private List<offerItemType> _offerItem;
        private roundingItemType _roundingItem;
        #endregion
        
        public offerDetailType()
        {
            _roundingItem = new roundingItemType();
            _offerItem = new List<offerItemType>();
        }
        
        [XmlElement("offerItem")]
        public List<offerItemType> offerItem
        {
            get
            {
                return _offerItem;
            }
            set
            {
                _offerItem = value;
            }
        }
        
        public roundingItemType roundingItem
        {
            get
            {
                return _roundingItem;
            }
            set
            {
                _roundingItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/offer.xsd")]
    public partial class offerHeaderType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private offerTypeType _offerType;
        private numberType1 _number;
        private System.DateTime _date;
        private System.DateTime _validTill;
        private string _text;
        private address _partnerIdentity;
        private myAddress _myIdentity;
        private refType _priceLevel;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private refTypeRegVATinEU _regVATinEU;
        private MOSStype _mOSS;
        private List<string> _evidentiaryResourcesMOSS;
        private string _accountingPeriodMOSS;
        private boolean _permanentDocument;
        private boolean _isExecuted;
        private boolean _isDelivered;
        private string _details;
        private string _note;
        private string _intNote;
        private boolean _histRate;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        #endregion
        
        public offerHeaderType()
        {
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _evidentiaryResourcesMOSS = new List<string>();
            _mOSS = new MOSStype();
            _regVATinEU = new refTypeRegVATinEU();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _priceLevel = new refType();
            _myIdentity = new myAddress();
            _partnerIdentity = new address();
            _number = new numberType1();
            _extId = new extIdType();
            _permanentDocument = boolean.@false;
            _histRate = boolean.@false;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public offerTypeType offerType
        {
            get
            {
                return _offerType;
            }
            set
            {
                _offerType = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime validTill
        {
            get
            {
                return _validTill;
            }
            set
            {
                _validTill = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public myAddress myIdentity
        {
            get
            {
                return _myIdentity;
            }
            set
            {
                _myIdentity = value;
            }
        }
        
        public refType priceLevel
        {
            get
            {
                return _priceLevel;
            }
            set
            {
                _priceLevel = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public refTypeRegVATinEU regVATinEU
        {
            get
            {
                return _regVATinEU;
            }
            set
            {
                _regVATinEU = value;
            }
        }
        
        public MOSStype MOSS
        {
            get
            {
                return _mOSS;
            }
            set
            {
                _mOSS = value;
            }
        }
        
        [XmlArrayItemAttribute("ids", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<string> evidentiaryResourcesMOSS
        {
            get
            {
                return _evidentiaryResourcesMOSS;
            }
            set
            {
                _evidentiaryResourcesMOSS = value;
            }
        }
        
        public string accountingPeriodMOSS
        {
            get
            {
                return _accountingPeriodMOSS;
            }
            set
            {
                _accountingPeriodMOSS = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean permanentDocument
        {
            get
            {
                return _permanentDocument;
            }
            set
            {
                _permanentDocument = value;
            }
        }
        
        public boolean isExecuted
        {
            get
            {
                return _isExecuted;
            }
            set
            {
                _isExecuted = value;
            }
        }
        
        public boolean isDelivered
        {
            get
            {
                return _isDelivered;
            }
            set
            {
                _isDelivered = value;
            }
        }
        
        public string details
        {
            get
            {
                return _details;
            }
            set
            {
                _details = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/offer.xsd")]
    public partial class offerType
    {
        #region Private fields
        private offerHeaderType _offerHeader;
        private offerDetailType _offerDetail;
        private offerSummaryType _offerSummary;
        private List<printerSettingsType> _print;
        private ofrVersionType _version;
        #endregion
        
        public offerType()
        {
            _print = new List<printerSettingsType>();
            _offerSummary = new offerSummaryType();
            _offerDetail = new offerDetailType();
            _offerHeader = new offerHeaderType();
        }
        
        public offerHeaderType offerHeader
        {
            get
            {
                return _offerHeader;
            }
            set
            {
                _offerHeader = value;
            }
        }
        
        public offerDetailType offerDetail
        {
            get
            {
                return _offerDetail;
            }
            set
            {
                _offerDetail = value;
            }
        }
        
        public offerSummaryType offerSummary
        {
            get
            {
                return _offerSummary;
            }
            set
            {
                _offerSummary = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public ofrVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class invoiceSummaryType
    {
        #region Private fields
        private typeRoundingDocument _roundingDocument;
        private string _roundingVAT;
        private bool _calculateVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        private typeCurrencyForeign _foreignCurrency;
        #endregion
        
        public invoiceSummaryType()
        {
            _foreignCurrency = new typeCurrencyForeign();
            _homeCurrency = new typeCurrencyHome();
            _calculateVAT = false;
        }
        
        public typeRoundingDocument roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public string roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        [DefaultValue(false)]
        public bool calculateVAT
        {
            get
            {
                return _calculateVAT;
            }
            set
            {
                _calculateVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeign foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class typeCurrencyForeignItem2
    {
        #region Private fields
        private double _unitPrice;
        private double _price;
        private double _priceVAT;
        private double _priceSum;
        private float _rateExcRateDiff;
        private string _amountExcRateDiff;
        #endregion
        
        public double unitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }
        
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        
        public double priceVAT
        {
            get
            {
                return _priceVAT;
            }
            set
            {
                _priceVAT = value;
            }
        }
        
        public double priceSum
        {
            get
            {
                return _priceSum;
            }
            set
            {
                _priceSum = value;
            }
        }
        
        public float rateExcRateDiff
        {
            get
            {
                return _rateExcRateDiff;
            }
            set
            {
                _rateExcRateDiff = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string amountExcRateDiff
        {
            get
            {
                return _amountExcRateDiff;
            }
            set
            {
                _amountExcRateDiff = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class invoiceAdvancePaymentItemType
    {
        #region Private fields
        private string _id;
        private string _extId;
        private sourceDocumentType _sourceDocument;
        private float _quantity;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem2 _homeCurrency;
        private typeCurrencyForeignItem2 _foreignCurrency;
        private MOSStype _typeServiceMOSS;
        private string _note;
        private string _symPar;
        private refType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private boolean _voucherEET;
        private List<parameterDocType> _parameters;
        #endregion
        
        public invoiceAdvancePaymentItemType()
        {
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new refType();
            _typeServiceMOSS = new MOSStype();
            _foreignCurrency = new typeCurrencyForeignItem2();
            _homeCurrency = new typeCurrencyHomeItem2();
            _sourceDocument = new sourceDocumentType();
            _discountPercentage = ((float)(0F));
            _voucherEET = boolean.@false;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public sourceDocumentType sourceDocument
        {
            get
            {
                return _sourceDocument;
            }
            set
            {
                _sourceDocument = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem2 homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem2 foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public refType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean voucherEET
        {
            get
            {
                return _voucherEET;
            }
            set
            {
                _voucherEET = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class intrastatItemType
    {
        #region Private fields
        private System.DateTime _date;
        private string _goodsCode;
        private string _description;
        private string _countryOfDestination;
        private string _countryOfDispatch;
        private string _countryOfOrigin;
        private string _region;
        private double _invoicedAmount;
        private double _transportExpenses;
        private float _ownWeight;
        private float _quantity;
        private string _addUnit;
        private string _transaction;
        private string _termsOfDelivery;
        private string _modeOfTransport;
        private string _statisticalCode;
        private string _specialTransaction;
        private string _vATIdOfPartner;
        #endregion
        
        public intrastatItemType()
        {
            _ownWeight = ((float)(0F));
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        public string goodsCode
        {
            get
            {
                return _goodsCode;
            }
            set
            {
                _goodsCode = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        public string countryOfDestination
        {
            get
            {
                return _countryOfDestination;
            }
            set
            {
                _countryOfDestination = value;
            }
        }
        
        public string countryOfDispatch
        {
            get
            {
                return _countryOfDispatch;
            }
            set
            {
                _countryOfDispatch = value;
            }
        }
        
        public string countryOfOrigin
        {
            get
            {
                return _countryOfOrigin;
            }
            set
            {
                _countryOfOrigin = value;
            }
        }
        
        public string region
        {
            get
            {
                return _region;
            }
            set
            {
                _region = value;
            }
        }
        
        public double invoicedAmount
        {
            get
            {
                return _invoicedAmount;
            }
            set
            {
                _invoicedAmount = value;
            }
        }
        
        public double transportExpenses
        {
            get
            {
                return _transportExpenses;
            }
            set
            {
                _transportExpenses = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float ownWeight
        {
            get
            {
                return _ownWeight;
            }
            set
            {
                _ownWeight = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string addUnit
        {
            get
            {
                return _addUnit;
            }
            set
            {
                _addUnit = value;
            }
        }
        
        public string transaction
        {
            get
            {
                return _transaction;
            }
            set
            {
                _transaction = value;
            }
        }
        
        public string termsOfDelivery
        {
            get
            {
                return _termsOfDelivery;
            }
            set
            {
                _termsOfDelivery = value;
            }
        }
        
        public string modeOfTransport
        {
            get
            {
                return _modeOfTransport;
            }
            set
            {
                _modeOfTransport = value;
            }
        }
        
        public string statisticalCode
        {
            get
            {
                return _statisticalCode;
            }
            set
            {
                _statisticalCode = value;
            }
        }
        
        public string specialTransaction
        {
            get
            {
                return _specialTransaction;
            }
            set
            {
                _specialTransaction = value;
            }
        }
        
        public string VATIdOfPartner
        {
            get
            {
                return _vATIdOfPartner;
            }
            set
            {
                _vATIdOfPartner = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class invoiceItemType
    {
        #region Private fields
        private linkItemType _link;
        private linkedDocumentType _linkedDocument;
        private string _id;
        private string _extId;
        private string _text;
        private float _quantity;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private typeCurrencyForeignItem _foreignCurrency;
        private MOSStype _typeServiceMOSS;
        private string _note;
        private string _code;
        private string _guarantee;
        private guaranteeTypeType _guaranteeType;
        private stockItemType _stockItem;
        private linkToStockType _linkToStock;
        private refType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private bool _pDP;
        private string _codePDP;
        private recyclingContribType _recyclingContrib;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private string _expirationDate;
        private intrastatItemType _intrastatItem;
        private EETItemType _eETItem;
        private List<parameterDocType> _parameters;
        #endregion
        
        public invoiceItemType()
        {
            _parameters = new List<parameterDocType>();
            _intrastatItem = new intrastatItemType();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _recyclingContrib = new recyclingContribType();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new refType();
            _linkToStock = new linkToStockType();
            _stockItem = new stockItemType();
            _typeServiceMOSS = new MOSStype();
            _foreignCurrency = new typeCurrencyForeignItem();
            _homeCurrency = new typeCurrencyHomeItem();
            _linkedDocument = new linkedDocumentType();
            _link = new linkItemType();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        public linkItemType link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
            }
        }
        
        public linkedDocumentType linkedDocument
        {
            get
            {
                return _linkedDocument;
            }
            set
            {
                _linkedDocument = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string guarantee
        {
            get
            {
                return _guarantee;
            }
            set
            {
                _guarantee = value;
            }
        }
        
        public guaranteeTypeType guaranteeType
        {
            get
            {
                return _guaranteeType;
            }
            set
            {
                _guaranteeType = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public linkToStockType linkToStock
        {
            get
            {
                return _linkToStock;
            }
            set
            {
                _linkToStock = value;
            }
        }
        
        public refType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public bool PDP
        {
            get
            {
                return _pDP;
            }
            set
            {
                _pDP = value;
            }
        }
        
        public string CodePDP
        {
            get
            {
                return _codePDP;
            }
            set
            {
                _codePDP = value;
            }
        }
        
        public recyclingContribType recyclingContrib
        {
            get
            {
                return _recyclingContrib;
            }
            set
            {
                _recyclingContrib = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public string expirationDate
        {
            get
            {
                return _expirationDate;
            }
            set
            {
                _expirationDate = value;
            }
        }
        
        public intrastatItemType intrastatItem
        {
            get
            {
                return _intrastatItem;
            }
            set
            {
                _intrastatItem = value;
            }
        }
        
        public EETItemType EETItem
        {
            get
            {
                return _eETItem;
            }
            set
            {
                _eETItem = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class invoiceDetailType
    {
        #region Private fields
        private List<object> _items;
        private List<string> _text;
        #endregion
        
        public invoiceDetailType()
        {
            _text = new List<string>();
            _items = new List<object>();
        }
        
        [XmlElement("invoiceAdvancePaymentItem", typeof(invoiceAdvancePaymentItemType))]
        [XmlElement("invoiceItem", typeof(invoiceItemType))]
        [XmlElement("roundingItem", typeof(roundingItemType))]
        public List<object> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        
        [XmlTextAttribute]
        public List<string> Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class invoiceRetentionType
    {
        #region Private fields
        private System.DateTime _date;
        private System.DateTime _dateDue;
        private double _homeCurrency;
        private liquidationType _liquidation;
        private string _text;
        private refType _accounting;
        #endregion
        
        public invoiceRetentionType()
        {
            _accounting = new refType();
            _liquidation = new liquidationType();
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateDue
        {
            get
            {
                return _dateDue;
            }
            set
            {
                _dateDue = value;
            }
        }
        
        public double homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public liquidationType liquidation
        {
            get
            {
                return _liquidation;
            }
            set
            {
                _liquidation = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public refType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class liquidationType
    {
        #region Private fields
        private System.DateTime _date;
        private double _amountHome;
        private double _amountForeign;
        #endregion
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        public double amountHome
        {
            get
            {
                return _amountHome;
            }
            set
            {
                _amountHome = value;
            }
        }
        
        public double amountForeign
        {
            get
            {
                return _amountForeign;
            }
            set
            {
                _amountForeign = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class intrastatType
    {
        #region Private fields
        private string _countryOfDestination;
        private string _countryOfDispatch;
        private string _countryOfOrigin;
        private string _region;
        private string _transaction;
        private string _specialTransaction;
        private string _termsOfDelivery;
        private string _modeOfTransport;
        private double _shippingCosts;
        private string _vATIdOfPartner;
        #endregion
        
        public string countryOfDestination
        {
            get
            {
                return _countryOfDestination;
            }
            set
            {
                _countryOfDestination = value;
            }
        }
        
        public string countryOfDispatch
        {
            get
            {
                return _countryOfDispatch;
            }
            set
            {
                _countryOfDispatch = value;
            }
        }
        
        public string countryOfOrigin
        {
            get
            {
                return _countryOfOrigin;
            }
            set
            {
                _countryOfOrigin = value;
            }
        }
        
        public string region
        {
            get
            {
                return _region;
            }
            set
            {
                _region = value;
            }
        }
        
        public string transaction
        {
            get
            {
                return _transaction;
            }
            set
            {
                _transaction = value;
            }
        }
        
        public string specialTransaction
        {
            get
            {
                return _specialTransaction;
            }
            set
            {
                _specialTransaction = value;
            }
        }
        
        public string termsOfDelivery
        {
            get
            {
                return _termsOfDelivery;
            }
            set
            {
                _termsOfDelivery = value;
            }
        }
        
        public string modeOfTransport
        {
            get
            {
                return _modeOfTransport;
            }
            set
            {
                _modeOfTransport = value;
            }
        }
        
        public double shippingCosts
        {
            get
            {
                return _shippingCosts;
            }
            set
            {
                _shippingCosts = value;
            }
        }
        
        public string VATIdOfPartner
        {
            get
            {
                return _vATIdOfPartner;
            }
            set
            {
                _vATIdOfPartner = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class invoiceHeaderType
    {
        #region Private fields
        private string _id;
        private extIdType _extId;
        private invoiceTypeType _invoiceType;
        private stornoType _storno;
        private sphereTypeType _sphereType;
        private numberType1 _number;
        private string _symVar;
        private string _originalDocument;
        private string _originalDocumentNumber;
        private string _symPar;
        private System.DateTime _date;
        private System.DateTime _dateTax;
        private System.DateTime _dateAccounting;
        private System.DateTime _dateKHDPH;
        private System.DateTime _dateDue;
        private System.DateTime _dateApplicationVAT;
        private System.DateTime _dateDelivery;
        private accountingType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private string _numberKHDPH;
        private string _numberKVDPH;
        private string _text;
        private address _partnerIdentity;
        private myAddress _myIdentity;
        private refType _order;
        private string _numberOrder;
        private string _dateOrder;
        private refType _priceLevel;
        private paymentType _paymentType;
        private accountType _account;
        private string _symConst;
        private string _symSpec;
        private invoiceHeaderTypePaymentAccount _paymentAccount;
        private string _messageForRecipient;
        private System.DateTime _dateOfPaymentOrder;
        private boolean _paymentTerminal;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private refTypeRegVATinEU _regVATinEU;
        private MOSStype _mOSS;
        private List<string> _evidentiaryResourcesMOSS;
        private string _accountingPeriodMOSS;
        private System.DateTime _dateTaxOriginalDocumentMOSS;
        private boolean _correctionMOSS;
        private carrierType _carrier;
        private string _note;
        private string _intNote;
        private liquidationType _liquidation;
        private double _applied;
        private boolean _histRate;
        private boolean _markRecord;
        private List<labelType> _labels;
        private intrastatType _intrastat;
        private List<parameterDocType> _parameters;
        private typeValidate _validate;
        private boolean _postponedIssue;
        #endregion
        
        public invoiceHeaderType()
        {
            _validate = new typeValidate();
            _parameters = new List<parameterDocType>();
            _intrastat = new intrastatType();
            _labels = new List<labelType>();
            _liquidation = new liquidationType();
            _carrier = new carrierType();
            _evidentiaryResourcesMOSS = new List<string>();
            _mOSS = new MOSStype();
            _regVATinEU = new refTypeRegVATinEU();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _paymentAccount = new invoiceHeaderTypePaymentAccount();
            _account = new accountType();
            _paymentType = new paymentType();
            _priceLevel = new refType();
            _order = new refType();
            _myIdentity = new myAddress();
            _partnerIdentity = new address();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new accountingType();
            _number = new numberType1();
            _extId = new extIdType();
            _sphereType = sphereTypeType.business;
            _paymentTerminal = boolean.@false;
            _correctionMOSS = boolean.@false;
            _histRate = boolean.@false;
            _markRecord = boolean.@true;
            _postponedIssue = boolean.@false;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public invoiceTypeType invoiceType
        {
            get
            {
                return _invoiceType;
            }
            set
            {
                _invoiceType = value;
            }
        }
        
        public stornoType storno
        {
            get
            {
                return _storno;
            }
            set
            {
                _storno = value;
            }
        }
        
        [DefaultValue(sphereTypeType.business)]
        public sphereTypeType sphereType
        {
            get
            {
                return _sphereType;
            }
            set
            {
                _sphereType = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public string symVar
        {
            get
            {
                return _symVar;
            }
            set
            {
                _symVar = value;
            }
        }
        
        public string originalDocument
        {
            get
            {
                return _originalDocument;
            }
            set
            {
                _originalDocument = value;
            }
        }
        
        public string originalDocumentNumber
        {
            get
            {
                return _originalDocumentNumber;
            }
            set
            {
                _originalDocumentNumber = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTax
        {
            get
            {
                return _dateTax;
            }
            set
            {
                _dateTax = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateAccounting
        {
            get
            {
                return _dateAccounting;
            }
            set
            {
                _dateAccounting = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateKHDPH
        {
            get
            {
                return _dateKHDPH;
            }
            set
            {
                _dateKHDPH = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateDue
        {
            get
            {
                return _dateDue;
            }
            set
            {
                _dateDue = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateApplicationVAT
        {
            get
            {
                return _dateApplicationVAT;
            }
            set
            {
                _dateApplicationVAT = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateDelivery
        {
            get
            {
                return _dateDelivery;
            }
            set
            {
                _dateDelivery = value;
            }
        }
        
        public accountingType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public string numberKHDPH
        {
            get
            {
                return _numberKHDPH;
            }
            set
            {
                _numberKHDPH = value;
            }
        }
        
        public string numberKVDPH
        {
            get
            {
                return _numberKVDPH;
            }
            set
            {
                _numberKVDPH = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public myAddress myIdentity
        {
            get
            {
                return _myIdentity;
            }
            set
            {
                _myIdentity = value;
            }
        }
        
        public refType order
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
            }
        }
        
        public string numberOrder
        {
            get
            {
                return _numberOrder;
            }
            set
            {
                _numberOrder = value;
            }
        }
        
        public string dateOrder
        {
            get
            {
                return _dateOrder;
            }
            set
            {
                _dateOrder = value;
            }
        }
        
        public refType priceLevel
        {
            get
            {
                return _priceLevel;
            }
            set
            {
                _priceLevel = value;
            }
        }
        
        public paymentType paymentType
        {
            get
            {
                return _paymentType;
            }
            set
            {
                _paymentType = value;
            }
        }
        
        public accountType account
        {
            get
            {
                return _account;
            }
            set
            {
                _account = value;
            }
        }
        
        public string symConst
        {
            get
            {
                return _symConst;
            }
            set
            {
                _symConst = value;
            }
        }
        
        public string symSpec
        {
            get
            {
                return _symSpec;
            }
            set
            {
                _symSpec = value;
            }
        }
        
        public invoiceHeaderTypePaymentAccount paymentAccount
        {
            get
            {
                return _paymentAccount;
            }
            set
            {
                _paymentAccount = value;
            }
        }
        
        public string messageForRecipient
        {
            get
            {
                return _messageForRecipient;
            }
            set
            {
                _messageForRecipient = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateOfPaymentOrder
        {
            get
            {
                return _dateOfPaymentOrder;
            }
            set
            {
                _dateOfPaymentOrder = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean paymentTerminal
        {
            get
            {
                return _paymentTerminal;
            }
            set
            {
                _paymentTerminal = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public refTypeRegVATinEU regVATinEU
        {
            get
            {
                return _regVATinEU;
            }
            set
            {
                _regVATinEU = value;
            }
        }
        
        public MOSStype MOSS
        {
            get
            {
                return _mOSS;
            }
            set
            {
                _mOSS = value;
            }
        }
        
        [XmlArrayItemAttribute("ids", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<string> evidentiaryResourcesMOSS
        {
            get
            {
                return _evidentiaryResourcesMOSS;
            }
            set
            {
                _evidentiaryResourcesMOSS = value;
            }
        }
        
        public string accountingPeriodMOSS
        {
            get
            {
                return _accountingPeriodMOSS;
            }
            set
            {
                _accountingPeriodMOSS = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTaxOriginalDocumentMOSS
        {
            get
            {
                return _dateTaxOriginalDocumentMOSS;
            }
            set
            {
                _dateTaxOriginalDocumentMOSS = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean correctionMOSS
        {
            get
            {
                return _correctionMOSS;
            }
            set
            {
                _correctionMOSS = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public carrierType carrier
        {
            get
            {
                return _carrier;
            }
            set
            {
                _carrier = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        public liquidationType liquidation
        {
            get
            {
                return _liquidation;
            }
            set
            {
                _liquidation = value;
            }
        }
        
        public double applied
        {
            get
            {
                return _applied;
            }
            set
            {
                _applied = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        public intrastatType intrastat
        {
            get
            {
                return _intrastat;
            }
            set
            {
                _intrastat = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        
        public typeValidate validate
        {
            get
            {
                return _validate;
            }
            set
            {
                _validate = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean postponedIssue
        {
            get
            {
                return _postponedIssue;
            }
            set
            {
                _postponedIssue = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public enum sphereTypeType
    {
        business,
        loan,
        specificRegulations,
        other,
        cheques,
        exchangeRateDifference,
        penalty,
        labourLaw,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class invoiceHeaderTypePaymentAccount
    {
        #region Private fields
        private string _accountNo;
        private string _bankCode;
        #endregion
        
        public string accountNo
        {
            get
            {
                return _accountNo;
            }
            set
            {
                _accountNo = value;
            }
        }
        
        public string bankCode
        {
            get
            {
                return _bankCode;
            }
            set
            {
                _bankCode = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class correctiveDocumentType
    {
        #region Private fields
        private sourceDocumentType _sourceDocument;
        #endregion
        
        public correctiveDocumentType()
        {
            _sourceDocument = new sourceDocumentType();
        }
        
        public sourceDocumentType sourceDocument
        {
            get
            {
                return _sourceDocument;
            }
            set
            {
                _sourceDocument = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
    public partial class invoiceType
    {
        #region Private fields
        private object[] _links;
        private cancelDocumentType _cancelDocument;
        private correctiveDocumentType _correctiveDocument;
        private invoiceHeaderType _invoiceHeader;
        private List<invoiceRetentionType> _invoiceRetentions;
        private invoiceDetailType _invoiceDetail;
        private invoiceSummaryType _invoiceSummary;
        private object[] _linkedDocuments;
        private EETType _eET;
        private List<printerSettingsType> _print;
        private invVersionType _version;
        #endregion
        
        public invoiceType()
        {
            _print = new List<printerSettingsType>();
            _eET = new EETType();
            _invoiceSummary = new invoiceSummaryType();
            _invoiceDetail = new invoiceDetailType();
            _invoiceRetentions = new List<invoiceRetentionType>();
            _invoiceHeader = new invoiceHeaderType();
            _correctiveDocument = new correctiveDocumentType();
            _cancelDocument = new cancelDocumentType();
        }
        
        [XmlArrayItemAttribute("link", typeof(linkElemetType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        [XmlArrayItemAttribute("manualLink", typeof(manualLinkElementType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public object[] links
        {
            get
            {
                return _links;
            }
            set
            {
                _links = value;
            }
        }
        
        public cancelDocumentType cancelDocument
        {
            get
            {
                return _cancelDocument;
            }
            set
            {
                _cancelDocument = value;
            }
        }
        
        public correctiveDocumentType correctiveDocument
        {
            get
            {
                return _correctiveDocument;
            }
            set
            {
                _correctiveDocument = value;
            }
        }
        
        public invoiceHeaderType invoiceHeader
        {
            get
            {
                return _invoiceHeader;
            }
            set
            {
                _invoiceHeader = value;
            }
        }
        
        [XmlArrayItemAttribute("invoiceRetention", IsNullable=false)]
        public List<invoiceRetentionType> invoiceRetentions
        {
            get
            {
                return _invoiceRetentions;
            }
            set
            {
                _invoiceRetentions = value;
            }
        }
        
        public invoiceDetailType invoiceDetail
        {
            get
            {
                return _invoiceDetail;
            }
            set
            {
                _invoiceDetail = value;
            }
        }
        
        public invoiceSummaryType invoiceSummary
        {
            get
            {
                return _invoiceSummary;
            }
            set
            {
                _invoiceSummary = value;
            }
        }
        
        [XmlArrayItemAttribute("link", typeof(linkElemetType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        [XmlArrayItemAttribute("manualLink", typeof(manualLinkElementType), Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public object[] linkedDocuments
        {
            get
            {
                return _linkedDocuments;
            }
            set
            {
                _linkedDocuments = value;
            }
        }
        
        public EETType EET
        {
            get
            {
                return _eET;
            }
            set
            {
                _eET = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public invVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intDoc.xsd")]
    public partial class intDocSummaryType
    {
        #region Private fields
        private typeRoundingDocument _roundingDocument;
        private string _roundingVAT;
        private bool _calculateVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        private typeCurrencyForeign _foreignCurrency;
        #endregion
        
        public intDocSummaryType()
        {
            _foreignCurrency = new typeCurrencyForeign();
            _homeCurrency = new typeCurrencyHome();
            _calculateVAT = false;
        }
        
        public typeRoundingDocument roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public string roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        [DefaultValue(false)]
        public bool calculateVAT
        {
            get
            {
                return _calculateVAT;
            }
            set
            {
                _calculateVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeign foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intDoc.xsd")]
    public partial class intDocItemType
    {
        #region Private fields
        private string _text;
        private float _quantity;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private typeCurrencyForeignItem _foreignCurrency;
        private MOSStype _typeServiceMOSS;
        private string _note;
        private string _code;
        private string _symPar;
        private refType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private bool _pDP;
        private string _codePDP;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private List<parameterDocType> _parameters;
        #endregion
        
        public intDocItemType()
        {
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new refType();
            _typeServiceMOSS = new MOSStype();
            _foreignCurrency = new typeCurrencyForeignItem();
            _homeCurrency = new typeCurrencyHomeItem();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public refType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public bool PDP
        {
            get
            {
                return _pDP;
            }
            set
            {
                _pDP = value;
            }
        }
        
        public string CodePDP
        {
            get
            {
                return _codePDP;
            }
            set
            {
                _codePDP = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intDoc.xsd")]
    public partial class intDocDetailType
    {
        #region Private fields
        private List<intDocItemType> _intDocItem;
        private roundingItemType _roundingItem;
        #endregion
        
        public intDocDetailType()
        {
            _roundingItem = new roundingItemType();
            _intDocItem = new List<intDocItemType>();
        }
        
        [XmlElement("intDocItem")]
        public List<intDocItemType> intDocItem
        {
            get
            {
                return _intDocItem;
            }
            set
            {
                _intDocItem = value;
            }
        }
        
        public roundingItemType roundingItem
        {
            get
            {
                return _roundingItem;
            }
            set
            {
                _roundingItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intDoc.xsd")]
    public partial class intDocHeaderType
    {
        #region Private fields
        private string _id;
        private stornoType _storno;
        private numberType1 _number;
        private string _symVar;
        private string _symPar;
        private string _originalDocumentNumber;
        private string _originalCorrectiveDocument;
        private System.DateTime _date;
        private System.DateTime _dateTax;
        private System.DateTime _dateAccounting;
        private System.DateTime _dateDelivery;
        private System.DateTime _dateKVDPH;
        private System.DateTime _dateKHDPH;
        private accountingType _accounting;
        private classificationVATType _classificationVAT;
        private refType _classificationKVDPH;
        private string _numberKHDPH;
        private string _text;
        private address _partnerIdentity;
        private myAddress _myIdentity;
        private boolean _liquidation;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private refTypeRegVATinEU _regVATinEU;
        private MOSStype _mOSS;
        private List<string> _evidentiaryResourcesMOSS;
        private string _accountingPeriodMOSS;
        private string _note;
        private string _intNote;
        private boolean _histRate;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        #endregion
        
        public intDocHeaderType()
        {
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _evidentiaryResourcesMOSS = new List<string>();
            _mOSS = new MOSStype();
            _regVATinEU = new refTypeRegVATinEU();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _myIdentity = new myAddress();
            _partnerIdentity = new address();
            _classificationKVDPH = new refType();
            _classificationVAT = new classificationVATType();
            _accounting = new accountingType();
            _number = new numberType1();
            _liquidation = boolean.@false;
            _histRate = boolean.@false;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public stornoType storno
        {
            get
            {
                return _storno;
            }
            set
            {
                _storno = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public string symVar
        {
            get
            {
                return _symVar;
            }
            set
            {
                _symVar = value;
            }
        }
        
        public string symPar
        {
            get
            {
                return _symPar;
            }
            set
            {
                _symPar = value;
            }
        }
        
        public string originalDocumentNumber
        {
            get
            {
                return _originalDocumentNumber;
            }
            set
            {
                _originalDocumentNumber = value;
            }
        }
        
        public string originalCorrectiveDocument
        {
            get
            {
                return _originalCorrectiveDocument;
            }
            set
            {
                _originalCorrectiveDocument = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTax
        {
            get
            {
                return _dateTax;
            }
            set
            {
                _dateTax = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateAccounting
        {
            get
            {
                return _dateAccounting;
            }
            set
            {
                _dateAccounting = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateDelivery
        {
            get
            {
                return _dateDelivery;
            }
            set
            {
                _dateDelivery = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateKVDPH
        {
            get
            {
                return _dateKVDPH;
            }
            set
            {
                _dateKVDPH = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateKHDPH
        {
            get
            {
                return _dateKHDPH;
            }
            set
            {
                _dateKHDPH = value;
            }
        }
        
        public accountingType accounting
        {
            get
            {
                return _accounting;
            }
            set
            {
                _accounting = value;
            }
        }
        
        public classificationVATType classificationVAT
        {
            get
            {
                return _classificationVAT;
            }
            set
            {
                _classificationVAT = value;
            }
        }
        
        public refType classificationKVDPH
        {
            get
            {
                return _classificationKVDPH;
            }
            set
            {
                _classificationKVDPH = value;
            }
        }
        
        public string numberKHDPH
        {
            get
            {
                return _numberKHDPH;
            }
            set
            {
                _numberKHDPH = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public myAddress myIdentity
        {
            get
            {
                return _myIdentity;
            }
            set
            {
                _myIdentity = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean liquidation
        {
            get
            {
                return _liquidation;
            }
            set
            {
                _liquidation = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public refTypeRegVATinEU regVATinEU
        {
            get
            {
                return _regVATinEU;
            }
            set
            {
                _regVATinEU = value;
            }
        }
        
        public MOSStype MOSS
        {
            get
            {
                return _mOSS;
            }
            set
            {
                _mOSS = value;
            }
        }
        
        [XmlArrayItemAttribute("ids", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<string> evidentiaryResourcesMOSS
        {
            get
            {
                return _evidentiaryResourcesMOSS;
            }
            set
            {
                _evidentiaryResourcesMOSS = value;
            }
        }
        
        public string accountingPeriodMOSS
        {
            get
            {
                return _accountingPeriodMOSS;
            }
            set
            {
                _accountingPeriodMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intDoc.xsd")]
    public partial class intDocType
    {
        #region Private fields
        private intDocHeaderType _intDocHeader;
        private intDocDetailType _intDocDetail;
        private intDocSummaryType _intDocSummary;
        private List<printerSettingsType> _print;
        private intVersionType _version;
        #endregion
        
        public intDocType()
        {
            _print = new List<printerSettingsType>();
            _intDocSummary = new intDocSummaryType();
            _intDocDetail = new intDocDetailType();
            _intDocHeader = new intDocHeaderType();
        }
        
        public intDocHeaderType intDocHeader
        {
            get
            {
                return _intDocHeader;
            }
            set
            {
                _intDocHeader = value;
            }
        }
        
        public intDocDetailType intDocDetail
        {
            get
            {
                return _intDocDetail;
            }
            set
            {
                _intDocDetail = value;
            }
        }
        
        public intDocSummaryType intDocSummary
        {
            get
            {
                return _intDocSummary;
            }
            set
            {
                _intDocSummary = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public intVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/intDoc.xsd")]
    public enum intVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/enquiry.xsd")]
    public partial class enquirySummaryType
    {
        #region Private fields
        private typeRoundingDocument _roundingDocument;
        private string _roundingVAT;
        private bool _calculateVAT;
        private typeCalculateVATInclusivePriceType _typeCalculateVATInclusivePrice;
        private typeCurrencyHome _homeCurrency;
        private typeCurrencyForeign _foreignCurrency;
        #endregion
        
        public enquirySummaryType()
        {
            _foreignCurrency = new typeCurrencyForeign();
            _homeCurrency = new typeCurrencyHome();
            _calculateVAT = false;
        }
        
        public typeRoundingDocument roundingDocument
        {
            get
            {
                return _roundingDocument;
            }
            set
            {
                _roundingDocument = value;
            }
        }
        
        public string roundingVAT
        {
            get
            {
                return _roundingVAT;
            }
            set
            {
                _roundingVAT = value;
            }
        }
        
        [DefaultValue(false)]
        public bool calculateVAT
        {
            get
            {
                return _calculateVAT;
            }
            set
            {
                _calculateVAT = value;
            }
        }
        
        public typeCalculateVATInclusivePriceType typeCalculateVATInclusivePrice
        {
            get
            {
                return _typeCalculateVATInclusivePrice;
            }
            set
            {
                _typeCalculateVATInclusivePrice = value;
            }
        }
        
        public typeCurrencyHome homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeign foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/enquiry.xsd")]
    public partial class enquiryItemType
    {
        #region Private fields
        private string _id;
        private string _text;
        private float _quantity;
        private string _unit;
        private float _coefficient;
        private boolean _payVAT;
        private vatRateType _rateVAT;
        private float _percentVAT;
        private float _discountPercentage;
        private typeCurrencyHomeItem _homeCurrency;
        private typeCurrencyForeignItem _foreignCurrency;
        private bool _pDP;
        private string _codePDP;
        private recyclingContribType _recyclingContrib;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private MOSStype _typeServiceMOSS;
        private string _note;
        private string _code;
        private stockItemType _stockItem;
        private EETItemType _eETItem;
        private List<parameterDocType> _parameters;
        #endregion
        
        public enquiryItemType()
        {
            _parameters = new List<parameterDocType>();
            _stockItem = new stockItemType();
            _typeServiceMOSS = new MOSStype();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _recyclingContrib = new recyclingContribType();
            _foreignCurrency = new typeCurrencyForeignItem();
            _homeCurrency = new typeCurrencyHomeItem();
            _coefficient = ((float)(1F));
            _payVAT = boolean.@false;
            _rateVAT = vatRateType.none;
            _discountPercentage = ((float)(0F));
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public float quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public string unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [DefaultValue(typeof(float), "1")]
        public float coefficient
        {
            get
            {
                return _coefficient;
            }
            set
            {
                _coefficient = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean payVAT
        {
            get
            {
                return _payVAT;
            }
            set
            {
                _payVAT = value;
            }
        }
        
        [DefaultValue(vatRateType.none)]
        public vatRateType rateVAT
        {
            get
            {
                return _rateVAT;
            }
            set
            {
                _rateVAT = value;
            }
        }
        
        public float percentVAT
        {
            get
            {
                return _percentVAT;
            }
            set
            {
                _percentVAT = value;
            }
        }
        
        [DefaultValue(typeof(float), "0")]
        public float discountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                _discountPercentage = value;
            }
        }
        
        public typeCurrencyHomeItem homeCurrency
        {
            get
            {
                return _homeCurrency;
            }
            set
            {
                _homeCurrency = value;
            }
        }
        
        public typeCurrencyForeignItem foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public bool PDP
        {
            get
            {
                return _pDP;
            }
            set
            {
                _pDP = value;
            }
        }
        
        public string CodePDP
        {
            get
            {
                return _codePDP;
            }
            set
            {
                _codePDP = value;
            }
        }
        
        public recyclingContribType recyclingContrib
        {
            get
            {
                return _recyclingContrib;
            }
            set
            {
                _recyclingContrib = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public MOSStype typeServiceMOSS
        {
            get
            {
                return _typeServiceMOSS;
            }
            set
            {
                _typeServiceMOSS = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public stockItemType stockItem
        {
            get
            {
                return _stockItem;
            }
            set
            {
                _stockItem = value;
            }
        }
        
        public EETItemType EETItem
        {
            get
            {
                return _eETItem;
            }
            set
            {
                _eETItem = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/enquiry.xsd")]
    public partial class enquiryDetailType
    {
        #region Private fields
        private List<enquiryItemType> _enquiryItem;
        private roundingItemType _roundingItem;
        #endregion
        
        public enquiryDetailType()
        {
            _roundingItem = new roundingItemType();
            _enquiryItem = new List<enquiryItemType>();
        }
        
        [XmlElement("enquiryItem")]
        public List<enquiryItemType> enquiryItem
        {
            get
            {
                return _enquiryItem;
            }
            set
            {
                _enquiryItem = value;
            }
        }
        
        public roundingItemType roundingItem
        {
            get
            {
                return _roundingItem;
            }
            set
            {
                _roundingItem = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/enquiry.xsd")]
    public partial class enquiryHeaderType
    {
        #region Private fields
        private string _id;
        private enquiryTypeType _enquiryType;
        private numberType1 _number;
        private System.DateTime _date;
        private System.DateTime _validTill;
        private string _text;
        private address _partnerIdentity;
        private myAddress _myIdentity;
        private refType _priceLevel;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private refTypeRegVATinEU _regVATinEU;
        private MOSStype _mOSS;
        private List<string> _evidentiaryResourcesMOSS;
        private boolean _isExecuted;
        private string _details;
        private string _note;
        private string _intNote;
        private boolean _histRate;
        private boolean _markRecord;
        private List<labelType> _labels;
        private List<parameterDocType> _parameters;
        #endregion
        
        public enquiryHeaderType()
        {
            _parameters = new List<parameterDocType>();
            _labels = new List<labelType>();
            _evidentiaryResourcesMOSS = new List<string>();
            _mOSS = new MOSStype();
            _regVATinEU = new refTypeRegVATinEU();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _priceLevel = new refType();
            _myIdentity = new myAddress();
            _partnerIdentity = new address();
            _number = new numberType1();
            _histRate = boolean.@false;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public enquiryTypeType enquiryType
        {
            get
            {
                return _enquiryType;
            }
            set
            {
                _enquiryType = value;
            }
        }
        
        public numberType1 number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime validTill
        {
            get
            {
                return _validTill;
            }
            set
            {
                _validTill = value;
            }
        }
        
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public address partnerIdentity
        {
            get
            {
                return _partnerIdentity;
            }
            set
            {
                _partnerIdentity = value;
            }
        }
        
        public myAddress myIdentity
        {
            get
            {
                return _myIdentity;
            }
            set
            {
                _myIdentity = value;
            }
        }
        
        public refType priceLevel
        {
            get
            {
                return _priceLevel;
            }
            set
            {
                _priceLevel = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        public refTypeRegVATinEU regVATinEU
        {
            get
            {
                return _regVATinEU;
            }
            set
            {
                _regVATinEU = value;
            }
        }
        
        public MOSStype MOSS
        {
            get
            {
                return _mOSS;
            }
            set
            {
                _mOSS = value;
            }
        }
        
        [XmlArrayItemAttribute("ids", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<string> evidentiaryResourcesMOSS
        {
            get
            {
                return _evidentiaryResourcesMOSS;
            }
            set
            {
                _evidentiaryResourcesMOSS = value;
            }
        }
        
        public boolean isExecuted
        {
            get
            {
                return _isExecuted;
            }
            set
            {
                _isExecuted = value;
            }
        }
        
        public string details
        {
            get
            {
                return _details;
            }
            set
            {
                _details = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean histRate
        {
            get
            {
                return _histRate;
            }
            set
            {
                _histRate = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/enquiry.xsd")]
    public partial class enquiryType
    {
        #region Private fields
        private enquiryHeaderType _enquiryHeader;
        private enquiryDetailType _enquiryDetail;
        private enquirySummaryType _enquirySummary;
        private List<printerSettingsType> _print;
        private enqVersionType _version;
        #endregion
        
        public enquiryType()
        {
            _print = new List<printerSettingsType>();
            _enquirySummary = new enquirySummaryType();
            _enquiryDetail = new enquiryDetailType();
            _enquiryHeader = new enquiryHeaderType();
        }
        
        public enquiryHeaderType enquiryHeader
        {
            get
            {
                return _enquiryHeader;
            }
            set
            {
                _enquiryHeader = value;
            }
        }
        
        public enquiryDetailType enquiryDetail
        {
            get
            {
                return _enquiryDetail;
            }
            set
            {
                _enquiryDetail = value;
            }
        }
        
        public enquirySummaryType enquirySummary
        {
            get
            {
                return _enquirySummary;
            }
            set
            {
                _enquirySummary = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public enqVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/addressbook.xsd")]
    public partial class GDPRItemType
    {
        #region Private fields
        private actionTypeItem _actionType;
        private string _id;
        private refTypeLong _name;
        private string _description;
        private System.DateTime _dateFrom;
        private System.DateTime _dateTill;
        private System.DateTime _revokeGDPR;
        private string _note;
        #endregion
        
        public GDPRItemType()
        {
            _name = new refTypeLong();
            _actionType = new actionTypeItem();
        }
        
        public actionTypeItem actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public refTypeLong name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateFrom
        {
            get
            {
                return _dateFrom;
            }
            set
            {
                _dateFrom = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateTill
        {
            get
            {
                return _dateTill;
            }
            set
            {
                _dateTill = value;
            }
        }
        
        public System.DateTime revokeGDPR
        {
            get
            {
                return _revokeGDPR;
            }
            set
            {
                _revokeGDPR = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/addressbook.xsd")]
    public partial class addressbookGDPRType
    {
        #region Private fields
        private boolean _restrictProcessing;
        private System.DateTime _dateSale;
        private System.DateTime _datePreSale;
        private System.DateTime _dateAfterSale;
        private List<GDPRItemType> _gDPRItems;
        #endregion
        
        public addressbookGDPRType()
        {
            _gDPRItems = new List<GDPRItemType>();
            _restrictProcessing = boolean.@false;
        }
        
        [DefaultValue(boolean.@false)]
        public boolean restrictProcessing
        {
            get
            {
                return _restrictProcessing;
            }
            set
            {
                _restrictProcessing = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateSale
        {
            get
            {
                return _dateSale;
            }
            set
            {
                _dateSale = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime datePreSale
        {
            get
            {
                return _datePreSale;
            }
            set
            {
                _datePreSale = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateAfterSale
        {
            get
            {
                return _dateAfterSale;
            }
            set
            {
                _dateAfterSale = value;
            }
        }
        
        [XmlArrayItemAttribute("GDPRItem", IsNullable=false)]
        public List<GDPRItemType> GDPRItems
        {
            get
            {
                return _gDPRItems;
            }
            set
            {
                _gDPRItems = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/addressbook.xsd")]
    public partial class accountItemType
    {
        #region Private fields
        private actionTypeItem _actionType;
        private string _id;
        private string _accountNumber;
        private string _symSpec;
        private string _bankCode;
        private boolean _defaultAccount;
        #endregion
        
        public accountItemType()
        {
            _actionType = new actionTypeItem();
            _defaultAccount = boolean.@false;
        }
        
        public actionTypeItem actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string accountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }
        
        public string symSpec
        {
            get
            {
                return _symSpec;
            }
            set
            {
                _symSpec = value;
            }
        }
        
        public string bankCode
        {
            get
            {
                return _bankCode;
            }
            set
            {
                _bankCode = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean defaultAccount
        {
            get
            {
                return _defaultAccount;
            }
            set
            {
                _defaultAccount = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class refAddressType
    {
        #region Private fields
        private string _refAD;
        private extIdType _extId;
        private addressType _address;
        #endregion
        
        public refAddressType()
        {
            _address = new addressType();
            _extId = new extIdType();
        }
        
        [XmlElement(DataType="integer")]
        public string refAD
        {
            get
            {
                return _refAD;
            }
            set
            {
                _refAD = value;
            }
        }
        
        public extIdType extId
        {
            get
            {
                return _extId;
            }
            set
            {
                _extId = value;
            }
        }
        
        public addressType address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public partial class responsiblePersonType
    {
        #region Private fields
        private string _id;
        private string _surname;
        private string _name;
        private string _degree;
        #endregion
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string degree
        {
            get
            {
                return _degree;
            }
            set
            {
                _degree = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/addressbook.xsd")]
    public partial class addressbookHeaderType
    {
        #region Private fields
        private string _id;
        private address _identity;
        private string _region;
        private string _phone;
        private string _mobil;
        private string _fax;
        private string _email;
        private string _web;
        private string _iCQ;
        private string _skype;
        private string _gPS;
        private string _adGroup;
        private string _adKey;
        private double _credit;
        private string _priceIDS;
        private short _maturity;
        private paymentType _paymentType;
        private string _agreement;
        private numberADType _number;
        private string _ost1;
        private string _ost2;
        private string _function;
        private string _personalIdentificationNumber;
        private string _salutation;
        private sexType _sex;
        private System.DateTime _dateOfBirth;
        private boolean _p1;
        private boolean _p2;
        private boolean _p3;
        private boolean _p4;
        private boolean _p5;
        private boolean _p6;
        private string _message;
        private string _note;
        private string _intNote;
        private accountingType _accountingReceivedInvoice;
        private accountingType _accountingIssuedInvoice;
        private classificationVATType _classificationVATReceivedInvoice;
        private classificationVATType _classificationVATIssuedInvoice;
        private refType _classificationKVDPHReceivedInvoice;
        private refType _classificationKVDPHIssuedInvoice;
        private accountType _accountForInvoicing;
        private responsiblePersonType _responsiblePerson;
        private short _toleranceMaturity;
        private refType _foreignCurrency;
        private refType _centre;
        private refType _activity;
        private refType _contract;
        private double _turnover;
        private double _turnover2;
        private List<parameterDocType> _parameters;
        private refAddressType _refAddress;
        private boolean _markRecord;
        private List<labelType> _labels;
        #endregion
        
        public addressbookHeaderType()
        {
            _labels = new List<labelType>();
            _refAddress = new refAddressType();
            _parameters = new List<parameterDocType>();
            _contract = new refType();
            _activity = new refType();
            _centre = new refType();
            _foreignCurrency = new refType();
            _responsiblePerson = new responsiblePersonType();
            _accountForInvoicing = new accountType();
            _classificationKVDPHIssuedInvoice = new refType();
            _classificationKVDPHReceivedInvoice = new refType();
            _classificationVATIssuedInvoice = new classificationVATType();
            _classificationVATReceivedInvoice = new classificationVATType();
            _accountingIssuedInvoice = new accountingType();
            _accountingReceivedInvoice = new accountingType();
            _number = new numberADType();
            _paymentType = new paymentType();
            _identity = new address();
            _credit = 0D;
            _maturity = ((short)(0));
            _p1 = boolean.@false;
            _p2 = boolean.@false;
            _p3 = boolean.@false;
            _p4 = boolean.@false;
            _p5 = boolean.@false;
            _p6 = boolean.@false;
            _toleranceMaturity = ((short)(0));
            _turnover = 0D;
            _turnover2 = 0D;
            _markRecord = boolean.@true;
        }
        
        [XmlElement(DataType="integer")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public address identity
        {
            get
            {
                return _identity;
            }
            set
            {
                _identity = value;
            }
        }
        
        public string region
        {
            get
            {
                return _region;
            }
            set
            {
                _region = value;
            }
        }
        
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        
        public string mobil
        {
            get
            {
                return _mobil;
            }
            set
            {
                _mobil = value;
            }
        }
        
        public string fax
        {
            get
            {
                return _fax;
            }
            set
            {
                _fax = value;
            }
        }
        
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        
        public string web
        {
            get
            {
                return _web;
            }
            set
            {
                _web = value;
            }
        }
        
        public string ICQ
        {
            get
            {
                return _iCQ;
            }
            set
            {
                _iCQ = value;
            }
        }
        
        public string Skype
        {
            get
            {
                return _skype;
            }
            set
            {
                _skype = value;
            }
        }
        
        public string GPS
        {
            get
            {
                return _gPS;
            }
            set
            {
                _gPS = value;
            }
        }
        
        public string adGroup
        {
            get
            {
                return _adGroup;
            }
            set
            {
                _adGroup = value;
            }
        }
        
        public string adKey
        {
            get
            {
                return _adKey;
            }
            set
            {
                _adKey = value;
            }
        }
        
        [DefaultValue(0D)]
        public double credit
        {
            get
            {
                return _credit;
            }
            set
            {
                _credit = value;
            }
        }
        
        public string priceIDS
        {
            get
            {
                return _priceIDS;
            }
            set
            {
                _priceIDS = value;
            }
        }
        
        [DefaultValue(typeof(short), "0")]
        public short maturity
        {
            get
            {
                return _maturity;
            }
            set
            {
                _maturity = value;
            }
        }
        
        [XmlElement(IsNullable=true)]
        public paymentType paymentType
        {
            get
            {
                return _paymentType;
            }
            set
            {
                _paymentType = value;
            }
        }
        
        public string agreement
        {
            get
            {
                return _agreement;
            }
            set
            {
                _agreement = value;
            }
        }
        
        public numberADType number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        
        public string ost1
        {
            get
            {
                return _ost1;
            }
            set
            {
                _ost1 = value;
            }
        }
        
        public string ost2
        {
            get
            {
                return _ost2;
            }
            set
            {
                _ost2 = value;
            }
        }
        
        public string function
        {
            get
            {
                return _function;
            }
            set
            {
                _function = value;
            }
        }
        
        public string personalIdentificationNumber
        {
            get
            {
                return _personalIdentificationNumber;
            }
            set
            {
                _personalIdentificationNumber = value;
            }
        }
        
        public string salutation
        {
            get
            {
                return _salutation;
            }
            set
            {
                _salutation = value;
            }
        }
        
        public sexType sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }
        
        [XmlElement(DataType="date")]
        public System.DateTime dateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean p1
        {
            get
            {
                return _p1;
            }
            set
            {
                _p1 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean p2
        {
            get
            {
                return _p2;
            }
            set
            {
                _p2 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean p3
        {
            get
            {
                return _p3;
            }
            set
            {
                _p3 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean p4
        {
            get
            {
                return _p4;
            }
            set
            {
                _p4 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean p5
        {
            get
            {
                return _p5;
            }
            set
            {
                _p5 = value;
            }
        }
        
        [DefaultValue(boolean.@false)]
        public boolean p6
        {
            get
            {
                return _p6;
            }
            set
            {
                _p6 = value;
            }
        }
        
        public string message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }
        
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        public string intNote
        {
            get
            {
                return _intNote;
            }
            set
            {
                _intNote = value;
            }
        }
        
        public accountingType accountingReceivedInvoice
        {
            get
            {
                return _accountingReceivedInvoice;
            }
            set
            {
                _accountingReceivedInvoice = value;
            }
        }
        
        public accountingType accountingIssuedInvoice
        {
            get
            {
                return _accountingIssuedInvoice;
            }
            set
            {
                _accountingIssuedInvoice = value;
            }
        }
        
        public classificationVATType classificationVATReceivedInvoice
        {
            get
            {
                return _classificationVATReceivedInvoice;
            }
            set
            {
                _classificationVATReceivedInvoice = value;
            }
        }
        
        public classificationVATType classificationVATIssuedInvoice
        {
            get
            {
                return _classificationVATIssuedInvoice;
            }
            set
            {
                _classificationVATIssuedInvoice = value;
            }
        }
        
        public refType classificationKVDPHReceivedInvoice
        {
            get
            {
                return _classificationKVDPHReceivedInvoice;
            }
            set
            {
                _classificationKVDPHReceivedInvoice = value;
            }
        }
        
        public refType classificationKVDPHIssuedInvoice
        {
            get
            {
                return _classificationKVDPHIssuedInvoice;
            }
            set
            {
                _classificationKVDPHIssuedInvoice = value;
            }
        }
        
        public accountType accountForInvoicing
        {
            get
            {
                return _accountForInvoicing;
            }
            set
            {
                _accountForInvoicing = value;
            }
        }
        
        public responsiblePersonType responsiblePerson
        {
            get
            {
                return _responsiblePerson;
            }
            set
            {
                _responsiblePerson = value;
            }
        }
        
        [DefaultValue(typeof(short), "0")]
        public short toleranceMaturity
        {
            get
            {
                return _toleranceMaturity;
            }
            set
            {
                _toleranceMaturity = value;
            }
        }
        
        public refType foreignCurrency
        {
            get
            {
                return _foreignCurrency;
            }
            set
            {
                _foreignCurrency = value;
            }
        }
        
        public refType centre
        {
            get
            {
                return _centre;
            }
            set
            {
                _centre = value;
            }
        }
        
        public refType activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }
        
        public refType contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        [DefaultValue(0D)]
        public double turnover
        {
            get
            {
                return _turnover;
            }
            set
            {
                _turnover = value;
            }
        }
        
        [DefaultValue(0D)]
        public double turnover2
        {
            get
            {
                return _turnover2;
            }
            set
            {
                _turnover2 = value;
            }
        }
        
        [XmlArrayItemAttribute("parameter", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<parameterDocType> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        
        public refAddressType refAddress
        {
            get
            {
                return _refAddress;
            }
            set
            {
                _refAddress = value;
            }
        }
        
        [DefaultValue(boolean.@true)]
        public boolean markRecord
        {
            get
            {
                return _markRecord;
            }
            set
            {
                _markRecord = value;
            }
        }
        
        [XmlArrayItemAttribute("label", Namespace="http://www.stormware.cz/schema/version_2/type.xsd", IsNullable=false)]
        public List<labelType> labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/type.xsd")]
    public enum sexType
    {
        man,
        woman,
        unknown,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/addressbook.xsd")]
    public partial class actionTypeType
    {
        #region Private fields
        private requestAddressBookType _item;
        private ItemChoiceType _itemElementName;
        #endregion
        
        [XmlElement("add", typeof(requestAddressBookActionType))]
        [XmlElement("delete", typeof(requestAddressBookType))]
        [XmlElement("update", typeof(requestAddressBookActionType))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public requestAddressBookType Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlIgnore]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return _itemElementName;
            }
            set
            {
                _itemElementName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/addressbook.xsd", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        add,
        delete,
        update,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/addressbook.xsd")]
    public partial class addressbookType
    {
        #region Private fields
        private actionTypeType _actionType;
        private addressbookHeaderType _addressbookHeader;
        private List<accountItemType> _addressbookAccount;
        private addressbookGDPRType _addressbookGDPR;
        private List<printerSettingsType> _print;
        private adbVersionType _version;
        #endregion
        
        public addressbookType()
        {
            _print = new List<printerSettingsType>();
            _addressbookGDPR = new addressbookGDPRType();
            _addressbookAccount = new List<accountItemType>();
            _addressbookHeader = new addressbookHeaderType();
            _actionType = new actionTypeType();
        }
        
        public actionTypeType actionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        }
        
        public addressbookHeaderType addressbookHeader
        {
            get
            {
                return _addressbookHeader;
            }
            set
            {
                _addressbookHeader = value;
            }
        }
        
        [XmlArrayItemAttribute("accountItem", IsNullable=false)]
        public List<accountItemType> addressbookAccount
        {
            get
            {
                return _addressbookAccount;
            }
            set
            {
                _addressbookAccount = value;
            }
        }
        
        public addressbookGDPRType addressbookGDPR
        {
            get
            {
                return _addressbookGDPR;
            }
            set
            {
                _addressbookGDPR = value;
            }
        }
        
        [XmlArrayItemAttribute("printerSettings", Namespace="http://www.stormware.cz/schema/version_2/print.xsd", IsNullable=false)]
        public List<printerSettingsType> print
        {
            get
            {
                return _print;
            }
            set
            {
                _print = value;
            }
        }
        
        [XmlAttribute]
        public adbVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/data.xsd")]
    public partial class dataPackItemType
    {
        #region Private fields
        private object _item;
        private ItemChoiceType6 _itemElementName;
        private dataPackItemVersionType _version;
        private string _id;
        #endregion
        
        [XmlElement("GDPR", typeof(GDPRType), Namespace="http://www.stormware.cz/schema/version_2/GDPR.xsd")]
        [XmlElement("accountingSalesVouchers", typeof(accountingSalesVouchersType), Namespace="http://www.stormware.cz/schema/version_2/accountingSalesVouchers.xsd")]
        [XmlElement("listAccountingUnitRequest", typeof(listRequestType), Namespace="http://www.stormware.cz/schema/version_2/accountingunit.xsd")]
        [XmlElement("addressbook", typeof(addressbookType), Namespace="http://www.stormware.cz/schema/version_2/addressbook.xsd")]
        [XmlElement("bank", typeof(bankType), Namespace="http://www.stormware.cz/schema/version_2/bank.xsd")]
        [XmlElement("bankAccount", typeof(bankAccountType), Namespace="http://www.stormware.cz/schema/version_2/bankAccount.xsd")]
        [XmlElement("categoryDetail", typeof(categoryDetailType), Namespace="http://www.stormware.cz/schema/version_2/category.xsd")]
        [XmlElement("contract", typeof(contractType), Namespace="http://www.stormware.cz/schema/version_2/contract.xsd")]
        [XmlElement("enquiry", typeof(enquiryType), Namespace="http://www.stormware.cz/schema/version_2/enquiry.xsd")]
        [XmlElement("groupStocks", typeof(groupStocksType), Namespace="http://www.stormware.cz/schema/version_2/groupStocks.xsd")]
        [XmlElement("intDoc", typeof(intDocType), Namespace="http://www.stormware.cz/schema/version_2/intDoc.xsd")]
        [XmlElement("intParamDetail", typeof(intParamDetailType), Namespace="http://www.stormware.cz/schema/version_2/intParam.xsd")]
        [XmlElement("inventoryLists", typeof(inventoryListsType), Namespace="http://www.stormware.cz/schema/version_2/inventoryLists.xsd")]
        [XmlElement("invoice", typeof(invoiceType), Namespace="http://www.stormware.cz/schema/version_2/invoice.xsd")]
        [XmlElement("isdoc", typeof(isdocType1), Namespace="http://www.stormware.cz/schema/version_2/isdoc.xsd")]
        [XmlElement("createAccountingDoubleEntry", typeof(createAccountingDoubleEntryType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listAccountRequest", typeof(listRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listAccountancyRequest", typeof(listAccountancyRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listAccountingDoubleEntryRequest", typeof(listRequestAgendasType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listAccountingSingleEntryRequest", typeof(listRequestAgendasType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listActionPriceRequest", typeof(listActionPriceRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listActivityRequest", typeof(listRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listBalanceRequest", typeof(listBalanceRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listBankAccountRequest", typeof(listBankAccountRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listBankRequest", typeof(listBankRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listCashRegisterRequest", typeof(listCashRegisterRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listCashRequest", typeof(listRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listCategoryRequest", typeof(listCategoryRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listCentreRequest", typeof(listRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listClassificationVATRequest", typeof(listClassificationVATRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listEnquiryRequest", typeof(listEnquiryRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listEstablishmentRequest", typeof(listEstablishmentRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listGDPRRequest", typeof(listGDPRRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listGlobalSettingsRequest", typeof(listGlobalSettingsRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listGroupStocksRequest", typeof(listGroupStocksRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listIndividualPriceRequest", typeof(listIndividualPriceRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listIntParamRequest", typeof(listIntParamRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listInvoiceRequest", typeof(listInvoiceRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listMovementRequest", typeof(listMovementRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listNumericSeriesRequest", typeof(listRequestAgendasType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listNumericalSeriesRequest", typeof(listNumericalSeriesRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listOfferRequest", typeof(listOfferRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listOrderRequest", typeof(listOrderRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listParameterRequest", typeof(listParameterRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listPaymentRequest", typeof(listPaymentRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listPrijemkaRequest", typeof(listPrijemkaRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listProductRequirementRequest", typeof(listProductRequirementRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listRecyclingContribRequest", typeof(listRecyclingContribRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listRegistrationNumberRequest", typeof(listRegistrationNumberRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listSellingPriceRequest", typeof(listRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listServiceRequest", typeof(listServiceRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listStorageRequest", typeof(listRequestStoresType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listStoreRequest", typeof(listStoreRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listUserCode", typeof(listUserCodeType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listUserCodeRequest", typeof(listUserCodeRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listVydejkaRequest", typeof(listVydejkaRequestType), Namespace="http://www.stormware.cz/schema/version_2/list.xsd")]
        [XmlElement("listActivityRequest", typeof(listRequestActivityType), Namespace="http://www.stormware.cz/schema/version_2/list_activity.xsd")]
        [XmlElement("listAddressBookRequest", typeof(listAddressBookRequestType), Namespace="http://www.stormware.cz/schema/version_2/list_addBook.xsd")]
        [XmlElement("listCentreRequest", typeof(listRequestCentreType), Namespace="http://www.stormware.cz/schema/version_2/list_centre.xsd")]
        [XmlElement("listContractRequest", typeof(listRequestContractType), Namespace="http://www.stormware.cz/schema/version_2/list_contract.xsd")]
        [XmlElement("listStockRequest", typeof(listRequestStockType), Namespace="http://www.stormware.cz/schema/version_2/list_stock.xsd")]
        [XmlElement("mKasaRequest", typeof(mKasaRequestType), Namespace="http://www.stormware.cz/schema/version_2/mKasa.xsd")]
        [XmlElement("numericalSeries", typeof(numericalSeriesType), Namespace="http://www.stormware.cz/schema/version_2/numericalSeries.xsd")]
        [XmlElement("offer", typeof(offerType), Namespace="http://www.stormware.cz/schema/version_2/offer.xsd")]
        [XmlElement("order", typeof(orderType), Namespace="http://www.stormware.cz/schema/version_2/order.xsd")]
        [XmlElement("parameter", typeof(parameterType), Namespace="http://www.stormware.cz/schema/version_2/parameter.xsd")]
        [XmlElement("prevodka", typeof(prevodkaType), Namespace="http://www.stormware.cz/schema/version_2/prevodka.xsd")]
        [XmlElement("prijemka", typeof(prijemkaType), Namespace="http://www.stormware.cz/schema/version_2/prijemka.xsd")]
        [XmlElement("print", typeof(printType), Namespace="http://www.stormware.cz/schema/version_2/print.xsd")]
        [XmlElement("prodejka", typeof(prodejkaType), Namespace="http://www.stormware.cz/schema/version_2/prodejka.xsd")]
        [XmlElement("productRequirement", typeof(productRequirementType), Namespace="http://www.stormware.cz/schema/version_2/productRequirement.xsd")]
        [XmlElement("sendEET", typeof(sendEETType), Namespace="http://www.stormware.cz/schema/version_2/sendEET.xsd")]
        [XmlElement("stock", typeof(stockType), Namespace="http://www.stormware.cz/schema/version_2/stock.xsd")]
        [XmlElement("storage", typeof(storageType), Namespace="http://www.stormware.cz/schema/version_2/storage.xsd")]
        [XmlElement("store", typeof(storeType), Namespace="http://www.stormware.cz/schema/version_2/store.xsd")]
        [XmlElement("voucher", typeof(voucherType), Namespace="http://www.stormware.cz/schema/version_2/voucher.xsd")]
        [XmlElement("vydejka", typeof(vydejkaType), Namespace="http://www.stormware.cz/schema/version_2/vydejka.xsd")]
        [XmlElement("vyroba", typeof(vyrobaType), Namespace="http://www.stormware.cz/schema/version_2/vyroba.xsd")]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlIgnore]
        public ItemChoiceType6 ItemElementName
        {
            get
            {
                return _itemElementName;
            }
            set
            {
                _itemElementName = value;
            }
        }
        
        [XmlAttribute]
        public dataPackItemVersionType version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/data.xsd", IncludeInSchema=false)]
    public enum ItemChoiceType6
    {
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/GDPR.xsd:GDPR")]
        GDPR,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/accountingSalesVouchers.xsd:accountingSa" +
            "lesVouchers")]
        accountingSalesVouchers,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/accountingunit.xsd:listAccountingUnitReq" +
            "uest")]
        listAccountingUnitRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/addressbook.xsd:addressbook")]
        addressbook,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/bank.xsd:bank")]
        bank,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/bankAccount.xsd:bankAccount")]
        bankAccount,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/category.xsd:categoryDetail")]
        categoryDetail,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/contract.xsd:contract")]
        contract,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/enquiry.xsd:enquiry")]
        enquiry,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/groupStocks.xsd:groupStocks")]
        groupStocks,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/intDoc.xsd:intDoc")]
        intDoc,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/intParam.xsd:intParamDetail")]
        intParamDetail,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/inventoryLists.xsd:inventoryLists")]
        inventoryLists,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/invoice.xsd:invoice")]
        invoice,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/isdoc.xsd:isdoc")]
        isdoc,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:createAccountingDoubleEntry")]
        createAccountingDoubleEntry,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listAccountRequest")]
        listAccountRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listAccountancyRequest")]
        listAccountancyRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listAccountingDoubleEntryReques" +
            "t")]
        listAccountingDoubleEntryRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listAccountingSingleEntryReques" +
            "t")]
        listAccountingSingleEntryRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listActionPriceRequest")]
        listActionPriceRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listActivityRequest")]
        listActivityRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listBalanceRequest")]
        listBalanceRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listBankAccountRequest")]
        listBankAccountRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listBankRequest")]
        listBankRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listCashRegisterRequest")]
        listCashRegisterRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listCashRequest")]
        listCashRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listCategoryRequest")]
        listCategoryRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listCentreRequest")]
        listCentreRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listClassificationVATRequest")]
        listClassificationVATRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listEnquiryRequest")]
        listEnquiryRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listEstablishmentRequest")]
        listEstablishmentRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listGDPRRequest")]
        listGDPRRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listGlobalSettingsRequest")]
        listGlobalSettingsRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listGroupStocksRequest")]
        listGroupStocksRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listIndividualPriceRequest")]
        listIndividualPriceRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listIntParamRequest")]
        listIntParamRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listInvoiceRequest")]
        listInvoiceRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listMovementRequest")]
        listMovementRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listNumericSeriesRequest")]
        listNumericSeriesRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listNumericalSeriesRequest")]
        listNumericalSeriesRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listOfferRequest")]
        listOfferRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listOrderRequest")]
        listOrderRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listParameterRequest")]
        listParameterRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listPaymentRequest")]
        listPaymentRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listPrijemkaRequest")]
        listPrijemkaRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listProductRequirementRequest")]
        listProductRequirementRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listRecyclingContribRequest")]
        listRecyclingContribRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listRegistrationNumberRequest")]
        listRegistrationNumberRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listSellingPriceRequest")]
        listSellingPriceRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listServiceRequest")]
        listServiceRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listStorageRequest")]
        listStorageRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listStoreRequest")]
        listStoreRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listUserCode")]
        listUserCode,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listUserCodeRequest")]
        listUserCodeRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list.xsd:listVydejkaRequest")]
        listVydejkaRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list_activity.xsd:listActivityRequest")]
        listActivityRequest1,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list_addBook.xsd:listAddressBookRequest")]
        listAddressBookRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list_centre.xsd:listCentreRequest")]
        listCentreRequest1,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list_contract.xsd:listContractRequest")]
        listContractRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/list_stock.xsd:listStockRequest")]
        listStockRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/mKasa.xsd:mKasaRequest")]
        mKasaRequest,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/numericalSeries.xsd:numericalSeries")]
        numericalSeries,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/offer.xsd:offer")]
        offer,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/order.xsd:order")]
        order,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/parameter.xsd:parameter")]
        parameter,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/prevodka.xsd:prevodka")]
        prevodka,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/prijemka.xsd:prijemka")]
        prijemka,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/print.xsd:print")]
        print,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/prodejka.xsd:prodejka")]
        prodejka,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/productRequirement.xsd:productRequiremen" +
            "t")]
        productRequirement,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/sendEET.xsd:sendEET")]
        sendEET,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/stock.xsd:stock")]
        stock,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/storage.xsd:storage")]
        storage,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/store.xsd:store")]
        store,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/voucher.xsd:voucher")]
        voucher,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/vydejka.xsd:vydejka")]
        vydejka,
        [XmlEnumAttribute("http://www.stormware.cz/schema/version_2/vyroba.xsd:vyroba")]
        vyroba,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/data.xsd")]
    public enum dataPackItemVersionType
    {
        [XmlEnumAttribute("1.0")]
        Item10,
        [XmlEnumAttribute("2.0")]
        Item20,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace="http://www.stormware.cz/schema/version_2/data.xsd")]
    public enum dataPackVersionType
    {
        [XmlEnumAttribute("2.0")]
        Item20,
    }
}
#pragma warning restore
