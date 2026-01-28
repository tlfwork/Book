using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ThreadLearn : MonoBehaviour
{
    private static SynchronizationContext _mainThreadContext;

    [SerializeField] private Text _uiText; // 要修改的UI文本

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
