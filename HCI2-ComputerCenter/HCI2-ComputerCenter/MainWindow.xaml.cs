using Syncfusion.UI.Xaml.Schedule;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI2_ComputerCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //this.DataContext = this;

            


            InitializeComponent();
            Schedule.DayViewColumnCount = 10;
            fillTable();
        }

        private void fillTable()
        {
            //this.Resources["Header"] = "L1";
            //ResourceType resourceType = (ResourceType)

            ResourceType resourceType = new ResourceType() { TypeName = "Classroom" };

            resourceType.ResourceCollection.Add(new Resource { DisplayName = "L1", ResourceName = "L1", });
            resourceType.ResourceCollection.Add(new Resource { DisplayName = "L2", ResourceName = "L2", });
            resourceType.ResourceCollection.Add(new Resource { DisplayName = "L3", ResourceName = "L3", });


            Schedule.ScheduleResourceTypeCollection = new ObservableCollection<ResourceType> { resourceType };

            Schedule.DayViewColumnCount = 10;
               
            
            

            //Schedule.Resource = "Classroom";
        }
    }
}
