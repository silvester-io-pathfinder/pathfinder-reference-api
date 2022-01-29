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
    public class RetainAbsorbedSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("18f477b0-ee82-4ebd-a541-718c467b83c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Retain Absorbed Spell",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0428e32f-b59a-4cf9-ba91-7d112bbce0a4"), Type = TextBlockType.Text, Text = $"When you absorb a spell using the {ToMarkdownLink<Models.Entities.Feat>("Absorb Spell", Feats.Instances.AbsorbSpell.ID)} reaction, you utilize secret, techniques that allow you to retain the power and knowledge necessary to cast the spell repeatedly – potentially for a greater period of time. If you're a spontaneous caster, you can cast the triggering spell up to three times instead of once. If you're a prepared spellcaster, you can replace up to three of your prepared spells of the same level with the absorbed spell instead of one. Either way, you can choose to retain the absorbed spell for the next hour instead of the next 10 minutes; if you choose to extend the absorption to an hour, you can't use {ToMarkdownLink<Models.Entities.Feat>("Absorb Spell", Feats.Instances.AbsorbSpell.ID)} again until one hour after the spell is absorbed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bcf24544-744a-49d8-be94-3b09ae043b77"), Feats.Instances.AbsorbSpell.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("78eece4b-1a34-4c10-badd-a846d63ab7d4"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae646cdc-7b01-4d1c-b47a-f4c784d4ff84"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
