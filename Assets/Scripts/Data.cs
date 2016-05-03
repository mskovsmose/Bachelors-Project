﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Data : MonoBehaviour {

    public static string ParticipantsName { get; set; }
    public static float InitialSceneTime { get; set; }
    public static float TotalTime { get; set; }
    public static int Progression { get; set; }
    public static List<string> Scenes = new List<string>();

    public static List<Scenario> scenario_1 = new List<Scenario>();
    public static List<Scenario> scenario_2 = new List<Scenario>();

    public static List<Achievement> achievements = new List<Achievement>();

    // Variables for achievements
    public static bool[] LearnCPRVisited { get; set; }

    public static Achievement ach1;
    public static Achievement ach2;
    public static Achievement ach3;
    public static Achievement ach4;
    public static Achievement ach5;
    public static Achievement ach6;
    public static Achievement ach7;

    public static void InitializeAchievements()
    {
        ach1 = new Achievement { Name = "Du har gennemført et scenarie !", isUnlocked = false };
        ach2 = new Achievement { Name = "Du har gennemført to scenarier !", isUnlocked = false };
        ach3 = new Achievement { Name = "Nysgerrig", isUnlocked = false };
        ach4 = new Achievement { Name = "50% - Som Bon Jovi sagde \"Whoa, we're half way there. \" ", isUnlocked = false };
        ach5 = new Achievement { Name = "100% - Det er sku imponerende !", isUnlocked = false };
        ach6 = new Achievement { Name = "Du burde overvejer et job som livredder !", isUnlocked = false };
        ach7 = new Achievement { Name = "Du svarede ikke forkert en eneste gang !", isUnlocked = false };

        achievements.Add(ach1);
        achievements.Add(ach2);
        achievements.Add(ach3);
        achievements.Add(ach4);
        achievements.Add(ach5);
        achievements.Add(ach6);
        achievements.Add(ach7);

    }

    public static Scenario ScenarioWithMostStars(int scenarioNumber)
    {
        Scenario s = new Scenario();
        int tempStars = 0;

        if (scenarioNumber == 1)
        {
            for (int i = 0; i < scenario_1.Count; i++)
            {
                if (scenario_1[i].Stars > tempStars)
                {
                    s = scenario_1[i];
                }
            }
        }

        if(scenarioNumber == 2)
        {
            for (int i = 0; i < scenario_2.Count; i++)
            {
                if (scenario_2[i].Stars > tempStars)
                {
                    s = scenario_2[i];
                }
            }
        }

        return s;
    }
}
