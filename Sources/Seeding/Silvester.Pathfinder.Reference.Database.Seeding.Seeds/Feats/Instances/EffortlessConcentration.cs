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
    public class EffortlessConcentration : Template
    {
        public static readonly Guid ID = Guid.Parse("dfc3e197-57ee-4a8e-825e-500226f78dec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Effortless Concentration",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bba2936f-daa6-4f32-a6d0-b05dcbd478c1"), Type = TextBlockType.Text, Text = $"You maintain a spell with hardly a thought. You immediately gain the effects of the {ToMarkdownLink<Models.Entities.Action>("Sustain a Spell", Actions.Instances.SustainASpell.ID)} action, allowing you to extend the duration of one of your active spells." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("53ef7d7a-ecf1-47a5-bdb2-208a4f813410"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("4abe49c1-d7e2-429f-94c4-a3e4f7adde12"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("eee73a03-84d2-42dd-a8da-f560f20f7a0c"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("fbe8c567-5fc8-4d6c-87ea-3e4650adf8cc"), Traits.Instances.Summoner.ID);
            builder.Add(Guid.Parse("2a374c48-1987-4b18-abbb-60215e787102"), Traits.Instances.Witch.ID);
            builder.Add(Guid.Parse("1b101961-8e08-41a8-8eb4-fe94e5a81e3b"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96d29171-7354-47ad-8291-4c2a8e640597"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
