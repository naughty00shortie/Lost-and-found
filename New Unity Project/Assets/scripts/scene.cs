using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //    SceneManager.UnloadScene("Intro", LoadSceneMode.Additive);
        //   SceneManager.LoadSceneAsync("test", LoadSceneMode.Additive);

    }
}
