using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    public GameObject panel1; // Panel pertama
    public GameObject panel2; // Panel kedua
    public CameraMove cameraMoveScript; // Referensi ke script CameraMove

    void Start()
    {
        // Matikan pergerakan kamera saat game dimulai
        cameraMoveScript.canMove = false;

        // Aktifkan panel pertama
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    // Dipanggil saat tombol "Next" ditekan
    public void NextPanel()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    // Dipanggil saat tombol "Back" ditekan
    public void BackPanel()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    // Dipanggil saat tombol "Close" ditekan
    public void CloseTutorial()
    {
        panel2.SetActive(false);
        cameraMoveScript.canMove = true; // Izinkan kamera bergerak
    }


}
