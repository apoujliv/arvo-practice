using System;
using System.Collections.Generic;
using System.Text;

namespace sonny.Speech.Models
{
    public interface IPhrases {
        string GenerateRandomHello();
        string GenerateIntroduction();
        string GenerateRandomGoodbye();
        string GenerateRandomMessageText();

    }
}
