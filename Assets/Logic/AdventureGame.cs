using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

	public void Start ()
	{
	    state = startingState;
	    textComponent.text = state.GetStateStory();
	}

	public void Update ()
	{
	    ManageStates();
	}

    public void ManageStates()
    {
        var nextStates = state.GetNextStates();

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
                state = nextStates[i];
        }

        textComponent.text = state.GetStateStory();
    }
}
