using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            pencil.AfterSharpening();
        }
    }
}
