using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App99;
using App99.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntryCell), typeof(myEntryCelliOSCellRenderer))]
namespace App99.iOS
{
    public class myEntryCelliOSCellRenderer : EntryCellRenderer
    {

        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var nativeCell = (EntryCell)item;

            var cell = base.GetCell(nativeCell, reusableCell, tv);

            ((UITextField)cell.Subviews[0].Subviews[0]).TextColor = UIColor.Orange;
            ((UITextField)cell.Subviews[0].Subviews[0]).BackgroundColor = UIColor.Green;
            return cell;
        }
    }
}