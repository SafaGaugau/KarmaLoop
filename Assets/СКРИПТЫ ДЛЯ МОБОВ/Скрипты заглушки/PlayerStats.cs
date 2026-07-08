using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float attackPower = 10f;

    private float defaultMoveSpeed;
    private float defaultAttackPower;

    private void Start()
    {
        defaultMoveSpeed = moveSpeed;
        defaultAttackPower = attackPower;
    }

    public void ApplySnakeTrailDebuff()
    {
        moveSpeed = defaultMoveSpeed * 0.8f;
        attackPower = defaultAttackPower * 0.9f;

        Debug.Log("Игрок замедлен.");
        Debug.Log("Сила атаки уменьшена.");
    }

    public void RemoveSnakeTrailDebuff()
    {
        moveSpeed = defaultMoveSpeed;
        attackPower = defaultAttackPower;

        Debug.Log("Дебафф снят.");
    }
}