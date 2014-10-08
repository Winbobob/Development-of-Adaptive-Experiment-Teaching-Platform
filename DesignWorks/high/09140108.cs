using System;
using System.Collections.Generic;
using System.Text;

namespace StringDs
{
  interface IString<T>
  {
   int Compare(T s);
   T SubString(int index, int len);
   int GetLength();
   T Concat(T s);
   int IndexOf(T s, int startpos);
   T Insert(int index, T s);
   T Delete(int index,int len);
  }
}
