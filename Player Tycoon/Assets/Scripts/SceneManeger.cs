using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManeger : MonoBehaviour
{
    public string scenename;
    public void SceneLoader()
    {
        SceneManager.LoadScene(scenename);
    }
}
