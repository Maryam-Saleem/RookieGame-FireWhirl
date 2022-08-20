using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
   public void MoveToScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
        Debug.Log("Maryam");
    }
    public void Quit()
    {
        Application.Quit();
    }

}
