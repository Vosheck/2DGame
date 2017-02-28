using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public float Speed;

    private Rigidbody2D _rb;

    private Animator _anim;

	// Use this for initialization
	void Start () {
        _rb=GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        bool isWalking = (Mathf.Abs(moveHorizontal) + Mathf.Abs(moveVertical)) > 0;

        _anim.SetBool("isWalking", isWalking);
        if (isWalking)
        {
            _anim.SetFloat("x", moveHorizontal);
            _anim.SetFloat("y", moveVertical);
        }

        

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f).normalized;

        _rb.velocity=movement * Speed;

    }
}
