using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakım Zamanı.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist = "Aynı isimli ürün ekleyemezsiniz";
        public static string CategoryLimitExceded = "Kategori sayısı 15 i geçerse ürün ekleyemezsiniz";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered="Kayıt olundu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token yaratıldı";
    }
}
