#pragma once

#include "pch.h"
#include "ExplorerToVinDesk.h"
#include "VinDeskToExplorer.h"

using namespace System;
using namespace Microsoft::Win32;

namespace Vincent_OS_Registry {
	public ref class Registry
	{
		// On a pas besoin de d�clarer les fonctions Ici vu qu'on a d�j� d�clar� pour le DLL
		public:
			void ToVinDesk();
			void ToExplorer();
	};
}