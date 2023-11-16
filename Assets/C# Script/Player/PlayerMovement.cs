using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 6f;
    public float runSpeed = 12f;
    public float jumpPower = 7f;
    public float lookSpeed = 4f;
    public float lookXLimit = 45f;
    public GameObject head;

    public Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0;
    private CharacterController characterController;

    private bool canMove = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (- forward * curSpeedX) + (- right * curSpeedY);

        if (Input.GetKeyDown(KeyCode.Space) && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        characterController.Move(moveDirection * Time.deltaTime);

        if (canMove)
        {
            rotationX += -Input.GetAxisRaw("Mouse Y") * lookSpeed;
            float v = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * 100f;
            head.transform.Rotate(new Vector3(v, 0, 0));
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxisRaw("Mouse X") * lookSpeed, 0);
        }


        if (this.transform.position.x > 30.75f || this.transform.position.x < -30.75f
            || this.transform.position.z > 30.75f || this.transform.position.z < -30.75f)
        {
            this.transform.position = new Vector3(0f, 1.6f, 0f);
            GameObject.Find("Player").GetComponent<Player>().Fall();
        }
    }

    public void SlowDown()
    {
        runSpeed /= 2;
        walkSpeed /= 2;
        Invoke("SpeedUp", 8.0f);
    }

    public void SpeedUp()
    {
        runSpeed *= 2;
        walkSpeed *= 2; 
    }
}