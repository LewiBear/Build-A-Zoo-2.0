﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelEditor
{

    //Class to describe and assign values for every object (place on all manipulatable objects)
    public class Ground_Object : MonoBehaviour
    {

        public string obj_Id;
        public int gridPosX;
        public int gridPosZ;
        public GameObject modelVisualization;
        public Vector3 worldPositionOffset;
        public Vector3 worldRotation;
        public bool isWater;
     
        public float rotateDegrees = 0;

        public float price = 0;

        public void UpdateNode(Node[,] grid)
        {
            Node node = grid[gridPosX, gridPosZ];

            Vector3 worldPosition = node.vis.transform.position;
            worldPosition += worldPositionOffset;
            transform.rotation = Quaternion.Euler(worldRotation);
            transform.position = worldPosition;
        }

        public void ChangeRotation()
        {
            Vector3 eulerAngles = transform.eulerAngles;
            eulerAngles += new Vector3(0, rotateDegrees, 0);
            transform.localRotation = Quaternion.Euler(eulerAngles);
        }

        //save level remnants
        public SaveableLevelObjects GetSaveableObject()
        {
            SaveableLevelObjects savedGround = new SaveableLevelObjects();
            savedGround.obj_Id = obj_Id;
            savedGround.posX = gridPosX;
            savedGround.posZ = gridPosZ;

            worldRotation = transform.localEulerAngles;

            savedGround.rotX = worldRotation.x;
            savedGround.rotY = worldRotation.y;
            savedGround.rotZ = worldRotation.z;
            // savedObj.isWallObject = isWallObject;
            // savedObj.isStackable = isStackableObj;

            return savedGround;
        }
    }

    [System.Serializable]
    public class SaveableLevelObjects
    {
        public string obj_Id;
        public int posX;
        public int posZ;

        public float rotX;
        public float rotY;
        public float rotZ;

        // public bool isWallObject = false;
        // public bool isStackable = false;
    }
}
