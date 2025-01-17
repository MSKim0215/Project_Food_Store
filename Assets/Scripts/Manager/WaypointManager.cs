using System;
using System.Collections.Generic;
using UnityEngine;

namespace MSKim.Manager
{
    public class WaypointManager : MonoBehaviour 
    {
        [Serializable]
        private class WayPointInfo
        {
            public Utils.WaypointType type;
            public List<Transform> pointList = new();
        }

        private static WaypointManager instance;

        public static WaypointManager Instance
        {
            get
            {
                if (instance == null) instance = new();
                return instance;
            }
        }

        [Header("Guest Waypoint Settings")]
        [SerializeField] private List<WayPointInfo> waypointInfoList = new();

        private readonly Dictionary<Utils.WaypointType, List<Transform>> waypointDict = new();

        private void Awake()
        {
            if(instance != null)
            {
                Destroy(gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(gameObject);

            Initailize();
        }

        private void Initailize()
        {
            foreach(var waypoint in waypointInfoList)
            {
                waypointDict.Add(waypoint.type, waypoint.pointList);
            }
        }

        public Vector3 GetCurrentWaypoint(Utils.WaypointType targetType, int currentIndex)
        {
            return waypointDict[targetType][currentIndex].position;
        }

        public int GetCurrentWaypointMaxIndex(Utils.WaypointType targetType)
        {
            return waypointDict[targetType].Count;
        }
    }
}