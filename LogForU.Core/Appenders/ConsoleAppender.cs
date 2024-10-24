using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Appenders
{
    public class ConsoleAppender : IAppender
    {
        //Todo Add layout
        public ConsoleAppender(ILayout layout, ReportLevel reportLevel = ReportLevel.Info)
        {
            ReportLevel = reportLevel;
            Layout = layout;
        }
        public ILayout Layout { get; private set; }
        public ReportLevel ReportLevel { get; set; }

        public int MessagesAppended { get; private set; }



        public void Append(Message message)
        {
            Console.WriteLine(string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text));
            MessagesAppended++;
        }
    }
}
