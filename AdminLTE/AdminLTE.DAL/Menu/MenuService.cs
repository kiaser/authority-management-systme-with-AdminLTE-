using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLTE.DAL.Menu
{
   public class MenuService
    {
        /// <summary>
        /// 获取用户的菜单
        /// </summary>
        /// <returns></returns>
        public string GetMenuByUser()
        {
            using (AdminLteContext db = new AdminLteContext())
            {
                var menus = db.Menus.Where(t => t.IsDeleted == false).ToList();

                StringBuilder menuStringBuilder = new StringBuilder();

                foreach (var rootMenu in menus.Where(t => !t.ParentMenuCode.HasValue).OrderBy(t=>t.SortNo))
                {
                    menuStringBuilder.Append(
                        "<li class=\"treeview\"><a href=\"#\"><i class=\"fa fa-folder\"></i><span>" + rootMenu.Name +
                        "</span> <i class=\"fa fa-angle-left pull-right\"></i></a>");
                    menuStringBuilder.Append("<ul class=\"treeview-menu\">");
                    foreach (var childMenu in menus.Where(t => t.ParentMenuCode == rootMenu.MenuCode))
                    {
                        /*
                         <li id="left-sidebar-menu-charts-chartjs">
                         <a href="@Url.Action("ChartJs", "Charts")">
                         <i class="fa fa-circle-o"></i> ChartJS</a></li>
                         */
                        //menuStringBuilder.Append("<li ><a href=\"" + childMenu.Url + "\"<i class=\"" +
                        //                         childMenu.IconName + "\"</i>" + childMenu.Name + "</a></li>");
                        //menuStringBuilder.Append("<li ><a href=\"#\"><i class=\"fa fa-user\"></i>" + childMenu.Name + "</a></li>");

                        menuStringBuilder.Append("<li ><a href=\"" + childMenu.Url + "\"><i class=\"" +
                                                 childMenu.IconName + "\"></i>" +
                                                 childMenu.Name + "</a></li>");

                    }
                    menuStringBuilder.Append("</ul></li>");
                }
                return menuStringBuilder.ToString();
            }
        }
    }
}
