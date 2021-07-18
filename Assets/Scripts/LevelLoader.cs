using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public void Update()
    {
       if (slider.value == 1)
        {
            SceneManager.LoadScene(2);
        } 
    }
}