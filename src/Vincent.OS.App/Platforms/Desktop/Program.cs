/*
 * Vincent OS App, This is the repository of the project of the mini operating system Open Source: Vincent OS
 * Copyright (C) 2016 - 2024 - v38armageddon
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using Uno.UI.Runtime.Skia;

namespace Vincent.OS.App;
public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
#if (!useDependencyInjection && useLoggingFallback)
        App.InitializeLogging();

#endif
        var host = SkiaHostBuilder.Create()
            .App(() => new App())
            .UseX11()
            .UseLinuxFrameBuffer()
            .UseMacOS()
            .UseWindows()
            .Build();

        host.Run();
    }
}