using UnityEngine;
using UnityEngine.UI;
public class healthBar : MonoBehaviour
{
    public Image healthBarImage;
    public player player;
    public void UpdateHealthBar()
    {
        healthBarImage.fillAmount = Mathf.Clamp(player.health / player.maxHealth, 0, 1f);
    }
}
