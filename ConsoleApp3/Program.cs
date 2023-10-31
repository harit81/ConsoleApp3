// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");
string first = string.Empty;
string Second = string.Empty;
string third = string.Empty;
first = "";
Second = "";
//third = "";
//Console.WriteLine(first ?? Second ?? third ?? "Four");
//Console.WriteLine(!string.IsNullOrWhiteSpace(first) ? first : !string.IsNullOrWhiteSpace(Second) ? Second : 
//!string.IsNullOrWhiteSpace(third) ? third : "FOUR" );

//int time = 20;
//string result = (time < 18) ? "Good day." : "Good evening.";
//Console.WriteLine(result);
//DateTime date1 = new DateTime(2019, 11, 11);

//// Converts the object to string 
//string s1 = string.Format("{0:Y}", date1);
//Console.WriteLine(s1);
System.Globalization.CultureInfo culture =
        new System.Globalization.CultureInfo("en-In");
Decimal pricePerOunce = 17.36m;
String s = String.Format("The current price is {0:C2} per ounce.",
                         pricePerOunce);
Console.WriteLine(s);
// Result if current culture is en-US:
//      The current price is $17.36 per ounce.
using (var httpClient = new HttpClient())
{
    using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://uatappservice.tigerlrm.com/api/CommonServices/GetAllCountryCode"))
    {
        var response = await httpClient.SendAsync(request);
        Console.WriteLine(response.ToString());

    }
}