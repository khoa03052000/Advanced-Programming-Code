using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                    Wellcome to SWORDSMAN Online                    ");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                    Initialize your character                    ");
            Console.WriteLine("The sect in game: ");
            Console.WriteLine("- Fire Element");
            Console.WriteLine("     1. Shaolin - Damage: 50");
            Console.WriteLine("     2. Heavenly Kings - Damage: 55");
            Console.WriteLine("- Water Element");
            Console.WriteLine("     3. Emei - Damage: 40");
            Console.WriteLine("     4. They yen - Damage: 45");
            Console.WriteLine("How many characters do you want to create");
            int num = Convert.ToInt32(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();
            List<Monster> monsters = new List<Monster>();
            CharactersAbstractFactory fire_factory = CharactersFactory.GetFactory(Elements.Fire);
            CharactersAbstractFactory water_factory = CharactersFactory.GetFactory(Elements.Water);
            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("Choose the Sect: ");
                int sect_choose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name Character: ");
                string name = Console.ReadLine();
                switch (sect_choose)
                {
                    case 1:
                        heroes.Add(fire_factory.CreateHero(name, Sect.Shaolin));
                        break;
                    case 2:
                        heroes.Add(fire_factory.CreateHero(name, Sect.HeavenlyKings));
                        break;
                    case 3:
                        heroes.Add(water_factory.CreateHero(name, Sect.Emei));
                        break;
                    case 4:
                        heroes.Add(water_factory.CreateHero(name, Sect.TheyYen));
                        break;
                    default:
                        Console.WriteLine("There is no corresponding sect");
                        break;
                }
            }
            Console.WriteLine("Successful initialization");
            Console.WriteLine();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("                    Game menu                    ");
                Console.WriteLine("1. Show list of Hero");
                Console.WriteLine("2. Going to fight the boss");
                Console.WriteLine("3. Hero Challenge");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose option menu:");
                int menu_choose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (menu_choose == 4)
                {
                    Console.WriteLine("Game over, Thank you for playing");
                    Console.ReadLine();
                    break;
                }
                switch (menu_choose)
                {
                    case 1:
                        foreach (var hero in heroes)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine("The Name Character: " + hero.Name);
                            Console.WriteLine("The basic dame: " + hero.Dame());
                            Console.WriteLine("The Element: " + hero.Info());
                            Console.WriteLine("The Sect: " + hero.sectHero);
                            Console.WriteLine("-------------------------");
                        }
                        break;
                    case 2:
                        int level_monster;
                        monsters.Clear();
                        Random r = new Random();
                        Console.WriteLine("You have moved to Map Monster    ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("List Monster in Map Monster");
                        for (int i = 0; i < 2; i++)
                        {

                            level_monster = r.Next(1, 10);
                            monsters.Add(fire_factory.CreateMonster(MonsterType.Ordinary, level_monster));
                            level_monster = r.Next(1, 10);
                            monsters.Add(water_factory.CreateMonster(MonsterType.Ordinary, level_monster));
                        }
                        level_monster = r.Next(1, 5);
                        monsters.Add(fire_factory.CreateMonster(MonsterType.Dominate, level_monster));
                        Console.WriteLine("-------------------------");
                        foreach (var monster in monsters)
                        {
                            Console.WriteLine(monster.Dame());
                            Console.WriteLine(monster.Type);
                            Console.WriteLine(monster.level);
                            Console.WriteLine("-------------------------");
                        }
                        Console.WriteLine("Starting to attack? Yes or No");
                        string ans_map = Console.ReadLine();
                        if(ans_map == "Yes" | ans_map == "yes")
                        {
                            for (int i = 0; i < heroes.Count(); i++)
                            {
                                for (int j = 0; j < monsters.Count(); j++)
                                {
                                    int dame_hero = heroes[i].Dame(monsters[j]);
                                    int dame_monster = monsters[j].Dame(heroes[i]);
                                    if (dame_hero >= dame_monster)
                                    {
                                        heroes[i].level += 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The Characters: "+heroes[i].Name+ " have lost the boss's turn " + (j + 1));
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("Successfully hit the boss, your level is: ");
                            Console.WriteLine();
                            foreach (var hero in heroes)
                            {
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("The Name Character: " + hero.Name);
                                Console.WriteLine("Level: " + hero.level);
                                Console.WriteLine("-------------------------");
                            }    

                        }
                        else
                        {
                            break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Choose 2 heroes in the following hero series to go to figth");
                        int id = 1;
                        foreach(var hero in heroes)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine("The ID Character: " + id);
                            Console.WriteLine("The Name Character: " + hero.Name);
                            Console.WriteLine("The Element: " + hero.Info());
                            Console.WriteLine("The Sect: " + hero.sectHero);
                            Console.WriteLine("-------------------------");
                            id += 1;
                        }
                        Console.WriteLine("Choice of First Hero:");
                        int hero_choose1 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Choice of Second Hero:");
                        int hero_choose2 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Hero participating in the fight is: ");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("The Name Character: " + heroes[hero_choose1].Name);
                        Console.WriteLine("The basic dame: " + heroes[hero_choose1].Dame());
                        Console.WriteLine("The Element: " + heroes[hero_choose1].Info());
                        Console.WriteLine("The Sect: " + heroes[hero_choose1].sectHero);
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("The Name Character: " + heroes[hero_choose2].Name);
                        Console.WriteLine("The basic dame: " + heroes[hero_choose2].Dame());
                        Console.WriteLine("The Element: " + heroes[hero_choose2].Info());
                        Console.WriteLine("The Sect: " + heroes[hero_choose2].sectHero);
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Started fighting:");
                        // sleep(2s)
                        int dame_hero1 = heroes[hero_choose1].Dame(heroes[hero_choose2]);
                        int dame_hero2 = heroes[hero_choose2].Dame(heroes[hero_choose1]);
                        if (dame_hero1 > dame_hero2)
                        {
                            Console.WriteLine("The Characters: "+heroes[hero_choose1].Name+" win");
                        }
                        else if (dame_hero1 == dame_hero2)
                        {
                            Console.WriteLine("Match Tie, Please choose another opponent");
                        }    
                        else
                        {
                            Console.WriteLine("The Characters: " + heroes[hero_choose2].Name + " win");
                        }    
                        break;
                    default:
                        Console.WriteLine("There is no corresponding sect");
                        break;
                }
            }
        }
    }
}
