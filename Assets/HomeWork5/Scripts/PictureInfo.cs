using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PictureInfo : MonoBehaviour
{
    [SerializeField]
    private GameObject _buttonView;
    [SerializeField]
    private GameObject _pictureInfoText;
    [SerializeField]
    private Transform _PictureName;

    private bool _pictureInfoTextVisible = false;

    IEnumerator ButtonAnimation()
    {
        for (;;)
        {
            if (Input.GetButtonDown("Use"))
            {
                _buttonView.transform.GetComponent<Animator>().SetTrigger("Pressed");
                
            }

            if (Input.GetButtonUp("Use") )
            {
                _buttonView.transform.GetComponent<Animator>().SetTrigger("Normal");
                OnButtonPress();
            }
            yield return null;
        }
    }
    public string ClousestPicture()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Picture");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest.name;
    }

    void Awake()
    {
          _buttonView.transform.GetComponent<Animator>().SetTrigger("Disabled");      
    }
    void Start()
    {
        StartCoroutine(ButtonAnimation());

    }

    void OnTriggerEnter(Collider other)
    {
        _buttonView.transform.GetComponent<Animator>().SetTrigger("Normal");
    }

  public  void OnButtonPress()
  {
        switch (ClousestPicture())
        {
            case "Утро в сосновом лесу":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                    "Год создания: 1889 \nМузей: Третьяковская галерея, Москва \nШишкин был отличным пейзажистом," +
                    "но рисовать животных ему приходилось нечасто, поэтому фигуры медвежат нарисовал Савицкий," +
                    "превосходный художник-анималист. По окончании работы Третьяков приказал стереть подпись Савицкого," +
                    "посчитав, что Шишкин проделал куда более обширную работу.";

                break;
            case "Иван Грозный и сын его Иван":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                    "Годы создания: 1883–1885 \nМузей: Третьяковская галерея, Москва \nНа сотворение шедевра," +
                    " более известного как «Иван Грозный убивает своего сына», Репина вдохновила симфония «Антар»" +
                    " Римского-Корсакова, а именно, ее вторая часть под названием «Сладость мести»." +
                    " Под влиянием звуков музыки художник изобразил кровавую сцену убийства и последующего раскаяния," +
                    " наблюдающегося в глазах государя.";
                break;
            case "Демон сидящий":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                    "Год создания: 1890 \nМузей: Третьяковская галерея, Москва\nКартина входила в число тридцати иллюстраций," +
                    " нарисованных Врубелем к юбилейному изданию сочинений М.Ю. Лермонтова. «Демон сидящий»" +
                    " олицетворяет сомнения, присущие человеческому духу, тонкое, неуловимое «настроение души»." +
                    " По мнению экспертов, художник был в какой-то мере одержим образом демона: за этой картиной последовали" +
                    " «Демон летящий» и «Демон поверженный».";
                break;
            case "Боярыня Морозова":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                    "Годы создания: 1884–1887 \nМузей: Третьяковская галерея, Москва\nВ основу картины лег" +
                    " сюжет старообрядческого жития «Повесть о боярыне Морозовой». Понимание ключевого образа" +
                    " пришло к художнику, когда тот увидел ворону, пятном раскинувшую черные крылья на снежном полотне." +
                    " Позже Суриков долго искал прототип для лица боярыни, но не мог обнаружить" +
                    " ничего подходящего, пока однажды не встретил на кладбище женщину-старообрядку" +
                    " с бледным исступленным лицом. Портретный набросок был завершен за два часа.";
                break;
            case "Богатыри":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                    "Годы создания: 1881–1898 \nМузей: Третьяковская галерея, Москва \nБудущий былинный шедевр родился" +
                    " небольшим карандашным наброском в 1881 году; для дальнейшей работы над полотном Васнецов много лет" +
                    " кропотливо собирал информацию о богатырях из мифов, легенд и преданий, а также изучал подлинную" +
                    " древнерусскую амуницию в музеях.";
                break;
            case "Купание красного коня":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                     "Год создания: 1912 \nМузей: Третьяковская галерея, Москва\nИзначально картина задумывалась" +
                    " как бытовая зарисовка из жизни русской деревушки, однако во время работы полотно художника" +
                    " обросло огромным количеством символов. Под красным конем Петров-Водкин подразумевал «Судьбу России»;" +
                    " после вступления страны в Первую мировую войну он воскликнул: «Так вот почему я нарисовал эту картину!»." +
                    " Впрочем, после революции просоветские искусствоведы трактовали ключевую фигуру полотна как" +
                    " «предвестника революционных пожаров».";
                break;
            case "Троица":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                     "Год создания: 1411 \nМузей: Третьяковская галерея, Москва\n" +
                    "Икона, положившая начало традиции русского иконописания XV–XVI вв. Полотно, изображающее" +
                    " ветхозаветную троицу ангелов, явившихся Аврааму, является символом единения Святой Троицы.";
                break;
            case "Девятый вал":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                     "Год создания: 1850 \nМузей: Русский музей, Санкт-Петербург\nЖемчужина в «картинографии»" +
                    " легендарного отечественного мариниста, которого без колебаний можно отнести к числу самых известных" +
                    " художников мира. Мы можем видеть, как чудом выжившие после шторма мореплаватели цепляются за мачту" +
                    " в ожидании встречи с «девятым валом», мифическим апогеем всех штормов. Но теплые оттенки," +
                    " господствующие на полотне, дают надежду на спасение потерпевших.";
                break;
            case "Последний день Помпеи":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                     "Годы создания: 1830–1833 \nМузей: Русский музей, Санкт-Петербург\n" +
                    "Завершенная в 1833 году картина Брюллова первоначально выставлялась в крупнейших городах Италии," +
                    " где вызвала настоящий фурор – живописца сравнивали с Микеланджело, Тицианом, Рафаэлем… На родине" +
                    " шедевр встретили с не меньшим воодушевлением, закрепив за Брюлловым прозвище «Карл великий»." +
                    " Полотно воистину великое: его размеры составляют 4,6 на 6,5 метра, что делает его одной из самых" +
                    " больших картин среди творений русских художников.";
                break;
            case "Мона Лиза":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                     "Годы создания: 1503–1505 \nМузей: Лувр, Париж\n" +
                    "Шедевр флорентийского гения, не нуждающийся в представлении. Примечательно, что культовый статус" +
                    " картина получила после инцидента с похищением из Лувра в 1911 году. Два года спустя похититель," +
                    " оказавшийся сотрудником музея, пытался продать полотно в галерею Уффици. События громкого дела подробно" +
                    " освещались в мировой прессе, после чего в продажу поступили сотни тысяч репродукций, а таинственная" +
                    " Джоконда стала объектом поклонения.";
                break;
            case "Тайная вечеря":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                     "Годы создания: 1495–1498 \nМузей: Санта-Мария-делле-Грацие, Милан\n" +
                    "Так же известная как «Мадонна с младенцем» картина долгое время хранилась в коллекции герцогов Литта," +
                    " а в 1864 году была куплена петербургским Эрмитажем. Многие эксперты сходятся во мнении, что фигура" +
                    " младенца была написана не лично да Винчи, а одним из его учеников – слишком нехарактерная для" +
                    " живописца поза.";
                break;
            case "Постоянство памяти":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                     "Год создания: 1931 \nМузей: Музей современного искусства, Нью-Йорк\n" +
                    "Парадоксально, но самая известная работа гения сюрреализма, была рождена мыслями о сыре Камамбер." +
                    " В один из вечеров, после дружеского ужина, завершившегося закусками с сыром, художник погрузился в" +
                    " размышления о «растекающейся мякоти», и его воображение нарисовало картину словно плавящихся часов " +
                    "с веткой оливы на переднем плане.";
                break;
            case "Тайная вечеря2":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                     "Год создания: 1955 \nМузей: Национальная галерея искусства, Вашингтон\n" +
                    "Традиционный сюжет, получивший сюрреалистическую канву с использованием арифметических принципов," +
                    " изучавшихся еще Леонардо да Винчи. Во главу угла художник поставил своеобразную магию числа «12»," +
                    " отойдя от герменевтического метода толкования библейского сюжета.";
                break;
            case "Герника":
                _pictureInfoText.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                     "Год создания: 1937 \nМузей: Музей королевы Софии, Мадрид\n" +
                    "Герника – название города страны Басков, подвергнувшегося немецкой бомбардировке в апреле" +
                    " 1937 года. Пикассо никогда не был в Гернике, но был ошеломлен масштабами катастрофы словно «ударом" +
                    " бычьего рога». Художник в абстрактной форме передал ужасы войны и показал настоящее лицо фашизма," +
                    " завуалировав его причудливыми геометрическими формами.";
                break;
        }
      _pictureInfoTextVisible = !_pictureInfoTextVisible;
        _pictureInfoText.transform.GetComponent<Animator>().SetBool("ChangeScale", _pictureInfoTextVisible);
        //_pictureInfoText.transform.GetChild(1).GetComponent<Scrollbar>().value = 1;
    }

   // void OnTriggerStay(Collider other)
  //  {

   // }

    void OnTriggerExit(Collider other)
    {
        _buttonView.transform.GetComponent<Animator>().SetTrigger("Disabled");
        _pictureInfoTextVisible = false;
        _pictureInfoText.transform.GetComponent<Animator>().SetBool("ChangeScale", _pictureInfoTextVisible);

    }

    void Update()
    {
        _PictureName.GetChild(0).GetComponent<Text>().text = ClousestPicture();
    }


}
