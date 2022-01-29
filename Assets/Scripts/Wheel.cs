using UnityEngine;

namespace Forklift.Physics
{
    [RequireComponent(typeof(Rigidbody))]
    public class Wheel : MonoBehaviour
    {
        [field: SerializeField]
        public WheelPosition WheelPosition { get; private set; }

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void ApplyTorque(float force)
        {
            _rigidbody.AddTorque(transform.right * force, ForceMode.Force);
        }
    }

    public enum WheelPosition
    {
        Front,
        Rear
    }
}