using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NecromanticResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("82573127-026b-42e0-ba1a-23d707e86b2a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Necromantic Resistance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47f95a05-2bee-4c8b-ba68-4375aad185b9"), Type = TextBlockType.Text, Text = "As part of your training, you’ve inured yourself against necromancy through repeated exposure. You gain a +1 circumstance bonus to saves against (trait: necromancy) effects and gain resistance to negative damage equal to half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("271e9428-3d41-44a6-a363-2d813e6de4ae"), Feats.Instances.LastwallSentryDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acee9e3c-e208-4db6-8675-a5faf476dade"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
