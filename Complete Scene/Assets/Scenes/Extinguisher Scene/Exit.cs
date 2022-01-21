using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public GameObject Player;
    public GameObject Teleport;
    public GameObject spot;
    private float Timer;
    private float Dis;
    private int check;
    public float animTime = 3f;
    public Image fadeImage;

    private float start = 0f;           // Mathf.Lerp �޼ҵ��� ù��° ��.  
    private float end = 1f;             // Mathf.Lerp �޼ҵ��� �ι�° ��.  
    private float time = 0f;

    private float timer2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        check = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Dis = Vector3.Distance(Player.transform.position, Teleport.transform.position);
        Timer += Time.deltaTime;
        if(Timer > 25)
        {
            if (check == 0)
            {
                Instantiate(spot);
                check++;
            }
            if(Dis < 3.0f)
            {
                PlayFadeOut();
                timer2 += Time.deltaTime;
                if (timer2 > 3.2)
                {
                    SceneManager.LoadScene("Main");
                }
            }
        }
    }

    void PlayFadeOut()
    {
        time += Time.deltaTime / animTime;

        // Image ������Ʈ�� ���� �� �о����.  
        Color color = fadeImage.color;
        // ���� �� ���.  
        color.a = Mathf.Lerp(start, end, time);
        // ����� ���� �� �ٽ� ����.  
        fadeImage.color = color;
    }
}
