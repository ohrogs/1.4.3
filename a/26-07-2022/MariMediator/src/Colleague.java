public class Colleague {
    protected Mediator mediator;

    void setMediator(Mediator mediator)
    {
        this.mediator = mediator;
        mediator.addColleague(this);
    }
}
