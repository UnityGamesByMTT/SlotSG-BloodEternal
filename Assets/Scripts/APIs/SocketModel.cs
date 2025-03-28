using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using JetBrains.Annotations;

public class SocketModel 
{

    public PlayerData playerData;
    public UIData uIData;

    public InitGameData initGameData;

    public ResultGameData resultGameData;

    public GambleData gambleData;
    public int currentBetIndex=0;

        internal SocketModel(){
        this.playerData= new PlayerData();
        this.uIData= new UIData();
        this.initGameData= new InitGameData();
        this.resultGameData= new ResultGameData();
        this.gambleData=new GambleData();
    }

}



[Serializable]
public class ResultGameData
{
    public List<List<int>> ResultReel { get; set; }
    public List<int> linesToEmit { get; set; }
    public List<List<string>> symbolsToEmit { get; set; }
    public bool isFreeSpin {get; set;}
    public List<string> vampHuman {get; set;}

    public List<string> bloodSplash {get; set;}

    public List<string> batPositions {get; set;}
    // public freeSpin freeSpin{get; set;}
    public int count {get; set;}
    // public int freeSpinCount { get; set; }
    public double jackpot { get; set; }
}


[Serializable]
public class InitGameData
{
    // public List<List<int>> Lines { get; set; }
    public List<double> Bets { get; set; }
    public bool canSwitchLines { get; set; }
    public List<int> LinesCount { get; set; }
    public List<List<int>> lineData {get; set;}
    public double freeSpinCount{get; set;}
}


[Serializable]
public class UIData
{
    public List<Symbol> symbols { get; set; }
        public List<double> BatsMultiplier {get; set;}

    public List<double> wildMultiplier {get; set;}
}

[Serializable]
public class freeSpin{



}

[Serializable]
public class BetData
{
    public double currentBet;
    public double currentLines;
    public double spins;
    //public double TotalLines;
}

[Serializable]
public class AuthData
{
    public string GameID;
    //public double TotalLines;
}

[Serializable]
public class MessageData
{
    public BetData data;
    public string id;
}

[Serializable]
public class InitData
{
    public AuthData Data;
    public string id;
}

[Serializable]
public class AbtLogo
{
    public string logoSprite { get; set; }
    public string link { get; set; }
}



[Serializable]
public class Symbol
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<List<int>> Multiplier { get; set;}
    public object defaultAmount { get; set; }
    public object symbolsCount { get; set; }
    public object increaseValue { get; set; }
    public object description { get; set; }
    public int freeSpin { get; set; }
}

[Serializable]

public class GambleData{

    public bool playerWon{get; set;}
    public double currentWinning{get; set;}
    public string coin{get; set;}
    public double balance{get; set;}

}


[Serializable]
public class PlayerData
{
    public double Balance { get; set; }
    public double haveWon { get; set; }
    public double currentWining { get; set; }
}

[Serializable]
public class AuthTokenData
{
    public string cookie;
    public string socketURL;
    public string nameSpace;
}
