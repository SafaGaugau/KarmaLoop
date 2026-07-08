using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;

    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        Debug.Log($"Игрок получил {damage} урона.");

        Debug.Log($"Текущее HP: {currentHealth}");

        if (currentHealth <= 0)
        {
            Debug.Log("Игрок погиб.");

            // ==================================================
            // TODO
            //
            // После интеграции удалить.
            // Здесь коллега вызовет свою смерть игрока.
            //
            // ==================================================
        }
    }
}