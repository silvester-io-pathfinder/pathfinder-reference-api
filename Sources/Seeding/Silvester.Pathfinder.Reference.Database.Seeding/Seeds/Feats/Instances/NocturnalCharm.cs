using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NocturnalCharm : Template
    {
        public static readonly Guid ID = Guid.Parse("ad32e073-b3a8-419f-9edb-41a3281c6a14");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nocturnal Charm",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("805e3d0a-e488-4b19-bfd0-5820058ba005"), Type = TextBlockType.Text, Text = "The supernatural charm of your vampiric progenitor hangs about you, and you've learned to use it on mortals. Against humanoids (or other creatures of your type, if you're not a humanoid), you gain a +1 circumstance bonus to Deception checks to (action: Lie), and to Diplomacy checks to (action: Gather Information) and (action: Make an Impression)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c1e6485-d2c8-474a-8c64-96c6645dd44d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
