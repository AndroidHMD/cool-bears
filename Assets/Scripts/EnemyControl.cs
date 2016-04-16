using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
    float moveSpeed;
    //public GameObject player;
    public Transform target;

    void Start () {
 	     moveSpeed = 0.1f;
 	     //player = GameObject.Find("Main Camera");
	}

	void Update () {
	    //Vector3 position = new transform.position;
	    //position = new Vector3(position.x, position.y - speed * Time.deltaTime);
	    //target.position = player.transform.position;

	    transform.LookAt(target.position);
	    float step = moveSpeed * Time.deltaTime;
	    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	    //transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);

	    //transform.position = position;
	    //Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

	    //if (transform.position.y < min.y) {
	    //	Destroy(gameObject);
	    //}
	}
}