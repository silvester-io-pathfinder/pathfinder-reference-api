using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PracticedDefender : Template
    {
        public static readonly Guid ID = Guid.Parse("fa15c209-20e3-41f5-98ad-8487a74b6b96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Practiced Defender",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5232065a-57f2-4a17-ae59-70e29eb357d3"), Type = TextBlockType.Text, Text = "After extensive practice with the Swords, you&#39;re comfortable enough with your shield to move at a normal pace with it raised. You may use the (action: Defend) exploration activity while traveling at your full travel speed instead of half your travel speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("16b0c377-66d0-43c2-bb88-35580ec859ed"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbbfdf8e-3728-4271-aca8-b6c0fce45a79"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
