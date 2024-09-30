using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class Program
    {
        static string connectionString = @"Data Source=DESKTOP-936JTB0;Initial Catalog=EmployeeDb;Integrated Security=True;Trust Server Certificate=True";

        // Method to insert employee data into the Employees table
        static void InsertEmployee(int employeeId, string firstName, string lastName, string email, int mobileNo, string address)
        {
            string query = "INSERT INTO Employees (EmployeeId, FirstName, LastName, Email, MobileNo, Address) " +
                           "VALUES (@EmployeeId, @FirstName, @LastName, @Email, @MobileNo, @Address)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Adding parameters to prevent SQL injection
                command.Parameters.AddWithValue("@EmployeeId", employeeId);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@MobileNo", mobileNo);
                command.Parameters.AddWithValue("@Address", address);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Employee added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Insert operation failed.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        // Method to insert employee data into the Employees table
        static void InsertEmployeeDetails()
        {
            // Collect employee data for insertion
            Console.Write("Enter Employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());

            if(employeeId < 1)
            {
                Console.WriteLine("Error: Employee Id Must be Greater than 0");
                return;
            }

            Console.Write("Enter First Name: ");
            string? firstName = Console.ReadLine();

            if(string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("First name Cannot be empty");
                return;
            }
            

            Console.Write("Enter Last Name: ");
            string? lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string? email = Console.ReadLine();

            Console.Write("Enter Mobile Number: ");
            int mobileNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Address: ");
            string? address = Console.ReadLine();

            InsertEmployee(employeeId, firstName, lastName, email, mobileNo, address);

        }

        // Method to delete an employee from the Employees table
        static void DeleteEmployee(int employeeId)
        {
            string query = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", employeeId);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine($"Employee with ID {employeeId} deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"No employee found with ID {employeeId}.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        // Method to delete an employee from the Employees table
        static void DeleteEmployeeDetails()
        {
            Console.Write("Enter the Employee ID to delete: ");
            int employeeIdToDelete = int.Parse(Console.ReadLine());
            DeleteEmployee(employeeIdToDelete);
        }

        // Method to update employee data in the Employees table
        static void UpdateEmployee(int employeeId, string email, int mobileNo, string address)
        {
            string query = "UPDATE Employees SET Email = @Email, MobileNo = @MobileNo, Address = @Address WHERE EmployeeId = @EmployeeId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@EmployeeId", employeeId);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@MobileNo", mobileNo);
                command.Parameters.AddWithValue("@Address", address);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine($"Employee with ID {employeeId} updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"No employee found with ID {employeeId}.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        // Method to collect employee data and update an employee
        static void UpdateEmployeeDetails()
        {
            Console.Write("Enter Employee ID to update: ");
            int employeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter new Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter new Mobile Number: ");
            int mobileNo = int.Parse(Console.ReadLine());

            Console.Write("Enter new Address: ");
            string address = Console.ReadLine();

            // Call the update method to update the employee data in the database
            UpdateEmployee(employeeId, email, mobileNo, address);
        }

        // Method to display all employees from the Employees table
        static void DisplayAllEmployees()
        {
            string query = "SELECT EmployeeId, FirstName, LastName, Email, MobileNo, Address FROM Employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Check if there are rows to display
                    if (reader.HasRows)
                    {
                        Console.WriteLine("\nEmployee Details:");
                        Console.WriteLine("-------------------------------------------------");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["EmployeeId"]}");
                            Console.WriteLine($"Name: {reader["FirstName"]} {reader["LastName"]}");
                            Console.WriteLine($"Email: {reader["Email"]}");
                            Console.WriteLine($"Mobile No: {reader["MobileNo"]}");
                            Console.WriteLine($"Address: {reader["Address"]}");
                            Console.WriteLine("-------------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No employees found.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        // Main method
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Employee Management System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display All Employees (Not implemented)");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string ?choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InsertEmployeeDetails();
                        break;

                    case "2":
                        UpdateEmployeeDetails();
                        break;

                    case "3":
                        DeleteEmployeeDetails();
                        break;

                    case "4":
                        DisplayAllEmployees();  // Call display method
                        break;

                    case "5":
                        Console.WriteLine("Bye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("===============================================================================");
            }
        }
    }
}
