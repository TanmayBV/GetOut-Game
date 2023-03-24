using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube2 : MonoBehaviour
{
    bool an;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void setbol()
    {
        
        animator.SetBool("rot", true);
    }

    public void setr()
    {
        animator.SetBool("rot", false);
    }
}
