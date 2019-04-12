# GeneticFish
This was my first attempt at simulating simple single cell organisms that use a basic neural network to evolve strategies to survive in a dangerous and unpredictable universe known as the fish-bowl.

## How this started
This project started as a conversation between myself and a colleague who was doing his honours degree at the time, where he mentioned that has been studying neural networks and genetic algorithms.
This was also at a time where there were many youtube videos of artificial life simulations.
I have not played with any of these ideas before so I decided that I was going to attempt to build my own from scratch.
It turned into one of those projects that I spent and entire weekend on, with barely any breaks or sleep, and it has been one of the projects that I had the most fun on.

The technology that I decided to use, was a c# project, using a form to paint the graphics on.
The idea was to quickly get something that simulates the behaviour that I was hoping to see, and very little attention was dedicated to writing nice code, or even performant code.
It is also worth mentioning that I did not do any research what so ever.
This becomes very apparent in my very naive implementation of a neural network, that works as expected, however no implementation of neural nets in the wild would resemble what I have done here.

## The rules of the fishbowl
### The fishbowl
For some reason that made sense at the time, i called the world where this experiment takes place, the "fishbowl".
In retrospect I should have picked a way cooler name!
The fishbowl is a world with no edges or corners meaning that if an inhabitant of the fishbowl goes off the side of the screen, it will appear on the opposite side.

### Food
Food is a very important part of the fishbowl ecosystem.
It is the mechanism whereby organisms in the bowl sustain themselves, and get enough energy to reproduce.
Food takes the form of pellets of varying sizes in the fishbowl.
The size correlates to how much energy is contained within that piece of food.
Food gets generated in one of two ways, the first way, is that food gets placed in a spot where an organism dies.
The size of the organism would dictate how much energy is stored in its corpse after it dies.
The second way that food gets produced, is that food spawns randomly and at random places in the fishbowl.
Finally the fishbowl has "currents" meaning that all the food in the fishbowl will drift in a certain direction. 

### Fish
The fishbowl is inhabited by organisms that look like single celled organisms, however, because of my terrible naming choices they are called "fish".
These fish have the ability to move forwards and backwards, and they are able to rotate any number of degrees in any direction.
They are also able to reproduce asexually.
When they produce a new fish, the new fish has the same genome as the parent fish with a chance that mutations can occur.
The parent can also choose how much of its own health it transfers to its offspring.
This mechanism is extremely important and will be discussed later.
Fish also have a couple of sensors that it uses when it makes decisions.
The first is how much energy it has, the second is an array of eyes that "see" a certain pixel around its body, and finally the age of the organism in number of rounds.

### Brain
Each organism has a brain.
These brains are very simple feed forward neural networks with a fixed structure.
The age, energy level, and eye data are used as inputs to this simple neural net, and the outputs are the rotation, movement speed, and whether the organism would like to reproduce, and how much of its energy it would like to transfer to its offspring.

### Genome
The genome determines the weights of the neural network, which ultimately determines the behaviour of the organism.
The genome is also responsible for determining the size, color..............
## What I learned

## What I would like to do next