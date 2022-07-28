public class ColleagueTwo extends Colleague {
    public void doing(String msg)
    {
        mediator.update(this, msg);
    }

    public void reactTwo(String msg)
    {
        System.out.println("React two " + msg);
    }
}
