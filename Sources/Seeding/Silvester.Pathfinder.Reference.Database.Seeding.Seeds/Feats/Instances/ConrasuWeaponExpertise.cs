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
    public class ConrasuWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("ca0f2f15-ead5-498c-aba8-d1e64162e1a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conrasu Weapon Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c71b7398-63cb-4ddd-87b2-bb8a88f10ca7"), Type = TextBlockType.Text, Text = $"Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency for {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("composite shortbow", Items.RangedWeapons.Instances.CompositeShortbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("glaive", Items.MeleeWeapons.Instances.Glaive.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longspear", Items.MeleeWeapons.Instances.Longspear.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longsword", Items.MeleeWeapons.Instances.Longsword.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("shortbow", Items.RangedWeapons.Instances.Shortbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spear", Items.MeleeWeapons.Instances.Spear.ID)}, and all conrasu weapons in which you are trained." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6305ef9e-2205-4b2e-b801-1330d208e47b"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
