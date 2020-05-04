using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace Justice.Questionary.Data
{
    public class AmPivotGridLoclizationProvider : PivotGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case PivotStringId.GrandTotal: return "Ընդամենը";
                case PivotStringId.Values: return "Արժեքներ";
                case PivotStringId.TotalP0: return "Ընդամենը {0}";
                case PivotStringId.Product: return "Արտադրյալ";
                case PivotStringId.StdDevP: return "StdDevP";
                case PivotStringId.Min: return "Մինիմում";
                case PivotStringId.Count: return "Քանակ";
                case PivotStringId.StdDev: return "StdDev";
                case PivotStringId.Sum: return "Գումար";
                case PivotStringId.Average: return "Միջին";
                case PivotStringId.Var: return "Փոփոխական";
                case PivotStringId.VarP: return "VarP";
                case PivotStringId.GroupP0AggregateP1: return "{0} {1}";
                case PivotStringId.YearGroupField: return "Տարի";
                case PivotStringId.MonthGroupField: return "Ամիս";
                case PivotStringId.QuarterGroupField: return "Եռամսյակ";
                case PivotStringId.WeekGroupField: return "Շաբաթ";
                case PivotStringId.DayGroupField: return "Օր";
                case PivotStringId.HourGroupField: return "Ժամ";
                case PivotStringId.MinuteGroupField: return "Րոպե";
                case PivotStringId.SecondsGroupField: return "Վարկյան";
                case PivotStringId.P0Total: return "{0} Ընդամենև";
                case PivotStringId.PivotAggregateP0ofP1: return "{0} {1}-ից";
                case PivotStringId.ExpandCollapseMenuItem: return "Բացել";
                case PivotStringId.CollapseAllMenuItems: return "Փակել Ամբողջը";
                case PivotStringId.ExpandAllMenuItems: return "Բացել Ամբողջը";
                case PivotStringId.CopyMenuItem: return "Կրկնօրինակել";
                case PivotStringId.HideMenuItem: return "Թաքցնել";
                case PivotStringId.SortMenuItem: return "Դասավորել";
                case PivotStringId.BestFitMenuItem: return "Best Fit";
                case PivotStringId.ReloadDataMenuItem: return "Կրկին ներբեռնել տվյալները";
                case PivotStringId.FieldListMenuItem: return "Ցուցադրել դաշտերի ցուցակը";
                case PivotStringId.SortAZMenuItem: return "&Դասավորել աճման կարգով";
                case PivotStringId.SortZAMenuItem: return "Դ&ասավորել նվազման կարգով";
                case PivotStringId.SortOptionsMenuItem: return "&Այլ դասավորման տարբերակներ ...";
                case PivotStringId.ClearFilterMenuItem: return "&Մաքրել Ֆիլտրերը";
                case PivotStringId.LabelFilterMenuItem: return "&Պիտակի Ֆիլտր";

                case PivotStringId.ValueFilterMenuItem: return "&Արժեքի Ֆիլտր";
                case PivotStringId.AllNode: return "(Ընտրել բոլորը)";
                case PivotStringId.FilterMenuItemEqual: return "&Հավասար է...";
                case PivotStringId.FilterMenuItemDoesNotEquals: return "Հավասասար &չէ...";
                case PivotStringId.FilterMenuItemBeginsWith: return "Սկսվում $է ...";
                case PivotStringId.FilterMenuItemDoesNotBeginWith: return "Չի &սկսվում...";
                case PivotStringId.FIlterMenuItemEndsWith: return "Ավարտվում &է...";
                case PivotStringId.FilterMenuItemDoesNotEndsWith: return "Չի &Ավարտվում...";
                case PivotStringId.FilterMenuItemContains: return "Պարունակում &է...";
                case PivotStringId.FilterMenuItemDoesNotContain: return "&Չի պարունակում...";
                case PivotStringId.FilterMenuItemGreaterThan: return "&Մեծ է քան...";
                case PivotStringId.FilterMenuItemGreaterThanOrEqualTo: return "Մեծ կամ հավասար է &քան...";
                case PivotStringId.FilterMenuItemLessThan: return "&Փոքր է քան...";
                case PivotStringId.FilterMenuItemLessThanOrEqualTo: return "Փոքր կամ &հավասար է քան...";
                case PivotStringId.FilterMenuItemBetween: return "&Միջակայքում է...";
                case PivotStringId.FilterMenuItemNotBetween: return "Միջակայքում &չէ...";
                case PivotStringId.TopTenItem: return "&Առաջին 10-յակը...";
                case PivotStringId.AllNodeSelectAllSearchResult: return "(Ընտրել ամբողջը Որոնման արդյունքը)";
                case PivotStringId.FilterMenuAvailableFilters: return "&Հասանելի ֆիլրեր";
                case PivotStringId.CheckBoxMenuItem: return "Ընտրել մեկից ավել տարբերակներ";

                case PivotStringId.CalculationOptionsDialogNoCalculation: return "Հաշվարկ չկատարել";
                case PivotStringId.CalculationOptionsDialogPrevious: return "(նախորդ)";
                case PivotStringId.CalculationOptionsDialogNext: return "(հաջորդ)";
                case PivotStringId.CalculationOptionsDialogGrandTotal: return "% Աղյուսակի Ամփոփներից";
                case PivotStringId.CalculationOptionsDialogColumnTotal: return "% Սյան Ամփոփներից";
                case PivotStringId.CalculationOptionsDialogRowTotal: return "% Տողի Ամփոփներից";
                case PivotStringId.CalculationOptionsDialogOf: return "% ";
                case PivotStringId.CalculationOptionsDialogDifferenceFrom: return "Տարբերություն - ";
                case PivotStringId.CalculationOptionsDialogPercentDifferenceFrom: return "% Տարբերություն";
                case PivotStringId.CalculationOptionsDialogRunningTotalIn: return "Ընթացիկ Ամփոփներ";
                case PivotStringId.CalculationOptionsDialogPercentRunningTotalIn: return "% Ընթացիկ Ամփոփներից";
                case PivotStringId.CalculationOptionsDialogRankSmallestToLargest: return "Դասակարհել Փոքրից Մեծ";
                case PivotStringId.CalculationOptionsDialogRankLargestToSmallest: return "Դասակարգել Մեծից Փոքր";
                case PivotStringId.CalculationOptionsDialogIndex: return "Ինդեքս";
                case PivotStringId.CalculationOptionsDialogShowValueAs: return "Ցուցադրել արժեքը որպես ({0})";

                case PivotStringId.LabelFilterOptionsDialogEquals: return "հավասար է";
                case PivotStringId.LabelFilterOptionsDialogDoesNotEqual: return "հավասար չէ";
                case PivotStringId.LabelFilterOptionsDialogIsGreaterThen: return "մեծ է";
                case PivotStringId.LabelFilterOptionsDialogIsGreaterThanOrEqualTo: return "մեծ է կամ հավասար";
                case PivotStringId.LabelFilterOptionsDialogIsLessThan: return "փոքր է";
                case PivotStringId.LabelFilterOptionsDialogIsLessThanOrEqualTo: return "փոքր է կամ հավասար";
                case PivotStringId.LabelFilterOptionsDialogBeginsWith: return "սկսվում է";
                case PivotStringId.LabelFilterOptionsDialogDoesNotBeginWith: return "րի սկսվում";
                case PivotStringId.LabelFilterOptionsDialogEndsWith: return "ավարտվում է";
                case PivotStringId.LabelFilterOptionsDialogDoesNotEndsWith: return "չի ավարտվում";
                case PivotStringId.LabelFilterOptionsDialogContains: return "պարունակում է";
                case PivotStringId.LabelFilterOptionsDialogDoesNotContain: return "չի պարունակում";
                case PivotStringId.LabelFilterOptionsDialogIsBetween: return "միջակայքում է";
                case PivotStringId.LabelFilterOptionsDialogIsNotBetween: return "միջակայքում չէ";
                case PivotStringId.LabelFilterOptionsDialogLabelFilter: return "Պիտակի Ֆիլտր ({0})";

                case PivotStringId.NumberFormatOptionsDialogCustomFormat: return "Այլ ձևաչափ";
                case PivotStringId.NumberFormatOptionsDialogFixedPoint: return "Ստորակետից հետո 2 նիշ";
                case PivotStringId.NumberFormatOptionsDialogPrefixedCurrency: return "$ նշան նախորդող ստորակետից հետո 2 նիշանոց թվին";
                case PivotStringId.NumberFormatOptionsDialogPostfixedCurrency: return "€ նշան հաջորդող ստորակետից հետո 2 նիշանոց թվին";
                case PivotStringId.NumberFormatOptionsDialogPostfixedTemperatureC: return "°C նշան նախորդող ստորակետից հետո 2 նիշանոց թվին";
                case PivotStringId.NumberFormatOptionsDialogPostfixedTemperatureF: return "°F նշան հաջորդող ստորակետից հետո 2 նիշանոց թվին";
                case PivotStringId.NumberFormatOptionsDialogExponential: return "Էքսպոնենտալ (գիտական)";
                case PivotStringId.NumberFormatOptionsDialogFormatOptions: return "Ձևաչափի տարբերակներ";
                case PivotStringId.NumberFormatOptionsDialogFormatOptionsDescription: return "Ձևաչափի տարբերակներ ({0})";

                case PivotStringId.SortOptionsDialogSortOptions: return "Դասավորման տարբերակներ ({0})";
                case PivotStringId.Top10FilterOptionsDialogTop: return "Առաջին";
                case PivotStringId.Top10FilterOptionsDialogBottom: return "Վերջին";
                case PivotStringId.Top10FilterOptionsDialogItems: return "Արժեքներ";
                case PivotStringId.Top10FilterOptionsDialogPercent: return "Տոկոս";
                case PivotStringId.Top10FilterOptionsDialogTop10: return "Առաձին 10-յակը Ֆիլտր  ({0})";
                case PivotStringId.ValueFilter: return "Արժեքների Ֆիլտր ({0})";

                case PivotStringId.AggregateOptionsDialogGroupBoxText: return "Գումարել Արժեքները ";
                case PivotStringId.AggregateOptionsDialogLabelCustomName: return "Այլ անուն:";
                case PivotStringId.AggregateOptionsDialogLabelDescription: return "Ընտրեք հաշվարկի մեթոդը, որն ուզում եք կիրառել ընտրված դաշտերը ագրեգացնելու համար:";
                case PivotStringId.AggregateOptionsDialogLabelField: return "FieLabelld Անուն";
                case PivotStringId.AggregateOptionsDialogLabelSourceName: return "Աղբյուրի անուն:";
                case PivotStringId.AggregateOptionsDialogText: return "AggregateOptionsDialog";

                case PivotStringId.DialogButtonCancel: return "Փակել";
                case PivotStringId.DialogButtonOK: return "Կատարել";

                case PivotStringId.CalculationOptionsDialogText: return "CalculationOptionsDialog";
                case PivotStringId.CalculationOptionsDialogLabelBaseItem: return "Հիմնական Արժեք:";
                case PivotStringId.CalculationOptionsDialogLabelBaseField: return "Հիմնական Դաշտ:";
                case PivotStringId.CalculationOptionsDialogGroupBoxText: return "Ցուցադրել Արժեքը որպես";

                case PivotStringId.LabelFilterOptionsDialogGroupBoxText: return "Ցուցադրել արժեքները, որոնց պիտակը";
                case PivotStringId.LabelFilterOptionsDialogText: return "LabelFilterOptionsDialog";
                case PivotStringId.LabelFilterOptionsDialogLabelAnd: return "և";

                case PivotStringId.NumberFormatOptionsDialogFormat: return "Ձևաչափ";
                case PivotStringId.NumberFormatOptionsDialogLabelDescription:
                    return "Ձևաչափը պետք է արտահայտի չափման տեսակը: ($, ¥, €, kg., lb.," +
" m.) Ձևաչափը օգտագործվում է հիմնական հաշվարկների համար, ինչպիսիք են Գումար, Միջին, Միմիմում, Մաքսիմում  այլ գործողություններ.";
                case PivotStringId.NumberFormatOptionsDialogText: return "NumberFormatOptionsDialog";
                case PivotStringId.NumberFormatOptionsDialogGroupBoxText: return "Հիմնական ձևաչափ";

                case PivotStringId.SortOptionsDialogAscending: return "Դասավորել Փոքրից Մեծ:";
                case PivotStringId.SortOptionsDialogDescending: return "Դասավորել Փոքրից Մեծ:";
                case PivotStringId.SortOptionsDialogGroupBoxText: return "Դասավորման տարբերակներ";
                case PivotStringId.SortOptionsDialogText: return "SortOptionsDialog";

                case PivotStringId.Top10FilterOptionsDialogGroupBoxText: return "Ցուցադրել";
                case PivotStringId.Top10FilterOptionsDialogLabelBy: return " - ";
                case PivotStringId.Top10FilterOptionsDialogText: return "Top10FilterOptionsDialog";

                case PivotStringId.ValueFilterOptionsDialogGroupBox: return "Ցուցադրել արժեքները, որոնց համար";

                case PivotStringId.ValueFilterOptionsDialogText: return "ValueFilterOptionsDialog";
                case PivotStringId.DragDataItemsHere: return "Տեղափոխեք Արժեքի տվյալները այստեղ";
                case PivotStringId.DragColumnItemsHere: return "Տեղափոխեք Սյան տվյալները այստեղ";
                case PivotStringId.DragItemsHere: return "Տեղափոխեք տվյալները այստեղ";
                case PivotStringId.DragFilterItemsHere: return "Տեղափոխեք Ձևաչափի տվյալները այստեղ";
                case PivotStringId.DragRowItemsHere: return "Տեղափոխեք Տողի տվյալները այստեղ";
                case PivotStringId.ResultItemFormat: return "Բանալի: {0}; Ագրեգատներ: {1}";
                case PivotStringId.Error: return "Սխալ";
                case PivotStringId.KpiSchemaElementValidatorError: return "Պետք է լինի գոնե մեկ KPI(Կարևորագույն Կետի Ինդիկատոր) անդամ հայտարարված (Ցանկալի արդյունք, Կարգավիճակ, Տենդենց, Արժեք)";
                case PivotStringId.SchemaElementValidatorMissingPropertyFormat: return "Անհրաժեշտ հատկանիշը բացակայում է: {0}";
                case PivotStringId.AdomdCellInfoToStringFormat: return "Հերթականություն: {0} | Արժեք: {1}";
                case PivotStringId.Aggregates: return "Ագրեգատներ";
                case PivotStringId.FilterMenuTextBoxItemNullText: return "Փնտրել...";
                case PivotStringId.FieldChooserFormButtonAdd: return "Ավելացնել - ";
                case PivotStringId.FieldChooserFormFields: return "Դաշտեր:";
                case PivotStringId.FieldChooserFormText: return "Դաշտի Ընտրություն";

                case PivotStringId.FieldChooserFormColumnArea: return "Սյուներ";
                case PivotStringId.FieldChooserFormDataArea: return "Արժեքներ";
                case PivotStringId.FieldChooserFormFilterArea: return "Ձևաչափեր";
                case PivotStringId.FieldChooserFormRowArea: return "Տողեր";

                case PivotStringId.FieldListlabelChooseFields: return "Ընտրեք դաշտերը:";
                case PivotStringId.FieldListButtonUpdate: return "Խմբագրել";
                case PivotStringId.FieldListCheckBoxDeferUpdate: return "Հետաձգել Նախագծի Խմբագրումը";
                case PivotStringId.FieldListLabelDrag: return "Տեղափոխել սունակները համապատասխան դաշտեր:";

                case PivotStringId.FieldListLabelRowLabels: return "Տողի Պիտակներ";
                case PivotStringId.FieldListLabelColumnLabels: return "Սյան Պիտակներ";
                case PivotStringId.FieldListLabelReportFilter: return "Հաշվետվության Ձևաչափեր";

                case PivotStringId.None: return "Ոչ Մեկը";
                case PivotStringId.PrintSettingsFitWidth: return "Հարմարեցնել Լայնությունը";
                case PivotStringId.PrintSettingsFitHeight: return "Հարմարեցնել Բարձրությունը";
                case PivotStringId.PrintSettingsCompact: return "Ամփոփ";
                case PivotStringId.PrintSettingsTabular: return "Աղյուսակային";
                case PivotStringId.PrintSettingsFitAll: return "Հարմարեցնել Ամբողջը";

                case PivotStringId.PrintSettingsPrintOrder: return "Տպման հերթականություն";
                case PivotStringId.PrintSettingsThenOver: return "Ներքև ու առաջ";
                case PivotStringId.PrintSettingsThenDown: return "Առաջ ու ներքև";
                case PivotStringId.PrintSettingsFontsAndColors: return "Տառատեսակներ և Գույներ";
                case PivotStringId.PrintSettingsBackground: return "Ետին Ֆոն";
                case PivotStringId.PrintSettingsNone: return "(ոչինչ)";
                case PivotStringId.PrintSettingsFont: return "Տառատեսակ";
                case PivotStringId.PrintSettingsGrantTotal: return "Ամփոփի բջիջներ:";
                case PivotStringId.PrintSettingsDescriptors: return "Ագգրեգատ/խումբ նկարագրիչներ:";
                case PivotStringId.PrintSettingsSubTotal: return "ԵնթաԱմփոփի բջիջներ:";
                case PivotStringId.PrintSettingsHeaderCells: return "Սյուն/տող գլխագրի բջիջներ:";
                case PivotStringId.PrintSettingsDataCells: return "Տվյալների բջիջներ:";
                case PivotStringId.PrintSettingsGridLinesColor: return "Աղյուսակի գծերի գույներ:";
                case PivotStringId.PrintSettingsSettings: return "Կառավարում";
                case PivotStringId.PrintSettingsLayuotType: return "Նախագծի Տեսակ:";
                case PivotStringId.PrintSettingsScaleMode: return "Մասշտաբի տարբերակ:";
                case PivotStringId.PrintSettingsPrintSelectionOnly: return "Տպել Ընտրվածը";
                case PivotStringId.PrintSettingsShowGridLines: return "Ցուցադրել աղյուսակի գծերը";
                case PivotStringId.CollapseMenuItem: return "Փակել";
                case PivotStringId.CalcualtedFields: return "Հաշվարկել Դաշտերը";
                case PivotStringId.Max: return "Մաքսիմում";
                case PivotStringId.NullValue: return "(դատարկ)";
                default: return base.GetLocalizedString(id);
            }
        }
    }
}
