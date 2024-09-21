using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwitcher  : MonoBehaviour
{
    public Animator transition;
    public void ChangeScene(string sceneName)
    {
        StartCoroutine(LoadLevel(sceneName));
    }
    IEnumerator LoadLevel(string sceneName){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
