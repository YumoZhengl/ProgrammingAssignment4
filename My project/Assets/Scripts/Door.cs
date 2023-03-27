using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Animator animator;
    public bool isOpen = false;
    public Transform exitPoint;
    public Transform approachPoint;

    public void TryOpen()
    {
        if (isOpen)
        {
            return;
        }
        animator.SetTrigger("open");
        isOpen = true;
    }
}
