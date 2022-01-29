using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Forklift.Physics
{
    public class ForkliftEngine : MonoBehaviour
    {
        [Header("References")]
        [SerializeField]
        private Wheel[] _wheels = new Wheel[4];
        [SerializeField]
        private Rigidbody _frontAxisRigidbody;
        [SerializeField]
        private HingeJoint _frontAxisJoint;

        [Header("Engine Properties")]
        [SerializeField]
        private float _enginePower;
        [SerializeField]
        private float _brakePower;
        [SerializeField]
        private float _maxForwardVelocity, _maxBackwardVelocity;
        [SerializeField]
        private float _acceleration, _backwardAcceleration, _staticDeceleration;

        private Dictionary<TurnDirection, float> _targetTurnAngles;
        public float _currentVelocity, _currentTurnAngle; //public for testing

        private void Awake()
        {
            _targetTurnAngles = new Dictionary<TurnDirection, float>
            {
                {TurnDirection.None, 0f},
                {TurnDirection.Left, _frontAxisJoint.limits.min},
                {TurnDirection.Right, _frontAxisJoint.limits.max}
            };
        }

        private void LateUpdate()
        {
            if (_currentVelocity > 0f)
            {
                _currentVelocity = Mathf.Clamp(_currentVelocity - _staticDeceleration * Time.deltaTime, 0f, _maxForwardVelocity);
            }
            if (_currentVelocity < 0f)
            {
                _currentVelocity = Mathf.Clamp(_currentVelocity + _staticDeceleration * Time.deltaTime, -_maxBackwardVelocity, 0f);
            }
        }

        private void FixedUpdate()
        {
            float force = _currentVelocity * _enginePower;
            for (int i = 0; i < (_wheels?.Length ?? 0); i++)
            {
                _wheels[i]?.ApplyTorque(force);
            }
            Vector3 targetFrontAxisRotation = Quaternion.Euler(0f, _currentTurnAngle, 0f) * _frontAxisRigidbody.transform.forward;
            _frontAxisRigidbody.MoveRotation(Quaternion.LookRotation(targetFrontAxisRotation, _frontAxisRigidbody.transform.up));
        }

        public void Accelerate()
        {
            if(_currentVelocity < 0f)
            {
                _currentVelocity = Mathf.Clamp(_currentVelocity + _brakePower * Time.deltaTime, _currentVelocity, 0f);
            }
            _currentVelocity = Mathf.Clamp(_currentVelocity + _acceleration * Time.deltaTime, 0f, _maxForwardVelocity);
        }

        public void Decelerate()
        {
            if (_currentVelocity > 0f)
            {
                _currentVelocity = Mathf.Clamp(_currentVelocity - _brakePower * Time.deltaTime, -_maxBackwardVelocity, 0f);
            }
            _currentVelocity = Mathf.Clamp(_currentVelocity - _backwardAcceleration * Time.deltaTime, -_maxBackwardVelocity, 0f);
        }

        public void Turn(TurnDirection direction)
        {
            _currentTurnAngle = Mathf.Lerp(_currentTurnAngle, _targetTurnAngles[direction], Time.deltaTime);
        }
    }

    public enum TurnDirection
    {
        None,
        Right,
        Left
    }
}