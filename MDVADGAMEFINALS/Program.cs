using System;

class Program
{
    #region -- Main Method na masakit sa mata talaga --
    static void Main(string[] args)
    {
        bool GameisRunning = true;

        while (GameisRunning)
        {
            Console.WriteLine("\n==== Guardians of the Scattered Gems ====");
            Console.WriteLine("\n1. Create New Karater");
            Console.WriteLine("2. Lod Game");
            Console.WriteLine("3. Campaign Mode");
            Console.WriteLine("4. Credits");
            Console.WriteLine("5. Alis sa far away");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                NewGame newGame = new NewGame();     /* FOR REVISION PWEDE IPASOK NA LANG SA METHOD NA MAY NAME 
                                                      * NA DISPLAY PARA MALINIS YUNG MAIN ANG KALAT EH BWISIT*/
                // Character Creation
                Console.Write("Enter your character's name: ");
                string name = Console.ReadLine();

                string eyeColor = newGame.ChooseEyeColor();
                string hairType = newGame.ChooseHairType();
                string hairColor = newGame.ChooseHairColor();
                string gender = newGame.ChooseGender();
                string skinTone = newGame.ChooseSkinTone();
                string clothingType = newGame.ChooseClothingType();
                string weapon = newGame.ChooseWeapon();
                string footwear = newGame.ChooseFootwear();
                string accessories = newGame.ChooseAccessories();
                string beast = newGame.ChooseBeast();
                string ability = newGame.ChooseAbility();
                string occupation = newGame.ChooseOccupation();
                string jewelry = newGame.ChooseJewelry();
                string headwear = newGame.ChooseHeadwear();
                string race = newGame.ChooseRace();
                string bodyType = newGame.ChooseBodyType();
                string offensive = newGame.SkillsOffensive();
                string supportive = newGame.SkillsSupportive();
                var (strength, agility, intelligence, vitality, luck, dexterity, endurance) = newGame.PointAllocation();
                string region = newGame.ChooseRegion();

                Console.WriteLine("Tagumpay ang pagkakagawa sa karakter!!");

                Console.WriteLine("+----------------+----------------------+--------------------+");
                Console.WriteLine("|    Features    |    Character Info    |        Stats       |");
                Console.WriteLine("+----------------+----------------------+--------------------+");

                Console.WriteLine($"| Character Name | {name.PadRight(20)} | Strength: {strength.ToString()}        |");
                Console.WriteLine($"| Eye Color      | {eyeColor.PadRight(20)} | Agility: {agility.ToString()}         |");
                Console.WriteLine($"| Hair Type      | {hairType.PadRight(20)} | Intelligence: {intelligence.ToString()}    |");
                Console.WriteLine($"| Hair Color     | {hairColor.PadRight(20)} | Vitality: {vitality.ToString()}        |");
                Console.WriteLine($"| Gender         | {gender.PadRight(20)} | Luck: {luck.ToString()}           |");
                Console.WriteLine($"| Skin Tone      | {skinTone.PadRight(20)} | Dexterity: {dexterity.ToString()}      |");
                Console.WriteLine($"| Clothing Type  | {clothingType.PadRight(20)} | Endurance: {endurance.ToString()}        |");
                Console.WriteLine($"| Weapon         | {weapon.PadRight(20)} |                    |");
                Console.WriteLine($"| Footwear       | {footwear.PadRight(20)} |                    |");
                Console.WriteLine($"| Accessories    | {accessories.PadRight(20)} |                    |");
                Console.WriteLine($"| Beast          | {beast.PadRight(20)} |                    |");
                Console.WriteLine($"| Ability        | {ability.PadRight(20)} |                    |");
                Console.WriteLine($"| Occupation     | {occupation.PadRight(20)} |                    |");
                Console.WriteLine($"| Jewelry        | {jewelry.PadRight(20)} |                    |");
                Console.WriteLine($"| Headwear       | {headwear.PadRight(20)} |                    |");
                Console.WriteLine($"| Race           | {race.PadRight(20)} |                    |");
                Console.WriteLine($"| Offensive      | {offensive.PadRight(20)} |                    |");
                Console.WriteLine($"| Supportive     | {supportive.PadRight(20)} |                    |");
                Console.WriteLine($"| Body Type      | {bodyType.PadRight(20)} |                    |");
                Console.WriteLine($"| Region         | {region.PadRight(20)} |                    |");

                Console.WriteLine("+----------------+----------------------+--------------------+");

                Console.WriteLine("\nDo you want to go back to the Main Menu? (Y/N)");
                string GoBack = Console.ReadLine()?.Trim().ToUpper(); 

                if (GoBack == "Y")
                {
                    Console.WriteLine("Going back to Main Menu...\n");
                }
                else if (GoBack == "N")
                {
                    Console.WriteLine("Loading Game...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Loading game (Place holder only).");
            }
            else if (choice == "3")
            {                                                     // FOR REVISION PWEDE IPASOK NA LANG SA METHOD PARA MALINIS YUNG MAIN
                Console.WriteLine("\nEntering Campaign Mode..."); // THEN PARA 'DI LANG PLAIN YUNG SA CAMPAIGN LAGYAN DIN
                Console.WriteLine("=== STORY ===\n");             // NG SIMPLE INTERACTION LIKE (YOU ENCOUNTERED A POWERFUL ENEMY GANON PERO DEPENDE
                Console.WriteLine(                                // SABI KASI CHARACTER CREATION LANG
    "In the kingdom of Soltaria lay five gems, the center of the kingdom that protected and sustained it since day one.\n" +
    "The people enjoyed peace and happiness, knowing nothing of the prophecy predicting the scattering of these precious gems.\n" +
    "Seers for years had prophesied the loss of the gems and how only the chosen keepers would be able to retrieve them.\n" +
    "On that fateful night, a force so potent and unseen broke the shield of protection meant to be around the kingdom,\n" +
    "scattering the gems across far distances. Prophecy was thus fulfilled, and it is now up to the guardians to emerge\n" +
    "and reposition the gems back in their original place.\n\n" +

    "A traveler by the name of Jack was called in his dream with a vision of the fall of the kingdom and a voice urging him\n" +
    "to seek out the white gem, an icon of peace. In his quest, he comes across an injured warrior, also seeking the red gem\n" +
    "that will give him undying strength and courage. They soon get joined by a mage looking for the green gem, a seer searching\n" +
    "for the purple gem for protection of secrets, and another keeper on a quest to find the blue gem of knowledge.\n" +
    "The five keepers, though different from one another, are somehow interlinked in their destiny. They form an alliance\n" +
    "that is based on trust and friendship. Together, they set off on their journey as guided by the mysterious voice inside them.\n\n" +

    "As they journey, the keepers face many trials, each testing their strength, wisdom, and resolve.\n" +
    "The faint voice inside their heads pushes them forward, urging them to overcome the challenges they encounter.\n" +
    "However, as their quest nears its end, they learn the devastating truth: to restore the kingdom, each keeper must sacrifice\n" +
    "their life to activate the gems' power. It is a fate they can never run away from - one that has been written in the stars\n" +
    "since the formation of the kingdom. Finally, only their selfless sacrifice will save the kingdom, and the once-thriving\n" +
    "land of the Karath will be returned to peace.");


                Console.WriteLine("\nDo you want to go back to the Main Menu? (Y/N)");
                string GoBack = Console.ReadLine()?.Trim().ToUpper(); 

                if (GoBack == "Y")
                {
                    Console.WriteLine("Going back to Main Menu...\n");
                }
                else if (GoBack == "N")
                {
                    Console.WriteLine("Edi downt...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("\n======== CREDITS =======\n");
                Console.WriteLine("This game was developed by: \n");
                Console.WriteLine("LEADER: \n\nMhart Aaron Navales (Overthinkerist) – Very passionate and dedicated sa kung ano mang ano na yan, pero tamad minsan tas \nprocrastinator ganon :>>. CS student na Customer Service.\n");
                Console.WriteLine("MEMBERS: \n\nMyra Geanga - An imaginative storyteller inspired by television, I craft short stories filled with adventure, fantasy, and vivid settings.");
                Console.WriteLine("Donna Tagura - a gifted storyteller who creates engaging and meaningful stories. My work somehow captures human experiences with \ngreat details, inspiring and connecting with my audiences. \n");

            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting the game...");
                GameisRunning = false;
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
    #endregion

    public class NewGame
    {
        #region -- 20 FEATURES NA PAGKAHABAHABA --
        public string ChooseEyeColor()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Eye Color:");
                Console.WriteLine("1. Bloody Red");
                Console.WriteLine("2. Ocean Blue");
                Console.WriteLine("3. Midnight Black");
                Console.WriteLine("4. Earthy Brown");
                Console.WriteLine("5. Forest Green");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Bloody Red" : // ternary boss
                   choice == "2" ? "Ocean Blue" :
                   choice == "3" ? "Midnight Black" :
                   choice == "4" ? "Earthy Brown" :
                   choice == "5" ? "Forest Green" : null;
        }

        public string ChooseHairType()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Hair Type:");
                Console.WriteLine("1. Short Hair");
                Console.WriteLine("2. Long Hair");
                Console.WriteLine("3. Medium Hair");
                Console.WriteLine("4. Tail");
                Console.WriteLine("5. Bald");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Short Hair" :
                   choice == "2" ? "Long Hair" :
                   choice == "3" ? "Medium Hair" :
                   choice == "4" ? "Tail" :
                   choice == "5" ? "Bald" : null;
        }

        public string ChooseHairColor()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Hair Color:");
                Console.WriteLine("1. Dark Brown");
                Console.WriteLine("2. Black");
                Console.WriteLine("3. Blue");
                Console.WriteLine("4. Ash Grey");
                Console.WriteLine("5. Red");
                Console.WriteLine("6. Mystic Purple");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Dark Brown" :
                   choice == "2" ? "Black" :
                   choice == "3" ? "Blue" :
                   choice == "4" ? "Ash Grey" :
                   choice == "5" ? "Red" :
                   choice == "6" ? "Mystic Purple" : null;
        }

        public string ChooseGender()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Gender:");
                Console.WriteLine("1. Male");
                Console.WriteLine("2. Female");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Male" : choice == "2" ? "Female" : null;
        }

        public string ChooseSkinTone()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Skin Tone:");
                Console.WriteLine("1. Black");
                Console.WriteLine("2. Brown");
                Console.WriteLine("3. Blue");
                Console.WriteLine("4. White");
                Console.WriteLine("5. Orange");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Black" :
                   choice == "2" ? "Brown" :
                   choice == "3" ? "Blue" :
                   choice == "4" ? "White" :
                   choice == "5" ? "Orange" : null;
        }

        public string ChooseClothingType()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Clothing Type:");
                Console.WriteLine("1. Squire");
                Console.WriteLine("2. Forester");
                Console.WriteLine("3. Minstrel");
                Console.WriteLine("4. Merchant");
                Console.WriteLine("5. Noble");
                Console.WriteLine("6. Priestess");
                Console.WriteLine("7. Knight");
                Console.WriteLine("8. Peasant");
                Console.WriteLine("9. Hunter");
                Console.WriteLine("10. Wizard");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6" || choice == "7" || choice == "8" || choice == "9" || choice == "10")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Squire" :
                   choice == "2" ? "Forester" :
                   choice == "3" ? "Minstrel" :
                   choice == "4" ? "Merchant" :
                   choice == "5" ? "Noble" :
                   choice == "6" ? "Priestess" :
                   choice == "7" ? "Knight" :
                   choice == "8" ? "Peasant" :
                   choice == "9" ? "Hunter" :
                   choice == "10" ? "Wizard" : null;
        }

