using UnityEngine;

namespace UI.WaterMark
{
    /// <summary>
    /// ������� � �������� WaterMark
    /// </summary>
    public class WaterMark : MonoBehaviour
    {
        [Tooltip("������ � WaterMark")]
        [SerializeField] private GameObject _waterMarkPanel;

        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.LeftControl))
            {
                if (Input.GetKeyDown(KeyCode.D))                
                    _waterMarkPanel.SetActive(!_waterMarkPanel.activeInHierarchy);                
            }
        }
    }
}
