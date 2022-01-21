using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelePort : MonoBehaviour
{
    public GameObject player;
    public GameObject cube;
    private float distance;

    public float animTime = 2f;         // Fade �ִϸ��̼� ��� �ð� (����:��).  
    public Image fadeImage;            // UGUI�� Image������Ʈ ���� ����.  
    private float start = 0f;           // Mathf.Lerp �޼ҵ��� ù��° ��.  
    private float end = 1f;             // Mathf.Lerp �޼ҵ��� �ι�° ��.  
    private float time = 0f;

    private float timer = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, cube.transform.position);
        
        if (distance <= 3)
        {
            timer += Time.deltaTime;
            PlayFadeOut();
            if (timer > 2.0f)
            {
                SceneManager.LoadScene("Burning Cinema");
            }
        }
    }

    void PlayFadeOut()
    {
        // ��� �ð� ���.  
        // 2��(animTime)���� ����� �� �ֵ��� animTime���� ������.  
        time += Time.deltaTime / animTime;

        // Image ������Ʈ�� ���� �� �о����.  
        Color color = fadeImage.color;
        // ���� �� ���.  
        color.a = Mathf.Lerp(start, end, time);
        // ����� ���� �� �ٽ� ����.  
        fadeImage.color = color;
    }
}
