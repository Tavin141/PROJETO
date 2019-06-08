using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator animator;

    public void PlayMenu()

    {
        animator.SetTrigger("Menu");

    }

    public void PlayCreditos()

    {

        animator.SetTrigger("Nave");
    }
}
