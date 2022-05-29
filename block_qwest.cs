    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseActive == false)
            {
                pausePanel.SetActive(true);
                pauseActive = true;
            }
            else
            {
                pausePanel.SetActive(false);
                pauseActive = false;
            }
        }
        if (debugTggl == 1)
        {
            debugText[0].enabled = true;
            debugText[0].text = " " + wQ.ToString();
            debugText[1].enabled = true;
            debugText[1].text = " " + clickedAnswer.ToString();
            debugText[2].enabled = true;
            debugText[2].text = " " + trueint.ToString();
        }

        timeText.text = timeEq.ToString();
        timeF += Time.deltaTime;
        if (timeF >= 1.2)
        {
            if (clickedAnswer == -1)
            {
                if (pauseActive == false)
                {
                    timeEq--;
                    timeF = 0;
                }
            }
        }
        if (timeEq <= 0)
        {
            timeText.text = " ";
            overTime();
        }
        if (timeEq <= 3)
        {
            timeText.color = Color.red;
        }
        if (wQ == 1)
        {
            RQ1();
        }
        //...
	else if (wQ == 25)
        {
            RQ25();
        }

    }
