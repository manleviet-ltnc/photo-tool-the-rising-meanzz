using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyAlbumEditor
{
    public partial class AlbumCalendar : UserControl
    {
        private AlbumManager _manager = null;
        public AlbumManager Manager
        {
            get { return _manager; }
            set
            {
                _manager = value;
                UpdateCalendar();
            }
        }
        public AlbumCalendar()
        {
            InitializeComponent();
        }
        private void UpdateCalendar()
        {
            DateTime minDate = DateTime.MaxValue;
            DateTime maxDate = DateTime.MinValue;
            calDates.RemoveAllBoldedDates();

            if (Manager == null)
            {
                minDate = DateTime.Now;
                maxDate = DateTime.Now.AddMonths(2);
            }
            else
            {
                foreach (Photograph p in Manager.Album)
                {
                    DateTime date = p.DateTaken;
                    calDates.AddBoldedDate(date);

                    if (date < minDate) minDate = date;
                    if (date > maxDate) maxDate = date;
                }
            }
            calDates.MinDate = minDate;
            calDates.MaxDate = maxDate;
            calDates.TodayDate = minDate;
            calDates.SelectionStart = minDate;
            calDates.UpdateBoldedDates();
        }
    }
}
