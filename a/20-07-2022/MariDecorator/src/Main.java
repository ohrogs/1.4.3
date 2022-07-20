public class Main {
    public static void main(String[] args) {
        Message messaggioutente = new VideoMessage("SEI UN MAIALE");
        System.out.println(messaggioutente.getText());
        Message messaggiotiktok = new TikTokMessage(messaggioutente);
        System.out.println(messaggiotiktok.getText());
        Message messaggioTikTokLog = new TikTokMessage(new LogMessage(messaggioutente));
        System.out.println(messaggioTikTokLog.getText());
        Message messaggioTikTokLogSms = new TikTokMessage(new LogMessage(new Sms(messaggioutente, "+393930939315")));
        System.out.println(messaggioTikTokLogSms.getText());
    }
}
