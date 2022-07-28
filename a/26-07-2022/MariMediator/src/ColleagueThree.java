public class ColleagueThree extends Colleague{
    public void doing(String msg)
    {
        mediator.update(this, msg);
    }

    public void reactThree(String msg)
    {
        System.out.println("React three " + msg);
    }
}
