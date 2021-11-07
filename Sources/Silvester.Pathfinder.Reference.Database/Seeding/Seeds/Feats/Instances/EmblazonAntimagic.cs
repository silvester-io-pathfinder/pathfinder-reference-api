using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmblazonAntimagic : Template
    {
        public static readonly Guid ID = Guid.Parse("5ecd1dec-70b5-4afa-8e8a-9fd90b8348e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emblazon Antimagic",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d956d4d2-ded7-4402-bc90-fa25ee4d1369"), Type = TextBlockType.Text, Text = "Your deity’s symbol protects against offensive magic. When you (action: Emblazon an Armament | Emblazon Armament), you can choose from the following effects instead of the effects listed in that feat." };
            yield return new TextBlock { Id = Guid.Parse("ac7bf523-4afe-410b-8607-3f9a8f2f9c7c"), Type = TextBlockType.Text, Text = "These effects have the same restrictions as the base options." };
            yield return new TextBlock { Id = Guid.Parse("0ca994b2-111c-40c0-a7f4-d242e99eeb07"), Type = TextBlockType.Enumeration, Text = " Shield: When the wielder has the shield raised, they gain the shield’s circumstance bonus to saving throws against magic, and they can use (action: Shield Block) against damage from their enemies’ spells." };
            yield return new TextBlock { Id = Guid.Parse("ed5d3535-32e5-46a5-af97-7a3bdfde7691"), Type = TextBlockType.Enumeration, Text = " Weapon: When the weapon’s wielder critically hits with the weapon, they can attempt to counteract a spell on their target, the counteract level is equal to half your level, rounded up. If they attempt to do so, the emblazoned symbol immediately disappears." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("47a9b5a9-6e0d-43bd-b8d8-f25350b99b57"), Feats.Instances.EmblazonArmament.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20462dd7-ecab-4d35-9884-b945a46ca0a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
