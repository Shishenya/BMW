using UnityEngine;

namespace UI.WaterMark
{
    /// <summary>
    /// Убирает и включает WaterMark
    /// </summary>
    public class WaterMark : MonoBehaviour
    {
        [Tooltip("Панель с WaterMark")]
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
