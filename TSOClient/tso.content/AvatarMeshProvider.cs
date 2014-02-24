﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tso.content.framework;
using Microsoft.Xna.Framework.Graphics;
using tso.content.codecs;
using System.Text.RegularExpressions;
using tso.vitaboy;

namespace tso.content
{
    public class AvatarMeshProvider : FAR3Provider<Mesh>{
        public AvatarMeshProvider(Content contentManager, GraphicsDevice device) : base(contentManager, new MeshCodec(), new Regex(".*\\\\meshes\\\\.*\\.dat"))
        {
        }
    }
}