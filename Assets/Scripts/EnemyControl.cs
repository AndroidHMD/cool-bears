/*using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
    float speed;

    void Start () {
 	    speed = 2.0f;
	}

	void Update () {
	    Vector3 position = new transform.position;

	    position = new Vector3(position.x, position.y - speed * Time.deltaTime);

	    transform.position = position;

	    Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

	    if (transform.position.y < min.y) {
	    	Destroy(gameObject);
	    }
	}
}*/