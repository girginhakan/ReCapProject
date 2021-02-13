using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string CarListed="Arabalar listelendi.";


        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcılar listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler güncellendi";

        public static string RentalAdded = "Araba kiralama işlemi başarıyla gerçekleştirildi";
        public static string RentalDeleted = "Araba kiralama işlemi iptal edildi";
        public static string RentalUpdated = "Araba kiralama işlemi güncellendi";
        public static string RentalListed = "Araba kiralama işlemleri listelendi";
        public static string FailedRental = "Henüz elinizdeki arabayı teslim etmediğiniz için yeni araba kiralayınız.";
    }
}
