using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Attach : MonoBehaviour
{
    public GameObject Player;
    public GameObject Extinguisher;
    private GameObject helptext1;
    private GameObject Destext1;
    private float distance;
    private float timer;
    void Start()
    {
        helptext1 = GameObject.Find("Canvas/Text_Grap");
        Destext1 = GameObject.Find("Canvas/Text_Des");
        timer = Time.deltaTime;
    }

    void Update()
    {
        distance = Vector3.Distance(Player.transform.position, Extinguisher.transform.position);
        if(distance < 2.0)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                SceneManager.LoadScene("Mission UI");
            }
        }
        helptext1.transform.position = transform.position + new Vector3(0, 1.0f, 0);
        Destext1.transform.position = transform.position + new Vector3(0, 0.8f, 0);
    }
}
