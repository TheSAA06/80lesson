using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("AllUnits");
    }
    public void GameExit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
