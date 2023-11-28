using Player;
using UnityEngine;
using TMPro;
public class HealthDisplay : MonoBehaviour
{
   [SerializeField] private PlayerModel _player;
   [SerializeField] private TMP_Text _healthDisplay;

   private void OnEnable()
   {
      _player.HealthChanged += OnHealthChanged;
   }

   private void OnDisable()
   {
      _player.HealthChanged -= OnHealthChanged;
   }

   private void OnHealthChanged(int health)
   {
      _healthDisplay.text = "Lifes: " + health.ToString();
   }
}
