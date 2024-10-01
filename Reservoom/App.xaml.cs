using Reservoom.Models;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Hotel California");
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            hotel.MakeReservation(new Reservation(new RoomID(1, 3), "yavuz", new DateTime(2024, 1, 1), new DateTime(2024, 1, 2)));
            
            //
            IEnumerable<Reservation> reservations = hotel.GetAllReservations("yavuz");
            base.OnStartup(e);
        }
            
    }

}
