using UnityEngine;
using System.Collections;

public class RocketControl : MonoBehaviour {
	public GameObject target;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		float angle2 =Mathf.Rad2Deg*Mathf.Atan ((target.transform.position.y-transform.position.y) / (target.transform.position.x-transform.position.x));
		if(target.transform.position.x<transform.position.x){
			angle2+=180;
		}
		else{

		}
		transform.localEulerAngles=new Vector3(0,0,angle2);


		float angle=0;

		float deltaX=target.transform.position.x-transform.position.x;
		float deltaY=target.transform.position.y-transform.position.y;


		if(deltaX==0){
			if(transform.position.y>=target.transform.position.y)
			{
				deltaX=0.0001f;
			}
			else{
				deltaX=-0.0001f;
			}
		}

		if(deltaY==0){
			if(transform.position.x>=target.transform.position.x)
			{
				deltaY=0.0001f;
			}
			else{
				deltaY=-0.0001f;
			}
		}

		float atan=Mathf.Atan(Mathf.Abs(deltaY/deltaX));
		if(deltaX>0&&deltaY>0){
			angle=atan;
		}
		else if(deltaX<0 &&deltaY>0){
			angle=Mathf.PI-atan;
		}
		else if(deltaX<0&&deltaY<0){
			angle=Mathf.PI+atan;
		}
		else{
			angle=2*Mathf.PI-atan;
		}

		float x=transform.position.x+0.2f*Mathf.Cos(angle);
		float y=transform.position.y+0.2f*Mathf.Sin(angle);
		transform.position=new Vector3(x,y,0);

	}
}
