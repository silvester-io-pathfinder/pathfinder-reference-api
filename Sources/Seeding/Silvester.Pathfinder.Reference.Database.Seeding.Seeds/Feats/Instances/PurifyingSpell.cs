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
    public class PurifyingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("a704dac1-6ed4-4fe2-99c9-f3c171d511e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Purifying Spell",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c98e5928-0414-40be-9dda-8474714f838e"), Type = TextBlockType.Text, Text = $"You purify the water within a creature's body to cleanse them of illness. If the next action you use is to cast {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} targeting a single living creature, you can attempt to counteract a disease or poison affecting the target, in addition to the other benefits of {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)}. If you do, {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} gains the {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)} trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("36be9193-1df0-4d5e-8f2a-a178a93604ae"), DruidicOrders.Instances.Wave.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("3d346787-9da7-478e-9c81-9d79d8409e81"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("3e7a85ae-a45a-4222-b916-84daa6de78f9"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("24dedd0e-ba2e-4335-921e-bd3d37de9e7c"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("1c8a71f5-edfb-4040-a239-5a8f872abbd4"), Traits.Instances.Water.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c974a58b-f04a-4bfc-b4ec-183aba44f276"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
