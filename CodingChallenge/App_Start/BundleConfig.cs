using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace CodingChallenge.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                         "~/Scripts/jquery-ui.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/Views/jquery.validate.custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/general").Include(
                     "~/Scripts/views/general.js",
                        "~/Scripts/chosen.jquery.min.js"

                     ));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/font-awesome.css",
                       "~/Content/css/jquery-ui.css",
                      "~/Content/css/jquery-ui.structure.css",
                      "~/Content/css/chosen.css",
                      "~/Content/css/chosen-boostrap.css",
                      "~/Content/css/boostrap-datepicker.min.css",
                      "~/Content/css/datepicker.css",
                      "~/Content/css/site.css"));

        }

    }
}