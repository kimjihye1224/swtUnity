using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Superman2Controller : MonoBehaviour
{
    public static Superman2Controller instance = null;

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
    public int code3Count;

    GameObject s2_0;
    GameObject s2_1;
    GameObject s2_2;
    GameObject s2_3;
    GameObject s2_4;
    GameObject s2_5;
    GameObject s2_6;
    GameObject s2_7;
    GameObject s2_8;

    GameObject explain2;
    GameObject particle;
    GameObject circle2;
    GameObject talk;
    GameObject Talk2;
    GameObject cam;

    float moveSpeed = 4.0f;

    bool isAlive = true;
    bool isAlive1 = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[0] == 0 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[0] == 1 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[0] == 2 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[0] == 3 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[0] == 4 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[0] == 5 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[0] == 6 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[0] == 7 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[0] == 8 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[1] == 0 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "16�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[1] == 1 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "16�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[1] == 2 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "16�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[1] == 3 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "16�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[1] == 4 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "16�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[1] == 5 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "16�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[1] == 6 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "16�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[1] == 7 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "16�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[1] == 8 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "16�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[2] == 0 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~16�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (16�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[2] == 1 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~16�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (16�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[2] == 2 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~16�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (16�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[2] == 3 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~16�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (16�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[2] == 4 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~16�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (16�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[2] == 5 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~16�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (16�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[2] == 6 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~16�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (16�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[2] == 7 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~16�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (16�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[2] == 8 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~16�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (16�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[3] == 0 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 6�� ���� radius�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, radius ������ ���� ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[3] == 1 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 6�� ���� radius�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, radius ������ ���� ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[3] == 2 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 6�� ���� radius�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, radius ������ ���� ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[3] == 3 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 6�� ���� radius�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, radius ������ ���� ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[3] == 4 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 6�� ���� radius�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, radius ������ ���� ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[3] == 5 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 6�� ���� radius�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, radius ������ ���� ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[3] == 6 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 6�� ���� radius�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, radius ������ ���� ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[3] == 7 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 6�� ���� radius�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, radius ������ ���� ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[3] == 8 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 6�� ���� radius�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, radius ������ ���� ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[4] == 0 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 7�� ���� area�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, area ������ ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[4] == 1 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 7�� ���� area�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, area ������ ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[4] == 2 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 7�� ���� area�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, area ������ ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[4] == 3 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 7�� ���� area�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, area ������ ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[4] == 4 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 7�� ���� area�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, area ������ ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[4] == 5 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 7�� ���� area�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, area ������ ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[4] == 6 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 7�� ���� area�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, area ������ ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[4] == 7 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 7�� ���� area�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, area ������ ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";


            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[4] == 8 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area�� ���� ������ �޸𸮿� ��� ��Ҹ� �д�. "
                + "��� ������ �̸�, ����, ũ��, ���� �ִ�. 7�� ���� area�� double(�Ǽ�) ���� ���� ����ϵ��� �� ���̸�, area ������ ���� �Ҵ��ϱ� �������� �������� �ʴ´�."
                + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[5] == 0 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius��� �̸��� ���� ������ 20�� �Ҵ��Ͽ���." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[5] == 1 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius��� �̸��� ���� ������ 20�� �Ҵ��Ͽ���." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[5] == 2 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius��� �̸��� ���� ������ 20�� �Ҵ��Ͽ���." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[5] == 3 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius��� �̸��� ���� ������ 20�� �Ҵ��Ͽ���." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[5] == 4 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius��� �̸��� ���� ������ 20�� �Ҵ��Ͽ���." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[5] == 5 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius��� �̸��� ���� ������ 20�� �Ҵ��Ͽ���." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[5] == 6 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius��� �̸��� ���� ������ 20�� �Ҵ��Ͽ���." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[5] == 7 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius��� �̸��� ���� ������ 20�� �Ҵ��Ͽ���." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[5] == 8 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius��� �̸��� ���� ������ 20�� �Ҵ��Ͽ���." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[6] == 0 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9�� �ٿ��� radius�� 20�� �Ҵ� �Ǿ����Ƿ� (20 * 20 * 3.14159)�� ����� ���� area(�Ǽ�)�� �Ҵ�ȴ�."
            + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[6] == 1 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9�� �ٿ��� radius�� 20�� �Ҵ� �Ǿ����Ƿ� (20 * 20 * 3.14159)�� ����� ���� area(�Ǽ�)�� �Ҵ�ȴ�."
            + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[6] == 2 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9�� �ٿ��� radius�� 20�� �Ҵ� �Ǿ����Ƿ� (20 * 20 * 3.14159)�� ����� ���� area(�Ǽ�)�� �Ҵ�ȴ�."
            + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[6] == 3 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9�� �ٿ��� radius�� 20�� �Ҵ� �Ǿ����Ƿ� (20 * 20 * 3.14159)�� ����� ���� area(�Ǽ�)�� �Ҵ�ȴ�."
            + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[6] == 4 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9�� �ٿ��� radius�� 20�� �Ҵ� �Ǿ����Ƿ� (20 * 20 * 3.14159)�� ����� ���� area(�Ǽ�)�� �Ҵ�ȴ�."
            + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[6] == 5 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9�� �ٿ��� radius�� 20�� �Ҵ� �Ǿ����Ƿ� (20 * 20 * 3.14159)�� ����� ���� area(�Ǽ�)�� �Ҵ�ȴ�."
            + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[6] == 6 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9�� �ٿ��� radius�� 20�� �Ҵ� �Ǿ����Ƿ� (20 * 20 * 3.14159)�� ����� ���� area(�Ǽ�)�� �Ҵ�ȴ�."
            + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[6] == 7 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9�� �ٿ��� radius�� 20�� �Ҵ� �Ǿ����Ƿ� (20 * 20 * 3.14159)�� ����� ���� area(�Ǽ�)�� �Ҵ�ȴ�."
            + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[6] == 8 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9�� �ٿ��� radius�� 20�� �Ҵ� �Ǿ����Ƿ� (20 * 20 * 3.14159)�� ����� ��(�� ���� 1256.64�̴�.)"
            + "�� area(�Ǽ�)�� �Ҵ�ȴ�."
            + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[7] == 0 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is �� �ֿܼ� ��µǰ� 11�� �ٿ��� (20 * 20 * 3.14159)�� ����� ���� area�� �Ҵ�Ǿ����Ƿ� "
            + "\"The area is 1256.64\"�� �ֿܼ� ��µȴ�." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[7] == 1 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is �� �ֿܼ� ��µǰ� 11�� �ٿ��� (20 * 20 * 3.14159)�� ����� ���� area�� �Ҵ�Ǿ����Ƿ� "
            + "\"The area is 1256.64\"�� �ֿܼ� ��µȴ�." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[7] == 2 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is �� �ֿܼ� ��µǰ� 11�� �ٿ��� (20 * 20 * 3.14159)�� ����� ���� area�� �Ҵ�Ǿ����Ƿ� "
            + "\"The area is 1256.64\"�� �ֿܼ� ��µȴ�." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[7] == 3 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is �� �ֿܼ� ��µǰ� 11�� �ٿ��� (20 * 20 * 3.14159)�� ����� ���� area�� �Ҵ�Ǿ����Ƿ� "
            + "\"The area is 1256.64\"�� �ֿܼ� ��µȴ�." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[7] == 4 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is �� �ֿܼ� ��µǰ� 11�� �ٿ��� (20 * 20 * 3.14159)�� ����� ���� area�� �Ҵ�Ǿ����Ƿ� "
            + "\"The area is 1256.64\"�� �ֿܼ� ��µȴ�." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[7] == 5 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is �� �ֿܼ� ��µǰ� 11�� �ٿ��� (20 * 20 * 3.14159)�� ����� ���� area�� �Ҵ�Ǿ����Ƿ� "
            + "\"The area is 1256.64\"�� �ֿܼ� ��µȴ�." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[7] == 6 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is �� �ֿܼ� ��µǰ� 11�� �ٿ��� (20 * 20 * 3.14159)�� ����� ���� area�� �Ҵ�Ǿ����Ƿ� "
            + "\"The area is 1256.64\"�� �ֿܼ� ��µȴ�." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[7] == 7 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is �� �ֿܼ� ��µǰ� 11�� �ٿ��� (20 * 20 * 3.14159)�� ����� ���� area�� �Ҵ�Ǿ����Ƿ� "
            + "\"The area is 1256.64\"�� �ֿܼ� ��µȴ�." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[7] == 8 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is �� �ֿܼ� ��µǰ� 11�� �ٿ��� (20 * 20 * 3.14159)�� ����� ���� area�� �Ҵ�Ǿ����Ƿ� "
            + "\"The area is 1256.64\"�� �ֿܼ� ��µȴ�." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[8] == 0 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "�����߾��! �����ڵ���� ��! �ʱ�ȭ������ ���ư����� ���͸� �����ּ���!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����(exit) �Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. " + "�� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ "
            + "�߻���ų �� �ִ�. �׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[8] == 1 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "�����߾��! �����ڵ���� ��! �ʱ�ȭ������ ���ư����� ���͸� �����ּ���!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����(exit) �Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. " + "�� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ "
            + "�߻���ų �� �ִ�. �׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            isAlive = false;
            isAlive = true;

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[8] == 2 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "�����߾��! �����ڵ���� ��! �ʱ�ȭ������ ���ư����� ���͸� �����ּ���!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����(exit) �Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. " + "�� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ "
            + "�߻���ų �� �ִ�. �׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[8] == 3 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "�����߾��! �����ڵ���� ��! �ʱ�ȭ������ ���ư����� ���͸� �����ּ���!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����(exit) �Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. " + "�� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ "
            + "�߻���ų �� �ִ�. �׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[8] == 4 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "�����߾��! �����ڵ���� ��! �ʱ�ȭ������ ���ư����� ���͸� �����ּ���!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����(exit) �Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. " + "�� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ "
            + "�߻���ų �� �ִ�. �׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[8] == 5 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -3.0f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "�����߾��! �����ڵ���� ��! �ʱ�ȭ������ ���ư����� ���͸� �����ּ���!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����(exit) �Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. " + "�� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ "
            + "�߻���ų �� �ִ�. �׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[8] == 6 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "�����߾��! �����ڵ���� ��! �ʱ�ȭ������ ���ư����� ���͸� �����ּ���!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����(exit) �Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. " + "�� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ "
            + "�߻���ų �� �ִ�. �׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[8] == 7 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "�����߾��! �����ڵ���� ��! �ʱ�ȭ������ ���ư����� ���͸� �����ּ���!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����(exit) �Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. " + "�� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ "
            + "�߻���ų �� �ִ�. �׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[8] == 8 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "�����߾��! �����ڵ���� ��! �ʱ�ȭ������ ���ư����� ���͸� �����ּ���!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����(exit) �Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. " + "�� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ "
            + "�߻���ų �� �ִ�. �׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }
    }


    void Start()
    {
        count = 0;

        this.s2_0 = GameObject.Find("s2_0");
        this.s2_1 = GameObject.Find("s2_1");
        this.s2_2 = GameObject.Find("s2_2");
        this.s2_3 = GameObject.Find("s2_3");
        this.s2_4 = GameObject.Find("s2_4");
        this.s2_5 = GameObject.Find("s2_5");
        this.s2_6 = GameObject.Find("s2_6");
        this.s2_7 = GameObject.Find("s2_7");
        this.s2_8 = GameObject.Find("s2_8");

        this.explain2 = GameObject.Find("explain2");
        this.particle = GameObject.Find("Particle System");
        this.circle2 = GameObject.Find("circle2");
        this.talk = GameObject.Find("talk");
        this.Talk2 = GameObject.Find("Talk2");
        this.cam = GameObject.Find("Main Camera");
    }

    void Update()
    {

        if (Superman1Controller.instance.code2Count == 1 && isAlive == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
                this.transform.localScale = new Vector3(0.65f, 0.65f, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
                this.transform.localScale = new Vector3(-0.65f, 0.65f, 0);
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

        if (isAlive1 == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                homeworkAudioManager.instance.AudioDestroy();

                PlayerPrefs.SetString("HomeworkR", "P");
                if (PlayerPrefs.GetInt("retry") == 0)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager>().saveCalDate(13);
                    SceneManager.LoadScene("calendarScene");
                }
                else if (PlayerPrefs.GetInt("retry") == 1)
                {
                    SceneManager.LoadScene("endScene");
                }

            }
        }
        if (this.transform.position.x >= 69.7f || this.transform.position.x <= 50.3f)
        {
            this.transform.position = new Vector3(61.55f, -3.42f, 0);
        }
        else if (this.transform.position.y >= 5.0f || this.transform.position.y <= -7.0f)
        {
            this.transform.position = new Vector3(61.55f, -3.42f, 0);
        }

    }
}
