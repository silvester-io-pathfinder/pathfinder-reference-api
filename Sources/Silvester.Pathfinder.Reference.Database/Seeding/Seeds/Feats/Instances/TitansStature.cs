using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TitansStature : Template
    {
        public static readonly Guid ID = Guid.Parse("89865e3b-a3d2-4e05-8cc2-203e06c8e6e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Titan's Stature",
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
            yield return new TextBlock { Id = Guid.Parse("2954adfc-94ba-4787-b1e9-4780e214916b"), Type = TextBlockType.Text, Text = "You grow to even greater size. When using (feat: Giant&#39;s Stature), you can instead become Huge (increasing your reach by 10 feet if you were Medium or smaller) while you are raging. You have the clumsy 1 condition as long as you are Huge." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("7c1943c5-8589-4499-bdb8-4e3d80170009"), Instincts.Instances.GiantInstinct.ID);
            builder.HaveSpecificFeat(Guid.Parse("90dc08aa-feac-426e-9d70-05c3e9a69c7a"), Feats.Instances.GiantsStature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bead136-f0da-4ed9-aefe-4d278bf82c44"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
