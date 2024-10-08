internal class Program
{
  private static void Main(string[] args)
  {
    //Bài 1: Bài Toán: Tính tổng các số trong mảng
    List<int> lstNumber1 = new List<int>() { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };

    int tongCacSoTrongMang = ZBaiTap.tongCacSoTrongMang(lstNumber1);
    Console.WriteLine($"tongCacSoTrongMang: {tongCacSoTrongMang}");

    //Bài 2: Tìm hai số trong tổng danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước
    List<int> lstNumber2 = new List<int>() { 2, 7, 11, 15 };
    int target = 9;

    List<int> tongHaiSoBangTarget = ZBaiTap.tongHaiSoBangTarget(lstNumber2, target);
    if (tongHaiSoBangTarget.Count == 2) // Nếu tìm được đúng 2 số
    {
      Console.WriteLine($"Tổng hai số bằng {target} có vị trí trong mảng tại: {tongHaiSoBangTarget.IndexOf(tongHaiSoBangTarget[0])} và {tongHaiSoBangTarget.IndexOf(tongHaiSoBangTarget[1])}");
    }
    else
    {
      Console.WriteLine($"Không tìm thấy hai số có tổng bằng {target}");
    }

    //Bài 3: Remove duplicates from sorted Array(Easy)
    List<int> lstNumber3 = new List<int>() { 1, 1, 2, 2, 2, 3, 4, 4, 5 };

    List<int> removeDuplicates = ZBaiTap.removeDuplicates(lstNumber3);
    Console.WriteLine($"Remove duplicates: {string.Join(",", removeDuplicates)}");

    // Bài 4: Remove duplicates from sorted Array(Easy)
    List<int> lstNumber4 = new List<int>() { 1, 1, 1, 2, 2, 3 };
    int k = 2;

    List<int> demSoLanXuatHien = ZBaiTap.demSoLanXuatHien(lstNumber4, k);
    Console.WriteLine($"Top {k} phần tử xuất hiện nhiều nhất: {string.Join(", ", demSoLanXuatHien)}");

    // Bài 5: Best time to Buy and Sell Stock
    List<int> prices = new List<int>() { 7, 1, 5, 3, 6, 4 };

    int maxProfit = ZBaiTap.maxLoiNhuan(prices);
    Console.WriteLine($"Lợi nhuận lớn nhất có thể đạt được: {maxProfit}");
  }
}