using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    public AudioClip sesEfekti;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        transform.position = new Vector3(Mathf.Clamp(farePos.x,-3.5f,3.75f),transform.position.y,transform.position.z);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(sesEfekti, transform.position);
    }
}
