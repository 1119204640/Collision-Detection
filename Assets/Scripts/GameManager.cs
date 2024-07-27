using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject plane;
    private List<GameObject> balls;
    public float speed = 1;
    public float number = 100;
    private struct planeSize
    {
        public float x; 
        public float z;
    };

    // Start is called before the first frame update
    void Start()
    {
        planeSize size;
        size.x = plane.GetComponent<Renderer>().bounds.size.x;
        size.z = plane.GetComponent<Renderer>().bounds.size.z;
        float r = ball.GetComponent<SphereCollider>().radius;        // Debug.Log($"{size.x},{size.y}");
        balls = new List<GameObject>();
        for (int i = 0; i < number; i++) {
            float width = size.x / 2 - r;
            float height = size.z / 2 - r;
            GameObject go = Instantiate(ball, new Vector3(Random.Range(-width, width), r/2, Random.Range(-height, height)), Quaternion.identity);
            balls.Add(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Move() {
        yield return new WaitForSeconds(1);
        ChangeDirection();
    }

    private void ChangeDirection()
    {
        // Vector3 dir = new Vector3();
    }
}
