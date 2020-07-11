using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool test;

    private void Update()
    {
        if (test)
        {
            print("cc");
        }
        else
        {
            print("kk");
        }
    }
}
