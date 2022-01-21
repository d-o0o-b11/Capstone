using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_Fire : MonoBehaviour
{
    public GameObject MediumFire;
    public GameObject ChairFire1;
    public GameObject ChairFire2;
    public GameObject ChairFire3;
    public GameObject LargeFlames;
    public GameObject UpperFog;
    private float timer;
    private int check;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        check = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 9.0 && check == 0)
        {
            Instantiate(MediumFire);
            check++;
        }
        else if (timer > 13.0&& check == 1)
        {
            Instantiate(ChairFire1);
            check++;
        }
        else if (timer > 17.0&& check == 2)
        {
            Instantiate(ChairFire2);
            check++;
        }
        else if (timer > 22&& check == 3)
        {
            Instantiate(ChairFire3);
            check++;
        }
        else if (timer > 26&& check == 4)
        {
            Instantiate(LargeFlames);
            Instantiate(UpperFog);
            check++;
        }
    }
}
