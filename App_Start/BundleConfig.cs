using System.Web.Optimization;

public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Scripts/jquery-3.5.1.js",
            "~/Scripts/jquery-3.5.1.min.js",
            "~/Scripts/bootstrap.min.js"));

        bundles.Add(new StyleBundle("~/Content/css").Include(
   "~/Content/bootstrap.min.css"));
    }
}