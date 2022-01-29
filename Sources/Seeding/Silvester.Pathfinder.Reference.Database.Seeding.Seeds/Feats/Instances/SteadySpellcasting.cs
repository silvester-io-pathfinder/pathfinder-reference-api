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
            builder.Add(Guid.Parse(""), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Oracle.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Witch.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Wizard.ID);

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
