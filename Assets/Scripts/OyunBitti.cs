using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OyunBitti : MonoBehaviour
{
    public UnityEngine.UI.Text puan;
    // Start is called before the first frame update
    void Start()
    {
        puan.text = "Puan�n�z: " + GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().PuanAl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnaSaheneyeGec() 
    {
        SceneManager.LoadScene(0);
    }
}
