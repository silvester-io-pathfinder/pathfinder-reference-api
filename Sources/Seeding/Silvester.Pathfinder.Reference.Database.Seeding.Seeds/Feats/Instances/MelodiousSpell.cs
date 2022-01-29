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
    public class MelodiousSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("5f41fd76-4990-4c29-8eb8-dea79b931ddb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Melodious Spell",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b46d5b55-9f2e-4135-9156-7c393f6e5f3a"), Type = TextBlockType.Text, Text = $"You subtly weave your spellcasting into your performance. If the next action you take is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)}, attempt a Performance check against all observers' Perception DCs. If your Performance check is successful against an observer's Perception DC, that observer doesn't notice that you are {ToMarkdownLink<Models.Entities.Rule>("Casting a Spell", Rules.Instances.CastASpell.ID)}, even though normally spells have sensory manifestations that would make spellcasting obvious to those around you, and verbal, somatic, and material components are extremely overt. You hide all of these as part of an ordinary performance." };
            yield return new TextBlock { Id = Guid.Parse("c3beb0a9-86bd-472e-bd79-5e7fe0fcbbc5"), Type = TextBlockType.Text, Text = $"This hides only the spell's spellcasting actions and manifestations, not its effects, so an observer might still see a ray streak out from you or see you vanish." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fa909808-498e-43e0-9307-31740d4c6002"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("47044726-d969-43cf-a6fe-78aebccbaa62"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("ed4ed56a-cbd6-49a7-9700-3f6389259393"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("38784b15-1ed4-442c-9e62-601d0c3c0177"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("424239c1-3711-4e6a-bce1-4689a9ede39c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
