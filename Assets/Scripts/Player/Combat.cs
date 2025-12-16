using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour
{
    private Animator anim;
    private bool isAttacking = false;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Attack();
        }

        anim.SetBool("attacking", isAttacking);
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        StartCoroutine(Combo());
    }

    IEnumerator Combo()
    {
        yield return new WaitForSeconds(0.1f);
        isAttacking = true;
        yield return new WaitForSeconds(0.5f);
        isAttacking = false;
    }

}