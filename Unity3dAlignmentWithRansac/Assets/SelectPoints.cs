using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPoints : MonoBehaviour
{


    public class Point{
        public float x;
        public float y;
        public float z;
    }
    // Start is called before the first frame update
    void Start()
    {
        //  GameObject plane  = GameObject.CreatePrimitive(PrimitiveType.Plane);

        // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // cube.transform.position = new Vector3(0, 0.5f, 0);

        // GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        // sphere.transform.position = new Vector3(0, 1.5f, 0);

        // GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        // capsule.transform.position = new Vector3(2, 1, 0);

        // GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        // cylinder.transform.position = new Vector3(-2, 1, 0);

         List<Point> file1 = GetPointClouds1(); //new List<Point>();

         List<GameObject> objList = new List<GameObject>();

        for( int i=0;i<file1.Count;i++){
            objList.Add(GameObject.CreatePrimitive(PrimitiveType.Sphere));
            objList[i].transform.position = new Vector3(file1[i].x,file1[i].y,file1[i].z);
            
            objList[i].GetComponent<Renderer>().material.SetColor("_Color",Color.red);

        }
    }

    // TODO: Read File
    public List<Point> GetPointClouds1(){

        List<Point> file1 = new List<Point>();

        // Random rand = new Random();

        for (int i=0;i<100;i++){

            float xPos = (float) i/5 - 10;
            float yPos = (float) i/10;
            file1.Add(new Point(){x = Random.Range(xPos, xPos+3), y=Random.Range(yPos, yPos+3), z = Random.Range(-3.0f, 3.0f)});
        } 

        // file1.Add(new Point(){x = 10, y=12, z = 17});
        // file1.Add(new Point(){x = 14, y=19, z = 10});
        // file1.Add(new Point(){x = 18, y=12, z = 11});
        // file1.Add(new Point(){x = 19, y=18, z = 13});
        // file1.Add(new Point(){x = 13, y=13, z = 16});
        // file1.Add(new Point(){x = 11, y=14, z = 18});

        return file1;

    }
    
    // TODO: Read File
    public List<Point> GetPointClouds2(){


        List<Point> file2 = new List<Point>();

        for (int i=0;i<100;i++){

            file2.Add(new Point(){x = Random.Range(-10.0f, 10.0f), y=0, z = Random.Range(-10.0f, 10.0f)});
        } 


        return file2;


    }
 
    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
