namespace hw2;

public class MobileApplication: Application{
    double rating;

    public MobileApplication(string name){
        this.name=name;
    }

    double RateApp(){
        double count=0,sum=0;
        foreach (User u in users){
            sum += Convert.ToDouble(Console.ReadLine());
            ++count;
        }
        rating = sum / count;
        return rating;
    }
}