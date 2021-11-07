using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ContinuousAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("2fdc2371-f2ce-423c-9a11-a7306fd761d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Continuous Assault",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("438573ae-eb7e-4290-8ddf-39d92c38ffd8"), Type = TextBlockType.Text, Text = "You can use (feat: Elemental Assault) once per hour instead of once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2492dfbd-3d97-403c-9db1-59f7716ab154"), Feats.Instances.ElementalAssault.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("617cb5e2-4714-4d50-b54b-6517f24aac38"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
