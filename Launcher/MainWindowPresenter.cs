using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Launcher_FTP;

namespace Launcher
{
    
    class MainWindowPresenter
    {
        private readonly IMessageService _service;
        private readonly IAuthWindow aw;
        private readonly IRegWindow rw; 
        private readonly IMainWindow mw;
        private readonly IFtpClient ftpClient;

        public MainWindowPresenter(IMainWindow mainWindow,IMessageService service)
        {
            mw = mainWindow;

            mw.Dota2lsButtonClick += Mw_Dota2lsButtonClick;
            mw.AgeBotButtonClick += Mw_AgeBotButtonClick;
            mw.PerfectBotButtonClick += Mw_PerfectBotButtonClick;

            ftpClient.UserName = "u662536153";
            ftpClient.Password = "Hi73s6dL";
            ftpClient.Host = "ftp.aabot.zyro.com";
        }

        private void Mw_PerfectBotButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Mw_AgeBotButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Mw_Dota2lsButtonClick(object sender, EventArgs e)
        {
            //ftpClient.DownloadFile("", "");
        }
    }
}
