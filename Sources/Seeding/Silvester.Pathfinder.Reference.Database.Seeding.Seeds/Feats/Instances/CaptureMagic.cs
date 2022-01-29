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
    public class CaptureMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("0391a8bc-214a-486c-9ce1-286425e26bf4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Capture Magic",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You succeed at your save against a foe's harmful spell, or a foe fails a spell attack roll against you from a harmful spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a8a1bca-0979-4aca-938b-90e51bc656a6"), Type = TextBlockType.Text, Text = $"When you resist a spell, you capture some of its magic for your own use. You enter your {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)} stance, using the triggering spell to determine what damage type your {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)} deals. Alternatively, if you're already in {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)}, you can instead amplify its effects temporarily. Until the end of your next turn, you gain a +2 status bonus to the damage from your {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f6cee79b-e8c9-4168-a5a1-4a30da0a12f9"), Feats.Instances.ArcaneCascade.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Magus.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b21e2d1-684d-41ad-ab49-e30a03a657c1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
