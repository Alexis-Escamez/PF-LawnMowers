using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LawnMowers.Models
{
    public class GardenViewModel
    {
        public int[,] val { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        //List<LawnMowersViewModel> lm { get; set; } = new List<LawnMowersViewModel>();
    }
}