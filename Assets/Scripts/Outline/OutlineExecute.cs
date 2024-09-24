using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Model.InputModel;

namespace Model.OutlineEffect
{
    /// <summary>
    /// Действия с Outline
    /// </summary>
    public class OutlineExecute : MonoBehaviour
    {

        private Outline _outline;
        private MouseOver _mouseOver;

        private void Awake()
        {
            _outline = GetComponent<Outline>();
            _mouseOver = GetComponent<MouseOver>();
        }

        private void OnEnable()
        {
            if (_mouseOver)
                _mouseOver.mouseOverEvent += OutlineEnable;

            if (_mouseOver)
                _mouseOver.mouseExitEvent += OutlieDisable;
        }

        private void OnDisable()
        {
            if (_mouseOver)
                _mouseOver.mouseOverEvent -= OutlineEnable;

            if (_mouseOver)
                _mouseOver.mouseExitEvent -= OutlieDisable;
        }

        /// <summary>
        /// Включение Outline
        /// </summary>
        private void OutlineEnable()
        {
            if (_outline)
                _outline.enabled = true;
        }

        /// <summary>
        /// Выключение Outline
        /// </summary>
        private void OutlieDisable()
        {
            if (_outline)
                _outline.enabled = false;
        }
    }
}
