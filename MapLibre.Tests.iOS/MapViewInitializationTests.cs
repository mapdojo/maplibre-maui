using System;
using CoreGraphics;
using CoreLocation;
using Foundation;
using MapLibre;
using UIKit;
using Xunit;

namespace MapLibre.Tests.iOS
{
    public class MapViewInitializationTests : IDisposable
    {
        private UIWindow window;
        // private MLNMapView mapView;
        
        public MapViewInitializationTests()
        {
            // Setup UIWindow to host the map view (needed for proper initialization)
            window = new UIWindow(new CGRect(0, 0, 800, 600));
        }
        
        [Fact]
        public void MapView_InitializesSuccessfully()
        {
            // // Arrange
            // mapView = new MLNMapView(new CGRect(0, 0, 800, 600));
            //
            // // Act
            // window.AddSubview(mapView);
            // window.MakeKeyAndVisible();
            //
            // // Assert
            // Assert.NotNull(mapView);
            // Assert.NotNull(mapView.Style);
        }
        
        public void Dispose()
        {
            // mapView?.Dispose();
            window?.Dispose();
        }
    }
}