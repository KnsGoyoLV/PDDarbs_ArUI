using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Move_Stuff : MonoBehaviour, IPointerDownHandler, IDragHandler,IBeginDragHandler,IEndDragHandler {
	private RectTransform transformation;
	public Canvas Kanva;

	private void Awake()
    {
		transformation = GetComponent<RectTransform>();
    }

	public void OnPointerDown(PointerEventData notikums)
    {
		Debug.Log("Left Click on a object");
    }
	public void OnDrag(PointerEventData notikums)
    {
		Debug.Log("Object is moving!");

		transformation.anchoredPosition += notikums.delta / Kanva.scaleFactor;
    }

	public void OnBeginDrag(PointerEventData notikums)
    {
		Debug.Log("Start Object Move!");
    }
	public void OnEndDrag(PointerEventData notikums)
    {
		Debug.Log("Object move Done!");
    }
}
