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
    public class PirateWeaponTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("bc558e68-7322-44a4-98a5-9cf527406443");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pirate Weapon Training",
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
            yield return new TextBlock { Id = Guid.Parse("030f5233-6fe7-443f-9f6c-8de0f7e6e87f"), Type = TextBlockType.Text, Text = $"You're particularly skilled at wielding traditional pirate weapons. You become trained with the following weapons: {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("hatchet", Items.MeleeWeapons.Instances.Hatchet.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("rapier", Items.MeleeWeapons.Instances.Rapier.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("scimitar", Items.MeleeWeapons.Instances.Scimitar.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("whip", Items.MeleeWeapons.Instances.Whip.ID)}. Whenever you gain a class feature that grants you expert or greater proficiency with a given weapon or weapons, you also gain that proficiency rank for these weapons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("932e0653-578f-4b8d-9252-5b97fc635355"), Feats.Instances.PirateDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("26f15d78-2aee-49da-9297-d0ead0c0f9aa"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9bc03a4-ae3f-4c96-9e25-f158e8070edd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
