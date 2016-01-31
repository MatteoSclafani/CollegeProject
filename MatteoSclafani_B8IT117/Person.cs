using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MatteoSclafani_B8IT117
{
    public class Person
    {
        //variables

        private string pps;
        private string name;
        private string address;
        private string phone;
        private string email;
        private bool flag = false;

        

        // Autoimplemented properties

        public string Pps
        {
            get { return pps;  }

            set
            {

                if (value.Length==7 && value.EndsWith("N"))

                {
                    pps = value;

                }

                else throw new ArgumentOutOfRangeException("Invalid PPS number");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.All(char.IsLetter))
                {

                    name = value;

                }
                else throw new ArgumentException("Not alphanumeric characters are allowed");
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (value.All(char.IsDigit))
                {
                    phone = value;
                }
                else throw new ArgumentException("Not Digit are allowed");
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (IsValidEmail(value))
                {

                    email = value;

                }
                else throw new ArgumentException("Invalid E-Mail Format");
            }
        }

        //Constructors

        public Person() { }

    
        public Person(string name, string pps, string address, string phone,string email)
        {

            this.Name = name;
            this.Phone = phone;
            this.Pps = pps;
            this.Address = address;
            this.Email = email;

        }

        public override string ToString()
        {

            return string.Format("\nName: {0} \nPPS: {1} \nAddress:{2} \nPhone:{3} \nEmail: {4}", this.Name, this.Pps, this.Address, this.Phone, this.Email);
            
        }

        #region Validate Email Method
        public bool IsValidEmail(string strIn)
        {
            flag = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (flag)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                flag = true;
            }
            return match.Groups[1].Value + domainName;
        }
        #endregion
    }
}

