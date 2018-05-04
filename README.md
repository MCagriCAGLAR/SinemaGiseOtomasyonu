# SinemaGiseOtomasyonu
Bilgisayar Mühendisliği, Yazılım Mühendisliği, Bilişim Sistemleri Mühendisliği vb. bölümlerde okuyan, yazılımla uğraşan öğrencilere yönelik kapsamlı, öğretici Veritabanı Yönetim Sistemleri, Nesneye Yönelik Programlama, Görsel Programlama dersleri için örnek Sinema Gişe Otomasyonu Projesidir. Projede Visual Studio C# + MySQL kullanılmıştır. Günümüzde WebTabanlı uygulamalar yaygın olarak kullanılmaktadır. Ancak bu projede masaüstü uygulama geliştirilmiştir.

# Programı Çalıştırmak İçin Gerekli Olan Yazılımlar
- WampServer, Link -> http://www.wampserver.com/en/
- Visual Studio 2017 Community Edition -> https://www.visualstudio.com/tr/thank-you-downloading-visual-studio/?sku=Community&rel=15
- SinemaGiseOtomasyonu\Resources klasöründe bulunan sinemagisesi.sql dosyasının bilgisayarınızda bulunması gerekir.

# MySQL Veritabanının Oluşturulması
Otomasyonda satis,satistur,kampanya,filmler,resimler,calisan,seans,bilet,resimler,filmtur,admin ve salon olmak üzere toplam 12 adet tablo bulunmaktadır.Tablolar birbirleriyle ilişkilendirilmiştir. Aşağıda Database Schema Dosyasının görünümü verilmiştir.


![MainMenus](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/veritabani.jpg "Main Menus")


# ANA MENÜ
Otomasyonumuzda ilk olarak açılan pencerede “Admin Girişi” ve “Çalışan Girişi ” olmak üzere iki kısım vardır.

Admin Girişinde güvenliği sağlamak amacıyla bir kullanıcı girişi bulunmaktadır.Girişi sağlayan personel kullanıcı adını ve şifresini girerek panele ulaşır. Daha sonra karşısına çıkan ekrandan Film,Salon,Seans “Ekle/Sil” veya Çalışan “Ekle/Sil” butonlarına ulaşır.


![MainMenus](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/AnaMenu.jpg "Main Menus")


# Admin Girişi
Admin Girişinde güvenliği sağlamak amacıyla bir kullanıcı girişi bulunmaktadır.Girişi sağlayan personel kullanıcı adını ve şifresini girerek panele ulaşır. Daha sonra karşısına çıkan ekrandan Film,Salon,Seans “Ekle/Sil” veya Çalışan “Ekle/Sil” butonlarına ulaşır.


![Admin Girişi](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/adminGiris.jpg "Admin Girişi")


# Admin Film/Salon/Seans Ekle-Sil
“Film,Salon,Seans Ekle/Sil”  paneli 3 kısımdan oluşmaktadır.Film ekle veya sil,salon ekle veya sil ve seans ekle veya sil kısımlarından oluşur.Erişimi sağlayan admin bu panelden vizyona yeni giren filmi ekleyebilir.Bu filmin salon ve seans bilgilerini girip çalışanların ulaşabileceği panele geçişini sağlar.Aynı zamanda vizyondan kalkan film bu panelden silinebilir.Yapılan işlemlerin görülmesi için ise hemen altta göster butonuna tıklanılarak yapılan değişiklikler gözlemlenebilir.


![FilmSalonSeansEkle](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/adminPanel.jpg "FilmSalonSeansEkle")


# Admin Çalışan Ekle/Sil Görüntüle
“Çalışan Ekle/Sil” panelinde ise giriş yapan admin yeni bir çalışan ekleyebilir veya bir çalışanı işten çıkarabilecektir.


![Admin Çalışan Ekleme](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/calisanEkle.jpg "Admin Çalışan Ekle/Sil")


# Çalışan Girişi
Çalışan giriş panelinde de güvenliği sağlamak amacıyla bir giriş ekranı bulunmaktadır.


![Çalışan Girişi](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/calisanGirisi.jpg "Çalışan Giriş")


# Çalışan Bilet Sat / İptal Et
Çalışan personel bu sayfadan girişi sağlayarak bilet “sat/iptal” ekranına ulaşır. 


![Çalışan Paneli](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/biletSatis.jpg "Çalışan Paneli")


# Müşteri Vizyondaki Filmleri Seçme
Müşterinin isteğine göre vizyondaki filmlerden biri seçilir. Ayrıca ekrandaki film afişlerine tıklanarak gerekli filmin fragmanı görüntülenebilir.Daha sonra salon ve seans seçilerek bilet satış sayfasına yönlendirme yapılır.


![Fragman](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/fragman.jpg "Fragman")


# Koltuk ve Fiyat Belirleme
Bu sayfada salondaki koltuklar görülür.Müşteri için koltuk seçildikten sonra diğer aşamada ise müşterinin öğrenci mi yoksa sivilmi olduğu bilgisi işaretlenir.Öğrenci ve tam biletlerin fiyatları farklıdır.Müşterinin adı soyadı gibi bilgileri girildikten sonra onay alınır ve bilet kesim işlemi alttaki toplam tutar ile birlikte gerçekleştirilir.


![Bilet Satış](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/koltuklar.jpg "Bilet Satış")


# Çalışan Bilet İptal Paneli
Bu sayfada önceden alınan biletin id’si ekrana girilerek biletin iptali gerçekleştirilir.


![Bilet İptal](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/biletiptal.jpg "Bilet İptal Sayfası")


# Çalışan Müşteriye Bilet Kesme İşlemi
Salondan alınan bilgiler ile birlikte bilet kesim işlemi bu ekrandan gerçekleşir.Biletimizi saat kaçta aldığımız,seans ve salon adlarıyla birlikte bu ekranda yazılıdır.


![Bilet Kesme](https://github.com/MCagriCAGLAR/SinemaGiseOtomasyonu/blob/master/biletKesme.jpg "Bilet Kesme İşlemleri")



