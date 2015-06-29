using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace BootstrapSupport
{
    public class BootstrapBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"             
                ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapdjs").Include(
                "~/Scripts/bootstrap.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-responsive.min.css"
                ));
        }
    }
}