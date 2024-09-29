using UnityEngine;

namespace BWM.Model
{
    /// <summary>
    /// Логика для включения / выключения фар
    /// </summary>
    public class Fari : MonoBehaviour
    {
        [Tooltip("ГО с фарами")]
        [SerializeField] private GameObject _fari;

        /// <summary>
        /// Включение / выключение фар (по кнопке)
        /// </summary>
        public void __ClickChangeFariState() =>        
            _fari.SetActive(!_fari.activeInHierarchy);
        
    }
}
