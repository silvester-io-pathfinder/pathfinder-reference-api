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
    public class ShadowSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("4e3bac6a-2a5d-4143-83f1-c14c32ffaeef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Spells",
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
            yield return new TextBlock { Id = Guid.Parse("6fbb8eb8-dbf6-4dcd-8d1a-290c902d73f0"), Type = TextBlockType.Text, Text = $"Hidden darkness whispers to you, teaching you secrets of shadow beyond other spellcasters of your tradition. Add {ToMarkdownLink<Models.Entities.Spell>("shadow blast", Spells.Instances.ShadowBlast.ID)}, {ToMarkdownLink<Models.Entities.Spell>("shadow siphon", Spells.Instances.ShadowSiphon.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("shadow walk", Spells.Instances.ShadowWalk.ID)} your spell list, as well as {ToMarkdownLink<Models.Entities.Spell>("replicate", Spells.Instances.Replicate.ID)}, {ToMarkdownLink<Models.Entities.Spell>("shadow army", Spells.Instances.ShadowArmy.ID)}, {ToMarkdownLink<Models.Entities.Spell>("shadow projectile", Spells.Instances.ShadowProjectile.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("shadow raid", Spells.Instances.ShadowRaid.ID)}. You can thus potentially learn these spells even if they aren't normally on your tradition's spell list." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e06e169f-9d99-49ee-825e-4fa9e228100f"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("260fba5d-32ff-4dd0-8189-e95aa0baf7e9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
