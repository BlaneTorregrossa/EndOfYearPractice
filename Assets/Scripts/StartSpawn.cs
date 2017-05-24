using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartSpawn : MonoBehaviour
{
    #region Variables
    public Vector2 Graph;
    public List<Vector2> Nodes = new List<Vector2>();
    public GameObject Node;
    public GameObject Player;
    public GameObject Bullet;
    public Rigidbody PlayerRB;
    public Rigidbody NodeRB;

    private Vector3 PlayerPos = new Vector3(0, -0.0001f, 0);
    private Vector3 NewNodePos = new Vector3(-4, 0.0001f, 8);
    private Vector3 BulletPos;
    private float positionScaler = 4;
    private int xCounter = 0;
    private int BulletPositionChoice;
    #endregion

    public List<Vector2> GenGraph()
    {
        if (Graph.x >= 3 || Graph.y >= 3)
        {
            xCounter = 0;
        }

        else
        {
            while (Graph.x != xCounter)
            {
                Nodes.Add(Graph);
            }
            while (Graph.x == xCounter)
            {
                Nodes.Add(Graph);
                Graph.y++;
                NewNodePos -= new Vector3(0, 0, 1) * positionScaler;
                Instantiate(Node).transform.position = NewNodePos;
                Debug.Log("Added Node at: " + NewNodePos.ToString());
                if (Graph.y >= 3)
                {

                    NewNodePos.x += 1 * positionScaler;
                    NewNodePos.z = 8;
                    Graph.y = 0;
                    Graph.x++;
                    xCounter++;
                    GenGraph();
                }
            }
        }
        return Nodes;
    }

    public void CreatePlayer()
    {
        Instantiate(Player).transform.position = PlayerPos;
        Debug.Log("Added Player at: " + PlayerPos.ToString());
    }

    public List<Vector3> CreateObstacles()
    {
        #region Lots of position setting w/ random values
        BulletPositionChoice = Random.Range(0, 5);
        Debug.Log("Current Number for Bullet is: " + BulletPositionChoice.ToString());
        if(BulletPositionChoice == 0)
        {
            BulletPos = new Vector3(25, 1, -3.8f);
            Instantiate(Bullet).transform.position = BulletPos;
        }
        if (BulletPositionChoice == 1)
        {
            BulletPos = new Vector3(25, 1, -1.8f);
            Instantiate(Bullet).transform.position = BulletPos;
        }
        if (BulletPositionChoice == 2)
        {
            BulletPos = new Vector3(25, 1, 0);
            Instantiate(Bullet).transform.position = BulletPos;
        }
        if (BulletPositionChoice == 3)
        {
            BulletPos = new Vector3(25, 1, 1.8f);
            Instantiate(Bullet).transform.position = BulletPos;
        }
        if (BulletPositionChoice == 4)
        {
            BulletPos = new Vector3(25, 1, 3.8f);
            Instantiate(Bullet).transform.position = BulletPos;
        }
        #endregion
        return null;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Node"))
        {
            other.gameObject.SetActive(false);
        }
    }

    void Start()
    {
        CreatePlayer();
        GenGraph();
    }

    void Update()
    {
        CreateObstacles();
    }

}