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
    public class InventorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("4b89a329-ab80-4775-8944-137a234b5860");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inventor Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have first gained two other feats from the inventor archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f605613-2cba-4410-aec6-b3957b7f4469"), Type = TextBlockType.Text, Text = $"You become trained in Crafting and inventor class DC. You gain the {ToMarkdownLink<Models.Entities.Feat>("Inventor", Feats.Instances.Inventor.ID)} skill feat, even if you don't meet the skill feat's requirements. Choose an innovation. You gain that innovation, though you don't gain any other abilities that modify or use that innovation, such as modifications or {ToMarkdownLink<Models.Entities.Feat>("Explode", Feats.Instances.Explode.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("e74fa3ef-577d-4ff0-8cec-1eb87c40b801"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("52732da5-41a6-4439-9b5d-7916bacfde4c"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("9043b50a-fc90-4af9-aec6-c0a21039e8d7"), Traits.Instances.Dedication.ID);
            builder.Add(Guid.Parse("91931f39-6904-4756-a366-56da07f553dc"), Traits.Instances.Multiclass.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfa186e0-717e-4ebe-a6cf-c0985d9a4a81"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
