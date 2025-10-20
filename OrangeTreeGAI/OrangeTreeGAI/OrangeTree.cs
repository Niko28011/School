using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrangeTree
{
    private int age;
    private int height;
    private bool isAlive;
    private int numOranges;
    private int orangesEaten;

    public OrangeTree()
    {
        age = 0;
        height = 0;
        isAlive = true;
        numOranges = 0;
        orangesEaten = 0;
    }

    public void SetAge(int value) => age = value;
    public int GetAge() => age;

    public void SetHeight(int value) => height = value;
    public int GetHeight() => height;

    public void SetTreeAlive(bool value) => isAlive = value;
    public bool GetTreeAlive() => isAlive;

    public int GetNumOranges() => numOranges;
    public int GetOrangesEaten() => orangesEaten;

    public void EatOrange(int count)
    {
        if (count <= numOranges)
        {
            orangesEaten += count;
            numOranges -= count;
        }
        else
        {
            orangesEaten += numOranges;
            numOranges = 0;
        }
    }

    public void OneYearPasses()
    {
        age++;

        // Reset oranges eaten for the new year
        orangesEaten = 0;

        if (!isAlive)
        {
            return;
        }

        if (age >= 80)
        {
            isAlive = false;
            numOranges = 0;
            return;
        }

        height += 2;

        if (age >= 2)
        {
            numOranges = (age - 1) * 5;
        }
        else
        {
            numOranges = 0;
        }
    }
}
