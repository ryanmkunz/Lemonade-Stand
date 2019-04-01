using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Game
    {
        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        public Day Day
        {
            get => default(Day);
            set
            {
            }
        }

        public Store Store
        {
            get => default(Store);
            set
            {
            }
        }

        public UserInterface UserInterface
        {
            get => default(UserInterface);
            set
            {
            }
        }

        public string GetWeather()
        {
            throw new System.NotImplementedException();
        }

        public int GetGameDurration()
        {
            throw new System.NotImplementedException();
        }

        public int GetDemand()
        {
            throw new System.NotImplementedException();
        }

        public void FindCustomers()
        {
            throw new System.NotImplementedException();
        }
    }
}