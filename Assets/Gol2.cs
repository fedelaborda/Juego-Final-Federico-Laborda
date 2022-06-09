using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gol2 : MonoBehaviour
{
    public int golAzul;
    public GameObject player1;
    public GameObject player2;
    public GameObject confetiAzul;

    // Start is called before the first frame update
    void Start()
    {
        golAzul = 0;
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

            golAzul ++;
            
            for (int i = 0; i < 10; i++)
            {
                Instantiate(confetiAzul);
            }

        }

    }
}
