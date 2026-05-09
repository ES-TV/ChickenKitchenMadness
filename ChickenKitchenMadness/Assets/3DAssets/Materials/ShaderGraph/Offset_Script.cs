using UnityEngine;

public enum ChickenType
{
    ChickenFer, 
    ChickenJuan, 
    ChickenJP,
    ChickenBrian
}

public class Offset_Script : MonoBehaviour
{
    public ChickenType chickenType;
    public Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    void Start()
    {
       switch (chickenType){
            case ChickenType.ChickenFer:
                rend.material.SetVector ("_Offset", new Vector2(0, 0));
                break;
            case ChickenType.ChickenJuan:
                rend.material.SetVector ("_Offset", new Vector2(0.5f, 0));
                break;
            case ChickenType.ChickenJP:
                rend.material.SetVector ("_Offset", new Vector2(0, 0.5f));
                break;
            case ChickenType.ChickenBrian:
                rend.material.SetVector ("_Offset", new Vector2(0.5f, 0.5f));
                break;
        }
    }

}
