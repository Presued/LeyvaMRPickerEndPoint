//Manuel L.
//10-27-22
//Resturant Picker EndPoint
//The user will be able to select a number between 1-3 and each one of those numbers will be a different style of food
//Once you select a number it will choose a random food iteam from that catagory 
//Peer Review: Brandon Le - Code works properly. I was able to get a randomized answer from the category that I chose by entering either 1, 2, or 3 in the end of the URL. There's no data validation, but other than that everything works and is good to go. Good job overall! I liked his choices for the restaurants :)


using Microsoft.AspNetCore.Mvc;

namespace LeyvaMRPickerEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ResturantPController : ControllerBase
{
    [HttpGet]
    [Route("pick")]
    public string selection()
    {
        return "1 Fast Food \n2 - Mexican Food \n3 - Chinese Food";
    }
    [HttpGet]
    [Route("pick/{number11}")]
    public string Math(int number11)
    {
        string answer = "";
        string message = "";
        if (number11 == 1)
        {
            string[] fFood = { " McDonalds ", " Wendys ", " Taco Bell ", " A&W ", " KFC ", " Dairy Queen ", " Burger King ", " SubWay ", " Popeyes ", " Raise n Canes" };
            message = "You choose Fast Food ~ ";
            Random random = new Random();
            int randomOut = random.Next(0, 10);
            answer = fFood[randomOut];
        }
        if (number11 == 2)
        {
            string[] mfood = { " El Foresto ", " Tacos Chapala ", " Pollo Local ", " Don Rafas ", " King Taco ", " Casa Flores ", " la tapitia ", " Nena's ", " Tacos El Pelon ", " Mi Ranchito Cafe " };
            message = "You choose Mexican Food ~ ";
            Random random = new Random();
            int randomOut = random.Next(0, 10);
            answer = mfood[randomOut];
        }
        if (number11 == 3)
        {
            string[] cfood = { " China Palace ", " Golden Star ", " China Express ", " Louie's Chinese Resturant ", " Sun's Garden ", " Shermans Buffet ", " Panda Express ", " Yen Du Resturant ", " China Work Express ", " Luu's Chicken Bowl " };
            message = "You choose Chinese Food ~ ";
            Random random = new Random();
            int randomOut = random.Next(0, 10);
            answer = cfood[randomOut];
        }
        return $"{message} You should go eat : {answer}";
    }
}
