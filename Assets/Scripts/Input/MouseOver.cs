using System;
using UnityEngine;

namespace Model.InputModel
{
    /// <summary>
    /// Отвечает за наведение мышки и ее отведение
    /// </summary>
    public class MouseOver : MonoBehaviour
    {

        public event Action mouseOverEvent;
        public event Action mouseExitEvent;

        private void OnMouseOver()
        {
            mouseOverEvent?.Invoke();
        }

        private void OnMouseExit()
        {
            mouseExitEvent?.Invoke();
        }
    }
}
