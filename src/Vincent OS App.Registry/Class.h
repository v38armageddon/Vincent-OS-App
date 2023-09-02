#pragma once

#include "Class.g.h"

namespace winrt::Vincent_OS_App_Registry::implementation
{
    struct Class : ClassT<Class>
    {
        Class() = default;

        int32_t MyProperty();
        void MyProperty(int32_t value);
    };
}

namespace winrt::Vincent_OS_App_Registry::factory_implementation
{
    struct Class : ClassT<Class, implementation::Class>
    {
    };
}
