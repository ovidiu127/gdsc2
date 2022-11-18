namespace hw2;

public class User{
    private string password;
    public string username,email;

    public User(string _username,string _password,string _email){
        this.username=_username;
        this.password=_password;
        this.email=_email;
    }

    public string GetMail(){
        return this.email;
    }

    public void ChangePassword(string _password){
        this.password=_password;
    }

    public override string ToString(){
        return this.username+" "+this.email;
    }
}