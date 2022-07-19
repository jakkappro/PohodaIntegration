using System.ComponentModel;
using System.Xml.Serialization;
using System;
using System.Xml;

namespace PohodaIntegration.Models.Orders.Expando
{
    public class ExpandoOrderModel
    {
        public static orders Deserialize(string filename)
        {
            Console.WriteLine("Reading with Stream");
            XmlSerializer serializer = new(typeof(orders));

            orders i;

            using Stream reader = new FileStream(filename, FileMode.Open);
            i = (orders)serializer.Deserialize(reader);
            return i;
        }

        // not tested
        public static string Serialize(orders i)
        {
            Console.WriteLine("Writing with Stream");
            // Create an instance of the XmlSerializer class.
            XmlSerializer serializer =
            new XmlSerializer(typeof(orders));

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
        [XmlTypeAttribute(AnonymousType = true)]
        [XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class orders
        {

            private ordersOrder orderField;

            /// <remarks/>
            public ordersOrder order
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
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrder
        {

            private string orderIdField;

            private string orderStatusField;

            private string purchaseDateField;

            private string marketplaceField;

            private string venueField;

            private string fulfillmentChannelField;

            private bool businessOrderField;

            private decimal totalPriceField;

            private byte totalItemTaxField;

            private string currencyCodeField;

            private string languageField;

            private string paymentMethodField;

            private string shippingMethodField;

            private string shipServiceLevelField;

            private object deliveryBranchIdField;

            private byte shippingPriceField;

            private string latestShipDateField;

            private string latestDeliveryDateField;

            private bool isPremiumOrderField;

            private bool isPrimeField;

            private bool isCompleteField;

            private bool isRefundedField;

            private ordersOrderInvoiceUrls invoiceUrlsField;

            private ordersOrderInvoices invoicesField;

            private ordersOrderCustomer customerField;

            private ordersOrderItems itemsField;

            private ordersOrderPrice priceField;

            private ordersOrderPayment paymentField;

            private ordersOrderDelivery deliveryField;

            /// <remarks/>
            public string orderId
            {
                get
                {
                    return this.orderIdField;
                }
                set
                {
                    this.orderIdField = value;
                }
            }

            /// <remarks/>
            public string orderStatus
            {
                get
                {
                    return this.orderStatusField;
                }
                set
                {
                    this.orderStatusField = value;
                }
            }

            /// <remarks/>
            public string purchaseDate
            {
                get
                {
                    return this.purchaseDateField;
                }
                set
                {
                    this.purchaseDateField = value;
                }
            }

            /// <remarks/>
            public string marketplace
            {
                get
                {
                    return this.marketplaceField;
                }
                set
                {
                    this.marketplaceField = value;
                }
            }

            /// <remarks/>
            public string venue
            {
                get
                {
                    return this.venueField;
                }
                set
                {
                    this.venueField = value;
                }
            }

            /// <remarks/>
            public string fulfillmentChannel
            {
                get
                {
                    return this.fulfillmentChannelField;
                }
                set
                {
                    this.fulfillmentChannelField = value;
                }
            }

            /// <remarks/>
            public bool businessOrder
            {
                get
                {
                    return this.businessOrderField;
                }
                set
                {
                    this.businessOrderField = value;
                }
            }

            /// <remarks/>
            public decimal totalPrice
            {
                get
                {
                    return this.totalPriceField;
                }
                set
                {
                    this.totalPriceField = value;
                }
            }

            /// <remarks/>
            public byte totalItemTax
            {
                get
                {
                    return this.totalItemTaxField;
                }
                set
                {
                    this.totalItemTaxField = value;
                }
            }

            /// <remarks/>
            public string currencyCode
            {
                get
                {
                    return this.currencyCodeField;
                }
                set
                {
                    this.currencyCodeField = value;
                }
            }

            /// <remarks/>
            public string language
            {
                get
                {
                    return this.languageField;
                }
                set
                {
                    this.languageField = value;
                }
            }

            /// <remarks/>
            public string paymentMethod
            {
                get
                {
                    return this.paymentMethodField;
                }
                set
                {
                    this.paymentMethodField = value;
                }
            }

            /// <remarks/>
            public string shippingMethod
            {
                get
                {
                    return this.shippingMethodField;
                }
                set
                {
                    this.shippingMethodField = value;
                }
            }

            /// <remarks/>
            public string shipServiceLevel
            {
                get
                {
                    return this.shipServiceLevelField;
                }
                set
                {
                    this.shipServiceLevelField = value;
                }
            }

            /// <remarks/>
            public object deliveryBranchId
            {
                get
                {
                    return this.deliveryBranchIdField;
                }
                set
                {
                    this.deliveryBranchIdField = value;
                }
            }

            /// <remarks/>
            public byte shippingPrice
            {
                get
                {
                    return this.shippingPriceField;
                }
                set
                {
                    this.shippingPriceField = value;
                }
            }

            /// <remarks/>
            public string latestShipDate
            {
                get
                {
                    return this.latestShipDateField;
                }
                set
                {
                    this.latestShipDateField = value;
                }
            }

            /// <remarks/>
            public string latestDeliveryDate
            {
                get
                {
                    return this.latestDeliveryDateField;
                }
                set
                {
                    this.latestDeliveryDateField = value;
                }
            }

            /// <remarks/>
            public bool isPremiumOrder
            {
                get
                {
                    return this.isPremiumOrderField;
                }
                set
                {
                    this.isPremiumOrderField = value;
                }
            }

            /// <remarks/>
            public bool isPrime
            {
                get
                {
                    return this.isPrimeField;
                }
                set
                {
                    this.isPrimeField = value;
                }
            }

            /// <remarks/>
            public bool isComplete
            {
                get
                {
                    return this.isCompleteField;
                }
                set
                {
                    this.isCompleteField = value;
                }
            }

            /// <remarks/>
            public bool isRefunded
            {
                get
                {
                    return this.isRefundedField;
                }
                set
                {
                    this.isRefundedField = value;
                }
            }

            /// <remarks/>
            public ordersOrderInvoiceUrls invoiceUrls
            {
                get
                {
                    return this.invoiceUrlsField;
                }
                set
                {
                    this.invoiceUrlsField = value;
                }
            }

            /// <remarks/>
            public ordersOrderInvoices invoices
            {
                get
                {
                    return this.invoicesField;
                }
                set
                {
                    this.invoicesField = value;
                }
            }

            /// <remarks/>
            public ordersOrderCustomer customer
            {
                get
                {
                    return this.customerField;
                }
                set
                {
                    this.customerField = value;
                }
            }

            /// <remarks/>
            public ordersOrderItems items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            public ordersOrderPrice price
            {
                get
                {
                    return this.priceField;
                }
                set
                {
                    this.priceField = value;
                }
            }

            /// <remarks/>
            public ordersOrderPayment payment
            {
                get
                {
                    return this.paymentField;
                }
                set
                {
                    this.paymentField = value;
                }
            }

            /// <remarks/>
            public ordersOrderDelivery delivery
            {
                get
                {
                    return this.deliveryField;
                }
                set
                {
                    this.deliveryField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderInvoiceUrls
        {

            private string urlField;

            private string[] textField;

            /// <remarks/>
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [XmlTextAttribute()]
            public string[] Text
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
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderInvoices
        {

            private ordersOrderInvoicesInvoice invoiceField;

            /// <remarks/>
            public ordersOrderInvoicesInvoice invoice
            {
                get
                {
                    return this.invoiceField;
                }
                set
                {
                    this.invoiceField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderInvoicesInvoice
        {

            private string idField;

            private string urlField;

            private string[] textField;

            /// <remarks/>
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
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [XmlTextAttribute()]
            public string[] Text
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
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderCustomer
        {

            private string companyNameField;

            private string firstnameField;

            private string surnameField;

            private string emailField;

            private object phoneField;

            private object taxIdField;

            private object taxCountryField;

            private ordersOrderCustomerAddress addressField;

            /// <remarks/>
            public string companyName
            {
                get
                {
                    return this.companyNameField;
                }
                set
                {
                    this.companyNameField = value;
                }
            }

            /// <remarks/>
            public string firstname
            {
                get
                {
                    return this.firstnameField;
                }
                set
                {
                    this.firstnameField = value;
                }
            }

            /// <remarks/>
            public string surname
            {
                get
                {
                    return this.surnameField;
                }
                set
                {
                    this.surnameField = value;
                }
            }

            /// <remarks/>
            public string email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }

            /// <remarks/>
            public object phone
            {
                get
                {
                    return this.phoneField;
                }
                set
                {
                    this.phoneField = value;
                }
            }

            /// <remarks/>
            public object taxId
            {
                get
                {
                    return this.taxIdField;
                }
                set
                {
                    this.taxIdField = value;
                }
            }

            /// <remarks/>
            public object taxCountry
            {
                get
                {
                    return this.taxCountryField;
                }
                set
                {
                    this.taxCountryField = value;
                }
            }

            /// <remarks/>
            public ordersOrderCustomerAddress address
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
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderCustomerAddress
        {

            private string address1Field;

            private object address2Field;

            private object address3Field;

            private string cityField;

            private uint zipField;

            private string stateOrRegionField;

            private string countryField;

            /// <remarks/>
            public string address1
            {
                get
                {
                    return this.address1Field;
                }
                set
                {
                    this.address1Field = value;
                }
            }

            /// <remarks/>
            public object address2
            {
                get
                {
                    return this.address2Field;
                }
                set
                {
                    this.address2Field = value;
                }
            }

            /// <remarks/>
            public object address3
            {
                get
                {
                    return this.address3Field;
                }
                set
                {
                    this.address3Field = value;
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
            public uint zip
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
            public string stateOrRegion
            {
                get
                {
                    return this.stateOrRegionField;
                }
                set
                {
                    this.stateOrRegionField = value;
                }
            }

            /// <remarks/>
            public string country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderItems
        {

            private ordersOrderItemsItem itemField;

            /// <remarks/>
            public ordersOrderItemsItem item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderItemsItem
        {

            private ushort itemIdField;

            private object externalIdField;

            private decimal itemPriceField;

            private byte itemQuantityField;

            private string itemNameField;

            private byte orderItemIdField;

            private byte itemTaxField;

            private byte shippingDiscountField;

            private byte shippingDiscountTaxField;

            private byte promotionDiscountField;

            private byte promotionDiscountTaxField;

            private byte shippingPriceField;

            private byte shippingTaxField;

            private ordersOrderItemsItemLineItemPrice lineItemPriceField;

            private ordersOrderItemsItemLineItemDiscount lineItemDiscountField;

            private ordersOrderItemsItemDeliveryPrice deliveryPriceField;

            private ordersOrderItemsItemDeliveryDiscount deliveryDiscountField;

            private ordersOrderItemsItemMarketplaceCommission marketplaceCommissionField;

            /// <remarks/>
            public ushort itemId
            {
                get
                {
                    return this.itemIdField;
                }
                set
                {
                    this.itemIdField = value;
                }
            }

            /// <remarks/>
            public object externalId
            {
                get
                {
                    return this.externalIdField;
                }
                set
                {
                    this.externalIdField = value;
                }
            }

            /// <remarks/>
            public decimal itemPrice
            {
                get
                {
                    return this.itemPriceField;
                }
                set
                {
                    this.itemPriceField = value;
                }
            }

            /// <remarks/>
            public byte itemQuantity
            {
                get
                {
                    return this.itemQuantityField;
                }
                set
                {
                    this.itemQuantityField = value;
                }
            }

            /// <remarks/>
            public string itemName
            {
                get
                {
                    return this.itemNameField;
                }
                set
                {
                    this.itemNameField = value;
                }
            }

            /// <remarks/>
            public byte orderItemId
            {
                get
                {
                    return this.orderItemIdField;
                }
                set
                {
                    this.orderItemIdField = value;
                }
            }

            /// <remarks/>
            public byte itemTax
            {
                get
                {
                    return this.itemTaxField;
                }
                set
                {
                    this.itemTaxField = value;
                }
            }

            /// <remarks/>
            public byte shippingDiscount
            {
                get
                {
                    return this.shippingDiscountField;
                }
                set
                {
                    this.shippingDiscountField = value;
                }
            }

            /// <remarks/>
            public byte shippingDiscountTax
            {
                get
                {
                    return this.shippingDiscountTaxField;
                }
                set
                {
                    this.shippingDiscountTaxField = value;
                }
            }

            /// <remarks/>
            public byte promotionDiscount
            {
                get
                {
                    return this.promotionDiscountField;
                }
                set
                {
                    this.promotionDiscountField = value;
                }
            }

            /// <remarks/>
            public byte promotionDiscountTax
            {
                get
                {
                    return this.promotionDiscountTaxField;
                }
                set
                {
                    this.promotionDiscountTaxField = value;
                }
            }

            /// <remarks/>
            public byte shippingPrice
            {
                get
                {
                    return this.shippingPriceField;
                }
                set
                {
                    this.shippingPriceField = value;
                }
            }

            /// <remarks/>
            public byte shippingTax
            {
                get
                {
                    return this.shippingTaxField;
                }
                set
                {
                    this.shippingTaxField = value;
                }
            }

            /// <remarks/>
            public ordersOrderItemsItemLineItemPrice lineItemPrice
            {
                get
                {
                    return this.lineItemPriceField;
                }
                set
                {
                    this.lineItemPriceField = value;
                }
            }

            /// <remarks/>
            public ordersOrderItemsItemLineItemDiscount lineItemDiscount
            {
                get
                {
                    return this.lineItemDiscountField;
                }
                set
                {
                    this.lineItemDiscountField = value;
                }
            }

            /// <remarks/>
            public ordersOrderItemsItemDeliveryPrice deliveryPrice
            {
                get
                {
                    return this.deliveryPriceField;
                }
                set
                {
                    this.deliveryPriceField = value;
                }
            }

            /// <remarks/>
            public ordersOrderItemsItemDeliveryDiscount deliveryDiscount
            {
                get
                {
                    return this.deliveryDiscountField;
                }
                set
                {
                    this.deliveryDiscountField = value;
                }
            }

            /// <remarks/>
            public ordersOrderItemsItemMarketplaceCommission marketplaceCommission
            {
                get
                {
                    return this.marketplaceCommissionField;
                }
                set
                {
                    this.marketplaceCommissionField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderItemsItemLineItemPrice
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private decimal withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public decimal withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderItemsItemLineItemDiscount
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private object withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public object withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderItemsItemDeliveryPrice
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private byte withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public byte withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderItemsItemDeliveryDiscount
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private object withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public object withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderItemsItemMarketplaceCommission
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private object withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public object withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderPrice
        {

            private ordersOrderPriceDelivery deliveryField;

            private ordersOrderPriceItems itemsField;

            private ordersOrderPricePayment paymentField;

            private ordersOrderPriceTotal totalField;

            private ordersOrderPriceTotalDiscount totalDiscountField;

            private string[] textField;

            /// <remarks/>
            public ordersOrderPriceDelivery delivery
            {
                get
                {
                    return this.deliveryField;
                }
                set
                {
                    this.deliveryField = value;
                }
            }

            /// <remarks/>
            public ordersOrderPriceItems items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            public ordersOrderPricePayment payment
            {
                get
                {
                    return this.paymentField;
                }
                set
                {
                    this.paymentField = value;
                }
            }

            /// <remarks/>
            public ordersOrderPriceTotal total
            {
                get
                {
                    return this.totalField;
                }
                set
                {
                    this.totalField = value;
                }
            }

            /// <remarks/>
            public ordersOrderPriceTotalDiscount totalDiscount
            {
                get
                {
                    return this.totalDiscountField;
                }
                set
                {
                    this.totalDiscountField = value;
                }
            }

            /// <remarks/>
            [XmlTextAttribute()]
            public string[] Text
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
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderPriceDelivery
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private byte withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public byte withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderPriceItems
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private decimal withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public decimal withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderPricePayment
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private object withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public object withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderPriceTotal
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private decimal withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public decimal withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderPriceTotalDiscount
        {

            private object taxField;

            private object taxRatePercentField;

            private object withoutTaxField;

            private object withTaxField;

            /// <remarks/>
            public object tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public object taxRatePercent
            {
                get
                {
                    return this.taxRatePercentField;
                }
                set
                {
                    this.taxRatePercentField = value;
                }
            }

            /// <remarks/>
            public object withoutTax
            {
                get
                {
                    return this.withoutTaxField;
                }
                set
                {
                    this.withoutTaxField = value;
                }
            }

            /// <remarks/>
            public object withTax
            {
                get
                {
                    return this.withTaxField;
                }
                set
                {
                    this.withTaxField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderPayment
        {

            private string paymentMethodField;

            private ordersOrderPaymentCashOnDelivery cashOnDeliveryField;

            /// <remarks/>
            public string paymentMethod
            {
                get
                {
                    return this.paymentMethodField;
                }
                set
                {
                    this.paymentMethodField = value;
                }
            }

            /// <remarks/>
            public ordersOrderPaymentCashOnDelivery cashOnDelivery
            {
                get
                {
                    return this.cashOnDeliveryField;
                }
                set
                {
                    this.cashOnDeliveryField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderPaymentCashOnDelivery
        {

            private decimal toPayField;

            private object servicePriceField;

            /// <remarks/>
            public decimal toPay
            {
                get
                {
                    return this.toPayField;
                }
                set
                {
                    this.toPayField = value;
                }
            }

            /// <remarks/>
            public object servicePrice
            {
                get
                {
                    return this.servicePriceField;
                }
                set
                {
                    this.servicePriceField = value;
                }
            }
        }

        /// <remarks/>
        [SerializableAttribute()]
        [DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public partial class ordersOrderDelivery
        {

            private string shippingCarrierField;

            private string shippingCarrierServiceField;

            /// <remarks/>
            public string shippingCarrier
            {
                get
                {
                    return this.shippingCarrierField;
                }
                set
                {
                    this.shippingCarrierField = value;
                }
            }

            /// <remarks/>
            public string shippingCarrierService
            {
                get
                {
                    return this.shippingCarrierServiceField;
                }
                set
                {
                    this.shippingCarrierServiceField = value;
                }
            }
        }

    }
}