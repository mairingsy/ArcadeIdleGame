using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Runtime.Signals;

namespace MyNamespace
{
    public class StartButtonController : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        private void Awake()
        {
            _startButton.onClick.AddListener(OnStart);
        }

        private void OnStart()
        {
            CoreUISignals.Instance.onCloseAllPanel();
            Instantiate(Resources.Load<GameObject>("Prefabs/Game"));
        }
    }
}

