using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day5_IfYouGiveASeed_Fertilizer
{
    internal class Program
    {
        static List<Int64> seeds = new List<Int64>();
        static List<List<Int64>> seedToSoilMap = new List<List<Int64>>();
        static List<List<Int64>> soilToFertilizerMap = new List<List<Int64>>();
        static List<List<Int64>> fertilizerToWaterMap = new List<List<Int64>>();
        static List<List<Int64>> waterToLightMap = new List<List<Int64>>();
        static List<List<Int64>> lightToTemperatureMap = new List<List<Int64>>();
        static List<List<Int64>> temperatureToHumidityMap = new List<List<Int64>>();
        static List<List<Int64>> humidityToLocationMap = new List<List<Int64>>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string input = "seeds: 1848591090 462385043 2611025720 154883670 1508373603 11536371 3692308424 16905163 1203540561 280364121 3755585679 337861951 93589727 738327409 3421539474 257441906 3119409201 243224070 50985980 7961058\r\n\r\nseed-to-soil map:\r\n3305253869 1699909104 39566623\r\n3344820492 1130725752 384459310\r\n3244681427 1739475727 60572442\r\n951517531 1800048169 868898709\r\n1820416240 951517531 179208221\r\n1999624461 2668946878 219310925\r\n3729279802 1515185062 184724042\r\n2218935386 2898481077 1015522767\r\n3234458153 2888257803 10223274\r\n\r\nsoil-to-fertilizer map:\r\n1569885498 220184682 161941102\r\n3711640300 872157831 344226893\r\n1934701528 0 25420995\r\n3394438846 2543943059 181930710\r\n2957858493 2070565336 135870012\r\n1416178127 25420995 36071868\r\n1030022714 2029369539 9317803\r\n1039340517 1216384724 133685745\r\n695011633 382125784 335011081\r\n2317056551 1350070469 640801942\r\n1731826600 2887680679 151926123\r\n0 3039606802 695011633\r\n2030497645 2257384153 286558906\r\n1960122523 2038687342 31877994\r\n3576369556 2840047597 42331426\r\n1536338434 4027621785 33547064\r\n1452249995 3964767856 62853929\r\n1331718081 787697785 84460046\r\n4055867193 2882379023 5301656\r\n3093728505 3734618435 230149421\r\n1173026262 61492863 158691819\r\n1883752723 2206435348 50948805\r\n3618700982 2725873769 92939318\r\n1515103924 2818813087 21234510\r\n1992000517 1990872411 38497128\r\n3323877926 717136865 70560920\r\n\r\nfertilizer-to-water map:\r\n898769374 211542615 277361469\r\n2901739042 2299030230 213178977\r\n207924763 1114173904 26774777\r\n3752402183 1968349402 71176470\r\n1176130843 625299169 68863743\r\n3114918019 3783121220 137843736\r\n1244994586 488904084 103878858\r\n3252761755 2915409726 98951129\r\n2779748334 3652754391 121990708\r\n3351712884 2593688676 245406043\r\n0 1252990064 95883380\r\n2007290234 3920964956 325008750\r\n3823578653 2039525872 202532901\r\n2443486939 2512209207 81479469\r\n4231974038 3371954615 62993258\r\n3698239076 2242058773 54163107\r\n2340675105 3014360855 102811834\r\n4219112930 4245973706 12861108\r\n4026111554 2839094719 76315007\r\n3597118927 3434947873 101120149\r\n2332298984 3774745099 8376121\r\n95883380 1140948681 112041383\r\n4102426561 3536068022 116686369\r\n1968349402 2296221880 2808350\r\n1971157752 4258834814 36132482\r\n866253147 592782942 32516227\r\n446242155 694162912 420010992\r\n2524966408 3117172689 254781926\r\n234699540 0 211542615\r\n\r\nwater-to-light map:\r\n3564276417 3073533986 256027539\r\n540951899 3329561525 136112599\r\n3123682450 3465674124 119685876\r\n2479417373 4222809437 72157859\r\n1957776831 2195006920 74795586\r\n3089045940 3585360000 28951457\r\n3820985109 2269802506 288781515\r\n1285562478 1664965131 530041789\r\n234319697 234026754 79806762\r\n3243368326 1344057040 320908091\r\n3117997397 541633052 5685053\r\n2551575232 547318105 349893979\r\n3820303956 540951899 681153\r\n0 369583040 292943\r\n314126459 313833516 55749524\r\n4109766624 2888333314 185200672\r\n292943 0 234026754\r\n677064498 3614311457 608497980\r\n2032572417 897212084 446844956\r\n2901469211 2700756585 187576729\r\n1815604267 2558584021 142172564\r\n\r\nlight-to-temperature map:\r\n2658328410 4044901271 250066025\r\n866264123 157899985 185676775\r\n2062023507 343576760 307684950\r\n1535723010 981670684 313982539\r\n3292868240 2534053678 579746095\r\n3905180794 3703329819 341571452\r\n2908394435 3318856014 384473805\r\n1194970869 1601263273 340752141\r\n427693043 1299669198 158564104\r\n748173107 651261710 118091016\r\n1051940898 1458233302 143029971\r\n586257147 0 157899985\r\n4246752246 2485838628 48215050\r\n1849705549 769352726 212317958\r\n0 2368902754 805703\r\n744157132 1295653223 4015975\r\n805703 1942015414 426887340\r\n3872614335 3113799773 32566459\r\n2485838628 3146366232 172489782\r\n\r\ntemperature-to-humidity map:\r\n2731357374 2535823037 72664015\r\n2987243945 1266132780 17518070\r\n3983567677 3876954134 113067367\r\n1669770178 435765631 9597802\r\n192217183 2087059527 132586479\r\n324803662 1449340061 36910958\r\n82239523 1283650850 47718149\r\n4251710314 3400860374 43256982\r\n788691045 2012848120 74211407\r\n139712452 383260900 52504731\r\n1679367980 1064470362 18439862\r\n3627675589 3649605531 101947626\r\n1761484189 1024489895 39980467\r\n3964889474 4132263773 7628253\r\n469056934 1486251019 222779936\r\n3808503415 3992550600 118386133\r\n4096635044 4139892026 155075270\r\n0 328658745 54602155\r\n3929418647 3751553157 35470827\r\n3729623215 3787023984 78880200\r\n129957672 2003093340 9754780\r\n3926889548 3990021501 2529099\r\n2130123401 3260061108 28438224\r\n1154320063 445363433 515450115\r\n2331952939 1331368999 72869773\r\n2804021389 1082910224 183222556\r\n1140184340 2219646006 14135723\r\n3606348549 4110936733 21327040\r\n3004762015 1709030955 50302777\r\n1801464656 0 328658745\r\n691836870 1759333732 96854175\r\n447785309 2608487052 21271625\r\n3400860374 3444117356 205488175\r\n3055064792 2233781729 261071908\r\n2185047506 1856187907 146905433\r\n1697807842 960813548 63676347\r\n361714620 2494853637 40969400\r\n2404822712 2933526446 326534662\r\n402684020 1404238772 45101289\r\n3972517727 3865904184 11049950\r\n2158561625 2907040565 26485881\r\n862902452 2629758677 277281888\r\n54602155 3288499332 27637368\r\n\r\nhumidity-to-location map:\r\n1368371614 3063096196 39876417\r\n2318920763 3734391855 138926764\r\n2980019498 3984955289 310012007\r\n3732521234 1430493364 562446062\r\n213274662 484132485 78936678\r\n0 892307918 213274662\r\n1023610211 575518293 214768297\r\n2807160244 2776517513 21582263\r\n2457847527 2833630022 176634966\r\n3619027057 2663023336 113494177\r\n2926107621 1368371614 53911877\r\n1784866635 3524616139 209775716\r\n2695523574 3873318619 111636670\r\n1250827638 790286590 102021328\r\n3290031505 1992939426 224427328\r\n954760770 415283044 68849441\r\n1408248031 2286404732 376618604\r\n292211340 0 415283044\r\n1994642351 3102972613 324278412\r\n2642692366 3034347120 28749076\r\n3514458833 2798099776 35530246\r\n1238378508 563069163 12449130\r\n2828742507 3427251025 97365114\r\n3549989079 2217366754 69037978\r\n2671441442 3010264988 24082132\r\n707494384 1105582580 247266386\r\n2634482493 1422283491 8209873";
            //string input = "seeds: 79 14 55 13\r\n\r\nseed-to-soil map:\r\n50 98 2\r\n52 50 48\r\n\r\nsoil-to-fertilizer map:\r\n0 15 37\r\n37 52 2\r\n39 0 15\r\n\r\nfertilizer-to-water map:\r\n49 53 8\r\n0 11 42\r\n42 0 7\r\n57 7 4\r\n\r\nwater-to-light map:\r\n88 18 7\r\n18 25 70\r\n\r\nlight-to-temperature map:\r\n45 77 23\r\n81 45 19\r\n68 64 13\r\n\r\ntemperature-to-humidity map:\r\n0 69 1\r\n1 0 69\r\n\r\nhumidity-to-location map:\r\n60 56 37\r\n56 93 4";
            Console.WriteLine(Count(input));

        }

        static Int64 Count(string input)
        {
            var BIG = PrepareMapsFromInput(input);
            Int64 lowestLocationNumber = Int64.MaxValue;
            for (int i = 0; i< seeds.Count; i+=2)
            {
                //Int64 seedPosition = seeds[i]; //this is for part1
                Int64 seedRange = seeds[i+1];//this is for part2
                for (Int64 X = 0; X < seedRange; X++)//this loop is for part2
                {
                    Int64 seedPosition = seeds[i] + X; //this is for part2
                    foreach (var map in BIG)
                    {
                        bool found = false;
                        foreach (var set in map)
                        {

                            Int64 targetStart = set[0];
                            Int64 sourceStart = set[1];
                            Int64 range = set[2];

                            if (seedPosition < sourceStart && seedPosition > sourceStart + range - 1 || found)
                            {
                                continue;
                            }

                            for (Int64 j = 0; j < range; j++)
                            {
                                if (sourceStart + j == seedPosition)
                                {
                                    seedPosition = targetStart + j;
                                    found = true;
                                    break;
                                }
                            }
                            if (found)
                                continue;
                        }
                        if (found)
                            continue;

                    }
                    //Console.WriteLine(seedPosition);
                    if (seedPosition < lowestLocationNumber)
                        lowestLocationNumber = seedPosition;
                }

            }

            return lowestLocationNumber;
        }

        static List<List<List<Int64>>> PrepareMapsFromInput(string input)
        {
            bool isSeedsSection = false;
            bool isSeedToSoilMapSection = false;
            bool isSoilToFertilizerMapSection = false;
            bool isFertilizerToWaterMapSection = false;
            bool isWaterToLightMapSection = false;
            bool isLightToTemperatureMapSection = false;
            bool isTemperatureToHumidityMapSection = false;
            bool isHumidityToLocationMapSection = false;
            string[] lines = input.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                if (line.StartsWith("seeds:"))
                {
                    isSeedsSection = true;
                }
                else if (line.StartsWith("seed-to-soil map:"))
                {
                    isSeedsSection = false;
                    isSeedToSoilMapSection = true;
                    continue;
                }
                else if (line.StartsWith("soil-to-fertilizer map:"))
                {
                    isSeedToSoilMapSection = false;
                    isSoilToFertilizerMapSection = true;
                    continue;
                }
                else if (line.StartsWith("fertilizer-to-water map:"))
                {
                    isSoilToFertilizerMapSection = false;
                    isFertilizerToWaterMapSection = true;
                    continue;
                }
                else if (line.StartsWith("water-to-light map:"))
                {
                    isFertilizerToWaterMapSection = false;
                    isWaterToLightMapSection = true;
                    continue;
                }
                else if (line.StartsWith("light-to-temperature map:"))
                {
                    isWaterToLightMapSection = false;
                    isLightToTemperatureMapSection = true;
                    continue;
                }
                else if (line.StartsWith("temperature-to-humidity map:"))
                {
                    isLightToTemperatureMapSection = false;
                    isTemperatureToHumidityMapSection = true;
                    continue;
                }
                else if (line.StartsWith("humidity-to-location map:"))
                {
                    isTemperatureToHumidityMapSection = false;
                    isHumidityToLocationMapSection = true;
                    continue;
                }

                if (isSeedsSection)
                {
                    string[] values = line.Split(' ');
                    for (Int64 i = 1; i < values.Length; i++)
                    {
                        seeds.Add(Int64.Parse(values[i]));
                    }
                }
                else if (isSeedToSoilMapSection)
                {
                    string[] values = line.Split(' ');
                    List<Int64> row = new List<Int64>();
                    foreach (string value in values)
                    {
                        row.Add(Int64.Parse(value));
                    }
                    seedToSoilMap.Add(row);
                }
                else if (isSoilToFertilizerMapSection)
                {
                    string[] values = line.Split(' ');
                    List<Int64> row = new List<Int64>();
                    foreach (string value in values)
                    {
                        row.Add(Int64.Parse(value));
                    }
                    soilToFertilizerMap.Add(row);
                }
                else if (isFertilizerToWaterMapSection)
                {
                    string[] values = line.Split(' ');
                    List<Int64> row = new List<Int64>();
                    foreach (string value in values)
                    {
                        row.Add(Int64.Parse(value));
                    }
                    fertilizerToWaterMap.Add(row);
                }
                else if (isWaterToLightMapSection)
                {
                    string[] values = line.Split(' ');
                    List<Int64> row = new List<Int64>();
                    foreach (string value in values)
                    {
                        row.Add(Int64.Parse(value));
                    }
                    waterToLightMap.Add(row);
                }
                else if (isLightToTemperatureMapSection)
                {
                    string[] values = line.Split(' ');
                    List<Int64> row = new List<Int64>();
                    foreach (string value in values)
                    {
                        row.Add(Int64.Parse(value));
                    }
                    lightToTemperatureMap.Add(row);
                }
                else if (isTemperatureToHumidityMapSection)
                {
                    string[] values = line.Split(' ');
                    List<Int64> row = new List<Int64>();
                    foreach (string value in values)
                    {
                        row.Add(Int64.Parse(value));
                    }
                    temperatureToHumidityMap.Add(row);
                }
                else if (isHumidityToLocationMapSection)
                {
                    string[] values = line.Split(' ');
                    List<Int64> row = new List<Int64>();
                    foreach (string value in values)
                    {
                        row.Add(Int64.Parse(value));
                    }
                    humidityToLocationMap.Add(row);
                }
            }
            List<List<List<Int64>>> bigDaddy = new List<List<List<Int64>>>()
            {
                seedToSoilMap,
                soilToFertilizerMap,
                fertilizerToWaterMap,
                waterToLightMap,
                lightToTemperatureMap,
                temperatureToHumidityMap,
                humidityToLocationMap
            };
            return bigDaddy;
            #region printing
            //Console.WriteLine("seeds:");
            //foreach (int seed in seeds)
            //{
            //    Console.Write(seed + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("seed-to-soil map:");
            //foreach (List<int> row in seedToSoilMap)
            //{
            //    foreach (int value in row)
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine("soil-to-fertilizer map:");
            //foreach (List<int> row in soilToFertilizerMap)
            //{
            //    foreach (int value in row)
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine("fertilizer-to-water map:");
            //foreach (List<int> row in fertilizerToWaterMap)
            //{
            //    foreach (int value in row)
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine("water-to-light map:");
            //foreach (List<int> row in waterToLightMap)
            //{
            //    foreach (int value in row)
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine("light-to-temperature map:");
            //foreach (List<int> row in lightToTemperatureMap)
            //{
            //    foreach (int value in row)
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine("temperature-to-humidity map:");
            //foreach (List<int> row in temperatureToHumidityMap)
            //{
            //    foreach (int value in row)
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine("humidity-to-location map:");
            //foreach (List<int> row in humidityToLocationMap)
            //{
            //    foreach (int value in row)
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}