using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcScript : EnemyBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Orc is attacking player");
    }



}
