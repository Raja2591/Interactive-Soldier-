using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ducksoldier : MonoBehaviour
{

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    public void theduck()
    {

        anim.SetTrigger("Duck");
    }

    public void knockout()
    {

        anim.SetTrigger("Damage");
    }

    public void handsup()
    {

        anim.SetTrigger("Shoot");
    }

    public void rest()
    {

        anim.SetTrigger("Idle");
    }
}