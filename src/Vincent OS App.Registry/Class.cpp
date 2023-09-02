#include "pch.h"
#include "Class.h"
#include "Class.g.cpp"

namespace winrt::Vincent_OS_App_Registry::implementation
{
    int32_t Class::MyProperty()
    {
        throw hresult_not_implemented();
    }

    void Class::MyProperty(int32_t /* value */)
    {
        throw hresult_not_implemented();
    }
}
