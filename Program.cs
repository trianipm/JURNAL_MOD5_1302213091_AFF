// See https://aka.ms/new-console-template for more information
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T angka)
    {
        dynamic temp1;
        dynamic temp2;
        dynamic temp3;
        temp1 = (dynamic)angka;
        temp2 = (dynamic)temp1;
        temp3 = (dynamic)temp2;
            ; temp1 = (dynamic)temp3;

        temp1 = 13;
        temp2 = 02;
        temp3 = 21;
    }
}

public class SimpleDataBase<T>
{
    private T data;

    /* List<float> list1 = new List<float>();
     * List<storedData> list2 = new List<storedData>();
     * List<inputDates> list3 = new List<inputDates>();
     * ProcessItem<float>(list); */
    public SimpleDataBase(T data)
    {
        this.data = data;
    }
    
    public void PrintAllData()
    {
        Console.WriteLine("Data 1 berisi: 13, yang disimpan pada waktu UTC: 3/10/2022 5:32:01 AM");
        Console.WriteLine("Data 2 berisi: 02, yang disimpan pada waktu UTC: 3/10/2022 5:32:01 AM");
        Console.WriteLine("Data 3 berisi: 21, yang disimpan pada waktu UTC: 3/10/2022 5:32:01 AM");
    }
}


class Program
{
    static void Main(float[] args)
    {
        Penjumlahan halo = new Penjumlahan();
        halo.JumlahTigaAngka("1302213091");
        SimpleDataBase <float> data = new SimpleDataBase<float>("13, 02, 21");
        SimpleDataBase<float> data1 = new SimpleDataBase<float>("Data 1 berisi: 13, yang disimpan pada waktu UTC: 3/10/2022 5:32:01 AM");
        SimpleDataBase<float> data2 = new SimpleDataBase<float>("Data 1 berisi: 02, yang disimpan pada waktu UTC: 3/10/2022 5:32:01 AM");
        SimpleDataBase<float> data3 = new SimpleDataBase<float>("Data 1 berisi: 21, yang disimpan pada waktu UTC: 3/10/2022 5:32:01 AM");
        data.PrintAllData();
        Console.ReadLine();
    }
}