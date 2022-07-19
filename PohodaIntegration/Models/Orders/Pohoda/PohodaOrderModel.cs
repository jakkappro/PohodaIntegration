using System;
using System.ComponentModel;
using System.Xml.Serialization;

using System.Xml;

namespace PohodaIntegration.Models.Orders.Pohoda
{
    public class PohodaOrderModel
    {
        // tested works :DD
        public static dataPack Deserialize(string filename)
        {
            Console.WriteLine("Reading with Stream");
            XmlSerializer serializer = new(typeof(dataPack));

            dataPack i;

            using Stream reader = new FileStream(filename, FileMode.Open);
            i = (dataPack)serializer.Deserialize(reader);
            return i;
        }

        // not tested
        public static string Serialize(dataPack i)
        {
            Console.WriteLine("Writing with Stream");
            // Create an instance of the XmlSerializer class.
            XmlSerializer serializer =
            new XmlSerializer(typeof(dataPack));

            // Create an XmlTextWriter.
            XmlWriter writer = new XmlTextWriter(@"C:\Users\Kubino\Downloads\xmlData\pure\pohodaObjednavkaRequest.xml", System.Text.Encoding.UTF8);
            // Serialize the object.
            serializer.Serialize(writer, i);
            writer.Close();
            return "";
        }

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/data.xsd")]
        [XmlRootAttribute(Namespace = "http://www.stormware.cz/schema/version_2/data.xsd", IsNullable = false)]
        public partial class dataPack
        {

            private dataPackDataPackItem dataPackItemField;

            private string idField;

            private uint icoField;

            private string applicationField;

            private decimal versionField;

            private string noteField;

