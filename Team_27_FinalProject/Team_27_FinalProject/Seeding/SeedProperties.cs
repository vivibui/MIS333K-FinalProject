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
				Property = new Property()
				{
					Zip = 72227,
					State = "PA",
					Street = "8714 Mann Plaza",
					City = "Lisaside",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 171.57m,
					WeekDayPrice = 152.68m,
					PetsAllowed = false,
					ParkingFree = false,
					CleaningFee = 8.88,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 05565,
					State = "FL",
					Street = "96593 White View Apt. 094",
					City = "Jonesberg",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 148.15m,
					WeekDayPrice = 120.81m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 8.02,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 80819,
					State = "MD",
					Street = "848 Melissa Springs Suite 947",
					City = "Kellerstad",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 132.99m,
					WeekDayPrice = 127.96m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 13.37,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 79428,
					State = "ND",
					Street = "30413 Norton Isle Suite 012",
					City = "North Lisa",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 185.35m,
					WeekDayPrice = 80.2m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 5.57,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 63315,
					State = "DE",
					Street = "39916 Mitchell Crescent",
					City = "New Andrewburgh",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 100.37m,
					WeekDayPrice = 170.25m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 18.64,
					Bedrooms = 2,
					Bathrooms = 3,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 24135,
					State = "NE",
					Street = "086 Mary Cliff",
					City = "North Deborah",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 162.6m,
					WeekDayPrice = 220.24m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 10.83,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 58475,
					State = "PA",
					Street = "91634 Strong Mountains Apt. 302",
					City = "West Alyssa",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 204.87m,
					WeekDayPrice = 213.37m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 25.04,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 10865,
					State = "WA",
					Street = "6984 Price Shoals",
					City = "Erictown",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 140.89m,
					WeekDayPrice = 159.69m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 27.13,
					Bedrooms = 2,
					Bathrooms = 3,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 51359,
					State = "ME",
					Street = "423 Bell Heights",
					City = "Brittanyberg",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 295.39m,
					WeekDayPrice = 200.73m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 14.91,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 87296,
					State = "WI",
					Street = "93523 Dana Lane",
					City = "Johnsonshire",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 110.8m,
					WeekDayPrice = 170.39m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 8.67,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 07035,
					State = "NH",
					Street = "1427 Odonnell Rapids",
					City = "North Troyport",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 126.29m,
					WeekDayPrice = 217.15m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 26.48,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 37198,
					State = "ME",
					Street = "81206 Stewart Forest Apt. 089",
					City = "East Davidborough",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 293.26m,
					WeekDayPrice = 205.21m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 28.74,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 85034,
					State = "SD",
					Street = "76104 Marsh Crescent",
					City = "Dennishaven",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 126.99m,
					WeekDayPrice = 123.13m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 18.73,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 60619,
					State = "SD",
					Street = "0003 Grant Lakes",
					City = "Port Karafort",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 188.81m,
					WeekDayPrice = 89.19m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 11.98,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 21978,
					State = "KY",
					Street = "236 Smith Drive Suite 555",
					City = "West Kimberlyton",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 132.96m,
					WeekDayPrice = 198.3m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 13.96,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 14742,
					State = "MT",
					Street = "6824 Timothy Garden Apt. 428",
					City = "West Richardmouth",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 297.31m,
					WeekDayPrice = 181.5m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 10.09,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 11894,
					State = "SC",
					Street = "5517 Holly Meadow Apt. 452",
					City = "Lake Anne",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 139.22m,
					WeekDayPrice = 134.09m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 9.75,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 28976,
					State = "TX",
					Street = "30601 Hawkins Highway",
					City = "Morashire",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 160.61m,
					WeekDayPrice = 187.65m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 7.5,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 28798,
					State = "AZ",
					Street = "49263 Wilson View Apt. 873",
					City = "South Raymondborough",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 133.25m,
					WeekDayPrice = 206.95m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 14.04,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 5,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 68819,
					State = "NE",
					Street = "76582 Vanessa Oval",
					City = "New Richard",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 242.89m,
					WeekDayPrice = 99.54m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 6.61,
					Bedrooms = 5,
					Bathrooms = 4,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 50177,
					State = "FL",
					Street = "7389 Alec Squares Suite 508",
					City = "Port Jonathan",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 165.32m,
					WeekDayPrice = 112.62m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 24.26,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 66355,
					State = "NC",
					Street = "18013 Billy Bridge Suite 522",
					City = "Schmitthaven",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 119.02m,
					WeekDayPrice = 199.21m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 11.63,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 51431,
					State = "NJ",
					Street = "891 Bullock Ford",
					City = "Amandachester",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 244.93m,
					WeekDayPrice = 179.05m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 21.78,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 50853,
					State = "MT",
					Street = "02489 Cook Park",
					City = "Sherriport",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 227.35m,
					WeekDayPrice = 207.24m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 5.5,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 20341,
					State = "UT",
					Street = "23450 Timothy Divide",
					City = "Wuland",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 278.36m,
					WeekDayPrice = 116.01m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 24.73,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 85565,
					State = "OH",
					Street = "0976 Williams Mountains Apt. 009",
					City = "Lake Mario",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 293.42m,
					WeekDayPrice = 225.14m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 10.42,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 51884,
					State = "WY",
					Street = "1097 Santos Springs Suite 264",
					City = "New Michelleborough",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 126.45m,
					WeekDayPrice = 70.24m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 18.69,
					Bedrooms = 2,
					Bathrooms = 2,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 66353,
					State = "SC",
					Street = "5100 Scott Burg",
					City = "East Clayton",
					HostEmail = "morales@aol.com",
					WeekendPrice = 224.07m,
					WeekDayPrice = 186.38m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 28.24,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 57004,
					State = "NV",
					Street = "412 Snow Manors Apt. 161",
					City = "South Kimtown",
					HostEmail = "morales@aol.com",
					WeekendPrice = 120.93m,
					WeekDayPrice = 112.47m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 23.28,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 48447,
					State = "IN",
					Street = "5415 David Square",
					City = "West Michaeltown",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 100.02m,
					WeekDayPrice = 214.81m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 17.78,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 62982,
					State = "DE",
					Street = "03104 Norris Rapids",
					City = "Port Donald",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 161.6m,
					WeekDayPrice = 159.87m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 10.34,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 16915,
					State = "FL",
					Street = "03557 Phillips Wells Suite 291",
					City = "New Beverlyburgh",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 203.6m,
					WeekDayPrice = 70.55m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 5.09,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 39742,
					State = "MT",
					Street = "332 Watson Shore Apt. 290",
					City = "Millerland",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 299.34m,
					WeekDayPrice = 176.37m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 17.38,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 54060,
					State = "MS",
					Street = "645 John Roads",
					City = "Danahaven",
					HostEmail = "morales@aol.com",
					WeekendPrice = 229.98m,
					WeekDayPrice = 172.83m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 23.55,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 55774,
					State = "HI",
					Street = "3547 Stephanie Underpass Apt. 418",
					City = "Port Jacqueline",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 143.71m,
					WeekDayPrice = 177.08m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 19.21,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 5,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 59363,
					State = "UT",
					Street = "5825 Welch Corners",
					City = "Fischerport",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 113.86m,
					WeekDayPrice = 76.66m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 27.87,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 71770,
					State = "IN",
					Street = "41489 Roger Terrace",
					City = "Davisfort",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 299.09m,
					WeekDayPrice = 177.37m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 23.78,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 05147,
					State = "CO",
					Street = "014 Aaron Locks Suite 714",
					City = "Justinborough",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 158.42m,
					WeekDayPrice = 104.05m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 5.36,
					Bedrooms = 2,
					Bathrooms = 2,
					GuestsAllowed = 5,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 28062,
					State = "SC",
					Street = "8518 Pamela Track Apt. 164",
					City = "Aprilshire",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 210.59m,
					WeekDayPrice = 199.37m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 8.83,
					Bedrooms = 3,
					Bathrooms = 2,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 88090,
					State = "OH",
					Street = "864 Ramos Port Apt. 211",
					City = "Moralesmouth",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 153.69m,
					WeekDayPrice = 94.48m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 16.85,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 28775,
					State = "RI",
					Street = "637 Neal Island Suite 074",
					City = "Lake Tyler",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 196.14m,
					WeekDayPrice = 88.82m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 6.97,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 75585,
					State = "WV",
					Street = "0811 Smith Canyon Apt. 904",
					City = "Jessicabury",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 123.22m,
					WeekDayPrice = 119.58m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 18.45,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 17438,
					State = "MD",
					Street = "7562 Fisher Spur",
					City = "Hernandezberg",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 283.77m,
					WeekDayPrice = 218.87m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 19.07,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 07027,
					State = "VT",
					Street = "5667 Blair Underpass",
					City = "South Shelby",
					HostEmail = "morales@aol.com",
					WeekendPrice = 239.76m,
					WeekDayPrice = 76.19m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 11.37,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 01008,
					State = "MI",
					Street = "6708 Carpenter Overpass Suite 735",
					City = "Bobbyton",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 229.04m,
					WeekDayPrice = 161.17m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 25.01,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 60236,
					State = "ND",
					Street = "16396 Shawn Junction",
					City = "New Nicolemouth",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 220.69m,
					WeekDayPrice = 106.06m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 11.82,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 01707,
					State = "CA",
					Street = "4486 Olson Well",
					City = "North Kevin",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 138.96m,
					WeekDayPrice = 151.44m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 6.72,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 33233,
					State = "HI",
					Street = "67771 Christopher Courts Apt. 637",
					City = "Port Ronaldfurt",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 134.28m,
					WeekDayPrice = 102.43m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 19.81,
					Bedrooms = 5,
					Bathrooms = 5,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 79756,
					State = "NY",
					Street = "5561 Bishop Turnpike",
					City = "Lake Kenneth",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 259.87m,
					WeekDayPrice = 94.31m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 22.33,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 36216,
					State = "SD",
					Street = "3019 Gerald Mall Apt. 340",
					City = "Trevinoville",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 263.32m,
					WeekDayPrice = 151.69m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 13.27,
					Bedrooms = 5,
					Bathrooms = 5,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 43477,
					State = "NY",
					Street = "84331 Leonard Fort Suite 749",
					City = "East Lisa",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 204.28m,
					WeekDayPrice = 204.04m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 11.07,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 17819,
					State = "VA",
					Street = "62281 Kathy Tunnel",
					City = "Hudsonborough",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 224.19m,
					WeekDayPrice = 165.51m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 24.26,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 97149,
					State = "NM",
					Street = "9927 Christina Burg Suite 774",
					City = "East Angelaburgh",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 121.74m,
					WeekDayPrice = 106.87m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 5.62,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 45480,
					State = "IA",
					Street = "142 Warner View Suite 460",
					City = "North Leslie",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 148.76m,
					WeekDayPrice = 212.32m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 20.2,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 03720,
					State = "AR",
					Street = "5240 Berry Centers",
					City = "West Andrew",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 111.01m,
					WeekDayPrice = 164.02m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 26.21,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 85576,
					State = "HI",
					Street = "51056 Patricia Forge",
					City = "Grahamstad",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 167.53m,
					WeekDayPrice = 117.45m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 24.75,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 92199,
					State = "VA",
					Street = "0648 Malone Port Apt. 662",
					City = "New Devonhaven",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 176.53m,
					WeekDayPrice = 209.47m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 5.83,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 05261,
					State = "SC",
					Street = "23028 Jennifer Meadow Apt. 972",
					City = "West Matthewfurt",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 199.1m,
					WeekDayPrice = 153.04m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 18.62,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 72649,
					State = "LA",
					Street = "2738 Martin Terrace Suite 547",
					City = "Smithhaven",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 199.22m,
					WeekDayPrice = 196.56m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 20.71,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 97488,
					State = "KY",
					Street = "984 Stephen Stravenue",
					City = "South Michaelton",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 178.29m,
					WeekDayPrice = 117.03m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 6.47,
					Bedrooms = 4,
					Bathrooms = 6,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 42837,
					State = "LA",
					Street = "98522 Mathis Viaduct Apt. 909",
					City = "West Michael",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 252.79m,
					WeekDayPrice = 133.35m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 9.15,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 56059,
					State = "OH",
					Street = "620 Ashley Mills Apt. 507",
					City = "Julieborough",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 296.05m,
					WeekDayPrice = 171.15m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 18.26,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 02288,
					State = "LA",
					Street = "212 Shelly Roads",
					City = "Fischerview",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 163.88m,
					WeekDayPrice = 132.81m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 7.46,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 50851,
					State = "OK",
					Street = "8885 Lee Tunnel Suite 208",
					City = "Port Donna",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 140.73m,
					WeekDayPrice = 228.84m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 17.13,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 03009,
					State = "NM",
					Street = "693 Michael Estate",
					City = "Lake Michael",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 139.83m,
					WeekDayPrice = 155.03m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 21.05,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 92905,
					State = "NY",
					Street = "342 Miller Mission",
					City = "Lake Jennifer",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 249.24m,
					WeekDayPrice = 128.41m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 6.63,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 65056,
					State = "AK",
					Street = "71664 Kim Throughway",
					City = "Chelsealand",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 286.53m,
					WeekDayPrice = 163.68m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 25.57,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 11181,
					State = "AZ",
					Street = "66660 Gomez Port Apt. 945",
					City = "South Thomashaven",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 137.17m,
					WeekDayPrice = 93.86m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 28.18,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 53480,
					State = "FL",
					Street = "0131 Williams Ville Apt. 562",
					City = "Richardberg",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 120.61m,
					WeekDayPrice = 86.25m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 11.39,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 11353,
					State = "OR",
					Street = "22708 Madison Spurs",
					City = "Herringstad",
					HostEmail = "morales@aol.com",
					WeekendPrice = 241.25m,
					WeekDayPrice = 182.46m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 18.29,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 05560,
					State = "FL",
					Street = "3454 Holmes Motorway",
					City = "Port Rachel",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 123.04m,
					WeekDayPrice = 89.88m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 19.14,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 93500,
					State = "GA",
					Street = "805 James Turnpike",
					City = "Carrmouth",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 219.86m,
					WeekDayPrice = 81.55m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 13.38,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 44515,
					State = "NV",
					Street = "8081 Smith Trail",
					City = "North Ronaldstad",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 196.09m,
					WeekDayPrice = 130.47m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 14.53,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 07347,
					State = "MS",
					Street = "125 Ian Crossroad Apt. 593",
					City = "South Deannaport",
					HostEmail = "morales@aol.com",
					WeekendPrice = 136.82m,
					WeekDayPrice = 148.1m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 15.57,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 54532,
					State = "NH",
					Street = "1607 Munoz River",
					City = "Emilyshire",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 209.77m,
					WeekDayPrice = 147.55m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 27.65,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 65516,
					State = "UT",
					Street = "3615 David Keys Apt. 269",
					City = "West Stephenside",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 126.47m,
					WeekDayPrice = 86.8m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 17.6,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 20721,
					State = "AZ",
					Street = "640 Mary Common",
					City = "Michaelville",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 173.01m,
					WeekDayPrice = 121.75m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 12.53,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 43567,
					State = "LA",
					Street = "395 Timothy Road",
					City = "Williamsbury",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 198.1m,
					WeekDayPrice = 160.23m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 10.82,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 5,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 01239,
					State = "OR",
					Street = "3267 Walter Dam",
					City = "Cunninghamtown",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 127.7m,
					WeekDayPrice = 110.64m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 26.67,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 03966,
					State = "MS",
					Street = "00580 Brandon Creek",
					City = "Port Eric",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 236.71m,
					WeekDayPrice = 227.6m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 20.22,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 29996,
					State = "MS",
					Street = "325 Amanda Cliffs Apt. 695",
					City = "South Paulabury",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 135.59m,
					WeekDayPrice = 115.37m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 29.8,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 93980,
					State = "CT",
					Street = "40956 Amanda Walk Apt. 260",
					City = "Simonfurt",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 271.49m,
					WeekDayPrice = 93.35m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 8.54,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 5,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 23687,
					State = "KS",
					Street = "25762 Gill Creek Suite 525",
					City = "Mccoyton",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 247.15m,
					WeekDayPrice = 171.37m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 17.22,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 5,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 04593,
					State = "GA",
					Street = "6048 Johnson Loop Suite 635",
					City = "East Daniel",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 299.6m,
					WeekDayPrice = 95.59m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 24.3,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 96954,
					State = "RI",
					Street = "1168 Gary Fords Apt. 308",
					City = "Port Trevor",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 278.17m,
					WeekDayPrice = 194.84m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 5.88,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 62271,
					State = "MS",
					Street = "164 Matthew Parkway Suite 826",
					City = "Jimmyfurt",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 100.08m,
					WeekDayPrice = 112.03m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 28.82,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 05222,
					State = "CO",
					Street = "1220 Heidi Rue Apt. 998",
					City = "West Haleyburgh",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 182.77m,
					WeekDayPrice = 127.97m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 13.02,
					Bedrooms = 5,
					Bathrooms = 4,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 22365,
					State = "SD",
					Street = "751 Wood Square Suite 732",
					City = "Port Melissaburgh",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 186.01m,
					WeekDayPrice = 120.07m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 26.71,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 53609,
					State = "OR",
					Street = "376 Smith Dale Suite 279",
					City = "South Sarahland",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 122.31m,
					WeekDayPrice = 137.96m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 26.29,
					Bedrooms = 2,
					Bathrooms = 2,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 09478,
					State = "CA",
					Street = "79148 Pierce Lock Suite 423",
					City = "Erikberg",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 234.61m,
					WeekDayPrice = 226.57m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 16.41,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 01425,
					State = "ID",
					Street = "147 Lisa Hill Apt. 512",
					City = "Port Elizabethshire",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 145.15m,
					WeekDayPrice = 95.73m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 9.93,
					Bedrooms = 4,
					Bathrooms = 6,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 29941,
					State = "KY",
					Street = "971 Hansen Well Suite 103",
					City = "South Mary",
					HostEmail = "morales@aol.com",
					WeekendPrice = 145.72m,
					WeekDayPrice = 161.68m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 24.36,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 47577,
					State = "WY",
					Street = "511 Berry Fork Suite 623",
					City = "Sharonfort",
					HostEmail = "morales@aol.com",
					WeekendPrice = 260.18m,
					WeekDayPrice = 183.81m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 7.46,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 94134,
					State = "WI",
					Street = "65873 Chen Knolls",
					City = "Ramirezfurt",
					HostEmail = "morales@aol.com",
					WeekendPrice = 117.17m,
					WeekDayPrice = 215.38m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 24.31,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 57039,
					State = "IN",
					Street = "8799 Emma Parkway Suite 735",
					City = "North Thomasfurt",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 242.21m,
					WeekDayPrice = 145.51m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 11.89,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 23718,
					State = "ND",
					Street = "30068 David View Apt. 173",
					City = "New Peggychester",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 161.21m,
					WeekDayPrice = 142.76m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 20.92,
					Bedrooms = 4,
					Bathrooms = 6,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 26932,
					State = "MD",
					Street = "298 Johnathan Cove Apt. 402",
					City = "South Jamie",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 176.37m,
					WeekDayPrice = 170.07m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 8.54,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 74554,
					State = "CO",
					Street = "171 Harrison Motorway",
					City = "Davidview",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 234.81m,
					WeekDayPrice = 145.08m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 26.14,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 32097,
					State = "NE",
					Street = "3576 Sergio Avenue",
					City = "Benjaminmouth",
					HostEmail = "morales@aol.com",
					WeekendPrice = 260.62m,
					WeekDayPrice = 111.73m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 15.89,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 21519,
					State = "RI",
					Street = "37457 Tanya Pike Apt. 348",
					City = "North Ericton",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 214.62m,
					WeekDayPrice = 70.63m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 5.29,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 76875,
					State = "PA",
					Street = "3673 Peter Turnpike Suite 835",
					City = "New Sandra",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 172.79m,
					WeekDayPrice = 229.03m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 14.05,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 80451,
					State = "TX",
					Street = "939 Johnson Oval Suite 830",
					City = "North Dennismouth",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 133.53m,
					WeekDayPrice = 169.34m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 18.06,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 51726,
					State = "NV",
					Street = "645 Jennings Estates",
					City = "Angelastad",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 109.44m,
					WeekDayPrice = 155.52m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 8.28,
					Bedrooms = 2,
					Bathrooms = 3,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 77240,
					State = "MT",
					Street = "1231 Stephanie Lock Suite 835",
					City = "North Richardland",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 182.33m,
					WeekDayPrice = 180.2m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 17.78,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 5,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 98152,
					State = "CO",
					Street = "302 Parker Plains Apt. 197",
					City = "East Robertstad",
					HostEmail = "morales@aol.com",
					WeekendPrice = 212.7m,
					WeekDayPrice = 212.86m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 6.82,
					Bedrooms = 3,
					Bathrooms = 2,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 98277,
					State = "MS",
					Street = "098 Hernandez Green",
					City = "New Sergiobury",
					HostEmail = "morales@aol.com",
					WeekendPrice = 262.3m,
					WeekDayPrice = 188.71m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 21.88,
					Bedrooms = 4,
					Bathrooms = 6,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 80082,
					State = "NE",
					Street = "94102 Sims Port Suite 187",
					City = "Florestown",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 128.05m,
					WeekDayPrice = 83.34m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 11.29,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 71531,
					State = "ND",
					Street = "01630 Baker Crescent",
					City = "Kellyborough",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 125.27m,
					WeekDayPrice = 204.02m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 21.15,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 14157,
					State = "OK",
					Street = "70452 Forbes Courts",
					City = "Mosesland",
					HostEmail = "morales@aol.com",
					WeekendPrice = 172.1m,
					WeekDayPrice = 90.98m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 18.09,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 26899,
					State = "MO",
					Street = "0835 Angela Station",
					City = "East Heather",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 299.91m,
					WeekDayPrice = 158.64m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 23.09,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 42872,
					State = "VT",
					Street = "2458 Jason Village Suite 248",
					City = "North Donnamouth",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 189.3m,
					WeekDayPrice = 107.97m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 9.05,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 78301,
					State = "CO",
					Street = "1243 Grimes Corners",
					City = "Shawchester",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 193.24m,
					WeekDayPrice = 214.14m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 26.1,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 34523,
					State = "DC",
					Street = "558 Williams Station",
					City = "Port Pamela",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 192.46m,
					WeekDayPrice = 106.3m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 17.59,
					Bedrooms = 6,
					Bathrooms = 7,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 63064,
					State = "VT",
					Street = "4934 Lozano Place Suite 716",
					City = "Gavinton",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 257.37m,
					WeekDayPrice = 116.99m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 5.63,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 35700,
					State = "LA",
					Street = "41227 Patricia Lake",
					City = "Martinezbury",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 108.28m,
					WeekDayPrice = 203.03m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 11.35,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 55206,
					State = "VA",
					Street = "028 Harris Drive Apt. 422",
					City = "Amyburgh",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 262.77m,
					WeekDayPrice = 163.3m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 13.74,
					Bedrooms = 2,
					Bathrooms = 2,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 98240,
					State = "IA",
					Street = "06268 Lewis Place Suite 121",
					City = "Port Patriciatown",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 108.52m,
					WeekDayPrice = 156.25m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 23.66,
					Bedrooms = 3,
					Bathrooms = 2,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 87205,
					State = "WI",
					Street = "5641 Brenda Streets Apt. 008",
					City = "Lake Seanmouth",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 153.42m,
					WeekDayPrice = 178.27m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 24.69,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 58221,
					State = "ME",
					Street = "92555 Shaw Spurs Suite 207",
					City = "New Randy",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 184.92m,
					WeekDayPrice = 92.51m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 12.82,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 18885,
					State = "NY",
					Street = "559 Foster Locks Suite 933",
					City = "Robinsonhaven",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 225.85m,
					WeekDayPrice = 224.62m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 17.9,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 00638,
					State = "WY",
					Street = "4647 Kristine Fields Suite 710",
					City = "New Dakota",
					HostEmail = "morales@aol.com",
					WeekendPrice = 174.02m,
					WeekDayPrice = 112.61m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 17.48,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 31451,
					State = "ME",
					Street = "92594 Emily Shoals",
					City = "North Cathyburgh",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 119.06m,
					WeekDayPrice = 189.98m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 25.11,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 26297,
					State = "MS",
					Street = "551 Casey Squares Apt. 209",
					City = "Michaelborough",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 114.73m,
					WeekDayPrice = 72.03m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 18.38,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 04610,
					State = "PA",
					Street = "2998 Willis Wall",
					City = "North Brian",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 144.51m,
					WeekDayPrice = 216.21m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 10.81,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 86618,
					State = "MD",
					Street = "164 Schultz Road",
					City = "Lake Bryan",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 233.9m,
					WeekDayPrice = 132.69m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 15.8,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 80124,
					State = "GA",
					Street = "9541 Brock Estate Apt. 848",
					City = "Franklinchester",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 285.05m,
					WeekDayPrice = 220.97m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 20.98,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 63590,
					State = "MS",
					Street = "588 Alan Rest",
					City = "Port Stephanieville",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 180.86m,
					WeekDayPrice = 224.98m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 11.91,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 53548,
					State = "MT",
					Street = "216 Brandon Loop Apt. 096",
					City = "New Jessica",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 239.97m,
					WeekDayPrice = 221.98m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 9.24,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 35611,
					State = "LA",
					Street = "782 Dawn Radial",
					City = "Port Christopher",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 297.25m,
					WeekDayPrice = 76.56m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 20.42,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 42879,
					State = "WA",
					Street = "008 Nancy Route Suite 228",
					City = "North Stephanie",
					HostEmail = "morales@aol.com",
					WeekendPrice = 129.36m,
					WeekDayPrice = 128.71m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 23.76,
					Bedrooms = 2,
					Bathrooms = 3,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 71569,
					State = "MO",
					Street = "115 Jon Isle Suite 788",
					City = "North Lesliefurt",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 210.63m,
					WeekDayPrice = 114.21m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 21.08,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 87566,
					State = "DE",
					Street = "132 Poole Pass Suite 212",
					City = "North Patrick",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 280.37m,
					WeekDayPrice = 146.82m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 26.78,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 67652,
					State = "WY",
					Street = "457 Vargas Island Suite 853",
					City = "Lake Patrickstad",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 249.39m,
					WeekDayPrice = 134.72m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 19.19,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 45184,
					State = "HI",
					Street = "1569 Amy Path",
					City = "North Ashleyton",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 111.23m,
					WeekDayPrice = 111.6m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 13.48,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 04078,
					State = "IL",
					Street = "0375 Sandra Trace Suite 826",
					City = "Gailshire",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 168.47m,
					WeekDayPrice = 89m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 14.93,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 50437,
					State = "MN",
					Street = "759 Good Port",
					City = "New Russell",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 208.35m,
					WeekDayPrice = 208.64m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 7.09,
					Bedrooms = 5,
					Bathrooms = 5,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 34147,
					State = "WV",
					Street = "3895 Allen Junction",
					City = "West John",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 195.41m,
					WeekDayPrice = 172.51m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 21.53,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 36340,
					State = "MS",
					Street = "7329 Jacobs Station",
					City = "New Tylerborough",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 146.12m,
					WeekDayPrice = 163.15m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 18.98,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 88806,
					State = "MD",
					Street = "5003 Cassandra Estates Suite 148",
					City = "Haleychester",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 161.49m,
					WeekDayPrice = 81.5m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 16.41,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 76853,
					State = "TN",
					Street = "10524 Parker Mall Suite 531",
					City = "Port Courtneyhaven",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 120.73m,
					WeekDayPrice = 177.94m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 9.5,
					Bedrooms = 5,
					Bathrooms = 7,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Hotel");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 93533,
					State = "MO",
					Street = "300 Madison Stream",
					City = "Christophershire",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 187.08m,
					WeekDayPrice = 121.01m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 16.48,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 96763,
					State = "FL",
					Street = "4229 Derrick Wells",
					City = "West Tyler",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 241.45m,
					WeekDayPrice = 199.68m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 25.94,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 92174,
					State = "VA",
					Street = "26239 Michael Shoals",
					City = "Gregoryview",
					HostEmail = "morales@aol.com",
					WeekendPrice = 111.91m,
					WeekDayPrice = 162.01m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 14.35,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 88294,
					State = "IN",
					Street = "302 Joy Spring Apt. 622",
					City = "Ryanhaven",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 163.73m,
					WeekDayPrice = 173.36m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 25.35,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 12,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 23464,
					State = "CA",
					Street = "734 Craig Overpass Suite 589",
					City = "Jefferyside",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 287.28m,
					WeekDayPrice = 216.1m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 22.2,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 8,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 35243,
					State = "CA",
					Street = "272 Green Street",
					City = "Port Lacey",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 247.34m,
					WeekDayPrice = 211.51m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 11.73,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 61935,
					State = "IL",
					Street = "8056 Dunn Trail Apt. 049",
					City = "Blackshire",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 189.08m,
					WeekDayPrice = 111.4m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 19.58,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 72324,
					State = "CA",
					Street = "86187 Antonio Fort",
					City = "North Carmen",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 109.87m,
					WeekDayPrice = 150.69m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 13.3,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 84393,
					State = "NJ",
					Street = "71318 Cassandra Plaza",
					City = "Burkeview",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 227.55m,
					WeekDayPrice = 184.21m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 19.52,
					Bedrooms = 7,
					Bathrooms = 7,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 62346,
					State = "NH",
					Street = "5303 Lewis Springs",
					City = "Port Adrian",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 207.51m,
					WeekDayPrice = 204.67m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 26.36,
					Bedrooms = 2,
					Bathrooms = 1,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 02837,
					State = "IA",
					Street = "465 Wiley Corners Apt. 759",
					City = "East Michellechester",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 213.84m,
					WeekDayPrice = 129.14m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 12.81,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 68847,
					State = "LA",
					Street = "521 Flores Stream",
					City = "West Rebeccaborough",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 254.37m,
					WeekDayPrice = 77.06m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 6.03,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 35218,
					State = "NE",
					Street = "0271 Soto Drives Apt. 975",
					City = "New Edgar",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 233.17m,
					WeekDayPrice = 179.91m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 11.04,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 32697,
					State = "NM",
					Street = "27862 Kent Mountains",
					City = "Lake Michaelville",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 153.38m,
					WeekDayPrice = 90.54m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 6.91,
					Bedrooms = 6,
					Bathrooms = 5,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 95889,
					State = "OR",
					Street = "917 Mclaughlin Glens",
					City = "Martinville",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 226.89m,
					WeekDayPrice = 225.59m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 28.99,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 2,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 82153,
					State = "KY",
					Street = "3032 Michelle Drives",
					City = "North Daniel",
					HostEmail = "rankin@yahoo.com",
					WeekendPrice = 157.15m,
					WeekDayPrice = 203.25m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 15.68,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 13,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 32202,
					State = "SD",
					Street = "601 Maria Mission Apt. 554",
					City = "Myerstown",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 269.55m,
					WeekDayPrice = 223.27m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 11.35,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 17431,
					State = "OH",
					Street = "238 Shawn Well",
					City = "Port Johnshire",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 112.64m,
					WeekDayPrice = 173.63m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 6.38,
					Bedrooms = 7,
					Bathrooms = 8,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 37901,
					State = "SC",
					Street = "41743 Berger Inlet Apt. 527",
					City = "South Tammymouth",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 163.2m,
					WeekDayPrice = 176.23m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 14.77,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 17895,
					State = "MO",
					Street = "9983 Mary Grove Apt. 643",
					City = "Beardview",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 209.33m,
					WeekDayPrice = 219.53m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 24.51,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 90576,
					State = "HI",
					Street = "03541 Ryan Islands Apt. 562",
					City = "East Michaelfort",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 269.63m,
					WeekDayPrice = 126.25m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 8.27,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 94980,
					State = "SC",
					Street = "6591 Angela Mission Apt. 108",
					City = "Penabury",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 286.86m,
					WeekDayPrice = 143.98m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 20.48,
					Bedrooms = 5,
					Bathrooms = 6,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 44974,
					State = "CO",
					Street = "492 Ramirez Crossing",
					City = "Aaronberg",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 144.6m,
					WeekDayPrice = 121.91m,
					PetsAllowed = False,
					ParkingFree = True,
					CleaningFee = 10.12,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 66170,
					State = "DE",
					Street = "35974 Sharon Locks Apt. 101",
					City = "Jennyport",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 114.46m,
					WeekDayPrice = 137.8m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 17.74,
					Bedrooms = 7,
					Bathrooms = 9,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 22495,
					State = "UT",
					Street = "89403 Gabriella Mills",
					City = "East Steven",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 155.1m,
					WeekDayPrice = 128.63m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 23.05,
					Bedrooms = 3,
					Bathrooms = 4,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 85059,
					State = "NH",
					Street = "601 Kyle Roads",
					City = "Clarkfurt",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 284.39m,
					WeekDayPrice = 209.11m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 6.25,
					Bedrooms = 4,
					Bathrooms = 5,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 61092,
					State = "IN",
					Street = "60969 Justin Passage Suite 774",
					City = "Joshuaburgh",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 121m,
					WeekDayPrice = 128.59m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 19.36,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 43986,
					State = "PA",
					Street = "7943 Tina Mount",
					City = "East Lisa",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 104.47m,
					WeekDayPrice = 122.88m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 25.31,
					Bedrooms = 4,
					Bathrooms = 3,
					GuestsAllowed = 14,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 91397,
					State = "NC",
					Street = "6775 James Ford",
					City = "South Victorialand",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 275.5m,
					WeekDayPrice = 211.24m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 15.74,
					Bedrooms = 1,
					Bathrooms = 3,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 67849,
					State = "VT",
					Street = "431 Johnson Neck Suite 039",
					City = "Mariechester",
					HostEmail = "rice@yahoo.com",
					WeekendPrice = 126.24m,
					WeekDayPrice = 124.65m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 24.3,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 20687,
					State = "NM",
					Street = "15666 Justin Locks",
					City = "Lake Ryanport",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 112.05m,
					WeekDayPrice = 70.11m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 27.45,
					Bedrooms = 6,
					Bathrooms = 6,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 30222,
					State = "TX",
					Street = "9947 Torres Viaduct Apt. 506",
					City = "Benjaminport",
					HostEmail = "ingram@gmail.com",
					WeekendPrice = 152.09m,
					WeekDayPrice = 174.87m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 18.44,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 11,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Apartment");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 21190,
					State = "NJ",
					Street = "20866 Keith Mill",
					City = "Susanton",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 174.06m,
					WeekDayPrice = 96.8m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 28.15,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 04838,
					State = "AL",
					Street = "04374 Nicholas Cliff Suite 001",
					City = "Adrianport",
					HostEmail = "jacobs@yahoo.com",
					WeekendPrice = 108.24m,
					WeekDayPrice = 205.01m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 6.56,
					Bedrooms = 1,
					Bathrooms = 1,
					GuestsAllowed = 10,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Condo");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 80130,
					State = "CA",
					Street = "271 Andrew Summit",
					City = "Port Craig",
					HostEmail = "gonzalez@aol.com",
					WeekendPrice = 148.39m,
					WeekDayPrice = 197.52m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 20.55,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 96166,
					State = "MN",
					Street = "17611 Robbins Mission",
					City = "New Curtis",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 286.13m,
					WeekDayPrice = 219.69m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 10.64,
					Bedrooms = 3,
					Bathrooms = 3,
					GuestsAllowed = 9,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 40702,
					State = "MO",
					Street = "80831 Kemp Pines",
					City = "Annashire",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 123.93m,
					WeekDayPrice = 91.26m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 19.36,
					Bedrooms = 1,
					Bathrooms = 2,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 86023,
					State = "IL",
					Street = "96545 Smith Alley",
					City = "West Joy",
					HostEmail = "martinez@aol.com",
					WeekendPrice = 254.38m,
					WeekDayPrice = 132.54m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 14.83,
					Bedrooms = 6,
					Bathrooms = 8,
					GuestsAllowed = 7,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 70897,
					State = "MT",
					Street = "6146 Johnson Isle",
					City = "South Arthur",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 228.04m,
					WeekDayPrice = 227.96m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 6.99,
					Bedrooms = 2,
					Bathrooms = 4,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 69154,
					State = "MN",
					Street = "0415 Smith Springs",
					City = "Jeremyburgh",
					HostEmail = "loter@yahoo.com",
					WeekendPrice = 228.81m,
					WeekDayPrice = 140.93m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 29.74,
					Bedrooms = 4,
					Bathrooms = 4,
					GuestsAllowed = 3,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 53524,
					State = "HI",
					Street = "3999 Ricky Via",
					City = "West Adamburgh",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 255.43m,
					WeekDayPrice = 137.35m,
					PetsAllowed = True,
					ParkingFree = True,
					CleaningFee = 16.62,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 6,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "House");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 24886,
					State = "MN",
					Street = "83787 Stuart Key",
					City = "Davetown",
					HostEmail = "chung@yahoo.com",
					WeekendPrice = 146.75m,
					WeekDayPrice = 172.99m,
					PetsAllowed = True,
					ParkingFree = False,
					CleaningFee = 26.24,
					Bedrooms = 7,
					Bathrooms = 6,
					GuestsAllowed = 4,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();

				Property  = new Property()
				{
					Zip = 56713,
					State = "TX",
					Street = "690 Christina Park",
					City = "Toddburgh",
					HostEmail = "tanner@utexas.edu",
					WeekendPrice = 157.96m,
					WeekDayPrice = 188.53m,
					PetsAllowed = False,
					ParkingFree = False,
					CleaningFee = 6.69,
					Bedrooms = 3,
					Bathrooms = 5,
					GuestsAllowed = 1,
				};
				.Category = db.Properties.FirstOrDefault(g => g.CategoryName == "Cabin");
				Properties.Add();


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
							dbProperty.HostEmail = propertyToAdd.HostEmail;
							dbProperty.WeekendPrice = propertyToAdd.WeekendPrice;
							dbProperty.WeekDayPrice = propertyToAdd.WeekDayPrice;
							dbProperty.Category = propertyToAdd.Category;
							dbProperty.PetsAllowed = propertyToAdd.PetsAllowed;
							dbProperty.ParkingFee = propertyToAdd.ParkingFree;
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
