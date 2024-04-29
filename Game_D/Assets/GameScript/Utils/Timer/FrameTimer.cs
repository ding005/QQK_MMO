using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pudding
{

    public abstract class FrameTimer
    {
        public Action<string> ErrorLog;

        public abstract int AddTask(uint delay, Action<int> taskCallBack, Action<int> CancelCallBack, int count);


        public abstract bool DeleteTask(int taskId);

        public abstract void Rest();

        protected int tId;

        protected abstract int generateTid();

    }
}