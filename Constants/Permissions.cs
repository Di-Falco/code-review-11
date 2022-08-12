using System.Collections.Generic;

namespace Pierre.Constants
{
  public static class Permissions
  {
    public static List<string> GeneratePermissionsForModule(string module)
    {
      return new List<string>()
      {
        $"Permissions.{module}.Create",
        $"Permissions.{module}.View",
        $"Permissions.{module}.Edit",
        $"Permissions.{module}.Delete",
      };
    }
    public static class Products
    {
      public const string View = "Permissions.Products.View";
      public const string Create = "Permission.Products.Create";
      public const string Edit = "Permissions.Products.Edit";
      public const string Delete = "Permission.Products.Delete";
    }
  }
}