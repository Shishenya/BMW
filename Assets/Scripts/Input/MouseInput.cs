using UnityEngine;
using System;

namespace Model.InputModel
{
    /// <summary>
    /// ��������� ������ �����
    /// </summary>
    public class MouseInput : MonoBehaviour
    {

        public event Action MouseClickEvent; // ����� ����� �����
        public void OnMouseDown()
        {
            MouseClickEvent?.Invoke();
        }
    }
}
