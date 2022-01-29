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
    public class VikingWeaponSpecialist : Template
    {
        public static readonly Guid ID = Guid.Parse("12841f85-21ea-4e27-9211-86c7f6374916");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Viking Weapon Specialist",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1143292-5360-4d9c-a3d8-2c40dbd4a976"), Type = TextBlockType.Text, Text = $"You are even more skilled in the weapons of your people. You gain the critical specialization effects of the {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("battle axe", Items.MeleeWeapons.Instances.BattleAxe.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("hatchet", Items.MeleeWeapons.Instances.Hatchet.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longsword", Items.MeleeWeapons.Instances.Longsword.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("shortsword", Items.MeleeWeapons.Instances.Shortsword.ID)}. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency rank in the above four weapons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("221dca30-ba03-4b0a-8e6a-b2a0a1969a54"), Feats.Instances.VikingWeaponFamiliarity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f20cf264-1d21-4503-a435-62b9da685fff"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
