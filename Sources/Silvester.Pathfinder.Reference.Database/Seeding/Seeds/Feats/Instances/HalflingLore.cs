using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalflingLore : Template
    {
        public static readonly Guid ID = Guid.Parse("2106761a-04b2-40df-a268-4b944f1d65ae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halfling Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("24fa3df1-02b8-414b-af90-dd208d14bebb"), Type = TextBlockType.Text, Text = "You’ve dutifully learned how to keep your balance and how to stick to the shadows where it’s safe, important skills passed down through generations of halfling tradition. You gain the trained proficiency rank in Acrobatics and Stealth. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Halfling Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9865a9c3-36e3-4158-b9ce-9c1b4ade4238"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
