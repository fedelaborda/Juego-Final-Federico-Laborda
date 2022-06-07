using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{

    public int golRojo;
    public GameObject player1;
    public GameObject player2;
    public GameObject confetiRojo;
    AudioSource hinchada;
    AudioSource gritoGol;
    bool isPlaying; 

    // Start is called before the first frame update
    void Start()
    {
        golRojo = 0;
        hinchada = GetComponent<AudioSource>();
        gritoGol = GetComponent<AudioSource>();
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Finish")
        {
            transform.position = new Vector3(0, 0.57f, 0);
            player1.transform.position = new Vector3(0, 0.5f, -10);
            player1.transform.eulerAngles = new Vector3(0, 0, 0);
            player2.transform.position = new Vector3(0, 0.5f, 10);
            player2.transform.eulerAngles = new Vector3(0, 180, 0);

            golRojo ++;

            for (int i = 0; i < 10; i++)
            {
                Instantiate(confetiRojo);
            }

            isPlaying = !isPlaying;

            if (isPlaying)
            {
                hinchada.Play;
            }
            else
            {
                hinchada.Stop;
                gritoGol.Play;
            }

        }

    }
}
