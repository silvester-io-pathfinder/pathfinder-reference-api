using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationHeavyConstruction : Template
    {
        public static readonly Guid ID = Guid.Parse("11d1b38f-216c-4d13-a4bd-d03b6adf71b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Heavy Construction",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7f6272d-1d15-4fed-a89a-273c323b2413"), Type = TextBlockType.Enumeration, Text = "*Power Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("c7728f2f-3e61-4e13-8e7d-17bf90227c65"), Type = TextBlockType.Text, Text = "You've expanded your innovation into a heavy bulwark, and your groundbreaking design ensures you don't take any of the drawbacks for such heavy defenses. Your innovation becomes heavy armor, and your proficiency in your innovation armor (but no other heavy armor) advances to be equal to your proficiency in medium armor. If your Strength score is at least 16, you remove the Speed penalty entirely instead of reducing it to –5 feet. The armor's adjusted statistics are: __AC Bonus__ +5; __Dex Cap__ +1; __Check Penalty__ –2; __Speed Penalty__ –10 feet; __Strength__ 16; __Bulk__ 3; __Group__ composite; __Armor Traits__ (trait: bulwark)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3a594ef-717f-44cb-9916-c5c1068f3c5c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
