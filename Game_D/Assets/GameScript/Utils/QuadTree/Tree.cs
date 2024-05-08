using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Pudding
{
    // public class Tree : INode
    // {
    //     public Bounds bound { get; set; } //包围盒
    //     private Node root;
    //     public int maxDepth { get; set; } //最大深度
    //     public int maxChildCount { get; set; } //最大叶子数
    //
    //     public Tree(Bounds bound) //构造函数 构造树
    //     {
    //         this.bound = bound;
    //         this.maxDepth = 5;
    //         this.maxChildCount = 4;
    //         root = new Node(bound, 0, this);
    //     }
    //
    //     public void InsertObj(ObjData obj)
    //     {
    //         root.InsertObj(obj);
    //     }
    //
    //     public void TriggerMove(Camera camera)
    //     {
    //         root.TriggerMove(camera);
    //     }
    //
    //     public void DrawBound()
    //     {
    //         root.DrawBound();
    //     }
    // }
}