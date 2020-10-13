using System;
using System.Collections.Generic;
using MorningChallenges.Models;

namespace MorningChallenges
{
  class Day2 // controller
  {
    public Dictionary<string, User> Users { get; set; }

    public void Login()
    {
      bool valid = false;
      Console.Clear();
      while (!valid)
      {
        Console.Write("Please Login to continue\nUsername:");
        string username = Console.ReadLine().ToLower();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        // ALWAYS CHECK THAT DICTIONARY HAS A KEY BEFORE YOU TRY TO USE IT
        if (Users.ContainsKey(username) && Users[username].ValidatePassword(password))
        {
          System.Console.WriteLine("success");
          valid = true;
        }
        else
        {
          System.Console.WriteLine("fail");
        }

      }
    }

    public void Register(User newUser)
    {
      Users.Add(newUser.Name.ToLower(), newUser);
    }

    public Day2()
    {
      // YOU MUST INSTATIATE ANY COLLECTION TYPE
      Users = new Dictionary<string, User>();
      User mark = new User("mark", "iHeartCode");
      User jake = new User("Jake", "iH3artCod3");
      User darryl = new User("darryl", "CodeRox");

      Register(mark);
      Register(jake);
      Register(darryl);
    }
  }
}