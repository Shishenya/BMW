using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BWM.Model
{
    /// <summary>
    /// Behaviour � ������������
    /// </summary>
    public class BMWBehaviour : MonoBehaviour
    {
        private Animator _animator = null; // ��������

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }
    }
}
