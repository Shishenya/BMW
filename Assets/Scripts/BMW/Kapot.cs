using Model.InputModel;
using Model.Useable;
using Project.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BWM.Model
{
    /// <summary>
    /// Капот в моделе
    /// </summary>
    public class Kapot : MonoBehaviour, IUseableAnimation
    {

        [Tooltip("Аниматор")]
        [SerializeField] private Animator _animator = null;

        [Tooltip("Параметр для анимации")]
        [SerializeField] private string _boolParameter = "";

        private MouseInput _mouseInput = null;
        private OpenCloseElement _isCurrentState = OpenCloseElement.Close; // текущее состояние капота

        private void Awake()
        {
            _mouseInput = GetComponent<MouseInput>();
        }

        private void OnEnable()
        {
            if (_mouseInput)
                _mouseInput.MouseClickEvent += Use;
        }

        private void OnDisable()
        {
            if (_mouseInput)
                _mouseInput.MouseClickEvent -= Use;
        }

        /// <summary>
        /// Использование
        /// </summary>
        public void Use()
        {
            UseAnimation();
        }

        /// <summary>
        /// Анимационная логики использования
        /// </summary>
        public void UseAnimation()
        {
            if (_isCurrentState == OpenCloseElement.Close)
                OpenKapot();
            else if (_isCurrentState == OpenCloseElement.Open)
                CloseKapot();
        }

        /// <summary>
        /// Открытие капота
        /// </summary>
        private void OpenKapot()
        {
            _animator.SetBool(_boolParameter, true);
            _isCurrentState = OpenCloseElement.Open;
        }

        /// <summary>
        /// Закрытие капота
        /// </summary>
        private void CloseKapot()
        {
            _animator.SetBool(_boolParameter, false);
            _isCurrentState = OpenCloseElement.Close;
        }

    }
}
