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
    public class SingToTheSteel : Template
    {
        public static readonly Guid ID = Guid.Parse("9f672bbe-dcb9-436b-a813-0508233d2216");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sing to the Steel",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3b9b40f2-0b7c-469d-9839-8d08394f8ac2"), Type = TextBlockType.Text, Text = $"You strike magical tones that can turn the tide of combat. You and your allies within 30 feet gain the effects of one of the following runes until the end of your next turn: {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("corrosive", Items.WeaponPropertyRunes.Instances.Corrosive.ID)}, {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("disrupting", Items.WeaponPropertyRunes.Instances.Disrupting.ID)}, {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("flaming", Items.WeaponPropertyRunes.Instances.Flaming.ID)}, {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("frost", Items.WeaponPropertyRunes.Instances.Frost.ID)}, {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("ghost touch", Items.WeaponPropertyRunes.Instances.GhostTouch.ID)}, {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("shock", Items.WeaponPropertyRunes.Instances.Shock.ID)}, or {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("thundering", Items.WeaponPropertyRunes.Instances.Thundering.ID)}. The effects apply to a single weapon the creature is holding or one of the creature's unarmed attacks. You choose the rune and the effect applies to all creatures. You can use an action, which has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait, to extend the duration of the rune for 1 additional round up to a maximum of 1 minute. If this would give a weapon or unarmed attack more property runes than its normal maximum, an existing property rune (as the creature chooses) is suppressed until the spell ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5812bf68-76c0-4ae1-87cd-608c2142795a"), Feats.Instances.NantambuChimeRingerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d5e0cd1-90a4-4e70-ba98-09c05a8d8fc0"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
