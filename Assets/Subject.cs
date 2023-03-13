using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
     private List<IObserver> observers = new List<IObserver>();
     
     public void addObserver(IObserver o){
        observers.Add(o);
     }
     public void removeObserver(IObserver o){
        observers.Remove(o);
     }
     protected void notifyObservers(){
foreach (IObserver item in observers)
{
    item.onNotify();
}
     }
}
