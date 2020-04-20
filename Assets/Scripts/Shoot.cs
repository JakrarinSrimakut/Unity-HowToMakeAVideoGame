using UnityEngine;

public class Shoot : MonoBehaviour {

    private float timeBtwShots; //counter for time to shoot
    public float startTimeBtwShots; //amount of time to shoot

    public GameObject projectile;
    private Vector3 projectile_pos;
    // Use this for initialization
    void Start()
    {
        timeBtwShots = startTimeBtwShots;
        projectile_pos = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwShots <= 0)
        {
            Instantiate(projectile, projectile_pos, Quaternion.identity);// bullet appear at enemy position w/ no rotation
            timeBtwShots = startTimeBtwShots;//reset counter
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
