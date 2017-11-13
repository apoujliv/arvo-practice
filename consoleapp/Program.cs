using System;
using System.IO;
using System.Threading;
using consoleapp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using sonny;
using sonny.Speech;

namespace consoleapp
{
    class Program
    {
        private static IConfigurationRoot _configuration;
        private static sonnyAI.sonny _sonny;
        private static bool IsRunning { get; set; }
        static void Main(string[] args)
        {
            IsRunning = true;

            Console.WriteLine(@"                _                        
                \`*-.
                 )  _`-.
                .  : `. .                
                : _   '  \               
                ; *` _.   `*-._
                `-.- '          `-.       
                  ;       `       `.     
                  :.       .        \    
                  . \  .   :   .-'   .   
                  '  `+.;  ;  '      :   
                  :  '  |    ;       ;-. 
                  ; '   : :`-:     _.`* ;
               .* ' /  .*'; .*`-+'  `*'
               `*-*   `*-*  `*-*'        ");
            Console.WriteLine("You've started a console app to test things in .Net Core.");
            Console.WriteLine("\n\nLet's begin.");
            Console.WriteLine("\n\nsonny is starting up.");
            StartSonny();

            while (IsRunning)
            {
                string input = Console.ReadLine();
                _sonny.Listen(input);

            }
        }

        private static void Exit(Object sender, EventArgs e)
        {
            IsRunning = false;
            Thread.Sleep(2000);
        }

        private static void StartSonny() {
            _sonny = new sonnyAI.sonny();
            _sonny.Exit += Exit;
        }
    }
}
