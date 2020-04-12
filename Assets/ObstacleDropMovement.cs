using UnityEngine;

public class ObstacleDropMovement : MonoBehaviour
{

    public float speed = 1f;
    public GameObject ground;

    private Vector3 pos1;
    private Vector3 pos2;

    public float max_y = 10f;

    // Use this for initialization
    void Start()
    {
        int random_sign = Random.Range(0, 2) * 2 - 1; //get -1 or +1 to set obstacle on one end or the the other
        pos1 = new Vector3(transform.position.x, max_y, transform.position.z);
        pos2 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 2));
    }
}
