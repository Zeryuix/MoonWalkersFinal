using UnityEngine;

public class CollisionFusee : MonoBehaviour
{
    public static Vector3 spawn;
    public GameObject fusee;
    public static bool crashed;

    private void Start()
    {
        spawn = new Vector3(0.3f, 6.6f, 3.041514f);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "SmallAsteroid" || other.gameObject.name == "SmallAsteroid(Clone)")
        {
            crashed = true;
            fusee.transform.position = spawn;
        }
    }
}
