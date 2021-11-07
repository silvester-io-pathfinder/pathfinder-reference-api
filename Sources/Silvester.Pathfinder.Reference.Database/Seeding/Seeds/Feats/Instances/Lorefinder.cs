using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Lorefinder : Template
    {
        public static readonly Guid ID = Guid.Parse("72b98b92-27f5-4612-9b82-7aee45c8d804");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lorefinder",
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
            yield return new TextBlock { Id = Guid.Parse("a8310fc5-af46-40eb-ae9d-22b01d4781a5"), Type = TextBlockType.Text, Text = "You know that fate sometimes conspires to keep dangerous knowledge or items from the eyes of those most able to understand them. You deny fate the ability to conceal truths from you. You can cast (spell: locate) as an innate occult spell once per day. When you reach 14th level, this spell is heightened to 5th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f65ca39b-4954-4058-a04e-f11b07365a72"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2ce0cab-feb1-45f3-b6fc-4a5264d30e8d"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
