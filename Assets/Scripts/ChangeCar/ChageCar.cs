using System.Collections.Generic;
using UnityEngine;
using Project.Enums;
using Project.Car;

namespace Project.ChangeCars
{
    public class ChageCar : MonoBehaviour
    {
        private Cars _currentCar = Cars.BWM; // текущая машина

        [Header("Настройки точек для машин")]
        [Tooltip("Куда переносить машину, чтобы ее не видеть")]
        [SerializeField] private Transform _noVisibleTransform;

        [Tooltip("Настройки для машин")]
        [SerializeField] private List<CarSceneOptions> _carsOptions = new List<CarSceneOptions>();

        Dictionary<Cars, CarSceneOptions> _carsDitionary = new Dictionary<Cars, CarSceneOptions>();

        private void Awake()
        {
            CreateDictionary();
        }

        /// <summary>
        /// Создание словаря
        /// </summary>
        private void CreateDictionary()
        {
            foreach (var item in _carsOptions)            
                _carsDitionary.Add(item._car, item);            
        }

        /// <summary>
        /// Смена машины для кнопки
        /// </summary>
        public void __ChangeCar(int id)
        {
            Cars newCar = (Cars)id;
            ChangeCar(newCar);
        }

        /// <summary>
        /// Показываем машину
        /// </summary>
        private void ChangeCar(Cars newCar)
        {
            foreach (var item in _carsOptions)
            {
                if (newCar == item._car)
                    VisibleCar(item);
                else
                    UnVisibleCar(item);
            }
        }

        /// <summary>
        /// Показать машину
        /// </summary>
        private void VisibleCar(CarSceneOptions option)
        {
            option._canvas.SetActive(true);
            option._model.transform.position = option._visiblePosition;
            _currentCar = option._car;
        }

        /// <summary>
        /// Убрать машину машину
        /// </summary>
        private void UnVisibleCar(CarSceneOptions option)
        {
            option._canvas.SetActive(false);
            option._model.transform.position = _noVisibleTransform.position;
        }
    }
}
