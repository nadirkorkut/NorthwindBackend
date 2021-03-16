using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Başarıyla Eklendi";
        public static string ProductDeleted = "Ürün Başarıyla Silindi";
        public static string ProductUpdated = "Ürün Başarıyla Güncellendi";

        public static string CategoryAdded = "Kategori Başarıyla Eklendi";
        public static string CategoryDeleted = "Kategori Başarıyla Silindi";
        public static string CategoryUpdated = "Kategori Başarıyla Güncellendi";

        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Şifre Hatalı";
        public static string SuccessfulLogin="Sisteme Giriş Başaralı";
        public static string UserAlreadyExists="Bu Kullanıcı Mevcut";
        public static string UserRegistered="Kullanıcı Başarıyla Kaydedildi";
        public static string AccessTokenCreated="Access Token Başarıyla Oluşturuldu.";
    }
}
