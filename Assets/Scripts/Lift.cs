using UnityEngine;

namespace Forklift.Physics
{
    public class Lift : MonoBehaviour
    {
        [Header("References")]
        [SerializeField]
        private Collider _liftCollider;
        [SerializeField]
        private PhysicMaterial _slipperyMaterial, _frictionMaterial;

        [Header("Properties")]
        [SerializeField]
        private Vector3 _localLowerPoint;
        [SerializeField]
        private Vector3 _localHigherPoint;
        [SerializeField]
        private float _raiseSpeed;

        private LiftState _liftState;
        private float _raiseState = 0f;

        private void UpdateLiftPosition() => _liftCollider.transform.localPosition = Vector3.Lerp(_localLowerPoint, _localHigherPoint, _raiseState);

        private void UpdateLiftState(LiftState state)
        {
            _liftState = state;
            _liftCollider.material = _liftState == LiftState.Lowered ? _slipperyMaterial : _frictionMaterial;
        }
        
        public void Raise()
        {
            _raiseState = Mathf.Clamp01(_raiseState + _raiseSpeed * Time.deltaTime);
            if(_liftState == LiftState.Lowered && _raiseState > 0f)
            {
                UpdateLiftState(LiftState.Raised);
            }
            UpdateLiftPosition();
        }

        public void Lower()
        {
            _raiseState = Mathf.Clamp01(_raiseState - _raiseSpeed * Time.deltaTime);
            if (_liftState == LiftState.Raised && _raiseState == 0f)
            {
                UpdateLiftState(LiftState.Lowered);
            }
            UpdateLiftPosition();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Vector3 transformedLower = transform.position + transform.localToWorldMatrix.MultiplyVector(_localLowerPoint);
            Vector3 transformedHigher = transform.position + transform.localToWorldMatrix.MultiplyVector(_localHigherPoint);
            Gizmos.DrawSphere(transformedLower, 0.05f);
            Gizmos.DrawSphere(transformedHigher, 0.05f);
            Gizmos.DrawLine(transformedLower, transformedHigher);
            if(_liftCollider != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawSphere(_liftCollider.transform.position, 0.1f);
            }
        }

        private enum LiftState
        {
            Lowered,
            Raised
        }
    }
}