public class LogMessage extends MessageServiceDecorator{
    public LogMessage(Message message)
    {
        this.message = message;
    }

    @Override
    public String getText() {
        return message.getText() + " Loggato e ";
    }
}
