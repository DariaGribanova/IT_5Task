using System;
using System.Collections.Generic;
using WinFormsApp1.Classes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var devices = new List<IDevice>();

            var digitalCamera = new DigitalCamera()
            {
                Brand = "Nikon",
                Name = "Z9 body",
                Viewfinder = true,
                MemorySize = 32,
                MegaPixels = 48,
            };

            var analogCamera = new AnalogCamera()
            {
                Brand = "Kodak",
                Name = "M35",
                Viewfinder = false,
                BatteryLife = 60,
                WeatherSealing = true,
            };

            var polaroid = new Polaroid()
            {
                Brand = "Polaroid",
                Name = "Now",
                Viewfinder = false,
                DevelopmentTime = 10,
                BodyMaterial = "Plastic",
            };

            devices.Add(digitalCamera);
            devices.Add(analogCamera);
            devices.Add(polaroid);

            foreach (var device in devices)
            {
                Console.WriteLine(device.TurnOn());
                if (device is Camera camera)
                {
                    if (camera is DigitalCamera digCamera)
                    {
                        Console.WriteLine(digCamera.SetZoom(1.4));
                        Console.WriteLine(digCamera.SetShutterSpeed(5));
                    }
                    if (camera is AnalogCamera anCamera)
                    {
                        Console.WriteLine(anCamera.InsertFilm());
                        Console.WriteLine(anCamera.Charge(20, 220));
                    }
                    if (camera is Polaroid pol)
                    {
                        Console.WriteLine(pol.InsertCartridges(10));
                        Console.WriteLine(pol.TurnOnFlash());
                    }
                    Console.WriteLine(camera.TakePhoto());

                }
                Console.WriteLine();
            }
        }
    }
    
}
