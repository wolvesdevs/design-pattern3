﻿namespace Rei02.Data
{
    internal static class KaisouFake
    {
        internal static IEnumerable<KaisouEntity> GetData()
        {
            var result = new List<KaisouEntity>();
            result.Add(new KaisouEntity(1, 0, 99, "関東"));
            result.Add(new KaisouEntity(10, 1, 1, "東京"));
            result.Add(new KaisouEntity(101, 10, 2 , "立川"));
            result.Add(new KaisouEntity(102, 10, 2, "三鷹"));

            result.Add(new KaisouEntity(20, 1, 1, "神奈川"));
            result.Add(new KaisouEntity(201, 20, 2, "横浜"));

            result.Add(new KaisouEntity(2, 0, 99, "四国"));
            result.Add(new KaisouEntity(30, 2, 1, "香川"));
            result.Add(new KaisouEntity(301, 30, 2, "高松"));

            return result;
        }
    }
}