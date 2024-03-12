using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace OOPEx
{
    public class SpaceShip
    {
        public LandingSystem LandingSystem { get; set; }
        public BoardComputer BoardComputer { get; set; }
        public NavigationSystem NavigationSystem { get; set; }
        public Rocket Rocket { get; set; }
        public SubCommander SubCommander { get; set; }
        public List<Astronaut> Astronauts { get; set; }
        public bool IsLaunched { get; set; }
        public SpaceShip(SubCommander subcommander)
        {
            LandingSystem = new LandingSystem();
            BoardComputer = new BoardComputer();
            NavigationSystem = new NavigationSystem();
            Rocket = new Rocket(NavigationSystem);
            SubCommander = subcommander;
            Astronauts = new List<Astronaut>();
            IsLaunched = false;
        }

        public SpaceShip () : this(new SubCommander("No name", 0))
        {
        }

        public string IsPiloting()
        {
            if (BoardComputer.AI.ImPiloting() && SubCommander.ImPiloting())
            {
                return "Is piloting AI";
            } else if (SubCommander.ImPiloting())
            {
                return "Is piloting SubCommander";
            }
            else if (BoardComputer.AI.ImPiloting())
            {
                return "Is piloting AI";
            }
            else
            {
                return "Is not piloting";
            }
        }
    }
}
