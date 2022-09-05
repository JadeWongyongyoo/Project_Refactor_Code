using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryCutscene : MonoBehaviour
{
    public GameObject cutscene1, cutscene2, cutscene3, cutscene4;
    public float time = 25.0f;
    void Start()
    {
        cutscene();
        Coroutine();
    }
    void cutscene()
    {
        cutscene1.SetActive(false);
        cutscene2.SetActive(false);
        cutscene3.SetActive(false);
        cutscene4.SetActive(false);
    }
    void Coroutine()
    {
        StartCoroutine(activeObject1());
        StartCoroutine(activeObject2());
        StartCoroutine(activeObject3());
        StartCoroutine(activeObject4());
    }
    IEnumerator activeObject1()
    {
        yield return new WaitForSeconds(time);
        cutscene1.SetActive(true);
    }
    IEnumerator activeObject2()
    {
        yield return new WaitForSeconds(time + 2.5f);
        cutscene2.SetActive(true);
    }
    IEnumerator activeObject3()
    {
        yield return new WaitForSeconds(time + 3.5f);
        cutscene3.SetActive(true);
    }
    IEnumerator activeObject4()
    {
        yield return new WaitForSeconds(time + 4.5f);
        cutscene4.SetActive(true);
    }
}
