using System;

namespace ConsoleAnimation
{
    public static class Frames
    {
        private static Frame _sun;
        public static Frame Sun = _sun ?? (_sun = CreateSun());
        private static Frame CreateSun(){
            var frame = new Frame();
            frame.SetPixel(0, 0, '\\');
            frame.SetPixel(1, 0, '|');
            frame.SetPixel(2, 0, '/');
            frame.SetPixel(0, 1, '-');
            frame.SetPixel(1, 1, 'O');
            frame.SetPixel(2, 1, '-');
            frame.SetPixel(0, 2, '/');
            frame.SetPixel(1, 2, '|');
            frame.SetPixel(2, 2, '\\');
            return frame;
        }

        private static Frame _man;

        public static Frame Man = _man ?? (_man = CreateMan());

        private static Frame CreateMan(){
            var frame = new Frame();
            frame.SetPixel(4, 9, '/');
            frame.SetPixel(6, 9, '\\');
            frame.SetPixel(5, 8, '|');
            frame.SetPixel(4, 8, '/');
            frame.SetPixel(6, 8, '\\');
            frame.SetPixel(5, 7, 'o');
            return frame;
        }
    }
}