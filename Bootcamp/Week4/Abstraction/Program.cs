namespace Abstraction
{
    class Program
    {
        static void Main()
        {
            Employee pManager = new ProjectManager() // Create new ProjectManager and assign values
            {
                Name = "Kutay",
                Surname = "Özcan",
                Department = "IT"
            };
            pManager.Task(); // Call Task() method for ProjectManager

            Employee sDeveloper = new SoftwareDeveloper() // Create new SoftwareDeveloper and assign values
            {
                Name = "Ata",
                Surname = "Arslan",
                Department = "IT"
            };
            sDeveloper.Task(); // Call Task() method for SoftwareDeveloper

            Employee sManager = new SalesManager() // Create new SalesManager and assign values
            {
                Name = "Emin",
                Surname = "Patır",
                Department = "IT"
            };
            sManager.Task(); // Call Task() method for SalesManager
        }
    }
}