﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Remove
{
    private int n;
    private string word;

    public int N
    {
        get { return n; }
        set { n = value; }    
    }

    public string Word
    {
        get { return word; }
        set { word = value; }
    }

    public void removal(string word, int n)
    {
        Console.WriteLine(word.Remove(n, 1));
    }
}

public class Swap
{
    private string word;
    public string Word
    {
        get { return word; }
        set { word = value; }
    }
    //  public string Word
    //  { get; set; }
    public void CharacterSwap(string word)
    {
        Console.WriteLine(word.Length > 1 ? word.Substring(word.Length - 1) + word.Substring(1, word.Length - 2) + word.Substring(0,1) : word);
    }
}

public class wordInt
{
    private string word;
    private int n;

    public string Word
    {
        get { return word; }
        set { word = value; }
    }

    public int N
    {
        get { return n; }
        set { if (value > 0)
            {
                n = value;
            }
            else
            {
                n = 0;
            }
        }
    }

    public void copies()
    {
        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += word;
        }
        Console.WriteLine(result);
    }

}