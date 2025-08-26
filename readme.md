⏸️ FreezeApp
<p align="center"> ⚠️ <strong>Önemli Uyarı:</strong> Bu yazılım, belirtilen bir işlemi (örnek: <code>RobloxPlayerBeta</code>) <strong>dondurma</strong> ve <strong>devam ettirme</strong> işlevi içerir. Yanlış kullanımda oyun veya uygulama çökebilir. Kullanım tamamen sizin sorumluluğunuzdadır. </p>
<p align="center"> <img src="https://img.shields.io/badge/.NET-Framework%204.8-blue?style=for-the-badge&logo=dotnet" /> <img src="https://img.shields.io/badge/C%23-Windows%20Forms-purple?style=for-the-badge&logo=csharp" /> <img src="https://img.shields.io/badge/Platform-Windows-lightgrey?style=for-the-badge&logo=windows" /> </p>
📋 Açıklama

FreezeApp, Windows üzerinde çalışan belirli bir işlemi (örnek: RobloxPlayerBeta.exe) E tuşuna basıldığında dondurur, R tuşuna basıldığında ise kaldığı yerden devam ettirir.

Program, Windows API fonksiyonlarını (OpenThread, SuspendThread, ResumeThread) kullanarak işlemdeki tüm thread'lerin kontrolünü sağlar.

✨ Özellikler
<p align="left"> <strong>🔧 İşlevler</strong><br> ✅ Belirli bir işlemi bulur ve üzerinde kontrol sağlar<br> ✅ E tuşu → İşlemi dondurma<br> ✅ R tuşu → İşlemi devam ettirme<br> ✅ Konsolda işlem durumunu gösterme<br> </p> <p align="left"> <strong>🖥️ Teknik Detaylar</strong><br> ✅ Windows API kullanımı (user32.dll & kernel32.dll)<br> ✅ HotKey kaydı (global kısayol atama)<br> ✅ Tüm thread’ler üzerinde çalışır<br> ✅ Windows Forms altyapısı ile hazırlanmıştır<br> </p>
🛠️ Kurulum

Gereksinimler

Windows işletim sistemi

.NET Framework (4.8 veya üzeri)

Visual Studio veya dotnet run ile çalışma

Kurulum Adımları

Projeyi bilgisayarınıza indirin

Program.cs dosyasını Visual Studio veya başka bir C# IDE’si ile açın

processName değişkenini istediğiniz uygulamanın exe adı ile değiştirin (varsayılan: RobloxPlayerBeta)

Uygulamayı derleyin

Çalıştırın

🎯 Kullanım

Başlatma

Programı açın

Hedef işlem çalışıyorsa otomatik algılanır

Kontroller

E tuşu: Hedef işlemi dondurur

R tuşu: Hedef işlemi devam ettirir

Konsolda işlem durumu görünür

📊 Çalışma Mantığı

Program açıldığında, belirtilen işlem (RobloxPlayerBeta) çalışıyorsa yakalar

Her bir işlem thread’ini OpenThread ile açar

Dondurma (E): SuspendThread çağırır

Devam Ettirme (R): ResumeThread çağırır

İşlem tamamen duraklatılmış olur, R tuşu ile devam eder

⚠️ Uyarılar

Yanlış bir işlemi dondurursanız sistem kararsız çalışabilir

Yetkisiz oyun/modifikasyonlarda ban riski vardır

Sadece kendi uygulama/test senaryolarınızda kullanmanız tavsiye edilir

🤝 Katkıda Bulunma

Katkıda bulunmak isteyenler:

HotKey kombinasyonlarını değiştirebilir

GUI (arayüz) ekleyebilir

Belirli süreçleri otomatik seçme özelliği ekleyebilir

<p align="center">💡 Kullanım sırasında dikkatli olun!</p>