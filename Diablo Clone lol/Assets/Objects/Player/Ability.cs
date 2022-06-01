using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    public string[] EquipedAbbs = new string[4];
    bool cancelAttack = false;
    string curAttack = "";
    // Start is called before the first frame update
    void Start()
    {
        EquipedAbbs[0] ="one";
        EquipedAbbs[1] ="two";
        EquipedAbbs[2] ="three";
        EquipedAbbs[3] ="four";
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetButtonUp("CncAtck")) cancelAttack = true;
            else if (Input.GetButton("Abb1"))curAttack = EquipedAbbs[0];
            else if (Input.GetButton("Abb2"))curAttack = EquipedAbbs[1];
            else if (Input.GetButton("Abb3"))curAttack = EquipedAbbs[2];
            else if (Input.GetButton("Abb4"))curAttack = EquipedAbbs[3];
            else abilityExecution();
            abilityPreparation();
    }
    #region Execution and Preparation Functions
    void abilityPreparation(){
        if (curAttack != "")
        {
            if (!cancelAttack)
            {
                switch (curAttack){
                    case "one": Abilities.testingAbb1(); break;
                    case "two": Abilities.testingAbb2(); break;
                    case "three": Abilities.testingAbb3(); break;
                    case "four": Abilities.testingAbb4(); break;
                }
            }
        }
    }
    void abilityExecution(){
        if (curAttack != "")
        {
            if (!cancelAttack)
            {
                Debug.Log("Execution");
                curAttack = "";
                cancelAttack = false;
            }
            else
            {
                curAttack = "";
                cancelAttack = false;
            }
           
        }
    }  
    #endregion 
}
#region Ability Functions
static class Abilities {
    public static void testingAbb1(){
        Debug.Log("Test 1");
    }
    public static void testingAbb2(){
        Debug.Log("Test 2");
    }
    public static void testingAbb3(){
        Debug.Log("Test 3");
    }
    public static void testingAbb4(){
        Debug.Log("Test 4");
    }
}
#endregion

