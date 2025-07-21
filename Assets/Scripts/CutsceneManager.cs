using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    public GameObject cutsceneCamera01;
    public GameObject mainCamera;
    public GameObject canvas;
    public GameObject cutsceneCamera02;



    IEnumerator StartCutsceneOne()
    {
        yield return new WaitForSeconds(2f);
        canvas.SetActive(false);
        cutsceneCamera01.SetActive(true);
        mainCamera.SetActive(false);
        print("11111");
        yield return new WaitForSeconds(3f);
        canvas.SetActive(true);
        cutsceneCamera01.SetActive(false);
        mainCamera.SetActive(true);
        print("22222");
    }

    public void PlayCutsceneOne()
    {
        StartCoroutine(StartCutsceneOne());
    }

    public void PlayCutsceneTwo()
    {
        StartCoroutine(StartCutsceneTwo());
    }

    IEnumerator StartCutsceneTwo()
    {
        yield return new WaitForSeconds(2f);
        canvas.SetActive(false);
        cutsceneCamera02.SetActive(true);
        mainCamera.SetActive(false);
        print("11111");
        yield return new WaitForSeconds(3f);
        canvas.SetActive(true);
        cutsceneCamera02.SetActive(false);
        mainCamera.SetActive(true);
        print("22222");
    }
}
