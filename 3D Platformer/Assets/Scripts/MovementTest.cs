using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour {

    public float Speed = 5f;
    public float JumpHeight = 4f;
    public float GroundDistance = 0.2f;
    public float DashDistance = 5f;
    public LayerMask Ground;
    public float sprint = 1.5f;

    private Rigidbody _body;
    private Vector3 _inputs = Vector3.zero;
    public bool _isGrounded;
    private Transform _groundChecker;

    public Animator _anim;

    void Start()
    {
        _body = GetComponent<Rigidbody>();
        _groundChecker = this.transform;
        _anim.GetComponent<Animator>();
        _isGrounded = true;
    }

    void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);

        _anim.SetBool("Grounded", _isGrounded);

        _inputs = Vector3.zero;
        _inputs.x = Input.GetAxis("Horizontal");
        _inputs.z = Input.GetAxis("Vertical");

        if (_inputs != Vector3.zero)
        {
            transform.forward = _inputs;
            _anim.SetFloat("Speed", _inputs.magnitude);
        }

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -1f * Physics.gravity.y), ForceMode.VelocityChange);

            _anim.SetBool("Grounded", _isGrounded);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Vector3 dashVelocity = Vector3.Scale(transform.forward, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime)));
            _body.AddForce(dashVelocity, ForceMode.VelocityChange);
            _anim.Play("Charge");
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            _inputs.x *= sprint;
            _anim.SetBool("Sprint", true);
            _inputs.z *= sprint;
        } else {
            _anim.SetBool("Sprint", false);
        }
    }

    void FixedUpdate()
    {
        _body.MovePosition(_body.position + _inputs * Speed * Time.fixedDeltaTime);
    }
}
