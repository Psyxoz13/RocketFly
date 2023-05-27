using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : Generator
{
    protected override GameObject Generate()
    {
        return _objectPool.GetObject();
    }
}
