using UnityEngine;

namespace CameraProject
{
    /// <summary>
    /// Ротация вокруг объекта
    /// </summary>
    public class RotateAroundObject : MonoBehaviour
    {

        [Tooltip("Вокруг чего ротируем камеру")]
        [SerializeField] private Transform _target;
        [Tooltip("Скорость ротации")]
        [SerializeField] private float _rotationSpeed = 5f;

        [Tooltip("Минимум по оси X (вертикальная ротация)")]
        [SerializeField] private float _xMin = 0f;

        [Tooltip("Максимум по оси Y (вертикальная ротация)")]
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
                // Получаем движения мыши
                float horizontalMovement = Input.GetAxis("Mouse X");
                float verticalMovement = Input.GetAxis("Mouse Y");

                float horizontalRotationAmount = horizontalMovement * _rotationSpeed;
                float verticalRotationAmount = verticalMovement * _rotationSpeed;

                transform.RotateAround(_target.position, Vector3.up, horizontalRotationAmount);


                //transform.RotateAround(_target.position, transform.right, -verticalRotationAmount);

                // Обновляем текущий угол по оси X
                _currentXRotation -= verticalRotationAmount;

                // Ограничиваем угол по оси X
                _currentXRotation = Mathf.Clamp(_currentXRotation, _xMin, _xMax);

                // Применяем новый угол по оси X
                Vector3 eulerAngles = transform.eulerAngles;
                eulerAngles.x = _currentXRotation;
                transform.eulerAngles = eulerAngles;
            }
        }
    }
}
