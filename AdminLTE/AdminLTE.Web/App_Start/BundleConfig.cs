using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AdminLTE.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterLayout(bundles);

            RegisterShared(bundles);

            RegisterAccount(bundles);

            RegisterHome(bundles);

            RegisterCharts(bundles);

            RegisterWidgets(bundles);

            RegisterElements(bundles);

            RegisterForms(bundles);

            RegisterTables(bundles);

            RegisterCalendar(bundles);

            RegisterMailbox(bundles);

            RegisterExamples(bundles);

            RegisterDocumentation(bundles);
        }

        private static void RegisterDocumentation(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Documentation/menu").Include(
                "~/JavaScript/Documentation/Documentation-menu.js"));
        }
        private static void RegisterExamples(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Examples/Blank/menu").Include(
                "~/JavaScript/Examples/Blank-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/Invoice/menu").Include(
                "~/JavaScript/Examples/Invoice-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/Lockscreen/menu").Include(
                "~/JavaScript/Examples/Lockscreen-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/Login").Include(
                "~/JavaScript/Examples/Login.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/Login/menu").Include(
                "~/JavaScript/Examples/Login-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/P404/menu").Include(
                "~/JavaScript/Examples/P404-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/P500/menu").Include(
                "~/JavaScript/Examples/P500-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/Pace").Include(
                "~/JavaScript/Examples/Pace.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/Pace/menu").Include(
                "~/JavaScript/Examples/Pace-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/ProfileEx/menu").Include(
                "~/JavaScript/Examples/ProfileEx-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/Register").Include(
                "~/JavaScript/Examples/Register.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Examples/Register/menu").Include(
                "~/JavaScript/Examples/Register-menu.js"));
        }
        private static void RegisterMailbox(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Mailbox/Inbox").Include(
                "~/Scripts/Mailbox/Inbox.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Mailbox/Inbox/menu").Include(
                "~/Scripts/Mailbox/Inbox-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Mailbox/Compose").Include(
                "~/Scripts/Mailbox/Compose.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Mailbox/Compose/menu").Include(
                "~/Scripts/Mailbox/Compose-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Mailbox/Read/menu").Include(
                "~/Scripts/Mailbox/Read-menu.js"));
        }
        private static void RegisterCalendar(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Calendar").Include(
                "~/JavaScript/Calendar/Calendar.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Calendar/menu").Include(
                "~/JavaScript/Calendar/Calendar-menu.js"));
        }
        private static void RegisterTables(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Tables/Simple/menu").Include(
                "~/JavaScript/Tables/Simple-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Tables/Data").Include(
                "~/JavaScript/Tables/Data.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Tables/Data/menu").Include(
                "~/JavaScript/Tables/Data-menu.js"));
        }
        private static void RegisterForms(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Forms/Advanced").Include(
                "~/JavaScript/Forms/Advanced.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Forms/Advanced/menu").Include(
                "~/JavaScript/Forms/Advanced-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Forms/Editors").Include(
                "~/JavaScript/Forms/Editors.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Forms/Editors/menu").Include(
                "~/JavaScript/Forms/Editors-menu.js"));


            bundles.Add(new ScriptBundle("~/JavaScript/Forms/General/menu").Include(
                "~/JavaScript/Forms/General-menu.js"));
        }
        private static void RegisterElements(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Elements/Buttons/menu").Include(
                "~/JavaScript/Elements/Buttons-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Elements/General/menu").Include(
                "~/JavaScript/Elements/General-menu.js"));

            bundles.Add(new StyleBundle("~/Content/Styles/Elements/General").Include(
                "~/Content/Styles/Elements/General.css"));

            bundles.Add(new ScriptBundle("~/JavaScript/Elements/Icons/menu").Include(
                "~/JavaScript/Elements/Icons-menu.js"));

            bundles.Add(new StyleBundle("~/Content/Styles/Elements/Icons").Include(
                "~/Content/Styles/Elements/Icons.css"));

            bundles.Add(new ScriptBundle("~/JavaScript/Elements/Modals/menu").Include(
                "~/JavaScript/Elements/Modals-menu.js"));

            bundles.Add(new StyleBundle("~/Content/Styles/Elements/Modals").Include(
                "~/Content/Styles/Elements/Modals.css"));

            bundles.Add(new ScriptBundle("~/JavaScript/Elements/Sliders").Include(
                "~/JavaScript/Elements/Sliders.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Elements/Sliders/menu").Include(
                "~/JavaScript/Elements/Sliders-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Elements/Timeline/menu").Include(
                "~/ScripJavaScriptts/Elements/Timeline-menu.js"));
        }
        private static void RegisterWidgets(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Widgets/menu").Include(
                "~/JavaScript/Widgets/Widgets-menu.js"));
        }
        private static void RegisterCharts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Charts/ChartsJs").Include(
                "~/JavaScript/Charts/ChartsJs.js"));
            bundles.Add(new ScriptBundle("~/JavaScript/Charts/ChartsJs/menu").Include(
                "~/JavaScript/Charts/ChartsJs-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Charts/Morris").Include(
                "~/JavaScript/Charts/Morris.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Charts/Morris/menu").Include(
                "~/JavaScript/Charts/Morris-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Charts/Flot").Include(
                "~/JavaScript/Charts/Flot.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Charts/Flot/menu").Include(
                "~/JavaScript/Charts/Flot-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Charts/Inline").Include(
                "~/JavaScript/Charts/Inline.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Charts/Inline/menu").Include(
                "~/JavaScript/Charts/Inline-menu.js"));
        }
        private static void RegisterHome(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Home/DashboardV1").Include(
                "~/JavaScript/Home/DashboardV1.js"));
            bundles.Add(new ScriptBundle("~/JavaScript/Home/DashboardV1/menu").Include(
                "~/JavaScript/Home/DashboardV1-menu.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Home/DashboardV2").Include(
                "~/JavaScript/Home/DashboardV2.js"));
            bundles.Add(new ScriptBundle("~/JavaScript/Home/DashboardV2/menu").Include(
                "~/JavaScript/Home/DashboardV2-menu.js"));
        }

        private static void RegisterAccount(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Account/Login").Include(
                "~/JavaScript/Account/Login.js"));

            bundles.Add(new ScriptBundle("~/JavaScript/Account/Register").Include(
                "~/JavaScript/Account/Register.js"));
        }

        private static void RegisterShared(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript/Shared/_Layout").Include(
                "~/JavaScript/Shared/_Layout.js"));
        }
        private static void RegisterLayout(BundleCollection bundles)
        {
            // bootstrap
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/bootstrap/js").Include(
                "~/Scripts/AdminLTE/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/bootstrap/css").Include(
                "~/Scripts/AdminLTE/bootstrap/css/bootstrap.min.css"));

            // dist
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/dist/js").Include(
                "~/Scripts/AdminLTE/dist/js/app.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/dist/css").Include(
                "~/Scripts/AdminLTE/dist/css/admin-lte.min.css"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/dist/css/skins").Include(
                "~/Scripts/AdminLTE/dist/css/skins/_all-skins.min.css"));


            // documentation
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/documentation/js").Include(
                "~/Scripts/AdminLTE/documentation/js/docs.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/documentation/css").Include(
                "~/Scripts/AdminLTE/documentation/css/style.css"));

            // plugins | bootstrap-slider
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/bootstrap-slider/js").Include(
                "~/Scripts/AdminLTE/plugins/bootstrap-slider/js/bootstrap-slider.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/bootstrap-slider/css").Include(
                "~/Scripts/AdminLTE/plugins/bootstrap-slider/css/slider.css"));

            // plugins | bootstrap-wysihtml5
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/bootstrap-wysihtml5/js").Include(
                "~/Scripts/AdminLTE/plugins/bootstrap-wysihtml5/js/bootstrap3-wysihtml5.all.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/bootstrap-wysihtml5/css").Include(
                "~/Scripts/AdminLTE/plugins/bootstrap-wysihtml5/css/bootstrap3-wysihtml5.min.css"));

            // plugins | chartjs
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/chartjs/js").Include(
                "~/Scripts/AdminLTE/plugins/chartjs/js/chart.min.js"));

            // plugins | ckeditor
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/ckeditor/js").Include(
                "~/Scripts/AdminLTE/plugins/ckeditor/js/ckeditor.js"));

            // plugins | colorpicker
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/colorpicker/js").Include(
                "~/Scripts/AdminLTE/plugins/colorpicker/js/bootstrap-colorpicker.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/colorpicker/css").Include(
                "~/Scripts/AdminLTE/plugins/colorpicker/css/bootstrap-colorpicker.css"));

            // plugins | datatables
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/datatables/js").Include(
                "~/Scripts/AdminLTE/plugins/datatables/js/jquery.dataTables.min.js",
                "~/Scripts/AdminLTE/plugins/datatables/js/dataTables.bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/datatables/css").Include(
                "~/Scripts/AdminLTE/plugins/datatables/css/dataTables.bootstrap.css"));

            // plugins | datepicker
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/datepicker/js").Include(
                "~/Scripts/AdminLTE/plugins/datepicker/js/bootstrap-datepicker.js",
                "~/Scripts/AdminLTE/plugins/datepicker/js/locales/bootstrap-datepicker*"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/datepicker/css").Include(
                "~/Scripts/AdminLTE/plugins/datepicker/css/datepicker3.css"));


            // plugins | daterangepicker
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/daterangepicker/js").Include(
                "~/Scripts/AdminLTE/plugins/daterangepicker/js/moment.min.js",
                "~/Scripts/AdminLTE/plugins/daterangepicker/js/daterangepicker.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/daterangepicker/css").Include(
                "~/Scripts/AdminLTE/plugins/daterangepicker/css/daterangepicker-bs3.css"));

            // plugins | fastclick
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/fastclick/js").Include(
                "~/Scripts/AdminLTE/plugins/fastclick/js/fastclick.min.js"));

            // plugins | flot
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/flot/js").Include(
                "~/Scripts/AdminLTE/plugins/flot/js/jquery.flot.min.js",
                "~/Scripts/AdminLTE/plugins/flot/js/jquery.flot.resize.min.js",
                "~/Scripts/AdminLTE/plugins/flot/js/jquery.flot.pie.min.js",
                "~/Scripts/AdminLTE/plugins/flot/js/jquery.flot.categories.min.js"));

            // plugins | font-awesome
            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/font-awesome/css").Include(
                "~/Scripts/AdminLTE/plugins/font-awesome/css/font-awesome.min.css"));

            // plugins | fullcalendar
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/fullcalendar/js").Include(
                "~/Scripts/AdminLTE/plugins/fullcalendar/js/fullcalendar.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/fullcalendar/css").Include(
                "~/Scripts/AdminLTE/plugins/fullcalendar/css/fullcalendar.min.css"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/fullcalendar/css/print").Include(
                "~/Scripts/AdminLTE/plugins/fullcalendar/css/print/fullcalendar.print.css"));

            // plugins | icheck
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/icheck/js").Include(
                "~/Scripts/AdminLTE/plugins/icheck/js/icheck.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/icheck/css").Include(
                "~/Scripts/AdminLTE/plugins/icheck/css/all.css"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/icheck/css/flat").Include(
                "~/Scripts/AdminLTE/plugins/icheck/css/flat/flat.css"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/icheck/css/sqare/blue").Include(
                "~/Scripts/AdminLTE/plugins/icheck/css/sqare/blue.css"));

            // plugins | input-mask
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/input-mask/js").Include(
                "~/Scripts/AdminLTE/plugins/input-mask/js/jquery.inputmask.js",
                "~/Scripts/AdminLTE/plugins/input-mask/js/jquery.inputmask.date.extensions.js",
                "~/Scripts/AdminLTE/plugins/input-mask/js/jquery.inputmask.extensions.js"));

            // plugins | ionicons
            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/ionicons/css").Include(
                "~/Scripts/AdminLTE/plugins/ionicons/css/ionicons.min.css"));

            // plugins | ionslider
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/ionslider/js").Include(
                "~/AdminLTE/plugins/ionslider/js/ion.rangeSlider.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/ionslider/css").Include(
                "~/Scripts/AdminLTE/plugins/ionslider/css/ion.rangeSlider.css",
                "~/Scripts/AdminLTE/plugins/ionslider/css/ion.rangeSlider.skinNice.css"));

            // plugins | jquery
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/jquery/js").Include(
                "~/Scripts/AdminLTE/plugins/jquery/js/jQuery-2.1.4.min.js"));

            // plugins | jquery-validate
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/jquery-validate/js").Include(
                "~/Scripts/AdminLTE/plugins/jquery-validate/js/jquery.validate*"));

            // plugins | jquery-ui
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/jquery-ui/js").Include(
                "~/Scripts/AdminLTE/plugins/jquery-ui/js/jquery-ui.min.js"));

            // plugins | jvectormap
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/jvectormap/js").Include(
                "~/Scripts/AdminLTE/plugins/jvectormap/js/jquery-jvectormap-1.2.2.min.js",
                "~/Scripts/AdminLTE/plugins/jvectormap/js/jquery-jvectormap-world-mill-en.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/jvectormap/css").Include(
                "~/Scripts/AdminLTE/plugins/jvectormap/css/jquery-jvectormap-1.2.2.css"));

            // plugins | knob
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/knob/js").Include(
                "~/Scripts/AdminLTE/plugins/knob/js/jquery.knob.js"));

            // plugins | morris
            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/morris/css").Include(
                "~/Scripts/AdminLTE/plugins/morris/css/morris.css"));

            // plugins | momentjs
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/momentjs/js").Include(
                "~/Scripts/AdminLTE/plugins/momentjs/js/moment.min.js"));

            // plugins | pace
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/pace/js").Include(
                "~/Scripts/AdminLTE/plugins/pace/js/pace.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/pace/css").Include(
                "~/Scripts/AdminLTE/plugins/pace/css/pace.min.css"));

            // plugins | slimscroll
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/slimscroll/js").Include(
                "~/Scripts/AdminLTE/plugins/slimscroll/js/jquery.slimscroll.min.js"));

            // plugins | sparkline
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/sparkline/js").Include(
                "~/Scripts/AdminLTE/plugins/sparkline/js/jquery.sparkline.min.js"));

            // plugins | timepicker
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/timepicker/js").Include(
                "~/Scripts/AdminLTE/plugins/timepicker/js/bootstrap-timepicker.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/timepicker/css").Include(
                "~/Scripts/AdminLTE/plugins/timepicker/css/bootstrap-timepicker.min.css"));

            // plugins | raphael
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/raphael/js").Include(
                "~/Scripts/AdminLTE/plugins/raphael/js/raphael-min.js"));

            // plugins | select2
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/select2/js").Include(
                "~/Scripts/AdminLTE/plugins/select2/js/select2.full.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/select2/css").Include(
                "~/Scripts/AdminLTE/plugins/select2/css/select2.min.css"));

            // plugins | morris
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/morris/js").Include(
                "~/Scripts/AdminLTE/plugins/morris/js/morris.min.js"));
        }
    }
}