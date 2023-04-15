using UnityEngine;

public class btnURL : MonoBehaviour
{
    public string url;
   
    public void open(){
        Application.OpenURL(url);
    }
}
