
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Mover3D _mover;
    private AnimationParamHandler _animHandler;
    private Vector3 _direction;

    private float _horizontal;
    private float _vertical;

    private void Awake()
    {
        _mover = GetComponent<Mover3D>();
        _animHandler = GetComponent<AnimationParamHandler>();
    }

    private void Update()
    {
        _horizontal = Input.GetAxis(Inputs.Horizontal);
        _vertical = Input.GetAxis(Inputs.Vertical);

        _direction = new Vector3(_horizontal, 0f, _vertical);

        if (Input.GetButtonDown(Inputs.Space))
        {
            _mover.Jump();
        }

        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        float forwardValue = 0f;

        if (_direction.magnitude > 0.1f)
        {
            forwardValue = isRunning ? 1f : 0.5f;
        }

        _animHandler.SetForward(forwardValue);

        if (isRunning)
        {
            _mover.SetSpeedMultiplier(2f);
        }
        else
        {
            _mover.ResetSpeedMultiplier();
        }
    }

    private void FixedUpdate()
    {
        _mover.SetMovementInput(_direction);        
    }
}
