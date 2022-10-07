using UnityEngine;

namespace Assets.Scripts
{
    public class JoystickMovment : MonoBehaviour
    {
        [SerializeField] private Joystick _joystick;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private TapMovement _tapMovement;

        [Header("Properties")]
        [SerializeField] private float _speed = 3f;

        private void FixedUpdate()
        {
            Vector3 joystickInput = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);

            if (joystickInput.sqrMagnitude != 0)
            {
                _rigidbody.MovePosition(transform.position + joystickInput * Time.fixedDeltaTime * _speed);
                _tapMovement.StopMove();
            }
        }
    }
}