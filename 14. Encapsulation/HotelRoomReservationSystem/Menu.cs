using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem
{
	public class Menu
	{

		public static void MainMenu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Main Menu");
				Console.WriteLine("1. Login/Register");
				Console.WriteLine("2. View Profile");
				Console.WriteLine("3. View Rooms");
				Console.WriteLine("4. Make Reservation");
				Console.WriteLine("5. Cancel Reservation");
				Console.WriteLine("0. Exit");
				Console.Write("Choose an option: ");
				int command = int.Parse(Console.ReadLine());

				switch (command)
				{
					case 0:
						{
							Console.WriteLine("Exiting the application.");
							return;
						}
					case 1:
						{
							AuthenticationMenu();
						}
						break;
					case 2:
						{
							ProfileMenu();
						}
						break;
					case 3:
						{
							ViewRoomsMenu();
						}
						break;
					case 4:
						{
							MakeReservationMenu();
						}
						break;
					case 5:
						{
							CancelReservationMenu();
						}
						break;
					default:
						{
							Console.WriteLine("Enter valid option");
						}
						break;
				}

			}
		}

		private static void AuthenticationMenu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Authentication Menu");
				Console.WriteLine("1. Login");
				Console.WriteLine("2. Register");
				Console.WriteLine("0. Back");
				Console.Write("Choose an option: ");
				int command = int.Parse(Console.ReadLine());

				switch (command)
				{
					case 0:
						{
							return;
						}
					case 1:
						{
							Console.Clear();
							Console.WriteLine("Login Menu");
						}
						break;
					case 2:
						{
							Console.Clear();
							Console.WriteLine("Register Menu");
						}
						break;
					default:
						{
							Console.WriteLine("Enter valid option");
						}
						break;
				}

			}
		}

		private static void ProfileMenu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Profile Menu");
				Console.WriteLine("1. Details");
				Console.WriteLine("2. History");
				Console.WriteLine("0. Back");
				Console.Write("Choose an option: ");
				int command = int.Parse(Console.ReadLine());

				switch (command)
				{
					case 0:
						{
							return;
						}
					case 1:
						{
							Console.Clear();
							Console.WriteLine("Profile Details Menu");
						}
						break;
					case 2:
						{
							Console.Clear();
							Console.WriteLine("Profile History Menu");
						}
						break;
					default:
						{
							Console.WriteLine("Enter valid option");
						}
						break;
				}
			}
		}
		private static void ViewRoomsMenu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("View Rooms Menu");
				Console.WriteLine("1. Single Room");
				Console.WriteLine("2. Double Room");
				Console.WriteLine("3. Deluxe Room");
				Console.WriteLine("4. Suite");
				Console.WriteLine("0. Back");
				Console.Write("Choose an option: ");
				int command = int.Parse(Console.ReadLine());

				switch (command)
				{
					case 0:
						{
							return;
						}
					case 1:
						{
							Console.Clear();
							Console.WriteLine("Single Room");
						}
						break;
					case 2:
						{
							Console.Clear();
							Console.WriteLine("Double Room");
						}
						break;
					case 3:
						{
							Console.Clear();
							Console.WriteLine("Deluxe Room");
						}
						break;
					case 4:
						{
							Console.Clear();
							Console.WriteLine("Suite");
						}
						break;
					default:
						{
							Console.WriteLine("Enter valid option");
						}
						break;
				}
			}

		}
		private static void MakeReservationMenu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Make Reservation Menu");
				Console.WriteLine("1. Single Room");
				Console.WriteLine("2. Double Room");
				Console.WriteLine("3. Deluxe Room");
				Console.WriteLine("4. Suite");
				Console.WriteLine("0. Back");
				Console.Write("Choose an option: ");
				int command = int.Parse(Console.ReadLine());

				switch (command)
				{
					case 0:
						{
							return;
						}
					case 1:
						{
							Console.Clear();
							Console.WriteLine("Single Room");
						}
						break;
					case 2:
						{
							Console.Clear();
							Console.WriteLine("Double Room");
						}
						break;
					case 3:
						{
							Console.Clear();
							Console.WriteLine("Deluxe Room");
						}
						break;
					case 4:
						{
							Console.Clear();
							Console.WriteLine("Suite");
						}
						break;
					default:
						{
							Console.WriteLine("Enter valid option");
						}
						break;
				}
			}
		}

		private static void CancelReservationMenu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Cancel Reservation Menu");
				Console.WriteLine("1. Single Room");
				Console.WriteLine("2. Double Room");
				Console.WriteLine("3. Deluxe Room");
				Console.WriteLine("4. Suite");
				Console.WriteLine("0. Back");
				Console.Write("Choose an option: ");
				int command = int.Parse(Console.ReadLine());

				switch (command)
				{
					case 0:
						{
							return;
						}
					case 1:
						{
							Console.Clear();
							Console.WriteLine("Single Room");
						}
						break;
					case 2:
						{
							Console.Clear();
							Console.WriteLine("Double Room");
						}
						break;
					case 3:
						{
							Console.Clear();
							Console.WriteLine("Deluxe Room");
						}
						break;
					case 4:
						{
							Console.Clear();
							Console.WriteLine("Suite");
						}
						break;
					default:
						{
							Console.WriteLine("Enter valid option");
						}
						break;
				}
			}
		}
	}
}
