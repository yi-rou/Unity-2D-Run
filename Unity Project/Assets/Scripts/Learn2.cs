using UnityEngine;

public class Learn2 : MonoBehaviour
{

    public GameObject d1;

    public Transform d1tr;

    public Camera cam;

    public ParticleSystem pat;

    private void Start()
    {
        print(d1.layer);

        d1tr.position = new Vector3(-2, 2, 0);
    }

    private void Update()
    {
        //d1tr.Rotate(0, 0, 50);
        d1tr.Translate(0.1f, 0, 0);

    }
}
