using System.Collections.Generic;

namespace AionLegendaryLauncher.Source
{
    public class Texts
    {
        private static Dictionary<string, string> TextTr = new Dictionary<string, string>
        {
            {"UNKNOWNERROR",                    "Bilinmeyen, ancak kritik bir hata oldu .. Sorunun çözülmesine yardımcı olabilecek hata mesajı: \n{0}"},
            {"MISSINGBINARY",                   "{0} dosyası bulunamadığı için oyun başlatılamadı!"},
            {"CANNOTSTART",                     "Patcher oyunu başlatamıyor. Antivirüs programınızı devre dışı bırakıp deneyebilirsiniz."},
            {"NONETWORK",                       "Güncelleme sunucusuna bağlanılamadı. İnternet bağlantınızı kontrol edin veya oyun yönetimine başvurun!"},
            {"CONNECTING",                      "Güncelleme sunucusuna bağlanılıyor..."},
            {"LISTDOWNLOAD",                    "Oyun indiriliyor..."},
            {"CHECKFILE",                       "{0} kontrol ediliyor..."},
            {"DOWNLOADFILE",                    "{0} indiriliyor... {1} / {2}"},
            {"COMPLETEPROGRESS",                "Toplam süreç: {0}%"},
            {"CURRENTPROGRESS",                 "İndirilen Dosya: {0}%"},
            {"CHECKCOMPLETE",                   "Dosyalar kontrol edildi."},
            {"DOWNLOADCOMPLETE",                "Oyun indirildi. Oyun başlatılıyor..."},
            {"DOWNLOADSPEED",                   "İndirme Hızı: {0} Mb/s"},
            {"BTN_CANCEL",                      "İptal"},
            {"BTN_CLOSE",                       "Kapat"},
            {"BTN_MINIMIZE",                    "Küçült"},
            {"BTN_PLAY",                        "Oyna"},
            {"BTN_SAVE",                        "Kaydet"},
            {"BTN_PATH",                        "Gözat"},
            {"BTN_FILE_CHECK",                  "Dosya kontrolü"},
            {"BTN_SETTINGS",                    "Ayarlar"},
            {"SETTINGS",                        "Ayarlar"},
            {"GAME_LANG",                       "Oyun Dili :"},
            {"UI_LANG",                         "KA Dili :"},
            {"GAME_TYPE",                       "Oyun Tipi :"},
            {"FILE_PATH",                       "Dosya Yolu :"},
            {"UPDATE_CANCELING",                "Güncelleme iptal ediliyor."},
            {"FULL_FILE_CHECK",                 "Tam Dosya Konrolü"},
            {"LAUNCHER_NEW_VERSION",            "Launcher'ın yeni versionu mevcut.\nYeni Launcher'ı sitemizden indirip öyle deneyin!\nhttps://www.aionlegendary.com/Home/Download"},
            {"LAUNCHER_VERSION_CHECK",          "Launcher versionu kontrol ediliyor..."},
        };
        private static Dictionary<string, string> TextEn = new Dictionary<string, string>
        {
            {"UNKNOWNERROR",                    "An unknown, but a critical error happened.. Error message which can help to solve the problem: \n{0}"},
            {"MISSINGBINARY",                   "The game could not be opened because the {0} file could not be found.!"},
            {"CANNOTSTART",                     "Patcher cannot starting the game. You can disable your malware program and try it."},
            {"NONETWORK",                       "Cannot connect to updater server. Check your internet connection or contact game management!"},
            {"CONNECTING",                      "Conneting updater server..."},
            {"LISTDOWNLOAD",                    "Game Downloading..."},
            {"CHECKFILE",                       "{0} file checking..."},
            {"DOWNLOADFILE",                    "{0} Downloading... {1} / {2}"},
            {"COMPLETEPROGRESS",                "Total Progress: {0}%"},
            {"CURRENTPROGRESS",                 "Download file: {0}%"},
            {"CHECKCOMPLETE",                   "Files checked."},
            {"DOWNLOADCOMPLETE",                "Game Downloaded. The game is starting..."},
            {"DOWNLOADSPEED",                   "Download Speed: {0} Mb/s"},
            {"BTN_CANCEL",                      "Cancel"},
            {"BTN_CLOSE",                       "Close"},
            {"BTN_MINIMIZE",                    "Minimize"},
            {"BTN_PLAY",                        "Play"},
            {"BTN_SAVE",                        "Save"},
            {"BTN_PATH",                        "Browse"},
            {"BTN_FILE_CHECK",                  "File Check"},
            {"BTN_SETTINGS",                    "Settings"},
            {"SETTINGS",                        "Settings"},
            {"GAME_LANG",                       "Game Language :"},
            {"UI_LANG",                         "UI Language :"},
            {"GAME_TYPE",                       "Game Type :"},
            {"FILE_PATH",                       "File Path :"},
            {"UPDATE_CANCELING",                "The update is being canceled."},
            {"FULL_FILE_CHECK",                 "Full File Check"},
            {"LAUNCHER_NEW_VERSION",            "New version of Launcher is available.\nDownload the New Launcher from our site and try it!\nhttps://www.aionlegendary.com/Home/Download"},
            {"LAUNCHER_VERSION_CHECK",          "Launcher version checking..."},
        };
        public static string GetText(string Key, params object[] Arguments)
        {
            if (Properties.Settings.Default._UILang == "tr")
            {
                foreach (var currentItem in TextTr)
                {
                    if (currentItem.Key == Key)
                    {
                        return string.Format(currentItem.Value, Arguments);
                    }
                }
            }
            else
            {
                foreach (var currentItem in TextEn)
                {
                    if (currentItem.Key == Key)
                    {
                        return string.Format(currentItem.Value, Arguments);
                    }
                }
            }


            return null;
        }
    }
}
