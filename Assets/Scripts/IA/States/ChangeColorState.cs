using UnityEngine;

[CreateAssetMenu(fileName = "(S) ChangeColorState", menuName = "ScriptableObjects/States/ChangeColorState")]
public class Chase : State
{
    public override State Run(GameObject owner)
    {
        owner.GetComponent<SkinnedMeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        return base.Run(owner);
    }
}
