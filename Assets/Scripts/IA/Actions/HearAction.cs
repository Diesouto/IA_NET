using UnityEngine;

[CreateAssetMenu(fileName = "(A) HearAction", menuName = "ScriptableObjects/Actions/HearAction")]
public class HearAction : DrawableAction
{
    [SerializeField] private float radius;

    public override bool Check(GameObject owner)
    {
        Collider[] colliders = Physics.OverlapSphere(owner.transform.position, radius);

        foreach (Collider collider in colliders)
        {
            if (collider.GetComponent<Player>()) return true;
        }

        return false;
    }

    public override void DrawGizmo(GameObject owner)
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(owner.transform.position, radius);
    }
}
