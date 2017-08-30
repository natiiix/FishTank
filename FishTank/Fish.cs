using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public class Fish
    {
        private Vector2 m_locaiton;
        private Vector2 m_direction;

        public Fish(Vector2 location, Vector2 direction)
        {
            m_locaiton = location;
            m_direction = direction;
        }

        /// <summary>
        /// Moves the fish in its current direction multiplied by the supplied factor.
        /// </summary>
        /// <param name="factor">Determines how much is the fish going to move.</param>
        public void Move(double factor = 1.0)
        {
            m_locaiton += m_direction * factor;
        }
    }
}