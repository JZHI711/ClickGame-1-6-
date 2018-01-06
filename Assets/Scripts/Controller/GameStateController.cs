using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour {

	public void Awake ()
    {
        Input.multiTouchEnabled = true;//多點觸碰
	}
    private IEnumerator Start()
    {
        while (true)
        {
            yield return StartCoroutine(PlayPhase());
            yield return StartCoroutine(EndPhase());
        }
    }
    private IEnumerator PlayPhase()
    {
       
        yield return null;

    }
    private IEnumerator EndPhase()
    {
        yield return null;
    }
}
