using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pudding
{

    public class SocketEvent : IDisposable
    {
        public delegate void OnActionHandler(byte[] userData);

        public Dictionary<ushort, LinkedList<OnActionHandler>> dic = new();

        /// <summary>
        /// 添加监听
        /// </summary>
        /// <param name="key"></param>
        /// <param name="handler"></param>
        public void AddListener(ushort key,OnActionHandler handler)
        {
            LinkedList<OnActionHandler> lstHandler = null;
            dic.TryGetValue(key, out lstHandler);
            if (lstHandler == null)
            {
                lstHandler = new LinkedList<OnActionHandler>();
                dic[key] = lstHandler;
            }
            lstHandler.AddLast(handler);
        }


        public void RemoveListener(ushort key,OnActionHandler handler)
        {
            LinkedList<OnActionHandler> lstHandler = null;
            dic.TryGetValue(key, out lstHandler);
            if (lstHandler != null)
            {
                lstHandler.Remove(handler);
                if (lstHandler.Count == 0)
                {
                    dic.Remove(key);
                }
            }
        }

        /// <summary>
        /// 派发
        /// </summary>
        /// <param name="key"></param>
        /// <param name="userData"></param>
        public void Dispatch(ushort key , byte[] buffer)
        {
            LinkedList<OnActionHandler> lstHandler = null;
            dic.TryGetValue(key, out lstHandler);
            if (lstHandler == null)
            {
                for (LinkedListNode<OnActionHandler> curr = lstHandler.First; curr != null;)
                {
                    LinkedListNode<OnActionHandler> next = curr.Next;
                    curr.Value?.Invoke(buffer);
                    curr = next;
                }
            }
        }
        
        public void Dispatch(ushort key)
        {
            Dispatch(key, null);
        }

        public void Dispose()
        {
            dic.Clear();
        }
    }
}