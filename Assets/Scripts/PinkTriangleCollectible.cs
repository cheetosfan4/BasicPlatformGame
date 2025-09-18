using UnityEngine;

public class PinkTriangleCollectible : MonoBehaviour
{
    string test;
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            Destroy(this.gameObject);
        }
    }

}
