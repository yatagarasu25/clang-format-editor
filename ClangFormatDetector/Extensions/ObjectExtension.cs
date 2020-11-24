﻿using Newtonsoft.Json;

namespace ClangFormatDetector.Extensions
{
  public static class ObjectExtension
  {
    public static T Clone<T>(this T obj)
    {
      return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj));
    }
  }
}
