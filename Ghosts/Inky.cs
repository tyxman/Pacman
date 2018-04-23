﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.Ghosts {
    public class Inky : Ghost {


        public Inky(Chixel chixel, Vector2 pos) {
            Chixel = chixel;
            Position = pos;
            
            Game.Instance.Characters.Add(this);
        }

        public override void Update() {
            base.Update();

            FrameBuffer.Instance.SetChixel(Position, Chixel, FrameBuffer.BufferLayers.Characters);
        }
    }
}