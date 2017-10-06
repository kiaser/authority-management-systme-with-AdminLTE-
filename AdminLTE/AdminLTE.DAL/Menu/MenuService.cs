using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Core.Data;


namespace AdminLTE.DAL.Menu
{
   public class MenuService:BaseService<Model.Entities.Menu>
    {
        /// <summary>
        /// 获取用户菜单
        /// </summary>
        /// <returns></returns>
        public string GetMenuByUser()
        {
            var menus = GetList(t => t.IsDeleted == false);

            StringBuilder menuStringBuilder = new StringBuilder();

            foreach (var rootMenu in menus.Where(t => !t.ParentMenuCode.HasValue).OrderBy(t => t.SortNo))
            {
                menuStringBuilder.Append(
                    "<li class=\"treeview\" id=\"" + rootMenu.MenuCode + "\"><a href=\"#\"><i class=\"fa fa-folder\"></i><span>" + rootMenu.Name +
                    "</span> <i class=\"fa fa-angle-left pull-right\"></i></a>");
                menuStringBuilder.Append("<ul class=\"treeview-menu\">");

                foreach (var childMenu in menus.Where(t => t.ParentMenuCode == rootMenu.MenuCode))
                {
                    menuStringBuilder.Append("<li id=\"" + childMenu.MenuCode + "\"><a href=\"" + childMenu.Url +
                                             "\"><i class=\"" +
                                             childMenu.IconName + "\"></i>" +
                                             childMenu.Name + "</a></li>");

                }
                menuStringBuilder.Append("</ul></li>");
            }
            return menuStringBuilder.ToString();
        }
    }
}
