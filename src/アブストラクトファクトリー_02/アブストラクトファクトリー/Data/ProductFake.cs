﻿namespace アブストラクトファクトリー.Data
{
  internal sealed class ProductFake : IProduct
  {
    public string GetData()
    {
      return "fake!!";
    }
  }
}