using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private UIScreenRed screenUI;
    [SerializeField]
    private float maxHP = 20;
    private float currentHP;

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    private void Awake()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;

        screenUI.OnHitAnimation();

        if (currentHP <= 0)
        {
        }
    }
}