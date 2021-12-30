using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static JsonUsers.Users;

namespace JsonUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            UserArray userarray=new UserArray();

            List<UserInfo> listuser = new List<UserInfo>();
            var geo1 = new Geo
            {
                lat="-37.3159",
                lng ="81.1496"
            };
            var geo2 = new Geo
            {
                lat="-43.9509",
                lng ="-34.4618"
            };
            var geo3 = new Geo
            {
                lat="-68.6102",
                lng ="-47.0653"
            };
            var adres1 = new Address
            {
                street="Kulas Light"
                ,suite="Apt. 556",
                city ="Gwenborough",
                zipcode ="92998-3874",
                geo =geo1
            };
            var adres2 = new Address
            {
                street="Victor Plains",
                suite ="Suite 879",
                city ="Wisokyburgh",
                zipcode ="90566-7771",
                geo =geo2
            };
            var adres3 = new Address
            {
                street="Douglas Extension",
                suite ="Suite 847",
                city ="McKenziehaven",
                zipcode ="59590-4157",
                geo =geo3
            };
            var comp1 = new Company
            {
                name="Romaguera-Crona",
                catchPhrase ="Multi-layered client-server neural-net",
                bs="harness real-time e-markets"
            };
            var comp2 = new Company
            {
                name="Deckow-Crist",
                catchPhrase ="Proactive didactic contingency",
                bs ="synergize scalable supply-chains"
            };
            var comp3 = new Company
            {
                name="Romaguera-Jacobson",
                catchPhrase ="Face to face bifurcated interface",
                bs ="e-enable strategic applications"
            };
            var user1 = new UserInfo
            {
                id="1",
                name= "Leanne Graham",
                username="Bret",
                email= "Sincere@april.biz",
                address=adres1,
                phone= "1-770-736-8031 x56442",
                website= "hildegard.org",
                company=comp1
            };
            var user2 = new UserInfo
            {
                id = "2",
                name = "Ervin Howell",
                username = "Antonette",
                email = "Shanna@melissa.tv",
                address = adres2,
                phone = "010-692-6593 x09125",
                website = "anastasia.net",
                company = comp2
            };
            var user3 = new UserInfo
            {
                id = "3",
                name = "Clementine Bauch",
                username = "Samantha",
                email = "Nathan@yesenia.net",
                address = adres3,
                phone = "1-463-123-4447",
                website = "ramiro.info",
                company = comp3
            };
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            listuser.Add(user1);
            listuser.Add(user2);
            listuser.Add(user3);

            userarray.userInfo = listuser;

            Console.WriteLine(JsonSerializer.Serialize(userarray, options));
           
            Console.ReadLine();
        }
    }
}
