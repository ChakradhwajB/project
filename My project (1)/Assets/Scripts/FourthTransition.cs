using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FourthTransition : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        SceneManager.LoadScene(sceneName: "Level 1");
    }
}