            /// <remarks/>
            public dataPackDataPackItem dataPackItem
            {
                get
                {
                    return this.dataPackItemField;
                }
                set
                {
                    this.dataPackItemField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [XmlAttributeAttribute()]
            public uint ico
            {
                get
                {
                    return this.icoField;
                }
                set
                {
                    this.icoField = value;
                }
            }

            /// <remarks/>
            [XmlAttributeAttribute()]
            public string application
            {
                get
                {
                    return this.applicationField;
                }
                set
                {
                    this.applicationField = value;
                }
            }

            /// <remarks/>
            [XmlAttributeAttribute()]
            public decimal version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [XmlAttributeAttribute()]
            public string note
            {
                get
                {
                    return this.noteField;
                }
                set
                {
                    this.noteField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/data.xsd")]
        public partial class dataPackDataPackItem
        {

            private order orderField;

            private string idField;

            private decimal versionField;

            /// <remarks/>
            [XmlElementAttribute(Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
            public order order
            {
                get
                {
                    return this.orderField;
                }
                set
                {
                    this.orderField = value;
                }
            }

            /// <remarks/>
            [XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [XmlAttributeAttribute()]
            public decimal version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
        [XmlRootAttribute(Namespace = "http://www.stormware.cz/schema/version_2/order.xsd", IsNullable = false)]
        public partial class order
        {

            private orderOrderHeader orderHeaderField;

            private orderOrderItem[] orderDetailField;

            private orderOrderSummary orderSummaryField;

            private decimal versionField;

            /// <remarks/>
            public orderOrderHeader orderHeader
            {
                get
                {
                    return this.orderHeaderField;
                }
                set
                {
                    this.orderHeaderField = value;
                }
            }

            /// <remarks/>
            [XmlArrayItemAttribute("orderItem", IsNullable = false)]
            public orderOrderItem[] orderDetail
            {
                get
                {
                    return this.orderDetailField;
                }
                set
                {
                    this.orderDetailField = value;
                }
            }

            /// <remarks/>
            public orderOrderSummary orderSummary
            {
                get
                {
                    return this.orderSummaryField;
                }
                set
                {
                    this.orderSummaryField = value;
                }
            }

            /// <remarks/>
            [XmlAttributeAttribute()]
            public decimal version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
        public partial class orderOrderHeader
        {

            private string orderTypeField;

            private string numberOrderField;

            private DateTime dateField;

            private DateTime dateFromField;

            private DateTime dateToField;

            private string textField;

            private orderOrderHeaderPartnerIdentity partnerIdentityField;

            private orderOrderHeaderPaymentType paymentTypeField;

            private orderOrderHeaderPriceLevel priceLevelField;

            /// <remarks/>
            public string orderType
            {
                get
                {
                    return this.orderTypeField;
                }
                set
                {
                    this.orderTypeField = value;
                }
            }

            /// <remarks/>
            public string numberOrder
            {
                get
                {
                    return this.numberOrderField;
                }
                set
                {
                    this.numberOrderField = value;
                }
            }

            /// <remarks/>
            [XmlElementAttribute(DataType = "date")]
            public DateTime date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            [XmlElementAttribute(DataType = "date")]
            public DateTime dateFrom
            {
                get
                {
                    return this.dateFromField;
                }
                set
                {
                    this.dateFromField = value;
                }
            }

            /// <remarks/>
            [XmlElementAttribute(DataType = "date")]
            public DateTime dateTo
            {
                get
                {
                    return this.dateToField;
                }
                set
                {
                    this.dateToField = value;
                }
            }

            /// <remarks/>
            public string text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            public orderOrderHeaderPartnerIdentity partnerIdentity
            {
                get
                {
                    return this.partnerIdentityField;
                }
                set
                {
                    this.partnerIdentityField = value;
                }
            }

            /// <remarks/>
            public orderOrderHeaderPaymentType paymentType
            {
                get
                {
                    return this.paymentTypeField;
                }
                set
                {
                    this.paymentTypeField = value;
                }
            }

            /// <remarks/>
            public orderOrderHeaderPriceLevel priceLevel
            {
                get
                {
                    return this.priceLevelField;
                }
                set
                {
                    this.priceLevelField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
        public partial class orderOrderHeaderPartnerIdentity
        {

            private address addressField;

            /// <remarks/>
            [XmlElementAttribute(Namespace = "http://www.stormware.cz/schema/version_2/type.xsd")]
            public address address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/type.xsd")]
        [XmlRootAttribute(Namespace = "http://www.stormware.cz/schema/version_2/type.xsd", IsNullable = false)]
        public partial class address
        {

            private string companyField;

            private string divisionField;

            private string nameField;

            private string cityField;

            private string streetField;

            private ushort zipField;

            private uint icoField;

            private string dicField;

            /// <remarks/>
            public string company
            {
                get
                {
                    return this.companyField;
                }
                set
                {
                    this.companyField = value;
                }
            }

            /// <remarks/>
            public string division
            {
                get
                {
                    return this.divisionField;
                }
                set
                {
                    this.divisionField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string city
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public string street
            {
                get
                {
                    return this.streetField;
                }
                set
                {
                    this.streetField = value;
                }
            }

            /// <remarks/>
            public ushort zip
            {
                get
                {
                    return this.zipField;
                }
                set
                {
                    this.zipField = value;
                }
            }

            /// <remarks/>
            public uint ico
            {
                get
                {
                    return this.icoField;
                }
                set
                {
                    this.icoField = value;
                }
            }

            /// <remarks/>
            public string dic
            {
                get
                {
                    return this.dicField;
                }
                set
                {
                    this.dicField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
        public partial class orderOrderHeaderPaymentType
        {

            private string idsField;

            /// <remarks/>
            [XmlElementAttribute(Namespace = "http://www.stormware.cz/schema/version_2/type.xsd")]
            public string ids
            {
                get
                {
                    return this.idsField;
                }
                set
                {
                    this.idsField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
        public partial class orderOrderHeaderPriceLevel
        {

            private string idsField;

            /// <remarks/>
            [XmlElementAttribute(Namespace = "http://www.stormware.cz/schema/version_2/type.xsd")]
            public string ids
            {
                get
                {
                    return this.idsField;
                }
                set
                {
                    this.idsField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
        public partial class orderOrderItem
        {

            private string textField;

            private byte quantityField;

            private byte deliveredField;

            private string rateVATField;

            private orderOrderItemHomeCurrency homeCurrencyField;

            private orderOrderItemStockItem stockItemField;

            /// <remarks/>
            public string text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            public byte quantity
            {
                get
                {
                    return this.quantityField;
                }
                set
                {
                    this.quantityField = value;
                }
            }

            /// <remarks/>
            public byte delivered
            {
                get
                {
                    return this.deliveredField;
                }
                set
                {
                    this.deliveredField = value;
                }
            }

            /// <remarks/>
            public string rateVAT
            {
                get
                {
                    return this.rateVATField;
                }
                set
                {
                    this.rateVATField = value;
                }
            }

            /// <remarks/>
            public orderOrderItemHomeCurrency homeCurrency
            {
                get
                {
                    return this.homeCurrencyField;
                }
                set
                {
                    this.homeCurrencyField = value;
                }
            }

            /// <remarks/>
            public orderOrderItemStockItem stockItem
            {
                get
                {
                    return this.stockItemField;
                }
                set
                {
                    this.stockItemField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
        public partial class orderOrderItemHomeCurrency
        {

            private byte unitPriceField;

            /// <remarks/>
            [XmlElementAttribute(Namespace = "http://www.stormware.cz/schema/version_2/type.xsd")]
            public byte unitPrice
            {
                get
                {
                    return this.unitPriceField;
                }
                set
                {
                    this.unitPriceField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
        public partial class orderOrderItemStockItem
        {

            private stockItem stockItemField;

            /// <remarks/>
            [XmlElementAttribute(Namespace = "http://www.stormware.cz/schema/version_2/type.xsd")]
            public stockItem stockItem
            {
                get
                {
                    return this.stockItemField;
                }
                set
                {
                    this.stockItemField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/type.xsd")]
        [XmlRootAttribute(Namespace = "http://www.stormware.cz/schema/version_2/type.xsd", IsNullable = false)]
        public partial class stockItem
        {

            private string idsField;

            /// <remarks/>
            public string ids
            {
                get
                {
                    return this.idsField;
                }
                set
                {
                    this.idsField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stormware.cz/schema/version_2/order.xsd")]
        public partial class orderOrderSummary
        {

            private string roundingDocumentField;

            /// <remarks/>
            public string roundingDocument
            {
                get
                {
                    return this.roundingDocumentField;
                }
                set
                {
                    this.roundingDocumentField = value;
                }
            }
        }


    }
}
