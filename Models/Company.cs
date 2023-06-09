namespace BogusExamples.Models;

public class Company
{
    public string Name { get; set; }
    public string Suffix { get; set; }
    public string StreetName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public User Owner { get; set; }

}