using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikOcagi
{
    public static class PoliklinikVeriAktarimi
    {
        public static string poliklinikAd="", poliklinikAciklama="", gecerliMi="";
    }

    public static class KullaniciVeriAktarimi
    {
        public static string kullaniciUserName = "";
    }

    public static class YetkiliKullaniciKontorl
    {
        public static string YetkliKullanici ="false";
    }

    public static class HastaIslemleriHastaBilgisiAktarma
    {
        public static string HastaDosyaNo = "",SeciliKullaniciDosyaNoBelirleme="";
        public static string HastaDosyaNoBulButon = "";
    }
    public static class HastaTaburcuEkraniVeri
    {
        public static string dosyaNo = "",odeme_sekli="",toplam_tutar="",saat="";
        public static DateTime? cikis_tarihi=null, sevk_tarih=null;
    }
}
