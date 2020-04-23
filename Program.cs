using System.Runtime.Serialization.Json;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Dynamic;
using Internal;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Data;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Net.Http;
using System;

namespace Guessgame
{
    class Program
    {
        static void Main(string[] args)
        {
         Random random=new Random();
         int RandomNumber=random.next();
         int guessCount=0;
         int guess=0;
         bool gamever=false;
         
         Console.WriteLine("do you want to choose level to play?Easy,Medium and Hard");
         string choice=(easy,medium,hard);
         if (choice==easy)
            do
            {
              int randomNumber = random.next(1,10); 
              int guessCount=6; 
            } while (true);
            {
                Console.Write("Guess a number between 1 and 10");
                int input=Convert.ToInt32(Console.ReadLine());
                if(input < randomNumber && input<guesscout)
            {
              Console.WriteLine("you loose");
             string triesLeft= guesscount--;
              Console.WriteLine("your remaining trier"+triesLeft);
                guessCount++;
                continue;
            }
            else if (input > randomNumber && input<guessCount)
            {
                Console.WriteLine("You loose");
                triesLeft=guessCount--;
                Console.WriteLine("your remaining trier"+triesLeft);
                guessCount++;
                continue;
            }
            else if (input==randmNumber && input <= guessCount)
            {
                Console.WriteLine("congratulation, You are right");
              string triesLeft=guessCount--;
                Console.Writeline("your remaining trier:"+triesLeft);
                guessCount++;
            }
            else 
            {
             Console.WriteLine("gameOver");
                Console.WriteLine("would you like to retry? y/n");
             string answer= Console.Readline();
             if(answer !=y)
             {
                 gameOver= false;
             }
             break;   
            }
         if(choice==Medium)
            do
            {
              int randomNumber = random.next(1,20); 
              int guessCount=4; 
            } while (true);
            {
                Console.Write("Guess a number between 1 and 20");
                int input=Convert.ToInt32(Console.ReadLine());
                if(input < randomNumber && input<guesscout)
            {
              Console.WriteLine("you loose");
              string triesLeft= guesscount--;
              Console.WriteLine("your remaining trier"+triesLeft);
                guessCount++;
                continue;
            }
            else if (input>randomNumber && input<guessCount)
            {
                Console.WriteLine("You loose");
                triesLeft=guessCount--;
                Console.WriteLine("your remaining trier"+triesLeft);
                guessCount++;
                continue;
            }
            else if (input==randmNumber && input <= guessCount)
            {
                Console.WriteLine("congratulation, You are right");
                triesleft=guessCount;
                ConsoleWriteline("your remaining trier:"+triesLeft);
                guessCount++;
            }
            else 
            {
             Console.WriteLine("gameOver");
                Console.WriteLine("would you like to retry? y/n");
             string answer= Console.Readline();
             if(answer !=y)
             {
                 gameOver= false;
             }
             break;

            } 
         if (choice==hard)
            do
            {
              int randomNumber = random.next(1,50); 
              int guessCount=4; 
            } while (true);
            {
                Console.Write("Guess a number between 1 and 50");
                int input=Convert.ToInt32(Console.ReadLine());
                if(input < randomNumber && input<guesscout)
            {
              Console.WriteLine("you loose");
              string triesLeft= guesscount--;
              Console.WriteLine("your remaining trier"+triesLeft);
                guessCount++;
                continue;
            }
            else if (input>randomNumber && input<guessCount)
            {
                Console.WriteLine("You loose");
               string triesLeft=guessCount--;
                Console.WriteLine("your remaining trier"+triesLeft);
                guessCount++;
                continue;
            }
            else if (input==randmNumber && input <= guessCount)
            {
                Console.WriteLine("congratulation, You are right");
                triesleft=guessCount;
                Console.Writeline("your remaining trier:"+triesLeft);
                guessCount++;
            }
            else 
            {
             Console.WriteLine("gameOver"); 
             Console.WriteLine("would you like to retry? y/n");
             string answer= Console.Readline();
             if(answer !=y)
             {
                 gameOver= false;
             }
             break;
            }

           Console.WriteLine();  
        }
       
    }
}


