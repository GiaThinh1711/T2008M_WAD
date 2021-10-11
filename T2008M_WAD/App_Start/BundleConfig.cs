using System.Web;
using System.Web.Optimization;

namespace T2008M_WAD
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/AdminLTE/css").Include(
                   "~/Content/AdminLTE/plugins/fontawesome-free/css/all.min.css",
                    "~/Content/AdminLTE/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                    "~/Content/AdminLTE/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                    "~/Content/AdminLTE/plugins/jqvmap/jqvmap.min.css",
                    "~/Content/AdminLTE/dist/css/adminlte.min.css",
                    "~/Content/AdminLTE/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                    "~/Content/AdminLTE/plugins/daterangepicker/daterangepicker.css",
                    "~/Content/AdminLTE/plugins/summernote/summernote-bs4.min.css"
             ));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Content/AdminLTE/plugins/jquery/jquery.min.js",
                         "~/Content/AdminLTE/plugins/jquery-ui/jquery-ui.min.js",
                         "~/Content/AdminLTE/plugins/bootstrap/js/bootstrap.bundle.min.js",
                         "~/Content/AdminLTE/plugins/chart.js/Chart.min.js",
                         "~/Content/adminLTE/plugins/sparklines/sparkline.js",
                         "~/Content/AdminLTE/plugins/jqvmap/jquery.vmap.min.js",
                         "~/Content/AdminLTE/plugins/jqvmap/maps/jquery.vmap.usa.js",
                         "~/Content/AdminLTE/plugins/jquery-knob/jquery.knob.min.js",
                         "~/Content/AdminLTE/plugins/moment/moment.min.js",
                         "~/Content/AdminLTE/plugins/daterangepicker/daterangepicker.js",
                         "~/Content/AdminLTE/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                         "~/Content/AdminLTE/plugins/summernote/summernote-bs4.min.js",
                         "~/Content/AdminLTE/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                         "~/Content/AdminLTE/dist/js/adminlte.js",
                         "~/Content/AdminLTE/dist/js/demo.js",
                         "~/Content/AdminLTE/dist/js/pages/dashboard.js"
                ));
        }
    }
}
