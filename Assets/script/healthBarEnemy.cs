using UnityEngine;
using UnityEngine.UI;
public class healthBarEnemy : MonoBehaviour
{
    public Image healthBarImage;
    public Enemy enemy;
    public void UpdateHealthBarEnemy()
    {
        healthBarImage.fillAmount = Mathf.Clamp(enemy.health / enemy.maxHealth, 0, 1f);
    }
}
