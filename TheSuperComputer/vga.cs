﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheSuperComputer
{
    class vga
    {
        private String brand;
        private int graphicsClock;
        private int memoryClock;

        public vga(String brand, int graphicsClock, int memoryClock)
        {
            this.brand = brand;
            this.graphicsClock = graphicsClock;
            this.memoryClock = memoryClock;
        }

        public String getBrand()
        {
            return this.brand;
        }

        public int getGraphicsClock()
        {
            return this.graphicsClock;
        }

        public int getMemoryClock()
        {
            return this.memoryClock;
        }

        public override string ToString()
        {
            return $"Vga brand : {this.brand} ; Vga clock graphics : {this.graphicsClock} ; Vga clock memmory : {this.memoryClock}";
        }
    }
}