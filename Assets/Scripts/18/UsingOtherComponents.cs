using System.Collections;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    // Start is called before the first frame update
    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();//getcompnent 很吃資源要儘量再 awake 和start利用避免不必要的重複調用
    }
    void Start()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is"+ anotherScript.playerScore);
        Debug.Log("The player has died"+yetAnotherScript .numberOfPlayerDeaths+"times");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
