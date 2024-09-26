using UnityEngine;
using Vector2 = System.Numerics.Vector2;

namespace Fsm_Mk2
{
    public class WalkIdle : State
    {
        private GameObject _gameObject;
        private WalkIdleModel _model;
        private LayerMask _layerRaycast;

        private Vector3 _dir = Vector3.zero;
        private bool _isClickPressed;

        
        private Vector3 _counterMovement;

        public WalkIdle(GameObject gameObject, WalkIdleModel model, LayerMask layerRaycast)
        {
            _gameObject = gameObject;
            _model = model;
            _layerRaycast = layerRaycast;
        }
        public override void Enter()
        {
        }

        public override void Tick(float delta)
        {
        }

        public override void FixedTick(float delta)
        {
            Move();
        }

        public override void Exit()
        {
        }

        private void Move()
        {
            _counterMovement = new Vector3(-_gameObject.GetComponent<Rigidbody>().velocity.x * _model.CounterMovementForce, 0,
                -_gameObject.GetComponent<Rigidbody>().velocity.z * _model.CounterMovementForce);

            _gameObject.GetComponent<Rigidbody>().AddForce(_dir.normalized * _model.MovementForce + _counterMovement);

            float angle = Vector3.SignedAngle(_gameObject.transform.forward, _dir, _gameObject.transform.up);

            if (!_isClickPressed)
            {
                _gameObject.transform.Rotate(_gameObject.transform.up, angle * Time.deltaTime * _model.RotationSpeed);
            }
            else
            {
                ChangeRotation();
            }
        }

        private void ChangeRotation()
        {
            if (!Camera.main) return;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layerRaycast))
            {
                Vector3 targetPosition = new Vector3(hit.point.x, _gameObject.transform.position.y, hit.point.z);

                Vector3 direction = targetPosition - _gameObject.transform.position;
                Quaternion actualRotation = _gameObject.transform.rotation;
                float rotationAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                Quaternion targetRotation = Quaternion.Euler(0f, rotationAngle, 0f);

                _gameObject.transform.rotation = targetRotation;
            }
        }

        public void SetDir(Vector3 newDir, bool shouldRot)
        {
            _dir = newDir;

            _isClickPressed = shouldRot;
        }
    }
}