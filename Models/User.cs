namespace MorningChallenges.Models
{
  class User
  {
    public string Name { get; }
    private string _password { get; set; }

    public bool ValidatePassword(string input)
    {
      // NOTE same same
      return input == _password;
      // if(input == _password){
      //   return true;
      // }
      // return false;
    }

    public User(string name, string password)
    {
      Name = name;
      _password = password;
    }
  }
}