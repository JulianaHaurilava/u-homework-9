using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float MaxTime;     // максимальное время таймера
    private float currentTime;          // текущее время
    public bool TaskCompleted;          // показатель истечния времени

    void Start()
    {
        currentTime = MaxTime;
        TaskCompleted = false;
    }

    void Update()
    {
        TaskCompleted = false;
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            TaskCompleted = true;
            currentTime = MaxTime;
        }
    }
}
