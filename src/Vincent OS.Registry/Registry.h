#pragma once

#include "pch.h"
#include "ExplorerToVinDesk.h"
#include "VinDeskToExplorer.h"

using namespace System;
using namespace Microsoft::Win32;

namespace Vincent_OS_Registry {
	public ref class Registry
	{
		public:
			void Location();
			void ToVinDesk();
			void ToExplorer();
	};
}