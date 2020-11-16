using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;

namespace KodaMHåkan
{
    class Car
    {

        private string licenseNumber;

        private string color;

        public string LicenseNumber 
        {
            get {return "*** " + licenseNumber + " ***";}
            set 
            {
                string letters = value.Substring(0, 3);
                
                bool isNumbers = int.TryParse(value.Substring(3, 3), out int numbers);

                if (value.Length != 6)
                {
                    throw new Exception("Registreringsnumret du angett är för långt/kort!");

                }
                //(letters.Any(c => char.IsDigit(c)))
                
                if (letters.Any(char.IsDigit))
                {

                    throw new Exception("Registreringsnumret du angett får inte ange " +
                        "siffror som någon av de tre första karaktärerna");

                }
                if (!isNumbers)
                {
                    throw new Exception("Registreringsnumret du angett får inte ange " +
                        "bokstäver som någon av de tre sista karaktärerna");
                }

                if (letters.Contains("KUK"))// Mycket fult ord
                {
                    throw new Exception("Olämpligt regNummer");

                }

                licenseNumber = value;
            }

        }

        public string Color 
        {
            get
            {
                if (color == "red")
                {
                    return "röd".ToUpper(); 
                }
                if (color == "green")
                {
                    return "grön".ToUpper();
                }
                if (color == "blue")
                {
                    return  "blå".ToUpper();
                }
                if (color == "yellow".ToUpper())
                {
                    return  "gul".ToUpper();
                }
                return color; 
               
            } 
            
            set 
            {
                value = value.ToLower(); 

                if (value == "red" || value == "green" || value == "blue" || value == "yellow")
                {
                    color = value;
                }
                else
                    throw new Exception("Färgen du angett ingår inte i paletten");
            }

        }

        //public void SetLicenseNumber(string lNumber)
        //{
        //    string letters = lNumber.Substring(0, 3);
        //    int numbers = 0;
        //    bool isNumbers = int.TryParse(lNumber.Substring(3, 3), out numbers);

        //    if (lNumber.Length != 6)
        //    {
        //        throw new Exception("Registreringsnumret du angett är för långt/kort!");

        //    }
        //    if (letters.All(char.IsDigit))
        //    {

        //        throw new Exception("Registreringsnumret du angett får inte ange " +
        //            "siffror som någon av de tre första karaktärerna");

        //    }
        //    if (!isNumbers)
        //    {
        //        throw new Exception("Registreringsnumret du angett får inte ange " +
        //            "bokstäver som någon av de tre sista karaktärerna");
        //    }

        //    if (letters.Contains("KUK"))
        //    {
        //        throw new Exception("Olämpligt regNummer");

        //    }

        //licenseNumber = lNumber;

        //}

        //public void SetColor(string c) 
        //{
        //    if (c.ToLower() == "red" || c.ToLower() == "green" || c.ToLower() == "blue" || c.ToLower() == "yellow")
        //    {
        //        color = c;
        //    }
        //    else
        //        throw new Exception("Färgen du angett ingår inte i paletten"); 
        //}

        //public string GetColor() 
        //{
        //    string colorSvenska = null; 

        //    if (color == "red") 
        //    {
        //        colorSvenska = "röd";
        //    }
        //    if (color == "green")
        //    {
        //        colorSvenska = "grön";
        //    } 
        //    if (color == "blue")
        //    {
        //        colorSvenska = "blå";
        //    }
        //    if (color == "yellow")
        //    {
        //        colorSvenska = "gul";
        //    }

        //    return colorSvenska; 
        //}



    }
}
