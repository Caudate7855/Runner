using Player;
using UnityEngine;

namespace Enemy
{
    public class EnemyModel : MonoBehaviour
    {
        [SerializeField] private int _damage;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out PlayerModel player))
            {
                player.ApplyDamage(_damage);
            }

            Die();
        }

        private void Die()
        {
            gameObject.SetActive(false);
        }
    }

}
