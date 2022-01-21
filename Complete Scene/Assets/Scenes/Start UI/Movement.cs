using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float animTime = 3f;         // Fade 애니메이션 재생 시간 (단위:초).  

    public Image fadeImage;            // UGUI의 Image컴포넌트 참조 변수.  

    private float start = 0f;           // Mathf.Lerp 메소드의 첫번째 값.  
    private float end = 1f;             // Mathf.Lerp 메소드의 두번째 값.  
    private float time = 0f;
    private float checkTimer = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("Cinema Lobby");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Application.Quit();
        }
    }

    void PlayFadeOut()
    {
        time += Time.deltaTime / animTime;
        Color color = fadeImage.color;
        color.a = Mathf.Lerp(start, end, time);
        fadeImage.color = color;
    }
}
