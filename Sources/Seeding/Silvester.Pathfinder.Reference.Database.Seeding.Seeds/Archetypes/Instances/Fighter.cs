using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Fighter : Template
    {
        public static readonly Guid ID = Guid.Parse("58c832b9-77a4-40e0-818a-9b92cb4237cc");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Fighter",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.FighterDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3d171b52-361b-40fb-90c6-0971fa308374"), Type = TextBlockType.Text, Text = "You have spent time learning the art of warfare, increasing your skill with martial arms and at wearing armor. With further training, you can become a true combat specialist." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a47c5cf7-b8e5-49d6-ab31-546516bd8f20"), Type = TextBlockType.Text, Text = "The fighter archetype grants access to great feats for characters focusing on any combat style, and it�s particularly helpful for characters looking to diversify their offensive abilities or focus on more powerful weapons." };
            yield return new TextBlock { Id = Guid.Parse("5b44d6e1-a5ec-42d9-b6fa-1564bf35786b"), Type = TextBlockType.Enumeration, Text = "Barbarian fighters can combine their talents with two - handed weapons with some of the fighter�s two - handed feats to devastating effect." };
            yield return new TextBlock { Id = Guid.Parse("aca71a3b-4456-47b5-98cd-100b4ddf5c3e"), Type = TextBlockType.Enumeration, Text = "Champion fighters focus on a style of combat exemplified by their deity.A shield -using champion benefits from the best of both worlds in shield feats." };
            yield return new TextBlock { Id = Guid.Parse("9dbd2ff1-6550-495d-b610-894ea3092d46"), Type = TextBlockType.Enumeration, Text = "Monk fighters are great at combining unusual weapon styles. For instance, a monks isn�t hindered by a restriction to keep one hand free, because they want to punch you with that hand anyway." };
            yield return new TextBlock { Id = Guid.Parse("5091f85a-0270-43ca-8672-a6738770e24a"), Type = TextBlockType.Enumeration, Text = "Ranger fighters can either specialize in archery or use their fighter feats to pick up an unusual combat style combination." };
            yield return new TextBlock { Id = Guid.Parse("566680c1-eaea-406b-af48-32190022ae2c"), Type = TextBlockType.Enumeration, Text = "Rogue fighters can make good use of fighter�s free hand, two-weapon fighting, or archery feats." };
            yield return new TextBlock { Id = Guid.Parse("61075d73-e6f1-488a-a364-516e34748763"), Type = TextBlockType.Enumeration, Text = "Spellcaster fighters benefit greatly from the additional weapon proficiencies, and fighter is a solid choice for any spellcaster of a particularly martial bent." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2503b13e-e2bf-4022-8068-dfc549af845d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 226
            };
        }
    }
}
