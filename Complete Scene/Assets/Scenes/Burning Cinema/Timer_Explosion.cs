using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_Explosion : MonoBehaviour
{
    public GameObject Fire;
    public GameObject Explosion;
    public GameObject DoorSmoke;
    public GameObject Smoke;
    private GameObject DeleteEx;
    private float timer;
    private int check;

    void Start()
    {
        timer = 0;
        check = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5.0f && check == 0)
        {
            Instantiate(Explosion);
            check++;
        }
        if(timer > 5.2f && check == 1)
        {
            Instantiate(Fire);
            check++;
        }
        if(timer > 7.0f && check ==2)
        {
            DeleteEx = GameObject.Find("BigExplosion(Clone)");
            Destroy(DeleteEx);
        }
        if(timer > 9.0f && check == 2)
        {
            Instantiate(DoorSmoke);
            check++;
        }
        if(timer > 15.0f && check == 3)
        {
            Instantiate(Smoke);
            check++;
        }
    }
}
