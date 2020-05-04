using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace Justice.Questionary.Data
{
    public class AmRadGridLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue: return "Անհրաժեշտ է ընտրել վավեր բջջի արժեք";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue: return "Անհրաժեշտ է դնել վավեր բջջի արժեք";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues: return "Անհրաժեշտ է ընտրել վավեր բջջի արժեքներ";
                case RadGridStringId.ConditionalFormattingPleaseSetValidExpression: return "Անհրաժեշտ է դնել վավեր արտահայտություն";
                case RadGridStringId.ConditionalFormattingItem: return "Նմուշ";

                case RadGridStringId.ConditionalFormattingInvalidParameters: return "Սխալ պարամետրեր";
                case RadGridStringId.FilterFunctionBetween: return "Միյակայք";
                case RadGridStringId.FilterFunctionContains: return "Պարունակում է";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Չի պարունակում";
                case RadGridStringId.FilterFunctionEndsWith: return "Ավարտվում է";
                case RadGridStringId.FilterFunctionEqualTo: return "Հավասար է";
                case RadGridStringId.FilterFunctionGreaterThan: return "Մեծ է քան";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Մեծ կամ հավասար է քան";
                case RadGridStringId.FilterFunctionIsEmpty: return "Դատարկ է";
                case RadGridStringId.FilterFunctionIsNull: return "Անհայտ արծեք է";
                case RadGridStringId.FilterFunctionLessThan: return "Փոքր է քան";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Փոթր կամ հավասար է քան";
                case RadGridStringId.FilterFunctionNoFilter: return "Ֆիլտրը բացակայում է";
                case RadGridStringId.FilterFunctionNotBetween: return "Միջակայքում չէ";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Հավասար չէ";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Դատարկ չէ";
                case RadGridStringId.FilterFunctionNotIsNull: return "Անհայտ չէ";
                case RadGridStringId.FilterFunctionStartsWith: return "Սկսվում է";
                case RadGridStringId.FilterFunctionCustom: return "Այլ";

                case RadGridStringId.FilterOperatorBetween: return "Միյակայքում է";
                case RadGridStringId.FilterOperatorContains: return "Պարունակում է";
                case RadGridStringId.FilterOperatorDoesNotContain: return "Չի Պարունակում";
                case RadGridStringId.FilterOperatorEndsWith: return "Ավարտվում է";
                case RadGridStringId.FilterOperatorEqualTo: return "Հավասար է";
                case RadGridStringId.FilterOperatorGreaterThan: return "Մեծ է";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "Մեծ է կամ հավասար";
                case RadGridStringId.FilterOperatorIsEmpty: return "Դատարկ է";
                case RadGridStringId.FilterOperatorIsNull: return "Անհայտ է";
                case RadGridStringId.FilterOperatorLessThan: return "Փոքր է";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "Փոքր է կամ հավասար";
                case RadGridStringId.FilterOperatorNoFilter: return "Ֆիլտրը բացակայում է";
                case RadGridStringId.FilterOperatorNotBetween: return "Միջակայքւմ չէ";
                case RadGridStringId.FilterOperatorNotEqualTo: return "Հավասար չէ";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "Դատարկ չէ";
                case RadGridStringId.FilterOperatorNotIsNull: return "Անհայտ չէ";
                case RadGridStringId.FilterOperatorStartsWith: return "Սկսվում է";
                case RadGridStringId.FilterOperatorIsLike: return "Նման է";
                case RadGridStringId.FilterOperatorNotIsLike: return "Նման չէ";
                case RadGridStringId.FilterOperatorIsContainedIn: return "Պարունակվում է";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "Չի Պարունակվում";
                case RadGridStringId.FilterOperatorCustom: return "Այլ";

                case RadGridStringId.CustomFilterMenuItem: return "Այլ";
                case RadGridStringId.CustomFilterDialogCaption: return "RadGridView Ֆիլտրի պատուհան [{0}]";
                case RadGridStringId.CustomFilterDialogLabel: return "Որոշ տողեր:";
                case RadGridStringId.CustomFilterDialogRbAnd: return "ԵՎ";
                case RadGridStringId.CustomFilterDialogRbOr: return "Կամ";
                case RadGridStringId.CustomFilterDialogBtnOk: return "Կատարել";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Փակել";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Ոչ";
                case RadGridStringId.CustomFilterDialogTrue: return "Ճիշտ";
                case RadGridStringId.CustomFilterDialogFalse: return "Սխալ";

                case RadGridStringId.FilterMenuBlanks: return "Դատարկ";
                case RadGridStringId.FilterMenuAvailableFilters: return "Հասանելի ֆիլտրեր";
                case RadGridStringId.FilterMenuSearchBoxText: return "Փնտրել...";
                case RadGridStringId.FilterMenuClearFilters: return "Մաքրել Ֆիլտրերը";
                case RadGridStringId.FilterMenuButtonOK: return "Կատարել";
                case RadGridStringId.FilterMenuButtonCancel: return "Փակել";
                case RadGridStringId.FilterMenuSelectionAll: return "Բելերը";
                case RadGridStringId.FilterMenuSelectionAllSearched: return "Բոլոր Փնտրման Արդյունքները";
                case RadGridStringId.FilterMenuSelectionNull: return "Անհայտ";
                case RadGridStringId.FilterMenuSelectionNotNull: return "Ոչ Անհայտ";

                case RadGridStringId.FilterFunctionSelectedDates: return "Ֆիլտրել որոշակի ամսաթվերով:";
                case RadGridStringId.FilterFunctionToday: return "Այսօր";
                case RadGridStringId.FilterFunctionYesterday: return "Երեկ";
                case RadGridStringId.FilterFunctionDuringLast7days: return "Նախորդ 7 օրերի ընթացքում";

                case RadGridStringId.FilterLogicalOperatorAnd: return "ԵՎ";
                case RadGridStringId.FilterLogicalOperatorOr: return "ԿԱՄ";
                case RadGridStringId.FilterCompositeNotOperator: return "ՈՉ";

                case RadGridStringId.DeleteRowMenuItem: return "Ջնջել Տողը";
                case RadGridStringId.SortAscendingMenuItem: return "Դասավորել Աճման կարգով";
                case RadGridStringId.SortDescendingMenuItem: return "Դասավորել Նվազման կարգով";
                case RadGridStringId.ClearSortingMenuItem: return "Մաքրել Դասավորությունը";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Պայմանական Ձևաչափեր";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Խմբավորել տվյալ սյունով";
                case RadGridStringId.UngroupThisColumn: return "Հանել տվյալ սյան խմբավորումը";
                case RadGridStringId.ColumnChooserMenuItem: return "Սյան Ընտրություն";
                case RadGridStringId.HideMenuItem: return "Թաքցնել Սյունը";
                case RadGridStringId.HideGroupMenuItem: return "Թաքցնել Խումբը";
                case RadGridStringId.UnpinMenuItem: return "Անջատել Սյունը";
                case RadGridStringId.UnpinRowMenuItem: return "Անջատել Տողը";
                case RadGridStringId.PinMenuItem: return "Կցման վիճակ";
                case RadGridStringId.PinAtLeftMenuItem: return "Կցել ձախից";
                case RadGridStringId.PinAtRightMenuItem: return "Կցել աջից";
                case RadGridStringId.PinAtBottomMenuItem: return "Կցել ներքից";
                case RadGridStringId.PinAtTopMenuItem: return "Կցել վերից";
                case RadGridStringId.BestFitMenuItem: return "Լավագույնս հարմարեցնել";
                case RadGridStringId.PasteMenuItem: return "Փակցնել";
                case RadGridStringId.EditMenuItem: return "Խմբագրել";
                case RadGridStringId.ClearValueMenuItem: return "Մաքրել Արժեքը";
                case RadGridStringId.CopyMenuItem: return "Կրկնօրինակել";
                case RadGridStringId.CutMenuItem: return "Կտրել";
                case RadGridStringId.AddNewRowString: return "Սեղմեք այստեղ նոր տող ավելացնելու համար";
                case RadGridStringId.SearchRowResultsOfLabel: return " - ";
                case RadGridStringId.SearchRowMatchCase: return "Համընկնող դեպք";
                case RadGridStringId.ConditionalFormattingSortAlphabetically: return "Դասավորել սյուները այբբենական կարգով";
                case RadGridStringId.ConditionalFormattingCaption: return "Պայմանական Ձևաչափի կանոննորի Կառավարում";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Ձաչափել միայն բջիջները - ";
                case RadGridStringId.ConditionalFormattingLblName: return "Կանոնի անվանում";
                case RadGridStringId.ConditionalFormattingLblType: return "Բջջի արժեք";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Արժեք 1";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Արժեք 2";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Կանոներ";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Կանոնի հատկանիշեր";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Կիրառել ձաչափը ամբողջ տողի համար";
                case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "Կիրառել ձևաչափը, եթե տողը ընտրված է";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Ավելացնել նոր կանոն";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Հեռացնել";
                case RadGridStringId.ConditionalFormattingBtnOK: return "Կատարել";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Փակել";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Կիրառել";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Կանոնը կիրառվում է - ";
                case RadGridStringId.ConditionalFormattingCondition: return "Պայման";
                case RadGridStringId.ConditionalFormattingExpression: return "Արտահայտություն";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Ընտրեք մեկը]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "հավասար է [Արժեք1]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "հավասար չէ [Արժեք1]";
                case RadGridStringId.ConditionalFormattingStartsWith: return "սկսվում է [Արժեք1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "ավարտվում է [Արժեք1]";
                case RadGridStringId.ConditionalFormattingContains: return "պարունակում է [Արժեք1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "չի պարունակում [Արժեք1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "մեծ է [Արժեք1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "մեծ կամ հավասար է [Արժեք1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "փոքր է [Արժեք1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "փոքր է կամ հավասար [Արժեք1]";
                case RadGridStringId.ConditionalFormattingIsBetween: return "[Արժեք1] և [Արժեք2] միջակայքում է";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "[Արժեք1] և [Արժեք2] միջակայքում չէ";
                case RadGridStringId.ConditionalFormattingLblFormat: return "Ձևաչափ";

                case RadGridStringId.ConditionalFormattingBtnExpression: return "Արտահայտության խմբագրում";
                case RadGridStringId.ConditionalFormattingTextBoxExpression: return "Արտահայտություն";

                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "ՄեծատառևՓոքրատառՏարբերող";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "ԲջջիՖոնիԳույն";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "ԲջջիԵզրագծիԳույն";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "Միացված";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "ՏեղիՖոնիԳույն";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "ՏողիԵզրագծիԳույն";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "ՏողիՏեքստիՀավասարեցում";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "ՏեքստիՀավասարեցում";

                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription: return "Որոշում է, թե փոքրատառ և մեծատառի նկատմամբ զգայուն համեմատությունները տեղի կունենան տառասիմվոլային արժեքների գնահատման ժամանակ:";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription: return "Մուտքագրեք բջջի համար նախատեսվող ֆոնի գուընը:";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription: return "Մուտքագրեք բջջի համար նախատեսվող եզրագծի գուընը:";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription: return "Որոշում է, թե պայմանը միացված է (կարող է գնահատվել  կիրառվել).";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription: return "Մուտքագրեք ամբողջ տողի համար նախատեսվող ֆոնի գուընը:";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription: return "Մուտքագրեք ամբողջ տողի համար նախատեսվող եզրագծի գուընը:";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription: return "Մուտքագրեք բջջի արժեքների հավասարեցումը կիրառվող ամբողջ տողի համար:";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription: return "Մուտքագրեք բջջի արժեքների հավասարեցումը.";

                case RadGridStringId.ColumnChooserFormCaption: return " Սյան Ընտրություն";
                case RadGridStringId.ColumnChooserFormMessage: return "Տեղափոխել սյան գլխագիրը աղյուսակից այստեղ այն տվյալ տեսարանից հեռացնելու համար:";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Տեղափոխել խմբավորման ենթակա սյունակը այստեղ";
                case RadGridStringId.GroupingPanelHeader: return "Խմբավորել ըստ:";
                case RadGridStringId.PagingPanelPagesLabel: return "Էջ";
                case RadGridStringId.PagingPanelOfPagesLabel: return " - ";
                case RadGridStringId.NoDataText: return "Տվյալների բացակայություն";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "Ֆիլտրի սխալ";
                case RadGridStringId.CompositeFilterFormInvalidFilter: return "Բաղադրյալ ֆիլտրի նկարագրությունը վավեր չէ:";

                case RadGridStringId.ExpressionMenuItem: return "Արտահայտություն";
                case RadGridStringId.ExpressionFormTitle: return "Արտահայտության ստեղծող";
                case RadGridStringId.ExpressionFormFunctions: return "Ֆունկցիանր";
                case RadGridStringId.ExpressionFormFunctionsText: return "Տեքստ";
                case RadGridStringId.ExpressionFormFunctionsAggregate: return "Ագգրեգատ";
                case RadGridStringId.ExpressionFormFunctionsDateTime: return "Ամսաթիվ-Ժամ";
                case RadGridStringId.ExpressionFormFunctionsLogical: return "Տրամաբանական";
                case RadGridStringId.ExpressionFormFunctionsMath: return "Մաթեմատիկական";
                case RadGridStringId.ExpressionFormFunctionsOther: return "Այլ";
                case RadGridStringId.ExpressionFormOperators: return "Օպերատորներ";
                case RadGridStringId.ExpressionFormConstants: return "Պարունակում է";
                case RadGridStringId.ExpressionFormFields: return "Դաշտեր";
                case RadGridStringId.ExpressionFormDescription: return "Նկարագրություն";
                case RadGridStringId.ExpressionFormResultPreview: return "Արդյունքների ցուցադրում";
                case RadGridStringId.ExpressionFormTooltipPlus: return "Գումարում";
                case RadGridStringId.ExpressionFormTooltipMinus: return "Հանում";
                case RadGridStringId.ExpressionFormTooltipMultiply: return "Բազմապատկում";
                case RadGridStringId.ExpressionFormTooltipDivide: return "Բաժանում";
                case RadGridStringId.ExpressionFormTooltipModulo: return "Մոդուլ";
                case RadGridStringId.ExpressionFormTooltipEqual: return "Հավասարություն";
                case RadGridStringId.ExpressionFormTooltipNotEqual: return "Անհավասարություն";
                case RadGridStringId.ExpressionFormTooltipLess: return "Փոքր";
                case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "Փոքր կամ Հավասար";
                case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "Մեծ կամ Հավասար";
                case RadGridStringId.ExpressionFormTooltipGreater: return "Մեծ";
                case RadGridStringId.ExpressionFormTooltipAnd: return "Տրամաբանական \"ԵՎ\"";
                case RadGridStringId.ExpressionFormTooltipOr: return "Տրամաբանական \"ԿԱՄ\"";
                case RadGridStringId.ExpressionFormTooltipNot: return "Տրամաբանական \"ԺԽՏՈՒՄ\"";
                case RadGridStringId.ExpressionFormAndButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOrButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormNotButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOKButton: return "Կատարել";
                case RadGridStringId.ExpressionFormCancelButton: return "Փակել";
            }

            return string.Empty;
        }
    }    
}
