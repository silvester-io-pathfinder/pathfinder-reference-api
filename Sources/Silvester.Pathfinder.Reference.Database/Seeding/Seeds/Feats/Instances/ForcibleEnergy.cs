using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForcibleEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("89594b94-c080-4c7b-adea-cdae235bd87c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forcible Energy",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4d5ec9e-67f3-4e52-a41a-567e3123c310"), Type = TextBlockType.Text, Text = "You perform complex manipulations to make the energy from your spells so powerful that your enemies remain vulnerable to it afterward. If your next action is to (activity: Cast a Spell) that deals acid, electricity, fire, or sonic damage, you can select one target that was damaged to gain weakness 5 to that damage type until the end of your next turn. If a spell deals multiple types of energy damage, choose one that the target gains weakness to. This has no effect on creatures with resistance or immunity to the energy type you choose." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa13d960-286b-4c33-8a41-237d263c6d9d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
