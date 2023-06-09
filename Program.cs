
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using Bogus;
using BogusExamples.Models;

var faker = new Faker();
// Create Fake Product
const int minPrice = 1_000;
const int maxPrice = 999_999;
var fakeProduct = new Product()
{
    Id = faker.Random.Number(1,100),
    Name = faker.Commerce.ProductName(),
    Description = faker.Lorem.Paragraph(),
    ImageUrl = faker.Image.PicsumUrl(500,500),
    CreatedDate = faker.Date.Past(),//Create Fake Date In past
    ExpireDate = faker.Date.Future(),//Create Fake Date In Future
    Price = faker.Random.Number(minPrice, maxPrice),
    DiscountPercent = faker.Random.Decimal()
        .OrDefault(faker, 0.8f),//Decimal between 0 and 1, 80% zero
    Company = new Company()
    {
        Name = faker.Company.CompanyName(),
        Suffix = faker.Company.CompanySuffix(),
        City = faker.Address.City(),
        State = faker.Address.State(),
        ZipCode = faker.Address.ZipCode(),
        StreetName = faker.Address.StreetName(),
        Owner = new User()
        {
            FirstName = faker.Name.FirstName(),
            LastName = faker.Name.LastName(),
            Age = faker.Random.Number(30,80)
                .OrDefault(faker,.7f,45),//Int between 30 and 80, 70% 45
            Email = faker.Internet.ExampleEmail(),
        }
    }
};
Console.WriteLine(
    JsonSerializer.Serialize(fakeProduct,
        new JsonSerializerOptions()
        {
            WriteIndented = true
        }));
