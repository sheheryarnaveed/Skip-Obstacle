using UnityEngine;
using UnityEngine.UI;
public class ScoreBoard : MonoBehaviour {
    public Transform Robot;
    public Text ScoreBoardText;
    public float robo;
    // Update is called once per frame
    void Update () {
       robo=Robot.position.z + 48;
    ScoreBoardText.text = robo.ToString("0");
	}
}
