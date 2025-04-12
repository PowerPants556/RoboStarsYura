using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainCharacter : MonoBehaviour
{
    [SerializeField] private PlayerInputs inputActions;
    [SerializeFIeld] private CharecterController cController;
    [SerializeField] private Animator animator;

    private Vector2 movementInput;
    private Vector3 currentMovement;
    private Quaternion rotateDir;

    private bool isRun, isWalk;
    private float rotateSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void Movement(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        currentMovement.x = movementInput.x;
        currentMovement.z = movementInput.y;
        isWalk = movementInput.x != 0 || movementInput.y != 0;
    }
}
