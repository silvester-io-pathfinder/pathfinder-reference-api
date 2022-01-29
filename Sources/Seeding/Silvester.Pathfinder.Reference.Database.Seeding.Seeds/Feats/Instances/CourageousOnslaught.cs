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
    public class CourageousOnslaught : Template
    {
        public static readonly Guid ID = Guid.Parse("c37ac2f3-9a0a-4ec3-83ac-63cd4dbbf5af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courageous Onslaught",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fa1be4b-463e-49eb-aa20-44dd4dd0203e"), Type = TextBlockType.Text, Text = $"You use your performance to orchestrate an onslaught against your enemies. If your next action is to cast the {ToMarkdownLink<Models.Entities.Spell>("inspire courage", Spells.Instances.InspireCourage.ID)} composition cantrip, one ally who gains a status bonus from the spell can immediately use a reaction to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} and then make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("022af4d5-05b3-4371-bde6-3f1c6e5f58c4"), Feats.Instances.CourageousAdvance.ID);
            builder.HaveSpecificFeat(Guid.Parse("de8e05c3-0fd4-4b9c-9116-6bbc99590980"), Feats.Instances.CourageousAssault.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("be543bf3-f24a-41b5-b0fa-b0af65b339b8"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("9d40f419-5534-4f0b-96ef-5502a651dc36"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("ef306f34-def2-44b8-a09f-6d36dc6d9448"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("3182b22d-6035-4129-885a-6f6b5f46c8bf"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fdf0466-819f-4a63-b20f-1a20c292bba7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
