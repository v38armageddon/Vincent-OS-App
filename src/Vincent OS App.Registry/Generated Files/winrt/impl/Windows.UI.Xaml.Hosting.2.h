// WARNING: Please don't edit this file. It was generated by C++/WinRT v2.0.220531.1

#pragma once
#ifndef WINRT_Windows_UI_Xaml_Hosting_2_H
#define WINRT_Windows_UI_Xaml_Hosting_2_H
#include "winrt/impl/Windows.UI.Composition.1.h"
#include "winrt/impl/Windows.UI.WindowManagement.1.h"
#include "winrt/impl/Windows.UI.Xaml.1.h"
#include "winrt/impl/Windows.UI.Xaml.Controls.1.h"
#include "winrt/impl/Windows.UI.Xaml.Hosting.1.h"
WINRT_EXPORT namespace winrt::Windows::UI::Xaml::Hosting
{
    struct __declspec(empty_bases) ElementCompositionPreview : winrt::Windows::UI::Xaml::Hosting::IElementCompositionPreview
    {
        ElementCompositionPreview(std::nullptr_t) noexcept {}
        ElementCompositionPreview(void* ptr, take_ownership_from_abi_t) noexcept : winrt::Windows::UI::Xaml::Hosting::IElementCompositionPreview(ptr, take_ownership_from_abi) {}
        static auto GetElementVisual(winrt::Windows::UI::Xaml::UIElement const& element);
        static auto GetElementChildVisual(winrt::Windows::UI::Xaml::UIElement const& element);
        static auto SetElementChildVisual(winrt::Windows::UI::Xaml::UIElement const& element, winrt::Windows::UI::Composition::Visual const& visual);
        static auto GetScrollViewerManipulationPropertySet(winrt::Windows::UI::Xaml::Controls::ScrollViewer const& scrollViewer);
        static auto SetImplicitShowAnimation(winrt::Windows::UI::Xaml::UIElement const& element, winrt::Windows::UI::Composition::ICompositionAnimationBase const& animation);
        static auto SetImplicitHideAnimation(winrt::Windows::UI::Xaml::UIElement const& element, winrt::Windows::UI::Composition::ICompositionAnimationBase const& animation);
        static auto SetIsTranslationEnabled(winrt::Windows::UI::Xaml::UIElement const& element, bool value);
        static auto GetPointerPositionPropertySet(winrt::Windows::UI::Xaml::UIElement const& targetElement);
        static auto SetAppWindowContent(winrt::Windows::UI::WindowManagement::AppWindow const& appWindow, winrt::Windows::UI::Xaml::UIElement const& xamlContent);
        static auto GetAppWindowContent(winrt::Windows::UI::WindowManagement::AppWindow const& appWindow);
    };
}
#endif
