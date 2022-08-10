using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slingshot : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public Player player;
    public Line line;
    private Vector2 startPos;
    private Vector2 direction;
    private float distance;

    public void OnPointerDown (PointerEventData eventData)
    {
        startPos = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 directionRaw = eventData.position - startPos;
        direction = directionRaw.normalized;
        distance = directionRaw.magnitude;

        if (distance >= Screen.width/2)
        {
            distance = 1;
        }
        else
        {
            distance = distance / (Screen.width/2);
        }
        
        if (direction.y <= 0f)
        {
            line.Navigate();
        }
        else
        {
            line.Hide();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        line.Hide();
        if (direction.y <= 0f)
            player.Push();
        distance = 0;
    }
    public float GetDirection()
    {
            if (direction.x > 0f)
            {
                return -Vector2.Angle(direction, new Vector2(0f, -1f));
            }
            else
            {
                return Vector2.Angle(direction, new Vector2(0f, -1f));
            } 
    }

    public float GetDistance()
    {
        return distance;
    }
}
