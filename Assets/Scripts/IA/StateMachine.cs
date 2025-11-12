using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private State initialState;
    private State currentState;

    void Start()
    {
        currentState = initialState;
    }

    void Update()
    {
        RunStateMachine();
    }

    void RunStateMachine()
    {
        State nextState = currentState.Run(gameObject);

        if (nextState != currentState)
        {
            currentState = nextState;
        }
    }
}
