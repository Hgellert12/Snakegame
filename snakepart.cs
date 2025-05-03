using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace snakegame
{
    class snakepart : PictureBox
    {
        public static int size = 30;
        public snakepart()
        {
            Width = size;
            Height = size;
            BackColor = Color.Fuchsia;
        }
    }
}
