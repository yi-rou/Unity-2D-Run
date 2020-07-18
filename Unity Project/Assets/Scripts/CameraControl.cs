using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("追蹤目標")]
    public Transform trn;
    [Header("追蹤速度"), Range(0,50)]
    public float speed = 5;
    public Vector2 limitY = new Vector2(-0.5f, 0.7f);

    private void Track()
    {
        Vector3 a = transform.position;
        Vector3 b = trn.position;
        b.z = -10;
        a = Vector3.Lerp(a, b, Time.deltaTime * speed);
        a.y = Mathf.Clamp(a.y, limitY.x, limitY.y);
        transform.position = a;
       
    }

    private void LateUpdate()
    {
        Track();
    }
    //public void Update()
    //{
    //    Vector2 myCamear = transform.position;

    //    Vector2 hero = trn.position;

    //    transform.position = Vector3.Lerp(myCamear, hero, speed * Time.deltaTime);

    //    transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    //}
}
