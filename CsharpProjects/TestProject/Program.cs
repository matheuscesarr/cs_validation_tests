int number = 0;
bool confirm = false;

do
{
Console.WriteLine("Enter an integer value between 5 and 10");
string answer = Console.ReadLine();
confirm = Int32.TryParse(answer,out number);
    if (confirm)
    {
            if (number >=5 && number<=10)
            {
            Console.WriteLine($"Your input value ({number}) has been accepted.");
            } else 
            {
                Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
            }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (!confirm);

string role= "";
confirm = false;
do {
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        role = Console.ReadLine().Trim().ToLower();
        confirm=true;
        switch (role)
        {

            case "administrator":
            Console.WriteLine("Your input value (Administrator) has been accepted.");
            break;

            case "manager":
            Console.WriteLine("Your input value (Manager) has been accepted.");
            break;

            case "user":
            Console.WriteLine("Your input value (User) has been accepted.");
            break;

            default:
            Console.WriteLine($@"The role name that you entered, ""{role}"" is not valid.");
            confirm=false;
            break;

        } 
   

} while (!confirm);

Console.WriteLine($@"You are the {role[0].ToString().ToUpper() + role.Substring(1)} number {number}!");