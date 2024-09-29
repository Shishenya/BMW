using UnityEngine;
using Project.Enums;

namespace Project.Car
{
    /// <summary>
    /// ��������� ��� ������
    /// </summary>
    [System.Serializable]
    public class CarSceneOptions
    {
        [Tooltip("��� ����� ������ ���������")]
        public Cars _car;

        [Tooltip("������ ������")]
        public GameObject _model;

        [Tooltip("�������, ����� ������ ���������� �������")]
        public Vector3 _visiblePosition;

        [Tooltip("�� ������")]
        public GameObject _canvas;

    }
}
