using System.Drawing;

namespace DoAn
{
    public static class ThamSo      // Thêm static để k phải tạo instance
    {
        public static int KichCoNode = 40;
        public static int KhoanCachGiuaCacNode = KichCoNode*2;
        public const int KhoanCachTrenDuoiNode = 60;
        public static Color MauNenNode = Color.White;
        public static Color MauNodeDaXetQua = Color.DimGray;
        public static Color MauNodeDangXet = Color.Aqua;
        // Toc Do : cang lon cang cham
        public static int TocDo = 60;

        // Số lượng phần tử lớn nhất đc phép nhập
        public static int SoLuongPhanTuMax = 20;
    }
}
