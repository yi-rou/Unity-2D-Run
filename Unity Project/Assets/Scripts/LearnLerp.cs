using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    public float a = 0;
    public float b = 10;

    public Color c1 = new Color(1, 0, 0);
    public Color c2 = new Color(0, 0, 1);

    private void Start()
    {
        float n = Mathf.Lerp(a, b ,0.3f);
        print(n);
    }

    private void Update()
    {
        c1 = Color.Lerp(c1, c2, 0.5f * Time.deltaTime);
    }
}
