using UnityEngine;

namespace CameraProject
{
    /// <summary>
    /// ������� ������ �������
    /// </summary>
    public class RotateAroundObject : MonoBehaviour
    {

        [Tooltip("������ ���� �������� ������")]
        [SerializeField] private Transform _target;
        [Tooltip("�������� �������")]
        [SerializeField] private float _rotationSpeed = 5f;

        [Tooltip("������� �� ��� X (������������ �������)")]
        [SerializeField] private float _xMin = 0f;

        [Tooltip("�������� �� ��� Y (������������ �������)")]
        [SerializeField] private float _xMax = 50f;


        private float _currentXRotation;
        private readonly int _buttonRotation = 1;

        private void Start()
        {
            _currentXRotation = transform.eulerAngles.x;
        }

        private void Update()
        {
            if (Input.GetMouseButton(_buttonRotation))
            {
                // �������� �������� ����
                float horizontalMovement = Input.GetAxis("Mouse X");
                float verticalMovement = Input.GetAxis("Mouse Y");

                float horizontalRotationAmount = horizontalMovement * _rotationSpeed;
                float verticalRotationAmount = verticalMovement * _rotationSpeed;

                transform.RotateAround(_target.position, Vector3.up, horizontalRotationAmount);


                //transform.RotateAround(_target.position, transform.right, -verticalRotationAmount);

                // ��������� ������� ���� �� ��� X
                _currentXRotation -= verticalRotationAmount;

                // ������������ ���� �� ��� X
                _currentXRotation = Mathf.Clamp(_currentXRotation, _xMin, _xMax);

                // ��������� ����� ���� �� ��� X
                Vector3 eulerAngles = transform.eulerAngles;
                eulerAngles.x = _currentXRotation;
                transform.eulerAngles = eulerAngles;
            }
        }
    }
}
