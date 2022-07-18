import java.net.URI;

public class Mp4Player implements AdvancedMediaPlayer{
    @Override
    public void playVlc(String fileName) {
        //inutilizzata
    }

    @Override
    public void playMp4(String fileName) {
        System.out.println("hai scelto playmp4" + " suonando " + fileName);
        try {
            java.awt.Desktop.getDesktop().browse(new URI(fileName));
        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
    }
}
