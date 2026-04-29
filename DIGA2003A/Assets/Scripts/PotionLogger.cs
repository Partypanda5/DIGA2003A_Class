using UnityEngine;
public class PotionLogger : MonoBehaviour
{
    public enum PotionType
    {
        Healing,
        Mana,
        Speed,
        Poison
    }

    public PotionType potion = PotionType.Healing;

    void Start()
    {
        switch (potion)
        {
            case PotionType.Healing:
                Debug.Log("Healing Potion Will Restore health.");
                break;

            case PotionType.Mana:
                Debug.Log("Mana Potio Will Restore mana.");
                break;

            case PotionType.Speed:
                Debug.Log("Speed Potion Will Increase movement speed.");
                break;

            case PotionType.Poison:
                Debug.Log("Poison Potion Will Deal damage over time.");
                break;
        }
    }
}