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
    public class GnollWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("df0ca9cc-0e26-4e09-ad5c-721d669c3328");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnoll Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("adb4ff80-e65a-44e7-be24-2ca1e93fd6fe"), Type = TextBlockType.Text, Text = $"You were taught to be a hunter and a raider. You are trained with {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("flails", Items.MeleeWeapons.Instances.Flail.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("khopeshes", Items.MeleeWeapons.Instances.Khopesh.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("mambeles", Items.MeleeWeapons.Instances.Mambele.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spears", Items.MeleeWeapons.Instances.Spear.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("war flails", Items.MeleeWeapons.Instances.WarFlail.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e01e51d5-8df6-4d15-b737-d35e9703910d"), Traits.Instances.Gnoll.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3176c5c2-3668-4cff-9c11-5594e4e86f37"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
