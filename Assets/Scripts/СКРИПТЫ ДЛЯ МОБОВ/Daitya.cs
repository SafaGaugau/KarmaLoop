using UnityEngine;

public class Daitya : EnemyBase
{
    [SerializeField]
    private float damageReduction = 0.15f;

    public override void TakeDamage(float amount)
    {
        amount *= (1f - damageReduction);

        base.TakeDamage(amount);
    }
}