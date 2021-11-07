using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IncredibleLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("3ea0da5e-5a0c-4461-ade2-704d30b55a6b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Luck",
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
            yield return new TextBlock { Id = Guid.Parse("214adacc-17ba-4d0f-80d9-cb5e68a26760"), Type = TextBlockType.Text, Text = "Even other halflings consider you to be particularly lucky. You can use (feat: Halfling Luck) once per hour, rather than once per day. If you have (feat: Guiding Luck), you can still use (feat: Halfling Luck) when you fail a Perception check or attack roll only once per day (though you can use it within the same hour that you used (feat: Halfling Luck)), and if you have (feat: Helpful Halfling), you can still use (feat: Halfling Luck) on an ally instead of yourself only once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e2687507-f32f-4d48-a67b-196f11e9fff1"), Feats.Instances.HalflingLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03d9bd36-7d1e-4043-9010-e3627a050ae0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
