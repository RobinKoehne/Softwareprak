using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];
    private bool isCollided = false;

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        //Collision Work
        boxCollider.OverlapCollider(filter, hits);
        for(int i=0; i<hits.Length; i++)
        {
            if(hits[i] == null)
                continue;
            //Aufruf der OnCollide Methode, damit ausgegeben wird, womit der Player zusammenstößt
            OnCollide(hits[i]);
            hits[i] = null;
        }
    }
    protected virtual void OnCollide(Collider2D coll)
    {
        if(!isCollided)
        { 
        //Zeigt in der Console an, womit wir zusammengestoßen sind
        Debug.Log(coll.name);
        isCollided = true;
        }
    }
}
