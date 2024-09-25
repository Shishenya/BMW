using UnityEngine;

namespace CameraProject
{
    public class ScrollCamera : MonoBehaviour
    {
        [Tooltip("Скорость изменения FOV")]
        [SerializeField] private float _fovChangeSpeed = 5f;
        [Tooltip("Минимальное значение FOV")]
        [SerializeField] private float _minFOV = 15f;
        [Tooltip("Максимальное значение FOV")]
        [SerializeField] private float _maxFOV = 90f;

        private Camera _camera;

        private void Start()
        {
            _camera = GetComponent<Camera>();
            // Убедимся, что FOV находится в пределах минимального и максимального значений
            _camera.fieldOfView = Mathf.Clamp(_camera.fieldOfView, _minFOV, _maxFOV);
        }

        private void Update()
        {
            // Получаем значение прокрутки мыши
            float scrollInput = Input.GetAxis("Mouse ScrollWheel");

            // Изменяем FOV в зависимости от прокрутки
            if (scrollInput != 0)
            {
                float newFOV = _camera.fieldOfView - scrollInput * _fovChangeSpeed;
                _camera.fieldOfView = Mathf.Clamp(newFOV, _minFOV, _maxFOV);
            }
        }
    }
}
