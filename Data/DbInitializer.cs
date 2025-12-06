using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using ZooAndAnimalFun.Models;
using ZooAndAnimalFun.Models;

namespace ZooAndAnimalFun.Data
{
    public class DbInitializer
    {

        public static void Initialize(ZooAndAnimalFunContext context, string xmlPath = @"Data\seed.xml")
        {
            {
                // Ensure database is created
                context.Database.Migrate(); 


                if (context.Animal.Any()) return;
               
                SeedDto seed = LoadSeed(xmlPath);

                Dictionary<string, AnimalCategories> animalCategoriesDict = seed.AnimalCategories.ToDictionary(
                    x => x.Id,
                    x => new AnimalCategories
                    {
                        CategoryName = x.CategoryName
                    }
                    );
                Dictionary<string, Customer> customerDict = seed.Customers.ToDictionary(
                    x => x.Id,
                    x => new Customer
                    {
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Address1 = x.Address1,
                        Address2 = x.Address2,
                        City = x.City,
                        State = x.State,
                        ZIP = x.ZIP,
                        Phone = x.Phone,
                        Email = x.Email
                    }
                    );
                Dictionary<string, Employee> employeeDict = seed.Employees.ToDictionary(
                    x => x.Id,
                    x => new Employee
                    {
                        FirstName = x.FirstName,
                        LastName = x.LastName
                    }
                    );
                Dictionary<string, EventCategory> eventCategoryDict = seed.EventCategorys.ToDictionary(
                    x => x.Id,
                    x => new EventCategory
                    {
                        EventCategoryName = x.EventCategoryName,
                        AvailableToCustomers = x.AvailableToCustomers
                    }
                    );
                Dictionary<string, Gender> genderDict = seed.Genders.ToDictionary(
                    x => x.Id,
                    x => new Gender
                    {
                        GenderName = x.GenderName
                    }
                    );
                Dictionary<string, HealthStatus> healthStatusDict = seed.HealthStatus.ToDictionary(
                    x => x.Id,
                    x => new HealthStatus
                    {
                        HealthDescription = x.HealthDescription
                    }
                    );
                Dictionary<string, Species> speciesDict = seed.Species.ToDictionary(
                    x => x.Id,
                    x => new Species
                    {
                        SpeciesName = x.SpeciesName,
                        EventCategory = eventCategoryDict[x.EventCategoryID]
                    }
                    );
                Dictionary<string, Animal> animalDict = seed.Animals.ToDictionary(
                    x => x.Id,
                    x => new Animal
                    {
                        Name = x.Name,
                        Weight = x.Weight,
                        Gender = genderDict[x.GenderID],
                        HealthStatus = healthStatusDict[x.HealthStatusID],
                        Species = speciesDict[x.SpeciesID]
                    }
                    );
                Dictionary<string, Event> eventDict = seed.Events.ToDictionary(
                    x => x.Id,
                    x => new Event
                    {
                        EventName = x.EventName,
                        EventStart = x.EventStart,
                        EventEnd = x.EventEnd,
                        EventCategory = eventCategoryDict[x.EventCategoryID],
                        Animal = animalDict[x.AnimalID]
                    }
                    );
                Dictionary<string, TicketType> ticketTypeDict = seed.TicketTypes.ToDictionary(
                   x => x.Id,
                   x => new TicketType
                   {
                       TicketTypeName = x.TicketTypeName
                   }
                   );
                Dictionary<string, TicketSales> ticketSalesDict = seed.TicketSales.ToDictionary(
                   x => x.Id,
                   x => new TicketSales
                   {
                       Price = x.Price,
                       DateSold = x.DateSold,
                       ApplicableFor = x.ApplicableFor,
                       Customer = customerDict[x.CustomerID],
                       TicketType = ticketTypeDict[x.TicketTypeID]
                   }
                   );
                Dictionary<string, Venue> venueDict = seed.Venues.ToDictionary(
                   x => x.Id,
                   x => new Venue
                   {
                       VenueName = x.VenueName,
                       Capacity = x.Capacity,
                       Event = eventDict[x.EventID]
                   }
                   );
                Dictionary<string, Session> sessionDict = seed.Sessions.ToDictionary(
                   x => x.Id,
                   x => new Session
                   {
                       TicketSales = ticketSalesDict[x.TicketID],
                       Event = eventDict[x.EventID],
                       Venue = venueDict[x.VenueID]
                   }
                   );
                /*
                Dictionary<int, Event> eventDict = seed.Events.ToDictionary(
                    x => x.Id,
                    x => {
                        List<Event> EventList = new List<Event>();

                        return new Session
                        {
                            SessionID = x.SessionId
                        ,
                            TicketID = x.TicketId
                        ,
                        };
                    }
                    );
                */

                context.AddRange(animalDict.Values);
                context.AddRange(customerDict.Values);
                context.AddRange(employeeDict.Values);
                context.AddRange(eventDict.Values);
                context.AddRange(eventCategoryDict.Values);
                context.AddRange(genderDict.Values);
                context.AddRange(healthStatusDict.Values);
                context.AddRange(speciesDict.Values);
                context.AddRange(sessionDict.Values);
                context.AddRange(ticketSalesDict.Values);
                context.AddRange(ticketTypeDict.Values);
                context.AddRange(venueDict.Values);

                context.SaveChanges();

            }
        }




        public static SeedDto LoadSeed(string path)
           {
           var ser = new XmlSerializer(typeof(SeedDto));
           var stg = new XmlReaderSettings
           {
               IgnoreComments = true
                                          ,
               IgnoreProcessingInstructions = true
           };
           using var reader = XmlReader.Create(path, stg);

           //try
           //{
         return (SeedDto)ser.Deserialize(reader);
           //}
           //catch (InvalidOperationException ex)
          // {
           //    string msg = $"Failed to deserialize '{path}'. {ex.InnerException?.Message ?? ex.Message}";
           //    throw new InvalidOperationException(msg, ex);
          // }
        }
    }
}
