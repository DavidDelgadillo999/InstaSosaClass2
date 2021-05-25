using System;

namespace InstaGramSosa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Users myUser = new Users();
            myUser.UserId = 1;
            myUser.UserName = "Mario Sosa";

            Console.WriteLine(myUser.UserId);
            Console.WriteLine(myUser.UserName);
        }
    }
}

public class Users
{
    public string UserId { get; set; }
    public string UserName { get; set; }
}
public class Roles 
{
    public string RokeId { get; set; }
    public string RoleName { get; set; }
}
public class Images
{
    public string ImageId { get; set; }
    public string ImageName { get; set; }
}
public class Rules
{
    public string RulesId { get; set; }
    public string RuleName { get; set; }
}
public class Posts
{
    public string PostId { get; set; }
    public string PostDate { get; set; }
}
public class Comments
{
    public string CommentId { get; set; }
    public string TheComment { get; set; }
}