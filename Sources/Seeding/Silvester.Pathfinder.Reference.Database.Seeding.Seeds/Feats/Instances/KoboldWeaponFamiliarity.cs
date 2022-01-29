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
    public class KoboldWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("7c00313d-1ab8-46fb-ba00-72fee758bc07");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kobold Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("164bca68-0989-4b52-93b7-322c24ca7ed1"), Type = TextBlockType.Text, Text = $"You've trained with weapons ideal for subterranean efficiency. You are trained with the {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("crossbow", Items.RangedWeapons.Instances.Crossbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("greatpick", Items.MeleeWeapons.Instances.Greatpick.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("light pick", Items.MeleeWeapons.Instances.LightPick.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("pick", Items.MeleeWeapons.Instances.Pick.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spear", Items.MeleeWeapons.Instances.Spear.ID)}. You also gain access to all uncommon kobold weapons. For the purpose of determining your proficiency, martial kobold weapons are simple weapons, and advanced kobold weapons are martial weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6ad1d6e-3bf3-4b17-a3d7-2bb799553143"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
