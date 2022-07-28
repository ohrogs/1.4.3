public class ColleagueOne extends Colleague{
    public void doing(String msg)
    {
        mediator.update(this, msg);
    }

    public void reactOne(String msg)
    {
        System.out.println("React one " + msg);
    }
}
