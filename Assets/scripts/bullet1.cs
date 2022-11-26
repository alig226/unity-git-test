using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    public GameObject bullet1fx;
    public float animSpeed;

    void Start() { StartCoroutine(waiter()); }
    IEnumerator waiter() {
        yield return new WaitForSecondsRealtime(2);
        Destroy(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Wall") {
            GameObject effect = Instantiate(bullet1fx, transform.position, Quaternion.identity);
            Destroy(effect, animSpeed);
            Destroy(this.gameObject);
        }
    }
}