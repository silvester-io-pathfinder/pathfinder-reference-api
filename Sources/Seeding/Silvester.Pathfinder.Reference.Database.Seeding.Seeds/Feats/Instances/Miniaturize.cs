using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Miniaturize : Template
    {
        public static readonly Guid ID = Guid.Parse("ba8c8f15-ea6e-4280-a8fa-9104b8f20b50");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Miniaturize",
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
            yield return new TextBlock { Id = Guid.Parse("7ebe2f8f-7d59-44fb-84c1-e100538aa71b"), Type = TextBlockType.Text, Text = "Your eidolon can shrink even further. When using (feat: Shrink Down), your eidolon can reduce its size to Tiny." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a559d105-e6be-4d3f-be64-898f9edf5deb"), Feats.Instances.ShrinkDown.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("861bc8a0-318b-40ad-beee-95b1ec1d9a2e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
