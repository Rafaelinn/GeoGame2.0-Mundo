using System;
using System.Threading;

namespace GeoGame2
{
    class Game
    {
        private string Location { get; set; }

        public Game(string location)
        {
            this.Location = location;

            if (location == "america")
            {
                Console.Clear();
                Console.WriteLine("\nContinente escolhido: América\n");
                GeoGame(1);
            }
            else if (location == "europa")
            {
                Console.Clear();
                Console.WriteLine("\nContinente escolhido: Europa\n");
                GeoGame(2);
            }
            else if (location == "asia")
            {
                Console.Clear();
                Console.WriteLine("\nContinente escolhido: Ásia\n");
                GeoGame(3);
            }
            else if (location == "africa")
            {
                Console.Clear();
                Console.WriteLine("\nContinente escolhido: África\n");
                GeoGame(4);
            }
            else if (location == "oceania")
            {
                Console.Clear();
                Console.WriteLine("\nContinente escolhido: Oceania\n");
                GeoGame(5);
            }
            else if (location == "mundo")
            {
                Console.Clear();
                Console.WriteLine("\nTodos os países do mundo\n");
                GeoGame(6);
            }
        }

        private void GeoGame(int continent)
        {
            string continentChosen = "Continent";
            int random = 0;

            if (continent == 1)
            {
                continentChosen = "América";
                random = 1;
            }
            else if (continent == 2)
            {
                continentChosen = "Europa";
                random = 2;
            }
            else if (continent == 3)
            {
                continentChosen = "Ásia";
                random = 3;
            }
            else if (continent == 4)
            {
                continentChosen = "África";
                random = 4;
            }
            else if (continent == 5)
            {
                continentChosen = "Oceania";
                random = 5;
            }
            else if (continent == 6)
            {
                continentChosen = "Mundo";
                random = 6;
            }

            Console.WriteLine("Digite: 'sair' caso queira terminar o jogo\n");
            Console.WriteLine($"Começando novo jogo nos países: {continentChosen}...\n\n");
            Thread.Sleep(3000);

            bool exit = false;
            int score = 0;
            int turn = 1;

            while (exit == false)
            {
                string correctAnswer = "Answer";
                string capital = "Capital";
                string continentShow = "Continent";
                string playerAnswer;
                int country = 0;

                Random rand = new Random();
                
                if (random == 1)
                    country = rand.Next(1,35);
                else if (random == 2)
                    country = rand.Next(35,78);         
                else if (random == 3)
                    country = rand.Next(78,125);
                else if (random == 4)
                    country = rand.Next(125,180);
                else if (random == 5)
                    country = rand.Next(180,201);
                else if (random == 6)
                    country = rand.Next(1,201);

                if (country == 1){
                    correctAnswer = "brasil";
                    capital = "Brasília";
                    continentShow = "América";
                }
                else if (country == 2){
                    correctAnswer = "argentina";
                    capital = "Buenos Aires";
                    continentShow = "América";
                }
                else if (country == 3){
                    correctAnswer = "chile";
                    capital = "Santiago";
                    continentShow = "América";
                }
                else if (country == 4){
                    correctAnswer = "uruguai";
                    capital = "Montevideo";
                    continentShow = "América";
                }
                else if (country == 5){
                    correctAnswer = "paraguai";
                    capital = "Asunción";
                    continentShow = "América";
                }
                else if (country == 6){
                    correctAnswer = "bolivia";
                    capital = "La Paz e Sucre";
                    continentShow = "América";
                }
                else if (country == 7){
                    correctAnswer = "peru";
                    capital = "Lima";
                    continentShow = "América";
                }
                else if (country == 8){
                    correctAnswer = "equador";
                    capital = "Quito";
                    continentShow = "América";
                }
                else if (country == 9){
                    correctAnswer = "colombia";
                    capital = "Bogotá";
                    continentShow = "América";
                }
                else if (country == 10){
                    correctAnswer = "venezuela";
                    capital = "Caracas";
                    continentShow = "América";
                }
                else if (country == 11){
                    correctAnswer = "guiana";
                    capital = "Georgetown";
                    continentShow = "América";
                }
                else if (country == 12){
                    correctAnswer = "suriname";
                    capital = "Paramaribo";
                    continentShow = "América";
                }
                else if (country == 13){
                    correctAnswer = "panama";
                    capital = "Ciudad de Panamá";
                    continentShow = "América";
                }
                else if (country == 14){
                    correctAnswer = "costa rica";
                    capital = "San José";
                    continentShow = "América";
                }
                else if (country == 15){
                    correctAnswer = "nicaragua";
                    capital = "Managuá";
                    continentShow = "América";
                }
                else if (country == 16){
                    correctAnswer = "honduras";
                    capital = "Tegucigalpa";
                    continentShow = "América";
                }
                else if (country == 17){
                    correctAnswer = "el salvador";
                    capital = "San Salvador";
                    continentShow = "América";
                }
                else if (country == 18){
                    correctAnswer = "guatemala";
                    capital = "Ciudad de Guatemala";
                    continentShow = "América";
                }
                else if (country == 19){
                    correctAnswer = "mexico";
                    capital = "Ciudad de México";
                    continentShow = "América";
                }
                else if (country == 20){
                    correctAnswer = "estados unidos";
                    capital = "Washington D.C";
                    continentShow = "América";
                }
                else if (country == 21){
                    correctAnswer = "canada";
                    capital = "Ottawa";
                    continentShow = "América";
                }
                else if (country == 22){
                    correctAnswer = "cuba";
                    capital = "Havana";
                    continentShow = "América";
                }
                else if (country == 23){
                    correctAnswer = "jamaica";
                    capital = "Kingston";
                    continentShow = "América";
                }
                else if (country == 24){
                    correctAnswer = "bahamas";
                    capital = "Nassau";
                    continentShow = "América";
                }
                else if (country == 25){
                    correctAnswer = "republica dominicana";
                    capital = "Santo Domingo";
                    continentShow = "América";
                }
                else if (country == 26){
                    correctAnswer = "haiti";
                    capital = "Port-au-Prince";
                    continentShow = "América";
                }
                else if (country == 27){
                    correctAnswer = "trindade e tobago";
                    capital = "Porto da Espanha";
                    continentShow = "América";
                }
                else if (country == 28){
                    correctAnswer = "belize";
                    capital = "Belmopan";
                    continentShow = "América";
                }
                else if (country == 29){
                    correctAnswer = "barbados";
                    capital = "Bridgetown";
                    continentShow = "América";
                }
                else if (country == 30){
                    correctAnswer = "dominica";
                    capital = "Roseau";
                    continentShow = "América";
                }
                else if (country == 31){
                    correctAnswer = "sao cristovao e neves";
                    capital = "Basseterre";
                    continentShow = "América";
                }
                else if (country == 32){
                    correctAnswer = "santa lucia";
                    capital = "Castries";
                    continentShow = "América";
                }
                else if (country == 33){
                    correctAnswer = "granada";
                    capital = "São Jorge";
                    continentShow = "América";
                }
                else if (country == 34){
                    correctAnswer = "antigua e barbuda";
                    capital = "São João";
                    continentShow = "América";
                }

                else if (country == 35){
                    correctAnswer = "russia";
                    capital = "Moscou";
                    continentShow = "Europa";
                }
                else if (country == 36){
                    correctAnswer = "ucrania";
                    capital = "Kiev";
                    continentShow = "Europa";
                }
                else if (country == 37){
                    correctAnswer = "frança";
                    capital = "Paris";
                    continentShow = "Europa";
                }
                else if (country == 38){
                    correctAnswer = "espanha";
                    capital = "Madri";
                    continentShow = "Europa";
                }
                else if (country == 39){
                    correctAnswer = "suecia";
                    capital = "Estocolmo";
                    continentShow = "Europa";
                }
                else if (country == 40){
                    correctAnswer = "noruega";
                    capital = "Oslo";
                    continentShow = "Europa";
                }
                else if (country == 41){
                    correctAnswer = "alemanha";
                    capital = "Berlim";
                    continentShow = "Europa";
                }
                else if (country == 42){
                    correctAnswer = "finlandia";
                    capital = "Helsinki";
                    continentShow = "Europa";
                }
                else if (country == 43){
                    correctAnswer = "polonia";
                    capital = "Varsóvia";
                    continentShow = "Europa";
                }
                else if (country == 44){
                    correctAnswer = "italia";
                    capital = "Roma";
                    continentShow = "Europa";
                }
                else if (country == 45){
                    correctAnswer = "reino unido";
                    capital = "Londres";
                    continentShow = "Europa";
                }
                else if (country == 46){
                    correctAnswer = "romenia";
                    capital = "Bucareste";
                    continentShow = "Europa";
                }
                else if (country == 47){
                    correctAnswer = "belarus";
                    capital = "Minsk";
                    continentShow = "Europa";
                }
                else if (country == 48){
                    correctAnswer = "grecia";
                    capital = "Atenas";
                    continentShow = "Europa";
                }
                else if (country == 49){
                    correctAnswer = "bulgaria";
                    capital = "Sofia";
                    continentShow = "Europa";
                }
                else if (country == 50){
                    correctAnswer = "islandia";
                    capital = "Reykjavík";
                    continentShow = "Europa";
                }
                else if (country == 51){
                    correctAnswer = "hungria";
                    capital = "Budapeste";
                    continentShow = "Europa";
                }
                else if (country == 52){
                    correctAnswer = "portugal";
                    capital = "Lisboa";
                    continentShow = "Europa";
                }
                else if (country == 53){
                    correctAnswer = "servia";
                    capital = "Belgrado";
                    continentShow = "Europa";
                }
                else if (country == 54){
                    correctAnswer = "austria";
                    capital = "Viena";
                    continentShow = "Europa";
                }
                else if (country == 55){
                    correctAnswer = "chequia";
                    capital = "Praga";
                    continentShow = "Europa";
                }
                else if (country == 56){
                    correctAnswer = "irlanda";
                    capital = "Dublin";
                    continentShow = "Europa";
                }
                else if (country == 57){
                    correctAnswer = "lituania";
                    capital = "Vilnius";
                    continentShow = "Europa";
                }
                else if (country == 58){
                    correctAnswer = "letonia";
                    capital = "Riga";
                    continentShow = "Europa";
                }
                else if (country == 59){
                    correctAnswer = "croacia";
                    capital = "Zagreb";
                    continentShow = "Europa";
                }
                else if (country == 60){
                    correctAnswer = "bosnia e herzegovina";
                    capital = "Sarajevo";
                    continentShow = "Europa";
                }
                else if (country == 61){
                    correctAnswer = "eslovaquia";
                    capital = "Bratislava";
                    continentShow = "Europa";
                }
                else if (country == 62){
                    correctAnswer = "estonia";
                    capital = "Tallinn";
                    continentShow = "Europa";
                }
                else if (country == 63){
                    correctAnswer = "dinamarca";
                    capital = "Copenhague";
                    continentShow = "Europa";
                }
                else if (country == 64){
                    correctAnswer = "suiça";
                    capital = "Berna";
                    continentShow = "Europa";
                }
                else if (country == 65){
                    correctAnswer = "paises baixos";
                    capital = "Amsterdã";
                    continentShow = "Europa";
                }
                else if (country == 66){
                    correctAnswer = "moldavia";
                    capital = "Chisinau";
                    continentShow = "Europa";
                }
                else if (country == 67){
                    correctAnswer = "belgica";
                    capital = "Bruxelas";
                    continentShow = "Europa";
                }
                else if (country == 68){
                    correctAnswer = "albania";
                    capital = "Tirana";
                    continentShow = "Europa";
                }
                else if (country == 69){
                    correctAnswer = "macedonia do norte";
                    capital = "Skopje";
                    continentShow = "Europa";
                }
                else if (country == 70){
                    correctAnswer = "eslovenia";
                    capital = "Ljubljana";
                    continentShow = "Europa";
                }
                else if (country == 71){
                    correctAnswer = "montenegro";
                    capital = "Podgorica";
                    continentShow = "Europa";
                }
                else if (country == 72){
                    correctAnswer = "kosovo";
                    capital = "Pristina";
                    continentShow = "Europa";
                }
                else if (country == 73){
                    correctAnswer = "luxemburgo";
                    capital = "Luxemburgo";
                    continentShow = "Europa";
                }
                else if (country == 74){
                    correctAnswer = "andorra";
                    capital = "Andorra-La-Vella";
                    continentShow = "Europa";
                }
                else if (country == 75){
                    correctAnswer = "malta";
                    capital = "Valleta";
                    continentShow = "Europa";
                }
                else if (country == 76){
                    correctAnswer = "liechtenstein";
                    capital = "Vaduz";
                    continentShow = "Europa";
                }
                else if (country == 77){
                    correctAnswer = "chipre";
                    capital = "Nicósia";
                    continentShow = "Europa";
                }

                else if (country == 78){
                    correctAnswer = "china";
                    capital = "Pequim";
                    continentShow = "Ásia";
                }
                else if (country == 79){
                    correctAnswer = "india";
                    capital = "Nova Delhi";
                    continentShow = "Ásia";
                }
                else if (country == 80){
                    correctAnswer = "indonesia";
                    capital = "Jakarta";
                    continentShow = "Ásia";
                }
                else if (country == 81){
                    correctAnswer = "paquistao";
                    capital = "Islamabad";
                    continentShow = "Ásia";
                }
                else if (country == 82){
                    correctAnswer = "bangladesh";
                    capital = "Daca";
                    continentShow = "Ásia";
                }
                else if (country == 83){
                    correctAnswer = "japao";
                    capital = "Tóquio";
                    continentShow = "Ásia";
                }
                else if (country == 84){
                    correctAnswer = "filipinas";
                    capital = "Manila";
                    continentShow = "Ásia";
                }
                else if (country == 85){
                    correctAnswer = "vietna";
                    capital = "Hanói";
                    continentShow = "Ásia";
                }
                else if (country == 86){
                    correctAnswer = "ira";
                    capital = "Teerã";
                    continentShow = "Ásia";
                }
                else if (country == 87){
                    correctAnswer = "turquia";
                    capital = "Ancara";
                    continentShow = "Ásia";
                }
                else if (country == 88){
                    correctAnswer = "tailandia";
                    capital = "Bangkok";
                    continentShow = "Ásia";
                }
                else if (country == 89){
                    correctAnswer = "mianmar";
                    capital = "Naypyidaw";
                    continentShow = "Ásia";
                }
                else if (country == 90){
                    correctAnswer = "coreia do sul";
                    capital = "Seul";
                    continentShow = "Ásia";
                }
                else if (country == 91){
                    correctAnswer = "iraque";
                    capital = "Bagdá";
                    continentShow = "Ásia";
                }
                else if (country == 92){
                    correctAnswer = "afeganistao";
                    capital = "Cabul";
                    continentShow = "Ásia";
                }
                else if (country == 93){
                    correctAnswer = "uzbequistao";
                    capital = "Tashkent";
                    continentShow = "Ásia";
                }
                else if (country == 94){
                    correctAnswer = "arabia saudita";
                    capital = "Riad";
                    continentShow = "Ásia";
                }
                else if (country == 95){
                    correctAnswer = "malasia";
                    capital = "Kuala Lumpur";
                    continentShow = "Ásia";
                }
                else if (country == 96){
                    correctAnswer = "iemen";
                    capital = "Sana";
                    continentShow = "Ásia";
                }
                else if (country == 97){
                    correctAnswer = "nepal";
                    capital = "Katmandu";
                    continentShow = "Ásia";
                }
                else if (country == 98){
                    correctAnswer = "coreia do norte";
                    capital = "Pyongyang";
                    continentShow = "Ásia";
                }
                else if (country == 99){
                    correctAnswer = "taiwan";
                    capital = "Taipé";
                    continentShow = "Ásia";
                }
                else if (country == 100){
                    correctAnswer = "sri lanka";
                    capital = "Colombo";
                    continentShow = "Ásia";
                }
                else if (country == 101){
                    correctAnswer = "siria";
                    capital = "Damasco";
                    continentShow = "Ásia";
                }
                else if (country == 102){
                    correctAnswer = "cazaquistao";
                    capital = "Astana";
                    continentShow = "Ásia";
                }
                else if (country == 103){
                    correctAnswer = "camboja";
                    capital = "Phnom Penh";
                    continentShow = "Ásia";
                }
                else if (country == 104){
                    correctAnswer = "jordania";
                    capital = "Amã";
                    continentShow = "Ásia";
                }
                else if (country == 105){
                    correctAnswer = "azerbaijao";
                    capital = "Baku";
                    continentShow = "Ásia";
                }
                else if (country == 106){
                    correctAnswer = "emirados arabes unidos";
                    capital = "Abu Dhabi";
                    continentShow = "Ásia";
                }
                else if (country == 107){
                    correctAnswer = "tajiquistao";
                    capital = "Dushanbe";
                    continentShow = "Ásia";
                }
                else if (country == 108){
                    correctAnswer = "israel";
                    capital = "Jerusalém";
                    continentShow = "Ásia";
                }
                else if (country == 109){
                    correctAnswer = "libano";
                    capital = "Beirute";
                    continentShow = "Ásia";
                }
                else if (country == 110){
                    correctAnswer = "quirguistao";
                    capital = "Bishkek";
                    continentShow = "Ásia";
                }
                else if (country == 111){
                    correctAnswer = "laos";
                    capital = "Vientiane";
                    continentShow = "Ásia";
                }
                else if (country == 112){
                    correctAnswer = "singapura";
                    capital = "Singapura";
                    continentShow = "Ásia";
                }
                else if (country == 113){
                    correctAnswer = "turcomenistao";
                    capital = "Ashgabat";
                    continentShow = "Ásia";
                }
                else if (country == 114){
                    correctAnswer = "oma";
                    capital = "Muscat";
                    continentShow = "Ásia";
                }
                else if (country == 115){
                    correctAnswer = "kuwait";
                    capital = "Cidade do Kuwait";
                    continentShow = "Ásia";
                }
                else if (country == 116){
                    correctAnswer = "georgia";
                    capital = "Tblisi";
                    continentShow = "Ásia";
                }
                else if (country == 117){
                    correctAnswer = "mongolia";
                    capital = "Ulan Bator";
                    continentShow = "Ásia";
                }
                else if (country == 118){
                    correctAnswer = "armenia";
                    capital = "Yerevan";
                    continentShow = "Ásia";
                }
                else if (country == 119){
                    correctAnswer = "catar";
                    capital = "Doha";
                    continentShow = "Ásia";
                }
                else if (country == 120){
                    correctAnswer = "timor leste";
                    capital = "Dili";
                    continentShow = "Ásia";
                }
                else if (country == 121){
                    correctAnswer = "bahrein";
                    capital = "Manama";
                    continentShow = "Ásia";
                }
                else if (country == 122){
                    correctAnswer = "butao";
                    capital = "Thimphu";
                    continentShow = "Ásia";
                }
                else if (country == 123){
                    correctAnswer = "maldivas";
                    capital = "Malé";
                    continentShow = "Ásia";
                }
                else if (country == 124){
                    correctAnswer = "brunei";
                    capital = "Bandar Seri Begawan";
                    continentShow = "Ásia";
                }

                else if (country == 125){
                    correctAnswer = "nigeria";
                    capital = "Abuja";
                    continentShow = "África";
                }
                else if (country == 126){
                    correctAnswer = "etiopia";
                    capital = "Adis Abeba";
                    continentShow = "África";
                }
                else if (country == 127){
                    correctAnswer = "egito";
                    capital = "Cairo";
                    continentShow = "África";
                }
                else if (country == 128){
                    correctAnswer = "congo democratico";
                    capital = "Kinshasa";
                    continentShow = "África";
                }
                else if (country == 129){
                    correctAnswer = "tanzania";
                    capital = "Dodoma";
                    continentShow = "África";
                }
                else if (country == 130){
                    correctAnswer = "africa do sul";
                    capital = "Cidade do Cabo, Bloemfontein e Pretória";
                    continentShow = "África";
                }
                else if (country == 131){
                    correctAnswer = "quenia";
                    capital = "Nairobi";
                    continentShow = "África";
                }
                else if (country == 132){
                    correctAnswer = "uganda";
                    capital = "Kampala";
                    continentShow = "África";
                }
                else if (country == 133){
                    correctAnswer = "sudao";
                    capital = "Cartum";
                    continentShow = "África";
                }
                else if (country == 134){
                    correctAnswer = "argelia";
                    capital = "Algiers";
                    continentShow = "África";
                }
                else if (country == 135){
                    correctAnswer = "marrocos";
                    capital = "Rabat";
                    continentShow = "África";
                }
                else if (country == 136){
                    correctAnswer = "angola";
                    capital = "Luanda";
                    continentShow = "África";
                }
                else if (country == 137){
                    correctAnswer = "moçambique";
                    capital = "Maputo";
                    continentShow = "África";
                }
                else if (country == 138){
                    correctAnswer = "gana";
                    capital = "Accra";
                    continentShow = "África";
                }
                else if (country == 139){
                    correctAnswer = "madagascar";
                    capital = "Antananarivo";
                    continentShow = "África";
                }
                else if (country == 140){
                    correctAnswer = "camaroes";
                    capital = "Yaoundé";
                    continentShow = "África";
                }
                else if (country == 141){
                    correctAnswer = "costa do marfim";
                    capital = "Yamoussoukro";
                    continentShow = "África";
                }
                else if (country == 142){
                    correctAnswer = "niger";
                    capital = "Niamey";
                    continentShow = "África";
                }
                else if (country == 143){
                    correctAnswer = "burkina faso";
                    capital = "Ouagadougou";
                    continentShow = "África";
                }
                else if (country == 144){
                    correctAnswer = "mali";
                    capital = "Bamako";
                    continentShow = "África";
                }
                else if (country == 145){
                    correctAnswer = "malaui";
                    capital = "Lilongwe";
                    continentShow = "África";
                }
                else if (country == 146){
                    correctAnswer = "zambia";
                    capital = "Lusaka";
                    continentShow = "África";
                }
                else if (country == 147){
                    correctAnswer = "senegal";
                    capital = "Dakar";
                    continentShow = "África";
                }
                else if (country == 148){
                    correctAnswer = "chade";
                    capital = "N'Djamena";
                    continentShow = "África";
                }
                else if (country == 149){
                    correctAnswer = "somalia";
                    capital = "Mogadíscio";
                    continentShow = "África";
                }
                else if (country == 150){
                    correctAnswer = "zimbabue";
                    capital = "Harare";
                    continentShow = "África";
                }
                else if (country == 151){
                    correctAnswer = "guine";
                    capital = "Conakry";
                    continentShow = "África";
                }
                else if (country == 152){
                    correctAnswer = "ruanda";
                    capital = "Kigali";
                    continentShow = "África";
                }
                else if (country == 153){
                    correctAnswer = "benin";
                    capital = "Porto-Novo";
                    continentShow = "África";
                }
                else if (country == 154){
                    correctAnswer = "burundi";
                    capital = "Gitega e Bujumbura";
                    continentShow = "África";
                }
                else if (country == 155){
                    correctAnswer = "tunisia";
                    capital = "Tunis";
                    continentShow = "África";
                }
                else if (country == 156){
                    correctAnswer = "sudao do sul";
                    capital = "Juba";
                    continentShow = "África";
                }
                else if (country == 157){
                    correctAnswer = "togo";
                    capital = "Lomé";
                    continentShow = "África";
                }
                else if (country == 158){
                    correctAnswer = "serra leoa";
                    capital = "Freetown";
                    continentShow = "África";
                }
                else if (country == 159){
                    correctAnswer = "libia";
                    capital = "Tripoli";
                    continentShow = "África";
                }
                else if (country == 160){
                    correctAnswer = "congo";
                    capital = "Brazzaville";
                    continentShow = "África";
                }
                else if (country == 161){
                    correctAnswer = "liberia";
                    capital = "Monróvia";
                    continentShow = "África";
                }
                else if (country == 162){
                    correctAnswer = "republica centro africana";
                    capital = "Bangui";
                    continentShow = "África";
                }
                else if (country == 163){
                    correctAnswer = "mauritania";
                    capital = "Nouakchott";
                    continentShow = "África";
                }
                else if (country == 164){
                    correctAnswer = "eritreia";
                    capital = "Asmara";
                    continentShow = "África";
                }
                else if (country == 165){
                    correctAnswer = "namibia";
                    capital = "Windhoek";
                    continentShow = "África";
                }
                else if (country == 166){
                    correctAnswer = "o gambia";
                    capital = "Banjul";
                    continentShow = "África";
                }
                else if (country == 167){
                    correctAnswer = "botsuana";
                    capital = "Gaborone";
                    continentShow = "África";
                }
                else if (country == 168){
                    correctAnswer = "gabao";
                    capital = "Libreville";
                    continentShow = "África";
                }
                else if (country == 169){
                    correctAnswer = "lesoto";
                    capital = "Maseru";
                    continentShow = "África";
                }
                else if (country == 170){
                    correctAnswer = "guine bissau";
                    capital = "Bissau";
                    continentShow = "África";
                }
                else if (country == 171){
                    correctAnswer = "guine equatorial";
                    capital = "Malabo";
                    continentShow = "África";
                }
                else if (country == 172){
                    correctAnswer = "mauricio";
                    capital = "Port Louis";
                    continentShow = "África";
                }
                else if (country == 173){
                    correctAnswer = "essuatini";
                    capital = "Mbabane e Lobamba";
                    continentShow = "África";
                }
                else if (country == 174){
                    correctAnswer = "djibuti";
                    capital = "Djibuti";
                    continentShow = "África";
                }
                else if (country == 175){
                    correctAnswer = "comores";
                    capital = "Moroni";
                    continentShow = "África";
                }
                else if (country == 176){
                    correctAnswer = "saara ocidental";
                    capital = "El Aaiún";
                    continentShow = "África";
                }
                else if (country == 177){
                    correctAnswer = "cabo verde";
                    capital = "Praia";
                    continentShow = "África";
                }
                else if (country == 178){
                    correctAnswer = "sao tome e principe";
                    capital = "São Tomé";
                    continentShow = "África";
                }
                else if (country == 179){
                    correctAnswer = "seicheles";
                    capital = "Victoria";
                    continentShow = "África";
                }

                else if (country == 180){
                    correctAnswer = "australia";
                    capital = "Camberra";
                    continentShow = "Oceania";
                }
                else if (country == 181){
                    correctAnswer = "papua nova guine";
                    capital = "Port Moresby";
                    continentShow = "Oceania";
                }
                else if (country == 182){
                    correctAnswer = "nova zelandia";
                    capital = "Wellington";
                    continentShow = "Oceania";
                }
                else if (country == 183){
                    correctAnswer = "fiji";
                    capital = "Suva";
                    continentShow = "Oceania";
                }
                else if (country == 184){
                    correctAnswer = "ilhas salomao";
                    capital = "Honiara";
                    continentShow = "Oceania";
                }
                else if (country == 185){
                    correctAnswer = "vanuatu";
                    capital = "Port Vila";
                    continentShow = "Oceania";
                }
                else if (country == 186){
                    correctAnswer = "nova caledonia";
                    capital = "Nouméa";
                    continentShow = "Oceania";
                }
                else if (country == 187){
                    correctAnswer = "polinesia francesa";
                    capital = "Papeete";
                    continentShow = "Oceania";
                }
                else if (country == 188){
                    correctAnswer = "samoa";
                    capital = "Apia";
                    continentShow = "Oceania";
                }
                else if (country == 189){
                    correctAnswer = "kiribati";
                    capital = "Tarawa do Sul";
                    continentShow = "Oceania";
                }
                else if (country == 190){
                    correctAnswer = "micronesia";
                    capital = "Palikir";
                    continentShow = "Oceania";
                }
                else if (country == 191){
                    correctAnswer = "tonga";
                    capital = "Nuku'alofa";
                    continentShow = "Oceania";
                }
                else if (country == 192){
                    correctAnswer = "ilhas marshall";
                    capital = "Delap-Uliga-Djarrit";
                    continentShow = "Oceania";
                }
                else if (country == 193){
                    correctAnswer = "palau";
                    capital = "Ngerulmud";
                    continentShow = "Oceania";
                }
                else if (country == 194){
                    correctAnswer = "ilhas cook";
                    capital = "Avarua";
                    continentShow = "Oceania";
                }
                else if (country == 195){
                    correctAnswer = "wallis e futuna";
                    capital = "Mata Utu";
                    continentShow = "Oceania";
                }
                else if (country == 196){
                    correctAnswer = "tuvalu";
                    capital = "Funafuti";
                    continentShow = "Oceania";
                }
                else if (country == 197){
                    correctAnswer = "nauru";
                    capital = "Yaren";
                    continentShow = "Oceania";
                }
                else if (country == 198){
                    correctAnswer = "ilha norfolk";
                    capital = "Kingston";
                    continentShow = "Oceania";
                }
                else if (country == 199){
                    correctAnswer = "niue";
                    capital = "Alofi";
                    continentShow = "Oceania";
                }
                else if (country == 200){
                    correctAnswer = "ilhas pitcairn";
                    capital = "Adamstown";
                    continentShow = "Oceania";
                }

                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine($"| Continente: {continentShow} | Capital: {capital} |\n");
                playerAnswer = Console.ReadLine().ToString().ToLower();

                if (playerAnswer == correctAnswer)
                {
                    Console.WriteLine("\nRESPOSTA CORRETA! +1 PONTO.\n");
                    score += 1;
                }
                else if (playerAnswer == "sair")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("\nRESPOSTA INCORRETA!\n");
                    exit = true;
                }

                Thread.Sleep(1000);
                Console.WriteLine($"Pontuação atual: {score}\n");

                turn += 1;
                Thread.Sleep(2000);
            }

            Console.WriteLine("\n--------------------------------------------\n");
            Console.WriteLine("Fim de Jogo.");
            Console.WriteLine($"\nPontuação final: {score}.\n");
        }
    }
}