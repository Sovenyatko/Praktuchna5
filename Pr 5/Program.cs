namespace Pr_5;
using System;
using System.Collections.Generic;

enum SoftwareCompany
{
    Kiev1, Kiev2, Kiev3, Kharkiv1, Kharkiv2, Kharkiv3
}

class Program
{
    static void Main(string[] args)
    {
        // перелiк фiрм з використанням констант
        Console.WriteLine("Список фiрм:");
        Console.WriteLine($"{(int)SoftwareCompany.Kiev1}. Фiрма з м. Київ 1");
        Console.WriteLine($"{(int)SoftwareCompany.Kiev2}. Фiрма з м. Київ 2");
        Console.WriteLine($"{(int)SoftwareCompany.Kiev3}. Фiрма з м. Київ 3");
        Console.WriteLine($"{(int)SoftwareCompany.Kharkiv1}. Фiрма з м. Харкiв 1");
        Console.WriteLine($"{(int)SoftwareCompany.Kharkiv2}. Фiрма з м. Харкiв 2");
        Console.WriteLine($"{(int)SoftwareCompany.Kharkiv3}. Фiрма з м. Харкiв 3");

        // ввiд номерiв фiрм
        Console.Write("Введiть номери фiрм через кому: ");
        string input = Console.ReadLine();
        string[] companyNumbers = input.Split(',');
        List<SoftwareCompany> selectedCompanies = new List<SoftwareCompany>();
        foreach (string number in companyNumbers)
        {
            if (Enum.IsDefined(typeof(SoftwareCompany), int.Parse(number)))
            {
                selectedCompanies.Add((SoftwareCompany)int.Parse(number));
            }
        }

        // виведення вiдповiдного перелiку фiрм
        Console.WriteLine("Список обраних фiрм:");
        Console.WriteLine("М. Київ:");
        foreach (SoftwareCompany company in selectedCompanies)
        {
            if (company == SoftwareCompany.Kiev1 || company == SoftwareCompany.Kiev2 || company == SoftwareCompany.Kiev3)
            {
                Console.WriteLine(company.ToString());
            }
        }
        Console.WriteLine("М. Харкiв:");
        foreach (SoftwareCompany company in selectedCompanies)
        {
            if (company == SoftwareCompany.Kharkiv1 || company == SoftwareCompany.Kharkiv2 || company == SoftwareCompany.Kharkiv3)
            {
                Console.WriteLine(company.ToString());
            }
        }

        // виведення прiзвища автора програми
        Console.WriteLine("Прiзвище автора програми: ваше прiзвище");
        Console.ReadKey();
    }
}
