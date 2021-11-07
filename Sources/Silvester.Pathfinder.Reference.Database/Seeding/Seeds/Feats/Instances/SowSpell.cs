using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SowSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("fe97f305-7b13-4aba-a0aa-4491708c07dd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sow Spell",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46335313-61ac-4629-8f6b-042aab7ad1e5"), Type = TextBlockType.Text, Text = "You fold your spell into a seed. If your next action is to (activity: Cast a Spell) using 1 action or 2 actions, the spell instead plants itself in an adjacent square. You must make all decisions regarding the spell at the time you cast it. Within the next 10 minutes, you can direct your sown spell to sprout and produce the spell’s effects as a reaction, which is triggered when a creature enters the sown spell’s space or a square adjacent to it. You can have only one sown spell at a time, and if you don’t trigger the spell within 10 minutes, it dissipates and the spell is lost. A creature can notice the sown spell with a successful Perception check against your spell DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6c9eaa8-e5d6-429e-a91b-d8f3822fb786"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
