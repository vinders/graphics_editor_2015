﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureAnalyst
{
    public partial class PreviewForm : Form
    {
        public PreviewForm(Bitmap source)
        {
            InitializeComponent();
            previewPicture.Image = source;
        }
    }
}