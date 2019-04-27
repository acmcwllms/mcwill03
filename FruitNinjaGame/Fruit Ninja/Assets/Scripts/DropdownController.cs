using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    public Dropdown SpawnDropDown;
    public static float SpawnSpeed;
    public Dropdown SpeedDropDown;
    public static float FruitSpeed;
    public Dropdown GravityDropDown;
    public static float Gravity;
    public Dropdown TimeDropDown;
    public static float TimeLimit;

    public void Choices()
    {
        switch(SpawnDropDown.value)
        {
            case 1:
                SpawnSpeed = 1f;
                break;
            case 2:
                SpawnSpeed = 3f;
                break;
            default:
                SpawnSpeed = .5f;
                break;
        }

        switch (SpeedDropDown.value)
        {
            case 1:
                FruitSpeed = 1f;
                break;
            case 2:
                FruitSpeed = 3f;
                break;
            default:
                FruitSpeed = .5f;
                break;
        }

        switch (GravityDropDown.value)
        {
            case 1:
                Gravity = 1f;
                break;
            case 2:
                Gravity = 3f;
                break;
            default:
                Gravity = .5f;
                break;
        }

        switch (TimeDropDown.value)
        {
            case 1:
                TimeLimit = 15f;
                break;
            case 2:
                TimeLimit = 30f;
                break;
            default:
                TimeLimit = 10f;
                break;
        }
    }

}
