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
    public class MastersCounterspell : Template
    {
        public static readonly Guid ID = Guid.Parse("6eee7fb4-f6c9-4f70-a0be-991a29294122");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master's Counterspell",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature Casts a Spell that you have prepared or is in your repertoire, and that spell was cast or created with a tradition of magic in which you have master proficiency in spell attack rolls and spell DCs.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fb8fd77-8782-4056-88d1-dbacc46d3397"), Type = TextBlockType.Text, Text = $"When a foe {ToMarkdownLink<Models.Entities.Rule>("Casts a Spell", Rules.Instances.CastASpell.ID)} and you can see its manifestations, you can use your magic to disrupt it. If you're a prepared caster, you can expend a prepared spell to counter the triggering creature's casting of a spell. If you're a spontaneous caster, you can expend a spell slot. The level of the prepared spell or spell slot must be at least as high as the triggering spell's level. You lose your prepared spell or spell slot as if you had {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)}. You then attempt to counteract the triggering spell, and you take a -2 penalty to your counteract check; for prepared casters, the GM might waive the penalty if the spell you're expending to counterspell is especially appropriate – such as countering with the same spell, or using a {ToMarkdownLink<Models.Entities.Spell>("cone of cold", Spells.Instances.ConeOfCold.ID)} to counteract a {ToMarkdownLink<Models.Entities.Spell>("fireball", Spells.Instances.Fireball.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8f865101-2f0f-488b-b753-89e51d618cd9"), Feats.Instances.SpellmasterDedication.ID);
            builder.HaveSpecificSpellAttackProficiency(Guid.Parse("e08d9fc6-884f-4acc-8b62-22b9890bbe45"), Proficiencies.Instances.Master.ID);
            builder.HaveSpecificSpellDcProficiency(Guid.Parse("0d3c0c8e-618a-4781-a89c-a0a9fdee3ea6"), Proficiencies.Instances.Master.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91246934-9644-4889-b353-b1bd1f8e47d8"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
