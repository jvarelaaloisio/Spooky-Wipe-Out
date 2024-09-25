using UnityEngine;

namespace VacuumCleaner.Modes
{
    [CreateAssetMenu(fileName = "VacuumModel", menuName = "Cleaner/Tools/VacuumModel")]
    public class VacuumModel : ScriptableObject
    {
        [SerializeField] private float speed;
        [SerializeField] private float maxAngle = 45.0f;
        [SerializeField] private float renderDistance = 5.0f;
        [SerializeField] private LayerMask wallLayer;

        public float Speed
        {
            get => speed;
            set => speed = value;
        }

        public float MaxAngle
        {
            get => maxAngle;
            set => maxAngle = value;
        }

        public float RenderDistance
        {
            get => renderDistance;
            set => renderDistance = value;
        }

        public LayerMask WallLayer
        {
            get => wallLayer;
            set => wallLayer = value;
        }
    }
}