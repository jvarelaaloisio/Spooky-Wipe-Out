using UnityEngine;

namespace VacuumCleaner.Modes
{
    public class VacuumColision : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private VacuumModel _model;
        
        private Ray _ray;
        private void OnTriggerStay(Collider other)
        {
            if (IsVacuumable(other))
            {
                if (CanVacuum(other))
                {
                    other.GetComponent<IVacuumable>().IsBeingVacuumed(target.position, _model.Speed);
                }
            }
        }
    
        private static bool IsVacuumable(Collider other)
        {
            IVacuumable vacuumable = other.GetComponent<IVacuumable>();

            return vacuumable != null;
        }
        
        private bool CanVacuum(Collider other)
        {
            var angleToObject = Vector3.Angle(target.forward, other.transform.position - target.position);

            if (!(angleToObject <= _model.MaxAngle)) return false;

            _ray = new Ray(target.position, other.transform.position - target.position);

            if (Physics.Raycast(_ray, out var hit, _model.RenderDistance, _model.WallLayer))
            {
                return false;
            }
                
            return true;
        }
    }
}
