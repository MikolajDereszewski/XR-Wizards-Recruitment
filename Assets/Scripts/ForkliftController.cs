using UnityEngine;

namespace Forklift.Player
{
    using Forklift.Physics;

    public class ForkliftController : MonoBehaviour
    {
        [SerializeField]
        private ForkliftEngine _engine;

        private InputMaster _controls;

        private void OnEnable()
        {
            if( _engine == null )
            {
                Debug.LogError("Attach Engine property and re-enable controller!");
                enabled = false;
                return;
            }
            _controls = new InputMaster();
            _controls.Enable();
        }

        private void Update()
        {
            if(_controls.Forklift.Accelerate.ReadValue<float>() > 0f)
            {
                _engine.Accelerate();
            }
            else if(_controls.Forklift.Decelerate.ReadValue<float>() > 0f)
            {
                _engine.Decelerate();
            }

            if (_controls.Forklift.TurnLeft.ReadValue<float>() > 0f)
            {
                _engine.Turn(TurnDirection.Left);
            }
            else if (_controls.Forklift.TurnRight.ReadValue<float>() > 0f)
            {
                _engine.Turn(TurnDirection.Right);
            }
            else
            {
                _engine.Turn(TurnDirection.None);
            }
        }

        private void OnDisable()
        {
            if (_controls != null)
            {
                _controls.Disable();
            }
        }
    }
}