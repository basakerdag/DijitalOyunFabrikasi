using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonKodları : MonoBehaviour
{
    public void sahneIleri(string sahneAdi)
    {
        SceneManager.LoadScene(sahneAdi);
    }

    public void CikisTusu()
    {
        Application.Quit();
    }
}
