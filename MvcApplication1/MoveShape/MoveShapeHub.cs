using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MvcApplication1.MoveShape
{
    [HubName("moveShapeHub")]
    public class MoveShapeHub : Hub
    {
        public void MoveShape(int x, int y)
        {
            Clients.Others.shapeMoved(x, y);
        }

        public void MoveShape2(int x, int y)
        {
            Clients.Others.shapeMoved2(x, y);
        }
    }
}