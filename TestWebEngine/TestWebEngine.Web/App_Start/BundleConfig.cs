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
            #endregion

            #region Scripts
            bundleTable.Add(new ScriptBundle("~/Scripts/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundleTable.Add(new StyleBundle("~/Scripts/jquery").Include(""));
            #endregion

            #endregion
        }
	}
}
