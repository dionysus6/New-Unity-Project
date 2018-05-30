using UnityEngine;
using UnityEngine.UI;


public class enemy : MonoBehaviour {

    public float speed = 10f;
    private int waypointsIndex = 0;
    private Transform target;
    void Start()
	{
        target = waypoints.points[0]; 
	}
    void Update()
	{
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized*speed*Time.deltaTime,Space.World);
        if(Vector3.Distance(transform.position,target.position)<=0.2f){
            GetNextWaypoint();
        }
    }
    void GetNextWaypoint(){
        if(waypointsIndex>=waypoints.points.Length-1){
            Destroy(gameObject);
            return;
        }
        waypointsIndex++;
        target = waypoints.points[waypointsIndex];
    }


}
