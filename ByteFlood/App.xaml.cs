﻿/* 
    ByteFlood - A BitTorrent client.
    Copyright (C) 2014 Burak Öztunç

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.IO;

namespace ByteFlood
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ByteFlood.Settings Settings = new Settings();
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Settings = Settings.Load("./config.xml");

            var themerd = new ResourceDictionary();
            
            themerd.Source = new Uri(string.Format(@"PresentationFramework.{0};V3.0.0.0;31bf3856ad364e35;component\themes/{0}.normalcolor.xaml", Settings.Theme.ToString()), UriKind.Relative);
            Resources.MergedDictionaries.Add(themerd);
        }
    }
}
