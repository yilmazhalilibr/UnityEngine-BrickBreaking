using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buton : MonoBehaviour
{
    // Start is called before the first frame update
    public void digerSahne() 
    {
        Tugla.toplamTuglaSayisi = 0;
        GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().PuanSifirla();
        SceneManager.LoadScene("Bolum1");
    }
}
