using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleQL.Migrations
{
    /// <inheritdoc />
    public partial class DbInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contractor",
                columns: new[] { "Id", "CompanyName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Schumm - Barton", "Sheryl", "VonRueden" },
                    { 2, "Mills, Kemmer and Deckow", "Hector", "Smith" },
                    { 3, "Rowe - Bogisich", "Oliver", "Morissette" },
                    { 4, "Hane, Kling and Maggio", "Mack", "Howe" },
                    { 5, "McGlynn Group", "Annie", "Kling" },
                    { 6, "Romaguera, Doyle and McKenzie", "Celia", "DuBuque" },
                    { 7, "Purdy - Cassin", "Eloise", "Rosenbaum" },
                    { 8, "Roob Group", "Tommy", "Donnelly" },
                    { 9, "Bailey, Brown and Hackett", "Kimberly", "Bergnaum" },
                    { 10, "Bartell - Williamson", "Olive", "Howe" },
                    { 11, "Hayes - Luettgen", "Jack", "Schamberger" },
                    { 12, "Bogisich, Wolff and Prohaska", "Betsy", "Hickle" },
                    { 13, "Maggio Inc", "Gilberto", "Luettgen" },
                    { 14, "Pfeffer and Sons", "Douglas", "Langosh" },
                    { 15, "Ebert Inc", "Melanie", "Jakubowski" },
                    { 16, "Bogan - Orn", "Emmett", "Kris" },
                    { 17, "Towne - Gulgowski", "Mamie", "Kub" },
                    { 18, "Hilpert and Sons", "Wilbert", "Block" },
                    { 19, "Kshlerin and Sons", "Randall", "Orn" },
                    { 20, "McClure - Bahringer", "Bob", "Tillman" },
                    { 21, "Sporer Group", "Derrick", "Heidenreich" },
                    { 22, "Feil LLC", "Darin", "Mayer" },
                    { 23, "Kemmer - Walter", "Hannah", "Fay" },
                    { 24, "Lockman and Sons", "Robin", "Schamberger" },
                    { 25, "Langworth - Ebert", "Timothy", "Jacobson" },
                    { 26, "Schultz - Prosacco", "Chris", "Schamberger" },
                    { 27, "Denesik - Spencer", "Wilbert", "Bogisich" },
                    { 28, "Kovacek - Stiedemann", "Gerard", "King" },
                    { 29, "Auer Group", "Jake", "Bartoletti" },
                    { 30, "Langworth, Davis and Cummerata", "Erick", "Lemke" },
                    { 31, "Batz - Daniel", "Phil", "Powlowski" },
                    { 32, "Reilly Inc", "Jane", "Will" },
                    { 33, "Towne, Reichel and O'Conner", "Laverne", "Collier" },
                    { 34, "Conn - Koelpin", "Angelo", "Nader" },
                    { 35, "Mohr Group", "Donald", "Kassulke" },
                    { 36, "Reilly Group", "Judith", "Schuster" },
                    { 37, "Bernier Group", "Louis", "Harber" },
                    { 38, "Jacobi and Sons", "Ada", "Crooks" },
                    { 39, "Jones, Fay and Funk", "Mark", "Green" },
                    { 40, "Zboncak LLC", "Gary", "Hettinger" },
                    { 41, "Leffler - Blanda", "Roderick", "Johns" },
                    { 42, "Barton - Parker", "Mona", "Rogahn" },
                    { 43, "Lowe Inc", "Felipe", "Lang" },
                    { 44, "Greenholt - Fadel", "Alejandro", "Quigley" },
                    { 45, "Schumm Group", "Tanya", "Lang" },
                    { 46, "Olson, Bechtelar and Kuhn", "Seth", "Muller" },
                    { 47, "Cormier - Bartell", "Lana", "Pollich" },
                    { 48, "Becker - Welch", "Roman", "Thiel" },
                    { 49, "Lebsack - Rodriguez", "Angel", "Lind" },
                    { 50, "Brekke - Anderson", "Erin", "Brown" },
                    { 51, "MacGyver - Ortiz", "Ervin", "DuBuque" }
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "BuildingNumber", "City", "ContractorId", "State", "Street", "Zip" },
                values: new object[,]
                {
                    { 1, "6994", "Zulatown", 1, "Arkansas", "34837 Fidel Tunnel", "45413-2482" },
                    { 2, "77375", "Lisettefurt", 1, "Mississippi", "2696 Nicole Mountain", "02809" },
                    { 3, "9257", "New Devonte", 1, "Nevada", "227 Wunsch Pine", "91458" },
                    { 4, "9383", "Blockmouth", 2, "New Jersey", "21290 Funk Plaza", "82606" },
                    { 5, "6206", "North Mayra", 2, "Delaware", "3183 Wolff Mill", "06767" },
                    { 6, "94459", "Hammesville", 2, "Georgia", "7486 Bashirian Islands", "70892" },
                    { 7, "796", "Lake Lauryland", 5, "Missouri", "34170 Considine Field", "55764" },
                    { 8, "60575", "West Jazmyn", 6, "Georgia", "113 Adrien Knoll", "73676" },
                    { 9, "51882", "Port Constance", 6, "Louisiana", "976 Ava Junctions", "68639" },
                    { 10, "35832", "Emilport", 6, "Idaho", "01858 Reyna Manor", "14671-5654" },
                    { 11, "217", "East Aliza", 7, "New Hampshire", "2274 Edythe Fall", "45945" },
                    { 12, "341", "West Tryciashire", 7, "Nebraska", "0296 Lind Drive", "09585-1910" },
                    { 13, "271", "Greenfelderburgh", 8, "New Hampshire", "50769 Lorine Crossroad", "69660" },
                    { 14, "983", "Rutherfordstad", 8, "Maine", "3428 Lenna Squares", "19040-9542" },
                    { 15, "58583", "West Lelandmouth", 8, "Idaho", "1477 Dewitt Isle", "21352" },
                    { 16, "872", "Alvahmouth", 9, "Arizona", "2973 Charlene Viaduct", "65904-6445" },
                    { 17, "364", "Rathfort", 9, "New Mexico", "277 Maryam Park", "62438" },
                    { 18, "4218", "Ricehaven", 11, "Alaska", "67882 Daryl Skyway", "39030-9260" },
                    { 19, "8974", "Hartmannmouth", 11, "New Jersey", "8888 Morar Common", "88894" },
                    { 20, "64606", "Carmelaberg", 11, "Iowa", "7471 Casper Circles", "54599-5612" },
                    { 21, "340", "Naderville", 12, "Wyoming", "65569 Witting Knoll", "15907" },
                    { 22, "4798", "West Carolanne", 12, "Massachusetts", "824 Greyson Spring", "90556-2131" },
                    { 23, "94320", "Kaleighborough", 12, "Ohio", "2183 Hand Plaza", "04020" },
                    { 24, "7582", "Deloreschester", 14, "Iowa", "6374 Della Roads", "20752" },
                    { 25, "59587", "North Kaylin", 15, "Kansas", "1258 Laurine Mountain", "32100-3809" },
                    { 26, "0477", "North Kaelatown", 17, "Texas", "0027 Laila Junction", "11550-6051" },
                    { 27, "30222", "West June", 17, "Tennessee", "9533 McDermott Road", "42035-9760" },
                    { 28, "6090", "Kentonmouth", 17, "West Virginia", "79478 Thurman Circles", "76411" },
                    { 29, "5440", "Ulicesville", 18, "Montana", "033 Dawn Curve", "96856" },
                    { 30, "29222", "Reillyborough", 20, "Missouri", "1451 Brekke Fall", "39168-8588" },
                    { 31, "958", "Kutchside", 22, "Louisiana", "5231 Rodrigo Hill", "69811-3253" },
                    { 32, "01105", "West Guy", 23, "Wisconsin", "07492 Reymundo Port", "56158-9879" },
                    { 33, "65215", "Connerburgh", 24, "California", "7977 Koelpin Court", "21851" },
                    { 34, "73040", "D'Amoretown", 24, "New Mexico", "271 Mitchell Lane", "90848" },
                    { 35, "27201", "Lake Roscoefort", 24, "Texas", "0718 Koss Gateway", "18435" },
                    { 36, "2608", "West Janae", 25, "Georgia", "61411 Cassie Trace", "23957-9462" },
                    { 37, "9725", "Wunschmouth", 26, "Vermont", "37382 Zula Divide", "90140-2268" },
                    { 38, "60568", "Tadmouth", 27, "Delaware", "06057 Frederic Pines", "20168-4486" },
                    { 39, "37921", "North Greenstad", 27, "Connecticut", "00737 Caleigh Walk", "65464" },
                    { 40, "03002", "Lake Zoila", 28, "Indiana", "284 Evangeline Hill", "83119" },
                    { 41, "221", "West Orpha", 28, "Vermont", "01317 Glover Parks", "01535" },
                    { 42, "1864", "Port Sandrine", 28, "Illinois", "41324 Geovanny Stream", "85384-0556" },
                    { 43, "9665", "Terranceview", 29, "Pennsylvania", "6675 Osinski Orchard", "23001-8133" },
                    { 44, "2575", "Cruickshankborough", 29, "Delaware", "84970 Okuneva Cove", "79056-0774" },
                    { 45, "16381", "New Brooks", 29, "Missouri", "7208 Monroe Highway", "75215-2822" },
                    { 46, "8052", "North Dayanamouth", 30, "Florida", "306 Hane Cape", "56490-4304" },
                    { 47, "198", "New Kaileychester", 30, "Idaho", "287 Pearlie Avenue", "37674-1895" },
                    { 48, "16719", "East Aaron", 31, "Maine", "084 Margarita Springs", "30175-5181" },
                    { 49, "940", "North Jean", 32, "Nebraska", "462 Armando Groves", "41062" },
                    { 50, "10156", "Haleybury", 33, "New Mexico", "7751 Ivory Junction", "91239" },
                    { 51, "405", "Port Bonnie", 33, "New Hampshire", "3634 Thompson Forge", "51779-1710" },
                    { 52, "92660", "Volkmantown", 34, "Florida", "5412 Lenny Centers", "86706-8130" },
                    { 53, "00145", "Yoshikoland", 34, "Oklahoma", "8877 Kamryn Club", "44017-3028" },
                    { 54, "0628", "East Rebecca", 36, "New Hampshire", "02280 Abshire View", "33152-3828" },
                    { 55, "2091", "North Else", 36, "Arkansas", "6079 Kasey Locks", "90527" },
                    { 56, "2148", "Carleemouth", 38, "New York", "4558 Ashleigh Radial", "57317" },
                    { 57, "6335", "Lake Javonbury", 39, "Oregon", "1889 Ruthe View", "82785" },
                    { 58, "843", "Lake Hans", 39, "Utah", "420 Whitney Center", "12988" },
                    { 59, "550", "East Everardo", 39, "Utah", "48579 Moen Shoals", "78382" },
                    { 60, "6379", "Gradytown", 40, "Georgia", "5381 Kirk Orchard", "71616" },
                    { 61, "25508", "East Derekton", 41, "Kentucky", "575 Dooley Forges", "39904" },
                    { 62, "454", "New Waltonshire", 42, "North Dakota", "491 Daphney Underpass", "78388" },
                    { 63, "70957", "Jedidiahborough", 42, "Arkansas", "136 Emmie Rapid", "10879" },
                    { 64, "5218", "Osinskishire", 42, "Alaska", "12844 Gabriella Harbor", "82928" },
                    { 65, "309", "Emmerichfurt", 43, "Oregon", "5611 Al Mountains", "25680-8152" },
                    { 66, "16172", "West Nellieview", 43, "New Mexico", "0364 Wunsch Hills", "94384-4956" },
                    { 67, "41866", "South Leonefurt", 43, "Michigan", "73518 Katarina Orchard", "36273-0262" },
                    { 68, "946", "Port Mertietown", 44, "Alabama", "948 McGlynn Knoll", "11850-9480" },
                    { 69, "42116", "East Judgechester", 44, "Florida", "2565 Cierra Ports", "59998" },
                    { 70, "281", "Malindafort", 44, "Nebraska", "5474 Nikolas Row", "27630-3215" },
                    { 71, "76547", "Justinaland", 45, "Delaware", "01357 Daugherty Park", "61753-7151" },
                    { 72, "72656", "Darrinmouth", 45, "Montana", "612 Huels Junctions", "32560-9507" },
                    { 73, "54130", "Xzavierton", 45, "Maryland", "570 Waelchi Harbors", "53577-6990" },
                    { 74, "072", "Sengerfurt", 46, "Arkansas", "8659 Rafaela Street", "02206-3924" },
                    { 75, "950", "Turcottefurt", 46, "Iowa", "072 Torphy Junctions", "18172-8352" },
                    { 76, "4860", "Hoppefort", 46, "Colorado", "09554 Ankunding Knoll", "61865-8115" },
                    { 77, "88905", "Heathcotehaven", 47, "Georgia", "915 Blanca Pass", "70788-8856" },
                    { 78, "27897", "Mrazstad", 48, "Michigan", "89634 Dianna Island", "52718" },
                    { 79, "75748", "Earnestinechester", 49, "Kentucky", "50764 Koelpin Road", "30790" },
                    { 80, "03100", "Adamsborough", 49, "Minnesota", "93444 DuBuque Spring", "20342" },
                    { 81, "72678", "Schillerstad", 51, "Montana", "5348 Tyler Fords", "81166-7611" },
                    { 82, "8246", "Russbury", 51, "Texas", "1618 Harry Dale", "90560" }
                });

            migrationBuilder.InsertData(
                table: "Case",
                columns: new[] { "Id", "CreditorId", "Currency", "Debt", "Description", "Number" },
                values: new object[,]
                {
                    { 1, 1, "GIP", 991.03m, "Et blanditiis exercitationem consequatur ut et.", "0" },
                    { 2, 2, "MMK", 421.51m, "Dolor recusandae eos ea soluta vel officia laboriosam assumenda.", "0" },
                    { 3, 7, "BSD", 585.92m, "Ullam facilis libero quam accusamus ut aspernatur.", "0" },
                    { 4, 11, "SVC", 952.76m, "Voluptas asperiores adipisci quia quibusdam delectus assumenda est.", "0" },
                    { 5, 17, "AUD", 910.93m, "Qui et facere ratione aliquam eaque odio doloribus et.", "1" },
                    { 6, 25, "BZD", 136.45m, "Aut sed sed in.", "1" },
                    { 7, 28, "BND", 900.14m, "Ad aliquam qui repellendus.", "0" },
                    { 8, 32, "MDL", 550.23m, "Est qui dolorem in at dignissimos.", "1" },
                    { 9, 42, "SVC", 330.23m, "A et veniam voluptatem minima et voluptatum dolorem delectus.", "0" },
                    { 10, 47, "BIF", 895.83m, "Et nisi aut dicta.", "1" }
                });

            migrationBuilder.InsertData(
                table: "ContractorPropertyType",
                columns: new[] { "Id", "ContractorId", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 1, "atque", 0 },
                    { 2, 1, "sed", 1 },
                    { 3, 1, "et", 2 },
                    { 4, 2, "mollitia", 0 },
                    { 5, 2, "ut", 1 },
                    { 6, 2, "facere", 2 },
                    { 7, 3, "et", 0 },
                    { 8, 3, "est", 1 },
                    { 9, 3, "error", 2 },
                    { 10, 4, "eveniet", 0 },
                    { 11, 4, "aliquam", 1 },
                    { 12, 4, "qui", 2 },
                    { 13, 5, "atque", 0 },
                    { 14, 5, "aut", 1 },
                    { 15, 5, "occaecati", 2 },
                    { 16, 6, "molestiae", 0 },
                    { 17, 6, "velit", 1 },
                    { 18, 6, "minus", 2 },
                    { 19, 7, "et", 0 },
                    { 20, 7, "nulla", 1 },
                    { 21, 7, "natus", 2 },
                    { 22, 8, "molestiae", 0 },
                    { 23, 8, "officiis", 1 },
                    { 24, 8, "quia", 2 },
                    { 25, 9, "aut", 0 },
                    { 26, 9, "illo", 1 },
                    { 27, 9, "iure", 2 },
                    { 28, 10, "modi", 0 },
                    { 29, 10, "et", 1 },
                    { 30, 10, "ad", 2 },
                    { 31, 11, "et", 0 },
                    { 32, 11, "sunt", 1 },
                    { 33, 11, "qui", 2 },
                    { 34, 12, "earum", 0 },
                    { 35, 12, "labore", 1 },
                    { 36, 12, "iure", 2 },
                    { 37, 13, "non", 0 },
                    { 38, 13, "natus", 1 },
                    { 39, 13, "est", 2 },
                    { 40, 14, "sunt", 0 },
                    { 41, 14, "inventore", 1 },
                    { 42, 14, "in", 2 },
                    { 43, 15, "nostrum", 0 },
                    { 44, 15, "cumque", 1 },
                    { 45, 15, "aperiam", 2 },
                    { 46, 16, "corporis", 0 },
                    { 47, 16, "quis", 1 },
                    { 48, 16, "dignissimos", 2 },
                    { 49, 17, "tenetur", 0 },
                    { 50, 17, "magni", 1 },
                    { 51, 17, "rerum", 2 },
                    { 52, 18, "earum", 0 },
                    { 53, 18, "ad", 1 },
                    { 54, 18, "voluptatibus", 2 },
                    { 55, 19, "cumque", 0 },
                    { 56, 19, "eligendi", 1 },
                    { 57, 19, "qui", 2 },
                    { 58, 20, "cum", 0 },
                    { 59, 20, "aspernatur", 1 },
                    { 60, 20, "dolor", 2 },
                    { 61, 21, "non", 0 },
                    { 62, 21, "tempora", 1 },
                    { 63, 21, "nihil", 2 },
                    { 64, 22, "ullam", 0 },
                    { 65, 22, "qui", 1 },
                    { 66, 22, "voluptatem", 2 },
                    { 67, 23, "quia", 0 },
                    { 68, 23, "voluptas", 1 },
                    { 69, 23, "non", 2 },
                    { 70, 24, "sit", 0 },
                    { 71, 24, "architecto", 1 },
                    { 72, 24, "ut", 2 },
                    { 73, 25, "minus", 0 },
                    { 74, 25, "at", 1 },
                    { 75, 25, "ducimus", 2 },
                    { 76, 26, "aliquam", 0 },
                    { 77, 26, "aut", 1 },
                    { 78, 26, "non", 2 },
                    { 79, 27, "dolores", 0 },
                    { 80, 27, "cum", 1 },
                    { 81, 27, "aliquid", 2 },
                    { 82, 28, "rerum", 0 },
                    { 83, 28, "repellat", 1 },
                    { 84, 28, "provident", 2 },
                    { 85, 29, "id", 0 },
                    { 86, 29, "blanditiis", 1 },
                    { 87, 29, "sed", 2 },
                    { 88, 30, "iste", 0 },
                    { 89, 30, "voluptates", 1 },
                    { 90, 30, "laudantium", 2 },
                    { 91, 31, "quibusdam", 0 },
                    { 92, 31, "quibusdam", 1 },
                    { 93, 31, "nemo", 2 },
                    { 94, 32, "occaecati", 0 },
                    { 95, 32, "est", 1 },
                    { 96, 32, "ipsa", 2 },
                    { 97, 33, "expedita", 0 },
                    { 98, 33, "voluptates", 1 },
                    { 99, 33, "impedit", 2 },
                    { 100, 34, "in", 0 },
                    { 101, 34, "pariatur", 1 },
                    { 102, 34, "consequatur", 2 },
                    { 103, 35, "voluptas", 0 },
                    { 104, 35, "iure", 1 },
                    { 105, 35, "voluptates", 2 },
                    { 106, 36, "non", 0 },
                    { 107, 36, "atque", 1 },
                    { 108, 36, "sit", 2 },
                    { 109, 37, "vel", 0 },
                    { 110, 37, "illo", 1 },
                    { 111, 37, "autem", 2 },
                    { 112, 38, "est", 0 },
                    { 113, 38, "quia", 1 },
                    { 114, 38, "nobis", 2 },
                    { 115, 39, "consequatur", 0 },
                    { 116, 39, "nesciunt", 1 },
                    { 117, 39, "in", 2 },
                    { 118, 40, "commodi", 0 },
                    { 119, 40, "eum", 1 },
                    { 120, 40, "eum", 2 },
                    { 121, 41, "repellendus", 0 },
                    { 122, 41, "placeat", 1 },
                    { 123, 41, "praesentium", 2 },
                    { 124, 42, "nemo", 0 },
                    { 125, 42, "eos", 1 },
                    { 126, 42, "modi", 2 },
                    { 127, 43, "totam", 0 },
                    { 128, 43, "labore", 1 },
                    { 129, 43, "quibusdam", 2 },
                    { 130, 44, "quis", 0 },
                    { 131, 44, "a", 1 },
                    { 132, 44, "id", 2 },
                    { 133, 45, "amet", 0 },
                    { 134, 45, "est", 1 },
                    { 135, 45, "exercitationem", 2 },
                    { 136, 46, "doloribus", 0 },
                    { 137, 46, "sit", 1 },
                    { 138, 46, "sit", 2 },
                    { 139, 47, "possimus", 0 },
                    { 140, 47, "assumenda", 1 },
                    { 141, 47, "et", 2 },
                    { 142, 48, "placeat", 0 },
                    { 143, 48, "et", 1 },
                    { 144, 48, "quo", 2 },
                    { 145, 49, "libero", 0 },
                    { 146, 49, "repudiandae", 1 },
                    { 147, 49, "sint", 2 },
                    { 148, 50, "ipsum", 0 },
                    { 149, 50, "harum", 1 },
                    { 150, 50, "consequatur", 2 },
                    { 151, 51, "voluptatem", 0 },
                    { 152, 51, "nihil", 1 },
                    { 153, 51, "at", 2 }
                });

            migrationBuilder.InsertData(
                table: "Email",
                columns: new[] { "Id", "Address", "ContractorId", "Type" },
                values: new object[,]
                {
                    { 1, "Jaquelin.OHara@yahoo.com", 2, 0 },
                    { 2, "Agnes90@hotmail.com", 4, 0 },
                    { 3, "Asha.Kozey@hotmail.com", 4, 0 },
                    { 4, "Ruthie.Stanton@yahoo.com", 4, 1 },
                    { 5, "Quinten.Wintheiser60@yahoo.com", 4, 2 },
                    { 6, "Bryon28@yahoo.com", 5, 1 },
                    { 7, "Nasir.Dickinson95@hotmail.com", 5, 0 },
                    { 8, "Harry_Schmitt@gmail.com", 5, 2 },
                    { 9, "Gudrun.Barrows64@gmail.com", 6, 0 },
                    { 10, "Johathan42@gmail.com", 6, 1 },
                    { 11, "Vladimir29@gmail.com", 7, 1 },
                    { 12, "Jaylen_Weissnat@gmail.com", 7, 2 },
                    { 13, "Meta.Zboncak87@yahoo.com", 7, 0 },
                    { 14, "Lincoln.Gorczany@yahoo.com", 7, 2 },
                    { 15, "Jannie.Bogan60@hotmail.com", 7, 0 },
                    { 16, "Cameron_West94@gmail.com", 8, 0 },
                    { 17, "Alia.Schinner@yahoo.com", 9, 2 },
                    { 18, "Jewell.Effertz@yahoo.com", 10, 0 },
                    { 19, "Myles46@yahoo.com", 10, 1 },
                    { 20, "Erna13@hotmail.com", 10, 1 },
                    { 21, "Cortez14@hotmail.com", 10, 0 },
                    { 22, "Rebeca50@gmail.com", 11, 2 },
                    { 23, "Alena22@yahoo.com", 11, 2 },
                    { 24, "Cordelia.Von41@yahoo.com", 11, 2 },
                    { 25, "Colton_Stanton@gmail.com", 12, 1 },
                    { 26, "Kaylie_Senger@hotmail.com", 12, 1 },
                    { 27, "Clementina3@hotmail.com", 12, 1 },
                    { 28, "Sibyl.Anderson@hotmail.com", 12, 1 },
                    { 29, "Justice.Friesen@yahoo.com", 12, 1 },
                    { 30, "Kaylin.Nicolas52@yahoo.com", 14, 2 },
                    { 31, "Pietro8@hotmail.com", 14, 2 },
                    { 32, "Wendy12@hotmail.com", 15, 0 },
                    { 33, "Myriam_Leuschke4@gmail.com", 15, 0 },
                    { 34, "Kellie22@yahoo.com", 15, 0 },
                    { 35, "Graciela_Willms@gmail.com", 15, 0 },
                    { 36, "Shaun.Rippin57@yahoo.com", 16, 0 },
                    { 37, "Vivienne.Ratke92@gmail.com", 17, 1 },
                    { 38, "Marisol4@hotmail.com", 17, 2 },
                    { 39, "Yasmin_Senger80@yahoo.com", 17, 0 },
                    { 40, "Edward.Schowalter47@gmail.com", 18, 1 },
                    { 41, "Antonietta.Bayer34@gmail.com", 18, 2 },
                    { 42, "Rex_VonRueden@hotmail.com", 18, 2 },
                    { 43, "Columbus_Schimmel54@hotmail.com", 19, 1 },
                    { 44, "Paolo_Bruen77@gmail.com", 19, 1 },
                    { 45, "Camila80@gmail.com", 19, 1 },
                    { 46, "Angelita68@gmail.com", 19, 1 },
                    { 47, "Carmine_Howell@hotmail.com", 19, 2 },
                    { 48, "Jazlyn_Effertz@yahoo.com", 20, 0 },
                    { 49, "Darrin.Maggio@yahoo.com", 22, 0 },
                    { 50, "Bailee.Leuschke58@gmail.com", 22, 1 },
                    { 51, "Aubrey.Predovic@yahoo.com", 22, 1 },
                    { 52, "Nina.Connelly@yahoo.com", 23, 2 },
                    { 53, "Nigel_Breitenberg79@yahoo.com", 24, 0 },
                    { 54, "Brent_Smitham@hotmail.com", 24, 0 },
                    { 55, "Georgiana88@yahoo.com", 24, 2 },
                    { 56, "Lyric72@yahoo.com", 25, 2 },
                    { 57, "Bernita_Bogisich@hotmail.com", 25, 2 },
                    { 58, "Evangeline.Kessler50@hotmail.com", 25, 0 },
                    { 59, "Hans62@hotmail.com", 25, 1 },
                    { 60, "Elenor.Skiles@hotmail.com", 26, 2 },
                    { 61, "Guy17@gmail.com", 26, 1 },
                    { 62, "Laney88@gmail.com", 26, 1 },
                    { 63, "Rose15@yahoo.com", 27, 2 },
                    { 64, "Dalton.Gislason63@hotmail.com", 28, 0 },
                    { 65, "Josiah_Lakin73@hotmail.com", 29, 2 },
                    { 66, "Floyd_Konopelski@gmail.com", 29, 2 },
                    { 67, "Ila_Reichel10@yahoo.com", 29, 0 },
                    { 68, "Stefanie.Tremblay68@gmail.com", 29, 2 },
                    { 69, "Evie_Stanton@yahoo.com", 29, 2 },
                    { 70, "Melvina.Johnson@yahoo.com", 30, 1 },
                    { 71, "Una_VonRueden@yahoo.com", 30, 0 },
                    { 72, "Jay_Pfeffer@gmail.com", 30, 0 },
                    { 73, "Rosa.Adams@hotmail.com", 30, 2 },
                    { 74, "Winona_Kuhlman@hotmail.com", 31, 0 },
                    { 75, "Anjali_McDermott50@gmail.com", 31, 2 },
                    { 76, "Raven.Ruecker@gmail.com", 32, 2 },
                    { 77, "Rubie_Medhurst@gmail.com", 33, 1 },
                    { 78, "Evans.Block8@yahoo.com", 33, 2 },
                    { 79, "Ottis.Grant@hotmail.com", 33, 2 },
                    { 80, "Brielle52@gmail.com", 34, 2 },
                    { 81, "Tyrell1@hotmail.com", 34, 1 },
                    { 82, "Dorothea.Franecki@gmail.com", 34, 1 },
                    { 83, "Anjali26@gmail.com", 36, 2 },
                    { 84, "Polly_Walsh40@gmail.com", 36, 0 },
                    { 85, "Tate_King@yahoo.com", 37, 2 },
                    { 86, "Diego33@yahoo.com", 37, 0 },
                    { 87, "Guillermo.Carroll48@hotmail.com", 37, 1 },
                    { 88, "Eryn90@yahoo.com", 38, 0 },
                    { 89, "Mark75@yahoo.com", 38, 1 },
                    { 90, "Adella70@gmail.com", 38, 0 },
                    { 91, "Mariana.Lang54@gmail.com", 39, 1 },
                    { 92, "Webster_Lebsack59@yahoo.com", 39, 1 },
                    { 93, "Elian.Crist@yahoo.com", 40, 2 },
                    { 94, "Darby23@gmail.com", 40, 1 },
                    { 95, "Kara_Schimmel50@yahoo.com", 41, 2 },
                    { 96, "Gussie32@gmail.com", 41, 0 },
                    { 97, "Clark.McCullough@hotmail.com", 41, 2 },
                    { 98, "Marcelo59@yahoo.com", 41, 0 },
                    { 99, "Paul.Koch7@yahoo.com", 43, 1 },
                    { 100, "Ernesto.Dooley@hotmail.com", 43, 1 },
                    { 101, "Johnson84@yahoo.com", 43, 1 },
                    { 102, "Garnett1@yahoo.com", 45, 1 },
                    { 103, "Hunter63@yahoo.com", 45, 2 },
                    { 104, "Vivian.Hartmann@gmail.com", 45, 0 },
                    { 105, "Marion41@gmail.com", 45, 1 },
                    { 106, "Kenton_Okuneva39@yahoo.com", 45, 1 },
                    { 107, "Karli_MacGyver97@hotmail.com", 46, 0 },
                    { 108, "Isabel95@gmail.com", 46, 1 },
                    { 109, "Evie13@gmail.com", 46, 2 },
                    { 110, "Brice.Maggio@hotmail.com", 46, 1 },
                    { 111, "Jarred.Feest@yahoo.com", 47, 2 },
                    { 112, "Stanton9@yahoo.com", 47, 2 },
                    { 113, "Frederick53@hotmail.com", 47, 2 },
                    { 114, "Sallie77@hotmail.com", 47, 2 },
                    { 115, "Kattie.Crist@yahoo.com", 47, 2 },
                    { 116, "Reagan.Larson49@yahoo.com", 48, 2 },
                    { 117, "Hazle_Grant21@hotmail.com", 48, 1 },
                    { 118, "Eryn_Collier@yahoo.com", 48, 1 },
                    { 119, "Lina29@yahoo.com", 48, 0 },
                    { 120, "Janet2@hotmail.com", 48, 0 },
                    { 121, "Paris49@gmail.com", 49, 1 },
                    { 122, "Garret_Armstrong11@yahoo.com", 49, 1 },
                    { 123, "Brook_Goodwin88@yahoo.com", 49, 0 },
                    { 124, "Eva_Bartell@yahoo.com", 49, 1 },
                    { 125, "Paula39@gmail.com", 49, 1 },
                    { 126, "Allison31@hotmail.com", 50, 0 },
                    { 127, "London_Hamill36@gmail.com", 50, 1 },
                    { 128, "Alexys_Kuhn45@yahoo.com", 51, 2 },
                    { 129, "Finn33@hotmail.com", 51, 1 },
                    { 130, "Jedediah73@gmail.com", 51, 2 },
                    { 131, "Merlin_Satterfield@gmail.com", 51, 1 }
                });

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "Id", "ContractorId", "Number", "Type" },
                values: new object[,]
                {
                    { 1, 1, "265.476.4456", 1 },
                    { 2, 1, "(553) 399-3581 x2332", 2 },
                    { 3, 1, "944.962.8523", 0 },
                    { 4, 1, "(898) 508-0640", 2 },
                    { 5, 1, "1-940-672-5421 x6251", 0 },
                    { 6, 2, "1-982-667-6866", 1 },
                    { 7, 2, "664.331.4645 x557", 0 },
                    { 8, 2, "549-203-1494", 2 },
                    { 9, 2, "898-234-0051 x748", 1 },
                    { 10, 2, "(260) 345-1972", 2 },
                    { 11, 2, "547-425-0499 x843", 2 },
                    { 12, 2, "512-847-1798 x11776", 1 },
                    { 13, 2, "212-373-2711", 1 },
                    { 14, 2, "1-482-428-7165 x910", 2 },
                    { 15, 2, "1-865-691-4911", 2 },
                    { 16, 3, "(564) 957-3562 x754", 2 },
                    { 17, 3, "516.994.4713 x589", 2 },
                    { 18, 3, "422.662.7943 x595", 2 },
                    { 19, 3, "1-659-834-9257", 2 },
                    { 20, 3, "882.819.6871 x55392", 2 },
                    { 21, 3, "(770) 245-3614 x1761", 2 },
                    { 22, 3, "1-741-907-2373", 1 },
                    { 23, 3, "869-455-0511 x391", 0 },
                    { 24, 3, "542.644.9290", 1 },
                    { 25, 4, "493-400-3872", 2 },
                    { 26, 4, "549-224-7341 x21101", 1 },
                    { 27, 4, "575-517-3407", 2 },
                    { 28, 4, "(395) 478-4832 x546", 1 },
                    { 29, 4, "492-497-9285", 1 },
                    { 30, 4, "1-497-236-4778 x6643", 2 },
                    { 31, 4, "918.350.9630 x02353", 1 },
                    { 32, 5, "305-876-8066 x79183", 0 },
                    { 33, 5, "(986) 742-6789 x64051", 2 },
                    { 34, 5, "665-816-6867 x9952", 2 },
                    { 35, 5, "(207) 791-2369", 1 },
                    { 36, 7, "483-452-8241 x3724", 1 },
                    { 37, 7, "608-848-3248", 2 },
                    { 38, 8, "1-614-503-1681 x46620", 2 },
                    { 39, 8, "1-863-685-5383 x52210", 0 },
                    { 40, 9, "976-451-1307", 1 },
                    { 41, 9, "1-646-390-1145 x71368", 1 },
                    { 42, 9, "(772) 598-6720", 2 },
                    { 43, 9, "(997) 452-1547 x747", 0 },
                    { 44, 9, "1-447-220-0965 x124", 1 },
                    { 45, 9, "313-930-7536", 2 },
                    { 46, 9, "(320) 816-4263", 1 },
                    { 47, 9, "435.775.1954 x91166", 0 },
                    { 48, 9, "244-862-4445 x10233", 2 },
                    { 49, 10, "1-261-862-2331", 2 },
                    { 50, 10, "943.378.1713 x3822", 0 },
                    { 51, 10, "206-859-3432 x69272", 2 },
                    { 52, 10, "273-865-1073 x7236", 1 },
                    { 53, 10, "348.825.5397", 1 },
                    { 54, 10, "(819) 961-1199 x94092", 1 },
                    { 55, 10, "415-217-0215 x944", 2 },
                    { 56, 11, "(609) 305-6555 x58535", 1 },
                    { 57, 11, "1-677-521-1611 x5374", 1 },
                    { 58, 11, "433-391-7715", 1 },
                    { 59, 11, "(744) 447-8416 x8602", 1 },
                    { 60, 12, "(340) 571-0431 x3995", 0 },
                    { 61, 12, "1-433-309-2925 x4174", 0 },
                    { 62, 12, "1-239-338-0033 x96455", 2 },
                    { 63, 12, "999-614-4606", 1 },
                    { 64, 12, "963-436-3710 x23847", 2 },
                    { 65, 12, "1-901-628-5622 x355", 1 },
                    { 66, 12, "1-421-677-5546", 1 },
                    { 67, 12, "(645) 306-1892 x664", 2 },
                    { 68, 12, "268.856.5984 x13597", 2 },
                    { 69, 13, "575-411-2481", 1 },
                    { 70, 13, "1-675-295-5733 x242", 2 },
                    { 71, 13, "685-483-6785 x53194", 0 },
                    { 72, 13, "(782) 959-8052 x0734", 0 },
                    { 73, 13, "1-996-840-0325 x264", 2 },
                    { 74, 13, "(274) 820-4280 x943", 2 },
                    { 75, 13, "953-308-9993 x4198", 2 },
                    { 76, 14, "728.681.8759", 2 },
                    { 77, 14, "899-751-7831 x819", 0 },
                    { 78, 14, "1-702-980-9934 x017", 0 },
                    { 79, 14, "587-917-3849 x763", 1 },
                    { 80, 14, "1-972-213-1361 x4476", 0 },
                    { 81, 14, "(344) 289-4357", 2 },
                    { 82, 15, "681.236.3451 x3897", 2 },
                    { 83, 15, "(377) 526-7301", 0 },
                    { 84, 15, "(217) 958-0219 x864", 1 },
                    { 85, 15, "1-854-826-6847", 1 },
                    { 86, 15, "306-456-1544", 2 },
                    { 87, 15, "(229) 528-2361", 2 },
                    { 88, 15, "(510) 415-9332 x49561", 0 },
                    { 89, 15, "(934) 841-3493", 2 },
                    { 90, 15, "535-604-4110 x5130", 1 },
                    { 91, 16, "661.948.7243 x4537", 0 },
                    { 92, 16, "685.980.8782", 0 },
                    { 93, 17, "353.612.0807 x853", 0 },
                    { 94, 17, "766-432-3488", 1 },
                    { 95, 17, "820-974-4238", 1 },
                    { 96, 17, "(909) 984-4245", 1 },
                    { 97, 17, "765.347.3230 x4561", 1 },
                    { 98, 17, "650-827-7443 x299", 2 },
                    { 99, 17, "616-773-6521 x7449", 0 },
                    { 100, 18, "585.990.3843", 0 },
                    { 101, 18, "(355) 734-2497", 2 },
                    { 102, 18, "580.661.9330 x91542", 2 },
                    { 103, 18, "916-284-6051", 0 },
                    { 104, 18, "286-750-2787", 2 },
                    { 105, 18, "350.906.7384 x0598", 1 },
                    { 106, 18, "508-858-2814 x022", 0 },
                    { 107, 18, "946.732.4047", 2 },
                    { 108, 18, "(631) 972-3575", 0 },
                    { 109, 18, "700-491-6200", 1 },
                    { 110, 19, "281.748.9999", 2 },
                    { 111, 19, "947.771.4993 x226", 0 },
                    { 112, 19, "(581) 540-6725 x62279", 2 },
                    { 113, 19, "(555) 499-5461", 2 },
                    { 114, 19, "(344) 661-4483", 1 },
                    { 115, 20, "(332) 580-3775 x94547", 0 },
                    { 116, 20, "(598) 234-0666 x9366", 0 },
                    { 117, 20, "237.582.4387 x9714", 1 },
                    { 118, 20, "(951) 447-6446 x2686", 2 },
                    { 119, 20, "508-815-6159 x26422", 1 },
                    { 120, 20, "598.471.9698 x53121", 0 },
                    { 121, 20, "1-784-373-2461 x887", 2 },
                    { 122, 21, "1-202-646-6850", 0 },
                    { 123, 21, "541.274.2467", 0 },
                    { 124, 22, "1-432-720-3865", 1 },
                    { 125, 22, "637-727-0368 x6527", 0 },
                    { 126, 22, "(449) 814-6800 x7457", 0 },
                    { 127, 22, "1-826-624-0610 x6536", 0 },
                    { 128, 22, "(505) 685-5250 x201", 1 },
                    { 129, 22, "(374) 913-2759 x9455", 0 },
                    { 130, 22, "(559) 421-4918", 0 },
                    { 131, 22, "(542) 725-2030 x3112", 1 },
                    { 132, 22, "757-288-4740", 1 },
                    { 133, 22, "(906) 650-6145", 0 },
                    { 134, 23, "841.418.5656 x939", 1 },
                    { 135, 23, "1-972-542-4720 x18160", 0 },
                    { 136, 23, "884-573-0204 x174", 2 },
                    { 137, 23, "964-796-2117 x9533", 2 },
                    { 138, 23, "242.717.7851 x0105", 2 },
                    { 139, 23, "(557) 782-8888 x95871", 0 },
                    { 140, 23, "571-457-6302 x212", 1 },
                    { 141, 23, "852-597-3621", 0 },
                    { 142, 23, "1-332-399-6727 x0546", 1 },
                    { 143, 24, "331-271-7815 x54425", 2 },
                    { 144, 24, "(296) 599-2966 x9391", 0 },
                    { 145, 24, "(405) 650-9558 x62417", 0 },
                    { 146, 24, "1-888-553-3660", 0 },
                    { 147, 24, "(342) 773-5564", 0 },
                    { 148, 24, "1-651-556-1832 x59033", 1 },
                    { 149, 24, "868-631-6799 x587", 0 },
                    { 150, 24, "968.566.0301", 0 },
                    { 151, 25, "1-623-942-1273", 0 },
                    { 152, 25, "836.383.9476 x100", 2 },
                    { 153, 25, "624-541-2609 x5821", 2 },
                    { 154, 25, "688-632-5879 x6241", 1 },
                    { 155, 25, "1-780-385-7602 x71555", 0 },
                    { 156, 25, "559-591-3325 x17123", 1 },
                    { 157, 25, "1-531-867-9295", 2 },
                    { 158, 25, "(559) 467-3080 x900", 2 },
                    { 159, 25, "1-338-639-0382", 1 },
                    { 160, 26, "567.864.6630", 2 },
                    { 161, 26, "(726) 633-3498", 1 },
                    { 162, 26, "414.212.7129", 2 },
                    { 163, 26, "(403) 907-2848 x57044", 2 },
                    { 164, 26, "(569) 541-4942", 0 },
                    { 165, 26, "787.695.9183 x07125", 2 },
                    { 166, 26, "1-361-287-5358 x76900", 1 },
                    { 167, 26, "397.860.7327 x87033", 0 },
                    { 168, 26, "324-381-1710 x73500", 2 },
                    { 169, 27, "651.786.7245 x13692", 1 },
                    { 170, 27, "(387) 490-4211 x2226", 2 },
                    { 171, 27, "(895) 932-6871", 2 },
                    { 172, 27, "(360) 477-0945 x723", 0 },
                    { 173, 27, "448-486-1012", 0 },
                    { 174, 27, "(255) 800-8256 x23923", 1 },
                    { 175, 27, "499.226.0155 x3692", 2 },
                    { 176, 27, "648.862.6602", 1 },
                    { 177, 28, "704-820-2883", 0 },
                    { 178, 29, "499.888.4540 x63708", 2 },
                    { 179, 29, "1-724-501-2964 x24588", 0 },
                    { 180, 29, "1-867-541-7011", 0 },
                    { 181, 29, "879.747.1547 x04295", 0 },
                    { 182, 29, "(901) 257-2477 x02858", 0 },
                    { 183, 29, "402-818-5923 x10499", 0 },
                    { 184, 29, "(267) 734-5249", 1 },
                    { 185, 29, "914-407-0526", 1 },
                    { 186, 29, "1-643-658-6975 x48167", 0 },
                    { 187, 29, "463-418-7816", 2 },
                    { 188, 30, "(866) 288-8258 x11282", 1 },
                    { 189, 30, "(289) 845-6458 x8300", 0 },
                    { 190, 30, "427-223-1300", 0 },
                    { 191, 30, "938-882-5550", 0 },
                    { 192, 30, "1-328-247-5436 x523", 2 },
                    { 193, 31, "948.842.9346 x35747", 0 },
                    { 194, 31, "(554) 318-1311", 1 },
                    { 195, 31, "604.991.0942 x035", 1 },
                    { 196, 31, "409-988-1428 x154", 0 },
                    { 197, 31, "(205) 729-3092", 0 },
                    { 198, 32, "(232) 641-4276 x29855", 1 },
                    { 199, 32, "1-448-558-1220", 1 },
                    { 200, 32, "668.408.4551 x159", 1 },
                    { 201, 32, "(404) 967-9690", 2 },
                    { 202, 32, "(626) 816-0737 x3249", 0 },
                    { 203, 32, "1-987-695-7917 x50148", 1 },
                    { 204, 32, "520.663.4952 x591", 2 },
                    { 205, 32, "416-808-4580", 0 },
                    { 206, 32, "461-352-1254 x5210", 2 },
                    { 207, 33, "358-754-9739 x583", 2 },
                    { 208, 33, "(761) 999-5868", 1 },
                    { 209, 33, "(512) 936-2645 x8520", 0 },
                    { 210, 33, "869.712.1869 x916", 2 },
                    { 211, 33, "497.769.8685 x404", 1 },
                    { 212, 33, "513.824.8930 x286", 1 },
                    { 213, 33, "1-637-813-6149 x2583", 0 },
                    { 214, 33, "442-856-5077 x460", 0 },
                    { 215, 34, "(880) 594-5106 x3793", 1 },
                    { 216, 35, "830-788-7603", 2 },
                    { 217, 35, "(222) 706-9847", 1 },
                    { 218, 35, "671.592.8748 x8451", 2 },
                    { 219, 35, "522.537.6308 x92545", 2 },
                    { 220, 35, "(767) 255-8897 x58299", 1 },
                    { 221, 35, "1-522-268-6792 x7661", 0 },
                    { 222, 35, "947.266.0256", 1 },
                    { 223, 35, "833.431.0062 x1525", 1 },
                    { 224, 35, "1-989-342-2807", 1 },
                    { 225, 35, "408-361-7138 x8864", 1 },
                    { 226, 36, "(895) 767-1237 x82906", 0 },
                    { 227, 36, "683.860.8519", 0 },
                    { 228, 36, "699-399-2049 x764", 1 },
                    { 229, 37, "1-468-620-4195 x959", 0 },
                    { 230, 37, "233-785-1315 x9941", 2 },
                    { 231, 37, "(443) 712-4666 x430", 1 },
                    { 232, 37, "(616) 981-7446 x3906", 2 },
                    { 233, 37, "1-346-931-6364", 0 },
                    { 234, 38, "473-799-9771 x5244", 1 },
                    { 235, 38, "(451) 595-3025 x160", 2 },
                    { 236, 38, "(350) 662-8059 x43741", 1 },
                    { 237, 38, "(947) 658-2989 x63142", 1 },
                    { 238, 39, "1-849-483-7544 x77814", 1 },
                    { 239, 39, "1-803-362-6736 x9890", 0 },
                    { 240, 39, "582-606-6598 x76816", 1 },
                    { 241, 39, "766-790-4296", 1 },
                    { 242, 39, "(350) 850-8811", 1 },
                    { 243, 39, "(364) 503-7423 x740", 2 },
                    { 244, 40, "(542) 840-2663 x3607", 1 },
                    { 245, 40, "516-617-1145 x9596", 1 },
                    { 246, 40, "(447) 850-4167 x5726", 2 },
                    { 247, 40, "1-296-848-2358 x577", 1 },
                    { 248, 40, "201.492.2526", 1 },
                    { 249, 40, "295.234.9584 x410", 2 },
                    { 250, 40, "945.683.0609", 1 },
                    { 251, 41, "837.438.2046 x9401", 2 },
                    { 252, 42, "472-549-8718 x8157", 2 },
                    { 253, 43, "612.648.5981", 2 },
                    { 254, 43, "606-992-4546", 0 },
                    { 255, 43, "767.330.0556 x45343", 2 },
                    { 256, 43, "(681) 530-8317", 2 },
                    { 257, 43, "(802) 989-0984 x68420", 0 },
                    { 258, 44, "587-897-4807 x169", 1 },
                    { 259, 44, "954.511.0346 x36524", 2 },
                    { 260, 44, "(532) 428-8921", 2 },
                    { 261, 44, "(517) 259-0027 x969", 0 },
                    { 262, 44, "(440) 837-9680 x325", 1 },
                    { 263, 44, "522.649.1279", 1 },
                    { 264, 44, "(407) 824-7472 x52253", 0 },
                    { 265, 44, "980-647-5217", 0 },
                    { 266, 44, "(417) 582-9401 x937", 0 },
                    { 267, 44, "1-831-332-2280 x5317", 0 },
                    { 268, 45, "441-219-5269 x63603", 2 },
                    { 269, 46, "(414) 555-6783", 1 },
                    { 270, 46, "398-457-4186 x81866", 1 },
                    { 271, 46, "299.847.2564", 0 },
                    { 272, 46, "341.363.5719", 2 },
                    { 273, 46, "(503) 228-9704 x83192", 1 },
                    { 274, 47, "789.847.9988 x9672", 0 },
                    { 275, 47, "942-304-0390 x2290", 1 },
                    { 276, 47, "1-503-888-7840 x9663", 1 },
                    { 277, 47, "401-998-4964 x712", 2 },
                    { 278, 47, "600.787.8414", 0 },
                    { 279, 47, "(467) 793-1756 x70370", 0 },
                    { 280, 47, "(370) 716-5164 x179", 0 },
                    { 281, 48, "321-255-0794 x800", 1 },
                    { 282, 48, "473.968.6804", 0 },
                    { 283, 48, "913.390.6232", 2 },
                    { 284, 48, "682.968.9099", 1 },
                    { 285, 49, "737-443-5884 x129", 1 },
                    { 286, 49, "1-546-665-0135 x178", 0 },
                    { 287, 49, "303.785.6139", 0 },
                    { 288, 50, "428.628.4199", 2 },
                    { 289, 50, "(886) 957-9497 x44169", 1 },
                    { 290, 50, "437.803.9664", 2 },
                    { 291, 50, "558.457.0086 x355", 0 },
                    { 292, 50, "218-626-0711 x398", 1 },
                    { 293, 50, "(692) 271-4265 x9299", 0 },
                    { 294, 50, "1-806-519-3279", 2 }
                });

            migrationBuilder.InsertData(
                table: "CaseDebtor",
                columns: new[] { "CaseId", "DebtorId", "EndDate", "Id", "StartDate", "Type" },
                values: new object[,]
                {
                    { 2, 3, new DateTime(2024, 4, 15, 7, 30, 27, 718, DateTimeKind.Local).AddTicks(9549), 1, new DateTime(2023, 5, 17, 10, 9, 30, 325, DateTimeKind.Local).AddTicks(1695), 2 },
                    { 2, 4, new DateTime(2024, 4, 15, 12, 14, 41, 924, DateTimeKind.Local).AddTicks(8786), 2, new DateTime(2024, 1, 16, 18, 55, 32, 318, DateTimeKind.Local).AddTicks(7136), 0 },
                    { 2, 5, new DateTime(2024, 4, 15, 13, 41, 8, 208, DateTimeKind.Local).AddTicks(4054), 3, new DateTime(2023, 12, 22, 17, 11, 19, 385, DateTimeKind.Local).AddTicks(749), 3 },
                    { 2, 6, new DateTime(2024, 4, 15, 5, 13, 43, 591, DateTimeKind.Local).AddTicks(4874), 4, new DateTime(2023, 11, 19, 23, 5, 18, 556, DateTimeKind.Local).AddTicks(2485), 1 },
                    { 3, 8, new DateTime(2024, 4, 14, 22, 51, 18, 812, DateTimeKind.Local).AddTicks(9081), 5, new DateTime(2023, 7, 5, 19, 59, 34, 141, DateTimeKind.Local).AddTicks(5941), 2 },
                    { 3, 9, new DateTime(2024, 4, 15, 7, 20, 7, 155, DateTimeKind.Local).AddTicks(2631), 6, new DateTime(2023, 7, 5, 5, 1, 58, 993, DateTimeKind.Local).AddTicks(9254), 0 },
                    { 3, 10, new DateTime(2024, 4, 15, 7, 3, 40, 427, DateTimeKind.Local).AddTicks(6983), 7, new DateTime(2023, 11, 23, 13, 15, 26, 463, DateTimeKind.Local).AddTicks(5254), 4 },
                    { 4, 12, new DateTime(2024, 4, 15, 11, 58, 36, 26, DateTimeKind.Local).AddTicks(9012), 8, new DateTime(2024, 4, 5, 14, 14, 15, 279, DateTimeKind.Local).AddTicks(9872), 2 },
                    { 4, 13, new DateTime(2024, 4, 15, 8, 29, 24, 514, DateTimeKind.Local).AddTicks(3398), 9, new DateTime(2023, 11, 17, 22, 1, 2, 627, DateTimeKind.Local).AddTicks(9832), 1 },
                    { 4, 14, new DateTime(2024, 4, 14, 23, 31, 26, 266, DateTimeKind.Local).AddTicks(9788), 10, new DateTime(2023, 10, 28, 23, 2, 14, 938, DateTimeKind.Local).AddTicks(9412), 4 },
                    { 4, 15, new DateTime(2024, 4, 15, 16, 11, 43, 98, DateTimeKind.Local).AddTicks(2208), 11, new DateTime(2023, 11, 1, 6, 38, 32, 419, DateTimeKind.Local).AddTicks(1251), 1 },
                    { 4, 16, new DateTime(2024, 4, 15, 12, 4, 5, 633, DateTimeKind.Local).AddTicks(3480), 12, new DateTime(2024, 3, 6, 0, 16, 42, 816, DateTimeKind.Local).AddTicks(4706), 1 },
                    { 5, 18, new DateTime(2024, 4, 15, 7, 51, 31, 61, DateTimeKind.Local).AddTicks(32), 13, new DateTime(2024, 1, 12, 11, 38, 57, 458, DateTimeKind.Local).AddTicks(9275), 4 },
                    { 5, 19, new DateTime(2024, 4, 15, 4, 58, 22, 32, DateTimeKind.Local).AddTicks(4292), 14, new DateTime(2023, 10, 17, 15, 29, 49, 962, DateTimeKind.Local).AddTicks(4175), 4 },
                    { 5, 20, new DateTime(2024, 4, 14, 23, 55, 28, 702, DateTimeKind.Local).AddTicks(8735), 15, new DateTime(2023, 10, 13, 23, 35, 2, 48, DateTimeKind.Local).AddTicks(3638), 1 },
                    { 5, 21, new DateTime(2024, 4, 14, 19, 32, 45, 720, DateTimeKind.Local).AddTicks(164), 16, new DateTime(2024, 3, 9, 17, 41, 53, 206, DateTimeKind.Local).AddTicks(4366), 0 },
                    { 5, 22, new DateTime(2024, 4, 14, 19, 17, 3, 194, DateTimeKind.Local).AddTicks(9367), 17, new DateTime(2023, 11, 5, 1, 8, 20, 906, DateTimeKind.Local).AddTicks(817), 4 },
                    { 5, 23, new DateTime(2024, 4, 15, 10, 6, 28, 152, DateTimeKind.Local).AddTicks(2234), 18, new DateTime(2023, 5, 9, 11, 56, 59, 255, DateTimeKind.Local).AddTicks(934), 0 },
                    { 5, 24, new DateTime(2024, 4, 15, 7, 36, 9, 713, DateTimeKind.Local).AddTicks(7724), 19, new DateTime(2023, 10, 17, 2, 55, 42, 664, DateTimeKind.Local).AddTicks(8127), 2 },
                    { 6, 26, new DateTime(2024, 4, 14, 22, 53, 38, 867, DateTimeKind.Local).AddTicks(7753), 20, new DateTime(2023, 6, 21, 7, 27, 13, 458, DateTimeKind.Local).AddTicks(1052), 0 },
                    { 6, 27, new DateTime(2024, 4, 15, 12, 18, 15, 20, DateTimeKind.Local).AddTicks(428), 21, new DateTime(2023, 11, 18, 11, 41, 1, 644, DateTimeKind.Local).AddTicks(1538), 1 },
                    { 7, 29, new DateTime(2024, 4, 15, 12, 2, 51, 323, DateTimeKind.Local).AddTicks(1330), 22, new DateTime(2023, 4, 15, 20, 36, 51, 404, DateTimeKind.Local).AddTicks(7247), 3 },
                    { 7, 30, new DateTime(2024, 4, 15, 3, 22, 2, 258, DateTimeKind.Local).AddTicks(3798), 23, new DateTime(2023, 6, 10, 12, 9, 47, 842, DateTimeKind.Local).AddTicks(7767), 1 },
                    { 7, 31, new DateTime(2024, 4, 15, 5, 29, 48, 7, DateTimeKind.Local).AddTicks(6439), 24, new DateTime(2024, 2, 3, 11, 3, 35, 138, DateTimeKind.Local).AddTicks(7404), 2 },
                    { 8, 33, new DateTime(2024, 4, 15, 9, 53, 52, 422, DateTimeKind.Local).AddTicks(9116), 25, new DateTime(2023, 7, 24, 9, 46, 43, 219, DateTimeKind.Local).AddTicks(7726), 3 },
                    { 8, 34, new DateTime(2024, 4, 15, 4, 28, 54, 116, DateTimeKind.Local).AddTicks(6879), 26, new DateTime(2023, 8, 2, 8, 16, 36, 672, DateTimeKind.Local).AddTicks(8312), 4 },
                    { 8, 35, new DateTime(2024, 4, 14, 17, 14, 51, 778, DateTimeKind.Local).AddTicks(8354), 27, new DateTime(2023, 8, 20, 10, 36, 0, 137, DateTimeKind.Local).AddTicks(6546), 3 },
                    { 8, 36, new DateTime(2024, 4, 15, 13, 33, 43, 429, DateTimeKind.Local).AddTicks(7136), 28, new DateTime(2024, 1, 17, 6, 17, 31, 64, DateTimeKind.Local).AddTicks(5923), 2 },
                    { 8, 37, new DateTime(2024, 4, 15, 4, 22, 27, 337, DateTimeKind.Local).AddTicks(5379), 29, new DateTime(2024, 2, 3, 20, 22, 58, 227, DateTimeKind.Local).AddTicks(9207), 3 },
                    { 8, 38, new DateTime(2024, 4, 14, 23, 42, 21, 996, DateTimeKind.Local).AddTicks(6590), 30, new DateTime(2024, 2, 13, 17, 4, 54, 996, DateTimeKind.Local).AddTicks(9795), 3 },
                    { 8, 39, new DateTime(2024, 4, 15, 10, 14, 2, 16, DateTimeKind.Local).AddTicks(8347), 31, new DateTime(2023, 6, 2, 9, 2, 10, 870, DateTimeKind.Local).AddTicks(8754), 4 },
                    { 8, 40, new DateTime(2024, 4, 15, 12, 36, 41, 481, DateTimeKind.Local).AddTicks(2890), 32, new DateTime(2023, 11, 13, 7, 15, 58, 673, DateTimeKind.Local).AddTicks(8292), 1 },
                    { 8, 41, new DateTime(2024, 4, 14, 21, 8, 59, 24, DateTimeKind.Local).AddTicks(9568), 33, new DateTime(2023, 10, 25, 9, 56, 36, 681, DateTimeKind.Local).AddTicks(2845), 1 },
                    { 9, 43, new DateTime(2024, 4, 15, 7, 56, 48, 11, DateTimeKind.Local).AddTicks(7490), 34, new DateTime(2023, 10, 2, 14, 4, 47, 937, DateTimeKind.Local).AddTicks(1348), 3 },
                    { 9, 44, new DateTime(2024, 4, 14, 21, 15, 14, 74, DateTimeKind.Local).AddTicks(4776), 35, new DateTime(2024, 2, 11, 15, 10, 3, 467, DateTimeKind.Local).AddTicks(9322), 1 },
                    { 9, 45, new DateTime(2024, 4, 15, 13, 1, 0, 15, DateTimeKind.Local).AddTicks(939), 36, new DateTime(2023, 5, 22, 18, 38, 13, 654, DateTimeKind.Local).AddTicks(4569), 4 },
                    { 9, 46, new DateTime(2024, 4, 15, 10, 51, 43, 424, DateTimeKind.Local).AddTicks(6112), 37, new DateTime(2024, 2, 11, 3, 11, 20, 888, DateTimeKind.Local).AddTicks(7453), 4 },
                    { 10, 48, new DateTime(2024, 4, 15, 3, 9, 32, 855, DateTimeKind.Local).AddTicks(471), 38, new DateTime(2023, 8, 31, 9, 14, 56, 552, DateTimeKind.Local).AddTicks(7079), 4 },
                    { 10, 49, new DateTime(2024, 4, 15, 1, 20, 58, 494, DateTimeKind.Local).AddTicks(5226), 39, new DateTime(2023, 8, 13, 18, 30, 31, 796, DateTimeKind.Local).AddTicks(2898), 0 },
                    { 10, 50, new DateTime(2024, 4, 14, 17, 45, 13, 142, DateTimeKind.Local).AddTicks(8022), 40, new DateTime(2023, 11, 29, 16, 27, 16, 978, DateTimeKind.Local).AddTicks(9559), 4 },
                    { 10, 51, new DateTime(2024, 4, 14, 22, 28, 15, 899, DateTimeKind.Local).AddTicks(8265), 41, new DateTime(2023, 5, 24, 20, 45, 36, 173, DateTimeKind.Local).AddTicks(288), 0 }
                });

            migrationBuilder.InsertData(
                table: "CaseProperty",
                columns: new[] { "Id", "CaseId", "ContractorPropertyId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "14.09.2023 04:49:35" },
                    { 2, 1, 2, "14.04.2024 17:07:52" },
                    { 3, 1, 3, "Rustic Fresh Bike" },
                    { 4, 2, 4, "22.01.2024 15:47:24" },
                    { 5, 2, 5, "15.04.2024 07:20:57" },
                    { 6, 2, 6, "Generic Cotton Keyboard" },
                    { 7, 3, 19, "03.07.2023 23:49:06" },
                    { 8, 3, 20, "15.04.2024 09:00:04" },
                    { 9, 3, 21, "Generic Wooden Keyboard" },
                    { 10, 4, 31, "01.11.2023 20:30:12" },
                    { 11, 4, 32, null },
                    { 12, 4, 33, "Rustic Steel Bacon" },
                    { 13, 5, 49, "13.09.2023 10:42:34" },
                    { 14, 5, 50, "15.04.2024 14:14:05" },
                    { 15, 5, 51, "Generic Steel Pizza" },
                    { 16, 6, 73, "22.01.2024 18:06:32" },
                    { 17, 6, 74, "15.04.2024 10:13:30" },
                    { 18, 6, 75, "Practical Rubber Pizza" },
                    { 19, 7, 82, "16.10.2023 14:33:05" },
                    { 20, 7, 83, "15.04.2024 16:07:48" },
                    { 21, 7, 84, null },
                    { 22, 8, 94, "04.12.2023 02:21:20" },
                    { 23, 8, 95, "14.04.2024 20:12:25" },
                    { 24, 8, 96, "Small Concrete Pants" },
                    { 25, 9, 124, "11.10.2023 15:51:53" },
                    { 26, 9, 125, null },
                    { 27, 9, 126, "Gorgeous Plastic Chicken" },
                    { 28, 10, 139, "13.10.2023 11:25:13" },
                    { 29, 10, 140, "14.04.2024 18:15:04" },
                    { 30, 10, 141, "Sleek Concrete Chicken" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 5, 20 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 5, 21 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 5, 24 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 6, 26 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 6, 27 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 7, 29 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 7, 30 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 7, 31 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 8, 33 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 8, 34 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 8, 35 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 8, 36 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 8, 37 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 8, 38 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 8, 39 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 8, 40 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 8, 41 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 9, 43 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 9, 44 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 9, 45 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 9, 46 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 10, 48 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 10, 49 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 10, 50 });

            migrationBuilder.DeleteData(
                table: "CaseDebtor",
                keyColumns: new[] { "CaseId", "DebtorId" },
                keyValues: new object[] { 10, 51 });

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CaseProperty",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ContractorPropertyType",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 47);
        }
    }
}
