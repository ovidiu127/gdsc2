namespace hw2;

public class Admin{
    public string name;
    public Application[]applications;

    public Admin(string _name){
        this.name=_name;
    }

    protected Application[] append(Application[]v,Application u){
        if(v==null){
            return new Application[]{u};
        }
        Application[] ans=new Application[v.Length+1];
        for(int i=0;i<v.Length;++i){
            ans[i]=v[i];
        }
        ans[v.Length]=u;
        return ans;
    }

    public void addApp(Application na){
        applications=append(applications,na);
    }

    public void AddUser(User user,Application app){
        bool ok=true;
        foreach (User u in users){
            if(user==u){
                ok=false;
                break;
            }
        }
        if(ok){
            app.addUser(user);
        }
        else{
            Console.WriteLine("User already registered!");
        }
    }

    public void RemoveUser(User user,Application app){
        if(app.users==app.users.Where(e=>e!=user).ToArray){
            Console.WriteLine("No such user found!")
        }
        else{
            app.removeUser(user.username);
        }
    }
}