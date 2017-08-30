using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FishTank
{
    public class Tank
    {
        private Random m_rand;
        private List<Fish> m_fish;

        public Tank(int fishCount)
        {
            Initialize(fishCount);
        }

        /// <summary>
        /// Method for easier generation of random scaled double values.
        /// </summary>
        /// <param name="scale">Scale factor for the output double value.</param>
        /// <returns>Returns a double value in range -scale - scale.</returns>
        private double GetRandomDouble(double scale = 1.0)
        {
            return (m_rand.NextDouble() - 0.5) * 2.0 * scale;
        }

        /// <summary>
        /// Method for generation of random scaled two-dimensional vectors.
        /// </summary>
        /// <param name="scale">Scale factor for the vector coordinates.</param>
        /// <returns>Returns a randomly generated scaled two-dimensional vector.</returns>
        private Vector2 GetRandomVector(double scale = 1.0)
        {
            return new Vector2(GetRandomDouble(scale), GetRandomDouble(scale));
        }

        /// <summary>
        /// Initializes the Tank object by randomly generating a specified number of fish.
        /// </summary>
        /// <param name="fishCount">How many fish are supposed to be generated.</param>
        public void Initialize(int fishCount)
        {
            m_rand = new Random();
            m_fish = new List<Fish>();

            for (int i = 0; i < fishCount; i++)
            {
                m_fish.Add(new Fish(GetRandomVector(), GetRandomVector()));
            }
        }

        /// <summary>
        /// Creates a bitmap based on the current location of all the fish in the tank.
        /// </summary>
        /// <param name="width">Width of the output bitmap.</param>
        /// <param name="height">Height of the output bitmap.</param>
        /// <returns>Returns a bitmap representation of the fish in the tank.</returns>
        public Bitmap ToBitmap(int width = 800, int height = 600)
        {
            // TODO
            return new Bitmap(width, height);
        }
    }
}