using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScript : MonoBehaviour
{
    public GameObject aTextBox;
    public GameObject TextBox;
    public GameObject Choice1;
    public GameObject Choice2;


    public float timer = 1;
    public bool up = false;

    public int ChoiceMode = 0;
    public int questionNum = 0;
    public int followup = 0;

    public void Awake()
    {
       
            if (questionNum == 0)
            {
                TextBox.GetComponent<Text>().text = "You’ve come a long way from(show) with (main character of the show), how has your relationship been going?";
                Choice1.GetComponentInChildren<Text>().text = "Fine! We are actually getting lunch.";
                Choice2.GetComponentInChildren<Text>().text = "We haven’t really spoken since.";
            }
            if (questionNum == 1)
            {

                TextBox.GetComponent<Text>().text = "Now that you’re a supporting actress, how has your life changed?";
                Choice1.GetComponentInChildren<Text>().text = "I don’t really see a difference in my life. I am just tried to learn from [director] as much as I could.";
                Choice2.GetComponentInChildren<Text>().text = "[director] has helped me get my start in this business, but it feels like he’s trying to take over every aspect of my life. It’s like I have to dress, eat, and act according to him.";
            }
            if (questionNum == 2)
            {

                TextBox.GetComponent<Text>().text = "Your career has really blossomed since you were cast as a recurring character on the show. It seems you and the producer are close. Can you speak about your friendship?";
                Choice1.GetComponentInChildren<Text>().text = "My friendship with [producer] is no secret. He’s amazing, really. A true visionary and I am glad to have worked to closely with him.";
                Choice2.GetComponentInChildren<Text>().text = "I don’t like to comment on any of my relationships.";
            }
            if (questionNum == 3)
            {

                TextBox.GetComponent<Text>().text = "An insider source told us that Mr. Mostawaloskawitz has taken advantage of you on multiple occasions. Is this true?";
                Choice1.GetComponentInChildren<Text>().text = "There are a lot of people in high positions who abuse their power. He is no different. I only hope he gets the justice he deserves.";
                Choice2.GetComponentInChildren<Text>().text = "*Is shocked by the question* I am unable to speak about this situation at this time.";
            }
            if (questionNum == 4)
            {

                TextBox.GetComponent<Text>().text = "Miss! Miss! First you said the producer put himself on you first before you started filming then later on the Daily Show you confessed it began the night after the Emmys last year -- so what is the truth?";
                Choice1.GetComponentInChildren<Text>().text = "The truth is that I have suffered. I have suffered so much trauma because of this situation. ";
                Choice2.GetComponentInChildren<Text>().text = "*Stutters and mumbles, and feel overwhelmed by the lights and flashing cameras* Leave me alone.";

            }
        

    }



    // Use this for initialization
    //public void Start()
    //{
    //    up = false;
    //    aTextBox.SetActive(up);
    //    followup = 0;
    //    questionNum = 0;
    //    //aTextBox.SetActive(false);
    //    //currEnergy = currHealth = 100;
    //    timer = 1f;
    //}

    //first response react
    public void ChoiceOpt1()
    {
        ChoiceMode = 1;
        followup += ChoiceMode;
        if (questionNum == 0)
        {
            HealthBar.Instance.currRep += 10;
            TextBox.GetComponent<Text>().text = "You know I never realized it, but you look like his ex-wife. Do you think that affected your relationship?";
            Choice1.GetComponentInChildren<Text>().text = "Huh, I never thought about that. I don’t think I look like her. ";
            Choice2.GetComponentInChildren<Text>().text = "Maybe! I don’t think that’s why we’re dating though.";
            HealthBar.Instance.currEnergy -= 10;
            HealthBar.Instance.currRep += 10;
        }
        if (questionNum == 1)
        {
            TextBox.GetComponent<Text>().text = "Are you still on good terms with the director?";
            Choice1.GetComponentInChildren<Text>().text = "We talk from time to time. I always have to check back with people who helped to launch my career.";
            Choice2.GetComponentInChildren<Text>().text = "We haven't really spoken since the spending so much time with the movie.";
            HealthBar.Instance.currRep += 10;
        }
        if (questionNum == 2)
        {

            TextBox.GetComponent<Text>().text = "Do you think your relationship is too close? That seems to be a pattern with you. Always getting close with someone working on the same project as you.";
            Choice1.GetComponentInChildren<Text>().text = "I think that anyone who really wants to succeed in this business needs to be open to learning from the best. Actors, directors and producers included.";
            Choice2.GetComponentInChildren<Text>().text = "It really hurts when low life paparazzi have nothing to do but to harrass you and prey on your achievements.";
            HealthBar.Instance.currRep += 10;
        }
        if (questionNum == 3)
        {

            TextBox.GetComponent<Text>().text = "What made you speak your truth about [producer] today?";
            Choice1.GetComponentInChildren<Text>().text = "As someone in the public I have a duty to bring light to be who spew out darkness.";
            Choice2.GetComponentInChildren<Text>().text = "People like that make victims feel like shit are the scum of the earth.";
            HealthBar.Instance.currRep -= 10;
            HealthBar.Instance.currEnergy += 10;
        }
        if (questionNum == 4)
        {

            TextBox.GetComponent<Text>().text = "But, when did it happen? You never answered.";
            Choice1.GetComponentInChildren<Text>().text = "It should have never happened. Period. ";
            Choice2.GetComponentInChildren<Text>().text = "I I-I can’t remember.";
            HealthBar.Instance.currRep -= 10;

        }
    }

    public void ChoiceOpt2()
    {
        ChoiceMode = 2;
        followup += ChoiceMode;
        if (questionNum == 0)
        {
            //question 0 - 2
            TextBox.GetComponent<Text>().text = "What about your relationship with the director of the show?";
            Choice1.GetComponentInChildren<Text>().text = "I think it’s fine. I haven’t really talked to him, though.";
            Choice2.GetComponentInChildren<Text>().text = "Oh it’s … fine!";
            HealthBar.Instance.currRep -= 10;
        }
        if (questionNum == 1)
        {
            TextBox.GetComponent<Text>().text = "We know you know the director well, but have you ever spoken to the producer? Has he ever overstepped his bounds?";
            Choice1.GetComponentInChildren<Text>().text = "I spoken to him a few times. He’s kind of been this helping hand whenever [director] steps out of his bounds.";
            Choice2.GetComponentInChildren<Text>().text = "Your response seems a bit out of bounds, don’t you think?";
            HealthBar.Instance.currRep -= 10;
        }
        if (questionNum == 2)
        {

            TextBox.GetComponent<Text>().text = "Really? You’ve been quite open in the past. In fact, every time you come into headlines you’re linked to a big name.";
            Choice1.GetComponentInChildren<Text>().text = "My fame is solely the result of my dedication to the craft. Shouldn’t you be questioning why big names are so interested in me.";
            Choice2.GetComponentInChildren<Text>().text = "No comment.";
            HealthBar.Instance.currRep -= 10;
        }
        if (questionNum == 3)
        {

            TextBox.GetComponent<Text>().text = "Wait, why is that? It’s a simple yes or no question.Does this mean the rumors aren’t true?";
            Choice1.GetComponentInChildren<Text>().text = "It means its is my business and my business only.";
            Choice2.GetComponentInChildren<Text>().text = "It means you know nothing about the situation or what I’m going through right now.";
            HealthBar.Instance.currRep -= 10;
        }
        if (questionNum == 4)
        {

            TextBox.GetComponent<Text>().text = "For someone who was so eloquent at destroying [producer] with such allegations, you can’t seem to recount when it actually happened.";
            Choice1.GetComponentInChildren<Text>().text = "I’m trying to heal. ";
            Choice2.GetComponentInChildren<Text>().text = "Let’s focus on the Oscars.";
            HealthBar.Instance.currRep -= 10;

        }

    }

    // Update is called once per frame
    void Update()
    {
        //aTextBox.SetActive(up);

        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            if(up == true)
            {
                up = false;
            } else
            {
                up = true;
            }
            timer = 0;
            //aTextBox.SetActive(!aTextBox.activeSelf);
            aTextBox.gameObject.GetComponent<Image>().enabled = false;
            Awake();
        }

        if (followup > 3)
        {
            //aTextBox.SetActive(false);

            followup = 0;
            questionNum++;
            up = false;
            if( questionNum == 5)
            {
                aTextBox.SetActive(false);
            }
            
        }

    }


}
