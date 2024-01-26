using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField]
    private float timeToCompleteLevel;

    [SerializeField]
    private float updateTimerIntervalsTime = 0.1f;

    private float currentTimer;

    private Coroutine updateTimerRoutine;

    private void Start()
    {
        currentTimer = timeToCompleteLevel;

        Debug.Log($"Time to complete level: {timeToCompleteLevel}");

        updateTimerRoutine = StartCoroutine(UpdateTimer(updateTimerIntervalsTime));
    }

    private void OnDestroy()
    {
        StopUpdateRoutine();
    }

    private void StopUpdateRoutine()
    {
        StopCoroutine(updateTimerRoutine);
    }

    private IEnumerator UpdateTimer(float intervalsTime)
    {
        while (true)
        {
            if (currentTimer <= 0)
            {
                Debug.Log("Game over! Time ran out!");
                // TODO Game over
                StopUpdateRoutine();
                yield break;
            }

            currentTimer = currentTimer - intervalsTime;
            Debug.Log($"Current time: {currentTimer} ; DeltaTIme: {Time.deltaTime}");

            yield return new WaitForSeconds( intervalsTime );
        }
    }
}
