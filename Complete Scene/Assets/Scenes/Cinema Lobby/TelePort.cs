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

    public float animTime = 2f;         // Fade 애니메이션 재생 시간 (단위:초).  
    public Image fadeImage;            // UGUI의 Image컴포넌트 참조 변수.  
    private float start = 0f;           // Mathf.Lerp 메소드의 첫번째 값.  
    private float end = 1f;             // Mathf.Lerp 메소드의 두번째 값.  
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
        // 경과 시간 계산.  
        // 2초(animTime)동안 재생될 수 있도록 animTime으로 나누기.  
        time += Time.deltaTime / animTime;

        // Image 컴포넌트의 색상 값 읽어오기.  
        Color color = fadeImage.color;
        // 알파 값 계산.  
        color.a = Mathf.Lerp(start, end, time);
        // 계산한 알파 값 다시 설정.  
        fadeImage.color = color;
    }
}
