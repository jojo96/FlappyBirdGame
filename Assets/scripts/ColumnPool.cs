using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
	
	public int columnPoolSize = 5;
	public GameObject columnPrefab;
	
	private GameObject[] columns;
	public float spr = 4f;	
	private Vector2 obPos = new Vector2(-15f,-25f);
	private float tsls;
	private float xsp = 10f;
	public float columnMin = -1f;
	public float columnMax = 3.5f;
	private int curc = 0;
	
    // Start is called before the first frame update
    void Start()
    {
     columns = new GameObject[columnPoolSize];
	 for(int i = 0; i < columnPoolSize; i++){
		 columns[i] = (GameObject)Instantiate(columnPrefab, obPos, Quaternion.identity);
	 }
    }

    // Update is called once per frame
    void Update()
    {
        tsls += Time.deltaTime;
		if(GameControl.instance.gameOver==false && tsls>=spr){
			tsls = 0;
			float syp = Random.Range(columnMin,columnMax);
			columns[curc].transform.position = new Vector2(xsp,syp);
			curc++;
			if (curc>=columnPoolSize)
				curc = 0;
		}
    }
}
