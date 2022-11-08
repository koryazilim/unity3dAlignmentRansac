using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ApplyRansac : MonoBehaviour
{
    
     public void ShowPointClouds2(){


        List<Point> file1 = GetPointClouds2(); //new List<Point>();

         List<GameObject> objList = new List<GameObject>();

        for( int i=0;i<file1.Count;i++){
            objList.Add(GameObject.CreatePrimitive(PrimitiveType.Sphere));
            objList[i].transform.position = new Vector3(file1[i].x,file1[i].y,file1[i].z);
            
            objList[i].GetComponent<Renderer>().material.SetColor("_Color",Color.blue);

        }

    }
 
 
 // TODO: Read File
    public List<Point> GetPointClouds2(){

        List<Point> file2 = new List<Point>();

        // Random rand = new Random();

        for (int i=0;i<100;i++){

            float xPos = (float) i/5 - 10;
            float yPos = (float) i/10;
            file2.Add(new Point(){x = UnityEngine.Random.Range(xPos, xPos+3), y=UnityEngine.Random.Range(yPos, yPos+3), z = UnityEngine.Random.Range(-3.0f, 3.0f)});
        } 

        return file2;

    }
  
    public class Point{
        public float x;
        public float y;
        public float z;
    }

    bool comparePoints(Point A, Point B, double treshold){
        if ( getDistance(A,B) < treshold ){
            return true;
        }
        return false;
    }

    public static double getDistance(Point A, Point B){
        return Math.Sqrt(System.Math.Pow(A.x-B.x,2)+Math.Pow(A.y-B.y,2)+Math.Pow(A.z-B.z,2));
    }

    public void checkAllPoints( ){

        List<Point> file1 = new List<Point>();

        file1.Add(new Point(){x = 10, y=12, z = 17});
        file1.Add(new Point(){x = 14, y=19, z = 10});
        file1.Add(new Point(){x = 18, y=12, z = 11});
        file1.Add(new Point(){x = 19, y=18, z = 13});
        file1.Add(new Point(){x = 13, y=13, z = 16});
        file1.Add(new Point(){x = 11, y=14, z = 18});
        

        List<Point> file2 = new List<Point>();

        file2.Add(new Point(){x = 10, y=12, z = 17});
        file2.Add(new Point(){x = 9,  y=9,  z = 9});
        file2.Add(new Point(){x = 18, y=12, z = 11});
        file2.Add(new Point(){x = 19, y=18, z = 13});
        file2.Add(new Point(){x = 9,  y=9,  z = 9});
        file2.Add(new Point(){x = 11, y=14, z = 18});
        

        for(int i=0;i<file1.Count-2;i++){
            for(int j = i+1; j<file1.Count-1;j++){
                for(int k=j+1;k<file1.Count;k++){

                    // ---

                }
            }
        }
        }
}
