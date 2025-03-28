using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runtime.Signals;

namespace Runtime.Managers
{
    public class UIManager : MonoBehaviour
    {
        private void Start()
        {
            Application.targetFrameRate = 60;
            OnLevelInitialize();
        }

        private void OnLevelInitialize()
        {
            CoreUISignals.Instance.onOpenPanel?.Invoke(Enums.UIPanelTypes.Start, 0);
        }
    }
}