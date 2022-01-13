using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SupermanController : MonoBehaviour
{
    public static SupermanController instance = null;

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

    int count, count1;
    public int code1Count;

    GameObject s0_0;
    GameObject s0_1;
    GameObject s0_2;
    GameObject s0_3;
    GameObject s0_4;
    GameObject explain;
    GameObject particle;
    GameObject circle;
    GameObject talk;
    GameObject Talk;
    GameObject cam;

    float delta = 0;
    float span = 7.0f;
    float moveSpeed = 4.0f;

    bool isAlive = false;
    bool isAlive1 = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[0] == 0 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[0] == 1 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[0] == 2 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[0] == 3 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[0] == 4 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>�� �����Ϸ� ��ó���� �����ڷ� �����Ϸ��� �Ͽ��� ȭ�� ������� ���� �� ���α׷��� "
            + "iostream ���̺귯���� �����ϵ��� �Ѵ�. C++ ���̺귯������ C++ ���α׷� ������ ���� �̸� ���ǵ� �ڵ尡 ���ԵǾ� �ִ�. "
            + "iostream ���� ���̺귯���� C++���� ��� �����̶�� �ϴµ�, ���� ���α׷��� ��ܿ� ��ġ�ϱ� �����̴�." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[1] == 0 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1); 
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[1] == 1 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            else
            { ;}
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[1] == 2 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[1] == 3 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[1] == 4 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;�� �����Ϸ����� ǥ�� ���ӽ����̽��� ����Ѵٰ� �˷� �ִ� ���̴�. "
            + "std�� ǥ��(standard)�� ���Ӹ��̴�. ���ӽ����̽��� ū ���α׷����� �̸����� ���� ȥ���� ���ϱ� ���� ���ǵ� ���̴�. "
            + "6�� ���� cout�� endl�̶�� �̸��� ǥ�� ���ӽ����̽����� iostream ���̺귯���� ���ǵǾ� �ִ�. �����Ϸ��� �̵� �̸��� ã���� �ϱ� ���ؼ� using namespace std; "
            + "������ ���Ǿ�� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[2] == 0 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~9�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (9�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[2] == 1 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~9�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (9�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            else
            { ;}
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[2] == 2 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~9�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (9�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[2] == 3 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~9�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (9�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[2] == 4 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "��� C++ ���α׷��� main �Լ��κ��� ����Ǹ�, �ϳ��� �Լ��� �������� �����ȴ�. "
            + "4~9�� �ٿ� �ۼ��� main �Լ����� 2���� ������ �ִ�. �׷��� ������� ��Ͼȿ� �ۼ��Ǵµ�, ������ {(5�� ��)�� ���۵Ǹ�} (9�� ��)�� ���� ����. "
            + "C++���� ��� ������ �� �������� ;(�����ݷ�)���� ������ �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[3] == 0 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6�� ���� ������ �ܼ�(ȭ��)�� ���ڿ��� ����ϴ� ������ cout �ܼ� ����� �ǹ��Ѵ�. "
            + "<< �����ڴ� ��Ʈ�� ���� �����ڷ� ���ڿ��� ȭ������ ������ �� ���Ǹ�, ���ڿ��� ����ǥ(\")�� �ѷ��ο��� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[3] == 1 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6�� ���� ������ �ܼ�(ȭ��)�� ���ڿ��� ����ϴ� ������ cout �ܼ� ����� �ǹ��Ѵ�. "
            + "<< �����ڴ� ��Ʈ�� ���� �����ڷ� ���ڿ��� ȭ������ ������ �� ���Ǹ�, ���ڿ��� ����ǥ(\")�� �ѷ��ο��� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            else
            { ;}
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[3] == 2 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6�� ���� ������ �ܼ�(ȭ��)�� ���ڿ��� ����ϴ� ������ cout �ܼ� ����� �ǹ��Ѵ�. "
            + "<< �����ڴ� ��Ʈ�� ���� �����ڷ� ���ڿ��� ȭ������ ������ �� ���Ǹ�, ���ڿ��� ����ǥ(\")�� �ѷ��ο��� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[3] == 3 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6�� ���� ������ �ܼ�(ȭ��)�� ���ڿ��� ����ϴ� ������ cout �ܼ� ����� �ǹ��Ѵ�. "
            + "<< �����ڴ� ��Ʈ�� ���� �����ڷ� ���ڿ��� ȭ������ ������ �� ���Ǹ�, ���ڿ��� ����ǥ(\")�� �ѷ��ο��� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[3] == 4 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6�� ���� ������ �ܼ�(ȭ��)�� ���ڿ��� ����ϴ� ������ cout �ܼ� ����� �ǹ��Ѵ�. "
            + "<< �����ڴ� ��Ʈ�� ���� �����ڷ� ���ڿ��� ȭ������ ������ �� ���Ǹ�, ���ڿ��� ����ǥ(\")�� �ѷ��ο��� �Ѵ�." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[4] == 0 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[4] == 1 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            else
            { ;}
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[4] == 2 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[4] == 3 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[4] == 4 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "���� �ڵ带 �˰� ������ �����̽��ٸ� ������!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;�� ���α׷��� �� �������� �ۼ��Ǿ� ������ ���α׷��� ����Ǵ� ���� �ǹ��Ѵ�. "
            + "���� 0�� ���� ���α׷��� �������� ���ᰡ �Ǿ����� �ǹ��ϴ� ���̴�. �� ������ ������ ��� �����Ϸ��� ���� ���α׷��� �� �����ϰų� �ƴϸ� ������ �߻���ų �� �ִ�. "
            + "�׷��Ƿ� ��� C++ �����Ϸ����� �ۼ� ���� ���α׷��� �� �����ϰ� �Ϸ��� �� ������ �׻� ���Խ�Ű�� ���� ����." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }
    }

   
    void Start()
    {
        count = 0;
        count1 = 0;

        this.s0_0 = GameObject.Find("s0_0");
        this.s0_1 = GameObject.Find("s0_1");
        this.s0_2 = GameObject.Find("s0_2");
        this.s0_3 = GameObject.Find("s0_3");
        this.s0_4 = GameObject.Find("s0_4");
        this.explain = GameObject.Find("explain");
        this.particle = GameObject.Find("Particle System");
        this.circle = GameObject.Find("circle");
        this.talk = GameObject.Find("talk");
        this.Talk = GameObject.Find("Talk");
        this.cam = GameObject.Find("Main Camera");
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span && count1 == 0)
        {
            this.talk.transform.localScale = new Vector3(0, 0, 0);
            this.Talk.GetComponent<Text>().text = "";
            count1 = 1;
            isAlive = true;
            isAlive1 = true;
        }
        if (isAlive)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(moveSpeed *Time.deltaTime, 0, 0);
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

        if (isAlive1 == true && isAlive == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                code1Count = 1;
                this.cam.transform.position = new Vector3(30, 0, -10);
                this.Talk.GetComponent<Text>().text = "";
                this.explain.GetComponent<Text>().text = "";
                Destroy(gameObject);
            }
        }

        if (this.transform.position.x >= 9.7f || this.transform.position.x <= -9.7f)
        {
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
        }
        else if (this.transform.position.y >= 5.0f || this.transform.position.y <= -7.0f)
        {
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
        }
    }
}
