﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelEditor {
    public class ResourcesManager : MonoBehaviour {

        public List<LevelFoliageBase> LevelFoliageObjects = new List<LevelFoliageBase>();
        public List<LevelCareBase> LevelCareObjects = new List<LevelCareBase>();
        public List<LevelEnrichmentBase> LevelEnrichmentObjects = new List<LevelEnrichmentBase>();
        public List<LevelAnimalBase> LevelAnimalObjects = new List<LevelAnimalBase>();
        public List<LevelFenceBase> LevelFenceObjects = new List<LevelFenceBase>();

        public List<Material> LevelMaterials = new List<Material>();
       

        private static ResourcesManager instance = null;

        void Awake()
        {
            instance = this;
        }

        public static ResourcesManager GetInstance()
        {
            return instance;
        }

        public LevelFoliageBase GetFoliageBase(string foliageId)
        {
            LevelFoliageBase retVal = null;

            for (int i = 0; i < LevelFoliageObjects.Count; i++)
            {
                if (foliageId.Equals(LevelFoliageObjects[i].foliage_id))
                {
                    retVal = LevelFoliageObjects[i];
                    break;
                }
            }

            return retVal;
        }

        public LevelCareBase GetCareBase(string careId)
        {
            LevelCareBase retVal = null;

            for (int i = 0; i < LevelCareObjects.Count; i++)
            {
                if (careId.Equals(LevelCareObjects[i].care_id))
                {
                    retVal = LevelCareObjects[i];
                    break;
                }
            }

            return retVal;
        }

        public LevelEnrichmentBase GetEnrichmentBase(string enrichmentId)
        {
            LevelEnrichmentBase retVal = null;

            for (int i = 0; i < LevelEnrichmentObjects.Count; i++)
            {
                if (enrichmentId.Equals(LevelEnrichmentObjects[i].enrichment_id))
                {
                    retVal = LevelEnrichmentObjects[i];
                    break;
                }
            }

            return retVal;
        }

        public LevelAnimalBase GetAnimalBase(string animalId)
        {
            LevelAnimalBase retVal = null;

            for (int i = 0; i < LevelAnimalObjects.Count; i++)
            {
                if (animalId.Equals(LevelAnimalObjects[i].animal_id))
                {
                    retVal = LevelAnimalObjects[i];
                    break;
                }
            }

            return retVal;
        }

        public LevelFenceBase GetFenceBase(string fenceId)
        {
            LevelFenceBase retVal = null;

            for (int i = 0; i < LevelFenceObjects.Count; i++)
            {
                if (fenceId.Equals(LevelFenceObjects[i].fence_id))
                {
                    retVal = LevelFenceObjects[i];
                    break;
                }
            }

            return retVal;
        }

        public Material GetMaterial(int matId)
        {
            Material retVal = null;

            for (int i = 0; i < LevelMaterials.Count; i++)
            {
                if (matId == i)
                {
                    retVal = LevelMaterials[i];
                    break;
                }
            }
            return retVal;
        }

        public int GetMaterialID(Material mat)
        {
            int id = -1;
            for (int i = 0; i < LevelMaterials.Count; i++)
            {
                if (mat.Equals(LevelMaterials[i]))
                {
                    id = i;
                    break;
                }
            }
            return id;
        }
    }

    
    [System.Serializable]
    public class LevelFoliageBase
    {
        public string foliage_id;
        public GameObject foliagePrefab;
    }
    [System.Serializable]
    public class LevelCareBase
    {
        public string care_id;
        public GameObject carePrefab;
    }
    [System.Serializable]
    public class LevelEnrichmentBase
    {
        public string enrichment_id;
        public GameObject enrichmentPrefab;
    }
    [System.Serializable]
    public class LevelAnimalBase
    {
        public string animal_id;
        public GameObject animalPrefab;
    }
    [System.Serializable]
    public class LevelFenceBase
    {
        public string fence_id;
        public GameObject fencePrefab;
    }
}