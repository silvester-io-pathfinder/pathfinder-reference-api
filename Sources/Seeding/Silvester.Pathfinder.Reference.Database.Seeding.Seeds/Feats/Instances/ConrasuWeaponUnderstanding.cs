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
    public class ConrasuWeaponUnderstanding : Template
    {
        public static readonly Guid ID = Guid.Parse("d4db8a33-6860-45b0-91ee-dd1480131f5f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conrasu Weapon Understanding",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18d1c98c-7936-4fad-9b83-46da3adeadf0"), Type = TextBlockType.Text, Text = $"You have come to know conrasu weapons as you know yourself. Whenever you critically hit using a {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("composite shortbow", Items.RangedWeapons.Instances.CompositeShortbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("glaive", Items.MeleeWeapons.Instances.Glaive.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longspear", Items.MeleeWeapons.Instances.Longspear.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longsword", Items.MeleeWeapons.Instances.Longsword.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("shortbow", Items.RangedWeapons.Instances.Shortbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spear", Items.MeleeWeapons.Instances.Spear.ID)}, or a conrasu weapon, you apply the weapon's critical specialization effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Conrasu.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18f16071-c96b-4467-9224-1773ac3b5a30"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
