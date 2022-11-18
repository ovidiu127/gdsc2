namespace hw2;

public class WebApplication: Application{

    public WebApplication(string name){
        this.name=name;
    }

    void HttpRequest(User user){
        bool ok=false;
        foreach (User u in users){
            if(user==u){
                ok=true;
                break;
            }
        }
        if(ok){
            Console.WriteLine("Ok Request");
        }
        else{
            Console.WriteLine("Bad Request");
        }
    }
}