namespace GeneratePDF.Models
{
    public class PropertyReportDto
    {
        public string ClientName { get; set; }
        public string UserName { get; set; }
        public string ReportName { get; set; }
        public SubjectProperty SubjectProperty { get; set; }
        public OwnerInformation OwnerInformation { get; set; }
        public ListingPropertyDetail ListingPropertyDetail { get; set; }
        public string LogoBase64 { get; set; }
    }

    public class SubjectProperty
    {
        public long PropertyId { get; set; }
        public SitusAddress SitusAddress { get; set; }
    }

    public class SitusAddress
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip9 { get; set; }
        public string County { get; set; }
    }

    public class OwnerInformation
    {
        public string OwnerNames { get; set; }
        public MailingAddress MailingAddress { get; set; }
    }

    public class MailingAddress
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip9 { get; set; }
    }

    public class ListingPropertyDetail
    {
        public string ListingNumber { get; set; }
        public double ListingPrice { get; set; }
    }
}
