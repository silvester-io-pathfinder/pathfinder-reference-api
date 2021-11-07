using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnapShot : Template
    {
        public static readonly Guid ID = Guid.Parse("a0c09f9f-291d-4248-b179-039d9b3eef86");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snap Shot",
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
            yield return new TextBlock { Id = Guid.Parse("fda78d21-9590-4f15-817c-998fe41d8304"), Type = TextBlockType.Text, Text = "You’ve learned to react with ranged weapons when a creature is in close quarters. You can use a reaction that normally allows you to make a melee weapon (action: Strike) to instead make a ranged weapon (action: Strike). You must be (action: Striking | Strike) an adjacent target." };
            yield return new TextBlock { Id = Guid.Parse("cbdea848-d269-443c-827c-cf1956eaa259"), Type = TextBlockType.Text, Text = "If necessary for the reaction’s trigger, you treat your ranged weapon as if it had a (trait: reach) of 5 feet. If the reaction has other requirements, such as wielding a specific kind of weapon, Snap Shot doesn’t allow you to ignore them; it allows you only to replace a melee weapon (action: Strike) with a ranged weapon (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cad1f3c-608a-4c2b-8f2d-88ecd001e253"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
