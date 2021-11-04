using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	this.GetComponent<Button>().onClick.AddListener(OnClick);
        
    }
void OnClick()
{Debug.Log("1111111");
SceneManager.LoadScene("mobilephone");
}
    // Update is called once per frame
    void Update()
    {
        
    }
	
	}
