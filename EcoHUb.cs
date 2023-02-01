using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace facebookClone
{
    [HubName("Echo")]
    public class EcoHUb : Hub
    {      
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}