﻿namespace ファクトリーメソッド.Data
{
  internal sealed class ProductSqlServer : IProduct
  {
    public string GetData()
    {
      return "sql server xxxxx";
    }
  }
}