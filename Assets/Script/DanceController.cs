using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>(); // Ambil komponen Animator
    }

    // Dipanggil saat tombol ditekan
    public void PlayDance()
    {
        animator.SetTrigger("Dancing"); // Trigger animasi
    }
}
