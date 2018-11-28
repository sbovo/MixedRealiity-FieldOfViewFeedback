using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DoSomeWork());
    }

    private IEnumerator DoSomeWork()
    {
        for (int i = 0; i < 50; i++)
        {
            StartCoroutine(ChangeTextForTesting(i));
            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator ChangeTextForTesting(int i)
    {
        FOVFeedback.instance.ModifyText("I count: " + i);
        yield return 1;
    }
}
