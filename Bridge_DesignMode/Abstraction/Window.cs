using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignMode
{
    public class Window
    {
        private WindowImp imp;
        private View view;

        public Window(View view)
        {
            this.view = view;
        }

        //requests handle by window
        public virtual void DrawContents()
        {

        }
        public virtual void Opne()
        {

        }

        public virtual void Close()
        {

        }

        public virtual void Iconfy()
        {

        }

        public virtual void Deiconfy()
        {

        }

        //requests forwarded to implementation

        public virtual void SetOrigin()
        {

        }

        public virtual void SetExtent()
        {

        }

        public virtual void Raise()
        {

        }

        public virtual void Lower()
        {

        }

        public virtual void DrawLine()
        {

        }

        public virtual void DrawRect()
        {

        }

        public virtual void DrawPolygon()
        {

        }

        public virtual void DrawText()
        {

        }

        protected WindowImp GetWindowImp()
        {
            if(imp==null)
            {
                imp = WindowFactory.GetInstance().MakeWindowImp(new WindowSystemFactory());
            }
            return imp;
        }
        protected View GetView()
        {
            return view;
        }
    }
}
