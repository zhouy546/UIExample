using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderBase : IRect, IPointerDownHandler,IPointerUpHandler
{
    public bool IsOnClicked;

    protected Slider slider;
	// Use this for initialization
	public void Start () {
        base.Start();

        initialization();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void initialization() {

        slider = this.GetComponent<Slider>();

    }

    public void SetValue(float value) {
        slider.value = value;
    }

   public float  GetValue() {
        return slider.value;
    }


    public virtual void OnPointerDown(PointerEventData eventData)
    {

    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {

    }

    public virtual void OnValueChange() {
    
    }
}
