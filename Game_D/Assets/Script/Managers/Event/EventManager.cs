using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pudding
{
    public class EventManager : ManagerBase,IDisposable
    {

        public override void Init()
        {
            
        }
        public CommonEvent CommonEvent { private set; get; }
        public SocketEvent SocketEvent { private set; get; }
        public EventManager()
        {
            CommonEvent = new CommonEvent();
            SocketEvent = new SocketEvent();
        }

        public void Dispose()
        {
            CommonEvent.Dispose();
            SocketEvent.Dispose();
        }

    }
}