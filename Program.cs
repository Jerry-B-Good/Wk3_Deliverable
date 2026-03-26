using System.Text;

Console.Write("Shelly Hello has a programmable macro keyboard. ");
Console.WriteLine("She uses it to enter her password automatically to login fields, so she doesn't show keystrokes.");
Console.Write("However, her login keeps failing due to incorrect password. ");
Console.WriteLine("To correct, Shelly has to view password to change the wrong characters.\n");

char[] Hello = ['\u0057', '\u0069', '\u0072', '\u006C', '\u0064', '\u0031'];
string showPW = new string(Hello);

Console.WriteLine($"The autofill: {showPW}\n");

Console.WriteLine("Now she must spot and change the wrong characters.\n");

Console.WriteLine("Can you guess Shelly's correct password?");
foreach (char item in Hello)
{
    char[] realPW = ['\u0057', '\u006F', '\u0072', '\u006C', '\u0064', '\u0021'];
    for (int i = 0; i < realPW.Length; i++)
    {
        if (item != realPW[i])
        {
            Hello[i] = realPW[i];
        }
    }
    //Uncomment the next line to peek.
    //Console.Write(item);
}