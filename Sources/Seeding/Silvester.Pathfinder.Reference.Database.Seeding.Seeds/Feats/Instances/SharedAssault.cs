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
    public class SharedAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("ed9821db-fe72-4875-b6c7-2d7f2df1d192");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Assault",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ac4fb8eb-9761-424a-9de6-7bd0486557d6"), Type = TextBlockType.Text, Text = $"In the triumph of battle, you can share the glory with another ally. When the ally you chose for {ToMarkdownLink<Models.Entities.Feat>("Courageous Assault", Feats.Instances.CourageousAssault.ID)} critically succeeds at the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} granted by that action, another ally affected by your {ToMarkdownLink<Models.Entities.Spell>("inspire courage", Spells.Instances.InspireCourage.ID)} composition spell can immediately use a reaction to make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. Since the second ally wasn't the ally you chose for {ToMarkdownLink<Models.Entities.Feat>("Courageous Assault", Feats.Instances.CourageousAssault.ID)}, this effect doesn't continue to a third ally, even if the second ally also critically succeeds at their {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("73c73b68-5263-46a2-bb6c-d3ca8daf09df"), Feats.Instances.CourageousAssault.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("05d85045-8e75-448b-9604-9b9cd8d5ca20"), Traits.Instances.Bard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1efc7f77-5e86-47bb-a150-c5e18b849058"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
