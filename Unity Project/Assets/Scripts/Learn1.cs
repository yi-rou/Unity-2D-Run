using UnityEngine;

public class Learn1 : MonoBehaviour
{
    private void Start()
    {
        print(Mathf.Epsilon);
        print(Mathf.Rad2Deg);
        print(Random.value);
        print(Mathf.Abs(-10.5f)); //取得絕對值

        Test();
        Skill("火花");
        Skill("波浪");
    }

    private void Update()
    {
        //print(Random.Range(100, 501));
    }

    public void Test()
    {
        print("測試中~");
    }

    public void Skill(string s)
    {
        print("施放技能:" + s);
        print("播放音效");
    }
}
