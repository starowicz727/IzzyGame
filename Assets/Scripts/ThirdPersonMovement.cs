using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;
    public float gravity = -9.81f;
    public float jumpHeight = 3;
    Vector3 velocity;
    bool isGrounded;

    public Transform groundCheck;
    public float groundDistance = 0.01f; //promieñ okrêgu sprawdzaj¹cego kolizjê z pod³o¿em 
    public LayerMask groundMask;

    float turnSmoothVelocity;
    public float turnSmoothTime = 0.1f;

    private Animator animator;

    private void Start()
    {
        Cursor.visible = false;
        animator = GetComponent<Animator>();
        animator.Play("Base Layer.idle", -1);
    }
    void Update()
    {
        //jump
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //tworzymy sfere tu¿ pod graczem ¿eby sprawdziæ czy koliduje z pod³o¿em

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            animator.Play("Base Layer.jump", -1);
            velocity.y = Mathf.Sqrt(jumpHeight * -1 * gravity);
        }
        //gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        //walk
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f) //jesli nastapil jakikolwiek ruch horizontal lub vertical
        {
            //animator.Play(animWalk.name,-1); //sposob ponizej jest lepszy
            animator.Play("Base Layer.walk", -1);

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; //o jaki promieñ powinna przebiec rotacja jak gracz siê obraca
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime); //¿eby rotacja nie by³a zbyt szybka 
            transform.rotation = Quaternion.Euler(0f, angle, 0f-90); //tutaj dodaje -90 bo byl problem ze animator kaczuchy j¹ przewraca³ 

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
        else
        {
            animator.Play("Base Layer.idle", -1);
        }
    }
}
