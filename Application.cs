namespace hw2;

public class Application{
    public string name;
    public User[] users;
    public int maxUsers;

    public string GetName(){
        return name;
    }

    public int GetNumberOfUsers(){
        return (users==null)?0:users.Length;
    }

    public override string ToString(){
        return name+" "+GetNumberOfUsers();
    }

    protected User[] append(User[]v,User u){
        if(v==null){
            return new User[]{u};
        }
        User[] ans=new User[v.Length+1];
        for(int i=0;i<v.Length;++i){
            ans[i]=v[i];
        }
        ans[v.Length]=u;
        return ans;
    }

    public void addUser(User n){
        users=append(users,n);
    }

    public void removeUser(string _username){
        users=users.Where(e=>e.username!=_username).ToArray();
    }
}