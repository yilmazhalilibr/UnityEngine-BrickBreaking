using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public GameObject kirilmaEfekti;
    private Puan puanScripti;
    public static int toplamTuglaSayisi;
    public Sprite[] tuglaSprite;
    private int maxCarpmaSayisi;
    private int carpmaSayisi;
    public AudioClip sesEfektiTuglaKirilma;
    public AudioClip sesEfektiCarpma;
    // Start is called before the first frame update
    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length + 1;
        toplamTuglaSayisi++;
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D diger)
    {
        if (diger.gameObject.name.Equals("top"))
        {
            puanScripti.PuanArttir();
            carpmaSayisi++;

            if (carpmaSayisi >= maxCarpmaSayisi)
            {
                toplamTuglaSayisi--;

                if (toplamTuglaSayisi < 1)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().BirSonrakiSahne();
                }
                Vector3 pos = diger.contacts[0].point;
                GameObject go = Instantiate(kirilmaEfekti, pos, Quaternion.identity) as GameObject;
                Color tuglaRengi = GetComponent<SpriteRenderer>().color;
                go.GetComponent<ParticleSystemRenderer>().material.color = tuglaRengi;
                Destroy(go, 1f);
                AudioSource.PlayClipAtPoint(sesEfektiTuglaKirilma, transform.position);
                Destroy(this.gameObject);
            }
            else
            {
                AudioSource.PlayClipAtPoint(sesEfektiCarpma, transform.position);
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1];
            }
        }
    }


}
