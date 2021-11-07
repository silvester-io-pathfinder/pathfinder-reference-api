using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BackToBack : Template
    {
        public static readonly Guid ID = Guid.Parse("61fb3225-8856-4c4b-9d67-4758d229d4af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Back to Back",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("181be222-1e9d-46c3-b2be-ebcbeb787b03"), Type = TextBlockType.Text, Text = "You excel at watching your allies’ backs and helping them watch yours. As long as you and an ally are adjacent to each other, neither of you can become flat-footed due to flanking unless both of you are flanked. If you’re adjacent to more than one ally, all eligible allies can benefit at a given time. The benefit is negated for everyone if at least you and any one eligible ally are flanked, but not if your allies are flanked and you aren’t." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("863eb87e-8f88-460d-952f-a4f39fdfdef9"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e77a77bf-e1d5-4cae-a270-15c49b122a7a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
