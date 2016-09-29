# Fractal Generator
Unity 3D project for generating fractals and exploring components and messaging.

# How It Was Made
This Fractal Generator was made as a part of my World of Zero project. The code is open source, and how it was written was recorded. Below is a link to the videos demonstrating how it was made.
[![Fractals All The Way Down! - YouTube Video](https://img.youtube.com/vi/VXegg-HGT0s/0.jpg)](https://www.youtube.com/watch?v=VXegg-HGT0s)

Part two of the series includes the addition of physics to our Fractal. Everything is better with physically simulated movement!

[![Physically Simulating the Generated Fractals - YouTube Video](https://img.youtube.com/vi/EMQOhrN453g/0.jpg)](https://www.youtube.com/watch?v=EMQOhrN453g)

# Extending the Project
This project is extremely simple to extend. Create a new component in Unity in Unity and add a function to accept the message. The function just needs to be named and have arguments similar to this `Generated(int index)`

Once you have that done simply use your script to modify your element. Once that is done, attach the component to the root element and hit play. It's that easy. If you need more help watch the video above to see how it is done.

Once you have your component finished create a pull request and let's get it added back in to the project so others can see it!
