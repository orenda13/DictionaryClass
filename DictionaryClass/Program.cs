using System;
namespace DictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> _dictionary = new Dictionary<int, string>();
            _dictionary.Add(1, "emre");
            Console.WriteLine(_dictionary.Count()); 
            MyDictionary<int,string>myDictionary=new MyDictionary<int, string>();
            myDictionary.Add(1, "enes");
            myDictionary.Add(2, "emir");
            myDictionary.Add(3, "ebru");
            Console.WriteLine(myDictionary.Count());
            myDictionary.List();
            
        }
    }
    class MyDictionary<A,B>
    {
        A [] _keyArray;
        A[] _tempKeyArray;
        B[] _valueArray;
        B[] _tempValueArray;
        public MyDictionary()
        {
             _keyArray = new A [0];
            _valueArray = new B [0];
        }
        public void Add(A key,B value)
        {
            _tempKeyArray = _keyArray;
            _tempValueArray = _valueArray;
            _keyArray = new A[_keyArray.Length+1];
            _valueArray = new B [_valueArray.Length+1];
            for(int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keyArray[i] = _tempKeyArray[i];
            }
            _keyArray[_keyArray.Length-1]=key;
            for (int i = 0; i < _tempValueArray.Length; i++)
            {
                _valueArray[i] = _tempValueArray[i];
            }
            _valueArray[_valueArray.Length - 1] = value;
        }
        public int Count()
        {
            return _keyArray.Length;    
        }
        public void List()
        {
            foreach (A key in _keyArray)
            {
                Console.WriteLine($"Key : {key}");
            }
            foreach (B value in _valueArray)
            {
                Console.WriteLine($"Value : {value}");
            }

        }

    }
}
