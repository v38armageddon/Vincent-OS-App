#pragma once

#include "pch.h"
#include "ExplorerToVinDesk.h"
#include "VinDeskToExplorer.h"

using namespace System;
using namespace Microsoft::Win32;

namespace Vincent_OS_Registry {
	public ref class Registry
	{
		// On a pas besoin de déclarer les fonctions Ici vu qu'on a déjà déclaré pour le DLL
		public:
			void ToVinDesk();
			void ToExplorer();
	};
}