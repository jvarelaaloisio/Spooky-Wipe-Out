using System;
using UnityEngine;

namespace VacuumCleaner.Modes
{
    public class Idle : MonoBehaviour, ITool
    {
        public event Action OnPowerOn;
        public event Action OnPowerOff;

        public void PowerOn()
        {
            OnPowerOn?.Invoke();
        }

        public void PowerOff()
        {
            OnPowerOff?.Invoke();
        }
    }
}