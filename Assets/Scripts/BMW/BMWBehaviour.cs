using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BWM.Model
{
    /// <summary>
    /// Behaviour с компонентами
    /// </summary>
    public class BMWBehaviour : MonoBehaviour
    {
        private Animator _animator = null; // Аниматор

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }
    }
}
