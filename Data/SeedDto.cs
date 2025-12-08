using System.Data;

namespace System.Xml.Serialization;

[XmlRoot("Seed")]

public class SeedDto
    {
    [XmlArray("Animals"), XmlArrayItem("Animal")]
    public List<AnimalDto> Animals { get; set; } = new();
    [XmlArray("AnimalCategories"), XmlArrayItem("AnimalCategory")]
    public List<AnimalCategoryDto> AnimalCategories { get; set; } = new();
    [XmlArray("Customers"), XmlArrayItem("Customer")]
    public List<CustomerDto> Customers { get; set; } = new();
    [XmlArray("Employees"), XmlArrayItem("Employee")]
    public List<EmployeeDto> Employees { get; set; } = new();
    [XmlArray("Events"), XmlArrayItem("Event")]
    public List<EventDto> Events { get; set; } = new();
    [XmlArray("EventCategorys"), XmlArrayItem("EventCategory")]
    public List<EventCategoryDto> EventCategorys { get; set; } = new();
    [XmlArray("Genders"), XmlArrayItem("Gender")]
    public List<GenderDto> Genders { get; set; } = new();
    [XmlArray("HealthStatuses"), XmlArrayItem("HealthStatus")]
    public List<HealthStatusDto> HealthStatus { get; set; } = new();
    [XmlArray("Sessions"), XmlArrayItem("Session")]
    public List<SessionDto> Sessions { get; set; } = new();
    [XmlArray("Species"), XmlArrayItem("Species")]
    public List<SpeciesDto> Species { get; set; } = new();
    [XmlArray("TicketSales"), XmlArrayItem("TicketSale")]
    public List<TicketSalesDto> TicketSales { get; set; } = new();
    [XmlArray("TicketTypes"), XmlArrayItem("TicketType")]
    public List<TicketTypeDto> TicketTypes { get; set; } = new();
    [XmlArray("Venues"), XmlArrayItem("Venue")]
    public List<VenueDto> Venues { get; set; } = new();
}

public class AnimalDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public double Weight { get; set; }
    public string GenderID { get; set; } = "";
    public string HealthStatusID { get; set; } = "";
    public string SpeciesID { get; set; } = "";
}

public class AnimalCategoryDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string CategoryName { get; set; } = "";
}

public class CustomerDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Address1 { get; set; } = "";
    public string? Address2 { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string ZIP { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
}

public class EmployeeDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
}

public class EventDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string EventName { get; set; } = "";
    public DateTime EventStart { get; set; }
    public DateTime EventEnd { get; set; }
    public string EventCategoryID { get; set; } = "";
    public string AnimalID { get; set; } = "";
}

public class EventCategoryDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string EventCategoryName { get; set; } = "";
    public bool AvailableToCustomers { get; set; }
}

public class GenderDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string GenderName { get; set; } = "";
}

public class HealthStatusDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string HealthDescription { get; set; } = "";
}

public class SessionDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string EventID { get; set; } = "";
    public string VenueID { get; set; }  = "";

}

public class SpeciesDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string SpeciesName { get; set; } = "";
    public string EventCategoryID { get; set; } = "";
}

public class TicketSalesDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public double Price { get; set; }
    public DateTime DateSold { get; set; }
    public DateTime ApplicableFor { get; set; }
    public string CustomerID { get; set; } = "";
    public string TicketTypeID { get; set; } = "";
    //public string SessionID { get; set; } = "";
}

public class TicketTypeDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string TicketTypeName { get; set; } = "";
}

public class VenueDto
{
    [XmlAttribute("id")]
    public string Id { get; set; } = "";
    public string VenueName { get; set; } = "";
    public int Capacity { get; set; }
    public string EventID { get; set; } = "";
}