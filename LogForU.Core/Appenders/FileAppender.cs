using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.IO.Interfaces;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models;

namespace LogForU.Core.Appenders
{
    public class FileAppender : IAppender
    {
        //Todo Add layout
        public FileAppender(ILayout layout, ILogFile logFile, ReportLevel reportLevel = ReportLevel.Info)
        {
            ReportLevel = reportLevel;
            Layout = layout;
            LogFile = logFile;
        }
        public ILogFile LogFile { get; private set; }
        public ILayout Layout { get; private set; }
        public ReportLevel ReportLevel { get; set; }

        public int MessagesAppended { get; private set; }



        public void Append(Message message)
        {
            string content = (string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text) + Environment.NewLine);
            File.AppendAllText(LogFile.FullPath, content);
            MessagesAppended++;
        }
    }
}
