using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    //todo maybe: -make a GetTimer method(hard) -make a EndTimer(hard) -make a ResetTimer Method(hard) -Will require multithreading

    static List<string> timerId = new List<string>(); //Each coroutine has an ID associated with it
    public static Timer instance; //to make coroutines possible from a static context, script is required to be on scene

    public void Start()
    {
        instance = this; //to have an instance
    }

    public static bool CheckTimer(string id)//To see if timer with id is in use
    { //example: Timer.CheckTimer("" + gameObject.GetInstanceID())
        return timerId.Contains(id);
    }

    public static bool SetTimer(string id, float time) //check if timer is set, else make one
    { //example: Timer.Setimer("" + gameObject.GetInstanceID(), delay)
        if (timerId.Contains(id)) //checking to see if id is in use
        {
            return false; //did not set timer
        }
        timerId.Add(id); //otherwise add id to list and start coroutine
        IEnumerator coroutine = startTimer(time, id);
        instance.StartCoroutine(coroutine);
        return true;//did set timer
    }

     static IEnumerator startTimer(float time, string targetId)
     {
        yield return new WaitForSeconds(time); //wait 'time' seconds and then remove id
        timerId.Remove(targetId);
    }
}
