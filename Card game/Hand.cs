using Quartet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_game
{
    internal class Hand
    {
        List<CarCard> carCards;
        public CarCard topcard()
        {
            return carCards[0];
        }
        public void Add(CarCard carCard)
        {
            carCards.Add(carCard);
        }
    }
}
