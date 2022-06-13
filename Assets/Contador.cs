using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public float TimeToFinish = 120f;
    public Text ContadorText;
    public int TiempoToText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToFinish -= Time.deltaTime;
        TiempoToText = (int)TimeToFinish;
        ContadorText.text = TiempoToText.ToString();

        if (TimeToFinish <= 0)
        {
            RestartGame();
        }

        //txt_time.text = Time.time.ToString();
    }
    public void RestartGame()
    {
        transform.position = new Vector3(0, 0.57f, 0);
        player1.transform.position = new Vector3(0, 0.5f, -10);
        player1.transform.eulerAngles = new Vector3(0, 0, 0);
        player2.transform.position = new Vector3(0, 0.5f, 10);
        player2.transform.eulerAngles = new Vector3(0, 180, 0);
    }
}
