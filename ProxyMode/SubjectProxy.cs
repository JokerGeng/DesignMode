using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyMode
{
    class SubjectProxy
    {
        private RealSubject _realSubject;

        public SubjectProxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        public void Request()
        {
            this._realSubject.Request();
        }
    }
}
