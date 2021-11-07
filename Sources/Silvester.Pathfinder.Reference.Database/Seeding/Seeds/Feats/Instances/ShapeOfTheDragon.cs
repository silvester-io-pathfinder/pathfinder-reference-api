using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShapeOfTheDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("3f202f17-5474-4fa0-82df-5b327ad9cfbc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shape of the Dragon",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff5e4f6d-6388-43ad-befd-e059b61454ce"), Type = TextBlockType.Text, Text = "You’ve discovered how to transform yourself into a dragon. Once per day, you can cast 7th-level (spell: dragon form) as an innate arcane spell, transforming into your chosen type of dragon. The spell automatically heightens to 8th level if you’re 16th level and 9th level if you’re 18th level." };
            yield return new TextBlock { Id = Guid.Parse("5d18c377-edc3-407b-8838-5ac507fce2b4"), Type = TextBlockType.Text, Text = "Any time you score a critical hit with an unarmed (action: Strike) gained from (spell: dragon form), you recharge the spell’s breath weapon immediately." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2770d31a-3055-4172-8360-1e3c5f1db869"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7fc93c89-1f64-4004-891c-144cf6b37163"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
