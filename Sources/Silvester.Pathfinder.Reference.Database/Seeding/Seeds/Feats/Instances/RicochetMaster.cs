using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RicochetMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("96c965f6-5f91-41b4-a5f5-198885e45287");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricochet Master",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("02c137d1-79cc-460a-8e20-5b2b5bb0964d"), Type = TextBlockType.Text, Text = "You have an eye for angles and can find shots that others believe are impossible. When using (feat: Ricochet Shot), you can bounce your bullet off up to two solid surfaces within your weapon’s first range increment instead of just one." };
            yield return new TextBlock { Id = Guid.Parse("6ff7ffa6-fb75-493c-bf15-faf0e1451d55"), Type = TextBlockType.Text, Text = "In addition, a creature is flat-footed the first time you attack it with a (feat: Ricochet Shot) during an encounter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1b27b759-8806-4f84-a3a7-46b6ded136e1"), Feats.Instances.RicochetShot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2520dd1-3881-4825-ac39-7f29a065f49f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
