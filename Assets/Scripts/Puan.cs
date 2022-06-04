using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    private int puan;
    public void PuanArttir() 
    {
        puan++;
    }
    public int PuanAl() 
    {
        return puan;
    }
    public void PuanSifirla() 
    {
        puan=0;
    }
    
}
