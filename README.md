# Design Pattern

#### 介绍
简单实现各种设计模式 C# 

#### 实例
1. 工厂模式（Factory Pattern）:
    创建型模式，提供了一种创建对象的最佳方式。
    在工厂模式中，我们在创建对象时不会对客户端暴露创建逻辑，并且通过使用一个共同的接口来指向新创建的对象。
    
2. 抽象工厂模式（Abstract Factory Pattern）:
    创建型模式，围绕一个超级工厂创建其他工厂，该超级工厂又称为其他工厂的工厂。也是创建对象的一种最佳方式。
    在抽象工厂模式中，接口是负责创建一个相关对象的工厂，不需要显示指定他们的类，每生成的工厂都能按照工厂模式提供对象
    
3. 单例模式（Singleton Pattern）:
    创建型模式，提供了一种创建对象的最佳方式。
    涉及到一个单一的类，该类负责创建自己的对象，同时确保只有单个对象被创建。
    这个类提供了一种访问其唯一的对象的凡是，可以直接访问。
    推荐使用完全懒汉型。
4. 建造者模式（Builder Pattern）:
    创建型模式，使用多个简单的对象一步一步构建一个复杂的对象。提供一种创建对象的最佳方式
5. 原型模式（Prototype Pattern）:
    创建型模式。创建重复对象，同时保证性能。
    这个模式实现了一个原型接口，用于创建当前对象的克隆。当直接创建对象的代价比较大的时候，可以采用这种模式。
    例如，在每次new这个对象前，都要操作一个高代价的数据库，我们可以选择克隆对象。
6. 适配器模式（Adapter Pattern）：
    结构型模式。两个不兼容的接口之间的桥梁，该模式结合了两个独立接口的功能。
7. 桥接模式（Bridge Pattern）：
    结构模式， 把抽象化与实现化解耦，二者独立变化。该模式实际一个桥接的接口，使得实体类的功能独立于接口实现类。
8. 过滤器模式（Filter Pattern）：
    结构型模式。
    通过逻辑运算以解耦的方式把它们连起来。
9. 组合模式（Composite Pattern）:
    结构型模式。创建了对象组的树形结构。
    把一组相似的对象当作一个单一的对象，依据树形图结构组合对象，用来表示部分和整体层次。
10. 装饰器模式（Decorator Pattern）:
    结构型模式，作为现有类的一个包装。安全实现扩展业务子类。
    装饰器模式4种角色：
    抽象业务角色：具体业务的抽象、 具体业务角色：抽象类的实体类、 装饰器：具体装饰器的基类、 具体装饰器角色：提供具体的功能装饰具体业务实体
11. 外观模式（Facade Pattern）：
    结构型模式。向现有的系统添加一个接口，来隐藏系统的复杂性。
    从用户层接收用户输入， 如果请求需要对数据进行只读访问，则可能使用“数据访问”层，
    将请求传递到“业务规则”层， 将响应从“业务规则”层返回到“用户”层，在对“业务规则”层的调用之间维护临时状态
12. 享元模式（Flyweight Pattern）:
    结构型模式。主要用于减少创建对象的数量，以减少内存占用和提高性能。
    一个系统中有大量的对象，这些对象耗费大量的内存，这些对象中的状态大部分都可以被外部化，系统不依赖这些对象的身份
13. 代理模式（Proxy Pattern）：
    结构型模式，一个类代表另一个类的功能。
    主线调用的不是阵势的业务对象，而是它的一个代理，真实的业务被隔离。
14. 责任链模式（Chain of Responsibility Pattern）:
    行为型模式。给予请求的类型，对请求的发送者和接收者进行解耦。
    主要涉及两个角色： 抽象处理者角色：定义一个处理请求的接口，这个接口通常由接口或者抽象来实现。    
    具体处理者角色： 具体处理者接收请求后，可以选择将该请求处理掉，或者将请求传给下一个处理者。
15. 命令模式（Command Pattern）：
    行为型模式。请求以命令形式包裹在对象中，并传递给调用对象，调用对象寻找可以处理该命令的适合对象，并把该命令传给响应的对象，该对象执行命令。
    在某些场合，比如要进行”记录、撤离/重做、事务“ 等处理，这种无法抵御变化的耦合是不合适的。
    在这种情况下，将”行为请求者“ 与 ”行为实现者“解耦，将一组行为抽象为对象，可以实现二者之间的松耦合。顺序：调用者 → 命令 → 接受者
