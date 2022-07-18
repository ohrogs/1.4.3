public class MediaAdapter implements MediaPlayer{
    private AdvancedMediaPlayer advancedMediaPlayer;

    public MediaAdapter(String AudioType)
    {
        //advancedMediaPlayer = new VlcPlayer();
        if (AudioType.equals("vlc"))
        {
            advancedMediaPlayer = new VlcPlayer();
        }
        else
        {
            advancedMediaPlayer = new Mp4Player();
        }

    }
    @Override
    public void play(String AudioType, String fileName)
    {
        if (AudioType.equals("vlc"))
        {
            advancedMediaPlayer.playVlc(fileName);
        }
        else
        {
            advancedMediaPlayer.playMp4(fileName);
        }
    }
}
