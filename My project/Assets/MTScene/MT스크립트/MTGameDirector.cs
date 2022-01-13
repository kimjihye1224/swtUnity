using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MTGameDirector : MonoBehaviour
{
    public string[] game_name = new string[17];
    public string[] game_explanation = new string[17];
    GameObject question;

    int flag = 0; //ó�� �ڸ�Ʈ���� ���
    int one = 0, two = 0, three = 0, four = 0, five = 0; //5���� ����
    public int now = 0; //���� ��ȣ
    public bool check = false; // ���� �ȵ�
    public bool check2 = false; //ȿ���� ���� -update()

    List<int> list = new List<int>();
    float[,] xloc = new float[5, 5];
    float[,] yloc = new float[5, 5];
    char[] extra = new char[25];

    public AudioClip next;
    AudioSource aud;

    //���� üũ
    string input = "";
    int cardcnt = 0;
    public int correct = 0; //���� ����
    // Start is called before the first frame update
    void Start()
    {
        this.question = GameObject.Find("explanation");
        this.game_name[0] = "�ٴϹٴ�";
        this.game_name[1] = "����ö";
        this.game_name[2] = "��ġ";
        this.game_name[3] = "����ĥ��";
        this.game_name[4] = "�ƹ�����";
        this.game_name[5] = "�պ�ȣ";
        this.game_name[6] = "����";
        this.game_name[7] = "�����϶�";
        this.game_name[8] = "Ŭ������Ʈ��";
        this.game_name[9] = "������";
        this.game_name[10] = "�̾�ϱ�";
        this.game_name[11] = "�����ӿ��굥��";
        this.game_name[12] = "�⼮��";
        this.game_name[13] = "ȫ��";
        this.game_name[14] = "��������";
        this.game_name[15] = "����";

        this.game_explanation[0] = "�뷡�� �����ϸ� �뷡�� ������ ���� ��ȭ�ڴ� �ٴϹٴ϶� �� �ϸ� �ڽ��� �Կ� �ָ��� �� �� �ٽ� �ٴϹٴ϶� ���ϸ鼭 �ٸ� ������� �� �ָ��� ����Ų��. �� �� �ָ��� ���� ����� �ٽ� �ٴϹٴ��Ҷ� �ڽ��� �ָ��� �Կ� ��� �ٽ� �ٸ� ������� �ָ��� ����Ų��. �� �� �ָ��� ���� ����� �� �� ����� �ٴϹٴ� �ٴϹٴ� �� ���� ��� ����� �ؾ��ϸ� ���� ������ ������ �̷� ������ ���� �ؾ� �Ѵ�. �׸��� ������ �Ǽ� �� ������ ��� ������ �����Ѵ�. �� ������ �����ϱ��?";
        this.game_explanation[1] = "���� ���۽� ��ȸ�ڰ� ����ö �뼱 �� �ϳ��� ���� �� �� �뼱�� ���� ���̸��� �θ���. �� �� ������ �������� ���ڰ� �ٲ�鼭 �� �뼱�� ���� ����ö�� �̸��� �θ���, ȯ�¿� (���￪, ��ǿ� ��)�� ��쿣 ȯ�¿��� ���� �ٸ� �뼱���� ������ �����ϴ�. ����, �� �̸��� ���ѵ� �ð� ���� ������ ���ϰų�, �̹� ���Ͽ��� ���� ���ϰų�, �ٸ� �뼱�� ���� ���� ��� ,������ ������ ������ ���� �ʴ� �� �̸��� ���� ���� �����Ѵ�. �� ������ �����ϱ��?";
        this.game_explanation[2] = "���� ��ȸ�ڰ� ���� 1�� �θ��� ���������ڰ� ���� ���ڸ� 1�� �ö󰡸鼭 �θ��� ���� �������� ���ڸ� �θ������ ��Ģ�� ���ϰ� ������ �����Ѵ�. ����, ���߿� �Ѽ��ڸ� �θ��̻��� ���ÿ� �θ��� ��� ������ �����ϰ� �� ���ڸ� �θ� ����� ��Ģ�� �޴´�.";
        this.game_explanation[3] = "�����ڰ� �հ������� �ڽ��� �տ� 007������ �׸��� ������ �����Ѵ�. �����ڰ� ���̶� ���ϸ� �� ���� �����Ѵ�. �� ������� ��� ���� ���̶� ���ϸ� �ٸ� ����� �����Ѵ�. �̹��� ������� ����� ĥ�̶� ���ϸ� �ٸ� ����� �����ϰ�, �̾ ���� ���� ����� ���̶� ���ϸ� �ٸ� ����� �����Ѵ�. �̹��� ���� ���� ����� �翷 �� ���� �����̶� ��ġ�� ���� ��ΰ� ���� �Ѵ�. �� ��, �ٸ� ������� ������ �־�� �Ѵ�. �� ������ �����ϱ��?";
        this.game_explanation[4] = "������ �� ���� �ʼ��� �θ��� ������ ������� �ش� �Ǵ� �ʼ��� �ܾ ������ ���� �����ָ鼭 ������ �������̺긦 �ϴ� ������ �����ϱ��?";
        this.game_explanation[5] = "�ټ� �հ����� ��� �Ѹ� ���ư��鼭 ��ü ������ �մϴ�. �� ������ �ش��� �Ǹ� �� �հ����� ��� �ټ� �հ����� �� ������ ���� �Ǵ� ������ �����ϱ��?";
        this.game_explanation[6] = "���̿��׶��� ���ۿ� ���߾� ���� 1- ����8���� ���ʴ�� �� �� �Ųٷ� ����8 ���Ŀ��� ���� 7, ���� 6���� �پ��� ������ �����ϱ��?";
        this.game_explanation[7] = "���ο��� �ڵ��� ī�� �� ���ڵ��� ���� �� ���� ���� �ʰ� ���� ����� �ɸ��� ������ �����ϱ��?";
        this.game_explanation[8] = "�ȳ� OOOOOO ���󿡼� ���ϰ��� ������Ĩ �̶�� �θ��鼭 �� ����� ���� �������� ������ �����ϱ��?";
        this.game_explanation[9] = "������ �ձ۰� �������� ����鼭 ������~�� 4�� �ݺ��� �� �������� ����� ��ġ�� ���濡�� �����մϴ�. �̰� ���� ������ �� ����� ���� ��纸�� ũ�� �ϰ� �Ҹ��� ũ�� ���ľ��ϴ� �� ������ �����ϱ��?";
        this.game_explanation[10] = "������ ������ 2,3���� ���� ���س��� 3���ڷ� �̾���ϴ�. ���� ��� �����ڰ� ��Ÿ��� ��ġ�� �̾� ���� ����� ����,�ʵ� �� �̾ ���ؾ� �մϴ�. �� ������ �����ϱ��?";
        this.game_explanation[11] = "������ �ų���, ��̳���, �� ���� ���굥����� ��ġ�� ��� ����� �հ������� �ƹ��� �����Ѵ�. ������ ���� �� ������ ���ڸ� ���� �� �ڽź��� ���� ������� �ճ��� ���� ���ڸ� ���� ������ ���ڰ� �Ҹ� ����� ���� �����̴�. �̰��� �����ϱ��?";
        this.game_explanation[12] = "�⼮��, �⼮�ζ�� ��ȣ�� ���߾� ���� �㸮�� ������ �ôٸ� �ݺ��Ѵ�. �� ���뿡 ���ߴٰ� ������ �̸��� �θ��� �������� �����ϸ鼭 ������ ��� ���� �ٸ� ����� �̸��� ���ľ��մϴ�. �̶� �̸��� ȣ��� ����� �׸� ��ģ �� �ٽ� ������ �ȴ�. �� ������ �����ϱ��?";
        this.game_explanation[13] = "�ƽ� ȫ�� ���ݺ��� ���� �ƽ� �ʳ��ϸ鼭 ������ �� ����� �����ϸ� �� �θ��� �� �ٸ� �θ��� �����Ѵ�. �� �� �Ѹ��� �θ����κ��� ������ ������ ���� �����̴�. �� ������ �����ΰ���?";
        this.game_explanation[14] = "�ƽ� OOOO�� �ö󰬴��� ��ü�� ������ 5���ϰ� ��~��ŷ�� ���� ũ�� �ϴ� �����̴�. �̰��� �����ΰ���?";
        this.game_explanation[15] = "�չٴ��� ���� �� ���¿��� �հ����� ���Ƿ� ���� ����� �մϴ�. ���� ���� ���θ���\"�� ��ġ�� 5�� ����� ���ڸ� ���ϵ� �ִ� ���ڴ� �ڸ��� �ִ� ������� 5����� �����մϴ�. �� ������ �����ϱ��?";

        this.aud = GetComponent<AudioSource>();

        for (int i = 0; i < 25; i++) list.Add(i);

        for (int i = 0; i < 5; i++)
        {
            xloc[i, 0] = -7.7f;
            xloc[i, 1] = -6.37f;
            xloc[i, 2] = -5.08f;
            xloc[i, 3] = -3.7f;
            xloc[i, 4] = -2.5f;
        }

        for (int i = 0; i < 5; i++)
        {
            yloc[0, i] = 3.87f;
            yloc[1, i] = 2.85f;
            yloc[2, i] = 1.54f;
            yloc[3, i] = 0.39f;
            yloc[4, i] = -0.69f;
        }

        this.extra[0] = '��';
        this.extra[1] = '��';
        this.extra[2] = '��';
        this.extra[3] = '��';
        this.extra[4] = '��';
        this.extra[5] = '��';
        this.extra[6] = '��';
        this.extra[7] = '��';
        this.extra[8] = '��';
        this.extra[9] = '��';
        this.extra[10] = 'ī';
        this.extra[11] = 'Ÿ';
        this.extra[12] = '��';
        this.extra[13] = '��';
        this.extra[14] = '��';
        this.extra[15] = '��';
        this.extra[16] = '��';
        this.extra[17] = '��';
        this.extra[18] = '��';
        this.extra[19] = '��';
        this.extra[20] = '��';
        this.extra[21] = '��';
        this.extra[22] = '��';
        this.extra[23] = '��';
        this.extra[24] = '��';

        Invoke("comment", 5);

        make_random();
        make_puzzle();
    }

    // Update is called once per frame
    void Update()
    {
        if (correct < 0) correct = 0;
    }

    //���� ����
    public void makequestion()
    {

        if (now == 0)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[one];

        }
        else if (now == 1)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[two];
        }
        else if (now == 2)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[three];

        }
        else if (now == 3)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[four];

        }
        else if (now == 4)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[five];

        }
        else
        {
            this.question.GetComponent<Text>().text = "���� ����";
            Debug.Log("����");
            Invoke("result", 3);
        }

    }

    //���� ����� �� ��ȯ
    public void gameOver()
    {
        PlayerPrefs.SetInt("MTR", this.correct);


        if (PlayerPrefs.GetInt("retry") == 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().saveCalDate(7);
            SceneManager.LoadScene("calendarScene");
        }
        else if (PlayerPrefs.GetInt("retry") == 1)
        {
            SceneManager.LoadScene("endScene");
        }
    }


    //���� ���, ���� ���� ���
    public void result()
    {
        GameObject.Find("Canvas").SetActive(false);
        float xresult = correct * 20 + 20;
        GameObject.Find("Main Camera").transform.position = new Vector3(xresult, 0, -10);
        Invoke("gameOver", 5.0f);
    }

    //ī�� ���� ����
    public void game(string s)
    {
        if (cardcnt > 6) return;
        GameObject button = GameObject.Find("card" + cardcnt); // ��� Ŭ���� ���� ������Ʈ�� �̸��� ��ư �� ���� ���

        button.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        button.GetComponentInChildren<TextMeshProUGUI>().text = s;
        button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 80;
        input += s;
        cardcnt++;

    }
    //retry ��ư ������ ī�� �ʱ�ȭ
    public void regame()
    {
        input = "";
        for (int i = 0; i < cardcnt; i++)
        {
            GameObject button = GameObject.Find("card" + i); // ��� Ŭ���� ���� ������Ʈ�� �̸��� ��ư �� ���� ���

            button.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            button.GetComponentInChildren<TextMeshProUGUI>().text = "";
        }
        cardcnt = 0;
    }
    //���� �´��� Ȯ��
    public bool checkgame()
    {
        if (now == 0)
        {
            if (input == game_name[one])
            {
                return true;
            }
            else return false;
        }
        else if (now == 1)
        {
            if (input == game_name[two])
            {

                return true;
            }
            else return false;
        }
        else if (now == 2)
        {
            if (input == game_name[three])
            {
                return true;
            }
            else return false;
        }
        else if (now == 3)
        {
            if (input == game_name[four])
            {
                return true;
            }
            else return false;
        }
        else if (now == 4)
        {
            if (input == game_name[five])
            {
                return true;
            }
            else return false;
        }

        return false;
    }

    //���� �������� ����
    public void shuffles()
    {
        for (int i = 1; i < 26; i++)
        {
            int rand1 = Random.Range(0, 25);
            int rand2 = Random.Range(0, 25);

            int tmp = list[rand1];
            list[rand1] = list[rand2];
            list[rand2] = tmp;
        }
    }
    //������ ���� �������� ���ϱ�
    void make_random()
    {
        one = Random.Range(0, 3);
        two = Random.Range(3, 6);
        three = Random.Range(6, 9);
        four = Random.Range(9, 12);
        five = Random.Range(12, 16);
    }
    //�� ���ڸ� 25ĭ�� ���
    void make_puzzle()
    {
        int sum = game_name[one].Length + game_name[two].Length + game_name[three].Length + game_name[four].Length + game_name[five].Length;
        while (sum > 25) make_random();

        shuffles();

        int cnt = 0;
        for (int i = 0; i < game_name[one].Length; i++)
        {
            char c = game_name[one][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // ��� Ŭ���� ���� ������Ʈ�� �̸��� ��ư �� ���� ���
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;

        }
        for (int i = 0; i < game_name[two].Length; i++)
        {
            char c = game_name[two][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // ��� Ŭ���� ���� ������Ʈ�� �̸��� ��ư �� ���� ���
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;

        }
        for (int i = 0; i < game_name[three].Length; i++)
        {
            char c = game_name[three][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // ��� Ŭ���� ���� ������Ʈ�� �̸��� ��ư �� ���� ���
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;
        }
        for (int i = 0; i < game_name[four].Length; i++)
        {
            char c = game_name[four][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // ��� Ŭ���� ���� ������Ʈ�� �̸��� ��ư �� ���� ���
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;

        }
        for (int i = 0; i < game_name[five].Length; i++)
        {
            char c = game_name[five][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // ��� Ŭ���� ���� ������Ʈ�� �̸��� ��ư �� ���� ���
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;

        }

        int cnt2 = 0;
        for (; cnt < 25; cnt++)
        {
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // ��� Ŭ���� ���� ������Ʈ�� �̸��� ��ư �� ���� ���
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + this.extra[cnt2];
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt2++;
        }

    }
    //ó�� ������ �� ���� �Ұ�
    void comment()
    {

        if (flag == 0)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = "�ȳ��ϼ��� ������. ���� ���ſ��� ���б��� �ٴϴ� N���� ���л� �������Դϴ�. MT���� ��� ���ӵ鿡 ���� ��� ���� �������ؿ�. ";
            flag = 1;
            Invoke("comment", 5);
        }
        else if (flag == 1)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = "�������� ��ġ�� 25���� ���� �� ���� �ش�Ǵ� �����̸��� ���߾� �������ֽø� �˴ϴ�. 2�� ������ ������ �Ǹ� �ʱ�ȭ�� ���Ͻø� retry�� ������ ������ �´��� Ȯ���ϰ� �����ø� check ��ư�� �����ּ���!";
            flag = 2;
            Invoke("comment", 10);
        }
        else if (flag == 2)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = "�׷� �����غ����?";
            flag = 3;
            Invoke("comment", 5);

        }
        else
        {
            Invoke("makequestion", 5);
        }
    }

}

