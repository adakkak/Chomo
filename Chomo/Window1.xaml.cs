using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chomo
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            btnConvert.IsEnabled = false;

            entSource.Text = @"C:\Users\Abdulmajed Dakkak\Downloads\States\states.shp";
            entDestination.Text = @"C:\Users\Abdulmajed Dakkak\Downloads\States\out.kml";
            btnConvert.IsEnabled = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void btnDestination_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.FileName = "Select File to Convert";

            Nullable<bool> result = saveFileDialog.ShowDialog();

            if (result == true)
            {
                entDestination.Text = saveFileDialog.FileName.ToLower();
                if (!(entDestination.Text.EndsWith(".shp") ||
                       entDestination.Text.EndsWith(".kml")))
                {
                    entDestination.Text = "Extension Must be SHP or KML";
                    btnConvert.IsEnabled = false;
                }
                else
                {
                    if (entSource.Text.EndsWith(".shp") ||
                           entSource.Text.EndsWith(".kml"))
                    {
                        btnConvert.IsEnabled = true;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSource_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.FileName = "Select File to Convert";

            Nullable<bool> result = openFileDialog.ShowDialog();

            if (result == true)
            {
                entSource.Text = openFileDialog.FileName.ToLower();
                if (!(entSource.Text.EndsWith(".shp") ||
                       entSource.Text.EndsWith(".kml")))
                {
                    entSource.Text = "Extension Must be SHP or KML";
                    btnConvert.IsEnabled = false;
                }
                
                else
                {
                    if (entDestination.Text.EndsWith(".shp") ||
                           entDestination.Text.EndsWith(".kml"))
                    {
                        btnConvert.IsEnabled = true;
                    }
                }
            }
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            string sourceFile = entSource.Text;
            string destinationFile = entDestination.Text;

            if (sourceFile.EndsWith(".shp"))
            {
                SHP2KML(sourceFile, destinationFile);
            }
            else
            {
                KML2SHP(sourceFile, destinationFile);
            }
        }

        private void SHP2KML(string shpFile, string kmlFile)
        {
            SharpMap.Data.Providers.ShapeFile shp = new SharpMap.Data.Providers.ShapeFile(shpFile);
            SharpMap.Data.FeatureDataSet fds = new SharpMap.Data.FeatureDataSet();
            
            shp.Open();
            shp.ExecuteIntersectionQuery(shp.GetExtents(), fds);
            System.Data.DataTable dt = fds.Tables[0];

            KMLib.KMLRoot kml = new KMLib.KMLRoot();
            for (int i = 0; i < dt.Rows.Count; i++ )
            {
                SharpMap.Data.FeatureDataRow row = dt.Rows[i] as SharpMap.Data.FeatureDataRow;
                
                StringBuilder description = new StringBuilder();

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    description.Append("<p><b>" + capitalize(dt.Columns[j].ToString()) + "</b>:  " + row[j] + "</p>\n");
                }


                if (row.Geometry is SharpMap.Geometries.Point)
                {
                    var pointGeom = row.Geometry as SharpMap.Geometries.Point;
                    var placemark = new KMLib.Feature.Placemark();
                    placemark.Point = new KMLib.Geometry.KmlPoint((float) pointGeom.X, (float) pointGeom.Y);

                    placemark.description = description.ToString();

                    kml.Document.Add(placemark);
                }
                else if (row.Geometry is SharpMap.Geometries.Polygon)
                {
                    var polygonGeom = row.Geometry as SharpMap.Geometries.Polygon;
                    var placemark = new KMLib.Feature.Placemark();

                    var polygon = new KMLib.Polygon();
                    var boundary = new KMLib.BoundaryIs();
                    foreach (SharpMap.Geometries.Point vertex in polygonGeom.ExteriorRing.Vertices)
                    {
                        boundary.LinearRing.Coordinates.Add(new Core.Geometry.Point3D(vertex.X, vertex.Y));
                    }
                    boundary.LinearRing.CloseRing();
                    boundary.LinearRing.Extrude = true;
                    polygon.OuterBoundaryIs = boundary;

                    var interiorRing = new KMLib.BoundaryIs();
                    for (int j = 0; j < polygonGeom.NumInteriorRing; j++)
                    {
                        foreach (SharpMap.Geometries.Point point in polygonGeom.InteriorRing(j).Vertices)
                        {
                            interiorRing.LinearRing.Coordinates.Add(new Core.Geometry.Point3D(point.X, point.Y));
                        }
                        interiorRing.LinearRing.CloseRing();
                    }
                    polygon.InnerBoundaryIs = interiorRing;

                    placemark.Polygon = polygon;

                    kml.Document.Add(placemark);
                }
            }
            kml.Save(kmlFile);
            shp.Close();

            btnConvert.Content = "Done Converting";
        }

        private void KML2SHP(string kmlFile, string shpFile)
        {
        }

        private string capitalize(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }
    }
}
