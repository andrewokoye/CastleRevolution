using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 10f;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool isDead = false;

    private void Awake()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, maxHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
            //iframes
        }
        else
        {
            if (!isDead)
            {
                anim.SetTrigger("die");
                GetComponent<Movement>().enabled = false;
                isDead = true;
            }

        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, maxHealth);
    }

}
