

Console.WriteLine("Enter a two letter state code to learn its capital.");
string state = Console.ReadLine();
state = state.ToUpper();

string capital = "I don't know!!!!";

if (state == "OH")
{
    capital = "Columbus";
}
else if (state == "KY")
{
    capital = "Frankfort";
}
else if (state == "IN")
{
    capital= "Indianapolis";
}
