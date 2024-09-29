using UnityEngine;
using Project.Enums;

namespace Project.Car
{
    /// <summary>
    /// Настройки для машины
    /// </summary>
    [System.Serializable]
    public class CarSceneOptions
    {
        [Tooltip("Для какой машины настройки")]
        public Cars _car;

        [Tooltip("Модель машины")]
        public GameObject _model;

        [Tooltip("Позиция, когда машина становится видимой")]
        public Vector3 _visiblePosition;

        [Tooltip("Ее канвас")]
        public GameObject _canvas;

    }
}
