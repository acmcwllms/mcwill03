using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Dropdown CarSpeed;
    public Dropdown SpawnSpeed;
    public Dropdown FrogSize;
    public Dropdown CarSize;

    static public float carSpeed = 20f;
    static public float spawnSpeed = 20f;
    static public float frogSize = 1f;
    static public float carSize = 1f;

    private void Update()
    {
        switch(CarSpeed.value)
        {
            case 1:
                carSpeed = 1f;
                break;
            case 2:
                carSpeed = 5f;
                break;
            case 3:
                carSpeed = 7f;
                break;
            default:
                carSpeed = 1f;
                break;
        }
        switch(SpawnSpeed.value)
        {
            case 1:
                spawnSpeed = 20f;
                break;
            case 2:
                spawnSpeed = 50f;
                break;
            case 3:
                spawnSpeed = 75f;
                break;
            default:
                spawnSpeed = 20f;
                break;
        }
        switch(FrogSize.value)
        {
            case 1:
                frogSize = .5f;
                break;
            case 2:
                frogSize = .75f;
                break;
            case 3:
                frogSize = 1f;
                break;
            default:
                frogSize = .5f;
                break;
        }
        switch(CarSize.value)
        {
            case 1:
                carSize = .5f;
                break;
            case 2:
                carSize = .75f;
                break;
            case 3:
                carSize = 1f;
                break;
            default:
                carSize = .5f;
                break;
        }
    }


}
