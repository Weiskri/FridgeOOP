using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    public class Fridge
    {
        //fields

        private bool isClean;
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;

        //properties
        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }
        }
        public string DispenserType
        {
            get { return this.dispenserType; }
        }
        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }
        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }


        //constructors

        //methods()
    }
}
