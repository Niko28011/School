using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        //Age
        public void SetAge(int age) 
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        //Height
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return height;
        }
        //Alive       
        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }
        public bool GetTreeAlive()
        {
            return treeAlive;
        }
        //numOranges
        public int GetNumOranges()
        {
            return numOranges;
        }
        //Eaten
        public int GetOrangesEaten()
        {
            return orangesEaten;
        }
        //OneYearPasses
        public void OneYearPasses()
        {
            age++;
            if (age < 80)
            {
                height += 2;
            }
            else
            {
                treeAlive = false;
            }
            numOranges = 0;
            if (age > 0 && treeAlive)
            {
                numOranges = (age - 1) * 5;
            }
            orangesEaten = 0;
        }
        //EatOrange
        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                orangesEaten += count;
                numOranges -= count;
            }
            
        }

        


        
        
    }
}
