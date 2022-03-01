using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler {
	private RectTransform tranformacijuLogs;
	public Canvas kanva;

	private void Awake(){
		tranformacijuLogs = GetComponent<RectTransform>();
	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais klikšķis uz pārvietojumšā objekta!");
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Objekts tiek pārvietots!");
		tranformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsākta obejekta pārvietošana");
	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Pabeigta objekta pārvietošana!");
	}
}
