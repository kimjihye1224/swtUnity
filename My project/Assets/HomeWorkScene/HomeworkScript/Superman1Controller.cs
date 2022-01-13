using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Superman1Controller : MonoBehaviour
{
    public static Superman1Controller instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }

    int count;
    public int code2Count;
    float moveSpeed = 4.0f;

    GameObject s1_0;
    GameObject s1_1;
    GameObject s1_2;
    GameObject s1_3;
    GameObject s1_4;
    GameObject s1_5;

    GameObject explain1;
    GameObject particle;
    GameObject circle1;
    GameObject talk;
    GameObject Talk1;
    GameObject cam;

    bool isAlive = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[0] == 0 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";
            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[0] == 1 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";
            
            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[0] == 2 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";
            
            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[0] == 3 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[0] == 4 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[0] == 5 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[1] == 0 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6,7�� ���� cout�� 7�� ���� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[1] == 1 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6,7�� ���� cout�� 7�� ���� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";
            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[1] == 2 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6,7�� ���� cout�� 7�� ���� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[1] == 3 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6,7�� ���� cout�� 7�� ���� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[1] == 4 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6,7�� ���� cout�� 7�� ���� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[1] == 5 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6,7�� ���� cout�� 7�� ���� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }


        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[2] == 0 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~10�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (10�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[2] == 1 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~10�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (10�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[2] == 2 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~10�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (10�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[2] == 3 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~10�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (10�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[2] == 4 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~10�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (10�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[2] == 5 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~10�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (10�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[3] == 0 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout�� �ܼ� ����� �ǹ��ϹǷ� (10.5 + 2 * 3) / (45 - 3.5) = �� ȭ�鿡 ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[3] == 1 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout�� �ܼ� ����� �ǹ��ϹǷ� (10.5 + 2 * 3) / (45 - 3.5) = �� ȭ�鿡 ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[3] == 2 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout�� �ܼ� ����� �ǹ��ϹǷ� (10.5 + 2 * 3) / (45 - 3.5) = �� ȭ�鿡 ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[3] == 3 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout�� �ܼ� ����� �ǹ��ϹǷ� (10.5 + 2 * 3) / (45 - 3.5) = �� ȭ�鿡 ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[3] == 4 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout�� �ܼ� ����� �ǹ��ϹǷ� (10.5 + 2 * 3) / (45 - 3.5) = �� ȭ�鿡 ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[3] == 5 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout�� �ܼ� ����� �ǹ��ϹǷ� (10.5 + 2 * 3) / (45 - 3.5) = �� ȭ�鿡 ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[4] == 0 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++���� ���ϱ� ��ȣ�� *�̴�. ������� C++ �������� �ٷ� ��ȯ�� �� �ִ�. (10.5 + 2 * 3) / (45 - 3.5)"
                + "�� �����Ͽ� �ֿܼ� ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[4] == 1 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++���� ���ϱ� ��ȣ�� *�̴�. ������� C++ �������� �ٷ� ��ȯ�� �� �ִ�. (10.5 + 2 * 3) / (45 - 3.5)"
                + "�� �����Ͽ� �ֿܼ� ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[4] == 2 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++���� ���ϱ� ��ȣ�� *�̴�. ������� C++ �������� �ٷ� ��ȯ�� �� �ִ�. (10.5 + 2 * 3) / (45 - 3.5)"
                + "�� �����Ͽ� �ֿܼ� ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[4] == 3 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++���� ���ϱ� ��ȣ�� *�̴�. ������� C++ �������� �ٷ� ��ȯ�� �� �ִ�. (10.5 + 2 * 3) / (45 - 3.5)"
                + "�� �����Ͽ� �ֿܼ� ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[4] == 4 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++���� ���ϱ� ��ȣ�� *�̴�. ������� C++ �������� �ٷ� ��ȯ�� �� �ִ�. (10.5 + 2 * 3) / (45 - 3.5)"
                + "�� �����Ͽ� �ֿܼ� ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[4] == 5 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++���� ���ϱ� ��ȣ�� *�̴�. ������� C++ �������� �ٷ� ��ȯ�� �� �ִ�. (10.5 + 2 * 3) / (45 - 3.5)"
                + "�� �����Ͽ� �ֿܼ� ����Ѵ�." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[5] == 0 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[5] == 1 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[5] == 2 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[5] == 3 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[5] == 4 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[5] == 5 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }
    }


    void Start()
    {
        count = 0;

        this.s1_0 = GameObject.Find("s1_0");
        this.s1_1 = GameObject.Find("s1_1");
        this.s1_2 = GameObject.Find("s1_2");
        this.s1_3 = GameObject.Find("s1_3");
        this.s1_4 = GameObject.Find("s1_4");
        this.s1_5 = GameObject.Find("s1_5");
        this.explain1 = GameObject.Find("explain1");
        this.particle = GameObject.Find("Particle System");
        this.circle1 = GameObject.Find("circle1");
        this.talk = GameObject.Find("talk");
        this.Talk1 = GameObject.Find("Talk");
        this.cam = GameObject.Find("Main Camera");
    }

    void Update()
    {

        if (SupermanController.instance.code1Count == 1 && isAlive == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
                this.transform.localScale = new Vector3(1, 1, 1);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
                this.transform.localScale = new Vector3(-1, 1, 1);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
            }
        }

        if (SupermanController.instance.code1Count == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                code2Count = 1;
                this.cam.transform.position = new Vector3(60, 0, -10);
                this.Talk1.GetComponent<Text>().text = "";
                this.explain1.GetComponent<Text>().text = "";
                Destroy(gameObject);
            }
        }
        if (this.transform.position.x >= 39.7f || this.transform.position.x <= 20.3f)
        {
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
        }
        else if (this.transform.position.y >= 5.0f || this.transform.position.y <= -7.0f)
        {
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
        }
    }
}
