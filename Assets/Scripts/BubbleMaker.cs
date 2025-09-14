using UnityEngine;

public class BubbleMaker : MonoBehaviour
{
    public GameObject Bubble;
    float y = -8f;
    float minX = -13f;
    float maxX = 13f;
    public float bubbleChance = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) <= bubbleChance)
        {
            Object.Instantiate(Bubble, new Vector3(Random.Range(minX, maxX), y, 0), Quaternion.identity);
        }
    }
}
