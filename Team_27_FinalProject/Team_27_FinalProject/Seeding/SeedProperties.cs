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
				Properties.Add(p183);

				Property p184 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p184.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p184);

				Property p185 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p185.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p185);

				Property p186 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p186.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p186);

				Property p187 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p187.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p187);

				Property p188 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p188.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p188);

				Property p189 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p189.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p189);

				Property p190 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p190.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p190);

				Property p191 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p191.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p191);

				Property p192 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p192.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p192);

				Property p193 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p193.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p193);

				Property p194 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p194.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p194);

				Property p195 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p195.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p195);

				Property p196 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p196.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p196);

				Property p197 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p197.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p197);

				Property p198 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p198.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p198);

				Property p199 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p199.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p199);

				Property p200 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p200.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p200);

				Property p201 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p201.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p201);

				Property p202 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p202.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p202);

				Property p203 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p203.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p203);

				Property p204 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p204.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p204);


				p210.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p210);

				Properties.Add(p238);

				Property p239 = n
					Bathrooms = ,
					GuestsAllowed = 
				};
				p247.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p247);

				Property p248 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
				};
				p304.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p304);

				Property p305 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p305.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p305);

				Property p306 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p306.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p306);

				Property p307 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p307.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p307);

				Property p308 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p319.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p319);

				Property p320 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p320.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p320);

				Property p321 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p321.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p321);

				Property p322 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p322.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p322);

				Property p323 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
				Property p338 = new Property()
				{
					Zip = ,
					State = "",
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					ParkingFree = ,
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p539.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p539);

				Property p540 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p540.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
		
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p642.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p642);

				Property p643 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p643.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p643);

				Property p644 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p644.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p644);

				Property p645 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p645.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p645);

				Property p646 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p646.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p646);

				Property p647 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p647.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p647);

				Property p648 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p648.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p648);

				Property p649 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p649.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p649);

				Property p650 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p650.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p650);

				Property p651 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p651.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p651);

				Property p652 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p652.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p652);

				Property p653 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p653.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p653);

				Property p654 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p654.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p654);

				Property p655 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p655.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p655);

				Property p656 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p656.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p656);

				Property p657 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p657.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p657);

				Property p658 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p658.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p658);

				Property p659 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p659.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p659);

				Property p660 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p660.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p660);

				Property p661 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p661.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p661);

				Property p662 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p662.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p662);

				Property p663 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p663.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p663);

				Property p664 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p664.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p664);

				Property p665 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p665.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p665);

				Property p666 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p666.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p666);

				Property p667 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p667.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p667);

				Property p668 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p668.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p668);

				Property p669 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p669.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p669);

				Property p670 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p670.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p670);

				Property p671 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p671.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p671);

				Property p672 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p672.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p672);

				Property p673 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p673.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p673);

				Property p674 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p674.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p674);

				Property p675 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p675.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p675);

				Property p676 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p676.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p676);

				Property p677 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p677.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p677);

				Property p678 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p678.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p678);

				Property p679 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p679.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p679);

				Property p680 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p680.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p680);

				Property p681 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p681.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p681);

				Property p682 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p682.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p682);

				Property p683 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p683.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p683);

				Property p684 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p684.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p684);

				Property p685 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p685.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p685);

				Property p686 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p686.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p686);

				Property p687 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p687.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p687);

				Property p688 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p688.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p688);

				Property p689 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p689.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p689);

				Property p690 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p690.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p690);

				Property p691 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p691.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p691);

				Property p692 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p692.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p692);

				Property p693 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p693.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p693);

				Property p694 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p694.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p694);

				Property p695 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p695.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p695);

				Property p696 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p696.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p696);

				Property p697 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p697.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p697);

				Property p698 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p698.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p698);

				Property p699 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p699.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p699);

				Property p700 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p700.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p700);

				Property p701 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p701.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p701);

				Property p702 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p702.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p702);

				Property p703 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p703.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p703);

				Property p704 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p704.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p704);

				Property p705 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p705.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p705);

				Property p706 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p706.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p706);

				Property p707 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p707.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p707);

				Property p708 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p708.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p708);

				Property p709 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p709.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p709);

				Property p710 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p710.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p710);

				Property p711 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p711.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p711);

				Property p712 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p712.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p712);

				Property p713 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p713.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p713);

				Property p714 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p714.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p714);

				Property p715 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p715.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p715);

				Property p716 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p716.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p716);

				Property p717 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p717.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p717);

				Property p718 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p718.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p718);

				Property p719 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p719.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p719);

				Property p720 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p720.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p720);

				Property p721 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p721.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p721);

				Property p722 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p722.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p722);

				Property p723 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p723.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p723);

				Property p724 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p724.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p724);

				Property p725 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p725.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p725);

				Property p726 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p726.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p726);

				Property p727 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p727.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p727);

				Property p728 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p728.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p728);

				Property p729 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p729.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p729);

				Property p730 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p730.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p730);

				Property p731 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p731.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p731);

				Property p732 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p732.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p732);

				Property p733 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p733.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p733);

				Property p734 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p734.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p734);

				Property p735 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p735.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p735);

				Property p736 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p736.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p736);

				Property p737 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p737.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p737);

				Property p738 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p738.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p738);

				Property p739 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p739.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p739);

				Property p740 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p740.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p740);

				Property p741 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p741.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p741);

				Property p742 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p742.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p742);

				Property p743 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p743.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p743);

				Property p744 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p744.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p744);

				Property p745 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p745.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p745);

				Property p746 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p746.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p746);

				Property p747 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p747.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p747);

				Property p748 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p748.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p748);

				Property p749 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p749.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p749);

				Property p750 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p750.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p750);

				Property p751 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p751.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p751);

				Property p752 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p752.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p752);

				Property p753 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p753.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p753);

				Property p754 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p754.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p754);

				Property p755 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p755.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p755);

				Property p756 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p756.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p756);

				Property p757 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p757.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p757);

				Property p758 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p758.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p758);

				Property p759 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p759.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p759);

				Property p760 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p760.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p760);

				Property p761 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p761.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p761);

				Property p762 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p762.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p762);

				Property p763 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p763.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p763);

				Property p764 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p764.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p764);

				Property p765 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p765.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p765);

				Property p766 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p766.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p766);

				Property p767 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p767.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p767);

				Property p768 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p768.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p768);

				Property p769 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p769.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p769);

				Property p770 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p770.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p770);

				Property p771 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p771.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p771);

				Property p772 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p772.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p772);

				Property p773 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p773.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p773);

				Property p774 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p774.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p774);

				Property p775 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p775.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p775);

				Property p776 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p776.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p776);

				Property p777 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p777.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p777);

				Property p778 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p778.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p778);

				Property p779 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p779.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p779);

				Property p780 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p780.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p780);

				Property p781 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p781.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p781);

				Property p782 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p782.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p782);

				Property p783 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p783.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p783);

				Property p784 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p784.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p784);

				Property p785 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p785.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p785);

				Property p786 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p786.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p786);

				Property p787 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p787.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p787);

				Property p788 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p788.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p788);

				Property p789 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p789.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p789);

				Property p790 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p790.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p790);

				Property p791 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p791.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p791);

				Property p792 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p792.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p792);

				Property p793 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p793.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p793);

				Property p794 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p794.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p794);

				Property p795 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p795.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p795);

				Property p796 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p796.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p796);

				Property p797 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p797.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p797);

				Property p798 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p798.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p798);

				Property p799 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p799.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p799);

				Property p800 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p800.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p800);

				Property p801 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p801.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p801);

				Property p802 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p802.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p802);

				Property p803 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p803.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p803);

				Property p804 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p804.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p804);

				Property p805 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p805.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p805);

				Property p806 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p806.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p806);

				Property p807 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p807.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p807);

				Property p808 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p808.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p808);

				Property p809 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p809.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p809);

				Property p810 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p810.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p810);

				Property p811 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p811.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p811);

				Property p812 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p812.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p812);

				Property p813 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p813.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p813);

				Property p814 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p814.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p814);

				Property p815 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p815.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p815);

				Property p816 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p816.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p816);

				Property p817 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p817.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p817);

				Property p818 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p818.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p818);

				Property p819 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p819.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p819);

				Property p820 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p820.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p820);

				Property p821 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p821.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p821);

				Property p822 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p822.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p822);

				Property p823 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p823.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p823);

				Property p824 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p824.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p824);

				Property p825 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p825.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p825);

				Property p826 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p826.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p826);

				Property p827 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p827.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p827);

				Property p828 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p828.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p828);

				Property p829 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p829.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p829);

				Property p830 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p830.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p830);

				Property p831 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p831.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p831);

				Property p832 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p832.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p832);

				Property p833 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p833.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p833);

				Property p834 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p834.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p834);

				Property p835 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p835.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p835);

				Property p836 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p836.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p836);

				Property p837 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p837.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p837);

				Property p838 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p838.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p838);

				Property p839 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p839.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p839);

				Property p840 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p840.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p840);

				Property p841 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p841.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p841);

				Property p842 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p842.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p842);

				Property p843 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p843.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p843);

				Property p844 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p844.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p844);

				Property p845 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p845.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p845);

				Property p846 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p846.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p846);

				Property p847 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p847.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p847);

				Property p848 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p848.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p848);

				Property p849 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p849.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p849);

				Property p850 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p850.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p850);

				Property p851 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p851.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p851);

				Property p852 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p852.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p852);

				Property p853 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p853.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p853);

				Property p854 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p854.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p854);

				Property p855 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p855.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p855);

				Property p856 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p856.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p856);

				Property p857 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p857.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p857);

				Property p858 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p858.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p858);

				Property p859 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p859.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p859);

				Property p860 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p860.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p860);

				Property p861 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p861.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p861);

				Property p862 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p862.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p862);

				Property p863 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p863.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p863);

				Property p864 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p864.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p864);

				Property p865 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p865.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p865);

				Property p866 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p866.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p866);

				Property p867 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p867.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p867);

				Property p868 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p868.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p868);

				Property p869 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p869.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p869);

				Property p870 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p870.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p870);

				Property p871 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p871.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p871);

				Property p872 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p872.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p872);

				Property p873 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p873.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p873);

				Property p874 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p874.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p874);

				Property p875 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p875.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p875);

				Property p876 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p876.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p876);

				Property p877 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p877.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p877);

				Property p878 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p878.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p878);

				Property p879 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p879.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p879);

				Property p880 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p880.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p880);

				Property p881 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p881.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p881);

				Property p882 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p882.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p882);

				Property p883 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p883.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p883);

				Property p884 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p884.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p884);

				Property p885 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p885.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p885);

				Property p886 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p886.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p886);

				Property p887 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p887.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p887);

				Property p888 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p888.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p888);

				Property p889 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p889.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p889);

				Property p890 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p890.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p890);

				Property p891 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p891.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p891);

				Property p892 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p892.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p892);

				Property p893 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p893.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p893);

				Property p894 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p894.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p894);

				Property p895 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p895.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p895);

				Property p896 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p896.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p896);

				Property p897 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p897.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p897);

				Property p898 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p898.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p898);

				Property p899 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p899.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p899);

				Property p900 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p900.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p900);

				Property p901 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p901.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p901);

				Property p902 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p902.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p902);

				Property p903 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p903.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p903);

				Property p904 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p904.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p904);

				Property p905 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p905.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p905);

				Property p906 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p906.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p906);

				Property p907 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p907.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p907);

				Property p908 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p908.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p908);

				Property p909 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p909.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p909);

				Property p910 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p910.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p910);

				Property p911 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p911.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p911);

				Property p912 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p912.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p912);

				Property p913 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p913.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p913);

				Property p914 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p914.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p914);

				Property p915 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p915.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p915);

				Property p916 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p916.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p916);

				Property p917 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p917.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p917);

				Property p918 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p918.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p918);

				Property p919 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p919.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p919);

				Property p920 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p920.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p920);

				Property p921 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p921.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p921);

				Property p922 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p922.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p922);

				Property p923 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p923.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p923);

				Property p924 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p924.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p924);

				Property p925 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p925.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p925);

				Property p926 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p926.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p926);

				Property p927 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p927.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p927);

				Property p928 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p928.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p928);

				Property p929 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p929.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p929);

				Property p930 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p930.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p930);

				Property p931 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p931.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p931);

				Property p932 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p932.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p932);

				Property p933 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p933.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p933);

				Property p934 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p934.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p934);

				Property p935 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p935.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p935);

				Property p936 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p936.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p936);

				Property p937 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p937.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p937);

				Property p938 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p938.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p938);

				Property p939 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p939.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p939);

				Property p940 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p940.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p940);

				Property p941 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p941.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p941);

				Property p942 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p942.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p942);

				Property p943 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p943.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p943);

				Property p944 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p944.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p944);

				Property p945 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p945.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p945);

				Property p946 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p946.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p946);

				Property p947 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p947.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p947);

				Property p948 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p948.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p948);

				Property p949 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p949.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p949);

				Property p950 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p950.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p950);

				Property p951 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p951.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p951);

				Property p952 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p952.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p952);

				Property p953 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p953.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p953);

				Property p954 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p954.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p954);

				Property p955 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p955.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p955);

				Property p956 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p956.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p956);

				Property p957 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p957.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p957);

				Property p958 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p958.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p958);

				Property p959 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p959.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p959);

				Property p960 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p960.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p960);

				Property p961 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p961.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p961);

				Property p962 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p962.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p962);

				Property p963 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p963.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p963);

				Property p964 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p964.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p964);

				Property p965 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p965.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p965);

				Property p966 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p966.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p966);

				Property p967 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p967.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p967);

				Property p968 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p968.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p968);

				Property p969 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p969.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p969);

				Property p970 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p970.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p970);

				Property p971 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p971.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p971);

				Property p972 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p972.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p972);

				Property p973 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p973.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p973);

				Property p974 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p974.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p974);

				Property p975 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p975.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p975);

				Property p976 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p976.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p976);

				Property p977 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p977.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p977);

				Property p978 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p978.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p978);

				Property p979 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p979.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p979);

				Property p980 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p980.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p980);

				Property p981 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p981.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p981);

				Property p982 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p982.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p982);

				Property p983 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p983.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p983);

				Property p984 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p984.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p984);

				Property p985 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p985.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p985);

				Property p986 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p986.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p986);

				Property p987 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p987.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p987);

				Property p988 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p988.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p988);

				Property p989 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p989.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p989);

				Property p990 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p990.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p990);

				Property p991 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p991.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p991);

				Property p992 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p992.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p992);

				Property p993 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p993.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p993);

				Property p994 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p994.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p994);

				Property p995 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p995.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p995);

				Property p996 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p996.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p996);

				Property p997 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p997.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p997);

				Property p998 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p998.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p998);

				Property p999 = new Property()
				{
					Zip = ,
					State = "",
					Street = "",
					City = "",
					WeekendPrice = m,
					WeekDayPrice = m,
					PetsAllowed = ,
					ParkingFree = ,
					CleaningFee = m,
					Bedrooms = ,
					Bathrooms = ,
					GuestsAllowed = 
				};
				p999.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "");
				Properties.Add(p999);

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
							dbProperty.Email = propertyToAdd.Email;
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
		}
	}
}
