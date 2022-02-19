using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string RentalAdded = "Kiralama islemi basarili";
        public static string UserAdded = "Kullanici eklendi";
        public static string CustomerAdded = "Musteri eklendi";
        public static string CarNameInvalid = "Gecersiz araba ismi";
        public static string CarPriceInvalid = "Geecersiz araba fiyati";
        public static string CarsListed = "Arabalar listelendi";
        public static string RentalsListed = "Kiralamalar listelendi";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayit basarili";
        public static string UserNotFound = "Kullanici bulunamadi";
        public static string SuccessfullLogin = "Giris basarili";
        public static string PasswordError = "Parola hatali";
        public static string UserAlreadyExists = "Boyle bir kullanici mevcut";
        public static string AccessTokenCreated = "Token olusturuldu";
    }
}
