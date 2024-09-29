using UnityEngine;

namespace BWM.Model
{
    /// <summary>
    /// ������ ��� ��������� / ���������� ���
    /// </summary>
    public class Fari : MonoBehaviour
    {
        [Tooltip("�� � ������")]
        [SerializeField] private GameObject _fari;

        /// <summary>
        /// ��������� / ���������� ��� (�� ������)
        /// </summary>
        public void __ClickChangeFariState() =>        
            _fari.SetActive(!_fari.activeInHierarchy);
        
    }
}
