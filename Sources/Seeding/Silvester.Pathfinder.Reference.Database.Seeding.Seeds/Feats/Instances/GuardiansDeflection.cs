using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GuardiansDeflection : Template
    {
        public static readonly Guid ID = Guid.Parse("4689c609-9978-45ac-82ba-35cdc695e969");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Guardian's Deflection",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within your melee reach is hit by an attack, you can see the attacker, and a +2 circumstance bonus to AC would turn the critical hit into a hit or the hit into a miss.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a37df5fe-cfaf-4a12-893c-095b4daf1a7d"), Type = TextBlockType.Text, Text = $"You use your weapon to deflect the attack against your ally, granting a +2 circumstance bonus to their AC against the triggering attack. This turns the triggering critical hit into a hit, or the triggering hit into a miss." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d383184-2e51-4c41-978a-224866604ed2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
