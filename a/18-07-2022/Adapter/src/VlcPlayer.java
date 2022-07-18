import javax.swing.table.TableRowSorter;

public class VlcPlayer implements AdvancedMediaPlayer{
    @Override
    public void playMp4(String fileName) {
        //inutilizzata
    }

    @Override
    public void playVlc(String fileName) {
        ProcessBuilder pb = new ProcessBuilder("C:\\Programmi\\VideoLAN\\VLC\\vlc.exe", fileName);
        try
        {
            pb.start();
        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
    }
}
