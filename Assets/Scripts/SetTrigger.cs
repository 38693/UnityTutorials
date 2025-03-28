using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTrigger : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Reset the "Crouch" trigger
            m_Animator.ResetTrigger("Idle");

            //Send the message to the Animator to activate the trigger parameter named "Jump"
            m_Animator.SetTrigger("Walking");
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            //Reset the "Jump" trigger
            m_Animator.ResetTrigger("Walking");

            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            m_Animator.SetTrigger("Idle");
        }
    }
}
