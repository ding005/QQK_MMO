using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pudding
{
    public interface ILogic
    {
        public void Init();
        public void Tick();
        public void UnInit();
    }
}