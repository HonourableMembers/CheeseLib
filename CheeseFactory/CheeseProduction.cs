using System;
using System.Collections.Generic;

namespace CheeseFactory
{
    public class CheeseProduction
    {
        List<Cheese> Factory = new List<Cheese>();

        private int iSize = 0;
        public int ListSize { get => iSize; }

        public void addCheese(int id, int batchnumber, string name, DateTime? MDate, DateTime? BBDate)
        {
            Factory.Add(new Cheese(id, batchnumber, name, MDate, BBDate));
            iSize++;
        }

        public void removeCheese(Cheese toRemove)
        {
            Factory.Remove(toRemove);
        }

        public List<string> CheeseList()
        {
            List<string> output = new List<string>();

            for (int i = 0; i < ListSize; i++)
            {
                output.Add(Factory[i].CheeseToString());
            }

            return output;
        }


        public Cheese search(int ID)
        {
            Cheese toReturn = null;

            for (int i = 0; i < ListSize; i++)
            {
                Cheese temp = Factory[i];
                if ((int)temp["id"] == ID)
                {
                    toReturn = temp;
                }
            }

            return toReturn;
        }
    }
}
