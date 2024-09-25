using UnityEngine;
using System;

namespace Model.InputModel
{
    /// <summary>
    /// ќбработка кликов мышки
    /// </summary>
    public class MouseInput : MonoBehaviour
    {

        public event Action MouseClickEvent; // Ёвент клика мышки
        public void OnMouseDown()
        {
            MouseClickEvent?.Invoke();
        }
    }
}
