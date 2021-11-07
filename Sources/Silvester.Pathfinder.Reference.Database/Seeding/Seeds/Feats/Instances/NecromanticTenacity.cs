using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NecromanticTenacity : Template
    {
        public static readonly Guid ID = Guid.Parse("85e34810-8023-434b-a15e-22dab531ae3a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Necromantic Tenacity",
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
            yield return new TextBlock { Id = Guid.Parse("ca16168c-0cd6-4609-b90b-3a3c4cd88a0b"), Type = TextBlockType.Text, Text = "Your training against necromantic effects allows you to escape the worst of their touch. If you roll a success on a saving throw against a (trait: necromancy) effect, you get a critical success instead; if you roll a critical failure on such a save, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5f1904e3-4916-47e4-8e21-c77442386cf3"), Feats.Instances.NecromanticResistance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d207c5e6-7b60-4635-8d79-bae06d49822d"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
