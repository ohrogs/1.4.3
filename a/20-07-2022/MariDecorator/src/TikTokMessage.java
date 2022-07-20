public class TikTokMessage extends MessageServiceDecorator{ //CONCRETEDECORATOR
    public TikTokMessage(Message message)
    {
        this.message = message;
    }

    @Override
    public String getText() {
        return message.getText() + " Mandato su tiktok e ";
    }
}
