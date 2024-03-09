using builders_Project.Models;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace license.services
{
    internal class PlaceService
    {
        private readonly Place place;
        private readonly Context context;
       
        /// Parameterless Constructor
        public PlaceService()
        {
            place = new Place();
            context = new Context();
        }



        /// Search

        public Place GetPlaceByID(int ID)
        {

            Place item = (Place)context.places.Include(p=>p.classification).FirstOrDefault(p => p.ID == ID);
            return item;

        }
        public Place GetPlaceByCode(string code)
        {
            
            Place item= (Place)context.places.Include(p=>p.classification).FirstOrDefault(p => p.Code == code);
            return item;    

        }
        public List<Place> GetPlaceByCode(string code,string classification ,string address )
        {
            List<Place> place;
            if (classification == "")
            {
                place = context.places.Include(p=>p.classification).Where(p => p.Address == address && p.Code == code).ToList();

            }
            else if (address == "")
            {
                place = context.places.Include(p=>p.classification).Where(p => p.classification.Name == classification && p.Code == code).ToList();
                
            }
            else
            {
                 place = context.places.Include(p=>p.classification).Where(p => p.Code == code && 
                 p.classification.Name == classification && p.Address == address).ToList();
            }
            return place;

        }

        //public List<Place>  GetPlace()
        //{
        //    List < Place > place = context.places.ToList();
        //    return place;
        //}



        public Place GetPlaceByName(string name)
        {

            Place item = (Place)context.places.Include(p=>p.classification).FirstOrDefault(p => p.Name == name);
            return item;

        }
        public List<Place> GetPlaceByName(string name, string classification, string address)
        {

            List<Place> place;
            if (classification == "")
            {
                place = context.places.Include(p => p.classification).Where(p => p.Address == address && p.Name == name).ToList();

            }
            else if (address == "")
            {
                place = context.places.Include(p => p.classification).Where(p => p.classification.Name == classification && p.Name == name).ToList();

            }
            else
            {
                place = context.places.Include(p => p.classification).Where(p => p.Name == name &&
                p.classification.Name == classification && p.Address == address).ToList();
            }
            return place;

        }
        public Place GetPlaceByClassification(string Classification)
        {

            Place item = (Place)context.places.Where(p => p.Classification_ID == Classification);
            return item;
        }
        public Place GetPlaceByAccetapttence(string status)
        {
            Place item = (Place)context.places.Where(p => p.Status == status);
            return item;
        }
        public List<string> GetUniqueAddresses()
        {
            var uniqueAddresses = context.places
                .Select(p => p.Address)
                .Distinct()
                .ToList();

            return uniqueAddresses;
        }




        /// Get Reports 



        public List<Place> AnnualReporting(string Classification, string address)
        {
            
            var currentDate = DateTime.Now;
            var oneYearFromNow = currentDate.AddYears(1);
            if (string.IsNullOrEmpty(address))
            {
                return context.places
                    .Where(p => p.classification.Name == Classification)
                    .AsEnumerable()
                    .Where(p =>
                     p.license_Start_Date <= currentDate&&p.license_End_Date <= oneYearFromNow && p.license_End_Date > currentDate)
                    .ToList();
            }
            else
            {
                return context.places
                    .Where(p => p.classification.Name == Classification && p.Address == address)
                    .AsEnumerable()
                    .Where(p =>
                   p.license_End_Date <= oneYearFromNow && p.license_End_Date >= currentDate)
                    .ToList();
            }
        }




        public List<Place> SecondReporting(string classificationName, string address)
        {
            var currentDate = DateTime.Now;
            var twoYearsFromNow = currentDate.AddYears(2);
           
            if (string.IsNullOrEmpty(address))
            {
                return context.places
                    .Where(p => p.classification.Name == classificationName)
                    .AsEnumerable()
                    .Where(p => p.license_End_Date <= twoYearsFromNow && p.license_End_Date > currentDate)
                    .ToList();
            }
            else
            {
                return context.places
                    .Where(p => p.classification.Name == classificationName && p.Address == address)
                    .AsEnumerable()
                    .Where(p => p.license_End_Date <= twoYearsFromNow && p.license_End_Date >= currentDate)
                    .ToList();
            }
        }

        public List<Place> Expire_Date_Reporting_Before_Month(string classificationName, string address)
        {
            var currentDate = DateTime.Now;
            var oneMonthFromNow = currentDate.AddMonths(1);

            if (string.IsNullOrEmpty(address))
            {
                return context.places
                    .Where(p => p.classification.Name == classificationName)
                    .AsEnumerable()
                    .Where(p => p.license_End_Date <= oneMonthFromNow && p.license_End_Date > currentDate)
                    .ToList();
            }
            else
            {
                return context.places
                    .Where(p => p.classification.Name == classificationName && p.Address == address)
                    .AsEnumerable()
                    .Where(p => p.license_End_Date <= oneMonthFromNow && p.license_End_Date >= currentDate)
                    .ToList();
            }
        }

        public List<Place> License_Expire_Date(string classificationName, string address)
        {
            var currentDate = DateTime.Now;

            if (string.IsNullOrEmpty(address))
            {
                return context.places
                    .Where(p => p.classification.Name == classificationName)
                    .AsEnumerable()
                    .Where(p => p.license_End_Date < currentDate)
                    .ToList();
            }
            else
            {
                return context.places
                    .Where(p => p.classification.Name == classificationName && p.Address == address)
                    .AsEnumerable()
                    .Where(p => p.license_End_Date < currentDate)
                    .ToList();
            }
        }

        public List<Place> License_Expire_Between_Tow_Dates(string classificationName, string address, DateTime Start, DateTime End)
        {
            if (string.IsNullOrEmpty(address))
            {
                return context.places
                    .Where(p => p.classification.Name == classificationName &&
                                p.license_Start_Date >= Start &&
                                p.license_End_Date <= End)
                    .ToList();
            }
            else
            {
                return context.places
                    .Where(p => p.classification.Name == classificationName &&
                                p.Address == address &&
                                p.license_Start_Date >= Start &&
                                p.license_End_Date <= End)
                    .ToList();
            }
        }


        public void Update_License(DateTime Start_date, DateTime End_Date,int ID)
        {
            Place place=context.places.Where(place => place.ID == ID).FirstOrDefault();
            place.license_Start_Date = Start_date;
            place.license_End_Date = End_Date;
        }

       


    }
}
