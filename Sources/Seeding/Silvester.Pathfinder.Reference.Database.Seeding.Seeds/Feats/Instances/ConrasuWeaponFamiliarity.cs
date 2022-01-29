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
    public class ConrasuWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("41455c3f-203e-4dd9-acae-6513c9d1a54b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conrasu Weapon Familiarity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a120ec3d-1799-42c5-8659-98656f9a1555"), Type = TextBlockType.Text, Text = $"You have taken it upon yourself to learn the ways of combat to aid with your tasks, perhaps in a role as a corrector. You are trained with the {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("composite shortbow", Items.RangedWeapons.Instances.CompositeShortbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("glaive", Items.MeleeWeapons.Instances.Glaive.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longspear", Items.MeleeWeapons.Instances.Longspear.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longsword", Items.MeleeWeapons.Instances.Longsword.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("shortbow", Items.RangedWeapons.Instances.Shortbow.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spear", Items.MeleeWeapons.Instances.Spear.ID)}. You also gain access to all uncommon conrasu weapons. For the purpose of determining your proficiency, martial conrasu weapons are simple weapons and advanced conrasu weapons are martial weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("076b7a89-20e2-4a8b-ad98-79882f8e2ce6"), Traits.Instances.Conrasu.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7e470f2-0e11-4aa5-be11-332339895ee8"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
