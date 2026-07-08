using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    private int karma;

    public void AddKarma(int amount)
    {
        karma += amount;

        Debug.Log($"Получено кармы: {amount}");

        Debug.Log($"Всего кармы: {karma}");

        // ==========================================
        // TODO
        //
        // После интеграции удалить.
        // Здесь коллега будет обновлять UI
        // и систему уровней.
        //
        // ==========================================
    }
}