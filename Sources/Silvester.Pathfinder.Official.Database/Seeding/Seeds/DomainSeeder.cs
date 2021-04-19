using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class DomainSeeder : IEntitySeed<Domain>
    {
        public IEnumerable<Domain> GetSeedEntities()
        {
            yield return new Domain { Id = Guid.Parse("09797fbb-48b5-42fa-abf3-5468c06dbbce"), Name = "Air", Description = "You can control winds and the weather." };
            yield return new Domain { Id = Guid.Parse("78d1b6a0-7f67-4e3c-a25c-dbf4aa4cd838"), Name = "Ambition", Description = "You strive to keep up with and outpace the competition." };
            yield return new Domain { Id = Guid.Parse("768a6f8b-75cb-4439-a95a-1a41ef36abd8"), Name = "Cities", Description = "You have powers over urban environments and denizens." };
            yield return new Domain { Id = Guid.Parse("3020bd98-a4f8-4e92-9c92-58110679137f"), Name = "Confidence", Description = "You overcome your fear and project pride." };
            yield return new Domain { Id = Guid.Parse("eceea1c6-3be5-49dd-bfb4-fca321132069"), Name = "Cold", Description = "You control ice, snow, and freezing temperatures." };
            yield return new Domain { Id = Guid.Parse("0b2dd6ec-60ae-4cab-ade5-b5bccdc8a993"), Name = "Creation", Description = "You have divine abilities related to crafting and art." };
            yield return new Domain { Id = Guid.Parse("9c5f23af-1bf7-46c8-bdba-8067b03f752f"), Name = "Change", Description = "You can restructure the physical and metaphysical." };
            yield return new Domain { Id = Guid.Parse("c750af99-1697-4c06-abb1-cb91bc2f8099"), Name = "Darkness", Description = "You operate in the darkness and take away the light." };
            yield return new Domain { Id = Guid.Parse("21481675-8a0d-4e7c-a373-fad64f4c14e7"), Name = "Death", Description = "You have the power to end lives and destroy undead." };
            yield return new Domain { Id = Guid.Parse("ab698922-2a43-4eb1-a400-2b96abcbb255"), Name = "Decay", Description = "You have the power to spoil and deteriorate matter." };
            yield return new Domain { Id = Guid.Parse("d09b4a1e-21fd-4dda-9fe6-8679bd6e3eef"), Name = "Destruction", Description = "You are a conduit for divine devastation." };
            yield return new Domain { Id = Guid.Parse("e214011e-7af3-4a53-9b4a-e0ed7ae4479a"), Name = "Dreams", Description = "You have the power to enter and manipulate dreams." };
            yield return new Domain { Id = Guid.Parse("ef17f4d2-95cd-4561-86fc-487a749244e4"), Name = "Duty", Description = "You defend oaths and carry out your divine missions with great dedication." };
            yield return new Domain { Id = Guid.Parse("41f79fe2-6ac6-42ec-a69c-15046cd962f4"), Name = "Earth", Description = "You control soil and stone." };
            yield return new Domain { Id = Guid.Parse("49ba8be3-a11f-4d61-9b64-d8d1fd208ffe"), Name = "Family", Description = "You aid and protect your family and community more effectively." };
            yield return new Domain { Id = Guid.Parse("696cb38a-1f8f-4506-b3e6-06c5b5e802af"), Name = "Fate", Description = "You see and understand hidden inevitabilities." };
            yield return new Domain { Id = Guid.Parse("f1a372b7-a9bc-4571-b0ca-69780008e40a"), Name = "Fire", Description = "You control flame." };
            yield return new Domain { Id = Guid.Parse("216d5607-4d52-4581-a669-06d0f2773b65"), Name = "Freedom", Description = "You liberate yourself and others from shackles and constraints." };
            yield return new Domain { Id = Guid.Parse("bc369149-d7c5-4319-b7d8-8137f9cfdcd8"), Name = "Glyph", Description = "You wield power over written words and symbols." };
            yield return new Domain { Id = Guid.Parse("3b1c75b0-524c-4a08-b04b-9e66b69b42fc"), Name = "Healing", Description = "Your healing magic is particularly potent." };
            yield return new Domain { Id = Guid.Parse("7463725f-9db1-45ce-8bde-57857ab6a2f9"), Name = "Indulgence", Description = "You feast mightily and can shake off the effects of overindulging." };
            yield return new Domain { Id = Guid.Parse("a434a214-22db-4d03-bd31-d2af7f4c4f76"), Name = "Knowledge", Description = "You receive divine insights." };
            yield return new Domain { Id = Guid.Parse("87a70253-a298-467a-92e1-a3be315e34b0"), Name = "Luck", Description = "You’re unnaturally lucky and keep out of harm’s way." };
            yield return new Domain { Id = Guid.Parse("8ab289e9-baf0-407e-80af-280774a66c15"), Name = "Lightning", Description = "You control electricity, thunder, and storms." };
            yield return new Domain { Id = Guid.Parse("9eadaa7c-bb04-4017-a31c-77a5355e0d2c"), Name = "Magic", Description = "You perform the unexpected and inexplicable." };
            yield return new Domain { Id = Guid.Parse("3eb1a047-7ae9-481b-a9ab-675684b2a67e"), Name = "Might", Description = "Your physical power is bolstered by divine strength." };
            yield return new Domain { Id = Guid.Parse("62a8bd3c-1541-43a7-b1ab-5e4c0b63be84"), Name = "Moon", Description = "You command powers associated with the moon." };
            yield return new Domain { Id = Guid.Parse("ab621b51-801a-4e47-9581-c7fa211731b3"), Name = "Nature", Description = "You hold power over animals and plants." };
            yield return new Domain { Id = Guid.Parse("9cc28967-eeee-4300-8723-a1fb61075bbc"), Name = "Nightmares", Description = "You fill minds with horror and dread." };
            yield return new Domain { Id = Guid.Parse("526ee5b8-2123-45ea-9711-123252645561"), Name = "Pain", Description = "You punish those who displease you with the sharp sting of pain." };
            yield return new Domain { Id = Guid.Parse("e3128860-aa47-47ac-a090-8252e83cec96"), Name = "Passion", Description = "You evoke passion, whether as love or lust." };
            yield return new Domain { Id = Guid.Parse("8eb27986-a0a7-433c-90b0-fe992c088bfe"), Name = "Perfection", Description = "You strive to perfect your mind, body, and spirit." };
            yield return new Domain { Id = Guid.Parse("9eafb500-89d8-46ff-b315-856f11aca152"), Name = "Protection", Description = "You ward yourself and others." };
            yield return new Domain { Id = Guid.Parse("4387ee8e-ad61-4d20-817a-deeebc8bb1da"), Name = "Repose", Description = "You ease mental burdens" };
            yield return new Domain { Id = Guid.Parse("433f01f4-387d-4cb7-b327-2b63bf21c16c"), Name = "Secrecy", Description = "You protect secrets and keep them hidden." };
            yield return new Domain { Id = Guid.Parse("d3a39e59-080b-4324-8921-124763c5b6af"), Name = "Sun", Description = "You harness the power of the sun and other light sources, and punish undead." };
            yield return new Domain { Id = Guid.Parse("da053ff5-4d67-4b00-bce6-19eb9a5f94bd"), Name = "Star", Description = "You command the power of the stars." };
            yield return new Domain { Id = Guid.Parse("4c7d189c-915f-4c09-b711-fa65a68a34d7"), Name = "Swarm", Description = "You exert control over masses of creatures." };
            yield return new Domain { Id = Guid.Parse("175bf44e-7909-46eb-b135-a7e97297d8df"), Name = "Soul", Description = "You wield power over the spiritual.." };
            yield return new Domain { Id = Guid.Parse("3658060d-b09b-4e73-b949-0255b77bd07b"), Name = "Time", Description = "You reign over the flow of time." };
            yield return new Domain { Id = Guid.Parse("1a434308-2ec6-4963-aa14-b82efa52fb98"), Name = "Travel", Description = "You have power over movement and journeys." };
            yield return new Domain { Id = Guid.Parse("ce60c9f8-e9a7-42e2-87e5-5d7e5210dbfa"), Name = "Trickery", Description = "You deceive others and cause mischief." };
            yield return new Domain { Id = Guid.Parse("833f560a-af75-49c8-8da6-d4e15a6a18a0"), Name = "Truth", Description = "You pierce lies and discover the truth." };
            yield return new Domain { Id = Guid.Parse("3c78a88a-9b78-4dc7-8f97-231a5788714e"), Name = "Tyranny", Description = "You wield power to rule and enslave others." };
            yield return new Domain { Id = Guid.Parse("8e2fe9d1-c723-4754-8cb3-8955bb0094fc"), Name = "Undeath", Description = "Your magic carries close ties to the undead." };
            yield return new Domain { Id = Guid.Parse("c803d19e-6341-4d09-b96f-2926c23c6bcf"), Name = "Vigil", Description = "You watch over those long passed and guard their secrets." };
            yield return new Domain { Id = Guid.Parse("611f0345-55bd-4632-9bfc-b10a5cf64491"), Name = "Void", Description = "You draw power from emptiness." };
            yield return new Domain { Id = Guid.Parse("e41819f7-aa1b-416f-99c5-62bde7886a79"), Name = "Water", Description = "You control water and bodies of water." };
            yield return new Domain { Id = Guid.Parse("794329a6-ca37-4ec4-b3bf-e979c639d628"), Name = "Wealth", Description = "You hold power over wealth, trade, and treasure." };
            yield return new Domain { Id = Guid.Parse("1fc1a8d3-cf3d-4e81-a1d5-f737a2e747f6"), Name = "Zeal", Description = "Your inner fire increases your combat prowess." };
        }
    }
}
