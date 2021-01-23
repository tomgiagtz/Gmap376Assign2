using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaAnimationManager : MonoBehaviour
{
    private Animator animator;
    [Range(0, 1)]
    public float forwardVelocity = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //get access to animation controller
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //set forward velocity in anim controller to some value
        animator.SetFloat("ForwardVelocity", forwardVelocity);
    }
}
