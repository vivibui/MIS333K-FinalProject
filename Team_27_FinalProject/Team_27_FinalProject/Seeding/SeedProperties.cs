using Team_27_FinalProject.Models;
using Team_27_FinalProject.DAL;
using System.Collections.Generic;
using System;
using System.Linq;


namespace Team_27_FinalProject.Seeding
{
	public static class SeedProperties
	{
		public static void SeedAllProperties(AppDbContext db)
		{
			if (db.Properties.Count() == 183)
			{
				throw new NotSupportedException("The database already contains all 183 properties!");
			}

			Int32 intPropertiesAdded = 0;
			String strPropertyStreet = "Begin"; //helps to keep track of error on books
			List<Property> Properties = new List<Property>();

			try
			{
				Property p1 = new Property()
				{
					Zip = 72227,
					State = "PA",
					Street = "8714 Mann Plaza",
					City = "Lisaside",
					WeekendPrice = 171.57m,
					WeekDayPrice = 152.68m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 8.88m,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 9
				};
				p1.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p1.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p1);

				Property p2 = new Property()
				{
					Zip = 05565,
					State = "FL",
					Street = "96593 White View Apt. 094",
					City = "Jonesberg",
					WeekendPrice = 148.15m,
					WeekDayPrice = 120.81m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 8.02m,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 8
				};
				p2.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p2.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p2);

				Property p3 = new Property()
				{
					Zip = 80819,
					State = "MD",
					Street = "848 Melissa Springs Suite 947",
					City = "Kellerstad",
					WeekendPrice = 132.99m,
					WeekDayPrice = 127.96m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 13.37m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 8
				};
				p3.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p3.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p3);

