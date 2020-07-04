using UnityEngine;

public class Learn1 : MonoBehaviour
{
    private void Start()
    {
        print(Mathf.Epsilon);
        print(Mathf.Rad2Deg);
        print(Random.value);
        print(Mathf.Abs(-10.5f)); //取得絕對值
        
    }

    private void Update()
    {
        print(Random.Range(100, 501));
    }
}
