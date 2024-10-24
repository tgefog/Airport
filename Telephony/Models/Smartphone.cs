﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Models.Interafaces;

namespace Telephony.Models
{
    internal class Smartphone : ICallable,IBrowsable
    {
        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {phoneNumber}";
        }
        public string Browse(string url)
        {
            if (!ValidateUrl(url))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }

        private bool ValidateUrl(string url)
        {
            return url.All(c=>!char.IsDigit(c));
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(c=>char.IsDigit(c));
        }
    }
}
