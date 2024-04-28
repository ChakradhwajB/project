using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdTransition : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        SceneManager.LoadScene(sceneName: "Game Complete");
    }
}
