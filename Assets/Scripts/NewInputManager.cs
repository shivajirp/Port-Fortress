using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputManager : MonoBehaviour
{
    private NewPlayerInput playerInput;
    public NewPlayerInput.OnfootActions onfoot;

    private PlayerMotor motor;
    private PlayerLook look;
    // Start is called before the first frame update

    void Awake()
    {
        playerInput = new NewPlayerInput();
        onfoot = playerInput.Onfoot;

        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();

        onfoot.Jump.performed += ctx => motor.jump();

        onfoot.Crouch.performed += ctx => motor.Crouch();
        onfoot.Sprint.started += ctx => motor.Sprint(true); // Start sprinting
        onfoot.Sprint.canceled += ctx => motor.Sprint(false);
    }

    private void Sprint_performed(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //tell the player motor to move using the value from our movement action
        motor.ProcessMove(onfoot.Movement.ReadValue<Vector2>());
    }

    void LateUpdate()
    {
        //tell the player motor to move using the value from our movement action
        look.ProcessLook(onfoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onfoot.Enable();    
    }

    private void OnDisable()
    {
        onfoot.Disable();
    }
}
