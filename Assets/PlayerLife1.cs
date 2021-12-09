using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife1 : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            Die();

        }
    }


    private void Die()
    {

        anim.SetTrigger("death");

    }
    
}

