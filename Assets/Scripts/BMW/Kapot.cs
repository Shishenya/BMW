using Model.InputModel;
using Model.Useable;
using Project.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BWM.Model
{
    /// <summary>
    /// ����� � ������
    /// </summary>
    public class Kapot : MonoBehaviour, IUseableAnimation
    {

        [Tooltip("��������")]
        [SerializeField] private Animator _animator = null;

        [Tooltip("�������� ��� ��������")]
        [SerializeField] private string _boolParameter = "";

        private MouseInput _mouseInput = null;
        private OpenCloseElement _isCurrentState = OpenCloseElement.Close; // ������� ��������� ������

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
        /// �������������
        /// </summary>
        public void Use()
        {
            UseAnimation();
        }

        /// <summary>
        /// ������������ ������ �������������
        /// </summary>
        public void UseAnimation()
        {
            if (_isCurrentState == OpenCloseElement.Close)
                OpenKapot();
            else if (_isCurrentState == OpenCloseElement.Open)
                CloseKapot();
        }

        /// <summary>
        /// �������� ������
        /// </summary>
        private void OpenKapot()
        {
            _animator.SetBool(_boolParameter, true);
            _isCurrentState = OpenCloseElement.Open;
        }

        /// <summary>
        /// �������� ������
        /// </summary>
        private void CloseKapot()
        {
            _animator.SetBool(_boolParameter, false);
            _isCurrentState = OpenCloseElement.Close;
        }

    }
}
