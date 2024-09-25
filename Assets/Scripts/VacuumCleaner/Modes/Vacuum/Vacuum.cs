using System;
using UnityEngine;

namespace VacuumCleaner.Modes
{
    public class Vacuum : MonoBehaviour, ITool
    {
        public event Action OnPowerOn;
        public event Action OnPowerOff;
        
        [SerializeField] private VacuumColision vacuumColision;
        
        public void PowerOn()
        {
            vacuumColision.gameObject.SetActive(true);
            OnPowerOn?.Invoke();
        }

        public void PowerOff()
        {
            vacuumColision.gameObject.SetActive(false);
            OnPowerOff?.Invoke();
        }
    }
}