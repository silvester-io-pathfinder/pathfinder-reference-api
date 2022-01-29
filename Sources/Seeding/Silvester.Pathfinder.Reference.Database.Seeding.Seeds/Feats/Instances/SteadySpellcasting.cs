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
    public class SteadySpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("98cf0254-7e0d-4e83-86ca-46726f24baa4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steady Spellcasting",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d7d67b3-51b2-410f-994b-0154cd38f908"), Type = TextBlockType.Text, Text = $"Confident in your technique, you don't easily lose your concentration when you {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)}. If a reaction would disrupt your spellcasting action, attempt a DC 15 flat check. If you succeed, your action isn't disrupted." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("29569606-d81e-419c-bf56-b69eb8f2592a"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("56323e0f-2007-4f83-a989-1a773a62d0b7"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("279bf225-17a0-4567-a56e-47b26f409474"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("63adc06d-1c28-43ac-9bac-b06d51bd69e0"), Traits.Instances.Oracle.ID);
            builder.Add(Guid.Parse("4f01fb1c-201d-4bd4-994c-db1954ae5984"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("93d62642-5f9a-4206-90f1-6756579101d6"), Traits.Instances.Witch.ID);
            builder.Add(Guid.Parse("e9086d81-78c5-4845-8c89-67bfb319631a"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b3c277d-cd8b-42a5-bf22-33561995e60d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
