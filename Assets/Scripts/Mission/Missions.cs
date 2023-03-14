using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Missions : MonoBehaviour
{
    public static Missions Instance;
    string[] missions ={"Deprem çantası için gerekli malzemeleri topla.(TAB ile toplanacakları görüntüle)",
                        "Deprem çantasını evdeki güvenli olabilecek noktalardan bir tanesine yerleştir.(F tuşu ile)",
                        "Deprem çantasının bulunduğu yere koş ve çök kapan hareketini uygula.(CTRL tuşu ile)",
                        "Deprem çantasını alarak evden uzaklaş.",
                        "Güvenli toplanma alanına doğru ilerle."
                        };

    [SerializeField] TextMeshProUGUI missionText;
    int missionQuery = 0;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        Instance = this;
        missionText.text = missions[missionQuery];
        
    }
    public void missionUpdate(int missionQuery){
        print("görev değişti");
        missionText.text = missions[missionQuery];
    }

}
