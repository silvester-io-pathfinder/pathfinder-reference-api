using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpansiveSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("e84f14fc-47a6-4a22-8f06-e34192c51afc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expansive Spellstrike",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8b505c9-eb8f-445d-91fa-560b5cd53b19"), Type = TextBlockType.Text, Text = "You’ve adapted a wider array of spells to work with your attacks. Rather than needing to use a spell that has a spell attack roll for a (feat: Spellstrike), you can use a harmful spell that can target a creature or that has an area of a burst, cone, or line (abiding by any other restrictions of (feat: Spellstrike)). When you (action: Cast a Spell) that doesn’t have a spell attack roll as part of a (feat: Spellstrike), it works in the following ways." };
            yield return new TextBlock { Id = Guid.Parse("826bb41f-fd84-426e-b12d-920f2204f25c"), Type = TextBlockType.Enumeration, Text = " : If your (action: Strike) critically fails, the spell is lost with no effect." };
            yield return new TextBlock { Id = Guid.Parse("9361a8b3-7afc-4dd2-99f4-d48a5319b026"), Type = TextBlockType.Enumeration, Text = " : Creatures use their normal defenses against the spell, such as saving throws." };
            yield return new TextBlock { Id = Guid.Parse("03073860-3f30-467c-9594-aaae7fd6059e"), Type = TextBlockType.Enumeration, Text = " : If the spell lets you select a number of targets, it instead targets only the creature you attacked with your (action: Strike)." };
            yield return new TextBlock { Id = Guid.Parse("234400dd-00e5-4cc3-89be-91655336c59a"), Type = TextBlockType.Enumeration, Text = " : If the spell has an area, the target must be in that area. A burst is centered on a corner of the target’s square, or the square corner closest to the center of the target, if the target is Large or larger; you choose the corner if more than one is eligible. A cone or line emits from you and must include the target; if you’re not adjacent to the target (using a reach weapon or starlit span, for example), choose any square adjacent to the target as the source. The spell affects all creatures in the area as normal, but the (action: Strike) still targets only one creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("82cb56ab-22e6-46a0-bd4d-bbfe9d2d6f9e"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf521a6b-eed9-4406-a87b-6e7b0e93784f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
