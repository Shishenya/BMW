using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CMFreelookOnlyWhenRightMouseDown : MonoBehaviour
{
    void Start()
    {
        CinemachineCore.GetInputAxis = GetAxisCustom;
    }
    public float GetAxisCustom(string axisName)
    {
        if (axisName == "Mouse X")
        {
            if (Input.GetMouseButton(2))
            {
                Cursor.visible = false;
                return UnityEngine.Input.GetAxis("Mouse X");
            }
            else
            {
                Cursor.visible = true;
                return 0;
            }
        }
        else if (axisName == "Mouse Y")
        {
            if (Input.GetMouseButton(2))
            {
                Cursor.visible = false;
                return UnityEngine.Input.GetAxis("Mouse Y");

            }
            else
            {
                Cursor.visible = true;
                return 0;
            }
        }
        return 0;
    }
}