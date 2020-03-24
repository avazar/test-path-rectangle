using System;
using System.Collections.Generic;
using System.Text;

namespace Test_path_rectangle
{
    public struct IntPoint
    {
        public long X;
        public long Y;
    }

    /// <summary>
    /// Класс, представляющий сегмент-отрезок
    /// </summary>
    public class Segment
    {
        #region START POINT

        /// <summary>
        /// Начальная точка сегмента
        /// </summary>
        public IntPoint StartPoint;

        #endregion

        #region END POINT

        /// <summary>
        /// Конечная точка сегмента
        /// </summary>
        public IntPoint EndPoint;

        #endregion

        public override string ToString()
        {
            return $"{this.StartPoint} - {this.EndPoint}";
        }
    }
}
