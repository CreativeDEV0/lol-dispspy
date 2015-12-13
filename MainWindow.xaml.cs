using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using MahApps.Metro.Controls.Dialogs;
using System.Security.Principal;
using MahApps.Metro;
class MainWindow
{

	string root;
	private void Tile1_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		Microsoft.Win32.OpenFileDialog o = new Microsoft.Win32.OpenFileDialog();
		o.Filter = "Application|*.exe";
		o.DefaultExt = ".exe";
		Nullable<bool> result = o.ShowDialog();
		if (result == true) {
			TextBox1.Text = o.FileName;
			FileInfo info = new FileInfo(o.FileName);
			root = info.DirectoryName;
			writeIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "General", "DEFAULT_PATH", o.FileName);
			if (IO.File.Exists(root + "\\Config\\game.cfg") == true) {
				if (IO.File.Exists(root + "\\Config\\input.ini") == true) {
					TextBox2.Text = ReadIni(root + "\\Config\\game.cfg", "General", "Width", "");
					TextBox3.Text = ReadIni(root + "\\Config\\game.cfg", "General", "Height", "");
					if (ReadIni(root + "\\Config\\game.cfg", "General", "Colors", "") == "16") {
						ComboBox5.SelectedIndex = 0;
					} else if (ReadIni(root + "\\Config\\game.cfg", "General", "Colors", "") == "32") {
						ComboBox5.SelectedIndex = 1;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "General", "WindowMode", "") == "1") {
						CheckBox1.IsChecked = true;
					} else {
						CheckBox1.IsChecked = false;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowsEnabled", "") == "1") {
						CheckBox2.IsChecked = true;
					} else {
						CheckBox2.IsChecked = false;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnableHUDAnimations", "") == "1") {
						CheckBox3.IsChecked = true;
					} else {
						CheckBox3.IsChecked = false;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnableParticleOptimizations", "") == "1") {
						CheckBox4.IsChecked = true;
					} else {
						CheckBox4.IsChecked = false;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnableFXAA", "") == "1") {
						CheckBox5.IsChecked = true;
					} else {
						CheckBox5.IsChecked = false;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "PerPixelPointLighting", "") == "1") {
						CheckBox6.IsChecked = true;
					} else {
						CheckBox6.IsChecked = false;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "AdvancedShader", "") == "1") {
						CheckBox7.IsChecked = true;
					} else {
						CheckBox7.IsChecked = false;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "GammaEnabled", "") == "1") {
						CheckBox8.IsChecked = true;
					} else {
						CheckBox8.IsChecked = false;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "Full3DModeEnabled", "") == "1") {
						CheckBox9.IsChecked = true;
					} else {
						CheckBox9.IsChecked = false;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "0") {
						ComboBox1.SelectedIndex = 0;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "1") {
						ComboBox1.SelectedIndex = 1;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "2") {
						ComboBox1.SelectedIndex = 2;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "3") {
						ComboBox1.SelectedIndex = 3;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "4") {
						ComboBox1.SelectedIndex = 4;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "5") {
						ComboBox1.SelectedIndex = 5;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "0") {
						ComboBox2.SelectedIndex = 0;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "1") {
						ComboBox2.SelectedIndex = 1;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "2") {
						ComboBox2.SelectedIndex = 2;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "3") {
						ComboBox2.SelectedIndex = 3;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "4") {
						ComboBox2.SelectedIndex = 4;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "0") {
						ComboBox3.SelectedIndex = 0;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "1") {
						ComboBox3.SelectedIndex = 1;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "2") {
						ComboBox3.SelectedIndex = 2;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "3") {
						ComboBox3.SelectedIndex = 3;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "4") {
						ComboBox3.SelectedIndex = 4;
					}
					if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "0") {
						ComboBox4.SelectedIndex = 0;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "1") {
						ComboBox4.SelectedIndex = 1;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "2") {
						ComboBox4.SelectedIndex = 2;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "3") {
						ComboBox4.SelectedIndex = 3;
					} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "4") {
						ComboBox4.SelectedIndex = 4;
					}
					Slider1.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "PingsVolume", ""), ".", ",");
					Slider2.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "AmbienceVolume", ""), ".", ",");
					Slider3.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "SfxVolume", ""), ".", ",");
					Slider4.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "MasterVolume", ""), ".", ",");
					Slider5.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "MusicVolume", ""), ".", ",");
					Slider6.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "VoiceVolume", ""), ".", ",");
					Slider7.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "AnnouncerVolume", ""), ".", ",");
					if (ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem4smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell2smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell1smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell1smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell4smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell3smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem5smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseVisionItemsmart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell2smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem6smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem1smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem3smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem2smart", "") == 1) {
						CheckBox10.IsChecked = true;
					} else if (ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem4smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell2smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell1smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell1smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell4smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell3smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem5smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseVisionItemsmart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell2smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem6smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem1smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem3smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem2smart", "") == 0) {
						CheckBox10.IsChecked = false;
						CheckBox10.IsChecked = false;
						CheckBox10.Content += " (Optional)";
					}
					Button1.IsEnabled = true;
				}
			} else {
				ShowMessageAsync("Opss.", "Unloaded settings. Unknown error.");
			}
		}
	}

	private void CheckBox1_Unchecked(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		if (CheckBox1.IsChecked == true) {
			CheckBox1.Content = "Checked";
		} else {
			CheckBox1.Content = "Unchecked";
		}
	}

	private void CheckBox1_Checked(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		if (CheckBox1.IsChecked == true) {
			CheckBox1.Content = "Checked";
		} else {
			CheckBox1.Content = "Unchecked";
		}
	}

	private void Button1_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		TextBox2.Text = ReadIni(root + "\\Config\\game.cfg", "General", "Width", "");
		TextBox3.Text = ReadIni(root + "\\Config\\game.cfg", "General", "Height", "");
		if (ReadIni(root + "\\Config\\game.cfg", "General", "Colors", "") == "16") {
			ComboBox5.SelectedIndex = 0;
		} else if (ReadIni(root + "\\Config\\game.cfg", "General", "Colors", "") == "32") {
			ComboBox5.SelectedIndex = 1;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "General", "WindowMode", "") == "1") {
			CheckBox1.IsChecked = true;
		} else {
			CheckBox1.IsChecked = false;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowsEnabled", "") == "1") {
			CheckBox2.IsChecked = true;
		} else {
			CheckBox2.IsChecked = false;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnableHUDAnimations", "") == "1") {
			CheckBox3.IsChecked = true;
		} else {
			CheckBox3.IsChecked = false;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnableParticleOptimizations", "") == "1") {
			CheckBox4.IsChecked = true;
		} else {
			CheckBox4.IsChecked = false;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnableFXAA", "") == "1") {
			CheckBox5.IsChecked = true;
		} else {
			CheckBox5.IsChecked = false;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "PerPixelPointLighting", "") == "1") {
			CheckBox6.IsChecked = true;
		} else {
			CheckBox6.IsChecked = false;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "AdvancedShader", "") == "1") {
			CheckBox7.IsChecked = true;
		} else {
			CheckBox7.IsChecked = false;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "GammaEnabled", "") == "1") {
			CheckBox8.IsChecked = true;
		} else {
			CheckBox8.IsChecked = false;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "Full3DModeEnabled", "") == "1") {
			CheckBox9.IsChecked = true;
		} else {
			CheckBox9.IsChecked = false;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "0") {
			ComboBox1.SelectedIndex = 0;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "1") {
			ComboBox1.SelectedIndex = 1;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "2") {
			ComboBox1.SelectedIndex = 2;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "3") {
			ComboBox1.SelectedIndex = 3;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "4") {
			ComboBox1.SelectedIndex = 4;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "5") {
			ComboBox1.SelectedIndex = 5;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "0") {
			ComboBox2.SelectedIndex = 0;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "1") {
			ComboBox2.SelectedIndex = 1;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "2") {
			ComboBox2.SelectedIndex = 2;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "3") {
			ComboBox2.SelectedIndex = 3;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "4") {
			ComboBox2.SelectedIndex = 4;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "0") {
			ComboBox3.SelectedIndex = 0;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "1") {
			ComboBox3.SelectedIndex = 1;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "2") {
			ComboBox3.SelectedIndex = 2;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "3") {
			ComboBox3.SelectedIndex = 3;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "4") {
			ComboBox3.SelectedIndex = 4;
		}
		if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "0") {
			ComboBox4.SelectedIndex = 0;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "1") {
			ComboBox4.SelectedIndex = 1;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "2") {
			ComboBox4.SelectedIndex = 2;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "3") {
			ComboBox4.SelectedIndex = 3;
		} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "4") {
			ComboBox4.SelectedIndex = 4;
		}
		Slider1.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "PingsVolume", ""), ".", ",");
		Slider2.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "AmbienceVolume", ""), ".", ",");
		Slider3.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "SfxVolume", ""), ".", ",");
		Slider4.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "MasterVolume", ""), ".", ",");
		Slider5.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "MusicVolume", ""), ".", ",");
		Slider6.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "VoiceVolume", ""), ".", ",");
		Slider7.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "AnnouncerVolume", ""), ".", ",");
		if (ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem4smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell2smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell1smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell1smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell4smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell3smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem5smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseVisionItemsmart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell2smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem6smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem1smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem3smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem2smart", "") == 1) {
			CheckBox10.IsChecked = true;
		} else if (ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem4smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell2smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell1smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell1smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell4smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell3smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem5smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseVisionItemsmart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell2smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem6smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem1smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem3smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem2smart", "") == 0) {
			CheckBox10.IsChecked = false;
			CheckBox10.IsChecked = false;
			CheckBox10.Content += " (Optional)";
		}
	}

	private void Slider8_ValueChanged(System.Object sender, System.Windows.RoutedPropertyChangedEventArgs<System.Double> e)
	{
		if (Slider8.Value == "0") {
			ComboBox1.SelectedIndex = 1;
			ComboBox2.SelectedIndex = 0;
			ComboBox3.SelectedIndex = 0;
			ComboBox4.SelectedIndex = 0;
		} else if (Slider8.Value >= "1,0" & Slider8.Value < 2) {
			ComboBox1.SelectedIndex = 2;
			ComboBox2.SelectedIndex = 1;
			ComboBox3.SelectedIndex = 1;
			ComboBox4.SelectedIndex = 1;
		} else if (Slider8.Value >= "2,0" & Slider8.Value < 3) {
			ComboBox1.SelectedIndex = 3;
			ComboBox2.SelectedIndex = 2;
			ComboBox3.SelectedIndex = 2;
			ComboBox4.SelectedIndex = 2;
		} else if (Slider8.Value >= "3,0" & Slider8.Value < 4) {
			ComboBox1.SelectedIndex = 4;
			ComboBox2.SelectedIndex = 3;
			ComboBox3.SelectedIndex = 3;
			ComboBox4.SelectedIndex = 3;
		} else if (Slider8.Value == "4,0") {
			ComboBox1.SelectedIndex = 5;
			ComboBox2.SelectedIndex = 4;
			ComboBox3.SelectedIndex = 4;
			ComboBox4.SelectedIndex = 4;
		}
	}

	private void Tile3_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		try {
			Process.Start(TextBox1.Text);
		} catch (Exception ex) {
			ShowMessageAsync("Opss.", "Are you sure you select the launcher?");
		}
	}

	private void Tile2_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		if (string.IsNullOrEmpty(TextBox1.Text)) {
			ShowMessageAsync("Opss.", "Are you sure you select the launcher?");
		} else {
			if (IO.File.Exists(root + "\\Config\\game.cfg") == true) {
				if (IO.File.Exists(root + "\\Config\\input.ini") == true) {
					writeIni(root + "\\Config\\game.cfg", "General", "Width", TextBox2.Text);
					writeIni(root + "\\Config\\game.cfg", "General", "Height", TextBox3.Text);
					if (ComboBox5.SelectedIndex == 0) {
						writeIni(root + "\\Config\\game.cfg", "General", "Colors", "16");
					} else if (ComboBox5.SelectedIndex == 1) {
						writeIni(root + "\\Config\\game.cfg", "General", "Colors", "32");
					}
					if (CheckBox1.IsChecked == true) {
						writeIni(root + "\\Config\\game.cfg", "General", "WindowMode", "1");
					} else {
						writeIni(root + "\\Config\\game.cfg", "General", "WindowMode", "0");
					}
					if (CheckBox2.IsChecked == true) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "ShadowsEnabled", "1");
					} else {
						writeIni(root + "\\Config\\game.cfg", "Performance", "ShadowsEnabled", "0");
					}
					if (CheckBox3.IsChecked == true) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnableHUDAnimations", "1");
					} else {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnableHUDAnimations", "0");
					}
					if (CheckBox4.IsChecked == true) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnableParticleOptimizations", "1");
					} else {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnableParticleOptimizations", "0");
					}
					if (CheckBox5.IsChecked == true) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnableFXAA", "1");
					} else {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnableFXAA", "0");
					}
					if (CheckBox6.IsChecked == true) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "PerPixelPointLighting", "1");
					} else {
						writeIni(root + "\\Config\\game.cfg", "Performance", "PerPixelPointLighting", "0");
					}
					if (CheckBox7.IsChecked == true) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "AdvancedShader", "1");
					} else {
						writeIni(root + "\\Config\\game.cfg", "Performance", "AdvancedShader", "0");
					}
					if (CheckBox8.IsChecked == true) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "GammaEnabled", "1");
					} else {
						writeIni(root + "\\Config\\game.cfg", "Performance", "GammaEnabled", "0");
					}
					if (CheckBox9.IsChecked == true) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "Full3DModeEnabled", "1");
					} else {
						writeIni(root + "\\Config\\game.cfg", "Performance", "Full3DModeEnabled", "0");
					}
					if (CheckBox10.IsChecked == true) {
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem4smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell2smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell1smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell1smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell4smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell3smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem5smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseVisionItemsmart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell2smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem6smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem1smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem3smart", "1");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem2smart", "1");
					} else if (CheckBox10.Content.ToString.Contains("Optional")) {
					} else {
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem4smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell2smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell1smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell1smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell4smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell3smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem5smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseVisionItemsmart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell2smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem6smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem1smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem3smart", "0");
						writeIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem2smart", "0");
					}
					if (ComboBox1.SelectedIndex == 0) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "0");
					} else if (ComboBox1.SelectedIndex == 1) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "1");
					} else if (ComboBox1.SelectedIndex == 2) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "2");
					} else if (ComboBox1.SelectedIndex == 3) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "3");
					} else if (ComboBox1.SelectedIndex == 4) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "4");
					} else if (ComboBox1.SelectedIndex == 5) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "5");
					}
					if (ComboBox2.SelectedIndex == 0) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "0");
					} else if (ComboBox2.SelectedIndex == 1) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "1");
					} else if (ComboBox2.SelectedIndex == 2) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "2");
					} else if (ComboBox2.SelectedIndex == 3) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "3");
					} else if (ComboBox2.SelectedIndex == 4) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "4");
					}
					if (ComboBox3.SelectedIndex == 0) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "0");
					} else if (ComboBox3.SelectedIndex == 1) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "1");
					} else if (ComboBox3.SelectedIndex == 2) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "2");
					} else if (ComboBox3.SelectedIndex == 3) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "3");
					} else if (ComboBox3.SelectedIndex == 4) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "4");
					}
					if (ComboBox4.SelectedIndex == 0) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "0");
					} else if (ComboBox4.SelectedIndex == 1) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "1");
					} else if (ComboBox4.SelectedIndex == 2) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "2");
					} else if (ComboBox4.SelectedIndex == 3) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "3");
					} else if (ComboBox4.SelectedIndex == 4) {
						writeIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "4");
					}
					writeIni(root + "\\Config\\game.cfg", "Volume", "PingsVolume", Strings.Replace(Math.Round(Slider1.Value, 2), ",", "."));
					writeIni(root + "\\Config\\game.cfg", "Volume", "AmbienceVolume", Strings.Replace(Math.Round(Slider2.Value, 2), ",", "."));
					writeIni(root + "\\Config\\game.cfg", "Volume", "SfxVolume", Strings.Replace(Math.Round(Slider3.Value, 2), ",", "."));
					writeIni(root + "\\Config\\game.cfg", "Volume", "MasterVolume", Strings.Replace(Math.Round(Slider4.Value, 2), ",", "."));
					writeIni(root + "\\Config\\game.cfg", "Volume", "MusicVolume", Strings.Replace(Math.Round(Slider5.Value, 2), ",", "."));
					writeIni(root + "\\Config\\game.cfg", "Volume", "VoiceVolume", Strings.Replace(Math.Round(Slider6.Value, 2), ",", "."));
					writeIni(root + "\\Config\\game.cfg", "Volume", "AnnouncerVolume", Strings.Replace(Math.Round(Slider7.Value, 2), ",", "."));
					ShowMessageAsync("Successful.", "All settings was saved.");
				}
			} else {
				ShowMessageAsync("Opss.", "Settings wasn't saved. Unknown error.");
			}
		}
	}

	private void CheckBox10_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		CheckBox10.Content = "Smart use of all abilities.";
	}

	private void MetroWindow_Loaded(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		TextBox2.Text = System.Windows.SystemParameters.PrimaryScreenWidth;
		TextBox3.Text = System.Windows.SystemParameters.PrimaryScreenHeight;
		ThemeChanger.SelectedIndex = ReadIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "Style", "COLOR", "");
		if (ReadIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "General", "AUTO_LOAD", "") == "1") {
			AutoLoad.IsChecked = true;
		} else {
			AutoLoad.IsChecked = false;
		}
		bool isElevated = false;
		WindowsIdentity identity = WindowsIdentity.GetCurrent();
		WindowsPrincipal principal = new WindowsPrincipal(identity);
		isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
		if (principal.IsInRole(WindowsBuiltInRole.Administrator)) {
			this.Title = "LoL DıspSpy [Admınıstrator]";
		}
		dynamic default_path = ReadIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "General", "DEFAULT_PATH", "");
		dynamic auto_load = ReadIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "General", "AUTO_LOAD", "");
		if (auto_load == "1") {
			if (File.Exists(default_path) == true) {
				TextBox1.Text = default_path;
				Microsoft.Win32.OpenFileDialog o = new Microsoft.Win32.OpenFileDialog();
				o.FileName = default_path;
				IO.FileInfo a = new IO.FileInfo(o.FileName);
				root = a.DirectoryName;
				if (IO.File.Exists(root + "\\Config\\game.cfg") == true) {
					if (IO.File.Exists(root + "\\Config\\input.ini") == true) {
						TextBox2.Text = ReadIni(root + "\\Config\\game.cfg", "General", "Width", "");
						TextBox3.Text = ReadIni(root + "\\Config\\game.cfg", "General", "Height", "");
						if (ReadIni(root + "\\Config\\game.cfg", "General", "Colors", "") == "16") {
							ComboBox5.SelectedIndex = 0;
						} else if (ReadIni(root + "\\Config\\game.cfg", "General", "Colors", "") == "32") {
							ComboBox5.SelectedIndex = 1;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "General", "WindowMode", "") == "1") {
							CheckBox1.IsChecked = true;
						} else {
							CheckBox1.IsChecked = false;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowsEnabled", "") == "1") {
							CheckBox2.IsChecked = true;
						} else {
							CheckBox2.IsChecked = false;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnableHUDAnimations", "") == "1") {
							CheckBox3.IsChecked = true;
						} else {
							CheckBox3.IsChecked = false;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnableParticleOptimizations", "") == "1") {
							CheckBox4.IsChecked = true;
						} else {
							CheckBox4.IsChecked = false;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnableFXAA", "") == "1") {
							CheckBox5.IsChecked = true;
						} else {
							CheckBox5.IsChecked = false;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "PerPixelPointLighting", "") == "1") {
							CheckBox6.IsChecked = true;
						} else {
							CheckBox6.IsChecked = false;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "AdvancedShader", "") == "1") {
							CheckBox7.IsChecked = true;
						} else {
							CheckBox7.IsChecked = false;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "GammaEnabled", "") == "1") {
							CheckBox8.IsChecked = true;
						} else {
							CheckBox8.IsChecked = false;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "Full3DModeEnabled", "") == "1") {
							CheckBox9.IsChecked = true;
						} else {
							CheckBox9.IsChecked = false;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "0") {
							ComboBox1.SelectedIndex = 0;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "1") {
							ComboBox1.SelectedIndex = 1;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "2") {
							ComboBox1.SelectedIndex = 2;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "3") {
							ComboBox1.SelectedIndex = 3;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "4") {
							ComboBox1.SelectedIndex = 4;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "ShadowQuality", "") == "5") {
							ComboBox1.SelectedIndex = 5;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "0") {
							ComboBox2.SelectedIndex = 0;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "1") {
							ComboBox2.SelectedIndex = 1;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "2") {
							ComboBox2.SelectedIndex = 2;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "3") {
							ComboBox2.SelectedIndex = 3;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "CharacterQuality", "") == "4") {
							ComboBox2.SelectedIndex = 4;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "0") {
							ComboBox3.SelectedIndex = 0;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "1") {
							ComboBox3.SelectedIndex = 1;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "2") {
							ComboBox3.SelectedIndex = 2;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "3") {
							ComboBox3.SelectedIndex = 3;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EffectsQuality", "") == "4") {
							ComboBox3.SelectedIndex = 4;
						}
						if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "0") {
							ComboBox4.SelectedIndex = 0;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "1") {
							ComboBox4.SelectedIndex = 1;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "2") {
							ComboBox4.SelectedIndex = 2;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "3") {
							ComboBox4.SelectedIndex = 3;
						} else if (ReadIni(root + "\\Config\\game.cfg", "Performance", "EnvironmentQuality", "") == "4") {
							ComboBox4.SelectedIndex = 4;
						}
						Slider1.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "PingsVolume", ""), ".", ",");
						Slider2.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "AmbienceVolume", ""), ".", ",");
						Slider3.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "SfxVolume", ""), ".", ",");
						Slider4.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "MasterVolume", ""), ".", ",");
						Slider5.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "MusicVolume", ""), ".", ",");
						Slider6.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "VoiceVolume", ""), ".", ",");
						Slider7.Value = Strings.Replace(ReadIni(root + "\\Config\\game.cfg", "Volume", "AnnouncerVolume", ""), ".", ",");
						if (ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem4smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell2smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell1smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell1smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell4smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell3smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem5smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseVisionItemsmart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell2smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem6smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem1smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem3smart", "") == 1 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem2smart", "") == 1) {
							CheckBox10.IsChecked = true;
						} else if (ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem4smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell2smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastAvatarSpell1smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell1smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell4smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell3smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem5smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseVisionItemsmart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtCastSpell2smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem6smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem1smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem3smart", "") == 0 & ReadIni(root + "\\Config\\input.ini", "Quickbinds", "evtUseItem2smart", "") == 0) {
							CheckBox10.IsChecked = false;
							CheckBox10.IsChecked = false;
							CheckBox10.Content += " (Optional)";
						}
						Button1.IsEnabled = true;
					}
				} else {
					ShowMessageAsync("Opss.", "Unloaded settings. Unknown error.");
				}
			}
		}
	}

	private void ThemeChanger_SelectionChanged(System.Object sender, System.Windows.Controls.SelectionChangedEventArgs e)
	{
		if (ThemeChanger.SelectedIndex == 0) {
			ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("Blue"), ThemeManager.GetAppTheme("BaseLight"));
			writeIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "Style", "COLOR", "0");
		} else if (ThemeChanger.SelectedIndex == 1) {
			ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("Purple"), ThemeManager.GetAppTheme("BaseDark"));
			writeIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "Style", "COLOR", "1");
		} else if (ThemeChanger.SelectedIndex == 2) {
			ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("Red"), ThemeManager.GetAppTheme("BaseLight"));
			writeIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "Style", "COLOR", "2");
		} else if (ThemeChanger.SelectedIndex == 3) {
			ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("Green"), ThemeManager.GetAppTheme("BaseLight"));
			writeIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "Style", "COLOR", "3");
		} else if (ThemeChanger.SelectedIndex == 4) {
			ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("Olive"), ThemeManager.GetAppTheme("BaseDark"));
			writeIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "Style", "COLOR", "4");
		}
	}

	private void AutoLoad_Checked(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		writeIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "General", "AUTO_LOAD", "1");
	}

	private void AutoLoad_Unchecked(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		writeIni(System.AppDomain.CurrentDomain.BaseDirectory + "appsettings.ini", "General", "AUTO_LOAD", "0");
	}
	public MainWindow()
	{
		Loaded += MetroWindow_Loaded;
	}
}
