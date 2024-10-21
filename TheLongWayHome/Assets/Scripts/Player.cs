using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public void TakeDamage(int damage)
    {
        if(_health - damage <= 0)
        {
            Debug.Log("DIED");
            return;
        }
        _health -= damage;
    }
}
