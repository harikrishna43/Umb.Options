using NUglify;
using System;
using System.Globalization;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.PublishedCache;

namespace Umb.Options.PropertyValueConverters
{
    public class UmbOptionsValueConverter : IPropertyValueConverter
    {
        public object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            if (inter == null)
                return null;

            inter = inter ?? String.Empty;
            string str = inter.ToString();
            switch (str)
            {
                case "ComponentWidth_Full":
                    return (object)UmbEnum.UmbOptions.ComponentWidth_Full;
                case "Sitemap_Monthly":
                    return (object)UmbEnum.UmbOptions.Sitemap_Monthly;
                case "BannerSize_Medium":
                    return (object)UmbEnum.UmbOptions.BannerSize_Medium;
                case "TextAlignment_Right":
                    return (object)UmbEnum.UmbOptions.TextAlignment_Right;
                case "SplitComponent_3070":
                    return (object)UmbEnum.UmbOptions.SplitComponent_3070;
                case "Newsletter_Mailchimp":
                    return (object)UmbEnum.UmbOptions.Newsletter_Mailchimp;
                case "WindowsOrder_3_Small":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_3_Small;
                case "BannerSize_Short":
                    return (object)UmbEnum.UmbOptions.BannerSize_Short;
                case "Sitemap_Always":
                    return (object)UmbEnum.UmbOptions.Sitemap_Always;
                case "ImageStyle_Square":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Square;
                case "Sitemap_Weekly":
                    return (object)UmbEnum.UmbOptions.Sitemap_Weekly;
                case "TextPosition_After":
                    return (object)UmbEnum.UmbOptions.TextPosition_After;
                case "ListingStyle_Vertical":
                    return (object)UmbEnum.UmbOptions.ListingStyle_Vertical;
                case "ItemsPerRow_4":
                    return (object)UmbEnum.UmbOptions.ItemsPerRow_4;
                case "ItemsPerRow_3":
                    return (object)UmbEnum.UmbOptions.ItemsPerRow_3;
                case "ItemsPerRow_2":
                    return (object)UmbEnum.UmbOptions.ItemsPerRow_2;
                case "ItemsPerRow_1":
                    return (object)UmbEnum.UmbOptions.ItemsPerRow_1;
                case "SplitComponent_Even":
                    return (object)UmbEnum.UmbOptions.SplitComponent_Even;
                case "WindowsOrder_3_Big":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_3_Big;
                case "ListingStyle_Grid":
                    return (object)UmbEnum.UmbOptions.ListingStyle_Grid;
                case "RepeatableLayout_Tabbed":
                    return (object)UmbEnum.UmbOptions.RepeatableLayout_Tabbed;
                case "ImageStyle_Wide":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Wide;
                case "ImageStyle_Circle":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Circle;
                case "PageLayout_Center":
                    return (object)UmbEnum.UmbOptions.PageLayout_Center;
                case "ImageStyle_Landscape":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Landscape;
                case "TextAlignment_Center":
                    return (object)UmbEnum.UmbOptions.TextAlignment_Center;
                case "SplitComponent_7030":
                    return (object)UmbEnum.UmbOptions.SplitComponent_7030;
                case "PageLayout_Right":
                    return (object)UmbEnum.UmbOptions.PageLayout_Right;
                case "Sitemap_Never":
                    return (object)UmbEnum.UmbOptions.Sitemap_Never;
                case "WindowsOrder_4_Small":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_4_Small;
                case "Sitemap_Yearly":
                    return (object)UmbEnum.UmbOptions.Sitemap_Yearly;
                case "ReusableComponentStyle_Stacked":
                    return (object)UmbEnum.UmbOptions.ReusableComponentStyle_Stacked;
                case "ImageStyle_Portrait":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Portrait;
                case "ComponentWidth_Wide":
                    return (object)UmbEnum.UmbOptions.ComponentWidth_Wide;
                case "Sitemap_Hourly":
                    return (object)UmbEnum.UmbOptions.Sitemap_Hourly;
                case "RepeatableLayout_Accordion":
                    return (object)UmbEnum.UmbOptions.RepeatableLayout_Accordion;
                case "PageLayout_Wide":
                    return (object)UmbEnum.UmbOptions.PageLayout_Wide;
                case "ComponentWidth_Center":
                    return (object)UmbEnum.UmbOptions.ComponentWidth_Center;
                case "TextPosition_Before":
                    return (object)UmbEnum.UmbOptions.TextPosition_Before;
                case "Newsletter_CM":
                    return (object)UmbEnum.UmbOptions.Newsletter_CM;
                case "BannerSize_Takeover":
                    return (object)UmbEnum.UmbOptions.BannerSize_Takeover;
                case "WindowsOrder_4":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_4;
                case "WindowsOrder_3":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_3;
                case "WindowsOrder_2":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_2;
                case "WindowsOrder_1":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_1;
                case "TextAlignment_Left":
                    return (object)UmbEnum.UmbOptions.TextAlignment_Left;
                case "Layouts_Above":
                    return (object)UmbEnum.UmbOptions.Layouts_Above;
                case "Layouts_Boxed":
                    return (object)UmbEnum.UmbOptions.Layouts_Boxed;
                case "ReusableComponentStyle_Tabbed":
                    return (object)UmbEnum.UmbOptions.ReusableComponentStyle_Tabbed;
                case "WindowsOrder_4_Big":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_4_Big;
                case "PageLayout_CenterAlt":
                    return (object)UmbEnum.UmbOptions.PageLayout_CenterAlt;
                case "PageLayout_Left":
                    return (object)UmbEnum.UmbOptions.PageLayout_Left;
                case "Sitemap_Daily":
                    return (object)UmbEnum.UmbOptions.Sitemap_Daily;
                case "ListingStyle_Single":
                    return (object)UmbEnum.UmbOptions.ListingStyle_Single;
            }
            return (object)UmbEnum.UmbOptions.EMPTY;
        }

