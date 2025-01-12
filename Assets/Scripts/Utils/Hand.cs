using System;
using UnityEngine;

[Serializable]
public class Hand
{
    [SerializeField] private Transform handRoot;
    [SerializeField] private GameObject handUpObject;

    public GameObject HandUpObject => handUpObject;

    public MSKim.HandAble.IngredientController GetHandUpIngredient()
    {
        if(handUpObject.TryGetComponent<MSKim.HandAble.IngredientController>(out var ingredient))
        {
            return ingredient;
        }
        return null;
    }

    public void ClearHand() => handUpObject = null;

    public void GetHandDown(Transform downTransform, Vector3 downPosition)
    {
        handUpObject.transform.SetParent(downTransform);
        handUpObject.transform.localPosition = downPosition;
        ClearHand();
    }

    public void GetHandUp(GameObject target)
    {
        SetHandUpObject(target);
        GetHandUp();
    }

    public void SetHandUpObject(GameObject target)
    {
        if (target == null) return;

        handUpObject = target;
    }

    public void GetHandUp()
    {
        if (handUpObject == null) return;

        handUpObject.transform.SetParent(handRoot);
        handUpObject.transform.localPosition = Vector3.zero;
    }
}
