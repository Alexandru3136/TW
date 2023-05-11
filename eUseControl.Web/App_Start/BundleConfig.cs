using System.Web.Optimization;

namespace eUseControl.Web
{
     public static class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               //bootstrap
               bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap.min.css"));
               bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.min.js"));

               //font-awesome
               bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/Content/font-awesome.min.css"));

               //magnific-popup
               bundles.Add(new StyleBundle("~/bundles/magnific-popup/css").Include("~/Content/magnific-popup.css"));
               bundles.Add(new ScriptBundle("~/bundles/jquery.magnific-popup/js").Include("~/Scripts/jquery.magnific-popup.min.js"));

               //slicknav
               bundles.Add(new StyleBundle("~/bundles/slicknav/css").Include("~/Content/slicknav.min.css"));
               bundles.Add(new ScriptBundle("~/bundles/jquery.slicknav/js").Include("~/Scripts/jquery.slicknav.min.js"));

               //owl.carousel
               bundles.Add(new StyleBundle("~/bundles/owl.carousel/css").Include("~/Content/owl.carousel.min.css"));
               bundles.Add(new ScriptBundle("~/bundles/owl.carousel/js").Include("~/Scripts/owl.carousel.min.js"));

               //main
               bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Content/style.css"));
               bundles.Add(new ScriptBundle("~/bundles/main/js").Include("~/Scripts/main.js"));

               //jquery
               bundles.Add(new ScriptBundle("~/bundles/jquery-3.2.1/js").Include("~/Scripts/jquery-3.2.1.min.js"));

               //circle-progress
               bundles.Add(new ScriptBundle("~/bundles/circle-progress/js").Include("~/Scripts/circle-progress.min.js"));

               //instafeed
               bundles.Add(new ScriptBundle("~/bundles/instafeed/js").Include("~/Scripts/instafeed.min.js"));

               //masonry.pkgd
               bundles.Add(new ScriptBundle("~/bundles/masonry.pkgd/js").Include("~/Scripts/masonry.pkgd.min.js"));

               //mixitup
               bundles.Add(new ScriptBundle("~/bundles/mixitup/js").Include("~/Scripts/mixitup.min.js"));


          }
     }
}