        public object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            return inter != null ? (object)(string)inter : (object)String.Empty;
        }

        public object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source, bool preview)
        {
            source = source ?? String.Empty;
            string str = source.ToString();
            switch (str)
            {
                case "ComponentWidth_Full":
                    return (object)UmbEnum.UmbOptions.ComponentWidth_Full;
                case "Sitemap_Monthly":
                    return (object)UmbEnum.UmbOptions.Sitemap_Monthly;
                case "BannerSize_Medium":
                    return (object)UmbEnum.UmbOptions.BannerSize_Medium;
                case "TextAlignment_Right":
                    return (object)UmbEnum.UmbOptions.TextAlignment_Right;
                case "SplitComponent_3070":
                    return (object)UmbEnum.UmbOptions.SplitComponent_3070;
                case "Newsletter_Mailchimp":
                    return (object)UmbEnum.UmbOptions.Newsletter_Mailchimp;
                case "WindowsOrder_3_Small":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_3_Small;
                case "BannerSize_Short":
                    return (object)UmbEnum.UmbOptions.BannerSize_Short;
                case "Sitemap_Always":
                    return (object)UmbEnum.UmbOptions.Sitemap_Always;
                case "ImageStyle_Square":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Square;
                case "Sitemap_Weekly":
                    return (object)UmbEnum.UmbOptions.Sitemap_Weekly;
                case "TextPosition_After":
                    return (object)UmbEnum.UmbOptions.TextPosition_After;
                case "ListingStyle_Vertical":
                    return (object)UmbEnum.UmbOptions.ListingStyle_Vertical;
                case "ItemsPerRow_4":
                    return (object)UmbEnum.UmbOptions.ItemsPerRow_4;
                case "ItemsPerRow_3":
                    return (object)UmbEnum.UmbOptions.ItemsPerRow_3;
                case "ItemsPerRow_2":
                    return (object)UmbEnum.UmbOptions.ItemsPerRow_2;
                case "ItemsPerRow_1":
                    return (object)UmbEnum.UmbOptions.ItemsPerRow_1;
                case "SplitComponent_Even":
                    return (object)UmbEnum.UmbOptions.SplitComponent_Even;
                case "WindowsOrder_3_Big":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_3_Big;
                case "ListingStyle_Grid":
                    return (object)UmbEnum.UmbOptions.ListingStyle_Grid;
                case "RepeatableLayout_Tabbed":
                    return (object)UmbEnum.UmbOptions.RepeatableLayout_Tabbed;
                case "ImageStyle_Wide":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Wide;
                case "ImageStyle_Circle":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Circle;
                case "PageLayout_Center":
                    return (object)UmbEnum.UmbOptions.PageLayout_Center;
                case "ImageStyle_Landscape":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Landscape;
                case "TextAlignment_Center":
                    return (object)UmbEnum.UmbOptions.TextAlignment_Center;
                case "SplitComponent_7030":
                    return (object)UmbEnum.UmbOptions.SplitComponent_7030;
                case "PageLayout_Right":
                    return (object)UmbEnum.UmbOptions.PageLayout_Right;
                case "Sitemap_Never":
                    return (object)UmbEnum.UmbOptions.Sitemap_Never;
                case "WindowsOrder_4_Small":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_4_Small;
                case "Sitemap_Yearly":
                    return (object)UmbEnum.UmbOptions.Sitemap_Yearly;
                case "ReusableComponentStyle_Stacked":
                    return (object)UmbEnum.UmbOptions.ReusableComponentStyle_Stacked;
                case "ImageStyle_Portrait":
                    return (object)UmbEnum.UmbOptions.ImageStyle_Portrait;
                case "ComponentWidth_Wide":
                    return (object)UmbEnum.UmbOptions.ComponentWidth_Wide;
                case "Sitemap_Hourly":
                    return (object)UmbEnum.UmbOptions.Sitemap_Hourly;
                case "RepeatableLayout_Accordion":
                    return (object)UmbEnum.UmbOptions.RepeatableLayout_Accordion;
                case "PageLayout_Wide":
                    return (object)UmbEnum.UmbOptions.PageLayout_Wide;
                case "ComponentWidth_Center":
                    return (object)UmbEnum.UmbOptions.ComponentWidth_Center;
                case "TextPosition_Before":
                    return (object)UmbEnum.UmbOptions.TextPosition_Before;
                case "Newsletter_CM":
                    return (object)UmbEnum.UmbOptions.Newsletter_CM;
                case "BannerSize_Takeover":
                    return (object)UmbEnum.UmbOptions.BannerSize_Takeover;
                case "WindowsOrder_4":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_4;
                case "WindowsOrder_3":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_3;
                case "WindowsOrder_2":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_2;
                case "WindowsOrder_1":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_1;
                case "TextAlignment_Left":
                    return (object)UmbEnum.UmbOptions.TextAlignment_Left;
                case "Layouts_Above":
                    return (object)UmbEnum.UmbOptions.Layouts_Above;
                case "Layouts_Boxed":
                    return (object)UmbEnum.UmbOptions.Layouts_Boxed;
                case "ReusableComponentStyle_Tabbed":
                    return (object)UmbEnum.UmbOptions.ReusableComponentStyle_Tabbed;
                case "WindowsOrder_4_Big":
                    return (object)UmbEnum.UmbOptions.WindowsOrder_4_Big;
                case "PageLayout_CenterAlt":
                    return (object)UmbEnum.UmbOptions.PageLayout_CenterAlt;
                case "PageLayout_Left":
                    return (object)UmbEnum.UmbOptions.PageLayout_Left;
                case "Sitemap_Daily":
                    return (object)UmbEnum.UmbOptions.Sitemap_Daily;
                case "ListingStyle_Single":
                    return (object)UmbEnum.UmbOptions.ListingStyle_Single;
            }
            return (object)UmbEnum.UmbOptions.EMPTY;
        }

        public PropertyCacheLevel GetPropertyCacheLevel(IPublishedPropertyType propertyType) => PropertyCacheLevel.Element;

        public Type GetPropertyValueType(IPublishedPropertyType propertyType) => typeof(UmbEnum.UmbOptions);

        public bool IsConverter(IPublishedPropertyType propertyType) => propertyType.EditorAlias == "umbOptions";

        public bool? IsValue(object value, PropertyValueLevel level)
        {
            return value != null;
        }
    }
}
