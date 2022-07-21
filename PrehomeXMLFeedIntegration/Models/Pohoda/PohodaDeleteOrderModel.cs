using System.ComponentModel;
using System.Xml.Serialization;

namespace PrehomeXMLFeedIntegration.Models.Pohoda
{
    public class PohodaDeleteOrderModel
    {

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/data.xsd")]
        [XmlRoot(Namespace = "http://www.stormware.cz/schema/version_2/data.xsd", IsNullable = false)]
        public class dataPack
        {

            private dataPackDataPackItem dataPackItemField;

            private string idField;

            private uint icoField;

            private string applicationField;

            private decimal versionField;

            private string noteField;

                public dataPackDataPackItem dataPackItem
            {
                get => dataPackItemField;
                set => dataPackItemField = value;
            }

                [XmlAttribute]
            public string id
            {
                get => idField;
                set => idField = value;
            }

                [XmlAttribute]
            public uint ico
            {
                get => icoField;
                set => icoField = value;
            }

                [XmlAttribute]
            public string application
            {
                get => applicationField;
                set => applicationField = value;
            }

                [XmlAttribute]
            public decimal version
            {
                get => versionField;
                set => versionField = value;
            }

                [XmlAttribute]
            public string note
            {
                get => noteField;
                set => noteField = value;
            }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/data.xsd")]
        public class dataPackDataPackItem
        {

            private stock stockField;

            private string idField;

            private decimal versionField;

                [XmlElement(Namespace = "http://www.stormware.cz/schema/version_2/stock.xsd")]
            public stock stock
            {
                get => stockField;
                set => stockField = value;
            }

                [XmlAttribute]
            public string id
            {
                get => idField;
                set => idField = value;
            }

                [XmlAttribute]
            public decimal version
            {
                get => versionField;
                set => versionField = value;
            }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/stock.xsd")]
        [XmlRoot(Namespace = "http://www.stormware.cz/schema/version_2/stock.xsd", IsNullable = false)]
        public class stock
        {

            private stockActionType actionTypeField;

            private decimal versionField;

                public stockActionType actionType
            {
                get => actionTypeField;
                set => actionTypeField = value;
            }

                [XmlAttribute]
            public decimal version
            {
                get => versionField;
                set => versionField = value;
            }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/stock.xsd")]
        public class stockActionType
        {

            private stockActionTypeDelete deleteField;

                public stockActionTypeDelete delete
            {
                get => deleteField;
                set => deleteField = value;
            }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/stock.xsd")]
        public class stockActionTypeDelete
        {

            private filter filterField;

                [XmlElement(Namespace = "http://www.stormware.cz/schema/version_2/filter.xsd")]
            public filter filter
            {
                get => filterField;
                set => filterField = value;
            }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/filter.xsd")]
        [XmlRoot(Namespace = "http://www.stormware.cz/schema/version_2/filter.xsd", IsNullable = false)]
        public class filter
        {

            private string codeField;

                public string code
            {
                get => codeField;
                set => codeField = value;
            }
        }


    }
}
