using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GuardiansDeflection : Template
    {
        public static readonly Guid ID = Guid.Parse("1e0e1bbc-bdb5-4028-bfd0-1cfa109e2e3a");

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
            yield return new TextBlock { Id = Guid.Parse("08cc9b76-271d-4d73-9ab9-99274234db16"), Type = TextBlockType.Text, Text = "You use your weapon to deflect the attack against your ally, granting a +2 circumstance bonus to their AC against the triggering attack. This turns the triggering critical hit into a hit, or the triggering hit into a miss." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed915f2d-e688-4a3f-b6a9-10d544eaf715"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
