class ZBaiTap
{
  //Bài 1: Bài Toán: Tính tổng các số trong mảng
  public static int tongCacSoTrongMang(List<int> lst)
  {
    int tong = 0;

    foreach (int item in lst)
    {
      tong += item;
    }
    return tong;
  }

  //Bài 2: Tìm hai số trong tổng danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước
  public static List<int> tongHaiSoBangTarget(List<int> list, int target)
  {
    List<int> listResult = new List<int>() { };

    for (int i = 0; i < list.Count; i++)
    {
      for (int j = i + 1; j < list.Count; j++)
      {
        if (list[i] + list[j] == target)
        {
          listResult.Add(list[i]);
          listResult.Add(list[j]);
          return listResult;
        }
      }
    }
    return listResult;
  }

  //Bài 3: Remove duplicates from sorted Array(Easy)
  public static List<int> removeDuplicates(List<int> list)
  {
    List<int> listResult = new List<int>() { };
    foreach (int item in list)
    {
      if (!listResult.Contains(item))
      {
        listResult.Add(item);
      }

    }
    return listResult;
  }

  // Bài 4: Remove duplicates from sorted Array(Easy)
  public static List<int> demSoLanXuatHien(List<int> nums, int k)
  {
    Dictionary<int, int> demSoLanXuatHien = new Dictionary<int, int>();

    foreach (int num in nums)
    {
      if (demSoLanXuatHien.ContainsKey(num))
      {
        demSoLanXuatHien[num]++;
      }
      else
      {
        demSoLanXuatHien[num] = 1;
      }
    }

    List<int> result = demSoLanXuatHien
        .OrderByDescending(pair => pair.Value)
        .Take(k)
        .Select(pair => pair.Key)
        .ToList();

    return result;
  }

  // Bài 5: Best time to Buy and Sell Stock
  public static int maxLoiNhuan(List<int> gia)
  {
    if (gia.Count == 0) return 0;
    int giaThapNhat = gia[0];
    int maxLoiNhuan = 0;
    for (int i = 1; i < gia.Count; i++)
    {
      if (gia[i] < giaThapNhat)
      {
        giaThapNhat = gia[i];
      }
      else
      {
        int profit = gia[i] - giaThapNhat;
        if (profit > maxLoiNhuan)
        {
          maxLoiNhuan = profit;
        }
      }
    }

    return maxLoiNhuan;
  }

}