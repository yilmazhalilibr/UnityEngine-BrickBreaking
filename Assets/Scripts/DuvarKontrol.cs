using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarKontrol : MonoBehaviour
{
    public GameObject carpma;
    public AudioClip sesEfekti;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D diger)
    {
        AudioSource.PlayClipAtPoint(sesEfekti, transform.position);
        Vector3 pos = diger.contacts[0].point;
        GameObject go = Instantiate(carpma, pos, Quaternion.identity) as GameObject;
        Destroy(go, 1f);
    }
}
