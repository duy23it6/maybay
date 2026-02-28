using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        GameManager gm = FindObjectOfType<GameManager>();

        if (gm != null)
        {
            gm.GameOver();
        }

        base.Die();
    }
}   