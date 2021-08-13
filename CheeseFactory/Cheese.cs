using System;

namespace CheeseFactory
{
    public class Cheese
    {
        int ID, BatchNum;
        string strName;
        DateTime? mDate, bbDate;

        public Cheese()
        {
            ID = 0;
            BatchNum = 0;
            strName = "";
            mDate = null;
            bbDate = null;
        }

        public Cheese(int id, int batchnumber, string name, DateTime? MDate, DateTime? BBDate)
        {
            ID = id;
            BatchNum = batchnumber;
            strName = name;
            mDate = MDate;
            bbDate = BBDate;
        }

        public string CheeseToString()
        {
            return "Cheese Name: " + strName +
                "\nCheese ID: " + ID +
                "\nCheese Batch Number: " + BatchNum +
                "\nManufacture Date: " + mDate +
                "\nBest Before Date: " + bbDate;
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("id"))
                {
                    return this.ID;
                }
                else if (attrName.ToLower().Equals("batchnum"))
                {
                    return this.BatchNum;
                }
                else if (attrName.ToLower().Equals("name"))
                {
                    return this.strName;
                }
                else if (attrName.ToLower().Equals("mdate"))
                {
                    return this.mDate;
                }
                else if (attrName.ToLower().Equals("bbdate"))
                {
                    return this.bbDate;
                }

                return null;
            }

            set
            {
                if (attrName.ToLower().Equals("id"))
                {
                    this.ID = (int)value;
                }
                else if (attrName.ToLower().Equals("batchnum"))
                {
                    this.BatchNum = (int)value;
                }
                else if (attrName.ToLower().Equals("name"))
                {
                    this.strName = (string)value;
                }
                else if (attrName.ToLower().Equals("mdate"))
                {
                    this.mDate = (DateTime?)value;
                }
                else if (attrName.ToLower().Equals("bbdate"))
                {
                    this.bbDate = (DateTime?)value;
                }
            }
        }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.ID;
                    case 1:
                        return this.BatchNum;
                    case 2:
                        return this.strName;
                    case 3:
                        return this.mDate;
                    case 4:
                        return this.bbDate;
                    default:
                        break;
                }
                return null;
            }

            set
            {
                switch (index)
                {
                    case 0:
                        this.ID = (int)value;
                        break;
                    case 1:
                        this.BatchNum = (int)value; ;
                        break;
                    case 2:
                        this.strName = (string)value;
                        break;
                    case 3:
                        this.mDate = (DateTime?)value;
                        break;
                    case 4:
                        this.bbDate = (DateTime?)value;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