        public string ChooseWeapon()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Weapon:");
                Console.WriteLine("1. Sword");
                Console.WriteLine("2. Crossbow");
                Console.WriteLine("3. Magic Wand");
                Console.WriteLine("4. Spear");
                Console.WriteLine("5. Dagger");
                Console.WriteLine("6. Knuckles");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Sword" :
                   choice == "2" ? "Crossbow" :
                   choice == "3" ? "Magic Wand" :
                   choice == "4" ? "Spear" :
                   choice == "5" ? "Dagger" :
                   choice == "6" ? "Knuckles" : null;
        }

        public string ChooseFootwear()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Footwear:");
                Console.WriteLine("1. Shoes");
                Console.WriteLine("2. Boots");
                Console.WriteLine("3. Sandals");
                Console.WriteLine("4. Slippers");
                Console.WriteLine("5. Barefoot");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Shoes" :
                   choice == "2" ? "Boots" :
                   choice == "3" ? "Sandals" :
                   choice == "4" ? "Slippers" :
                   choice == "5" ? "Barefoot" : null;
        }

        public string ChooseAccessories()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Accessories:");
                Console.WriteLine("1. Gloves");
                Console.WriteLine("2. Gauntlet");
                Console.WriteLine("3. Wings");
                Console.WriteLine("4. Warrior Bag");
                Console.WriteLine("5. Scarf");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Gloves" :
                   choice == "2" ? "Gauntlet" :
                   choice == "3" ? "Wings" :
                   choice == "4" ? "Warrior Bag" :
                   choice == "5" ? "Scarf" : null;
        }

        public string ChooseBeast()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Beast:");
                Console.WriteLine("1. Unicorn");
                Console.WriteLine("2. Pegasus");
                Console.WriteLine("3. Hydra");
                Console.WriteLine("4. Dire Wolf");
                Console.WriteLine("5. Thunderbird");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Unicorn" :
                   choice == "2" ? "Pegasus" :
                   choice == "3" ? "Hydra" :
                   choice == "4" ? "Dire Wolf" :
                   choice == "5" ? "Thunderbird" : null;
        }

        public string ChooseAbility()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Ability:");
                Console.WriteLine("1. Battle Rage - Unleash a warrior's fury, enhancing strength and attack speed for a short time.");
                Console.WriteLine("2. Flame Touch - Enchant your weapon with flames, scorching enemies with each strike.");
                Console.WriteLine("3. Arcane Blast - Harness ancient magic to unleash a powerful burst that damages foes in a");
                Console.WriteLine("4. Healing Touch - Channel divine energy to restore health to yourself or an ally.");
                Console.WriteLine("5. Shadow Step - Move through the shadows to reposition swiftly and evade danger.");
                Console.WriteLine("6. Invisibility - Cloak yourself in magic, becoming unseen to enemies and gaining the element of surprise.");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Battle Rage" :
                   choice == "2" ? "Flame Touch" :
                   choice == "3" ? "Arcane Blast" :
                   choice == "4" ? "Healing Touch" :
                   choice == "5" ? "Shadow Step" :
                   choice == "6" ? "Invisibility" : null;
        }

        public string ChooseOccupation()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Occupation:");
                Console.WriteLine("1. Wizard - A master of arcane arts, wielding powerful spells to control the battlefield and obliterate enemies.");
                Console.WriteLine("2. Knight - A noble warrior clads in heavy armor, excelling in melee combat and defending allies.");
                Console.WriteLine("3. Assassin - A stealthy killer who uses agility and precision to eliminate targets swiftly and silently.");
                Console.WriteLine("4. Alchemist - A skilled potion maker and scientist, crafting powerful brews and explosives to aid in battle.");
                Console.WriteLine("5. Merchant - A savvy trader who thrives on commerce, amassing wealth and acquiring rare goods.");
                Console.WriteLine("6. Ranger - A master of the wilderness, skilled with the bow and able to track and hunt foes from afar");
                Console.WriteLine("7. Craftsman - An artisan with unparalleled skills in creating weapons, armor, and tools essential for survival.");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6" || choice == "7")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Wizard" :
                   choice == "2" ? "Knight" :
                   choice == "3" ? "Assassin" :
                   choice == "4" ? "Alchemist" :
                   choice == "5" ? "Merchant" :
                   choice == "6" ? "Ranger" :
                   choice == "7" ? "Craftsman" : null;
        }

        public string ChooseJewelry()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Jewelry:");
                Console.WriteLine("1. Bracelet");
                Console.WriteLine("2. Necklace");
                Console.WriteLine("3. Earrings");
                Console.WriteLine("4. Ring");
                Console.WriteLine("5. Anklet");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Bracelet" :
                   choice == "2" ? "Necklace" :
                   choice == "3" ? "Earrings" :
                   choice == "4" ? "Ring" :
                   choice == "5" ? "Anklet" : null;
        }

        public string ChooseHeadwear()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Headwear:");
                Console.WriteLine("1. Bandana");
                Console.WriteLine("2. Berret");
                Console.WriteLine("3. Blade Helmet");
                Console.WriteLine("4. Crown");
                Console.WriteLine("5. Feather’s Cap");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Bandana" :
                   choice == "2" ? "Berret" :
                   choice == "3" ? "Blade Helmet" :
                   choice == "4" ? "Crown" :
                   choice == "5" ? "Feather’s Cap" : null;
        }

        public string ChooseRace()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Race:");
                Console.WriteLine("1. Orc");
                Console.WriteLine("2. Werewolf");
                Console.WriteLine("3. Human");
                Console.WriteLine("4. Elf");
                Console.WriteLine("5. Monster");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Orc" :
                   choice == "2" ? "Werewolf" :
                   choice == "3" ? "Human" :
                   choice == "4" ? "Elf" :
                   choice == "5" ? "Monster" : null;
        }

        public string ChooseBodyType()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Body Type:");
                Console.WriteLine("1. Slim");
                Console.WriteLine("2. Muscular");
                Console.WriteLine("3. Average");
                Console.WriteLine("4. Skinny");
                Console.WriteLine("5. Heavyset");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Slim" :
                   choice == "2" ? "Muscular" :
                   choice == "3" ? "Average" :
                   choice == "4" ? "Skinny" :
                   choice == "5" ? "Heavyset" : null;
        }

        public string ChooseRegion()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose Region:");
                Console.WriteLine("1. Forest of Eldoria - A lush, green forest filled with ancient trees and mystical creatures. Ideal for adventurers seeking a balance between danger and tranquility.");
                Console.WriteLine("2. Caves of Draugmar - Dark and mysterious underground caverns where ancient treasures and deadly monsters lie in wait. Perfect for those with a taste for danger and exploration.");
                Console.WriteLine("3. Kingdom of Soltaria - A grand and prosperous kingdom ruled by a wise king. Its bustling cities and peaceful countryside are perfect for characters seeking to build connections and influence.");
                Console.WriteLine("4. Desert of Karath - A vast, scorching desert full of ruins and hidden oases. A land of solitude and tough survival, where only the strongest and most resourceful thrive.");
                Console.WriteLine("5. Winter of Freljord - A harsh, icy landscape where survival is a constant struggle against the elements. Only the bravest can endure its freezing cold and fierce storms.");
                Console.Write("Enter a number: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Forest of Eldoria" :
                   choice == "2" ? "Caves of Draugmar" :
                   choice == "3" ? "Kingdom of Soltaria" :
                   choice == "4" ? "Desert of Karath" :
                   choice == "5" ? "Winter of Freljord" : null;
        }

        public string SkillsOffensive()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose 1 Offensive Skill (will help you deal damage to enemies and gain an edge in combat): ");
                Console.WriteLine("1. Power Strike: A strong melee attack that deals heavy damage to a single target.");
                Console.WriteLine("2. Fireball: Launches a fiery projectile that explodes on impact, dealing area-of-effect damage over time.");
                Console.WriteLine("3. Arcane Blast: Unleashes a burst of arcane energy that damages all nearby enemies in a small radius.");
                Console.WriteLine("4. Thunder Strike: Calls down a lightning bolt to strike a target, with a chance to stun nearby enemies. ");
                Console.Write("Enter a number to choose (1-4): ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Power Strike" :
                   choice == "2" ? "Fireball" :
                   choice == "3" ? "Arcane Blast" :
                   choice == "4" ? "Thunder Strike" : null;
        }

        public string SkillsSupportive()
        {
            string choice;
            do
            {
                Console.WriteLine("\nChoose 1 Supportive Skill (will aid you in survival, healing, or controlling the battlefield):");
                Console.WriteLine("1. Quick Dash: Temporarily boosts your movement speed, allowing you to dodge attacks or quickly close the distance to enemies.");
                Console.WriteLine("2. Heal: Restores a portion of health to yourself or an ally, perfect for staying alive in tough fights.");
                Console.WriteLine("3. Shadow Cloak: Grants temporary invisibility, allowing you to sneak past enemies or avoid damage.");
                Console.WriteLine("4. Ice Shield: Creates a barrier of ice around you that absorbs damage for a short period.");
                Console.WriteLine("5. Trap Setting: Place traps that trigger when enemies walk over them, causing damage or status effects like poison.");
                Console.WriteLine("6. Summon Familiar: Summons a magical creature to assist you in combat, offering support or distracting enemies. ");
                Console.Write("Enter a number to choose (1-6): ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please try again.");
                }
            } while (true);
            return choice == "1" ? "Quick Dash" :
                   choice == "2" ? "Heal" :
                   choice == "3" ? "Shadow Cloak" :
                   choice == "4" ? "Ice Shield" :
                   choice == "5" ? "Trap Setting" :
                   choice == "6" ? "Summon Familiar" : null;
        }

        #endregion

        #region -- FOR POINT ALLOCATION -- 
        public int GetPointsInput(int remainingPoints)
        {
            int points;
            while (true)
            {
                Console.WriteLine($"Enter points to allocate (1-5) [Remaining points: {remainingPoints}]:");
                points = int.Parse(Console.ReadLine());

                if (points >= 1 && points <= 5 && points <= remainingPoints)
                {
                    return points;
                }
                else
                {
                    Console.WriteLine($"Invalid input. Please enter a number between 1 and 5 and no more than {remainingPoints}.");
                }
            }
        }

        public (int strength, int agility, int intelligence, int vitality, int luck, int dexterity, int endurance) PointAllocation()
        {
            int strength = 0, agility = 0, intelligence = 0, vitality = 0, luck = 0, dexterity = 0, endurance = 0;
            int totalPoints = 20;

            Console.WriteLine("Distribute allocation points only (maximum of 5 each stat). Total remaining points: 20");

            while (totalPoints > 0)
            {
                Console.WriteLine($"\nRemaining Points: {totalPoints}");
                Console.WriteLine($"1. Strength ({strength})");
                Console.WriteLine($"2. Agility ({agility})");
                Console.WriteLine($"3. Intelligence ({intelligence})");
                Console.WriteLine($"4. Vitality ({vitality})");
                Console.WriteLine($"5. Luck ({luck})");
                Console.WriteLine($"6. Dexterity ({dexterity})");
                Console.WriteLine($"7. Endurance ({endurance})");

                Console.WriteLine("\nChoose a stat to allocate points to (1-7):");
                int choice = int.Parse(Console.ReadLine());

                if (choice < 1 || choice > 7)
                {
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 7.");
                    continue;
                }

                int pointsToAllocate = GetPointsInput(totalPoints);

                switch (choice)
                {
                    case 1: // Strength
                        strength += pointsToAllocate;
                        totalPoints -= pointsToAllocate;
                        break;

                    case 2: // Agility
                        agility += pointsToAllocate;
                        totalPoints -= pointsToAllocate;
                        break;

                    case 3: // Intelligence
                        intelligence += pointsToAllocate;
                        totalPoints -= pointsToAllocate;
                        break;

                    case 4: // Vitality
                        vitality += pointsToAllocate;
                        totalPoints -= pointsToAllocate;
                        break;

                    case 5: // Luck
                        luck += pointsToAllocate;
                        totalPoints -= pointsToAllocate;
                        break;

                    case 6: // Dexterity
                        dexterity += pointsToAllocate;
                        totalPoints -= pointsToAllocate;
                        break;

                    case 7: // Endurance
                        endurance += pointsToAllocate;
                        totalPoints -= pointsToAllocate;
                        break;
                }
            }


            return (strength, agility, intelligence, vitality, luck, dexterity, endurance);
        }
        #endregion
    }
}

