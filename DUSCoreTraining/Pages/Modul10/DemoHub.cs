using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUSCoreTraining.Pages.Modul10
{
    public class DemoHub:Hub
    {
       
        public void Send(string message)
        {
            Clients.All.SendAsync("clientListener", message.ToLower());
        }

    }
}
