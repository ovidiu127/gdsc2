using hw2;

Console.WriteLine("Enter a name for the admin:");
string adminName=Console.ReadLine();
Admin boss=new Admin(adminName);

WebApplication app1=new WebApplication("My Website");
MobileApplication app2=new MobileApplication("My App");

boss.addApp(app1);
boss.addApp(app2);

Console.WriteLine("How many users for app1 ?");
int l=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<l;++i){
    string username,password,email;
    Console.WriteLine($"Enter username {i+1}:");
    username=Console.ReadLine();
    Console.WriteLine($"Enter password {i+1}:");
    password=Console.ReadLine();
    Console.WriteLine($"Enter email {i+1}:");
    email=Console.ReadLine();
    boss.AddUser(new User(username,password,email),app1);
}

Console.WriteLine("How many users for app2 ?");
l=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<l;++i){
    string username,password,email;
    Console.WriteLine($"Enter username {i+1}:");
    username=Console.ReadLine();
    Console.WriteLine($"Enter password {i+1}:");
    password=Console.ReadLine();
    Console.WriteLine($"Enter email {i+1}:");
    email=Console.ReadLine();
    boss.AddUser(new User(username,password,email),app2);
}

Console.WriteLine(app1.users[0].ToString());