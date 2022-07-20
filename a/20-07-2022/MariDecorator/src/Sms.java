public class Sms extends MessageServiceDecorator{
    protected String PhoneNumber;
    public Sms(Message message, String PhoneNumber)
    {
        this.message = message;
        this.PhoneNumber = PhoneNumber;
    }

    @Override
    public String getText() {
        return message.getText() + " Mandato a " + PhoneNumber + " e ";
    }
}
