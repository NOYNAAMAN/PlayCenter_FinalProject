using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCenter.Models
{
    public class Game
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string ExecutablePath { get; set; }
        public string MoreInfo { get; set; }
        public string LaunchButtonColor { get; set; }
        public string MoreInfoButtonColor { get; set; }
    }
}
