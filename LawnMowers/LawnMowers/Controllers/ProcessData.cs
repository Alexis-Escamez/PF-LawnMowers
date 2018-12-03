using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LawnMowers.Models;

namespace LawnMowers.Controllers
{
    public class ProcessData
    {
        GardenViewModel garden = new GardenViewModel();
        List<LawnMowersViewModel> lm = new List<LawnMowersViewModel>();
        int x_border = 0;
        int y_border = 0;
        int robots = 0;
        public List<LawnMowersViewModel> handler(string chain) {
           try
            {
                //split 
                string[] lines = chain.TrimStart().TrimEnd().Split(' ');
                //LM's Numbers
                robots = (lines.Length - 2) / 4; //gives you how many robots are
                //assign variables 
                x_border = int.Parse(lines[0]);
                y_border = int.Parse(lines[1]);

                //populate garden
                garden.val = new int[x_border + 1, y_border + 1];

                //create each robot
                int pos = 2;
                for (int i = 2; i < robots + 2; i++)
                {
                    lm.Add(new LawnMowersViewModel() { x = int.Parse(lines[pos]), y = int.Parse(lines[pos + 1]), o = lines[pos + 2], m = lines[pos + 3], n = 0 });
                    pos = pos + 4;
                }
                //move each robot
                foreach (var i in lm)
                {
                    moving(i);
                }
                return lm;
            }
            catch(Exception e) {
                lm.Clear();
                return lm;
            }
        }

        private void moving(LawnMowersViewModel lm) {
            foreach (char c in lm.m) {
                checkAndMove(lm, c.ToString());
            }
        }

        private void checkAndMove(LawnMowersViewModel lm, string c) {            
            switch (c)
            {
                case "L":
                    if (lm.o.Equals("N")) { lm.o = "W"; break; } 
                    if (lm.o.Equals("W")) { lm.o = "S"; break; } 
                    if (lm.o.Equals("S")) { lm.o = "E"; break; } 
                    if (lm.o.Equals("E")) { lm.o = "N"; break; }
                    break;
                case "R":
                    if (lm.o.Equals("N")) { lm.o = "E"; break; }
                    if (lm.o.Equals("W")) { lm.o = "N"; break; }
                    if (lm.o.Equals("S")) { lm.o = "W"; break; }
                    if (lm.o.Equals("E")) { lm.o = "S"; break; }
                    break;
                case "M":
                    //check orientation and move
                    switch (lm.o)
                    {
                        case "N":
                            if (garden.val[lm.x, lm.y + 1] == 0 && checkBorder(lm.x, lm.y + 1))
                            {
                                garden.val[lm.x, lm.y + 1] = 1;
                                garden.val[lm.x, lm.y] = 0;
                                lm.y = lm.y + 1;
                                lm.n++;
                            }
                            break;
                        case "E":
                            if (garden.val[lm.x + 1, lm.y] == 0 && checkBorder(lm.x + 1, lm.y))
                            {
                                garden.val[lm.x + 1, lm.y] = 1;
                                garden.val[lm.x, lm.y] = 0;
                                lm.x = lm.x + 1;
                                lm.n++;
                            }
                            break;
                        case "S":
                            if (garden.val[lm.x, lm.y - 1] == 0 && checkBorder(lm.x, lm.y - 1))
                            {
                                garden.val[lm.x, lm.y - 1] = 1;
                                garden.val[lm.x, lm.y] = 0;
                                lm.y = lm.y - 1;
                                lm.n++;
                            }
                            break;
                        case "W":
                            if (garden.val[lm.x - 1, lm.y] == 0 && checkBorder(lm.x - 1, lm.y))
                            {
                                garden.val[lm.x - 1, lm.y] = 1;
                                garden.val[lm.x, lm.y] = 0;
                                lm.x = lm.x - 1;
                                lm.n++;
                            }
                            break;

                        default: break;
                    }
                    break;
                default:break;
            }           
        }

        private bool checkBorder(int x, int y) {
            
            if ((x >= 0 && x <= x_border) && (y >= 0 && y <= y_border))
            {
                return true;
            }
            return false;
        }

    }
}