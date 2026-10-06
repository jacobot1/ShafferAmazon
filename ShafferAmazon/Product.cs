using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ShafferAmazon
{
    public class Product
    {
        private string prodName = "";
        private string prodDescription = "";
        public required string availabilityStatus = "";
        // Store the creation date of the product as a readonly field,
        // so it doesn't get modified later.
        private readonly DateTime createDate = DateTime.Now;
        public static string StoreName = "TotallyNotAmazon";
        [SetsRequiredMembers]
        public Product()
        {
            ProductName = "No name given";
            availabilityStatus = "";
        }
        [SetsRequiredMembers]
        public Product(string id)
        {
            ProductID = id;
            ProductName = "Product";
            ProductDescription = "A Cool Product";
            SpecialFeature = "This product does something really cool!";
            Vendor = "ACME";
            availabilityStatus = "";
        }
        [SetsRequiredMembers]
        public Product(string id, string name, string description, string feature, string vendor, string availability)
        {
            ProductID = id;
            ProductName = name;
            ProductDescription = description;
            SpecialFeature = feature;
            Vendor = vendor;
            availabilityStatus = availability;
        }
        // Only allow init for ProductID, so it can only be set when a new Product is created.
        public string ProductID { get; init; } = "";
        
        public required string ProductName
        {
            get { return prodName; }
            set { prodName = value.Trim(); }
        }
        public string ProductDescription
        {
            get
            {
                if (String.IsNullOrEmpty(prodDescription))
                {
                    return "No description available";
                }
                else
                {
                    return prodDescription;
                }
            }
            set { prodDescription = value.Trim(); }
        }
        public string SpecialFeature { get; set; } = "";
        public string Vendor { get; set; } = "";
        public string AvailabilityStatus
        {
            get
            {
                if (String.IsNullOrEmpty(availabilityStatus))
                {
                    return "Unknown";
                }
                else
                {
                    return availabilityStatus;
                }
            }
        }

        public string CreationDate
        {
            get { return createDate.ToString(); }
        }
    }
}
