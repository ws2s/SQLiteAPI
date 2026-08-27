using SQLiteAPI.Models;

namespace SQLiteAPI.Data;

public static class SeedData
{
    public static void Initialize(APIContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                Name = "Basic Cheese Pizza",
                Description = "It's cheesy and delicious. Why wouldn't you want one?",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
            new PizzaSpecial()
            {
                Id = 2,
                Name = "The Baconatorizor",
                Description = "It has EVERY kind of bacon",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                Id = 3,
                Name = "Classic pepperoni",
                Description = "It's the pizza you grew up with, but Blazing hot!",
                BasePrice = 10.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                Id = 4,
                Name = "Buffalo chicken",
                Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up",
                BasePrice = 12.75m,
                ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                Id = 5,
                Name = "Mushroom Lovers",
                Description = "It has mushrooms. Isn't that obvious?",
                BasePrice = 11.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                Id = 7,
                Name = "Veggie Delight",
                Description = "It's like salad, but on a pizza",
                BasePrice = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                Id = 8,
                Name = "Margherita",
                Description = "Traditional Italian pizza with tomatoes and basil",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
            },
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
        
        var approvalTypes = new LookupApprovalType[]
        {
            new LookupApprovalType()
            {
                Seq = 1,
                ApprovalType = "LockShop",
                Active = true
            },
            new LookupApprovalType()
            {
                ID = 2,
                Seq = 2,
                ApprovalType = "Customer Support Center",
                Active = true
            },
            new LookupApprovalType()
            {
                ID = 3,
                Seq = 3,
                ApprovalType = "Read Only",
                Active = true
            },
            new LookupApprovalType()
            {
                ID = 4,
                Seq = 4,
                ApprovalType = "Admin",
                Active = true
            },
            new LookupApprovalType()
            {
                ID = 5,
                Seq = 10,
                ApprovalType = "Supervisor",
                Active = true
            },
            new LookupApprovalType()
            {
                ID = 6,
                Seq = 20,
                ApprovalType = "Department",
                Active = true
            },
            new LookupApprovalType()
            {
                ID = 7,
                Seq = 30,
                ApprovalType = "Health System",
                Active = true
            },
            new LookupApprovalType()
            {
                ID = 8,
                Seq = 40,
                ApprovalType = "Safety & Security",
                Active = true
            },
            new LookupApprovalType()
            {
                ID = 9,
                Seq = 50,
                ApprovalType = "UPD",
                Active = false
            }
        };
        db.ApprovalTypes.AddRange(approvalTypes);
        db.SaveChanges();

        var justifications = new LookupJustification[]
        {
            new LookupJustification()
            {
                RequestType = "New",
                Description = "New hire"
            },
            new LookupJustification()
            {
                ID = 2,
                RequestType = "New",
                Description = "New or renovated space"
            },
            new LookupJustification()
            {
                ID = 3,
                RequestType = "New",
                Description = "Current employee needs access to additional space"
            },
            new LookupJustification()
            {
                ID = 4,
                RequestType = "New",
                Description = "Other (please describe)"
            },
            new LookupJustification()
            {
                ID = 5,
                RequestType = "Replacement",
                Description = "Previous key damaged"
            },
            new LookupJustification()
            {
                ID = 6,
                RequestType = "Replacement",
                Description = "Previous key lost"
            },
            new LookupJustification()
            {
                ID = 7,
                RequestType = "Replacement",
                Description = "Previous key stolen"
            },
            new LookupJustification()
            {
                ID = 8,
                RequestType = "Replacement",
                Description = "Other (please describe)"
            },
            new LookupJustification()
            {
                ID = 9,
                RequestType = "Temporary",
                Description = "Construction/renovation project"
            },
            new LookupJustification()
            {
                ID = 10,
                RequestType = "Temporary",
                Description = "Temporary employee"
            },
            new LookupJustification()
            {
                ID = 11,
                RequestType = "Temporary",
                Description = "Other (please describe)"
            },
            new LookupJustification()
            {
                ID = 12,
                RequestType = "Rekey",
                Description = "Previous key lost"
            },
            new LookupJustification()
            {
                ID = 13,
                RequestType = "Rekey",
                Description = "Previous key stolen"
            },
            new LookupJustification()
            {
                ID = 14,
                RequestType = "Rekey",
                Description = "Change to match other locks"
            },
            new LookupJustification()
            {
                ID = 15,
                RequestType = "Rekey",
                Description = "Increase security/limit access"
            },
            new LookupJustification()
            {
                ID = 16,
                RequestType = "Rekey",
                Description = "Other (please describe)"
            },
            new LookupJustification()
            {
                ID = 17,
                RequestType = "Transfer",
                Description = "Position is being replaced"
            },
            new LookupJustification()
            {
                ID = 18,
                RequestType = "Transfer",
                Description = "Change in job duties between employees"
            },
            new LookupJustification()
            {
                ID = 19,
                RequestType = "Transfer",
                Description = "Other (please describe)"
            }
        };
        db.Justifications.AddRange(justifications);
        db.SaveChanges();

        var pickupLocations = new LookupPickupLocation[]
        {
            new LookupPickupLocation()
            {
                ID = 1,
                Description = "Customer Support Center - Leake Building, Room 036, Lower level",
                Location = "Academic",
                Building = "Leake Building",
                RoomFloor = "Room 036, Lower level",
                StreetAddress = "1450 Leake Drive",
                CityZip = "Charlottesville, VA 22904"
            },
            new LookupPickupLocation()
            {
                ID = 2,
                Description = "Multistory Building in West Complex, Room G018, Ground floor",
                Location = "Health System",
                Building = "West Complex",
                RoomFloor = "Room G018, Ground floor",
                StreetAddress = "1400 Jefferson Park Avenue",
                CityZip = "Charlottesville, VA 22908"
            }
        };
        db.PickupLocations.AddRange(pickupLocations);
        db.SaveChanges();

        var requestTypes = new LookupRequestType[]
        {
            new LookupRequestType()
            {
                Description = "New"
            },
            new LookupRequestType()
            {
                ID = 2,
                Description = "Temporary"
            },
            new LookupRequestType()
            {
                ID = 3,
                Description = "Transfer"
            },
            new LookupRequestType()
            {
                ID = 4,
                Description = "Rekey"
            },
            new LookupRequestType()
            {
                ID = 5,
                Description = "Replacement"
            }
        };
        db.RequestTypes.AddRange(requestTypes);
        db.SaveChanges();

        var approvers = new LookupSpecialApprover[]
        {
            new LookupSpecialApprover()
            {
                Seq = 1,
                ApprovalType = "LockShop",
                ApproverComputingID = "ws2s",
                ApproverFullName = "Wei Sun (ws2s)",
                ApproverPhone = "243-2592",
                ApproverEmail = "ws2s@virginia.edu",
                AlternateComputingID = null
            },
            new LookupSpecialApprover()
            {
                ID = 2,
                Seq = 2,
                ApprovalType = "Customer Support Center",
                ApproverComputingID = "ws2s",
                ApproverFullName = "Wei Sun (ws2s)",
                ApproverPhone = "243-2592",
                ApproverEmail = "ws2s@virginia.edu",
                AlternateComputingID = null
            },
            new LookupSpecialApprover()
            {
                ID = 3,
                Seq = 3,
                ApprovalType = "Read Only",
                ApproverComputingID = "ws2s",
                ApproverFullName = "Wei Sun (ws2s)",
                ApproverPhone = "243-2592",
                ApproverEmail = "ws2s@virginia.edu",
                AlternateComputingID = null
            },
            new LookupSpecialApprover()
            {
                ID = 4,
                Seq = 4,
                ApprovalType = "Admin",
                ApproverComputingID = "ws2s",
                ApproverFullName = "Wei Sun (ws2s)",
                ApproverPhone = "243-2592",
                ApproverEmail = "ws2s@virginia.edu",
                AlternateComputingID = null
            }
        };
        db.SpecialApprovers.AddRange(approvers);
        db.SaveChanges();
    }
}