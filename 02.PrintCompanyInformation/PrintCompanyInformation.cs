using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string website = Console.ReadLine();
            string managerName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Company Name: {0}", companyName);
            Console.WriteLine("Company Address: {0}", companyAddress);
            Console.WriteLine("Company Number: {0}", phoneNumber);
            Console.WriteLine("Company Fax: {0}", faxNumber);
            Console.WriteLine("Company Website: {0}", website);
            Console.WriteLine("Manager first name: {0}", managerName);
            Console.WriteLine("Manager last name: {0}", managerLastName);
            Console.WriteLine("Manager Number: {0}", managerAge);
            Console.WriteLine("Manager Age: {0}", managerPhone);

        }
    }

