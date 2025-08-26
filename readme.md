<p align="center"> <img src="https://img.shields.io/badge/.NET-Framework%204.8-blue?style=for-the-badge&logo=dotnet" /> <img src="https://img.shields.io/badge/C%23-Windows%20Forms-purple?style=for-the-badge&logo=csharp" /> <img src="https://img.shields.io/badge/Platform-Windows-lightgrey?style=for-the-badge&logo=windows" /> </p>
📋 Açıklama

FreezeApp, Windows üzerinde çalışan belirli bir işlemi (örnek: RobloxPlayerBeta.exe) E tuşuna basıldığında dondurur, R tuşuna basıldığında ise kaldığı yerden devam ettirir.

Program, Windows API fonksiyonlarını (OpenThread, SuspendThread, ResumeThread) kullanarak işlemdeki tüm thread'lerin kontrolünü sağlar.

✨ Özellikler
<p align="left"> <strong>🔧 İşlevler</strong><br> ✅ Belirli bir işlemi bulur ve üzerinde kontrol sağlar<br> ✅ E tuşu → İşlemi dondurma<br> ✅ R tuşu → İşlemi devam ettirme<br> ✅ Konsolda işlem durumunu gösterme<br> </p> <p align="left"> <strong>🖥️ Teknik Detaylar</strong><br> ✅ Windows API kullanımı (user32.dll & kernel32.dll)<br> ✅ HotKey kaydı (global kısayol atama)<br> ✅ Tüm thread’ler üzerinde çalışır<br> ✅ Windows Forms altyapısı ile hazırlanmıştır<br> </p>

### 🛠️ Kurulum

**Gereksinimler**  
- [.NET Framework 4.8 veya üzeri](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)  

**Kurulum Adımları**  
1. Projeyi bilgisayarınıza indirin.
2. Proje klasöründe CMD açın ve `dotnet run` yazın **veya** projeyi derleyip kullanın.
3. `Program.cs` dosyasını açın ve `processName` değişkenini, kontrol etmek istediğiniz uygulamanın exe adı ile değiştirin (varsayılan: `RobloxPlayerBeta`).
4. Uygulamanın hotkey’lerini kullanarak işlemleri gerçekleştirin.
