using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_back : MonoBehaviour
{
    public void SceneChange_main()
    {
        SceneManager.LoadScene("Main");
    }
}
