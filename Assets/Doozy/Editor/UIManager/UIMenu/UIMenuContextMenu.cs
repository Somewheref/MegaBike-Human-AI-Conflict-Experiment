// Copyright (c) 2015 - 2023 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using UnityEditor;
// ReSharper disable All
namespace Doozy.Editor.UIManager.UIMenu
{
    public static class UIMenuContextMenu
    {
        private const int MENU_ITEM_PRIORITY = 7;
        private const string MENU_PATH = "GameObject/Doozy/UIMenu";

        public static class Components
        {
            private const string TYPE_NAME = "Components";
            private const string TYPE_MENU_PATH = MENU_PATH + "/" + TYPE_NAME + "/";

            public static class ButtonBasic
            {
                private const string CATEGORY_NAME = "Button Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Flex Button", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlexButton(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlexButton");

                [MenuItem(CATEGORY_MENU_PATH + "Flex Icon Button", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlexIconButton(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlexIconButton");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButton(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButton");

                [MenuItem(CATEGORY_MENU_PATH + "Simple Button", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleButton(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleButton");

                [MenuItem(CATEGORY_MENU_PATH + "Simple Icon Button", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleIconButton(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleIconButton");
            }

            public static class ButtonDirection
            {
                private const string CATEGORY_NAME = "Button Direction";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Arrow Down", false, MENU_ITEM_PRIORITY)]
                public static void CreateArrowDown(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ArrowDown");

                [MenuItem(CATEGORY_MENU_PATH + "Arrow Left", false, MENU_ITEM_PRIORITY)]
                public static void CreateArrowLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ArrowLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Arrow Right", false, MENU_ITEM_PRIORITY)]
                public static void CreateArrowRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ArrowRight");

                [MenuItem(CATEGORY_MENU_PATH + "Arrow Up", false, MENU_ITEM_PRIORITY)]
                public static void CreateArrowUp(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ArrowUp");

                [MenuItem(CATEGORY_MENU_PATH + "Chevron Down", false, MENU_ITEM_PRIORITY)]
                public static void CreateChevronDown(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ChevronDown");

                [MenuItem(CATEGORY_MENU_PATH + "Chevron Left", false, MENU_ITEM_PRIORITY)]
                public static void CreateChevronLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ChevronLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Chevron Right", false, MENU_ITEM_PRIORITY)]
                public static void CreateChevronRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ChevronRight");

                [MenuItem(CATEGORY_MENU_PATH + "Chevron Up", false, MENU_ITEM_PRIORITY)]
                public static void CreateChevronUp(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ChevronUp");

                [MenuItem(CATEGORY_MENU_PATH + "Circle Arrow Down", false, MENU_ITEM_PRIORITY)]
                public static void CreateCircleArrowDown(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CircleArrowDown");

                [MenuItem(CATEGORY_MENU_PATH + "Circle Arrow Left", false, MENU_ITEM_PRIORITY)]
                public static void CreateCircleArrowLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CircleArrowLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Circle Arrow Right", false, MENU_ITEM_PRIORITY)]
                public static void CreateCircleArrowRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CircleArrowRight");

                [MenuItem(CATEGORY_MENU_PATH + "Circle Arrow Up", false, MENU_ITEM_PRIORITY)]
                public static void CreateCircleArrowUp(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CircleArrowUp");

                [MenuItem(CATEGORY_MENU_PATH + "Circle Chevron Down", false, MENU_ITEM_PRIORITY)]
                public static void CreateCircleChevronDown(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CircleChevronDown");

                [MenuItem(CATEGORY_MENU_PATH + "Circle Chevron Left", false, MENU_ITEM_PRIORITY)]
                public static void CreateCircleChevronLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CircleChevronLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Circle Chevron Right", false, MENU_ITEM_PRIORITY)]
                public static void CreateCircleChevronRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CircleChevronRight");

                [MenuItem(CATEGORY_MENU_PATH + "Circle Chevron Up", false, MENU_ITEM_PRIORITY)]
                public static void CreateCircleChevronUp(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CircleChevronUp");
            }

            public static class ButtonGeneral
            {
                private const string CATEGORY_NAME = "Button General";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "AddToCart", false, MENU_ITEM_PRIORITY)]
                public static void CreateAddToCart(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "AddToCart");

                [MenuItem(CATEGORY_MENU_PATH + "AddToCart Bag", false, MENU_ITEM_PRIORITY)]
                public static void CreateAddToCartBag(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "AddToCartBag");

                [MenuItem(CATEGORY_MENU_PATH + "AddToFavorites", false, MENU_ITEM_PRIORITY)]
                public static void CreateAddToFavorites(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "AddToFavorites");

                [MenuItem(CATEGORY_MENU_PATH + "Calendar", false, MENU_ITEM_PRIORITY)]
                public static void CreateCalendar(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Calendar");

                [MenuItem(CATEGORY_MENU_PATH + "Calendar Days", false, MENU_ITEM_PRIORITY)]
                public static void CreateCalendarDays(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CalendarDays");

                [MenuItem(CATEGORY_MENU_PATH + "Camera", false, MENU_ITEM_PRIORITY)]
                public static void CreateCamera(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Camera");

                [MenuItem(CATEGORY_MENU_PATH + "Close XMark", false, MENU_ITEM_PRIORITY)]
                public static void CreateCloseXMark(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CloseXMark");

                [MenuItem(CATEGORY_MENU_PATH + "Gamepad", false, MENU_ITEM_PRIORITY)]
                public static void CreateGamepad(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Gamepad");

                [MenuItem(CATEGORY_MENU_PATH + "Gift", false, MENU_ITEM_PRIORITY)]
                public static void CreateGift(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Gift");

                [MenuItem(CATEGORY_MENU_PATH + "Globe", false, MENU_ITEM_PRIORITY)]
                public static void CreateGlobe(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Globe");

                [MenuItem(CATEGORY_MENU_PATH + "Id Badge", false, MENU_ITEM_PRIORITY)]
                public static void CreateIdBadge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IdBadge");

                [MenuItem(CATEGORY_MENU_PATH + "Key", false, MENU_ITEM_PRIORITY)]
                public static void CreateKey(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Key");

                [MenuItem(CATEGORY_MENU_PATH + "Language", false, MENU_ITEM_PRIORITY)]
                public static void CreateLanguage(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Language");

                [MenuItem(CATEGORY_MENU_PATH + "Map", false, MENU_ITEM_PRIORITY)]
                public static void CreateMap(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Map");

                [MenuItem(CATEGORY_MENU_PATH + "Minus", false, MENU_ITEM_PRIORITY)]
                public static void CreateMinus(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Minus");

                [MenuItem(CATEGORY_MENU_PATH + "Plus", false, MENU_ITEM_PRIORITY)]
                public static void CreatePlus(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Plus");

                [MenuItem(CATEGORY_MENU_PATH + "Redo", false, MENU_ITEM_PRIORITY)]
                public static void CreateRedo(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Redo");

                [MenuItem(CATEGORY_MENU_PATH + "Refresh", false, MENU_ITEM_PRIORITY)]
                public static void CreateRefresh(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Refresh");

                [MenuItem(CATEGORY_MENU_PATH + "Reply", false, MENU_ITEM_PRIORITY)]
                public static void CreateReply(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Reply");

                [MenuItem(CATEGORY_MENU_PATH + "ReportBug", false, MENU_ITEM_PRIORITY)]
                public static void CreateReportBug(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ReportBug");

                [MenuItem(CATEGORY_MENU_PATH + "Search", false, MENU_ITEM_PRIORITY)]
                public static void CreateSearch(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Search");

                [MenuItem(CATEGORY_MENU_PATH + "SendEmail", false, MENU_ITEM_PRIORITY)]
                public static void CreateSendEmail(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SendEmail");

                [MenuItem(CATEGORY_MENU_PATH + "Share", false, MENU_ITEM_PRIORITY)]
                public static void CreateShare(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Share");

                [MenuItem(CATEGORY_MENU_PATH + "Share Nodes", false, MENU_ITEM_PRIORITY)]
                public static void CreateShareNodes(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ShareNodes");

                [MenuItem(CATEGORY_MENU_PATH + "Star", false, MENU_ITEM_PRIORITY)]
                public static void CreateStar(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Star");

                [MenuItem(CATEGORY_MENU_PATH + "Tag", false, MENU_ITEM_PRIORITY)]
                public static void CreateTag(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Tag");

                [MenuItem(CATEGORY_MENU_PATH + "Undo", false, MENU_ITEM_PRIORITY)]
                public static void CreateUndo(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Undo");

                [MenuItem(CATEGORY_MENU_PATH + "User", false, MENU_ITEM_PRIORITY)]
                public static void CreateUser(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "User");

                [MenuItem(CATEGORY_MENU_PATH + "Users", false, MENU_ITEM_PRIORITY)]
                public static void CreateUsers(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Users");
            }

            public static class ButtonMedia
            {
                private const string CATEGORY_NAME = "Button Media";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Backward", false, MENU_ITEM_PRIORITY)]
                public static void CreateBackward(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Backward");

                [MenuItem(CATEGORY_MENU_PATH + "Backward Step", false, MENU_ITEM_PRIORITY)]
                public static void CreateBackwardStep(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "BackwardStep");

                [MenuItem(CATEGORY_MENU_PATH + "Forward", false, MENU_ITEM_PRIORITY)]
                public static void CreateForward(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Forward");

                [MenuItem(CATEGORY_MENU_PATH + "Forward Step", false, MENU_ITEM_PRIORITY)]
                public static void CreateForwardStep(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ForwardStep");

                [MenuItem(CATEGORY_MENU_PATH + "Pause", false, MENU_ITEM_PRIORITY)]
                public static void CreatePause(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Pause");

                [MenuItem(CATEGORY_MENU_PATH + "Play", false, MENU_ITEM_PRIORITY)]
                public static void CreatePlay(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Play");

                [MenuItem(CATEGORY_MENU_PATH + "PlayPause", false, MENU_ITEM_PRIORITY)]
                public static void CreatePlayPause(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "PlayPause");

                [MenuItem(CATEGORY_MENU_PATH + "Repeat", false, MENU_ITEM_PRIORITY)]
                public static void CreateRepeat(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Repeat");

                [MenuItem(CATEGORY_MENU_PATH + "Stop", false, MENU_ITEM_PRIORITY)]
                public static void CreateStop(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Stop");
            }

            public static class ProgressorBasic
            {
                private const string CATEGORY_NAME = "Progressor Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Simple Progress Bar", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleProgressBar(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleProgressBar");

                [MenuItem(CATEGORY_MENU_PATH + "Simple Progress Text", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleProgressText(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleProgressText");
            }

            public static class ScrollbarBasic
            {
                private const string CATEGORY_NAME = "Scrollbar Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Simple Scrollbar", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleScrollbar(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleScrollbar");
            }

            public static class SliderBasic
            {
                private const string CATEGORY_NAME = "Slider Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Simple Slider", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleSlider(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleSlider");
            }

            public static class StepperBasic
            {
                private const string CATEGORY_NAME = "Stepper Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Counter Stepper H", false, MENU_ITEM_PRIORITY)]
                public static void CreateCounterStepperH(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CounterStepperH");

                [MenuItem(CATEGORY_MENU_PATH + "Counter Stepper V", false, MENU_ITEM_PRIORITY)]
                public static void CreateCounterStepperV(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CounterStepperV");

                [MenuItem(CATEGORY_MENU_PATH + "Flex Stepper H", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlexStepperH(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlexStepperH");

                [MenuItem(CATEGORY_MENU_PATH + "Flex Stepper V", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlexStepperV(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlexStepperV");

                [MenuItem(CATEGORY_MENU_PATH + "Quanity Stepper H", false, MENU_ITEM_PRIORITY)]
                public static void CreateQuanityStepperH(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "QuanityStepperH");

                [MenuItem(CATEGORY_MENU_PATH + "Quantity Stepper V", false, MENU_ITEM_PRIORITY)]
                public static void CreateQuantityStepperV(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "QuantityStepperV");

                [MenuItem(CATEGORY_MENU_PATH + "Round Stepper H", false, MENU_ITEM_PRIORITY)]
                public static void CreateRoundStepperH(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RoundStepperH");

                [MenuItem(CATEGORY_MENU_PATH + "Round Stepper V", false, MENU_ITEM_PRIORITY)]
                public static void CreateRoundStepperV(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RoundStepperV");

                [MenuItem(CATEGORY_MENU_PATH + "Simple Stepper H", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleStepperH(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleStepperH");

                [MenuItem(CATEGORY_MENU_PATH + "Simple Stepper V", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleStepperV(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleStepperV");

                [MenuItem(CATEGORY_MENU_PATH + "Slider Stepper H", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderStepperH(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderStepperH");

                [MenuItem(CATEGORY_MENU_PATH + "Slider Stepper V", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderStepperV(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderStepperV");
            }

            public static class TabBasic
            {
                private const string CATEGORY_NAME = "Tab Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Flex Icon Tab", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlexIconTab(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlexIconTab");

                [MenuItem(CATEGORY_MENU_PATH + "Flex Tab", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlexTab(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlexTab");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTab(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTab");

                [MenuItem(CATEGORY_MENU_PATH + "Simple Icon Tab", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleIconTab(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleIconTab");

                [MenuItem(CATEGORY_MENU_PATH + "Simple Tab", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleTab(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleTab");
            }

            public static class ToggleCheckbox
            {
                private const string CATEGORY_NAME = "Toggle Checkbox";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Checkbox", false, MENU_ITEM_PRIORITY)]
                public static void CreateCheckbox(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Checkbox");

                [MenuItem(CATEGORY_MENU_PATH + "Flex Checkbox", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlexCheckbox(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlexCheckbox");
            }

            public static class ToggleIcon
            {
                private const string CATEGORY_NAME = "Toggle Icon";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Toggle", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconToggle(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconToggle");
            }

            public static class ToggleRadio
            {
                private const string CATEGORY_NAME = "Toggle Radio";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Flex Radio", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlexRadio(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlexRadio");

                [MenuItem(CATEGORY_MENU_PATH + "Radio", false, MENU_ITEM_PRIORITY)]
                public static void CreateRadio(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Radio");
            }

            public static class ToggleSwitch
            {
                private const string CATEGORY_NAME = "Toggle Switch";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Flex Switch", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlexSwitch(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlexSwitch");

                [MenuItem(CATEGORY_MENU_PATH + "Switch", false, MENU_ITEM_PRIORITY)]
                public static void CreateSwitch(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Switch");
            }
        }

        public static class Containers
        {
            private const string TYPE_NAME = "Containers";
            private const string TYPE_MENU_PATH = MENU_PATH + "/" + TYPE_NAME + "/";

            public static class ContainerBasic
            {
                private const string CATEGORY_NAME = "Container Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Simple Container", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleContainer(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleContainer");
            }

            public static class TabLayout
            {
                private const string CATEGORY_NAME = "Tab Layout";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Bottom Expanded", false, MENU_ITEM_PRIORITY)]
                public static void CreateBottomExpanded(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "BottomExpanded");

                [MenuItem(CATEGORY_MENU_PATH + "Bottom Left", false, MENU_ITEM_PRIORITY)]
                public static void CreateBottomLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "BottomLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Bottom Right", false, MENU_ITEM_PRIORITY)]
                public static void CreateBottomRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "BottomRight");

                [MenuItem(CATEGORY_MENU_PATH + "Left Bottom", false, MENU_ITEM_PRIORITY)]
                public static void CreateLeftBottom(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "LeftBottom");

                [MenuItem(CATEGORY_MENU_PATH + "Left Expanded", false, MENU_ITEM_PRIORITY)]
                public static void CreateLeftExpanded(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "LeftExpanded");

                [MenuItem(CATEGORY_MENU_PATH + "Left Top", false, MENU_ITEM_PRIORITY)]
                public static void CreateLeftTop(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "LeftTop");

                [MenuItem(CATEGORY_MENU_PATH + "Right Bottom", false, MENU_ITEM_PRIORITY)]
                public static void CreateRightBottom(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RightBottom");

                [MenuItem(CATEGORY_MENU_PATH + "Right Expanded", false, MENU_ITEM_PRIORITY)]
                public static void CreateRightExpanded(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RightExpanded");

                [MenuItem(CATEGORY_MENU_PATH + "Right Top", false, MENU_ITEM_PRIORITY)]
                public static void CreateRightTop(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RightTop");

                [MenuItem(CATEGORY_MENU_PATH + "Top Expanded", false, MENU_ITEM_PRIORITY)]
                public static void CreateTopExpanded(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TopExpanded");

                [MenuItem(CATEGORY_MENU_PATH + "Top Left", false, MENU_ITEM_PRIORITY)]
                public static void CreateTopLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TopLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Top Right", false, MENU_ITEM_PRIORITY)]
                public static void CreateTopRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TopRight");
            }

            public static class ViewBasic
            {
                private const string CATEGORY_NAME = "View Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Simple View", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleView");
            }
        }

        public static class Content
        {
            private const string TYPE_NAME = "Content";
            private const string TYPE_MENU_PATH = MENU_PATH + "/" + TYPE_NAME + "/";

            public static class Basic
            {
                private const string CATEGORY_NAME = "Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Dark Overlay", false, MENU_ITEM_PRIORITY)]
                public static void CreateDarkOverlay(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "DarkOverlay");

                [MenuItem(CATEGORY_MENU_PATH + "Light Overlay", false, MENU_ITEM_PRIORITY)]
                public static void CreateLightOverlay(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "LightOverlay");

                [MenuItem(CATEGORY_MENU_PATH + "Simple Card", false, MENU_ITEM_PRIORITY)]
                public static void CreateSimpleCard(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SimpleCard");
            }

            public static class ProductCard
            {
                private const string CATEGORY_NAME = "Product Card";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Card 001", false, MENU_ITEM_PRIORITY)]
                public static void CreateCard001(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Card001");

                [MenuItem(CATEGORY_MENU_PATH + "Card 002", false, MENU_ITEM_PRIORITY)]
                public static void CreateCard002(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Card002");

                [MenuItem(CATEGORY_MENU_PATH + "Card 003", false, MENU_ITEM_PRIORITY)]
                public static void CreateCard003(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Card003");

                [MenuItem(CATEGORY_MENU_PATH + "Card 004", false, MENU_ITEM_PRIORITY)]
                public static void CreateCard004(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Card004");

                [MenuItem(CATEGORY_MENU_PATH + "Card 005", false, MENU_ITEM_PRIORITY)]
                public static void CreateCard005(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Card005");
            }

            public static class SpinnerBasic
            {
                private const string CATEGORY_NAME = "Spinner Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Circle Spinner", false, MENU_ITEM_PRIORITY)]
                public static void CreateCircleSpinner(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CircleSpinner");

                [MenuItem(CATEGORY_MENU_PATH + "Rim Circle Spinner", false, MENU_ITEM_PRIORITY)]
                public static void CreateRimCircleSpinner(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RimCircleSpinner");

                [MenuItem(CATEGORY_MENU_PATH + "Square Spinner", false, MENU_ITEM_PRIORITY)]
                public static void CreateSquareSpinner(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SquareSpinner");
            }
        }

        public static class Layouts
        {
            private const string TYPE_NAME = "Layouts";
            private const string TYPE_MENU_PATH = MENU_PATH + "/" + TYPE_NAME + "/";

            public static class Basic
            {
                private const string CATEGORY_NAME = "Basic";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Grid", false, MENU_ITEM_PRIORITY)]
                public static void CreateGrid(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Grid");

                [MenuItem(CATEGORY_MENU_PATH + "Horizontal", false, MENU_ITEM_PRIORITY)]
                public static void CreateHorizontal(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Horizontal");

                [MenuItem(CATEGORY_MENU_PATH + "Radial", false, MENU_ITEM_PRIORITY)]
                public static void CreateRadial(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Radial");

                [MenuItem(CATEGORY_MENU_PATH + "Vertical", false, MENU_ITEM_PRIORITY)]
                public static void CreateVertical(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Vertical");
            }
        }

        public static class Scripts
        {
            private const string TYPE_NAME = "Scripts";
            private const string TYPE_MENU_PATH = MENU_PATH + "/" + TYPE_NAME + "/";

            public static class Controller
            {
                private const string CATEGORY_NAME = "Controller";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Flow Controller", false, MENU_ITEM_PRIORITY)]
                public static void CreateFlowController(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FlowController");
            }
        }

        public static class NeumorphOne
        {
            private const string TYPE_NAME = "Neumorph One";
            private const string TYPE_MENU_PATH = MENU_PATH + "/" + TYPE_NAME + "/";

            public static class Button
            {
                private const string CATEGORY_NAME = "Button";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonSmall");
            }

            public static class ButtonInCircle
            {
                private const string CATEGORY_NAME = "Button In Circle";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonSmall");
            }

            public static class ButtonInRounded
            {
                private const string CATEGORY_NAME = "Button In Rounded";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonSmall");
            }

            public static class ButtonInSquare
            {
                private const string CATEGORY_NAME = "Button In Square";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonSmall");
            }

            public static class ButtonOutCircle
            {
                private const string CATEGORY_NAME = "Button Out Circle";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonSmall");
            }

            public static class ButtonOutRounded
            {
                private const string CATEGORY_NAME = "Button Out Rounded";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonSmall");
            }

            public static class ButtonOutSquare
            {
                private const string CATEGORY_NAME = "Button Out Square";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTextButtonSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Button (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextButtonSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextButtonSmall");
            }

            public static class CardIconbox
            {
                private const string CATEGORY_NAME = "Card Iconbox";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Card IconBox (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardIconBoxExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardIconBoxExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card IconBox (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardIconBoxLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardIconBoxLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card IconBox (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardIconBoxMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardIconBoxMedium");
            }

            public static class CardIn
            {
                private const string CATEGORY_NAME = "Card In";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Card In Circle (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInCircleExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInCircleExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Circle (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInCircleLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInCircleLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Circle (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInCircleMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInCircleMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Circle (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInCircleSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInCircleSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Circle (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageCircleExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageCircleExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Circle (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageCircleLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageCircleLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Circle (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageCircleMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageCircleMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Circle (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageCircleSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageCircleSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Rounded (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageRoundedExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageRoundedExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Rounded (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageRoundedLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageRoundedLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Rounded (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageRoundedMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageRoundedMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Rounded (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageRoundedSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageRoundedSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Square (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageSquareExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageSquareExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Square (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageSquareLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageSquareLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Square (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageSquareMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageSquareMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Image Square (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInImageSquareSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInImageSquareSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Rounded (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInRoundedExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInRoundedExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Rounded (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInRoundedLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInRoundedLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Rounded (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInRoundedMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInRoundedMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Rounded (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInRoundedSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInRoundedSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Square (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInSquareExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInSquareExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Square (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInSquareLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInSquareLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Square (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInSquareMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInSquareMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card In Square (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardInSquareSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardInSquareSmall");
            }

            public static class CardOut
            {
                private const string CATEGORY_NAME = "Card Out";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Circle (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutCircleExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutCircleExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Circle (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutCircleLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutCircleLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Circle (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutCircleMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutCircleMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Circle (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutCircleSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutCircleSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Circle (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageCircleExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageCircleExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Circle (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageCircleLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageCircleLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Circle (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageCircleMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageCircleMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Circle (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageCircleSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageCircleSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Rounded (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageRoundedExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageRoundedExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Rounded (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageRoundedLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageRoundedLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Rounded (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageRoundedMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageRoundedMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Rounded (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageRoundedSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageRoundedSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Square (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageSquareExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageSquareExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Square (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageSquareLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageSquareLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Square (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageSquareMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageSquareMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Image Square (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutImageSquareSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutImageSquareSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Rounded (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutRoundedExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutRoundedExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Rounded (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutRoundedLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutRoundedLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Rounded (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutRoundedMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutRoundedMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Rounded (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutRoundedSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutRoundedSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Selectable Wide (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutSelectableWideLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutSelectableWideLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Square (Extra Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutSquareExtraLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutSquareExtraLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Square (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutSquareLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutSquareLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Square (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutSquareMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutSquareMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Card Out Square (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCardOutSquareSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CardOutSquareSmall");
            }

            public static class Checkbox
            {
                private const string CATEGORY_NAME = "Checkbox";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Checkbox (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCheckboxLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CheckboxLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Checkbox (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCheckboxMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CheckboxMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Checkbox (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateCheckboxSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "CheckboxSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Checkbox (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextCheckboxLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextCheckboxLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Checkbox (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextCheckboxMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextCheckboxMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Checkbox (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextCheckboxSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextCheckboxSmall");
            }

            public static class Dropdown
            {
                private const string CATEGORY_NAME = "Dropdown";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Dropdown (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateDropdownLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "DropdownLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Dropdown (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateDropdownMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "DropdownMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Dropdown (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateDropdownSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "DropdownSmall");
            }

            public static class InputFieldIn
            {
                private const string CATEGORY_NAME = "InputField In";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "InputField Password (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldPasswordLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldPasswordLarge");

                [MenuItem(CATEGORY_MENU_PATH + "InputField Password (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldPasswordMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldPasswordMedium");

                [MenuItem(CATEGORY_MENU_PATH + "InputField Password (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldPasswordSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldPasswordSmall");

                [MenuItem(CATEGORY_MENU_PATH + "InputField Search (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldSearchLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldSearchLarge");

                [MenuItem(CATEGORY_MENU_PATH + "InputField Search (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldSearchMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldSearchMedium");

                [MenuItem(CATEGORY_MENU_PATH + "InputField Search (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldSearchSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldSearchSmall");

                [MenuItem(CATEGORY_MENU_PATH + "InputField Text (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldTextLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldTextLarge");

                [MenuItem(CATEGORY_MENU_PATH + "InputField Text (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldTextMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldTextMedium");

                [MenuItem(CATEGORY_MENU_PATH + "InputField Text (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldTextSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldTextSmall");
            }

            public static class InputFieldOut
            {
                private const string CATEGORY_NAME = "InputField Out";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "InputField  Password (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldPasswordLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldPasswordLarge");

                [MenuItem(CATEGORY_MENU_PATH + "InputField  Password (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldPasswordMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldPasswordMedium");

                [MenuItem(CATEGORY_MENU_PATH + "InputField  Password (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldPasswordSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldPasswordSmall");

                [MenuItem(CATEGORY_MENU_PATH + "InputField  Search (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldSearchLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldSearchLarge");

                [MenuItem(CATEGORY_MENU_PATH + "InputField  Search (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldSearchMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldSearchMedium");

                [MenuItem(CATEGORY_MENU_PATH + "InputField  Search (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldSearchSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldSearchSmall");

                [MenuItem(CATEGORY_MENU_PATH + "InputField  Text (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldTextLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldTextLarge");

                [MenuItem(CATEGORY_MENU_PATH + "InputField  Text (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldTextMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldTextMedium");

                [MenuItem(CATEGORY_MENU_PATH + "InputField  Text (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateInputFieldTextSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InputFieldTextSmall");
            }

            public static class Layout
            {
                private const string CATEGORY_NAME = "Layout";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Add Product Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateAddProductLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "AddProductLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Image Grid Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateImageGridLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ImageGridLayout");

                [MenuItem(CATEGORY_MENU_PATH + "List View Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateListViewLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ListViewLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Login And Register Buttons Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateLoginAndRegisterButtonsLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "LoginAndRegisterButtonsLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Login Buttons Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateLoginButtonsLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "LoginButtonsLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Login Inputfields Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateLoginInputfieldsLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "LoginInputfieldsLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Pricing Single Item Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreatePricingSingleItemLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "PricingSingleItemLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Product Grid Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateProductGridLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProductGridLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Register Buttons Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateRegisterButtonsLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RegisterButtonsLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Register Inputfields Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateRegisterInputfieldsLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RegisterInputfieldsLayout");
            }

            public static class LayoutLandscape
            {
                private const string CATEGORY_NAME = "Layout Landscape";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Contact Form In Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateContactFormInLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ContactFormInLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Contact Form Out Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateContactFormOutLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ContactFormOutLayout");

                [MenuItem(CATEGORY_MENU_PATH + "IconBox Grid Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconBoxGridLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconBoxGridLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Info Box Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateInfoBoxLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InfoBoxLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Pricing Table Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreatePricingTableLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "PricingTableLayout");
            }

            public static class LayoutPortrait
            {
                private const string CATEGORY_NAME = "Layout Portrait";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Contact Form In Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateContactFormInLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ContactFormInLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Contact Form Out Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateContactFormOutLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ContactFormOutLayout");

                [MenuItem(CATEGORY_MENU_PATH + "IconBox Grid Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconBoxGridLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconBoxGridLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Info Box Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreateInfoBoxLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "InfoBoxLayout");

                [MenuItem(CATEGORY_MENU_PATH + "Pricing Table Layout", false, MENU_ITEM_PRIORITY)]
                public static void CreatePricingTableLayout(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "PricingTableLayout");
            }

            public static class MenuIn
            {
                private const string CATEGORY_NAME = "Menu In";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Menu Horizontal (Left)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuHorizontalLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuHorizontalLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Horizontal (Right)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuHorizontalRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuHorizontalRight");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Radial (Down)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuRadialDown(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuRadialDown");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Radial (Left)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuRadialLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuRadialLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Radial (Right)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuRadialRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuRadialRight");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Radial (Up)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuRadialUp(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuRadialUp");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Vertical (Down)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuVerticalDown(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuVerticalDown");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Vertical (Up)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuVerticalUp(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuVerticalUp");
            }

            public static class MenuOut
            {
                private const string CATEGORY_NAME = "Menu Out";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Menu Horizontal (Left)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuHorizontalLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuHorizontalLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Horizontal (Right)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuHorizontalRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuHorizontalRight");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Radial (Down)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuRadialDown(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuRadialDown");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Radial (Left)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuRadialLeft(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuRadialLeft");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Radial (Right)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuRadialRight(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuRadialRight");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Radial (Up)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuRadialUp(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuRadialUp");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Vertical (Down)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuVerticalDown(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuVerticalDown");

                [MenuItem(CATEGORY_MENU_PATH + "Menu Vertical (Up)", false, MENU_ITEM_PRIORITY)]
                public static void CreateMenuVerticalUp(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MenuVerticalUp");
            }

            public static class ProgressBar
            {
                private const string CATEGORY_NAME = "Progress Bar";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Text (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressTextLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressTextLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Text (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressTextMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressTextMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Text (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressTextSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressTextSmall");
            }

            public static class ProgressBarInCircle
            {
                private const string CATEGORY_NAME = "Progress Bar In Circle";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorSmall");
            }

            public static class ProgressBarInRounded
            {
                private const string CATEGORY_NAME = "Progress Bar In Rounded";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorSmall");
            }

            public static class ProgressBarInSquare
            {
                private const string CATEGORY_NAME = "Progress Bar In Square";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorSmall");
            }

            public static class ProgressBarOutCircle
            {
                private const string CATEGORY_NAME = "Progress Bar Out Circle";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorSmall");
            }

            public static class ProgressBarOutRounded
            {
                private const string CATEGORY_NAME = "Progress Bar Out Rounded";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorSmall");
            }

            public static class ProgressBarOutSquare
            {
                private const string CATEGORY_NAME = "Progress Bar Out Square";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Bar (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressBarSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressBarSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Progress Indicator (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateProgressIndicatorSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProgressIndicatorSmall");
            }

            public static class Radio
            {
                private const string CATEGORY_NAME = "Radio";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Radio (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateRadioLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RadioLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Radio (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateRadioMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RadioMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Radio (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateRadioSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RadioSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Radio (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextRadioLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextRadioLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Radio (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextRadioMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextRadioMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Radio (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextRadioSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextRadioSmall");
            }

            public static class SliderCircle
            {
                private const string CATEGORY_NAME = "Slider Circle";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Slider (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Slider (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Slider (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderSmall");
            }

            public static class SliderRounded
            {
                private const string CATEGORY_NAME = "Slider Rounded";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Slider (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Slider (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Slider (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderSmall");
            }

            public static class SliderSquare
            {
                private const string CATEGORY_NAME = "Slider Square";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Slider (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Slider (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Slider (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSliderSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SliderSmall");
            }

            public static class Spinner
            {
                private const string CATEGORY_NAME = "Spinner";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Small");
            }

            public static class SpinnerCircle
            {
                private const string CATEGORY_NAME = "Spinner Circle";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 10 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner10Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner10Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 10 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner10Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner10Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 10 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner10Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner10Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 11 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner11Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner11Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 11 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner11Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner11Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 11 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner11Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner11Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 12 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner12Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner12Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 12 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner12Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner12Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 12 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner12Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner12Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 13 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner13Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner13Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 13 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner13Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner13Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 13 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner13Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner13Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 14 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner14Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner14Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 14 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner14Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner14Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 14 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner14Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner14Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 15 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner15Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner15Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 15 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner15Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner15Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 15 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner15Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner15Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 5 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner5Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner5Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 5 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner5Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner5Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 5 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner5Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner5Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 6 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner6Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner6Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 6 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner6Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner6Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 6 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner6Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner6Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 7 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner7Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner7Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 7 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner7Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner7Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 7 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner7Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner7Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 8 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner8Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner8Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 8 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner8Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner8Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 8 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner8Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner8Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 9 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner9Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner9Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 9 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner9Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner9Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 9 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner9Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner9Small");
            }

            public static class SpinnerRounded
            {
                private const string CATEGORY_NAME = "Spinner Rounded";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 10 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner10Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner10Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 10 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner10Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner10Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 10 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner10Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner10Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 11 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner11Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner11Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 11 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner11Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner11Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 11 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner11Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner11Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 12 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner12Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner12Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 12 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner12Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner12Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 12 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner12Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner12Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 13 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner13Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner13Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 13 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner13Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner13Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 13 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner13Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner13Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 14 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner14Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner14Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 14 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner14Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner14Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 14 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner14Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner14Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 15 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner15Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner15Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 15 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner15Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner15Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 15 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner15Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner15Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 16 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner16Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner16Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 16 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner16Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner16Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 16 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner16Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner16Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 5 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner5Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner5Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 5 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner5Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner5Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 5 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner5Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner5Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 6 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner6Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner6Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 6 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner6Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner6Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 6 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner6Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner6Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 7 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner7Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner7Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 7 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner7Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner7Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 7 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner7Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner7Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 8 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner8Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner8Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 8 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner8Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner8Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 8 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner8Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner8Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 9 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner9Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner9Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 9 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner9Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner9Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 9 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner9Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner9Small");
            }

            public static class SpinnerSquare
            {
                private const string CATEGORY_NAME = "Spinner Square";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 1 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner1Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner1Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 10 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner10Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner10Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 10 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner10Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner10Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 10 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner10Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner10Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 11 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner11Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner11Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 11 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner11Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner11Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 11 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner11Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner11Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 12 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner12Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner12Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 12 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner12Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner12Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 12 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner12Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner12Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 13 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner13Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner13Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 13 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner13Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner13Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 13 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner13Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner13Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 14 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner14Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner14Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 14 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner14Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner14Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 14 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner14Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner14Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 15 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner15Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner15Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 15 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner15Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner15Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 15 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner15Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner15Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 16 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner16Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner16Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 16 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner16Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner16Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 16 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner16Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner16Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 2 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner2Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner2Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 3 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner3Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner3Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 4 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner4Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner4Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 5 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner5Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner5Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 5 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner5Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner5Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 5 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner5Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner5Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 6 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner6Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner6Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 6 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner6Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner6Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 6 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner6Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner6Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 7 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner7Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner7Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 7 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner7Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner7Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 7 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner7Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner7Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 8 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner8Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner8Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 8 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner8Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner8Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 8 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner8Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner8Small");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 9 (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner9Large(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner9Large");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 9 (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner9Medium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner9Medium");

                [MenuItem(CATEGORY_MENU_PATH + "Spinner 9 (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSpinner9Small(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "Spinner9Small");
            }

            public static class Switch
            {
                private const string CATEGORY_NAME = "Switch";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Switch (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconSwitchLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconSwitchLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Switch (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconSwitchMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconSwitchMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Switch (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconSwitchSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconSwitchSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Switch (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSwitchLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SwitchLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Switch (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSwitchMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SwitchMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Switch (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateSwitchSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SwitchSmall");
            }

            public static class TabDown
            {
                private const string CATEGORY_NAME = "Tab Down";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabSmall");
            }

            public static class TabLayout
            {
                private const string CATEGORY_NAME = "Tab Layout";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Tabs (Horizontal)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTabsHorizontal(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TabsHorizontal");

                [MenuItem(CATEGORY_MENU_PATH + "Tabs (Vertical)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTabsVertical(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TabsVertical");
            }

            public static class TabLeft
            {
                private const string CATEGORY_NAME = "Tab Left";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabSmall");
            }

            public static class TabRight
            {
                private const string CATEGORY_NAME = "Tab Right";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabSmall");
            }

            public static class TabTop
            {
                private const string CATEGORY_NAME = "Tab Top";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Icon Tab (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateIconTabSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "IconTabSmall");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Large)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabLarge(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabLarge");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Medium)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabMedium(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabMedium");

                [MenuItem(CATEGORY_MENU_PATH + "Text Tab (Small)", false, MENU_ITEM_PRIORITY)]
                public static void CreateTextTabSmall(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TextTabSmall");
            }

            public static class View
            {
                private const string CATEGORY_NAME = "View";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Bottom Bar View", false, MENU_ITEM_PRIORITY)]
                public static void CreateBottomBarView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "BottomBarView");

                [MenuItem(CATEGORY_MENU_PATH + "Tab Group View", false, MENU_ITEM_PRIORITY)]
                public static void CreateTabGroupView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "TabGroupView");
            }

            public static class ViewLandscape
            {
                private const string CATEGORY_NAME = "View Landscape";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Contact Form In View", false, MENU_ITEM_PRIORITY)]
                public static void CreateContactFormInView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ContactFormInView");

                [MenuItem(CATEGORY_MENU_PATH + "Contact Form Out View", false, MENU_ITEM_PRIORITY)]
                public static void CreateContactFormOutView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ContactFormOutView");

                [MenuItem(CATEGORY_MENU_PATH + "Filter View", false, MENU_ITEM_PRIORITY)]
                public static void CreateFilterView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FilterView");

                [MenuItem(CATEGORY_MENU_PATH + "Login View", false, MENU_ITEM_PRIORITY)]
                public static void CreateLoginView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "LoginView");

                [MenuItem(CATEGORY_MENU_PATH + "Music Player Browse View", false, MENU_ITEM_PRIORITY)]
                public static void CreateMusicPlayerBrowseView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MusicPlayerBrowseView");

                [MenuItem(CATEGORY_MENU_PATH + "Music Player List Songs View", false, MENU_ITEM_PRIORITY)]
                public static void CreateMusicPlayerListSongsView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MusicPlayerListSongsView");

                [MenuItem(CATEGORY_MENU_PATH + "Music Player Play Now View", false, MENU_ITEM_PRIORITY)]
                public static void CreateMusicPlayerPlayNowView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MusicPlayerPlayNowView");

                [MenuItem(CATEGORY_MENU_PATH + "Music Player Sidebar View", false, MENU_ITEM_PRIORITY)]
                public static void CreateMusicPlayerSidebarView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MusicPlayerSidebarView");

                [MenuItem(CATEGORY_MENU_PATH + "Product Detailed View", false, MENU_ITEM_PRIORITY)]
                public static void CreateProductDetailedView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProductDetailedView");

                [MenuItem(CATEGORY_MENU_PATH + "Product Simple View", false, MENU_ITEM_PRIORITY)]
                public static void CreateProductSimpleView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProductSimpleView");

                [MenuItem(CATEGORY_MENU_PATH + "Register View", false, MENU_ITEM_PRIORITY)]
                public static void CreateRegisterView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RegisterView");

                [MenuItem(CATEGORY_MENU_PATH + "Sidebar View", false, MENU_ITEM_PRIORITY)]
                public static void CreateSidebarView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SidebarView");

                [MenuItem(CATEGORY_MENU_PATH + "Welcome View", false, MENU_ITEM_PRIORITY)]
                public static void CreateWelcomeView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "WelcomeView");
            }

            public static class ViewPortrait
            {
                private const string CATEGORY_NAME = "View Portrait";
                private const string CATEGORY_MENU_PATH = TYPE_MENU_PATH + CATEGORY_NAME + "/";

                [MenuItem(CATEGORY_MENU_PATH + "Contact Form In View", false, MENU_ITEM_PRIORITY)]
                public static void CreateContactFormInView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ContactFormInView");

                [MenuItem(CATEGORY_MENU_PATH + "Contact Form Out View", false, MENU_ITEM_PRIORITY)]
                public static void CreateContactFormOutView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ContactFormOutView");

                [MenuItem(CATEGORY_MENU_PATH + "Filter View", false, MENU_ITEM_PRIORITY)]
                public static void CreateFilterView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "FilterView");

                [MenuItem(CATEGORY_MENU_PATH + "Login View", false, MENU_ITEM_PRIORITY)]
                public static void CreateLoginView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "LoginView");

                [MenuItem(CATEGORY_MENU_PATH + "Music Player Bottom Sidebar View", false, MENU_ITEM_PRIORITY)]
                public static void CreateMusicPlayerBottomSidebarView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MusicPlayerBottomSidebarView");

                [MenuItem(CATEGORY_MENU_PATH + "Music Player Browse View", false, MENU_ITEM_PRIORITY)]
                public static void CreateMusicPlayerBrowseView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MusicPlayerBrowseView");

                [MenuItem(CATEGORY_MENU_PATH + "Music Player List Songs View", false, MENU_ITEM_PRIORITY)]
                public static void CreateMusicPlayerListSongsView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MusicPlayerListSongsView");

                [MenuItem(CATEGORY_MENU_PATH + "Music Player Play Now View", false, MENU_ITEM_PRIORITY)]
                public static void CreateMusicPlayerPlayNowView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "MusicPlayerPlayNowView");

                [MenuItem(CATEGORY_MENU_PATH + "Product Detailed View", false, MENU_ITEM_PRIORITY)]
                public static void CreateProductDetailedView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProductDetailedView");

                [MenuItem(CATEGORY_MENU_PATH + "Product Simple View", false, MENU_ITEM_PRIORITY)]
                public static void CreateProductSimpleView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "ProductSimpleView");

                [MenuItem(CATEGORY_MENU_PATH + "Register View", false, MENU_ITEM_PRIORITY)]
                public static void CreateRegisterView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "RegisterView");

                [MenuItem(CATEGORY_MENU_PATH + "Sidebar View", false, MENU_ITEM_PRIORITY)]
                public static void CreateSidebarView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "SidebarView");

                [MenuItem(CATEGORY_MENU_PATH + "Welcome View", false, MENU_ITEM_PRIORITY)]
                public static void CreateWelcomeView(MenuCommand command) => UIMenuUtils.AddToScene(TYPE_NAME, CATEGORY_NAME, "WelcomeView");
            }
        }        
    }
}

