using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Scarecrow : Template
    {
        public static readonly Guid ID = Guid.Parse("f5b11533-3127-45f8-9f79-7056f5c217a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scarecrow",
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
            yield return new TextBlock { Id = Guid.Parse("a085dd64-bda7-44bf-92cb-abfe89154a66"), Type = TextBlockType.Text, Text = $"You fight fiercely to protect your crop. When you hit a creature that is adjacent to two or more members of your crop with a weapon or unarmed attack, you gain a circumstance bonus to your damage roll equal to the number of weapon damage dice. When you hit a creature who has a member of your crop grabbed, that member can attempt to {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} using a reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b9dfb19d-a859-4098-95e7-2a86b8d1aa5a"), Feats.Instances.BellflowerTillerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("591fb9b8-894b-49c2-9918-376620ed8b30"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
