# Design-Pattern-Examples

This is a Console App that I made to better understand design patterns and had a bit of fun with it. In this case you can find examples of Facade and Factory patterns. 

The reason why I chose these is two is because I have another project in the works and wanted to have a better understanding of design patterns so I can benefit from them regarding my other project.

If you decide to see what I made, here is what you need to do:

Download the repo.

Open the project.

Next,choose which patterns example you want to examine (just uncomment one of them)
![choosepattern](https://user-images.githubusercontent.com/54059134/97285445-e4311300-184a-11eb-9641-25ee5ca85cf0.JPG)

When you uncomment the choice, just press "Run"
![Run design](https://user-images.githubusercontent.com/54059134/97285275-adf39380-184a-11eb-8ad0-328ed55bb5ce.JPG)

And you should see the result in a console.
![console](https://user-images.githubusercontent.com/54059134/97285732-3e31d880-184b-11eb-8220-d009caa6bcb8.JPG)

To understand the patterns you will have to look around the other files in the project.
![files](https://user-images.githubusercontent.com/54059134/97286308-02e3d980-184c-11eb-90a4-fc7e03c005c2.JPG)

Basically the Facade pattern allows to combine complex operations in one location so that they can be executed with ease.

The factory basically saves the trouble of having to hardcode a new instance everytime you need a different object. So the objects in question are inheriting an interface they all share and there should be a method that determines which object should be instantiated based on the client's choice. 

By the way, this project has a little surprise hidden in the factory.
