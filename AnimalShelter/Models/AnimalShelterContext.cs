using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {

    }

    public DbSet<Creature> Creatures { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Creature>()
        .HasData(
          new Creature { CreatureId=1, Name="Gunnar", Spieces="Dog", Mythical="No", Description="He's a very good boy!", Image="https://images.unsplash.com/photo-1559743404-85fb2bd372d3?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", Age=3 },
          new Creature { CreatureId=2, Name="Gus", Spieces="Dog", Mythical="No", Description="D'awe!", Image="https://images.unsplash.com/photo-1578584099737-351780c55f69?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1170&q=80", Age=1 },
          new Creature { CreatureId=3, Name="Mr. Gigglesworth", Spieces="Cat", Mythical="No", Description="Does not giggle. He's actually quite the jerk to be honest.", Image="https://images.unsplash.com/photo-1603349136288-95d87bd0a268?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=687&q=80", Age=11 },
          new Creature { CreatureId=4, Name="Dog", Spieces="Dog", Mythical="No", Description="What can we do? It's the only name he responds to.", Image="https://images.unsplash.com/photo-1552053831-71594a27632d?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=662&q=80", Age=5 },
          new Creature { CreatureId=5, Name="Tim Curry", Spieces="Minotaur", Mythical="Yes", Description="This may actually be Tim Curry. We're not entirely sure.", Image="https://i.pinimg.com/564x/0a/40/7e/0a407e1fd8c113f0d29564f116f4c64a.jpg", Age=75 },
          new Creature { CreatureId=6, Name="Hotdog", Spieces="Dragon", Mythical="Yes", Description="Self-named. Good luck.", Image="https://images.unsplash.com/photo-1614770596508-de1d826c3765?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NzB8fGRyYWdvbnxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Age=400 },
          new Creature { CreatureId=7, Name="Snaps", Spieces="Turtle", Mythical="No", Description="High energy! Walks are a must!", Image="https://images.unsplash.com/photo-1521217155737-0d5632e9813f?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=687&q=80", Age=50 },
          new Creature { CreatureId=8, Name="Jerry", Spieces="Cat", Mythical="No", Description="Eats butterflies. Like, all the time.", Image="https://images.unsplash.com/photo-1526336024174-e58f5cdd8e13?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=687&q=80", Age=5 },
          new Creature { CreatureId=9, Name="Sir Barkington", Spieces="Dog", Mythical="No", Description="Great with kids!", Image="https://images.unsplash.com/photo-1554692936-82776f9406db?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", Age=5 },
          new Creature { CreatureId=10, Name="Samantha", Spieces="Cat", Mythical="No", Description="Does not care for laser pointers.", Image="https://images.unsplash.com/photo-1561948955-570b270e7c36?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=601&q=80", Age=7 },
          new Creature { CreatureId=11, Name="Wheels", Spieces="Hamster", Mythical="No", Description="Only has three legs, but eats like he has all four!", Image="https://images.unsplash.com/photo-1452721226468-f95fb66ebf83?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8aGFtc3RlcnxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Age=1 },
          new Creature { CreatureId=12, Name="Mistletoe", Spieces="Dog", Mythical="No", Description="Born on Xmas.", Image="https://images.unsplash.com/photo-1609260057679-1b9f08ea0dc5?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=687&q=80", Age=1 },
          new Creature { CreatureId=13, Name="Flops", Spieces="Dog", Mythical="No", Description="He's a snuggler!", Image="https://images.unsplash.com/photo-1544568100-847a948585b9?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1074&q=80", Age=2 },
          new Creature { CreatureId=14, Name="Sphinx", Spieces="Cat", Mythical="Yes", Description="What makes him mythical? Wouldn't you like to know...", Image="https://images.unsplash.com/photo-1517178271410-0b2a6480952f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=957&q=80", Age=8 },
          new Creature { CreatureId=15, Name="Mortimer", Spieces="Dragon", Mythical="Yes", Description="Mostly keeps to himself. Occasionally razes.", Image="https://images.unsplash.com/photo-1577493340887-b7bfff550145?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=640&q=80", Age=297 },
          new Creature { CreatureId=16, Name="Dee", Spieces="Harpy", Mythical="Yes", Description="Twins. This one is dumber than the other one.", Image="https://ameliamellorsfantasticnarratograph.files.wordpress.com/2018/02/harpy2.jpg", Age=56 },
          new Creature { CreatureId=17, Name="Dum", Spieces="Harpy", Mythical="Yes", Description="Twins. This one is smarter than the other one.", Image="https://ameliamellorsfantasticnarratograph.files.wordpress.com/2018/02/harpy2.jpg", Age=56 },
          new Creature { CreatureId=18, Name="Gwen", Spieces="Axe Beak", Mythical="Yes", Description="Pretty territorial. Not really sure we should be selling this.", Image="https://static.wikia.nocookie.net/forgottenrealms/images/5/5b/Axe_beak-5e.jpg/revision/latest/scale-to-width-down/350?cb=20200917222507", Age=40 },
          new Creature { CreatureId=19, Name="Huggy", Spieces="Bear", Mythical="No", Description="An old circus bear looking for a good home to retire in. Comes with his own ball!", Image="https://images.unsplash.com/photo-1530595467537-0b5996c41f2d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8YmVhcnxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", Age=19 },
          new Creature { CreatureId=20, Name="Dimetrius", Spieces="Cat", Mythical="No", Description="Just another cat. Same as the other ones.", Image="https://images.unsplash.com/photo-1543852786-1cf6624b9987?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1974&q=80", Age=4 },
          new Creature { CreatureId=21, Name="Stench", Spieces="Hellhound", Mythical="Yes", Description="Name is more of a description really.", Image="https://static.turbosquid.com/Preview/2014/12/10__15_52_12/Hellhound_1.jpg2737221e-11c1-450b-bc32-0e86ae7d144fZoom.jpg", Age=9 },
          new Creature { CreatureId=22, Name="Sprinkle", Spieces="Dog", Mythical="No", Description="Well she's just the most adorable thing you ever saw!", Image="https://images.unsplash.com/photo-1611003228941-98852ba62227?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1074&q=80", Age=3 },
          new Creature { CreatureId=23, Name="Mildred", Spieces="Dog", Mythical="No", Description="The absolute froofiest!", Image="https://images.unsplash.com/photo-1591946614720-90a587da4a36?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", Age=2 },
          new Creature { CreatureId=24, Name="Friskers", Spieces="Cat", Mythical="No", Description="Look, we just don't like cats ok? Please take him.", Image="https://images.unsplash.com/photo-1573865526739-10659fec78a5?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=715&q=80", Age=1 },
          new Creature { CreatureId=25, Name="Floater", Spieces="Goldfish", Mythical="No", Description="Don't get too attached.", Image="https://images.unsplash.com/photo-1579161256825-57ba3094f057?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1170&q=80", Age=1 }
        );
    }
  }
}