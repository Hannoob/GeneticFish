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
The genome is also responsible for determining the size, color and eye position of the organism.

## What all these pieces look like together
The final product is depicted in the following image.
From this image, one can see all the variables that can be tweaked in order to have some cool behaviours emerge.

(I still have to add the image but Game of thrones is coming out tonight).

## What I learned
This was probably one of the projects that I learnt the most from.
The lessons that I learnt was about neural networks and genetic algorithms (sort of), but these were minor compared to how it changed the way I look at nature, evolution and animal behaviour.

I learnt that everything that any living organism does, is to ensure that genes survive, not necessarily its own, or the genes of its offspring, but some genes.
This lesson goes hand-in-hand with another lesson, one thing that nature does really well, and I took for granted, was the fact that there is always an "energy balance".
This means that although we continuously spawn food in the fishbowl, roughly simulating the energy input of our sun, organisms or anything in the system cannot "conjure" energy by themselves.
I had this same goal when I created the fishbowl, however, in order to try to get the organisms to evolve some interesting behaviours, I added a feature that would cause dead organisms to turn into food.
The amount of food that gets spawned was some small amount, but not necessarily equal to the amount of energy a parent expended giving birth to that offspring.
"What could possibly go wrong?" you may ask.
Well it was not long into the simulation that I saw one group, or "species", exploit this bug in my world by spawning dead offspring and consuming the corpses for energy.
This was absolutely shocking but it really does reaffirm the point that there is no morality in nature, it is all about the survival of the genes.

This was an example where an organism evolved to protect its own genes over the genes of the children, however I have seen examples where organisms preserve the genes of their offspring by learning to follow one-another very closely, and spawning only one child that follows behind it.
This has the effect that when the older creature at the front dies, the successor consumes its corpse, and energy is largely preserved in that species, making it more robust to periods where food is scarce.
Even though this sounds more pleasant, it is still cannibalism.

This brings me to the third lesson that I leant from this experiment.
If the mutation rate is too high, this whole species thing falls apart.
Initially, I wanted the mutation rate to be quite high in order to speed up the process, however this means that species never really form, just a bunch of random individuals with no proven strategy to survive.
In the example above, when the followers mutate too drastically, the whole mechanism of the species survival disappears.
Because the mutation rate is determined by me, I had to tweak the parameters to get the population stable, but it would be quite conceivable that in the real world, proto-organisms, or strands of rna, would have different propensities to mutate, and evolution simply destroyed the species that mutated too fast.
One could actually encode the mutation rate in the genome and mutate it as offspring is produced.

The rest of the thoughts that took over my mind in the weeks after this project took me as far as questioning the existence of "free will", but that is a bit too philosophical for this article.

## What I would like to do next
The first thing that I would really like to do, is to rewrite this entire project with the focus on maintainable and more perfomant code.
Secondly, I wanted to give the eyes the ability to look at the world in terms of rays, rather than just a singe pixel at some random distance from the organism.
But to write this from scratch and make make it performant would be too much of an effort when great tools already exist that can do this, such a Unity or some other game engine.

I would like to add a neural network that is able to change its shape using the genome, instead of just manipulating the values of a neural network with a fixed structure.
This can be achieved using an architecture known as [NEAT](https://en.wikipedia.org/wiki/Neuroevolution_of_augmenting_topologieshttps://en.wikipedia.org/wiki/Neuroevolution_of_augmenting_topologieshttps://en.wikipedia.org/wiki/Neuroevolution_of_augmenting_topologies).
I have been thinking about this problem for a long time without doing the research, and I have not cracked it yet, so I am looking forward to that feeling of utter "not smartness" when I see how people have solved it.
This neural net algorithm is over and above the other huge changes I should be making such as normalizing my input values, and using a known neural network library rather than writing my own.
I would also like to encode the mutation rate and strategies in the genome and see if the system can balance itself out to produce cohesive species.
I should also probably do an actual study of evolutionary biology works to see if there are other, more interesting mechanisms I could simulate that might give more interesting results, such as evolving carnivores and herbivores and plants, complex communication strategies, camouflage, or something all together new and unheard of.