using System;
using System.Collections.Generic;
using Model;


namespace DataLayer
{
    public class Profile
    {
        public void DisplayGroup(Group group)
        {
            Console.WriteLine("Group Name: " + group.Name);
            Console.WriteLine("Group Members: " + group.Members);
            Console.WriteLine("Debut Date: " + group.DebutDate);
            Console.WriteLine("Company: " + group.Company);
        }
    }
}
