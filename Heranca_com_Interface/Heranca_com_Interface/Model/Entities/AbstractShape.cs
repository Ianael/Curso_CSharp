using Heranca_com_Interface.Enums;

namespace Heranca_com_Interface.Model.Entities {
    abstract class AbstractShape : IShape {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
