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
    public class SunderSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("b7d00f38-09f8-4e12-ad46-ab84f227c91c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sunder Spell",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60b8bc47-deae-4d76-baee-8a3a748e0203"), Type = TextBlockType.Text, Text = $"You draw upon your superstitious fury to destroy a spell. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a melee weapon or an unarmed attack against a creature, object, or a spell manifestation (such as the wall created by {ToMarkdownLink<Models.Entities.Spell>("wall of fire", Spells.Instances.WallOfFire.ID)} or the guardian from {ToMarkdownLink<Models.Entities.Spell>("spiritual guardian", Spells.Instances.SpiritualGuardian.ID)}). If your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, you can attempt to counteract a single spell or magical effect on the target. Your counteract level for this attempt is equal to half your level rounded up, and you use the result of your attack roll for the counteract check." };
            yield return new TextBlock { Id = Guid.Parse("e0fe6585-9374-4b2d-9593-87bc03fc0233"), Type = TextBlockType.Text, Text = $"Whether or not you succeed at your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, the target becomes temporarily immune to your Sunder Spell for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("bf8a9b4d-609c-47ab-98b1-63c5669c3138"), Instincts.Instances.SuperstitionInstinct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b53ac7b2-b11b-4f16-80df-69449997134e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
