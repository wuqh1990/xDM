# xDM

> c# 使用大漠插件. 完成 类似 按键精灵的 功能.

# 准备
1. 运行需要 .NET Framework 4.7.2  或者 手动把 类库框架版本改为 自己有的版本

# 效果图
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190515155237435.jpg?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM3MjE0NTY3,size_16,color_FFFFFF,t_70)
# 如何运行
## 1. 注册 大漠dll  到com (资源在 源码的 DLL 文件夹中)
![在这里插入图片描述](https://img-blog.csdnimg.cn/2019051515531998.jpg?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM3MjE0NTY3,size_16,color_FFFFFF,t_70)
### 或者用代码执行命令, (一定要将所有的初始化操作放在这个代码后面)
```csharp

static void Main(string[] args)
{
    // 判断是否注册了大漠, 没有则执行命令注册 
    // (项目里新建一个"dll"文件夹,把dm.dll放进去,属性中选择"始终复制"))
    if (Type.GetTypeFromProgID("dm.dmsoft") == null)
    {
        // 执行cmd命令, 并打印输出 
        //  (搜索引擎随便找一个,
        // 一定要获取输出,否则还没等到注册成功,代码就继续执行了,就会初始化失败)
       ExcuteCommandOnBackgroudCaptureOutputStream("regsvr32 ./dll/dm.dll");
    }

    // 你的初始化dm代码

}

```

## 2. 成功 提示
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190515160034183.jpg?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM3MjE0NTY3,size_16,color_FFFFFF,t_70)

## 3. 验证是否注册成功 (列表中存在即可,不需要引用到项目中)
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190515155439884.jpg?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM3MjE0NTY3,size_16,color_FFFFFF,t_70)

## 4.在 Visual Studio 中运行项目 查看结果

> 使用免费版  或者  填写 注册码  后  再运行

## 支持作者

如果这个开源项目 可以帮助到你,  你也可以请作者喝一杯咖啡。

![pay](img.assets/pay.png)

