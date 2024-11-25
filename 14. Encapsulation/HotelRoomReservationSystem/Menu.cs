using HotelRoomReservationSystem.Managers;
using HotelRoomReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem
{
    public class Menu
	{
        private static UserManager userManager = new UserManager();
		private static User loggedInUser = null;

		private static RoomManager roomManager = new RoomManager();

		private static ReservationManager reservationManager = new ReservationManager();
		

        public static void MainMenu()
		{
            int command;
			while (true)
			{
				Console.Clear();
				if (loggedInUser != null)
				{
					Console.WriteLine($"Hello, {loggedInUser.Username}");
				}
				Console.WriteLine("Main Menu");
				Console.WriteLine("1. Login/Register");
				Console.WriteLine("2. View Profile");
				Console.WriteLine("3. View Rooms");
				Console.WriteLine("4. Make Reservation");
				Console.WriteLine("5. Cancel Reservation");
				Console.WriteLine("0. Exit");
				Console.Write("Choose an option: ");

				if (!int.TryParse(Console.ReadLine(), out command))
				{
					Console.WriteLine("Invalid input! Please enter a number between 0 and 5.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
					continue;
				}

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
			int command;
			while (true)
			{
				Console.Clear();
                if (loggedInUser != null)
                {
                    Console.WriteLine($"Hello, {loggedInUser.Username}");
                }
                Console.WriteLine("Authentication Menu");
				Console.WriteLine("1. Login");
				Console.WriteLine("2. Register");
				Console.WriteLine("0. Back");
				Console.Write("Choose an option: ");

				if (!int.TryParse(Console.ReadLine(), out command))
				{
					Console.WriteLine("Invalid input! Please enter a number between 0 and 2.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
					continue;
				}

				switch (command)
				{
					case 0:
						{
							return;
						}
					case 1:
						{
							loggedInUser = userManager.LoginUser();
						}
						break;
					case 2:
						{
							loggedInUser = userManager.RegisterUser();
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
			int command;
			while (true)
			{
				Console.Clear();
                if (loggedInUser != null)
                {
                    Console.WriteLine($"Hello, {loggedInUser.Username}");
                }
                Console.WriteLine("Profile Menu");
				Console.WriteLine("1. Details");
				Console.WriteLine("2. History");
				Console.WriteLine("0. Back");
				Console.Write("Choose an option: ");

				if (!int.TryParse(Console.ReadLine(), out command))
				{
					Console.WriteLine("Invalid input! Please enter a number between 0 and 2.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
					continue;
				}

				switch (command)
				{
					case 0:
						{
							return;
						}
					case 1:
						{
							userManager.ShowProfileDetails(loggedInUser);
						}
						break;
					case 2:
						{
							Console.Clear();
							Console.WriteLine("Profile History Menu");
							if (loggedInUser != null)
							{
                                ShowReservationsForUser(loggedInUser.Username);
                            }
							else
							{
								Console.WriteLine("You are not logged in.");
							}
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
							break;
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
			int command;
			while (true)
			{
				Console.Clear();
                if (loggedInUser != null)
                {
                    Console.WriteLine($"Hello, {loggedInUser.Username}");
                }
                Console.WriteLine("View Rooms Menu");
				Console.WriteLine("0. Back");
				Console.WriteLine();
				roomManager.ShowAllRoomTypes();

				Console.Write("Choose an option: ");


				if (!int.TryParse(Console.ReadLine(), out command))
				{
					Console.WriteLine("Invalid input! Please enter a number between 0 and 4.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
					continue;
				}

				switch (command)
				{
					case 0:
						{
							return;
						}
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
            int command;
            while (true)
			{
				Console.Clear();			
                if (loggedInUser != null)
                {
                    Console.WriteLine($"Hello, {loggedInUser.Username}");
                }
                Console.WriteLine("Make Reservation Menu");
				Console.WriteLine("1. Single Room");
				Console.WriteLine("2. Double Room");
				Console.WriteLine("3. Deluxe Room");
				Console.WriteLine("4. Suite Room");
				Console.WriteLine("0. Back");
				Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out command))
                {
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 4.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                switch (command)
				{
					case 0:
						{
							return;
						}
					case 1:
						{
							Console.Clear();
							MakeReservationPerRoomTypeMenu("Single Room");
                        }
						break;
					case 2:
						{
                            Console.Clear();
                            MakeReservationPerRoomTypeMenu("Double Room");
                        }
						break;
					case 3:
						{
                            Console.Clear();
                            MakeReservationPerRoomTypeMenu("Deluxe Room");
                        }
						break;
					case 4:
						{
                            Console.Clear();
                            MakeReservationPerRoomTypeMenu("Suite Room");
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
				string command;

				Console.Clear();
                if (loggedInUser != null)
                {
                    Console.WriteLine($"Hello, {loggedInUser.Username}");
                }
                Console.WriteLine("Cancel Reservation Menu");
				if (loggedInUser != null)
				{
                    ShowReservationsForUser(loggedInUser.Username);
                    Console.Write("Enter reservation number: ");

					command = Console.ReadLine();

					int reservationRoomNumber = reservationManager.CancelReservation(command);
					if (reservationRoomNumber != 0)
					{
						roomManager.FreeRoomByRoomNumber(reservationRoomNumber);
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
						break;
                    }
					else
					{
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
						continue;
                    }
                }
				else
				{
                    Console.WriteLine("You need to be logged in.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
                }
				

			}
		}

        private static void ShowReservationsForUser(string username)
        {
            var userReservations = reservationManager.GetAllReservationsForUser(username);

			foreach (var reservation in userReservations)
			{
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Reservation ID: {reservation.Id}");
				Console.WriteLine($"Room Number: {reservation.RoomNumber}");
				Console.WriteLine($"User: {reservation.User}");
				Console.WriteLine($"Status: {reservation.ReservationStatus}");			
			}
            Console.WriteLine("-------------------------------");
        }

        private static void MakeReservationPerRoomTypeMenu(string roomType)
		{
			int command;
            List<Room> availableRooms = roomManager.PrintAvailableRoomsOfType(roomType);
            if (availableRooms.Count > 0)
            {
                Console.WriteLine("1: Book Room 0: Back");
                Console.Write("Choose an option: ");
                if (!int.TryParse(Console.ReadLine(), out command))
                {
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 1.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    return;
                }
                if (command == 1)
                {
                    if (loggedInUser != null)
                    {
                        int roomNumber = availableRooms[0].RoomNumber;
                        roomManager.BookRoomByRoomNumber(roomNumber);
                        reservationManager.CreateReservation(roomNumber, loggedInUser.Username);
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You need to be logged in.");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                    }

                }
                else if (command == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 1.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("No available rooms.");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
	}
}
