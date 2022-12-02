#pragma once

#include "pch.h"
#include "Check.h"
#include "ExplorerToVinDesk.h"
#include "VinDeskToExplorer.h"

using namespace System;

namespace Vincent_OS_Registry {
	public ref class Regedit
	{
		void GetInfo();
		void AtStart();
	};
}