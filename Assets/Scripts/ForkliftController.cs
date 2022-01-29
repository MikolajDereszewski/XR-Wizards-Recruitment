using UnityEngine;

namespace Forklift.Player
{
    using Forklift.Physics;

    public class ForkliftController : MonoBehaviour
    {
        [SerializeField]
        private ForkliftEngine _engine;
        [SerializeField]
        private Lift _lift;

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

        private void OnDisable()
        {
            if (_controls != null)
            {
                _controls.Disable();
                _controls.Dispose();
            }
        }

        private void Update()
        {
            ManageAcceleration();
            ManageTurning();
            ManageLift();
        }

        private void ManageAcceleration()
        {
            if (_controls.Forklift.Accelerate.ReadValue<float>() > 0f)
            {
                _engine.Accelerate();
            }
            else if (_controls.Forklift.Decelerate.ReadValue<float>() > 0f)
            {
                _engine.Decelerate();
            }
        }

        private void ManageTurning()
        {
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

        private void ManageLift()
        {
            if (_controls.Forklift.RaiseLift.ReadValue<float>() > 0f)
            {
                _lift.Raise();
            }
            else if (_controls.Forklift.LowerLift.ReadValue<float>() > 0f)
            {
                _lift.Lower();
            }
        }
    }
}