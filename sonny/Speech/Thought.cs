using System;
using System.Collections.Generic;
using System.Text;
using sonny.Speech.Models;

namespace sonny.Speech
{
    public class Thought
    {
        private readonly Phrases _phrases;

        public Thought() {
            _phrases = new Phrases();
        }

        public string SayHello() {
            return _phrases.GenerateRandomHello() + " " + _phrases.GenerateIntroduction();
        }

        public string SayRandomPhrase() {
            return _phrases.GenerateRandomMessageText();
        }

        public string SayGoodbye() {
            return _phrases.GenerateRandomGoodbye() + " Goodbye.";
        }
    }
}
