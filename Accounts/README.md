# 银行程序说明

1. 本实验我完成了管理员和普通用户的双重登录

   老师可以先通过点击**菜单**处的银行注册普通用户，返回主界面登录，在ATM和银行中进行存钱取钱等操作。

   需求分析时考虑到用户的信用额度不应该由用户来决定，故设计管理员界面

   ```
   管理员账号采用账号为：root，密码为：123456。老师可以在登录管理员界面之后在银行进行登录。查看当前系统内所有账号，并且设置用户的信用额度或者余额。（默认已经有credit的用户不可取消全部credit）
   ```

   通过管理员和用户界面，基本实现了项目的高完成度。其中普通账号只是存放在Static 全局变量中，退出程序后会消失，并没有用到mysql sqlite等数据库，留给下次IO Database等实验时锻炼。

2. 实验代码位置说明：

![image-20200921094040607](C:\Users\81981\AppData\Roaming\Typora\typora-user-images\image-20200921094040607.png)

Accounts为项目名称 也即命名空间。Account中存放了账号类，其中放置了Account的BigMoneyFetched的委托和事件的声明。

![image-20200921094935320](C:\Users\81981\AppData\Roaming\Typora\typora-user-images\image-20200921094935320.png)

CreditAccount同理，为继承自Accounts的类，其他含义类似，进行了部分的修改,比如说override

![image-20200921094956721](C:\Users\81981\AppData\Roaming\Typora\typora-user-images\image-20200921094956721.png)

BaseForm为窗体入口程序，其中使用了枚举定义了三种 Unlogined，Logined，Root状态

![image-20200921095016051](C:\Users\81981\AppData\Roaming\Typora\typora-user-images\image-20200921095016051.png)

ATM.cs中存放了 BigMoneyFetched的事件注册函数，存放了BadCashException自定义异常类，

![image-20200921095043956](C:\Users\81981\AppData\Roaming\Typora\typora-user-images\image-20200921095043956.png)

![image-20200921095103844](C:\Users\81981\AppData\Roaming\Typora\typora-user-images\image-20200921095103844.png)

github:LcKnight

Email:819818746@qq.com/2018302120094@whu.edu.cn