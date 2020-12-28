using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignMode
{
    public class Window
    {
        private WindowImp _imp;
        private View _contents;

        public Window(View view)
        {
            this._contents = view;
        }


        //requests handle by window
        /// <summary>
        /// 各自的实现
        /// </summary>
        public virtual void DrawContents()
        {
            
        }


        public virtual void Open()
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
            _imp.ImpSetOrigin();
        }

        public virtual void SetExtent()
        {
            _imp.ImpSetExtent();
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
            _imp.DeviceRect();
        }

        public virtual void DrawPolygon()
        {

        }

        public virtual void DrawText()
        {
            _imp.DeviceText();
        }



        protected WindowImp GetWindowImp(WindowSystemFactory factory)
        {
            if(_imp==null)
            {
                _imp = WindowFactory.GetInstance().MakeWindowImp(factory);
            }
            return _imp;
        }

        protected View GetView()
        {
            return _contents;
        }
    }
}
