using UnityEngine;

[CreateAssetMenu(fileName = "(A) HearAction", menuName = "ScriptableObjects/Actions/HearAction")]
public class HearAction : Action
{
    [SerializeField] private float radius = 10f;

    public override bool Check(GameObject owner)
    {
        Collider[] colliders = Physics.OverlapSphere(owner.transform.position, radius);

        foreach (Collider collider in colliders)
        {
            if (collider.GetComponent<Player>()) return true;
        }

        return false;
    }
}
