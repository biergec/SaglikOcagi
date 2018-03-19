# Kısaca Uygulama

Tasarım desenleri dersini almadan önce yaptığım bir proje. OOP Adına pek bir şey yapmamış olsam da projem. Database sql sorgu dosyası içerisinde mevcuttur. <br>
Projede database bağlantısını singleton olarak tasarladım. ( Sonradan eklendi)<br>
Proje sırasında kalsik bağlantı metotlarını ve parametre kullanımını öğrenmek amacı ile her hangi bir Framework kullanmamıştım (Büyük hata).<br>
Pek Class kullanmamış olmam en büyük hatam diyebilirim projemde.<br>


# Sağlık Ocağı Hasta Takip Sistemi Genel Tasarım/Kodlama Bilgileri
Sağlık ocaklarında hastaların poliklinik giriş ve çıkışlarının takibi ve raporlanması amacıyla yapılan bir otomasyon.<br>

# Genel Program Kapsamı

- Dosya no veya isme göre kullanıcı bulma/oluşturma.<br>
- Dosya numarası bilinmeyen hasta geldiğinde Dosya Arama Yardımı penceresi ile kullanıcı bulma.<br>
- Muayeneye gelen hasta için her gelişinde sevk açılmaz, Sevk tarihi ile dosya numarası birlikte hastanın bir kez gelişini birlikte primary key olarak ifade eder.<br>
- Hastanın Gerekli bilgilerinin düzenlendiği bir form bulunmaktadır.<br>
- Hastanın poliklinikte muayene için bekleyeceği sıra numarası otomatik olarak verilir. <br>
- Hastanın hesabında silinmek istenen işlem veya tahlil grid satır baslığından seçilerek buton ile silinir. <br>
- Formu temizleyerek yeni bir hastaya işlem yapabilmeye hazır hale getirilebilir. <br>
- Hastanın bu sevkine ait bilgileri yazdırılırabilir.<br>
- Doktor tanıtma, Kullanıcı tanıtma, Eleman tanıtma ekranları bulunmaktadır.<br>
