using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public float speed = 1f;
    public GameObject ground;

    private Vector3 pos1;
    private Vector3 pos2;

    // Use this for initialization
    void Start () {
        int random_sign = Random.Range(0, 2) * 2 - 1; //get -1 or +1 to set obstacle on one end or the the other
        float length = ground.transform.localScale.x - transform.lossyScale.x/2;
        pos1 = new Vector3( random_sign * (length / 2), transform.position.y, transform.position.z);
        pos2 = new Vector3( -random_sign * (length / 2), transform.position.y, transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(pos1,pos2,Mathf.PingPong(Time.time * speed, 1));
	}
}

