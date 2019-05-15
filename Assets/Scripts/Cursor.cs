using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    List<Entity> entities;
    int entityIndex;
    Vector3 positionOffset = new Vector3(1, 0, 0);


    private void Awake() {
        entities = new List<Entity>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Move(1); 
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Move(-1);
        }
    }

    public void Add(Entity entity) {
        entities.Add(entity);
        if (entities.Count == 1) {
            //gameObject.SetActive(true);
            entityIndex = entities.IndexOf(entity);
            entity.Select();
            transform.position = entity.Position + positionOffset;
        }
    }

    public void Remove(Entity entity) {
        entities.Remove(entity);
        //if (entities.Count == 0) {
        //    gameObject.SetActive(false);
        //}
    }

    public void Reset() {
        entities.Clear();
    }

    void Move(int offset) {
        entities[entityIndex].Deselect();
        entityIndex = entityIndex + offset;
        int length = entities.Count;
        if (entityIndex >= length) { entityIndex -= length; }
        else if (entityIndex < 0) { entityIndex += length; }
        entities[entityIndex].Select();
        transform.position = entities[entityIndex].Position + positionOffset;
    }
}
