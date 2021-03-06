using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
          UnityEngine.Application.Quit();
#endif
    }
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(Screen.width, Screen.height, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && Screen.fullScreen)
        {
            Screen.fullScreen = false;
        }
    }
}
