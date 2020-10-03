using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Country : MonoBehaviour
{

    public List<Territory> territories;
    public List<State> states;

    public King king;
    public King heir;

    //Powers
    public int adminPower;
    public int diploPower;
    public int militPower;
    
    //Culture
    public List<Culture> acceptedCultures;
    public List<Culture> rejectedCultures;

    //Technology
    public int adminTechLevel;
    public int diploTechLevel;
    public int militTechLevel;

    public float warExh;


    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
