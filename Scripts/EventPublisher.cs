using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            EventBus.TriggerEvent("Shoot");
        }

        if (Input.GetKeyDown("l"))
        {
            EventBus.TriggerEvent("Launch");
        }

        if(Input.GetKeyDown("e"))
        {
            EventBus.TriggerEvent("Motto");
        }

        if(Input.GetKeyDown("p"))
        {
            EventBus.TriggerEvent("Play");
        }

        if(Input.GetKeyDown("s"))
        {
            EventBus.TriggerEvent("Stop");
        }

        if(Input.GetKeyDown("r"))
        {
            EventBus.TriggerEvent("LetsGetAtEr");
        }
    }
}