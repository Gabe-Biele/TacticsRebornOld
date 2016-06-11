﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.GameLobby
{
    public class GameManager
    {
        GameLobbyManager ourGLM;

        public GameManager(GameLobbyManager gLM)
        {
            ourGLM = gLM;
        }

        public void drawHexGrid(int maxHeight)
        {

            float xPos = 0;
            float yPos = 0;
            for(int y = 0; y < maxHeight; y++)
            {
                //Determine the shift
                if(y % 2 != 0) xPos = 0.866f;
                else xPos = 0;

                for(int x = 0; x < 12; x++)
                {
                    GameObject aDumHex = ourGLM.createObject("hexagon");
                    aDumHex.transform.localPosition = new Vector3(xPos, 0, yPos);
                    aDumHex.transform.SetParent(GameObject.Find("HexGrid").transform);
                    aDumHex.name = "Hex " + x + "-" + y;

                    xPos += 1.73f;
                }
                yPos += 1.5f;
            }
        }
    }
}
