using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Windows;


namespace EarthquakeApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Earthquake.Models.Earthquake> earthquakes = new List<Earthquake.Models.Earthquake>();
        private List<Earthquake.Models.Properties> properties = new List<Earthquake.Models.Properties>();

        private ObservableCollection<Earthquake.Models.Properties> source;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
          
            if (dataGrid.Items != null)
            {                                
                    dataGrid.Items.Clear();       
            }
           
        
            var httpWebRequest = (HttpWebRequest)WebRequest.Create($"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&limit={count.Text}&orderby=time");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Earthquake.Models.Earthquake answer = JsonConvert.DeserializeObject<Earthquake.Models.Earthquake>(result);

                earthquakes.Add(answer);
            }

            foreach (var earthquake in earthquakes)
            {
                foreach (var feature in earthquake.Features)
                {
                    properties.Add(feature.Properties);
                }
            } 
                 
            source= new ObservableCollection<Earthquake.Models.Properties>(properties);
            dataGrid.ItemsSource = source;

        }

      
    }


}
    