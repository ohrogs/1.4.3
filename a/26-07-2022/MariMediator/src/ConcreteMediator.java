import java.util.ArrayList;

public class ConcreteMediator implements Mediator{
    protected ArrayList<Colleague> list;

    public ConcreteMediator()
    {
        list = new ArrayList<>();
    }
    @Override
    public void update(Colleague colleague, String msg) {
        for(Colleague x : list)
        {
            if(x instanceof ColleagueOne)
            {
                ((ColleagueOne) x).reactOne(msg);
            }
            if(x instanceof ColleagueTwo)
            {
                ((ColleagueTwo) x).reactTwo(msg);
            }
            if(x instanceof ColleagueThree)
            {
                ((ColleagueThree) x).reactThree(msg);
            }
        }
    }

    @Override
    public void addColleague(Colleague colleague) {
        list.add(colleague);
    }
}
