using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterController : MonoBehaviour
{
    public float inputDelay = 0.1f;
    public float forwardVel = 12;
    public float rotateVel = 100;

    Quaternion targetRotation;
    Rigidbody rBody;
    float forwardInput, turnInput;

    public Quaternion TargetRotation
    {
        get { return targetRotation; }
    }

    private void Start()
    {
        targetRotation = transform.rotation;
        if(GetComponent<Rigidbody>())
        {
            rBody = GetComponent<Rigidbody>();
        } else
        {
            Debug.LogError("need rigidbody");
        }
        forwardInput = turnInput = 0;
    }

    void GetInput()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }

    private void Update()
    {
        GetInput();
        Turn();

    }

    private void FixedUpdate()
    {
        Run();
    }

    void Run()
    {
        if(Mathf.Abs(forwardInput) > inputDelay)
        {
            //move
            rBody.velocity = transform.forward * forwardInput * forwardVel;
        }
        else
        {
            //or dont
            rBody.velocity = Vector3.zero;
        }
    }

    void Turn()
    {
        if (Mathf.Abs(turnInput) > inputDelay)
        {
            targetRotation *= Quaternion.AngleAxis(rotateVel * turnInput * Time.deltaTime, Vector3.up); 
        }
        transform.rotation = targetRotation;
    }


    /////// <summary>
    /////// 
    /////// </summary>
    ////public bool isRunning = false;
    ////public float inputDelay = 0.1f;
    ////public float forwardVel = 12;
    ////public float rotateVel = 100;

    //////hold next rotation
    ////Quaternion targetRotation;

    ////Rigidbody rBody;
    ////public Animator anim;
    ////CapsuleCollider colSize;

    ////private float mouseY, y;
    ////public float mouse;

    ////float forwardInput, turnInput;



    //////base cam rot off of this
    ////public Quaternion TargetRotation
    ////{
    ////    get { return targetRotation;  }
    ////}

    ////void Start()
    ////{
    ////    rBody = GetComponent<Rigidbody>();
    ////    anim = anim.GetComponent<Animator>();
    ////} 

    ////void GetInput()
    ////{

    ////}

    ////void Update()
    ////{
    ////    Run(); //movement
    ////    Turn();
    ////    checkAnim();
    ////}

    ////void checkAnim()
    ////{
    ////    //if moving
    ////    if(Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0) //forward or backwrard
    ////    {
    ////        anim.SetBool("isIdle", false);
    ////    } else
    ////    {
    ////        anim.SetBool("isIdle", true);
    ////    }

    ////    //if Attacking
    ////    if (Input.GetButton("Fire1"))
    ////    {
    ////        anim.SetBool("isAttacking", true);
    ////    } else
    ////    {
    ////        anim.SetBool("isAttacking", false);
    ////    }
    ////}

    ////void Run()
    ////{
    ////    var z = Input.GetAxis("Vertical") * forwardVel;
    ////    transform.Translate(0, 0, z);
    ////}

    ////void Turn()
    ////{
    ////    y += Input.GetAxis("Horizontal") * mouse;
    ////    mouseY += Input.GetAxis("MouseX") * mouse;
    ////    //rotate if RIGHT mouse is clicked
    ////    if (Input.GetMouseButton(1))
    ////    {
    ////        transform.rotation = Quaternion.Euler(0, mouseY, 0);
    ////        y = mouseY;
    ////    } else
    ////    {
    ////        transform.rotation = Quaternion.Euler(0, y, 0);
    ////        mouseY = y;
    ////    }
    ////}
    //public float speed;
    //public float jumpHeight;
    //public float mouseSensitivity;
    //private float mouseY, y;
    //public bool isGrounded;

    //Rigidbody rb;
    //public Animator anim;

    //// Use this for initialization
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    anim = anim.GetComponent<Animator>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    Movement();
    //    Turn();
    //    Jump();
    //    CheckAnimation();
    //}

    //void Movement()
    //{
    //    var z = Input.GetAxis("Vertical") * speed;
    //    transform.Translate(0, 0, z);
    //}
    //void Turn()
    //{
    //    y += Input.GetAxis("Horizontal") * mouseSensitivity;
    //    mouseY += Input.GetAxis("Mouse X") * mouseSensitivity;
    //    //Rotate Only if Right Mouse Button is Clicked
    //    if (Input.GetMouseButton(1))
    //    {
    //        transform.rotation = Quaternion.Euler(0, mouseY, 0);
    //        y = mouseY;
    //    }
    //    else
    //    {
    //        transform.rotation = Quaternion.Euler(0, y, 0);
    //        mouseY = y;
    //    }
    //}
    //void Jump()
    //{
    //    if (isGrounded && Input.GetKey(KeyCode.Space))
    //    {
    //        rb.AddForce(transform.up * jumpHeight);
    //        isGrounded = false;
    //    }
    //}

    //void CheckAnimation()
    //{
    //    //If Moving
    //    if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
    //    {
    //        anim.SetBool("isIdle", false);
    //    }
    //    else
    //    {
    //        anim.SetBool("isIdle", true);
    //    }
    //    //If Jumping
    //    if (!isGrounded)
    //    {
    //        anim.SetBool("isJumping", true);
    //    }
    //    else
    //    {
    //        anim.SetBool("isJumping", false);
    //    }
    //    //If Attacking/Minning
    //    if (Input.GetButton("Fire1"))
    //    {
    //        anim.SetBool("isAttacking", true);
    //    }
    //    else
    //    {
    //        anim.SetBool("isAttacking", false);
    //    }
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    isGrounded = true;
    //}
    //private void OnCollisionStay(Collision collision)
    //{
    //    isGrounded = true;
    //}
}