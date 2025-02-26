using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleColorChanger : MonoBehaviour
{
    public Material capsuleMaterial;
    private Color originalColor;
    public Color targetColor = Color.red; // Warna saat mencapai titik

    void Start()
    {
        originalColor = capsuleMaterial.color; // Simpan warna awal
    }

    // Dipanggil via Animation Event
    public void ChangeColor()
    {
        capsuleMaterial.color = targetColor;
    }

    // Kembali ke warna asal (bisa dipanggil di event kedua)
    public void ResetColor()
    {
        capsuleMaterial.color = originalColor;
    }

}