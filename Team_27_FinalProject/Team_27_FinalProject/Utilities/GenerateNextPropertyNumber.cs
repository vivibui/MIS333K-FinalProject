using Team_27_FinalProject.DAL;
using System;
using System.Linq;


namespace Team_27_FinalProject.Utilities
{
    public static class GenerateNextPropertyNumber
    {
        public static Int32 GetNextPropertyNumber (AppDbContext _context)
        {
            //set a constant to designate where the property numbers 
            //should start
            const Int32 START_NUMBER = 3001;

            Int32 intMaxPropertyNumber; //the current maximum property number
            Int32 intNextPropertyNumber; //the property number for the next class

            if (_context.Properties.Count() == 0) //there are no properties in the database yet
            {
                intMaxPropertyNumber = START_NUMBER; //property numbers start at 3001
            }
            else
            {
                intMaxPropertyNumber = _context.Properties.Max(p => p.PropertyNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxPropertyNumber < START_NUMBER)
            {
                intMaxPropertyNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextPropertyNumber = intMaxPropertyNumber + 1;

            //return the value
            return intNextPropertyNumber;
        }

    }
}