16. 解释器模式（Interpreter Pattern):
    行为型模式。这模式实现类一个表达式接口
17. 迭代器模式（Iterator Pattern）:
    行为型模式。提供一种方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示
18. 中介者模式（Mediator Pattern）：
    行为型模式。用来降低多个对象和类之间的通信复杂性。
    通常处理不同类之间的通信，减少了耦合，可以独立改变和复用类。
19. 备忘录模式（Memento Pattern）：
    行为型模式。 保存一个对象的某个状态，以便在适当的时候回复对象
    定义3个角色： 发起者(object保存其状态的对象)，备忘录(memento用来保存状态的对象)， 监护者(caretaker管理状态的保存)
20. 观察者模式（Observer Pattern）:
    行为型模式。 当一个对象被修改，则会通知依赖他的对象。订阅监听事件，并执行
21. 状态模式（State Pattern）：
    行为型模式。创建表示各种状态的对象和一个行为随着状态对象改变而改变的Context对象
    状态模式的适用场景：
    · 一个对象的行为取决于它的状态，并且它必须在运行时刻根据状态改变它的行为。
    · 一个操作中含有庞大的多分支结构，并且这些分支决定于对象的状态。
22. 空对象模式（Null Object Pattern）:
    一个空对象取代NULL对象实例的检查，null对象不是检查空值，而是反应一个不做任何动作的关系，这样null对象可以在数据不可用的时候提供默认的行为。
    空对象模式中，我们创建一个指定各种要执行的操作的抽象类和扩展该类的实体、一个未对该类做任何实现的空对象。
23. 策略模式（Strategy Pattern）:
    行为型模式。封装每一个算法，并使它们可以替换。
    设计三个角色： 环境角色（Context）、抽象策略（strategy）、具体策略（ConcreteStrategy）；
24. 模板模式（Template Pattern）:
    行为型模式。一个抽象类公开定义了他的方法，方法中定义了个操作中的算法骨架，将一些步骤延迟到子类中实现
25. 访问者模式（Visitor Pattern）:
    行为型模式。主要将数据结构与数据操作分离。
    当需要对一个对象结构中的对象进行很多不同并且不相干操作，而需要避免让这些污染对象类，使用访问者将这些疯涨到类中。
26. MVC模式（Model-View-Controller）：
    MVC 模式代表 Model-View-Controller（模型-视图-控制器） 模式。这种模式用于应用程序的分层开发。
    · Model（模型） - 模型代表一个存取数据的对象或 JAVA POJO。它也可以带有逻辑，在数据变化时更新控制器。
    · View（视图） - 视图代表模型包含的数据的可视化。
    · Controller（控制器） - 控制器作用于模型和视图上。它控制数据流向模型对象，并在数据变化时更新视图。它使视图与模型分离开。
27. 业务代表模式（Business Delegate Pattern）:
    用于表示层和业务层解耦。它基本上用来减少通信对表示层代码中的业务层代码的远程查询功能。
    · 客户端（Client） - 表示层代码可以是 JSP、servlet 或 UI java 代码。
    · 业务代表（Business Delegate） - 一个为客户端实体提供的入口类，它提供了对业务服务方法的访问。
    · 查询服务（LookUp Service） - 查找服务对象负责获取相关的业务实现，并提供业务对象对业务代表对象的访问。
    · 业务服务（Business Service） - 业务服务接口。实现了该业务服务的实体类，提供了实际的业务实现逻辑。
28. 组合实体模式（Composite Entity Pattern）：
    · 组合实体（Composite Entity） - 它是主要的实体 bean。它可以是粗粒的，或者可以包含一个粗粒度对象，用于持续生命周期。
    · 粗粒度对象（Coarse-Grained Object） - 该对象包含依赖对象。它有自己的生命周期，也能管理依赖对象的生命周期。
    · 依赖对象（Dependent Object） - 依赖对象是一个持续生命周期依赖于粗粒度对象的对象。
    · 策略（Strategies） - 策略表示如何实现组合实体