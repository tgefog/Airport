using LogForU.Core.Enums;
using LogForU.Core.Exceptions;
using LogForU.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Models
{
    public class Message
    {
        //Todo validations
        private string createdTime;
        private string text;
        public Message(string createdTime, string text, ReportLevel reportLevel)
        {
            CreatedTime = createdTime;
            Text = text;
            ReportLevel = reportLevel;
        }
        public string CreatedTime
        {
            get
            {
                return createdTime;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyCreatedTimeException();
                }
                if (!DateTimeValidator.ValidateDateTimeFormat(value))
                {
                    throw new InvalidDateTimeFormatException();
                }
                    createdTime = value;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyMessageTextException();
                }
                text = value;
            }
        }
        public ReportLevel ReportLevel { get; set; }
    }
}
