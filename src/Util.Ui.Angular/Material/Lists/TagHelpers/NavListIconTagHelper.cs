﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Configs;
using Util.Ui.Enums;
using Util.Ui.Material.Enums;
using Util.Ui.Material.Lists.Renders;
using Util.Ui.Renders;
using Util.Ui.TagHelpers;

namespace Util.Ui.Material.Lists.TagHelpers {
    /// <summary>
    /// 导航列表图标，该标签应放到 util-nav-list-item 中
    /// </summary>
    [HtmlTargetElement( "util-nav-list-icon",TagStructure = TagStructure.WithoutEndTag)]
    public class NavListIconTagHelper : TagHelperBase {
        /// <summary>
        /// Material图标
        /// </summary>
        public MaterialIcon MaterialIcon { get; set; }
        /// <summary>
        /// Font Awesome图标
        /// </summary>
        public FontAwesomeIcon FontAwesomeIcon { get; set; }
        /// <summary>
        /// 图标大小
        /// </summary>
        public IconSize Size { get; set; }
        /// <summary>
        /// 图标位置
        /// </summary>
        public XPosition Position { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new NavListIconRender( new Config( context ) );
        }
    }
}