				Property p4 = new Property()
				{
					Zip = 79428,
					State = "ND",
					Street = "30413 Norton Isle Suite 012",
					City = "North Lisa",
					WeekendPrice = 185.35m,
					WeekDayPrice = 80.2m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 5.57m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 14
				};
				p4.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p4.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p4);

				Property p5 = new Property()
				{
					Zip = 63315,
					State = "DE",
					Street = "39916 Mitchell Crescent",
					City = "New Andrewburgh",
					WeekendPrice = 100.37m,
					WeekDayPrice = 170.25m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 18.64m,
					Bedrooms = 2,
					Bathrooms = 3,
					GuestsAllowed = 12
				};
				p5.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p5.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p5);

				Property p6 = new Property()
				{
					Zip = 24135,
					State = "NE",
					Street = "086 Mary Cliff",
					City = "North Deborah",
					WeekendPrice = 162.6m,
					WeekDayPrice = 220.24m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 10.83m,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 2
				};
				p6.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p6.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p6);

				Property p7 = new Property()
				{
					Zip = 58475,
					State = "PA",
					Street = "91634 Strong Mountains Apt. 302",
					City = "West Alyssa",
					WeekendPrice = 204.87m,
					WeekDayPrice = 213.37m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 25.04m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 9
				};
				p7.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p7.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p7);

				Property p8 = new Property()
				{
					Zip = 10865,
					State = "WA",
					Street = "6984 Price Shoals",
					City = "Erictown",
					WeekendPrice = 140.89m,
					WeekDayPrice = 159.69m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 27.13m,
					Bedrooms = 2,
					Bathrooms = 3,
					GuestsAllowed = 8
				};
				p8.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p8.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p8);

				Property p9 = new Property()
				{
					Zip = 51359,
					State = "ME",
					Street = "423 Bell Heights",
					City = "Brittanyberg",
					WeekendPrice = 295.39m,
					WeekDayPrice = 200.73m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 14.91m,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 4
				};
				p9.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p9.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p9);

				Property p10 = new Property()
				{
					Zip = 87296,
					State = "WI",
					Street = "93523 Dana Lane",
					City = "Johnsonshire",
					WeekendPrice = 110.8m,
					WeekDayPrice = 170.39m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 8.67m,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 3
				};
				p10.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p10.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p10);

				Property p11 = new Property()
				{
					Zip = 07035,
					State = "NH",
					Street = "1427 Odonnell Rapids",
					City = "North Troyport",
					WeekendPrice = 126.29m,
					WeekDayPrice = 217.15m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 26.48m,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 14
				};
				p11.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p11.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p11);

				Property p12 = new Property()
				{
					Zip = 37198,
					State = "ME",
					Street = "81206 Stewart Forest Apt. 089",
					City = "East Davidborough",
					WeekendPrice = 293.26m,
					WeekDayPrice = 205.21m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 28.74m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 8
				};
				p12.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p12.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p12);

				Property p13 = new Property()
				{
					Zip = 85034,
					State = "SD",
					Street = "76104 Marsh Crescent",
					City = "Dennishaven",
					WeekendPrice = 126.99m,
					WeekDayPrice = 123.13m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 18.73m,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 4
				};
				p13.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p13.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p13);

				Property p14 = new Property()
				{
					Zip = 60619,
					State = "SD",
					Street = "0003 Grant Lakes",
					City = "Port Karafort",
					WeekendPrice = 188.81m,
					WeekDayPrice = 89.19m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 11.98m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 14
				};
				p14.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p14.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p14);

				Property p15 = new Property()
				{
					Zip = 21978,
					State = "KY",
					Street = "236 Smith Drive Suite 555",
					City = "West Kimberlyton",
					WeekendPrice = 132.96m,
					WeekDayPrice = 198.3m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 13.96m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 11
				};
				p15.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p15.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p15);

				Property p16 = new Property()
				{
					Zip = 14742,
					State = "MT",
					Street = "6824 Timothy Garden Apt. 428",
					City = "West Richardmouth",
					WeekendPrice = 297.31m,
					WeekDayPrice = 181.5m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 10.09m,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 10
				};
				p16.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p16.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p16);

				Property p17 = new Property()
				{
					Zip = 11894,
					State = "SC",
					Street = "5517 Holly Meadow Apt. 452",
					City = "Lake Anne",
					WeekendPrice = 139.22m,
					WeekDayPrice = 134.09m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 9.75m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 1
				};
				p17.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p17.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p17);

				Property p18 = new Property()
				{
					Zip = 28976,
					State = "TX",
					Street = "30601 Hawkins Highway",
					City = "Morashire",
					WeekendPrice = 160.61m,
					WeekDayPrice = 187.65m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 7.5m,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 9
				};
				p18.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p18.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p18);

				Property p19 = new Property()
				{
					Zip = 28798,
					State = "AZ",
					Street = "49263 Wilson View Apt. 873",
					City = "South Raymondborough",
					WeekendPrice = 133.25m,
					WeekDayPrice = 206.95m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 14.04m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 5
				};
				p19.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p19.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p19);

				Property p20 = new Property()
				{
					Zip = 68819,
					State = "NE",
					Street = "76582 Vanessa Oval",
					City = "New Richard",
					WeekendPrice = 242.89m,
					WeekDayPrice = 99.54m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 6.61m,
					Bedrooms = 5,
					Bathrooms = 4,
					GuestsAllowed = 12
				};
				p20.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p20.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p20);

				Property p21 = new Property()
				{
					Zip = 50177,
					State = "FL",
					Street = "7389 Alec Squares Suite 508",
					City = "Port Jonathan",
					WeekendPrice = 165.32m,
					WeekDayPrice = 112.62m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 24.26m,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 12
				};
				p21.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p21.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p21);

				Property p22 = new Property()
				{
					Zip = 66355,
					State = "NC",
					Street = "18013 Billy Bridge Suite 522",
					City = "Schmitthaven",
					WeekendPrice = 119.02m,
					WeekDayPrice = 199.21m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 11.63m,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 2
				};
				p22.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p22.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p22);

				Property p23 = new Property()
				{
					Zip = 51431,
					State = "NJ",
					Street = "891 Bullock Ford",
					City = "Amandachester",
					WeekendPrice = 244.93m,
					WeekDayPrice = 179.05m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 21.78m,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 11
				};
				p23.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p23.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p23);

				Property p24 = new Property()
				{
					Zip = 50853,
					State = "MT",
					Street = "02489 Cook Park",
					City = "Sherriport",
					WeekendPrice = 227.35m,
					WeekDayPrice = 207.24m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 5.5m,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 6
				};
				p24.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p24.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p24);

				Property p25 = new Property()
				{
					Zip = 20341,
					State = "UT",
					Street = "23450 Timothy Divide",
					City = "Wuland",
					WeekendPrice = 278.36m,
					WeekDayPrice = 116.01m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 24.73m,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 11
				};
				p25.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p25.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p25);

				Property p26 = new Property()
				{
					Zip = 85565,
					State = "OH",
					Street = "0976 Williams Mountains Apt. 009",
					City = "Lake Mario",
					WeekendPrice = 293.42m,
					WeekDayPrice = 225.14m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 10.42m,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 7
				};
				p26.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p26.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p26);

				Property p27 = new Property()
				{
					Zip = 51884,
					State = "WY",
					Street = "1097 Santos Springs Suite 264",
					City = "New Michelleborough",
					WeekendPrice = 126.45m,
					WeekDayPrice = 70.24m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 18.69m,
					Bedrooms = 2,
					Bathrooms = 2,
					GuestsAllowed = 4
				};
				p27.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p27.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p27);

				Property p28 = new Property()
				{
					Zip = 66353,
					State = "SC",
					Street = "5100 Scott Burg",
					City = "East Clayton",
					WeekendPrice = 224.07m,
					WeekDayPrice = 186.38m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 28.24m,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 3
				};
				p28.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p28.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p28);

				Property p29 = new Property()
				{
					Zip = 57004,
					State = "NV",
					Street = "412 Snow Manors Apt. 161",
					City = "South Kimtown",
					WeekendPrice = 120.93m,
					WeekDayPrice = 112.47m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 23.28m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 9
				};
				p29.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p29.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p29);

				Property p30 = new Property()
				{
					Zip = 48447,
					State = "IN",
					Street = "5415 David Square",
					City = "West Michaeltown",
					WeekendPrice = 100.02m,
					WeekDayPrice = 214.81m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 17.78m,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 1
				};
				p30.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p30.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p30);

				Property p31 = new Property()
				{
					Zip = 62982,
					State = "DE",
					Street = "03104 Norris Rapids",
					City = "Port Donald",
					WeekendPrice = 161.6m,
					WeekDayPrice = 159.87m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 10.34m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 11
				};
				p31.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p31.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p31);

				Property p32 = new Property()
				{
					Zip = 16915,
					State = "FL",
					Street = "03557 Phillips Wells Suite 291",
					City = "New Beverlyburgh",
					WeekendPrice = 203.6m,
					WeekDayPrice = 70.55m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 5.09m,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 4
				};
				p32.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p32.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p32);

				Property p33 = new Property()
				{
					Zip = 39742,
					State = "MT",
					Street = "332 Watson Shore Apt. 290",
					City = "Millerland",
					WeekendPrice = 299.34m,
					WeekDayPrice = 176.37m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 17.38m,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 2
				};
				p33.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p33.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p33);

				Property p34 = new Property()
				{
					Zip = 54060,
					State = "MS",
					Street = "645 John Roads",
					City = "Danahaven",
					WeekendPrice = 229.98m,
					WeekDayPrice = 172.83m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 23.55m,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 14
				};
				p34.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p34.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p34);

				Property p35 = new Property()
				{
					Zip = 55774,
					State = "HI",
					Street = "3547 Stephanie Underpass Apt. 418",
					City = "Port Jacqueline",
					WeekendPrice = 143.71m,
					WeekDayPrice = 177.08m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 19.21m,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 5
				};
				p35.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p35.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p35);

				Property p36 = new Property()
				{
					Zip = 59363,
					State = "UT",
					Street = "5825 Welch Corners",
					City = "Fischerport",
					WeekendPrice = 113.86m,
					WeekDayPrice = 76.66m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 27.87m,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 10
				};
				p36.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p36.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p36);

				Property p37 = new Property()
				{
					Zip = 71770,
					State = "IN",
					Street = "41489 Roger Terrace",
					City = "Davisfort",
					WeekendPrice = 299.09m,
					WeekDayPrice = 177.37m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 23.78m,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 6
				};
				p37.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p37.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p37);

				Property p38 = new Property()
				{
					Zip = 05147,
					State = "CO",
					Street = "014 Aaron Locks Suite 714",
					City = "Justinborough",
					WeekendPrice = 158.42m,
					WeekDayPrice = 104.05m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 5.36m,
					Bedrooms = 2,
					Bathrooms = 2,
					GuestsAllowed = 5
				};
				p38.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p38.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p38);

				Property p39 = new Property()
				{
					Zip = 28062,
					State = "SC",
					Street = "8518 Pamela Track Apt. 164",
					City = "Aprilshire",
					WeekendPrice = 210.59m,
					WeekDayPrice = 199.37m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 8.83m,
					Bedrooms = 3,
					Bathrooms = 2,
					GuestsAllowed = 1
				};
				p39.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p39.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p39);

				Property p40 = new Property()
				{
					Zip = 88090,
					State = "OH",
					Street = "864 Ramos Port Apt. 211",
					City = "Moralesmouth",
					WeekendPrice = 153.69m,
					WeekDayPrice = 94.48m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 16.85m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 9
				};
				p40.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p40.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p40);

				Property p41 = new Property()
				{
					Zip = 28775,
					State = "RI",
					Street = "637 Neal Island Suite 074",
					City = "Lake Tyler",
					WeekendPrice = 196.14m,
					WeekDayPrice = 88.82m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 6.97m,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 14
				};
				p41.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p41.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p41);

				Property p42 = new Property()
				{
					Zip = 75585,
					State = "WV",
					Street = "0811 Smith Canyon Apt. 904",
					City = "Jessicabury",
					WeekendPrice = 123.22m,
					WeekDayPrice = 119.58m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 18.45m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 2
				};
				p42.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p42.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p42);

				Property p43 = new Property()
				{
					Zip = 17438,
					State = "MD",
					Street = "7562 Fisher Spur",
					City = "Hernandezberg",
					WeekendPrice = 283.77m,
					WeekDayPrice = 218.87m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 19.07m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 2
				};
				p43.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p43.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p43);

				Property p44 = new Property()
				{
					Zip = 07027,
					State = "VT",
					Street = "5667 Blair Underpass",
					City = "South Shelby",
					WeekendPrice = 239.76m,
					WeekDayPrice = 76.19m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 11.37m,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 13
				};
				p44.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p44.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p44);

				Property p45 = new Property()
				{
					Zip = 01008,
					State = "MI",
					Street = "6708 Carpenter Overpass Suite 735",
					City = "Bobbyton",
					WeekendPrice = 229.04m,
					WeekDayPrice = 161.17m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 25.01m,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 7
				};
				p45.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p45.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p45);

				Property p46 = new Property()
				{
					Zip = 60236,
					State = "ND",
					Street = "16396 Shawn Junction",
					City = "New Nicolemouth",
					WeekendPrice = 220.69m,
					WeekDayPrice = 106.06m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 11.82m,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 6
				};
				p46.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p46.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p46);

				Property p47 = new Property()
				{
					Zip = 01707,
					State = "CA",
					Street = "4486 Olson Well",
					City = "North Kevin",
					WeekendPrice = 138.96m,
					WeekDayPrice = 151.44m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 6.72m,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 10
				};
				p47.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p47.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p47);

				Property p48 = new Property()
				{
					Zip = 33233,
					State = "HI",
					Street = "67771 Christopher Courts Apt. 637",
					City = "Port Ronaldfurt",
					WeekendPrice = 134.28m,
					WeekDayPrice = 102.43m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 19.81m,
					Bedrooms = 5,
					Bathrooms = 5,
					GuestsAllowed = 2
				};
				p48.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p48.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p48);

				Property p49 = new Property()
				{
					Zip = 79756,
					State = "NY",
					Street = "5561 Bishop Turnpike",
					City = "Lake Kenneth",
					WeekendPrice = 259.87m,
					WeekDayPrice = 94.31m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 22.33m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 11
				};
				p49.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p49.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p49);

				Property p50 = new Property()
				{
					Zip = 36216,
					State = "SD",
					Street = "3019 Gerald Mall Apt. 340",
					City = "Trevinoville",
					WeekendPrice = 263.32m,
					WeekDayPrice = 151.69m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 13.27m,
					Bedrooms = 5,
					Bathrooms = 5,
					GuestsAllowed = 1
				};
				p50.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p50.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p50);

				Property p51 = new Property()
				{
					Zip = 43477,
					State = "NY",
					Street = "84331 Leonard Fort Suite 749",
					City = "East Lisa",
					WeekendPrice = 204.28m,
					WeekDayPrice = 204.04m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 11.07m,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 10
				};
				p51.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p51.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p51);

				Property p52 = new Property()
				{
					Zip = 17819,
					State = "VA",
					Street = "62281 Kathy Tunnel",
					City = "Hudsonborough",
					WeekendPrice = 224.19m,
					WeekDayPrice = 165.51m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 24.26m,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 9
				};
				p52.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p52.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p52);

				Property p53 = new Property()
				{
					Zip = 97149,
					State = "NM",
					Street = "9927 Christina Burg Suite 774",
					City = "East Angelaburgh",
					WeekendPrice = 121.74m,
					WeekDayPrice = 106.87m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 5.62m,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 6
				};
				p53.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p53.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p53);

				Property p54 = new Property()
				{
					Zip = 45480,
					State = "IA",
					Street = "142 Warner View Suite 460",
					City = "North Leslie",
					WeekendPrice = 148.76m,
					WeekDayPrice = 212.32m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 20.2m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 9
				};
				p54.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p54.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p54);

				Property p55 = new Property()
				{
					Zip = 03720,
					State = "AR",
					Street = "5240 Berry Centers",
					City = "West Andrew",
					WeekendPrice = 111.01m,
					WeekDayPrice = 164.02m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 26.21m,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 12
				};
				p55.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p55.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p55);

				Property p56 = new Property()
				{
					Zip = 85576,
					State = "HI",
					Street = "51056 Patricia Forge",
					City = "Grahamstad",
					WeekendPrice = 167.53m,
					WeekDayPrice = 117.45m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 24.75m,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 10
				};
				p56.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p56.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p56);

				Property p57 = new Property()
				{
					Zip = 92199,
					State = "VA",
					Street = "0648 Malone Port Apt. 662",
					City = "New Devonhaven",
					WeekendPrice = 176.53m,
					WeekDayPrice = 209.47m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 5.83m,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 12
				};
				p57.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p57.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p57);

				Property p58 = new Property()
				{
					Zip = 05261,
					State = "SC",
					Street = "23028 Jennifer Meadow Apt. 972",
					City = "West Matthewfurt",
					WeekendPrice = 199.1m,
					WeekDayPrice = 153.04m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 18.62m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 14
				};
				p58.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p58.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p58);

				Property p59 = new Property()
				{
					Zip = 72649,
					State = "LA",
					Street = "2738 Martin Terrace Suite 547",
					City = "Smithhaven",
					WeekendPrice = 199.22m,
					WeekDayPrice = 196.56m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 20.71m,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 11
				};
				p59.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p59.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p59);

				Property p60 = new Property()
				{
					Zip = 97488,
					State = "KY",
					Street = "984 Stephen Stravenue",
					City = "South Michaelton",
					WeekendPrice = 178.29m,
					WeekDayPrice = 117.03m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 6.47m,
					Bedrooms = 4,
					Bathrooms = 6,
					GuestsAllowed = 3
				};
				p60.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p60.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p60);

				Property p61 = new Property()
				{
					Zip = 42837,
					State = "LA",
					Street = "98522 Mathis Viaduct Apt. 909",
					City = "West Michael",
					WeekendPrice = 252.79m,
					WeekDayPrice = 133.35m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 9.15m,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 1
				};
				p61.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p61.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p61);

				Property p62 = new Property()
				{
					Zip = 56059,
					State = "OH",
					Street = "620 Ashley Mills Apt. 507",
					City = "Julieborough",
					WeekendPrice = 296.05m,
					WeekDayPrice = 171.15m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 18.26m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 9
				};
				p62.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p62.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p62);

				Property p63 = new Property()
				{
					Zip = 02288,
					State = "LA",
					Street = "212 Shelly Roads",
					City = "Fischerview",
					WeekendPrice = 163.88m,
					WeekDayPrice = 132.81m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 7.46m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 10
				};
				p63.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p63.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p63);

				Property p64 = new Property()
				{
					Zip = 50851,
					State = "OK",
					Street = "8885 Lee Tunnel Suite 208",
					City = "Port Donna",
					WeekendPrice = 140.73m,
					WeekDayPrice = 228.84m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 17.13m,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 7
				};
				p64.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p64.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p64);

				Property p65 = new Property()
				{
					Zip = 03009,
					State = "NM",
					Street = "693 Michael Estate",
					City = "Lake Michael",
					WeekendPrice = 139.83m,
					WeekDayPrice = 155.03m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 21.05m,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 13
				};
				p65.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p65.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p65);

				Property p66 = new Property()
				{
					Zip = 92905,
					State = "NY",
					Street = "342 Miller Mission",
					City = "Lake Jennifer",
					WeekendPrice = 249.24m,
					WeekDayPrice = 128.41m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 6.63m,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 1
				};
				p66.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p66.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p66);

				Property p67 = new Property()
				{
					Zip = 65056,
					State = "AK",
					Street = "71664 Kim Throughway",
					City = "Chelsealand",
					WeekendPrice = 286.53m,
					WeekDayPrice = 163.68m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 25.57m,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 9
				};
				p67.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p67.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p67);

				Property p68 = new Property()
				{
					Zip = 11181,
					State = "AZ",
					Street = "66660 Gomez Port Apt. 945",
					City = "South Thomashaven",
					WeekendPrice = 137.17m,
					WeekDayPrice = 93.86m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 28.18m,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 2
				};
				p68.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p68.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p68);

				Property p69 = new Property()
				{
					Zip = 53480,
					State = "FL",
					Street = "0131 Williams Ville Apt. 562",
					City = "Richardberg",
					WeekendPrice = 120.61m,
					WeekDayPrice = 86.25m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 11.39m,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 13
				};
				p69.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p69.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p69);

				Property p70 = new Property()
				{
					Zip = 11353,
					State = "OR",
					Street = "22708 Madison Spurs",
					City = "Herringstad",
					WeekendPrice = 241.25m,
					WeekDayPrice = 182.46m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 18.29m,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 2
				};
				p70.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p70.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p70);

				Property p71 = new Property()
				{
					Zip = 05560,
					State = "FL",
					Street = "3454 Holmes Motorway",
					City = "Port Rachel",
					WeekendPrice = 123.04m,
					WeekDayPrice = 89.88m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 19.14m,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 1
				};
				p71.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p71.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p71);

				Property p72 = new Property()
				{
					Zip = 93500,
					State = "GA",
					Street = "805 James Turnpike",
					City = "Carrmouth",
					WeekendPrice = 219.86m,
					WeekDayPrice = 81.55m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 13.38m,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 12
				};
				p72.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p72.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p72);

				Property p73 = new Property()
				{
					Zip = 44515,
					State = "NV",
					Street = "8081 Smith Trail",
					City = "North Ronaldstad",
					WeekendPrice = 196.09m,
					WeekDayPrice = 130.47m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 14.53m,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 3
				};
				p73.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p73.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p73);

				Property p74 = new Property()
				{
					Zip = 07347,
					State = "MS",
					Street = "125 Ian Crossroad Apt. 593",
					City = "South Deannaport",
					WeekendPrice = 136.82m,
					WeekDayPrice = 148.1m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 15.57m,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 4
				};
				p74.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p74.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p74);

				Property p75 = new Property()
				{
					Zip = 54532,
					State = "NH",
					Street = "1607 Munoz River",
					City = "Emilyshire",
					WeekendPrice = 209.77m,
					WeekDayPrice = 147.55m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 27.65m,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 3
				};
				p75.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p75.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p75);

				Property p76 = new Property()
				{
					Zip = 65516,
					State = "UT",
					Street = "3615 David Keys Apt. 269",
					City = "West Stephenside",
					WeekendPrice = 126.47m,
					WeekDayPrice = 86.8m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 17.6m,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 3
				};
				p76.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p76.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p76);

				Property p77 = new Property()
				{
					Zip = 20721,
					State = "AZ",
					Street = "640 Mary Common",
					City = "Michaelville",
					WeekendPrice = 173.01m,
					WeekDayPrice = 121.75m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 12.53m,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 7
				};
				p77.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p77.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p77);

				Property p78 = new Property()
				{
					Zip = 43567,
					State = "LA",
					Street = "395 Timothy Road",
					City = "Williamsbury",
					WeekendPrice = 198.1m,
					WeekDayPrice = 160.23m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 10.82m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 5
				};
				p78.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p78.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p78);

				Property p79 = new Property()
				{
					Zip = 01239,
					State = "OR",
					Street = "3267 Walter Dam",
					City = "Cunninghamtown",
					WeekendPrice = 127.7m,
					WeekDayPrice = 110.64m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 26.67m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 7
				};
				p79.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p79.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p79);

				Property p80 = new Property()
				{
					Zip = 03966,
					State = "MS",
					Street = "00580 Brandon Creek",
					City = "Port Eric",
					WeekendPrice = 236.71m,
					WeekDayPrice = 227.6m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 20.22m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 2
				};
				p80.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p80.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p80);

				Property p81 = new Property()
				{
					Zip = 29996,
					State = "MS",
					Street = "325 Amanda Cliffs Apt. 695",
					City = "South Paulabury",
					WeekendPrice = 135.59m,
					WeekDayPrice = 115.37m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 29.8m,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 13
				};
				p81.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p81.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p81);

				Property p82 = new Property()
				{
					Zip = 93980,
					State = "CT",
					Street = "40956 Amanda Walk Apt. 260",
					City = "Simonfurt",
					WeekendPrice = 271.49m,
					WeekDayPrice = 93.35m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 8.54m,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 5
				};
				p82.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p82.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p82);

				Property p83 = new Property()
				{
					Zip = 23687,
					State = "KS",
					Street = "25762 Gill Creek Suite 525",
					City = "Mccoyton",
					WeekendPrice = 247.15m,
					WeekDayPrice = 171.37m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 17.22m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 5
				};
				p83.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p83.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p83);

				Property p84 = new Property()
				{
					Zip = 04593,
					State = "GA",
					Street = "6048 Johnson Loop Suite 635",
					City = "East Daniel",
					WeekendPrice = 299.6m,
					WeekDayPrice = 95.59m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 24.3m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 8
				};
				p84.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p84.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p84);

				Property p85 = new Property()
				{
					Zip = 96954,
					State = "RI",
					Street = "1168 Gary Fords Apt. 308",
					City = "Port Trevor",
					WeekendPrice = 278.17m,
					WeekDayPrice = 194.84m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 5.88m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 11
				};
				p85.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p85.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p85);

				Property p86 = new Property()
				{
					Zip = 62271,
					State = "MS",
					Street = "164 Matthew Parkway Suite 826",
					City = "Jimmyfurt",
					WeekendPrice = 100.08m,
					WeekDayPrice = 112.03m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 28.82m,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 8
				};
				p86.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p86.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p86);

				Property p87 = new Property()
				{
					Zip = 05222,
					State = "CO",
					Street = "1220 Heidi Rue Apt. 998",
					City = "West Haleyburgh",
					WeekendPrice = 182.77m,
					WeekDayPrice = 127.97m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 13.02m,
					Bedrooms = 5,
					Bathrooms = 4,
					GuestsAllowed = 1
				};
				p87.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p87.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p87);

				Property p88 = new Property()
				{
					Zip = 22365,
					State = "SD",
					Street = "751 Wood Square Suite 732",
					City = "Port Melissaburgh",
					WeekendPrice = 186.01m,
					WeekDayPrice = 120.07m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 26.71m,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 13
				};
				p88.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p88.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p88);

				Property p89 = new Property()
				{
					Zip = 53609,
					State = "OR",
					Street = "376 Smith Dale Suite 279",
					City = "South Sarahland",
					WeekendPrice = 122.31m,
					WeekDayPrice = 137.96m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 26.29m,
					Bedrooms = 2,
					Bathrooms = 2,
					GuestsAllowed = 9
				};
				p89.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p89.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p89);

				Property p90 = new Property()
				{
					Zip = 09478,
					State = "CA",
					Street = "79148 Pierce Lock Suite 423",
					City = "Erikberg",
					WeekendPrice = 234.61m,
					WeekDayPrice = 226.57m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 16.41m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 6
				};
				p90.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p90.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p90);

				Property p91 = new Property()
				{
					Zip = 01425,
					State = "ID",
					Street = "147 Lisa Hill Apt. 512",
					City = "Port Elizabethshire",
					WeekendPrice = 145.15m,
					WeekDayPrice = 95.73m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 9.93m,
					Bedrooms = 4,
					Bathrooms = 6,
					GuestsAllowed = 10
				};
				p91.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p91.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p91);

				Property p92 = new Property()
				{
					Zip = 29941,
					State = "KY",
					Street = "971 Hansen Well Suite 103",
					City = "South Mary",
					WeekendPrice = 145.72m,
					WeekDayPrice = 161.68m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 24.36m,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 4
				};
				p92.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p92.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p92);

				Property p93 = new Property()
				{
					Zip = 47577,
					State = "WY",
					Street = "511 Berry Fork Suite 623",
					City = "Sharonfort",
					WeekendPrice = 260.18m,
					WeekDayPrice = 183.81m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 7.46m,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 3
				};
				p93.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p93.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p93);

				Property p94 = new Property()
				{
					Zip = 94134,
					State = "WI",
					Street = "65873 Chen Knolls",
					City = "Ramirezfurt",
					WeekendPrice = 117.17m,
					WeekDayPrice = 215.38m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 24.31m,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 14
				};
				p94.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p94.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p94);

				Property p95 = new Property()
				{
					Zip = 57039,
					State = "IN",
					Street = "8799 Emma Parkway Suite 735",
					City = "North Thomasfurt",
					WeekendPrice = 242.21m,
					WeekDayPrice = 145.51m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 11.89m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 11
				};
				p95.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p95.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p95);

				Property p96 = new Property()
				{
					Zip = 23718,
					State = "ND",
					Street = "30068 David View Apt. 173",
					City = "New Peggychester",
					WeekendPrice = 161.21m,
					WeekDayPrice = 142.76m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 20.92m,
					Bedrooms = 4,
					Bathrooms = 6,
					GuestsAllowed = 7
				};
				p96.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p96.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p96);

				Property p97 = new Property()
				{
					Zip = 26932,
					State = "MD",
					Street = "298 Johnathan Cove Apt. 402",
					City = "South Jamie",
					WeekendPrice = 176.37m,
					WeekDayPrice = 170.07m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 8.54m,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 13
				};
				p97.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p97.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p97);

				Property p98 = new Property()
				{
					Zip = 74554,
					State = "CO",
					Street = "171 Harrison Motorway",
					City = "Davidview",
					WeekendPrice = 234.81m,
					WeekDayPrice = 145.08m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 26.14m,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 10
				};
				p98.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p98.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p98);

				Property p99 = new Property()
				{
					Zip = 32097,
					State = "NE",
					Street = "3576 Sergio Avenue",
					City = "Benjaminmouth",
					WeekendPrice = 260.62m,
					WeekDayPrice = 111.73m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 15.89m,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 1
				};
				p99.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p99.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p99);

				Property p100 = new Property()
				{
					Zip = 21519,
					State = "RI",
					Street = "37457 Tanya Pike Apt. 348",
					City = "North Ericton",
					WeekendPrice = 214.62m,
					WeekDayPrice = 70.63m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 5.29m,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 13
				};
				p100.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p100.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p100);

				Property p101 = new Property()
				{
					Zip = 76875,
					State = "PA",
					Street = "3673 Peter Turnpike Suite 835",
					City = "New Sandra",
					WeekendPrice = 172.79m,
					WeekDayPrice = 229.03m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 14.05m,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 6
				};
				p101.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p101.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p101);

				Property p102 = new Property()
				{
					Zip = 80451,
					State = "TX",
					Street = "939 Johnson Oval Suite 830",
					City = "North Dennismouth",
					WeekendPrice = 133.53m,
					WeekDayPrice = 169.34m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 18.06m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 6
				};
				p102.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p102.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p102);

				Property p103 = new Property()
				{
					Zip = 51726,
					State = "NV",
					Street = "645 Jennings Estates",
					City = "Angelastad",
					WeekendPrice = 109.44m,
					WeekDayPrice = 155.52m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 8.28m,
					Bedrooms = 2,
					Bathrooms = 3,
					GuestsAllowed = 4
				};
				p103.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p103.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p103);

				Property p104 = new Property()
				{
					Zip = 77240,
					State = "MT",
					Street = "1231 Stephanie Lock Suite 835",
					City = "North Richardland",
					WeekendPrice = 182.33m,
					WeekDayPrice = 180.2m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 17.78m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 5
				};
				p104.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p104.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p104);

				Property p105 = new Property()
				{
					Zip = 98152,
					State = "CO",
					Street = "302 Parker Plains Apt. 197",
					City = "East Robertstad",
					WeekendPrice = 212.7m,
					WeekDayPrice = 212.86m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 6.82m,
					Bedrooms = 3,
					Bathrooms = 2,
					GuestsAllowed = 1
				};
				p105.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p105.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p105);

				Property p106 = new Property()
				{
					Zip = 98277,
					State = "MS",
					Street = "098 Hernandez Green",
					City = "New Sergiobury",
					WeekendPrice = 262.3m,
					WeekDayPrice = 188.71m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 21.88m,
					Bedrooms = 4,
					Bathrooms = 6,
					GuestsAllowed = 8
				};
				p106.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p106.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p106);

				Property p107 = new Property()
				{
					Zip = 80082,
					State = "NE",
					Street = "94102 Sims Port Suite 187",
					City = "Florestown",
					WeekendPrice = 128.05m,
					WeekDayPrice = 83.34m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 11.29m,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 8
				};
				p107.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p107.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p107);

				Property p108 = new Property()
				{
					Zip = 71531,
					State = "ND",
					Street = "01630 Baker Crescent",
					City = "Kellyborough",
					WeekendPrice = 125.27m,
					WeekDayPrice = 204.02m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 21.15m,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 4
				};
				p108.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p108.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p108);

				Property p109 = new Property()
				{
					Zip = 14157,
					State = "OK",
					Street = "70452 Forbes Courts",
					City = "Mosesland",
					WeekendPrice = 172.1m,
					WeekDayPrice = 90.98m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 18.09m,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 9
				};
				p109.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p109.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p109);

				Property p110 = new Property()
				{
					Zip = 26899,
					State = "MO",
					Street = "0835 Angela Station",
					City = "East Heather",
					WeekendPrice = 299.91m,
					WeekDayPrice = 158.64m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 23.09m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 9
				};
				p110.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p110.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p110);

				Property p111 = new Property()
				{
					Zip = 42872,
					State = "VT",
					Street = "2458 Jason Village Suite 248",
					City = "North Donnamouth",
					WeekendPrice = 189.3m,
					WeekDayPrice = 107.97m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 9.05m,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 4
				};
				p111.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p111.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p111);

				Property p112 = new Property()
				{
					Zip = 78301,
					State = "CO",
					Street = "1243 Grimes Corners",
					City = "Shawchester",
					WeekendPrice = 193.24m,
					WeekDayPrice = 214.14m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 26.1m,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 2
				};
				p112.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p112.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p112);

				Property p113 = new Property()
				{
					Zip = 34523,
					State = "DC",
					Street = "558 Williams Station",
					City = "Port Pamela",
					WeekendPrice = 192.46m,
					WeekDayPrice = 106.3m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 17.59m,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 4
				};
				p113.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p113.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p113);

				Property p114 = new Property()
				{
					Zip = 63064,
					State = "VT",
					Street = "4934 Lozano Place Suite 716",
					City = "Gavinton",
					WeekendPrice = 257.37m,
					WeekDayPrice = 116.99m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 5.63m,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 6
				};
				p114.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p114.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p114);

				Property p115 = new Property()
				{
					Zip = 35700,
					State = "LA",
					Street = "41227 Patricia Lake",
					City = "Martinezbury",
					WeekendPrice = 108.28m,
					WeekDayPrice = 203.03m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 11.35m,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 3
				};
				p115.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p115.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p115);

				Property p116 = new Property()
				{
					Zip = 55206,
					State = "VA",
					Street = "028 Harris Drive Apt. 422",
					City = "Amyburgh",
					WeekendPrice = 262.77m,
					WeekDayPrice = 163.3m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 13.74m,
					Bedrooms = 2,
					Bathrooms = 2,
					GuestsAllowed = 14
				};
				p116.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p116.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p116);

				Property p117 = new Property()
				{
					Zip = 98240,
					State = "IA",
					Street = "06268 Lewis Place Suite 121",
					City = "Port Patriciatown",
					WeekendPrice = 108.52m,
					WeekDayPrice = 156.25m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 23.66m,
					Bedrooms = 3,
					Bathrooms = 2,
					GuestsAllowed = 4
				};
				p117.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p117.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p117);

				Property p118 = new Property()
				{
					Zip = 87205,
					State = "WI",
					Street = "5641 Brenda Streets Apt. 008",
					City = "Lake Seanmouth",
					WeekendPrice = 153.42m,
					WeekDayPrice = 178.27m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 24.69m,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 12
				};
				p118.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p118.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p118);

				Property p119 = new Property()
				{
					Zip = 58221,
					State = "ME",
					Street = "92555 Shaw Spurs Suite 207",
					City = "New Randy",
					WeekendPrice = 184.92m,
					WeekDayPrice = 92.51m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 12.82m,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 13
				};
				p119.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p119.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p119);

				Property p120 = new Property()
				{
					Zip = 18885,
					State = "NY",
					Street = "559 Foster Locks Suite 933",
					City = "Robinsonhaven",
					WeekendPrice = 225.85m,
					WeekDayPrice = 224.62m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 17.9m,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 6
				};
				p120.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p120.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p120);

				Property p121 = new Property()
				{
					Zip = 00638,
					State = "WY",
					Street = "4647 Kristine Fields Suite 710",
					City = "New Dakota",
					WeekendPrice = 174.02m,
					WeekDayPrice = 112.61m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 17.48m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 10
				};
				p121.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p121.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p121);

				Property p122 = new Property()
				{
					Zip = 31451,
					State = "ME",
					Street = "92594 Emily Shoals",
					City = "North Cathyburgh",
					WeekendPrice = 119.06m,
					WeekDayPrice = 189.98m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 25.11m,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 1
				};
				p122.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p122.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p122);

				Property p123 = new Property()
				{
					Zip = 26297,
					State = "MS",
					Street = "551 Casey Squares Apt. 209",
					City = "Michaelborough",
					WeekendPrice = 114.73m,
					WeekDayPrice = 72.03m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 18.38m,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 6
				};
				p123.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p123.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p123);

				Property p124 = new Property()
				{
					Zip = 04610,
					State = "PA",
					Street = "2998 Willis Wall",
					City = "North Brian",
					WeekendPrice = 144.51m,
					WeekDayPrice = 216.21m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 10.81m,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 3
				};
				p124.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p124.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p124);

				Property p125 = new Property()
				{
					Zip = 86618,
					State = "MD",
					Street = "164 Schultz Road",
					City = "Lake Bryan",
					WeekendPrice = 233.9m,
					WeekDayPrice = 132.69m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 15.8m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 13
				};
				p125.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p125.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p125);

				Property p126 = new Property()
				{
					Zip = 80124,
					State = "GA",
					Street = "9541 Brock Estate Apt. 848",
					City = "Franklinchester",
					WeekendPrice = 285.05m,
					WeekDayPrice = 220.97m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 20.98m,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 9
				};
				p126.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p126.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p126);

				Property p127 = new Property()
				{
					Zip = 63590,
					State = "MS",
					Street = "588 Alan Rest",
					City = "Port Stephanieville",
					WeekendPrice = 180.86m,
					WeekDayPrice = 224.98m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 11.91m,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 12
				};
				p127.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p127.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p127);

				Property p128 = new Property()
				{
					Zip = 53548,
					State = "MT",
					Street = "216 Brandon Loop Apt. 096",
					City = "New Jessica",
					WeekendPrice = 239.97m,
					WeekDayPrice = 221.98m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 9.24m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 12
				};
				p128.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p128.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p128);

				Property p129 = new Property()
				{
					Zip = 35611,
					State = "LA",
					Street = "782 Dawn Radial",
					City = "Port Christopher",
					WeekendPrice = 297.25m,
					WeekDayPrice = 76.56m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 20.42m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 1
				};
				p129.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p129.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p129);

				Property p130 = new Property()
				{
					Zip = 42879,
					State = "WA",
					Street = "008 Nancy Route Suite 228",
					City = "North Stephanie",
					WeekendPrice = 129.36m,
					WeekDayPrice = 128.71m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 23.76m,
					Bedrooms = 2,
					Bathrooms = 3,
					GuestsAllowed = 3
				};
				p130.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p130.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p130);

				Property p131 = new Property()
				{
					Zip = 71569,
					State = "MO",
					Street = "115 Jon Isle Suite 788",
					City = "North Lesliefurt",
					WeekendPrice = 210.63m,
					WeekDayPrice = 114.21m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 21.08m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 9
				};
				p131.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p131.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p131);

				Property p132 = new Property()
				{
					Zip = 87566,
					State = "DE",
					Street = "132 Poole Pass Suite 212",
					City = "North Patrick",
					WeekendPrice = 280.37m,
					WeekDayPrice = 146.82m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 26.78m,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 11
				};
				p132.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p132.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p132);

				Property p133 = new Property()
				{
					Zip = 67652,
					State = "WY",
					Street = "457 Vargas Island Suite 853",
					City = "Lake Patrickstad",
					WeekendPrice = 249.39m,
					WeekDayPrice = 134.72m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 19.19m,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 1
				};
				p133.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p133.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p133);

				Property p134 = new Property()
				{
					Zip = 45184,
					State = "HI",
					Street = "1569 Amy Path",
					City = "North Ashleyton",
					WeekendPrice = 111.23m,
					WeekDayPrice = 111.6m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 13.48m,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 7
				};
				p134.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p134.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p134);

				Property p135 = new Property()
				{
					Zip = 04078,
					State = "IL",
					Street = "0375 Sandra Trace Suite 826",
					City = "Gailshire",
					WeekendPrice = 168.47m,
					WeekDayPrice = 89m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 14.93m,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 3
				};
				p135.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p135.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p135);

				Property p136 = new Property()
				{
					Zip = 50437,
					State = "MN",
					Street = "759 Good Port",
					City = "New Russell",
					WeekendPrice = 208.35m,
					WeekDayPrice = 208.64m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 7.09m,
					Bedrooms = 5,
					Bathrooms = 5,
					GuestsAllowed = 6
				};
				p136.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p136.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p136);

				Property p137 = new Property()
				{
					Zip = 34147,
					State = "WV",
					Street = "3895 Allen Junction",
					City = "West John",
					WeekendPrice = 195.41m,
					WeekDayPrice = 172.51m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 21.53m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 3
				};
				p137.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p137.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p137);

				Property p138 = new Property()
				{
					Zip = 36340,
					State = "MS",
					Street = "7329 Jacobs Station",
					City = "New Tylerborough",
					WeekendPrice = 146.12m,
					WeekDayPrice = 163.15m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 18.98m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 8
				};
				p138.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p138.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p138);

				Property p139 = new Property()
				{
					Zip = 88806,
					State = "MD",
					Street = "5003 Cassandra Estates Suite 148",
					City = "Haleychester",
					WeekendPrice = 161.49m,
					WeekDayPrice = 81.5m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 16.41m,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 9
				};
				p139.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p139.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p139);

				Property p140 = new Property()
				{
					Zip = 76853,
					State = "TN",
					Street = "10524 Parker Mall Suite 531",
					City = "Port Courtneyhaven",
					WeekendPrice = 120.73m,
					WeekDayPrice = 177.94m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 9.5m,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 13
				};
				p140.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Hotel");
				p140.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p140);

				Property p141 = new Property()
				{
					Zip = 93533,
					State = "MO",
					Street = "300 Madison Stream",
					City = "Christophershire",
					WeekendPrice = 187.08m,
					WeekDayPrice = 121.01m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 16.48m,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 6
				};
				p141.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p141.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p141);

				Property p142 = new Property()
				{
					Zip = 96763,
					State = "FL",
					Street = "4229 Derrick Wells",
					City = "West Tyler",
					WeekendPrice = 241.45m,
					WeekDayPrice = 199.68m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 25.94m,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 6
				};
				p142.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p142.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p142);

				Property p143 = new Property()
				{
					Zip = 92174,
					State = "VA",
					Street = "26239 Michael Shoals",
					City = "Gregoryview",
					WeekendPrice = 111.91m,
					WeekDayPrice = 162.01m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 14.35m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 9
				};
				p143.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p143.AppUser = db.Users.FirstOrDefault(g => g.Email == "morales@aol.com");
				Properties.Add(p143);

				Property p144 = new Property()
				{
					Zip = 88294,
					State = "IN",
					Street = "302 Joy Spring Apt. 622",
					City = "Ryanhaven",
					WeekendPrice = 163.73m,
					WeekDayPrice = 173.36m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 25.35m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 12
				};
				p144.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p144.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p144);

				Property p145 = new Property()
				{
					Zip = 23464,
					State = "CA",
					Street = "734 Craig Overpass Suite 589",
					City = "Jefferyside",
					WeekendPrice = 287.28m,
					WeekDayPrice = 216.1m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 22.2m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 8
				};
				p145.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p145.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p145);

				Property p146 = new Property()
				{
					Zip = 35243,
					State = "CA",
					Street = "272 Green Street",
					City = "Port Lacey",
					WeekendPrice = 247.34m,
					WeekDayPrice = 211.51m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 11.73m,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 7
				};
				p146.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p146.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p146);

				Property p147 = new Property()
				{
					Zip = 61935,
					State = "IL",
					Street = "8056 Dunn Trail Apt. 049",
					City = "Blackshire",
					WeekendPrice = 189.08m,
					WeekDayPrice = 111.4m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 19.58m,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 2
				};
				p147.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p147.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p147);

				Property p148 = new Property()
				{
					Zip = 72324,
					State = "CA",
					Street = "86187 Antonio Fort",
					City = "North Carmen",
					WeekendPrice = 109.87m,
					WeekDayPrice = 150.69m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 13.3m,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 7
				};
				p148.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p148.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p148);

				Property p149 = new Property()
				{
					Zip = 84393,
					State = "NJ",
					Street = "71318 Cassandra Plaza",
					City = "Burkeview",
					WeekendPrice = 227.55m,
					WeekDayPrice = 184.21m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 19.52m,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 10
				};
				p149.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p149.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p149);

				Property p150 = new Property()
				{
					Zip = 62346,
					State = "NH",
					Street = "5303 Lewis Springs",
					City = "Port Adrian",
					WeekendPrice = 207.51m,
					WeekDayPrice = 204.67m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 26.36m,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 2
				};
				p150.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p150.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p150);

				Property p151 = new Property()
				{
					Zip = 02837,
					State = "IA",
					Street = "465 Wiley Corners Apt. 759",
					City = "East Michellechester",
					WeekendPrice = 213.84m,
					WeekDayPrice = 129.14m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 12.81m,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 11
				};
				p151.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p151.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p151);

				Property p152 = new Property()
				{
					Zip = 68847,
					State = "LA",
					Street = "521 Flores Stream",
					City = "West Rebeccaborough",
					WeekendPrice = 254.37m,
					WeekDayPrice = 77.06m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 6.03m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 3
				};
				p152.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p152.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p152);

				Property p153 = new Property()
				{
					Zip = 35218,
					State = "NE",
					Street = "0271 Soto Drives Apt. 975",
					City = "New Edgar",
					WeekendPrice = 233.17m,
					WeekDayPrice = 179.91m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 11.04m,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 9
				};
				p153.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p153.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p153);

				Property p154 = new Property()
				{
					Zip = 32697,
					State = "NM",
					Street = "27862 Kent Mountains",
					City = "Lake Michaelville",
					WeekendPrice = 153.38m,
					WeekDayPrice = 90.54m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 6.91m,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 14
				};
				p154.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p154.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p154);

				Property p155 = new Property()
				{
					Zip = 95889,
					State = "OR",
					Street = "917 Mclaughlin Glens",
					City = "Martinville",
					WeekendPrice = 226.89m,
					WeekDayPrice = 225.59m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 28.99m,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 2
				};
				p155.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p155.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p155);

				Property p156 = new Property()
				{
					Zip = 82153,
					State = "KY",
					Street = "3032 Michelle Drives",
					City = "North Daniel",
					WeekendPrice = 157.15m,
					WeekDayPrice = 203.25m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 15.68m,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 13
				};
				p156.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p156.AppUser = db.Users.FirstOrDefault(g => g.Email == "rankin@yahoo.com");
				Properties.Add(p156);

				Property p157 = new Property()
				{
					Zip = 32202,
					State = "SD",
					Street = "601 Maria Mission Apt. 554",
					City = "Myerstown",
					WeekendPrice = 269.55m,
					WeekDayPrice = 223.27m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 11.35m,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 9
				};
				p157.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p157.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p157);

				Property p158 = new Property()
				{
					Zip = 17431,
					State = "OH",
					Street = "238 Shawn Well",
					City = "Port Johnshire",
					WeekendPrice = 112.64m,
					WeekDayPrice = 173.63m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 6.38m,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 14
				};
				p158.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p158.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p158);

				Property p159 = new Property()
				{
					Zip = 37901,
					State = "SC",
					Street = "41743 Berger Inlet Apt. 527",
					City = "South Tammymouth",
					WeekendPrice = 163.2m,
					WeekDayPrice = 176.23m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 14.77m,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 9
				};
				p159.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p159.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p159);

				Property p160 = new Property()
				{
					Zip = 17895,
					State = "MO",
					Street = "9983 Mary Grove Apt. 643",
					City = "Beardview",
					WeekendPrice = 209.33m,
					WeekDayPrice = 219.53m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 24.51m,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 9
				};
				p160.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p160.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p160);

				Property p161 = new Property()
				{
					Zip = 90576,
					State = "HI",
					Street = "03541 Ryan Islands Apt. 562",
					City = "East Michaelfort",
					WeekendPrice = 269.63m,
					WeekDayPrice = 126.25m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 8.27m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 10
				};
				p161.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p161.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p161);

				Property p162 = new Property()
				{
					Zip = 94980,
					State = "SC",
					Street = "6591 Angela Mission Apt. 108",
					City = "Penabury",
					WeekendPrice = 286.86m,
					WeekDayPrice = 143.98m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 20.48m,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 14
				};
				p162.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p162.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p162);

				Property p163 = new Property()
				{
					Zip = 44974,
					State = "CO",
					Street = "492 Ramirez Crossing",
					City = "Aaronberg",
					WeekendPrice = 144.6m,
					WeekDayPrice = 121.91m,
					PetsAllowed = false,
					ParkingFree = true,
					CleaningFee = 10.12m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 10
				};
				p163.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p163.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p163);

				Property p164 = new Property()
				{
					Zip = 66170,
					State = "DE",
					Street = "35974 Sharon Locks Apt. 101",
					City = "Jennyport",
					WeekendPrice = 114.46m,
					WeekDayPrice = 137.8m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 17.74m,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 1
				};
				p164.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p164.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p164);

				Property p165 = new Property()
				{
					Zip = 22495,
					State = "UT",
					Street = "89403 Gabriella Mills",
					City = "East Steven",
					WeekendPrice = 155.1m,
					WeekDayPrice = 128.63m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 23.05m,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 11
				};
				p165.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p165.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p165);

				Property p166 = new Property()
				{
					Zip = 85059,
					State = "NH",
					Street = "601 Kyle Roads",
					City = "Clarkfurt",
					WeekendPrice = 284.39m,
					WeekDayPrice = 209.11m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 6.25m,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 4
				};
				p166.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p166.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p166);

				Property p167 = new Property()
				{
					Zip = 61092,
					State = "IN",
					Street = "60969 Justin Passage Suite 774",
					City = "Joshuaburgh",
					WeekendPrice = 121m,
					WeekDayPrice = 128.59m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 19.36m,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 7
				};
				p167.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p167.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p167);

				Property p168 = new Property()
				{
					Zip = 43986,
					State = "PA",
					Street = "7943 Tina Mount",
					City = "East Lisa",
					WeekendPrice = 104.47m,
					WeekDayPrice = 122.88m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 25.31m,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 14
				};
				p168.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p168.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p168);

				Property p169 = new Property()
				{
					Zip = 91397,
					State = "NC",
					Street = "6775 James Ford",
					City = "South Victorialand",
					WeekendPrice = 275.5m,
					WeekDayPrice = 211.24m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 15.74m,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 9
				};
				p169.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p169.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p169);

				Property p170 = new Property()
				{
					Zip = 67849,
					State = "VT",
					Street = "431 Johnson Neck Suite 039",
					City = "Mariechester",
					WeekendPrice = 126.24m,
					WeekDayPrice = 124.65m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 24.3m,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 9
				};
				p170.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p170.AppUser = db.Users.FirstOrDefault(g => g.Email == "rice@yahoo.com");
				Properties.Add(p170);

				Property p171 = new Property()
				{
					Zip = 20687,
					State = "NM",
					Street = "15666 Justin Locks",
					City = "Lake Ryanport",
					WeekendPrice = 112.05m,
					WeekDayPrice = 70.11m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 27.45m,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 3
				};
				p171.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p171.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p171);

				Property p172 = new Property()
				{
					Zip = 30222,
					State = "TX",
					Street = "9947 Torres Viaduct Apt. 506",
					City = "Benjaminport",
					WeekendPrice = 152.09m,
					WeekDayPrice = 174.87m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 18.44m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 11
				};
				p172.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Apartment");
				p172.AppUser = db.Users.FirstOrDefault(g => g.Email == "ingram@gmail.com");
				Properties.Add(p172);

				Property p173 = new Property()
				{
					Zip = 21190,
					State = "NJ",
					Street = "20866 Keith Mill",
					City = "Susanton",
					WeekendPrice = 174.06m,
					WeekDayPrice = 96.8m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 28.15m,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 10
				};
				p173.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p173.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p173);

				Property p174 = new Property()
				{
					Zip = 04838,
					State = "AL",
					Street = "04374 Nicholas Cliff Suite 001",
					City = "Adrianport",
					WeekendPrice = 108.24m,
					WeekDayPrice = 205.01m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 6.56m,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 10
				};
				p174.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Condo");
				p174.AppUser = db.Users.FirstOrDefault(g => g.Email == "jacobs@yahoo.com");
				Properties.Add(p174);

				Property p175 = new Property()
				{
					Zip = 80130,
					State = "CA",
					Street = "271 Andrew Summit",
					City = "Port Craig",
					WeekendPrice = 148.39m,
					WeekDayPrice = 197.52m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 20.55m,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 7
				};
				p175.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p175.AppUser = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
				Properties.Add(p175);

				Property p176 = new Property()
				{
					Zip = 96166,
					State = "MN",
					Street = "17611 Robbins Mission",
					City = "New Curtis",
					WeekendPrice = 286.13m,
					WeekDayPrice = 219.69m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 10.64m,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 9
				};
				p176.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p176.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p176);

				Property p177 = new Property()
				{
					Zip = 40702,
					State = "MO",
					Street = "80831 Kemp Pines",
					City = "Annashire",
					WeekendPrice = 123.93m,
					WeekDayPrice = 91.26m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 19.36m,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 7
				};
				p177.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p177.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p177);

				Property p178 = new Property()
				{
					Zip = 86023,
					State = "IL",
					Street = "96545 Smith Alley",
					City = "West Joy",
					WeekendPrice = 254.38m,
					WeekDayPrice = 132.54m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 14.83m,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 7
				};
				p178.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p178.AppUser = db.Users.FirstOrDefault(g => g.Email == "martinez@aol.com");
				Properties.Add(p178);

				Property p179 = new Property()
				{
					Zip = 70897,
					State = "MT",
					Street = "6146 Johnson Isle",
					City = "South Arthur",
					WeekendPrice = 228.04m,
					WeekDayPrice = 227.96m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 6.99m,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 1
				};
				p179.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p179.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p179);

				Property p180 = new Property()
				{
					Zip = 69154,
					State = "MN",
					Street = "0415 Smith Springs",
					City = "Jeremyburgh",
					WeekendPrice = 228.81m,
					WeekDayPrice = 140.93m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 29.74m,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 3
				};
				p180.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p180.AppUser = db.Users.FirstOrDefault(g => g.Email == "loter@yahoo.com");
				Properties.Add(p180);

				Property p181 = new Property()
				{
					Zip = 53524,
					State = "HI",
					Street = "3999 Ricky Via",
					City = "West Adamburgh",
					WeekendPrice = 255.43m,
					WeekDayPrice = 137.35m,
					PetsAllowed = true,
					ParkingFree = true,
					CleaningFee = 16.62m,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 6
				};
				p181.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
				p181.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p181);

				Property p182 = new Property()
				{
					Zip = 24886,
					State = "MN",
					Street = "83787 Stuart Key",
					City = "Davetown",
					WeekendPrice = 146.75m,
					WeekDayPrice = 172.99m,
					PetsAllowed = true,
					ParkingFree = false,
					CleaningFee = 26.24m,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 4
				};
				p182.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p182.AppUser = db.Users.FirstOrDefault(g => g.Email == "chung@yahoo.com");
				Properties.Add(p182);

				Property p183 = new Property()
				{
					Zip = 56713,
					State = "TX",
					Street = "690 Christina Park",
					City = "Toddburgh",
					WeekendPrice = 157.96m,
					WeekDayPrice = 188.53m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 6.69m,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 1
				};
				p183.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "Cabin");
				p183.AppUser = db.Users.FirstOrDefault(g => g.Email == "tanner@utexas.edu");
				Properties.Add(p183);

				try
				{
					foreach (Property propertyToAdd in Properties)
					{
						strPropertyStreet = propertyToAdd.Street;
						Property dbProperty = db.Properties.FirstOrDefault(b => b.Street == propertyToAdd.Street);
						if (dbProperty == null) //this title doesn't exist
						{
							db.Properties.Add(propertyToAdd);
							db.SaveChanges();
							intPropertiesAdded += 1;
						}
						else //property exists - update values
						{
							dbProperty.Zip = propertyToAdd.Zip;
							dbProperty.State = propertyToAdd.State;
							dbProperty.Street = propertyToAdd.Street;
							dbProperty.City = propertyToAdd.City;
							dbProperty.WeekendPrice = propertyToAdd.WeekendPrice;
							dbProperty.WeekDayPrice = propertyToAdd.WeekDayPrice;
							dbProperty.Category = propertyToAdd.Category;
							dbProperty.PetsAllowed = propertyToAdd.PetsAllowed;
							dbProperty.ParkingFree = propertyToAdd.ParkingFree;
							dbProperty.CleaningFee = propertyToAdd.CleaningFee;
							dbProperty.Bedrooms = propertyToAdd.Bedrooms;
							dbProperty.Bathrooms = propertyToAdd.Bathrooms;
							dbProperty.GuestsAllowed = propertyToAdd.GuestsAllowed;
							db.Update(dbProperty);
							db.SaveChanges();
							intPropertiesAdded += 1;
						}
					}
				}
				catch (Exception ex)
				{
					String msg = "  Repositories added:" + intPropertiesAdded + "; Error on " + strPropertyStreet;
					throw new InvalidOperationException(ex.Message + msg);
				}
			}
			catch (Exception e)
			{
				throw new InvalidOperationException(e.Message);
			}
		}
	}
}
