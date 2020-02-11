using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Basarili Ekleme P";
        public static string ProductDeleted = "Basarili Silindi P";
        public static string ProductUpdated = "Basarili Guncellendi P";

        public static string CategoryAdded = "Basarili Ekleme";
        public static string CategoryDeleted = "Basarili Silindi";
        public static string CategoryUpdated = "Basarili Guncellendi";

        public static string UserNotFound = "Kullanıcı Bulunamadi";

        public static string PasswordError = "Şifre Hatali";

        public static string SuccessLogin = "Giris Basarili";

        public static string UserAlreadyExists = "Kullanci Mevcut";
        public static string UserRegistered = "Kullanici Basarili Kayit";
        public static string AccessTokenCreated = "Access Token Olusturuldu";
    }
}
