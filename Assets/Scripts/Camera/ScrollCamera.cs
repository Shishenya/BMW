using UnityEngine;

namespace CameraProject
{
    public class ScrollCamera : MonoBehaviour
    {
        [Tooltip("�������� ��������� FOV")]
        [SerializeField] private float _fovChangeSpeed = 5f;
        [Tooltip("����������� �������� FOV")]
        [SerializeField] private float _minFOV = 15f;
        [Tooltip("������������ �������� FOV")]
        [SerializeField] private float _maxFOV = 90f;

        private Camera _camera;

        private void Start()
        {
            _camera = GetComponent<Camera>();
            // ��������, ��� FOV ��������� � �������� ������������ � ������������� ��������
            _camera.fieldOfView = Mathf.Clamp(_camera.fieldOfView, _minFOV, _maxFOV);
        }

        private void Update()
        {
            // �������� �������� ��������� ����
            float scrollInput = Input.GetAxis("Mouse ScrollWheel");

            // �������� FOV � ����������� �� ���������
            if (scrollInput != 0)
            {
                float newFOV = _camera.fieldOfView - scrollInput * _fovChangeSpeed;
                _camera.fieldOfView = Mathf.Clamp(newFOV, _minFOV, _maxFOV);
            }
        }
    }
}
