public class Main {
    public static void main(String[] args) {
        ConcreteMediator cm = new ConcreteMediator();
        ColleagueOne c1 = new ColleagueOne();
        ColleagueTwo c2 = new ColleagueTwo();
        ColleagueThree c3 = new ColleagueThree();
        c1.setMediator(cm);
        c2.setMediator(cm);
        c3.setMediator(cm);

        c1.doing("from c1");
        c2.doing("from c2");
        c3.doing("from c3");
    }
}
