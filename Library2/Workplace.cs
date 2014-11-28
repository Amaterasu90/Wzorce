using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public enum Mode { Towers, Drawing }
    public class Workplace
    {
        private IUsable _iUsable = null;
        public Workplace(Mode mod)
        {
            switch (mod)
            {
                case Mode.Towers:
                    _iUsable = new Tower();
                    break;
                case Mode.Drawing:
                    _iUsable = new Line();
                    break;
            }
        }

        public void Update()
        {
            _iUsable.Update();
        }

        public void Draw()
        {
            _iUsable.Draw();
        }
    }
}
