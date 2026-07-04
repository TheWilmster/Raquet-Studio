using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Raquet_Studio
{
    public partial class ActorEditor : Form
    {
        public ActorEditor()
        {
            InitializeComponent();
        }
    }

    public enum ActorFlip
    {
        SDL_FLIP_NONE = 0x00000000,     /**< Do not flip */
        SDL_FLIP_HORIZONTAL = 0x00000001,    /**< flip horizontally */
        SDL_FLIP_VERTICAL = 0x00000002     /**< flip vertically */
    }

    public class RaquetCHR
    {
        public int width;
        public int height;
        public int data;
        //RaquetPalette palette[4];
    }

    public class RaquetBBox
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
    }

    public class RaquetActor
    {
        public Point initalPosition = Point.Empty;
        public Point origin = Point.Empty;
        public int angle = 0;
        public ActorFlip flip = ActorFlip.SDL_FLIP_NONE;
        public RaquetCHR chr;
        public int width;
        public int height;
        public RaquetBBox bbox;

        public RaquetActor(RaquetCHR _chr, RaquetBBox _bbox)
        {
            chr = _chr;
            width = chr.width;
            height = chr.height;
            bbox = _bbox;
        }
    }
}
