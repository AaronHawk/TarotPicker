using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarotPicker.Models
{
    public static class TarotConstants
    {
        public static List<Card> AllCards = new List<Card>
    {
        new Card { Name = "0 - The Fool", Description = "The Fool represents new beginnings...", ImagePath = "path/to/fool.png" },
        new Card { Name = "1 - The Magician", Description = "The Magician embodies potential...", ImagePath = "path/to/magician.png" },
        // ...
    };
    }
}
