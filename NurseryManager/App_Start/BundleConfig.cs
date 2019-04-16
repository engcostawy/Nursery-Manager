using System.Web;
using System.Web.Optimization;

namespace NurseryManager
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Content/global/vendor/breakpoints/breakpoints.js",
                      "~/Content/global/vendor/babel-external-helpers/babel-external-helpers.js",
                      "~/Content/global/vendor/jquery/jquery.js",
                      "~/Content/global/vendor/popper-js/umd/popper.min.js",
                      "~/Content/global/vendor/animsition/animsition.js",
                      "~/Content/global/vendor/mousewheel/jquery.mousewheel.js",
                      "~/Content/global/vendor/asscrollbar/jquery-asScrollbar.js",
                      "~/Content/global/vendor/asscrollable/jquery-asScrollable.js",
                      "~/Content/global/vendor/switchery/switchery.js",
                      "~/Content/global/vendor/intro-js/intro.js",
                      "~/Content/global/vendor/screenfull/screenfull.js",
                      "~/Content/global/vendor/slidepanel/jquery-slidePanel.js",
                      "~/Content/global/vendor/chartist/chartist.js",
                      "~/Content/global/vendor/chartist-plugin-tooltip/chartist-plugin-tooltip.js",
                      "~/Content/global/vendor/aspieprogress/jquery-asPieProgress.js",
                      "~/Content/global/vendor/matchheight/jquery.matchHeight-min.js",
                      "~/Content/global/vendor/jquery-selective/jquery-selective.min.js",
                      "~/Content/global/vendor/bootstrap-datepicker/bootstrap-datepicker.js",
                      "~/Content/global/js/Component.js",
                      "~/Content/global/js/Plugin.js",
                      "~/Content/global/js/Base.js",
                      "~/Content/global/js/Config.js",
                      "~/Content/global/js/config/colors.js",
                      "~/Content/global/js/Plugin/asscrollable.js",
                      "~/Content/global/js/Plugin/slidepanel.js",
                      "~/Content/global/js/Plugin/switchery.js",
                      "~/Content/global/js/Plugin/matchheight.js",
                      "~/Content/global/js/Plugin/aspieprogress.js",
                      "~/Content/global/js/Plugin/bootstrap-datepicker.js",
                      "~/Content/global/js/Plugin/asscrollable.js",
                      "~/Content/assets/js/Section/Menubar.js",
                      "~/Content/assets/js/Section/Sidebar.js",
                      "~/Content/assets/js/Section/PageAside.js",
                      "~/Content/assets/js/Plugin/menu.js",
                      "~/Content/assets/js/Site.js",
                      "~/Content/assets/examples/js/dashboard/team.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/global/vendor/bootstrap/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/global/vendor/animsition/animsition.css",
                      "~/Content/assets/css/site.min.css",
                      "~/Content/global/css/bootstrap.css",
                      "~/Content/global/css/bootstrap.min.css",
                      "~/Content/global/css/bootstrap-extend.min.css",
                      "~/Content/global/vendor/animsition/animsition.css",
                      "~/Content/global/vendor/asscrollable/asScrollable.css",
                      "~/Content/global/vendor/switchery/switchery.css",
                      "~/Content/global/vendor/intro-js/introjs.css",
                      "~/Content/global/vendor/slidepanel/slidePanel.css",
                      "~/Content/global/vendor/flag-icon-css/flag-icon.css",
                      "~/Content/global/vendor/chartist/chartist.css",
                      "~/Content/global/vendor/chartist-plugin-tooltip/chartist-plugin-tooltip.css",
                      "~/Content/global/vendor/aspieprogress/asPieProgress.css",
                      "~/Content/global/vendor/jquery-selective/jquery-selective.css",
                      "~/Content/global/vendor/bootstrap-datepicker/bootstrap-datepicker.css",
                      "~/Content/global/vendor/asscrollable/asScrollable.css",
                      "~/Content/global/fonts/web-icons/web-icons.min.css",
                      "~/Content/global/fonts/brand-icons/brand-icons.min.css",
                      "~/Content/assets/examples/css/dashboard/team.css"));
        }
    }
}
