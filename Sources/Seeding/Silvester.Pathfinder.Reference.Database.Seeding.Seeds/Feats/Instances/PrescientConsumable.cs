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
    public class PrescientConsumable : Template
    {
        public static readonly Guid ID = Guid.Parse("ca4074e5-918c-49de-9774-d33f038d8c5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prescient Consumable",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d9e83418-2e3d-45f0-b133-39fd059357ef"), Type = TextBlockType.Text, Text = $"You can predict which consumables you might need in advance. When using {ToMarkdownLink<Models.Entities.Feat>("Prescient Planner", Feats.Instances.PrescientPlanner.ID)}, you can procure a consumable item from your backpack, instead of a piece of adventuring gear. The consumable item must still be common with a level no higher than half your level, and its Bulk must be low enough that carrying it wouldn't have made you encumbered." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0173405e-4c02-4b02-bc25-5d9d0bc15867"), Feats.Instances.PrescientPlanner.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a64d97d9-e1d7-4375-8979-9661c6911a11"), Traits.Instances.General.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b6089ee-328c-41cb-94a7-98794e42d761"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
