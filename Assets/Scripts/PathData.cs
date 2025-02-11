﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PathData
{
    /// <summary>
    /// 경로 이름
    /// </summary>
    public string pathName = "noName";

    public string departure;

    public string destination;

    /// <summary>
    /// 자식 오브젝트들의 위치
    /// </summary>
    public List<Vector.SerializableVector3> childPositions = new List<Vector.SerializableVector3>();
    public List<SerializableQuaternion> childRotation = new List<SerializableQuaternion>();

}
