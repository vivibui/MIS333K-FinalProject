using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Team_27_FinalProject.Models;
using Team_27_FinalProject.Utilities;
using Team_27_FinalProject.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace Team_27_FinalProject.Seeding
{
	public static class SeedUsers
	{
		public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
		{
			
			List<AddUserModel> AllUsers = new List<AddUserModel>();

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "cbaker@freezing.co.uk",
					Email = "cbaker@freezing.co.uk",
					PhoneNumber = "5125595133",
					FirstName = "Christopher",
					LastName = "Baker",
					MI = "L",
					Street = "1245 Lake America Blvd.",
					Zip = 78733,
					Birthday = new DateTime(1968, 11, 28)
				},
				Password = "hellothere",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "mb@puppy.com",
					Email = "mb@puppy.com",
					PhoneNumber = "2102702860",
					FirstName = "Michelle",
					LastName = "Bradicus",
					MI = "Q",
					Street = "1300 Small Pine Lane",
					Zip = 78261,
					Birthday = new DateTime(1988, 2, 7)
				},
				Password = "555533",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "fd@puppy.com",
					Email = "fd@puppy.com",
					PhoneNumber = "8175683686",
					FirstName = "Franco",
					LastName = "Broccoli",
					MI = "V",
					Street = "62 Cookie Rd",
					Zip = 77019,
					Birthday = new DateTime(1999, 11, 7)
				},
				Password = "666645",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "wendy@puppy.com",
					Email = "wendy@puppy.com",
					PhoneNumber = "5125967209",
					FirstName = "Wendy",
					LastName = "Charile",
					MI = "L",
					Street = "202 Bellmoth Hall",
					Zip = 78713,
					Birthday = new DateTime(1992, 10, 27)
				},
				Password = "Kansas",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "limchou@puppy.com",
					Email = "limchou@puppy.com",
					PhoneNumber = "2107748586",
					FirstName = "Lim",
					LastName = "Chou",
					MI = "Q",
					Street = "1600 Barbara Lane",
					Zip = 78266,
					Birthday = new DateTime(1961, 11, 11)
				},
				Password = "Rockwall",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "444444.Dave@aool.com",
					Email = "444444.Dave@aool.com",
					PhoneNumber = "2142667242",
					FirstName = "Shan",
					LastName = "Dave",
					MI = "D",
					Street = "234 Puppy Circle",
					Zip = 75208,
					Birthday = new DateTime(1972, 12, 19)
				},
				Password = "444444",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "louann@puppy.com",
					Email = "louann@puppy.com",
					PhoneNumber = "8172580736",
					FirstName = "Lou Ann",
					LastName = "Feeley",
					MI = "K",
					Street = "700 S 9th Street W",
					Zip = 77010,
					Birthday = new DateTime(1958, 8, 1)
				},
				Password = "longhorns",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "tfreeley@puppy.com",
					Email = "tfreeley@puppy.com",
					PhoneNumber = "8173279674",
					FirstName = "Tesa",
					LastName = "Freeley",
					MI = "P",
					Street = "4334 Meanview Ave.",
					Zip = 77009,
					Birthday = new DateTime(2001, 7, 12)
				},
				Password = "puppies",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "mgar@puppy.com",
					Email = "mgar@puppy.com",
					PhoneNumber = "8176617531",
					FirstName = "Margaret",
					LastName = "Garcia",
					MI = "L",
					Street = "594 Puppyview",
					Zip = 77003,
					Birthday = new DateTime(1956, 11, 17)
				},
				Password = "horses",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "chaley@thug.com",
					Email = "chaley@thug.com",
					PhoneNumber = "2148499570",
					FirstName = "Charles",
					LastName = "Harley",
					MI = "E",
					Street = "One Ranger Pkwy",
					Zip = 75261,
					Birthday = new DateTime(1998, 5, 29)
				},
				Password = "mycats",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "jeff@puppy.com",
					Email = "jeff@puppy.com",
					PhoneNumber = "5127002600",
					FirstName = "Jeffrey",
					LastName = "Stark",
					MI = "T",
					Street = "337 40th St.",
					Zip = 78705,
					Birthday = new DateTime(1974, 5, 2)
				},
				Password = "jeffery",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "wjhearniii@umch.edu",
					Email = "wjhearniii@umch.edu",
					PhoneNumber = "2148989608",
					FirstName = "John",
					LastName = "Hearn",
					MI = "B",
					Street = "4445 South First",
					Zip = 75237,
					Birthday = new DateTime(1983, 12, 29)
				},
				Password = "posicles",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "hicks43@puppy.com",
					Email = "hicks43@puppy.com",
					PhoneNumber = "2105812952",
					FirstName = "Mark",
					LastName = "Hicks",
					MI = "J",
					Street = "32 NE Mark Ln., Ste 910",
					Zip = 78239,
					Birthday = new DateTime(1989, 12, 16)
				},
				Password = "guac45",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "bradsingram@mall.utexas.edu",
					Email = "bradsingram@mall.utexas.edu",
					PhoneNumber = "5124702808",
					FirstName = "Brad",
					LastName = "Ingram",
					MI = "S",
					Street = "6548 La Chess St.",
					Zip = 78736,
					Birthday = new DateTime(1958, 9, 18)
				},
				Password = "father",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "father.Ingram@aool.com",
					Email = "father.Ingram@aool.com",
					PhoneNumber = "5124677352",
					FirstName = "Todd",
					LastName = "Jacobs",
					MI = "L",
					Street = "4564 Palm St.",
					Zip = 78731,
					Birthday = new DateTime(1975, 12, 9)
				},
				Password = "555897",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "victoria@puppy.com",
					Email = "victoria@puppy.com",
					PhoneNumber = "5129481386",
					FirstName = "Victoria",
					LastName = "Lawrence",
					MI = "M",
					Street = "6639 Butterfly Ln.",
					Zip = 78761,
					Birthday = new DateTime(1981, 5, 29)
				},
				Password = "something",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "lineback@flush.net",
					Email = "lineback@flush.net",
					PhoneNumber = "2102473963",
					FirstName = "Brad",
					LastName = "Lineback",
					MI = "W",
					Street = "1300 Pirateland St",
					Zip = 78293,
					Birthday = new DateTime(1973, 5, 19)
				},
				Password = "treelover",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "elowe@netscrape.net",
					Email = "elowe@netscrape.net",
					PhoneNumber = "2105368614",
					FirstName = "Evan",
					LastName = "Lowe",
					MI = "S",
					Street = "3201 Pineapple Drive",
					Zip = 78279,
					Birthday = new DateTime(1993, 6, 7)
				},
				Password = "headear",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "luce_chuck@puppy.com",
					Email = "luce_chuck@puppy.com",
					PhoneNumber = "2107007535",
					FirstName = "Chuck",
					LastName = "Luce",
					MI = "B",
					Street = "2345 Silent Clouds",
					Zip = 78268,
					Birthday = new DateTime(1995, 6, 11)
				},
				Password = "gooseyloosey",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "mackcloud@pimpdaddy.com",
					Email = "mackcloud@pimpdaddy.com",
					PhoneNumber = "5124772125",
					FirstName = "Jennifer",
					LastName = "MacLeod",
					MI = "D",
					Street = "2504 Far East Blvd.",
					Zip = 78731,
					Birthday = new DateTime(1965, 10, 11)
				},
				Password = "rainyday",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "liz@puppy.com",
					Email = "liz@puppy.com",
					PhoneNumber = "5124603832",
					FirstName = "Elizabeth",
					LastName = "Markham",
					MI = "P",
					Street = "7861 Chevy Mace Rd",
					Zip = 78732,
					Birthday = new DateTime(1989, 6, 18)
				},
				Password = "ember22",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "mclarence@puppy.com",
					Email = "mclarence@puppy.com",
					PhoneNumber = "8174979188",
					FirstName = "Clarence",
					LastName = "Martin",
					MI = "A",
					Street = "87 Alcedo St.",
					Zip = 77045,
					Birthday = new DateTime(1984, 4, 28)
				},
				Password = "lamemartin",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "lamemartin.Martin@aool.com",
					Email = "lamemartin.Martin@aool.com",
					PhoneNumber = "8178770705",
					FirstName = "Gregory",
					LastName = "Martinez",
					MI = "R",
					Street = "8295 Moon Blvd.",
					Zip = 77030,
					Birthday = new DateTime(1981, 12, 27)
				},
				Password = "gregory",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "cmiller@mapster.com",
					Email = "cmiller@mapster.com",
					PhoneNumber = "8177482602",
					FirstName = "Charles",
					LastName = "Miller",
					MI = "R",
					Street = "8962 Side St.",
					Zip = 77031,
					Birthday = new DateTime(1987, 5, 5)
				},
				Password = "mucky44",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "nelson.Kelly@puppy.com",
					Email = "nelson.Kelly@puppy.com",
					PhoneNumber = "5122950953",
					FirstName = "Kelly",
					LastName = "Nelson",
					MI = "T",
					Street = "2601 Green River",
					Zip = 78703,
					Birthday = new DateTime(1969, 8, 3)
				},
				Password = "Tree34",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "jojoe@puppy.com",
					Email = "jojoe@puppy.com",
					PhoneNumber = "2143149884",
					FirstName = "Joe",
					LastName = "Nguyen",
					MI = "C",
					Street = "1249 4th NW St.",
					Zip = 75238,
					Birthday = new DateTime(1956, 2, 6)
				},
				Password = "jvb485bg",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "orielly@foxnets.com",
					Email = "orielly@foxnets.com",
					PhoneNumber = "2103474912",
					FirstName = "Bill",
					LastName = "O'Reilly",
					MI = "T",
					Street = "8800 Gringo Drive",
					Zip = 78260,
					Birthday = new DateTime(1989, 3, 14)
				},
				Password = "Bobbygirl",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "or@puppy.com",
					Email = "or@puppy.com",
					PhoneNumber = "2142369553",
					FirstName = "Anka",
					LastName = "Radkovich",
					MI = "L",
					Street = "1300 Freaky",
					Zip = 75260,
					Birthday = new DateTime(1952, 10, 26)
				},
				Password = "radioactive",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "megrhodes@freezing.co.uk",
					Email = "megrhodes@freezing.co.uk",
					PhoneNumber = "5123768733",
					FirstName = "Megan",
					LastName = "Rhodes",
					MI = "C",
					Street = "4587 Rightfield Rd.",
					Zip = 78707,
					Birthday = new DateTime(1958, 3, 18)
				},
				Password = "gopigs",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "erynrice@puppy.com",
					Email = "erynrice@puppy.com",
					PhoneNumber = "5123900644",
					FirstName = "Eryn",
					LastName = "Rice",
					MI = "M",
					Street = "3405 Rio Small",
					Zip = 78705,
					Birthday = new DateTime(2000, 11, 2)
				},
				Password = "iloveme",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "jorge@hootmail.com",
					Email = "jorge@hootmail.com",
					PhoneNumber = "8178928361",
					FirstName = "Jorge",
					LastName = "Rodriguez",
					MI = "",
					Street = "6788 Cotten Street",
					Zip = 77057,
					Birthday = new DateTime(1979, 1, 1)
				},
				Password = "565656",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "ra@aoo.com",
					Email = "ra@aoo.com",
					PhoneNumber = "5128776930",
					FirstName = "Allen",
					LastName = "Rogers",
					MI = "B",
					Street = "4965 Rabbit Hill",
					Zip = 78732,
					Birthday = new DateTime(2000, 3, 12)
				},
				Password = "treeman",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "o_st-jean@home.com",
					Email = "o_st-jean@home.com",
					PhoneNumber = "2104169665",
					FirstName = "Olivier",
					LastName = "Saint-Jean",
					MI = "M",
					Street = "255 Slap Dr.",
					Zip = 78292,
					Birthday = new DateTime(1997, 5, 1)
				},
				Password = "55htrq",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "ss34@puppy.com",
					Email = "ss34@puppy.com",
					PhoneNumber = "5123521797",
					FirstName = "Sarah",
					LastName = "Saunders",
					MI = "J",
					Street = "332 Fish C",
					Zip = 78705,
					Birthday = new DateTime(1994, 5, 31)
				},
				Password = "leaves",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "willsheff@email.com",
					Email = "willsheff@email.com",
					PhoneNumber = "5124534071",
					FirstName = "William",
					LastName = "Sewell",
					MI = "T",
					Street = "2365 34st St.",
					Zip = 78709,
					Birthday = new DateTime(1951, 12, 10)
				},
				Password = "borbj44",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "sheff44@puppy.com",
					Email = "sheff44@puppy.com",
					PhoneNumber = "5125503154",
					FirstName = "Martin",
					LastName = "Sheffield",
					MI = "J",
					Street = "3886 Road A",
					Zip = 78705,
					Birthday = new DateTime(1993, 7, 2)
				},
				Password = "ldiul485",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "johnsmith187@puppy.com",
					Email = "johnsmith187@puppy.com",
					PhoneNumber = "2108345875",
					FirstName = "John",
					LastName = "Smith",
					MI = "A",
					Street = "23 Known Forge Dr.",
					Zip = 78280,
					Birthday = new DateTime(1985, 6, 13)
				},
				Password = "kribv75",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "dustroud@mail.com",
					Email = "dustroud@mail.com",
					PhoneNumber = "2142370654",
					FirstName = "Dustin",
					LastName = "Stroud",
					MI = "P",
					Street = "1212 Henrietta Rd",
					Zip = 75221,
					Birthday = new DateTime(1974, 7, 14)
				},
				Password = "klavjkb48",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "eric_stuart@puppy.com",
					Email = "eric_stuart@puppy.com",
					PhoneNumber = "5128202322",
					FirstName = "Eric",
					LastName = "Stuart",
					MI = "D",
					Street = "5576 Big Ring",
					Zip = 78746,
					Birthday = new DateTime(1968, 6, 17)
				},
				Password = "vkb451",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "peterstump@hootmail.com",
					Email = "peterstump@hootmail.com",
					PhoneNumber = "8174584890",
					FirstName = "Peter",
					LastName = "Stump",
					MI = "L",
					Street = "1300 Kellen Square",
					Zip = 77018,
					Birthday = new DateTime(2001, 7, 23)
				},
				Password = "kdsiu4",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "tanner@puppy.com",
					Email = "tanner@puppy.com",
					PhoneNumber = "8174614916",
					FirstName = "Jeremy",
					LastName = "Tanner",
					MI = "S",
					Street = "4347 Palmstead",
					Zip = 77044,
					Birthday = new DateTime(1973, 12, 28)
				},
				Password = "klrfbj45",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "taylordjay@puppy.com",
					Email = "taylordjay@puppy.com",
					PhoneNumber = "5124772439",
					FirstName = "Allison",
					LastName = "Taylor",
					MI = "R",
					Street = "467 Nueces St.",
					Zip = 78705,
					Birthday = new DateTime(1999, 9, 30)
				},
				Password = "lraggrhb854",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "lraggrhb854.Taylor@aool.com",
					Email = "lraggrhb854.Taylor@aool.com",
					PhoneNumber = "5124536618",
					FirstName = "Rachel",
					LastName = "Taylor",
					MI = "K",
					Street = "345 Shortview Dr.",
					Zip = 78705,
					Birthday = new DateTime(1956, 2, 24)
				},
				Password = "alsuib95",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "tee_frank@hootmail.com",
					Email = "tee_frank@hootmail.com",
					PhoneNumber = "8178789530",
					FirstName = "Frank",
					LastName = "Tee",
					MI = "J",
					Street = "5590 Big Dr.",
					Zip = 77004,
					Birthday = new DateTime(1964, 11, 11)
				},
				Password = "kd1734",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "tuck33@puppy.com",
					Email = "tuck33@puppy.com",
					PhoneNumber = "2148495141",
					FirstName = "Clent",
					LastName = "Tucker",
					MI = "J",
					Street = "3132 Main St.",
					Zip = 75315,
					Birthday = new DateTime(1990, 6, 25)
				},
				Password = "kjdb983",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "avelasco@puppy.com",
					Email = "avelasco@puppy.com",
					PhoneNumber = "2144009625",
					FirstName = "Allen",
					LastName = "Velasco",
					MI = "G",
					Street = "634 W. 4th",
					Zip = 75207,
					Birthday = new DateTime(1966, 12, 13)
				},
				Password = "odrb02",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "westj@pioneer.net",
					Email = "westj@pioneer.net",
					PhoneNumber = "2148499231",
					FirstName = "Jake",
					LastName = "West",
					MI = "T",
					Street = "RR 3244",
					Zip = 75323,
					Birthday = new DateTime(1968, 2, 6)
				},
				Password = "kndl847",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "louielouie@puppy.com",
					Email = "louielouie@puppy.com",
					PhoneNumber = "2145674085",
					FirstName = "Louis",
					LastName = "Winthorpe",
					MI = "L",
					Street = "2500 Madre Blvd",
					Zip = 78746,
					Birthday = new DateTime(1961, 7, 23)
				},
				Password = "lb2394",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "rwood@voyager.net",
					Email = "rwood@voyager.net",
					PhoneNumber = "5124569229",
					FirstName = "Reagan",
					LastName = "Wood",
					MI = "B",
					Street = "447 Westlake Dr.",
					Zip = 78746,
					Birthday = new DateTime(1988, 10, 24)
				},
				Password = "drai494",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "jacobs@yahoo.com",
					Email = "jacobs@yahoo.com",
					PhoneNumber = "8176663948",
					FirstName = "Todd",
					LastName = "Jacobs",
					MI = "L",
					Street = "4564 Elm St.",
					Zip = 77003,
					Birthday = new DateTime(1978, 1, 29)
				},
				Password = "tj2245",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "rice@yahoo.com",
					Email = "rice@yahoo.com",
					PhoneNumber = "2148545987",
					FirstName = "Eryn",
					LastName = "Rice",
					MI = "M",
					Street = "3405 Rio Grande",
					Zip = 75261,
					Birthday = new DateTime(2003, 6, 11)
				},
				Password = "ricearoni",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "ingram@gmail.com",
					Email = "ingram@gmail.com",
					PhoneNumber = "5127049017",
					FirstName = "John",
					LastName = "Ingram",
					MI = "R",
					Street = "6548 La Posada Ct.",
					Zip = 78705,
					Birthday = new DateTime(1980, 6, 25)
				},
				Password = "ingram68",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "martinez@aol.com",
					Email = "martinez@aol.com",
					PhoneNumber = "2105859369",
					FirstName = "Paul",
					LastName = "Martinez",
					MI = "G",
					Street = "8295 Sunset Blvd.",
					Zip = 78239,
					Birthday = new DateTime(1969, 6, 25)
				},
				Password = "party1",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "tanner@utexas.edu",
					Email = "tanner@utexas.edu",
					PhoneNumber = "5129527803",
					FirstName = "Jared",
					LastName = "Tanner",
					MI = "F",
					Street = "4347 Almstead",
					Zip = 78761,
					Birthday = new DateTime(1979, 6, 2)
				},
				Password = "sandman",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "chung@yahoo.com",
					Email = "chung@yahoo.com",
					PhoneNumber = "2107053952",
					FirstName = "Lauren",
					LastName = "Chung",
					MI = "R",
					Street = "234 RR 12",
					Zip = 78268,
					Birthday = new DateTime(1976, 3, 24)
				},
				Password = "listen",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "loter@yahoo.com",
					Email = "loter@yahoo.com",
					PhoneNumber = "5124650249",
					FirstName = "Wandavison",
					LastName = "Loter",
					MI = "T",
					Street = "3453 RR 3235",
					Zip = 78732,
					Birthday = new DateTime(1966, 9, 23)
				},
				Password = "pottery",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "morales@aol.com",
					Email = "morales@aol.com",
					PhoneNumber = "8177529019",
					FirstName = "Heather",
					LastName = "Morales",
					MI = "R",
					Street = "4501 RR 140",
					Zip = 77031,
					Birthday = new DateTime(1971, 1, 16)
				},
				Password = "heckin",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "rankin@yahoo.com",
					Email = "rankin@yahoo.com",
					PhoneNumber = "5122997370",
					FirstName = "Martin",
					LastName = "Rankin",
					MI = "P",
					Street = "340 Second St",
					Zip = 78703,
					Birthday = new DateTime(1961, 5, 16)
				},
				Password = "rankmark",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "gonzalez@aol.com",
					Email = "gonzalez@aol.com",
					PhoneNumber = "2142415970",
					FirstName = "Garth",
					LastName = "Gonzalez",
					MI = "R",
					Street = "103 Manor Rd",
					Zip = 75260,
					Birthday = new DateTime(1993, 12, 10)
				},
				Password = "gg2017",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "taylor@bevobnb.com",
					Email = "taylor@bevobnb.com",
					PhoneNumber = "2149036025",
					FirstName = "Albert",
					LastName = "Taylor",
					MI = "F",
					Street = "467 Nueces St.",
					Zip = 75237,
					Birthday = new DateTime(1954, 8, 14)
				},
				Password = "TRY563",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "sheffield@bevobnb.com",
					Email = "sheffield@bevobnb.com",
					PhoneNumber = "5124749225",
					FirstName = "Molly",
					LastName = "Sheffield",
					MI = "R",
					Street = "3886 Avenue A",
					Zip = 78736,
					Birthday = new DateTime(1986, 8, 27)
				},
				Password = "longsnores",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "macleod@bevobnb.com",
					Email = "macleod@bevobnb.com",
					PhoneNumber = "5124723769",
					FirstName = "Jenny",
					LastName = "MacLeod",
					MI = "I",
					Street = "2504 Far West Blvd.",
					Zip = 78731,
					Birthday = new DateTime(1984, 12, 5)
				},
				Password = "kittys",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "rhodes@bevobnb.com",
					Email = "rhodes@bevobnb.com",
					PhoneNumber = "2102520380",
					FirstName = "Michelle",
					LastName = "Rhodes",
					MI = "N",
					Street = "4587 Enfield Rd.",
					Zip = 78293,
					Birthday = new DateTime(1972, 7, 2)
				},
				Password = "puppies",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "stuart@bevobnb.com",
					Email = "stuart@bevobnb.com",
					PhoneNumber = "2105415031",
					FirstName = "Evan",
					LastName = "Stuart",
					MI = "Q",
					Street = "5576 Toro Ring",
					Zip = 78279,
					Birthday = new DateTime(1984, 4, 17)
				},
				Password = "coolboi",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "swanson@bevobnb.com",
					Email = "swanson@bevobnb.com",
					PhoneNumber = "5124818542",
					FirstName = "Ron",
					LastName = "Swanson",
					MI = "P",
					Street = "245 River Rd",
					Zip = 78731,
					Birthday = new DateTime(1991, 7, 25)
				},
				Password = "swanbong",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "white@bevobnb.com",
					Email = "white@bevobnb.com",
					PhoneNumber = "8175025605",
					FirstName = "Jabriel",
					LastName = "White",
					MI = "M",
					Street = "12 Valley View",
					Zip = 77045,
					Birthday = new DateTime(1986, 3, 17)
				},
				Password = "456789",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "montgomery@bevobnb.com",
					Email = "montgomery@bevobnb.com",
					PhoneNumber = "8178817122",
					FirstName = "Washington",
					LastName = "Montgomery",
					MI = "X",
					Street = "210 Blanco Dr",
					Zip = 77030,
					Birthday = new DateTime(1961, 5, 4)
				},
				Password = "python4",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "walker@bevobnb.com",
					Email = "walker@bevobnb.com",
					PhoneNumber = "2143196301",
					FirstName = "Lisa",
					LastName = "Walker",
					MI = "O",
					Street = "9 Bison Circle",
					Zip = 75238,
					Birthday = new DateTime(2003, 4, 18)
				},
				Password = "walkameter",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "chang@bevobnb.com",
					Email = "chang@bevobnb.com",
					PhoneNumber = "2103521329",
					FirstName = "Gregory",
					LastName = "Chang",
					MI = "J",
					Street = "9003 Joshua St",
					Zip = 78260,
					Birthday = new DateTime(1958, 4, 26)
				},
				Password = "pupgang",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "derek@bevobnb.com",
					Email = "derek@bevobnb.com",
					PhoneNumber = "5125556789",
					FirstName = "Derek",
					LastName = "Dreibrodt",
					MI = "X",
					Street = "4 Privet Dr",
					Zip = 78705,
					Birthday = new DateTime(2001, 1, 1)
				},
				Password = "2cool4u",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					UserName = "rester@bevobnb.com",
					Email = "rester@bevobnb.com",
					PhoneNumber = "2103521329",
					FirstName = "Amy",
					LastName = "Rester",
					MI = "K",
					Street = "2110 Speedway",
					Zip = 78705,
					Birthday = new DateTime(2000, 1, 1)
				},
				Password = "KIzGreat",
				RoleName = "Admin"
			});

			String errorFlag = "";
			IdentityResult result = new IdentityResult();
			try
			{
				foreach (AddUserModel aum in AllUsers)
				{
					errorFlag = aum.User.Email;
					result = await
					Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
				}
			}
			catch (Exception ex)
			{
				throw new Exception("  There was a problem adding user with email: " + errorFlag, ex);
			}
			return result;
		}
		
	}
}
