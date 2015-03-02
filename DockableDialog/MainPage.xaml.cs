using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Navigation;
using System.Windows.Controls.Primitives;
using System.Reflection;
using System.Drawing;
using System.Configuration;
using System.Collections.Generic;
using Autodesk.Revit.UI;
using System.Text;

namespace DockableDialog.Forms
{
  /// <summary>
  /// Interaction logic for UserControl1.xaml
  /// </summary>
  public partial class MainPage : Page, Autodesk.Revit.UI.IDockablePaneProvider
  {
    #region Data
    private Guid m_targetGuid;
    private DockPosition m_position = DockPosition.Bottom;
    private int m_left = 1;
    private int m_right = 1;
    private int m_top = 1;
    private int m_bottom = 1;
    const string _url_tbc = "http://thebuildingcoder.typepad.com";
    const string _url_git = "https://github.com/jeremytammik/DockableDialog";
    #endregion

    public MainPage()
    {
      InitializeComponent();
    }

    public void SetupDockablePane( Autodesk.Revit.UI.DockablePaneProviderData data )
    {
      data.FrameworkElement = this as FrameworkElement;
      data.InitialState = new Autodesk.Revit.UI.DockablePaneState();
      data.InitialState.DockPosition = DockPosition.Tabbed;
      //DockablePaneId targetPane;
      //if (m_targetGuid == Guid.Empty)
      //    targetPane = null;
      //else targetPane = new DockablePaneId(m_targetGuid);
      //if (m_position == DockPosition.Tabbed)
      data.InitialState.TabBehind = Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ProjectBrowser;
      //if (m_position == DockPosition.Floating)
      //{
      //data.InitialState.SetFloatingRectangle(new Autodesk.Revit.UI.Rectangle(10, 710, 10, 710));
      //data.InitialState.DockPosition = DockPosition.Tabbed;
      //}
      //Log.Message("***Intial docking parameters***");
      //Log.Message(APIUtility.GetDockStateSummary(data.InitialState));
    }

    public void SetInitialDockingParameters( int left, int right, int top, int bottom, DockPosition position, Guid targetGuid )
    {
      m_position = position;
      m_left = left;
      m_right = right;
      m_top = top;
      m_bottom = bottom;
      m_targetGuid = targetGuid;
    }

    private void PaneInfoButton_Click( object sender, RoutedEventArgs e )
    {
      web_browser.Navigate( _url_tbc );
    }

    private void wpf_stats_Click( object sender, RoutedEventArgs e )
    {
      web_browser.Navigate( _url_git );
    }

    private void btn_getById_Click( object sender, RoutedEventArgs e )
    {
      web_browser.Navigate( _url_tbc );
    }

    private void btn_listTabs_Click( object sender, RoutedEventArgs e )
    {
      web_browser.Navigate( _url_git );
    }

    private void DockableDialogs_Loaded( object sender, RoutedEventArgs e )
    {
      web_browser.Navigate( _url_tbc );
    }
  }
}
