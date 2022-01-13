using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class endSceneDirector : MonoBehaviour
{

    //������ ���� ���� ����.
    int RegisterR; //���� �� ����.
    int RegisterRM; //���� ���� ����
    int RegisterRNM; //���� ���� ����
    int QuizR; // s���ϸ���
    float CommuteR; //�ð�. ��������
    int MTR; //���� ���� ����, s���ϸ���
    int AlbeitR; //�� ��. 
    string HomeworkR; //�г���
    int ExamR; //�ܿ� �ð�. *2 = �ܿ� ������ �¼�
    string ExamRP; //�غ� ã�� ���� ����

    float finScore = 0;
    int FCount = 0;

    GameObject[] buttons = new GameObject[7];
    public GameObject endButton;
    AudioSource aud;
    public AudioClip goodS;
    public AudioClip badS;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("retry", 0); //0�̸� ������ƴϰ� 1�̸� ������� ���. �� ������ �����ؾ�.

        this.buttons[0] = GameObject.Find("registerF");
        this.buttons[1] = GameObject.Find("quizF");
        this.buttons[2] = GameObject.Find("commuteF");
        this.buttons[3] = GameObject.Find("mtF");
        this.buttons[4] = GameObject.Find("albeitF");
        this.buttons[5] = GameObject.Find("hwF");
        this.buttons[6] = GameObject.Find("examF");

        this.aud = gameObject.GetComponent<AudioSource>();

        for (int i = 0; i < 7; i++)
        {
            this.buttons[i].SetActive(false);
        }
        getSceneResults();
        //this.FCount = 0;
    }



    void getSceneResults()
    {
        this.RegisterR = PlayerPrefs.GetInt("RegisterR");//�̰� ���� ����.
        this.RegisterRM = PlayerPrefs.GetInt("RegisterRM");
        this.RegisterRNM = PlayerPrefs.GetInt("RegisterRNM");
        this.QuizR = PlayerPrefs.GetInt("QuizR");
        this.CommuteR = PlayerPrefs.GetFloat("CommuteR");
        this.MTR = PlayerPrefs.GetInt("MTR");
        this.AlbeitR = PlayerPrefs.GetInt("AlbeitR");
        this.HomeworkR = PlayerPrefs.GetString("HomeworkR");
        this.ExamR = PlayerPrefs.GetInt("ExamR");
        this.ExamRP = PlayerPrefs.GetString("ExamRP");
    }


    string calcRegister()
    {
        if (this.RegisterR >= 12)
            return "P";
        else
            this.buttons[0].SetActive(true);
        return "NP";
    } //���� �ִ� ��� �߰��ؾ� �Ѵ�. 


    string calcQuiz()
    {
        if (this.QuizR >= 70)
        {
            return "A+";
        }
        else if (this.QuizR >= 50 && this.QuizR < 70)
        {
            return "B+";
        }
        else if (this.QuizR >= 30 && this.QuizR < 50)
        {
            this.buttons[1].SetActive(true);
            return "C+";
        }
        else if (this.QuizR >= 10 && this.QuizR < 30)
        {
            this.buttons[1].SetActive(true);
            return "D0";
        }
        else
        {
            this.buttons[1].SetActive(true);
            this.FCount++;
            return "F";
        }


    }



    string calcCommute()
    {
        if (this.CommuteR >= 60)
        {
            return "A+";
        }
        else if (this.CommuteR >= 50 && this.CommuteR < 60)
        {
            return "A0";
        }
        else if (this.CommuteR >= 40 && this.CommuteR < 50)
        {
            return "A-";
        }
        else if (this.CommuteR >= 30 && this.CommuteR < 40)
        {
            return "B+";
        }
        else if (this.CommuteR >= 20 && this.CommuteR < 30)
        {
            return "B0";
        }
        else if (this.CommuteR >= 10 && this.CommuteR < 20)
        {
            this.buttons[2].SetActive(true);
            return "C+";
        }
        else if (this.CommuteR >= 0 && this.CommuteR < 10)
        {
            this.buttons[2].SetActive(true);
            return "C0";
        }
        else
        {
            this.buttons[2].SetActive(true);
            this.FCount++;
            return "F";
        }
    }

    void showCommute()
    {
        string late;
        if (this.CommuteR >= 20)
            late = "��";
        else if (this.CommuteR >= 0 && this.CommuteR < 20)
            late = "��";
        else
            late = "X";

        GameObject.Find("commuteC").GetComponent<TextMeshProUGUI>().text = "�⼮: " + late;
    }

    string calcMT()
    {
        switch (this.MTR)
        {
            case 0:
                this.buttons[3].SetActive(true);
                this.FCount++;
                return "F";
            case 1:
                this.buttons[3].SetActive(true);
                return "C+";
            case 2:
                return "B0";
            case 3:
                return "B+";
            case 4:
                return "A0";
            case 5:
                return "A+";
            default:
                return "No Score"; //�Է� �ȵǸ�. 
        }
    }



    string calcAlbeit()
    {
        if (this.AlbeitR >= 33000 && this.AlbeitR <= 34000)
        { return "A+"; }
        else if (this.AlbeitR >= 31000 && this.AlbeitR <= 32000)
        {
            return "A0";
        }
        else if (this.AlbeitR >= 29000 && this.AlbeitR <= 30000)
        {
            return "A-";
        }
        else if (this.AlbeitR >= 27000 && this.AlbeitR <= 28000)
        {
            return "B+";
        }
        else if (this.AlbeitR >= 25000 && this.AlbeitR <= 26000)
        {
            return "B0";
        }
        else if (this.AlbeitR >= 23000 && this.AlbeitR <= 24000)
        {
            return "B-";
        }
        else if (this.AlbeitR >= 21000 && this.AlbeitR <= 22000)
        {
            this.buttons[4].SetActive(true);
            return "C+";
        }
        else if (this.AlbeitR >= 19000 && this.AlbeitR <= 20000)
        {
            this.buttons[4].SetActive(true);
            return "C0";
        }
        else if (this.AlbeitR >= 17000 && this.AlbeitR <= 18000)
        {
            this.buttons[4].SetActive(true);
            return "C-";
        }
        else if (this.AlbeitR >= 10000 && this.AlbeitR <= 16000)
        {
            this.buttons[4].SetActive(true);
            return "D+";
        }
        else
        {
            this.buttons[4].SetActive(true);
            this.FCount++;
            return "F";
        }

    }


    string calcHW()
    {
        return "P";


    }


    string calcExam()
    {
        if (this.ExamR >= 15)
        {
            return "A+";
        }
        else if (this.ExamR >= 10 && this.ExamR < 15)
        {
            return "A0";
        }
        else if (this.ExamR >= 8 && this.ExamR < 10)
        {
            return "A-";
        }
        else if (this.ExamR >= 7 && this.ExamR < 8)
        {
            return "B+";
        }
        else if (this.ExamR >= 5 && this.ExamR < 7)
        {
            return "B+";
        }
        else if (this.ExamR >= 2 && this.ExamR < 5)
        {
            return "B-";
        }
        else
        {
            if (this.ExamRP == "P")
            {
                this.buttons[6].SetActive(true);
                return "C+";
            }
            else
            {
                this.buttons[6].SetActive(true);
                this.FCount++;
                return "F";
            }
        }
    }



    public void finScores() //��������.
    {
        float totalS = 0;
        for(int i = 1; i < 6; i++)
        {
            totalS += changeStoSF(showScore(i));
        }
        this.finScore = totalS / 4;

        playSound();

        GameObject.Find("avgScore").GetComponent<TextMeshProUGUI>().text = this.finScore.ToString("F2");
        GameObject.Find("failedSub").GetComponent<TextMeshProUGUI>().text = this.FCount.ToString();

    }

    float changeStoSF(string s)
    {
        if (s == "A+") return 4.5f;
        else if (s == "A0") return 4.2f;
        else if (s == "A-") return 4.0f;
        else if (s == "B+") return 3.6f;
        else if (s == "B0") return 3.3f;
        else if (s == "B-") return 3.0f;
        else if (s == "C+") return 2.6f;
        else if (s == "C0") return 2.3f;
        else if (s == "C-") return 2.0f;
        else if (s == "D+") return 1.6f;
        else if (s == "D0") return 1.3f;
        else if (s == "F" /*&& s == "NP"*/)
        {
            //this.FCount++;//�Ǵ� ����� �޾Ƽ� ��.
            return 0;
        }
        else return 0; //�г���
    }

    public string showScore(int n)
    {
        switch (n)
        {
            case 1:
                return calcRegister();
            case 2:
                return calcQuiz();
            case 3:
                return calcCommute();
            case 4:
                return calcMT();
            case 5:
                return calcAlbeit();
            case 6:
                return calcHW();
            case 7:
                return calcExam();
            default:
                return "null";
        }
    }

    public void printTMI()
    {
        GameObject.Find("registerC").GetComponent<TextMeshProUGUI>().text = "���� ����: " + (this.RegisterRM * 3).ToString() + ", ���� ����: " + (this.RegisterRNM * 3).ToString();
        GameObject.Find("quizC").GetComponent<TextMeshProUGUI>().text = "S ���ϸ���: " + this.QuizR.ToString();
        showCommute();
        GameObject.Find("mtC").GetComponent<TextMeshProUGUI>().text = "S ���ϸ���: " + this.MTR.ToString() + "0";
        GameObject.Find("albeitC").GetComponent<TextMeshProUGUI>().text = this.AlbeitR.ToString() + "��";
        GameObject.Find("hwC").GetComponent<TextMeshProUGUI>().text = "���� ����";
        GameObject.Find("examC").GetComponent<TextMeshProUGUI>().text = "������ �ܿ� �¼�: " + (this.ExamR * 2).ToString();

    }

    public void replayScene(int t)
    {
        switch (t)
        {
            case 1: //����. 2/16 18��
                SceneManager.LoadScene("registerScene");
                break;
            case 2: //��Ƽ. 2/18 20��
                SceneManager.LoadScene("Quiz");
                break;
            case 3: //����. 3/1. 3��
                SceneManager.LoadScene("commute");
                break;
            case 4: //mt. 3/25  27��
                SceneManager.LoadScene("MTGame");
                break;
            case 5: //�˹�. 4/7 12��
                SceneManager.LoadScene("InitialScene");
                break;
            case 6: //����. 5/21 21��
                SceneManager.LoadScene("HomeworkScene");
                break;
            case 7: //����. 6/13 16��
                SceneManager.LoadScene("examScene");
                break;




        }
        PlayerPrefs.SetInt("retry", 1);
    }

    public void showButton()
    {
        this.endButton.SetActive(true);
    }

    void playSound()
    {
        if (finScore > 3.6f) //���� 3.6 ���� ��
        {
            this.aud.PlayOneShot(goodS);
        }
        else
        {
            this.aud.PlayOneShot(badS);
        }
    }

    public void showSF() //���� ���
    {
        GameObject.Find("registerSF").GetComponent<TextMeshProUGUI>().text = "NL";
        GameObject.Find("quizSF").GetComponent<TextMeshProUGUI>().text = changeStoSF(showScore(2)).ToString();
        GameObject.Find("commuteSF").GetComponent<TextMeshProUGUI>().text = changeStoSF(showScore(3)).ToString();
        GameObject.Find("mtSF").GetComponent<TextMeshProUGUI>().text = changeStoSF(showScore(4)).ToString();
        GameObject.Find("albeitSF").GetComponent<TextMeshProUGUI>().text = changeStoSF(showScore(5)).ToString();
        GameObject.Find("hwSF").GetComponent<TextMeshProUGUI>().text = "NL";
        GameObject.Find("examSF").GetComponent<TextMeshProUGUI>().text = changeStoSF(showScore(7)).ToString();

    }


    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
