using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    /// <summary>
    /// 相机上下移动
    /// </summary>
    [SerializeField]
    private Transform m_CameraUpAndDown;
    [SerializeField]
    private Transform m_CameraZoomContainer;
    [SerializeField]
    private Transform m_CameraContainer;

    /// <summary>
    /// 相机左右旋转速度
    /// </summary>
    [SerializeField] private int m_RotateSpeed = 80;
    
    
}
