using System.Web.Optimization;



namespace TestWebEngine.Web
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundleTable)
        {
            #region Libraries

            #region Styles
            bundleTable.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.css"));
            bundleTable.Add(new StyleBundle("~/Content/bootstrap-theme").Include("~/Content/bootstrap-theme.css"));
            bundleTable.Add(new StyleBundle("~/Content/jquery-ui")
                .Include("~/Content/themes/base/jquery-ui.css",
                          "~/Content/themes/base/jquery.ui.accordion.css",
                          "~/Content/themes/base/jquery.ui.all.css",
                          "~/Content/themes/base/jquery.ui.autocomplete.css",
                          "~/Content/themes/base/jquery.ui.base.css",
                          "~/Content/themes/base/jquery.ui.button.css",
                          "~/Content/themes/base/jquery.ui.core.css",
                          "~/Content/themes/base/jquery.ui.datepicker.css",
                          "~/Content/themes/base/jquery.ui.dialog.css",
                          "~/Content/themes/base/jquery.ui.menu.css",
                          "~/Content/themes/base/jquery.ui.progressbar.css",
                          "~/Content/themes/base/jquery.ui.resizable.css",
                          "~/Content/themes/base/jquery.ui.selectable.css",
                          "~/Content/themes/base/jquery.ui.slider.css",
                          "~/Content/themes/base/jquery.ui.spinner.css",
                          "~/Content/themes/base/jquery.ui.tabs.css",
                          "~/Content/themes/base/jquery.ui.theme.css",
                          "~/Content/themes/base/jquery.ui.tooltip.css"));
            #endregion

            #region Scripts
            bundleTable.Add(new ScriptBundle("~/Scripts/bootstrap")
                .Include("~/Scripts/bootstrap.js"));
            bundleTable.Add(new ScriptBundle("~/Scripts/jquery")
                .Include("~/Scripts/jquery-2.1.0.intellisense.js",
                            "~/Scripts/jquery-2.1.0.js"));
            bundleTable.Add(new StyleBundle("~/Scripts/jquery-ui")
                .Include("~/Scripts/jquery-ui-1.10.4.js"));
            bundleTable.Add(new StyleBundle("~/Scripts/jquery-signalR")
                .Include("~/Scripts/jquery.signalR-2.0.3.js"));
            bundleTable.Add(new ScriptBundle("~/Scripts/jquery-unobtrusive")
                .Include("~/Scripts/jquery.unobtrusive-ajax.js"));
            bundleTable.Add(new ScriptBundle("~/Scripts/jquery-validate")
                .Include("~/Scripts/jquery.validate.js"));
            bundleTable.Add(new ScriptBundle("~/Scripts/less")
                .Include("~/Scripts/less-1.5.1.js"));
            bundleTable.Add(new ScriptBundle("~/Scripts/modernizr")
                .Include("~/Scripts/modernizr-2.7.2.js"));
            bundleTable.Add(new ScriptBundle("~/Scripts/underscore")
                .Include("~/Scripts/underscore.js"));
            bundleTable.Add(new ScriptBundle("~/Scripts/angular")
                .Include("~/Scripts/angular.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/angular-cookies.js",
                "~/Scripts/angular-loader.js",
                "~/Scripts/angular-mocks.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-sanitize.js",
                "~/Scripts/angular-scenario.js",
                "~/Scripts/angular-touch.js"));
            #endregion

            #endregion
        }
	}
}
