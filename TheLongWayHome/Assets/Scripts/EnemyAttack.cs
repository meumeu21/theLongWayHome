using UnityEngine;
using System;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float _attackRange;
    [SerializeField] private int _damage;
    [SerializeField] private float _coolDown;
    private float _timer;
    public bool CanAttack { get;  private set; }
    private Player _player;
    public float AttackRange => _attackRange;
    private void Update()
    {
        UpDateCooldown();
    }
    private void UpDateCooldown()
    {
        if (CanAttack)
        {
            return;
        }
        _timer += Time.deltaTime;
        if (_timer < _coolDown)
        {
            return;
        }
        CanAttack = true;
        _timer = 0;
    }
    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }
    public void TryAttackPlayer()
    {
        _player.TakeDamage(_damage);

        CanAttack = false;
    }
}