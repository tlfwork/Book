using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBook : MonoBehaviour
{
    IEnumerator _myCoroutine;

    public class MyWaitForSecond
    {
        public float total;

        public float now;

        public bool done { get => total - now <= 0; }
    
        public void update()
        {
            now += Time.deltaTime;
        }

        public MyWaitForSecond(float time) { total = time; }
    }

    public void MyStartCoRoutine(IEnumerator enumerator)
    {
        _myCoroutine = enumerator;
    }

    // Start is called before the first frame update
    void Start()
    {
        MyStartCoRoutine(Func());
    }

    IEnumerator Func()
    {
        Debug.Log("aaaa");

        yield return null;

        Debug.Log("bbb");

        yield return new MyWaitForSecond(5);

        Debug.Log("ccc");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if(_myCoroutine != null)
        {
            if(_myCoroutine.Current is MyWaitForSecond mywait)
            {
                mywait.update();

                if (!mywait.done) return;
            }

            if(!_myCoroutine.MoveNext())
            {
                _myCoroutine = null;
            }
        }
    }
}
