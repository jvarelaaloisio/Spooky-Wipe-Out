using System;
using UnityEngine;

namespace VacuumCleaner.Modes
{
    public class Vacuum : MonoBehaviour, ITool
    {
        public event Action OnPowerOn;
        public event Action OnPowerOff;
        
        [SerializeField] private VacuumColision vacuumColision;
        [SerializeField] private TrashCollector trashCollector;
        
        public void PowerOn()
        {
            vacuumColision.gameObject.SetActive(true);
            trashCollector.gameObject.SetActive(true);
            OnPowerOn?.Invoke();
        }

        public void PowerOff()
        {
            vacuumColision.gameObject.SetActive(false);
            trashCollector.gameObject.SetActive(false);
            OnPowerOff?.Invoke();
        }
    }
}