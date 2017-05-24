//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Grid : MonoBehaviour
//{

//    public Vector2 Graph;
//    public List<Vector2> Nodes = new List<Vector2>();
//    public Vector2 PlayerVec;
//    public Vector2 goal;
//    public GameObject Node;

//    private Vector3 NewNodePos = new Vector3(-4, 0.0001f, 8);
//    private float positionScaler = 4;
//    private int xCounter = 0;

//    // Creates Graph 
//    void GenGraph()
//    {
//        if (Graph.x >= 3 || Graph.y >= 3)
//        {
//            xCounter = 0;
//        }

//        else
//        {
//            while (Graph.x != xCounter)
//            {
//                Nodes.Add(Graph);
//            }
//            while (Graph.x == xCounter)
//            {
//                Nodes.Add(Graph);
//                Graph.y++;
//                NewNodePos -= new Vector3(0, 0, 1) * positionScaler;
//                Instantiate(Node).transform.position = NewNodePos;
//                if (Graph.y >= 3)
//                {

//                    NewNodePos.x += 1 * positionScaler;
//                    NewNodePos.z = 8;
//                    Graph.y = 0;
//                    Graph.x++;
//                    xCounter++;
//                    GenGraph();
//                }
//            }
//        }
//    }




//    void Start()
//    {
//        GenGraph();
//        //DecideGoal();
//    }

//}