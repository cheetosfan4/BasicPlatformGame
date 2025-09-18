using UnityEngine;

public class CollectibleData : MonoBehaviour
{
    public int collectibleValue;

    public void destroyCollectible() {
        Destroy(this.gameObject);
    }

    public int getCollectibleValue() {
        return collectibleValue;
    }
}
