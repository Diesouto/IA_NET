using UnityEngine;

public class State : ScriptableObject
{
    [Tooltip("Acción que se ha de cumplir para cambiar de estado")]
    [SerializeField] private Action actionToCheck;

    [Tooltip("Valor que tiene que devolver la acción")]
    [SerializeField] private bool actionValue;

    [Tooltip("Próximo estado a ejecutar")]
    [SerializeField] private State nextState;

    public virtual State Run(GameObject owner)
    {
        if (actionToCheck.Check(owner) == actionValue) {
            return nextState;
        }

        return this;
    }

    public void DrawAllGizmos(GameObject owner) {
        DrawableAction drawableAction = (DrawableAction) actionToCheck;

        if(drawableAction)
        {
            drawableAction.DrawGizmo(owner);
        }
    }
}
