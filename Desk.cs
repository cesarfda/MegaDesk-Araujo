using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Araujo
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewoord,
        Veneer,
        Pine
    }

 
    public class Desk
    {
        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumberDrawers { get; set; }

        public DesktopMaterial SurfaceMaterial { get; set; }

        //Desk Constraints
        public const int MAX_WIDTH = 96;
        public const int MAX_DRAWERS = 7;
        public const int MAX_DEPTH = 48;
        public const int MIN_WIDTH = 24;
        public const int MIN_DRAWERS = 7;
        public const int MIN_DEPTH = 12;
        
    }
}
