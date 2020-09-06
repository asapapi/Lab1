﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.GetSpeech().Split(new char[] { ' ', ',', '.', ':', '\t' });
            foreach (string s in program.GetSpeech()) {
                if (s.Trim() != "")
                    Console.WriteLine(s);
            }
            Dictionary<string,int> wordList = new Dictionary<string, int>();
            wordList.Add(program.GetSpeech(),1);
            string[] options = new string[6];
            options[0] = "1 : Show Histogram";
            options[1] = "2 : Search for word";
            options[2] = "3 : Save Histogram";
            options[3] = "4 : Load Histogram";
            options[4] = "5 : Remove Word";
            options[5] = "6 : Exit";
            int userInput;
            while (true) {
                program.ReadChoice("please select an option ", options, out userInput);

                switch (userInput) {
                    case 1: Console.WriteLine("Show Histogram");
                        break;
                    case 2: Console.WriteLine("Search for word");
                        break;
                    case 3: Console.WriteLine("Save Histogram");
                        break;
                    case 4: Console.WriteLine("Load Histogram");
                        break;
                    case 5: Console.WriteLine("Remove Word");
                        break;
                    case 6: Console.WriteLine("Exit");
                        break;

                }
                break;
            }


            


        }
        public int ReadInteger(string prompt, int min, int max) {
            while (true) {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput, out int number) && number >= min && number <= max) {
                    return number;
                }
            }
        }
        public void ReadString(string prompt, ref string value) {
            while (true) {
                Console.WriteLine(prompt);
                value = Console.ReadLine();
                
            }
        }
        public void ReadChoice(string prompt, string[]options,out int selection) { 
            
            for(int i = 0; i < options.Length; i++) {
                Console.WriteLine(options[i] + " ");
                
                
            }
            selection = ReadInteger(prompt, 1, 6);
            Console.WriteLine("Please select an option " +  ReadInteger(prompt,1,6));

        }
        public String GetSpeech() {
            string text = "I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream. It is a dream deeply rooted in the American dream. " +
          "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " +
          "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " +
          "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " +
          "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " +
          "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " +
          "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " +
          "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope. With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " +
          "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " +
          "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " +
          "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire. Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " +
          "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia! " +
          "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi. From every mountainside, let freedom ring. " +
          "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!";


            string[] split = text.Split(new char[] { ' ', ',', '.', ':', '\t' });
            foreach (string s in split) {
                if (s.Trim() != "")
                    Console.WriteLine(s);
            }

            return text ;

        }


    }
}

