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
    public class EternalBane : Template
    {
        public static readonly Guid ID = Guid.Parse("cb8ec42a-5065-4278-9b58-a140ce9dcdae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eternal Bane",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ac896f8-e0f3-45ef-82c9-8a7841145b59"), Type = TextBlockType.Text, Text = $"A life of evil has made you a nexus for your deity's vile power. You're continuously surrounded by a {ToMarkdownLink<Models.Entities.Spell>("bane", Spells.Instances.Bane.ID)} spell with a spell level equal to half your level (rounded up). The radius is 15 feet, and you can't increase it. You can {ToMarkdownLink<Models.Entities.Action>("Dismiss", Actions.Instances.Dismiss.ID)} the spell; if you do, it returns automatically after 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("302790de-644c-4955-ad9b-067e8447e8d0"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("96f7ac54-05fb-48f3-92a8-03a27cc6cb42"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("7df00d1c-3a49-436f-a1ce-0aa2604ff50d"), Alignments.Instances.NeutralEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("94eda256-6e76-4a8e-a5dc-6526294b0b6b"), Alignments.Instances.ChaoticEvil.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("448e8e89-556a-4af3-8bff-c8ff3151de7e"), Traits.Instances.Cleric.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73aed0f5-db0b-47be-b2a6-540e8bfb79a1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
