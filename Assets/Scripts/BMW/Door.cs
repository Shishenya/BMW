using UnityEngine;
using Project.Enums;
using DG.Tweening;
using Model.InputModel;
using Model.Useable;

namespace BWM.Model
{
    /// <summary>
    /// ����� � ������
    /// </summary>
    public class Door : MonoBehaviour, IUseableRotation
    {
        private OpenCloseElement _isCurrentState = OpenCloseElement.Close; // ������� ��������� �����

        [Tooltip("������� � �������� ����")]
        [SerializeField] private Vector3 _rotationCloseAngle;

        [Tooltip("������� � �������� ����")]
        [SerializeField] private Vector3 _rotationOpenAngle;

        private MouseInput _mouseInput= null;
        private readonly float _durationAnimation = 1f;
        private MeshCollider _collider = null;

        private void Awake()
        {
            _mouseInput = GetComponent<MouseInput>();
            _collider = GetComponent<MeshCollider>();
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
        /// ������ �������������
        /// </summary>
        public void Use()
        {
            UseRotation();
        }

        /// <summary>
        /// ���������� ������
        /// </summary>
        public void UseRotation()
        {
            if (_isCurrentState == OpenCloseElement.Close)
                ExecuteOpenRotation();
            else if (_isCurrentState == OpenCloseElement.Open)
                ExecuteCloseRotation();
        }

        /// <summary>
        /// �������� �������� �����
        /// </summary>
        private async void ExecuteOpenRotation()
        {
            _collider.enabled = false;
            Tween tween = transform.DOLocalRotate(_rotationOpenAngle, _durationAnimation);
            await tween.AsyncWaitForCompletion();
            _isCurrentState = OpenCloseElement.Open;
            _collider.enabled = true;
        }

        /// <summary>
        /// ������� �������� �����
        /// </summary>
        private async void ExecuteCloseRotation()
        {
            _collider.enabled = false;
            Tween tween = transform.DOLocalRotate(_rotationCloseAngle, _durationAnimation);
            await tween.AsyncWaitForCompletion();
            _isCurrentState = OpenCloseElement.Close;
            _collider.enabled = true;
        }
    }
}
