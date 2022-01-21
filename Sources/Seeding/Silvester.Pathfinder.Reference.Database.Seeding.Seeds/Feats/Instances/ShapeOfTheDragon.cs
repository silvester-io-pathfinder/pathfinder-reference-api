using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShapeOfTheDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("b8935603-df02-4fae-a55e-a23ae8363954");

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
            yield return new TextBlock { Id = Guid.Parse("d761e946-48b6-4b86-9bde-89cb29d6d622"), Type = TextBlockType.Text, Text = "You've discovered how to transform yourself into a dragon. Once per day, you can cast 7th-level (spell: dragon form) as an innate arcane spell, transforming into your chosen type of dragon. The spell automatically heightens to 8th level if you're 16th level and 9th level if you're 18th level." };
            yield return new TextBlock { Id = Guid.Parse("ecef92c1-dffc-4db6-856d-b9ed619657fa"), Type = TextBlockType.Text, Text = "Any time you score a critical hit with an unarmed (action: Strike) gained from (spell: dragon form), you recharge the spell's breath weapon immediately." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("efacea6c-ec39-4fa0-8f2f-8c9a23fd09a8"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0294cac9-cb58-405b-a86e-198e41ea3e8d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
